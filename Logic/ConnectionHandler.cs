using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
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
    //this class will connect to the server and will be in charge of handling the data transfer to DataManager by calling its Function when connection is establised
    public class ConnectionHandler
    {
        private static ManualResetEvent responseReceivedEvent = new ManualResetEvent(false);


        public static SimpleSocketClient _client;
        private static bool _encrypt;
        private static bool _compress;
        private static MessageA _messageAContract;
        private static ProgressBar progress;

        private static bool authorized = false;


        public static void initConnection(string ip)
        {
            _encrypt = false;
            _compress = true;
            var jsonSer = new MessageTesting.JsonSerialization();
            var xmlSer = new XmlSerialization();
            var binSer = new BinarySerializer();
            _client = new SimpleSocketTcpClient();
            _client.ObjectSerializer = jsonSer;
            _client.EnableExtendedAuth = true;
            _client.AllowReceivingFiles = true;
            _messageAContract = new MessageA("MessageAHeader");
            _client.AddMessageContract(_messageAContract);
            _messageAContract.OnMessageReceived += MessageAContractOnOnMessageReceived;
            BindEvents();
            _client.StartClient(ip, 9999);
        }



        //Event for MessageContract
        //The clientId is only used on the server side. Here it will return -1
        private static void MessageAContractOnOnMessageReceived(SimpleSocket client, IClientInfo clientInfo, object message, string header)
        {
            WriteLine("MessageContract received with header: " + header + " and with message " + message.ToString());
        }
        //
        //requestSubject can be one of those:
        //equipment - regard equipment such as add equipment, delete equipment
        //mission - regard missions, such as add missions, delete missions
        //solider - regard soliders and their premissions
        public static void SendRequest(string requestSubject, string request, object dataToServer)
        {
            
            requestObject requestToServer = new requestObject();
            responseObject responseFromServer = new responseObject();
            requestToServer = new requestObject();
            requestToServer.ID = localCardential.username;
            requestToServer.requestSubject = requestSubject;
            requestToServer.request = request;
            requestToServer.data = dataToServer;
            SendObject(requestToServer);
            
        }

        private static async void SendObject(requestObject requestToServer)
        {
            responseReceivedEvent.Reset();
            try
            {
                await _client.SendObjectAsync(requestToServer, true, true, false);

            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Timeout while sending request to server.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            responseReceivedEvent.WaitOne();
        }


        #region Events

        private static void BindEvents()
        {
            //_client.ProgressFileReceived += Progress;
            _client.SslAuthStatus += ClientOnAuthStatus;
            _client.DisconnectedFromServer += Disconnected;
            _client.ConnectedToServer += ConnectedToServer;
            _client.ClientErrorThrown += ErrorThrown;
            _client.MessageReceived += ServerMessageReceived;
            _client.MessageSubmitted += ClientMessageSubmitted;
            _client.MessageFailed += MessageFailed;
            _client.ObjectReceived += ClientOnObjectReceived;
        }

        private static void ClientOnAuthStatus(AuthStatus status)
        {
            if (status == AuthStatus.Failed)
                WriteLine("Failed to authenticate.");
            if (status == AuthStatus.Success)
                WriteLine("Authenticated with success.");
        }

        private static void ClientOnObjectReceived(SimpleSocketClient a, object obj, Type objType)
        {
            responseReceivedEvent.Set();
            responseObject responseFromServer = new responseObject();
            string x = obj.GetType().Name;
            string jsonRequest = obj.ToString();
            responseFromServer = JObject.Parse(jsonRequest).ToObject<responseObject>();
            authorizationByResponse(responseFromServer);
            responseHandler(responseFromServer);
        }

        private static void ErrorThrown(SimpleSocket socketClient, Exception error)
        {
            WriteLine("The client has thrown an error: " + error.Message);
            WriteLine("Stacktrace: " + error.StackTrace);
        }

        private static void ConnectedToServer(SimpleSocket a)
        {
            WriteLine("The client has connected to the server on ip " + a.Ip);
            //

        }

        private static void ServerMessageReceived(SimpleSocket a, string msg)
        {
            WriteLine("Message received from the server: " + msg);
        }

        private static void Disconnected(SimpleSocket a)
        {
            WriteLine("The client has disconnected from the server with ip " + a.Ip + "on port " + a.Port);
        }

        private static void ClientMessageSubmitted(SimpleSocket a, bool close)
        {
            WriteLine("The client has submitted a message to the server.");
        }

        private static void MessageFailed(SimpleSocket tcpClient, byte[] messageData, Exception exception)
        {
            WriteLine("The client has failed to send a message.");
            WriteLine("Error: " + exception);
        }

        #endregion

        private static void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
        private static void authorizationByResponse(responseObject responseFromServer)
        {
            authorized = false;
            if (responseFromServer.authorized)
            {
                //Console.WriteLine("Authorization successful!");
                authorized = true;
            }
            else
            {
                MessageBox.Show("Authorization failed. Exiting program.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0); // Close the program
            }
        }
        public static object responseHandler(responseObject responseFromServer)
        {
            switch (responseFromServer.requestSubject)
            {
                case "solider":
                    solidersResponse.solidersResponseHandler(responseFromServer);
                    break;

                case "equipment":
                    equipmentResponse.equipmentResponseHandler(responseFromServer);
                    break;

                case "mission":
                    missionResponse.missionResponseHandler(responseFromServer);
                    break;
                case "signature":
                    SignatureResponse.SignatureResponseHandler(responseFromServer);
                    break;

                default:
                    break;
            }
            return "";
        }

    }
}
