using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Ocsp;
using Tikshuv.Logic.Handlers;
using System.Text.Json;
using System.Web;
using System.IO.Compression;
using MessageTesting;
using SimpleSockets.Client;
using SimpleSockets.Messaging.Metadata;
using SimpleSockets.Messaging;
using SimpleSockets;
using System.Text.Json.Nodes;

namespace Tikshuv.Logic
{
    public class experimentalSndMessages
    {
        public class requestObject : Tikshuv.Logic.requestObject
        {
            
        }

        public class responseObject : Tikshuv.Logic.responseObject
        {

        }

        public class ConnectionHandler
        {
            private static SimpleSocketClient _client;
            private static bool _encrypt = false;
            private static bool _compress = true;
            private static readonly object _lock = new object();
            private static string localCardentialUsername = localCardential.username; // Replace with actual username or configuration

            public static void initConnection(string ip = "127.0.0.1",int port = 25367)
            {
                try
                {
                    _client = new SimpleSocketTcpClient();
                    _client.ObjectSerializer = new JsonSerialization();
                    _client.EnableExtendedAuth = true;
                    _client.AllowReceivingFiles = true;
                    BindEvents();
                    _client.StartClient(ip, port);
                    Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Connected to {ip}:25367");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Failed to connect to {ip}:25367 - {ex.Message}");
                    throw;
                }
            }

            private static void BindEvents()
            {
                _client.ConnectedToServer += (clientInfo) => Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Connected to server: ID={clientInfo.Port}, IPv4={clientInfo.Ip}");
                _client.DisconnectedFromServer += (reason) => Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Disconnected: Reason={reason}");
                _client.MessageReceived += (clientInfo, msg) => Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Received message: {msg}");
                _client.ClientErrorThrown += (clientInfo, ex) => Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Error: {ex.Message}");
            }

            public static async Task<responseObject> SendRequest(string requestSubject, string request, object dataToServer)
            {
                requestObject requestToServer = new requestObject
                {
                    ID = localCardentialUsername,
                    requestSubject = requestSubject,
                    request = request,
                    data = dataToServer
                };

                return await SendObject(requestToServer);
            }

            private static async Task<responseObject> SendObject(requestObject requestToServer)
            {
                if (_client == null || !_client.IsConnected())
                {
                    throw new InvalidOperationException("ClientEX is not connected to the server.");
                }

                TaskCompletionSource<responseObject> tcs = new TaskCompletionSource<responseObject>();

                ObjectReceivedDelegate responseHandler = null;
                responseHandler = (clientInfo, obj, objType) =>
                {
                    lock (_lock)
                    {
                        try
                        {
                            if (obj is JObject jObject)
                            {
                                responseObject response = jObject.ToObject<responseObject>();
                                Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Received response: Subject={response.requestSubject}, Request={response.request}, Data={response.data}, Authorized={response.authorized}");
                                _client.ObjectReceived -= responseHandler;
                                tcs.SetResult(response);
                            }
                            else
                            {
                                Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Received unexpected object type: {objType.Name}, Raw: {obj}");
                                _client.ObjectReceived -= responseHandler;
                                tcs.SetException(new InvalidOperationException($"Expected JObject, received {objType.Name}"));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Error deserializing response: {ex.Message}");
                            _client.ObjectReceived -= responseHandler;
                            tcs.SetException(ex);
                        }
                    }
                };
                _client.ObjectReceived += responseHandler;

                try
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(requestToServer);
                    Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Sending request: Subject={requestToServer.requestSubject}, Request={requestToServer.request}, Data={requestToServer.data}, JSON={json}");
                    Task sendTask = _client.SendObjectAsync(requestToServer, _compress, _encrypt, false);
                    await sendTask.ContinueWith(task =>
                    {
                        if (task.IsFaulted)
                        {
                            lock (_lock)
                            {
                                _client.ObjectReceived -= responseHandler;
                                tcs.SetException(task.Exception?.InnerException ?? new Exception($"Failed to send requestEX: {task.Exception?.Message}"));
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    lock (_lock)
                    {
                        _client.ObjectReceived -= responseHandler;
                        tcs.SetException(ex);
                    }
                }

                bool received = tcs.Task.Wait(TimeSpan.FromSeconds(30));
                if (!received)
                {
                    lock (_lock)
                    {
                        _client.ObjectReceived -= responseHandler;
                    }
                    throw new TimeoutException("No responseEX received from server within the timeout period.");
                }

                return await tcs.Task;
            }

            public static async Task TestSendMessage()
            {
                if (_client == null || !_client.IsConnected())
                {
                    throw new InvalidOperationException("ClientEX is not connected.");
                }
                await _client.SendMessageAsync("Test message", _compress, _encrypt, false);
                Console.WriteLine($"[ClientEX {DateTime.Now:HH:mm:ss}] Sent test message");
            }
        }

    }
}

