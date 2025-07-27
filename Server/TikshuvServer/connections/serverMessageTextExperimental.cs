using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SimpleSockets;
using SimpleSockets.Server;
using SimpleSockets.Messaging.Metadata;
using MessageTesting;

namespace TikshuvServer.connections
{
    internal class serverMessageTextExperimental
    {
        public class requestObject : TikshuvServer.requestObject
        {
            
        }

        public class responseObject : TikshuvServer.responseObject
        {
            
        }

        public static class signatureRequestHandling
        {
            public static object[] signatureRequestFromClient(requestObject request)
            {
                Console.WriteLine($"[ServerEx {DateTime.Now:HH:mm:ss}] Handling signature request: {request.request}, Data: {request.data}");
                // Simulate processing
                object data = $"Processed {request.data}";
                bool authorized = true;
                return new object[] { data, authorized };
            }
        }

        public class Server
        {
            private static SimpleSocketListener _listener;
            private static bool _encrypt = false;
            private static bool _compress = true;

            public static void SetupServer(string ip = "127.0.0.1", int port = 25367)
            {
                try
                {
                    _listener = new SimpleSocketTcpListener();
                    _listener.ObjectSerializer = new JsonSerialization();
                    _listener.AllowReceivingFiles = true;
                    BindEvents();
                    _listener.StartListening(ip, port);
                    WriteLine($"Server experimental started listening on {ip}:{port}");
                }
                catch (Exception ex)
                {
                    WriteLine($"Failed to start server: {ex.Message}");
                    throw;
                }
            }

            private static void BindEvents()
            {
                _listener.ClientConnected += (client) => WriteLine($"Client EX {client.Id} (IPv4: {client.RemoteIPv4}) connected.");
                _listener.ClientDisconnected += (client, reason) => WriteLine($"Client EX {client?.Id} disconnected: {reason}");
                _listener.ObjectReceived += ListenerOnObjectReceived;
                _listener.ServerErrorThrown += (ex) => WriteLine($"Server EX error: {ex.Message}");
                _listener.MessageReceived += (client, msg) => WriteLine($"Received message from client EX {client.Id}: {msg}");
            }

            private static void ListenerOnObjectReceived(IClientInfo client, object obj, Type objType)
            {
                WriteLine($"Received object from client EX {client.Id}, type: {objType.Name}, raw: {obj}");
                try
                {
                    if (obj is JObject jObject)
                    {
                        requestObject requestFromClient = jObject.ToObject<requestObject>();
                        WriteLine($"Deserialized request: ID={requestFromClient.ID}, Subject={requestFromClient.requestSubject}, Request={requestFromClient.request}, Data={requestFromClient.data}");
                        responseObject responseToClient = MessageHandler(requestFromClient);
                        SendObject(client, responseToClient);
                    }
                    else
                    {
                        WriteLine($"Error: Received object is not a valid requestObjectEX, type: {objType.Name}");
                    }
                }
                catch (Exception ex)
                {
                    WriteLine($"Error processing object from clientEX {client.Id}: {ex.Message}");
                }
            }

            private static async void SendObject(IClientInfo client, responseObject responseToClient)
            {
                try
                {
                    await _listener.SendObjectAsync(client.Id, responseToClient, _compress, _encrypt, false);
                    WriteLine($"Sent response to clientEX {client.Id}: Subject={responseToClient.requestSubject}, Request={responseToClient.request}");
                }
                catch (Exception ex)
                {
                    WriteLine($"Failed to send response to clientEX {client.Id}: {ex.Message}");
                }
            }

            private static responseObject MessageHandler(requestObject requestFromClient)
            {
                WriteLine($"Processing request: Subject={requestFromClient.requestSubject}, Request={requestFromClient.request}, Data={requestFromClient.data}");
                responseObject responseToClient = new responseObject
                {
                    request = requestFromClient.request,
                    requestSubject = requestFromClient.requestSubject
                };

                if (requestFromClient.requestSubject.Equals("signature"))
                {
                    object[] array = TikshuvServer.signatureManagment.signatureRequestHandling.signatureRequestFromClient(requestFromClient);
                    responseToClient.data = array[0];
                    responseToClient.authorized = Convert.ToBoolean(array[1]);
                }
                else
                {
                    responseToClient.data = null;
                    responseToClient.authorized = false;
                }
                return responseToClient;
            }

            private static void WriteLine(string text)
            {
                Console.WriteLine($"[Server EX {DateTime.Now:HH:mm:ss}] {text}");
            }
        }
    }
}
