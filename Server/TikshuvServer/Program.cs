using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;
using TikshuvServer;
using TikshuvServer.Files;


namespace TikshuvServer
{
    class Program
    {
        public static DataBase mainDataBase = new DataBase();
        //private static byte[] _buffer = new byte[1024];
        //private static List<Socket> _clientSockets = new List<Socket>();
        //private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            mainDataBase = new DataBase();
            DataBase.initDataBase();
            soliderRequestHandling.initSolidersToMemory();
            equipmentRequestHandling.initEquipmentToMemory();
            missionRequestHandling.initMissionToMemory();
            signatureManagment.signatureRequestHandling.initSignatureToMemory();
            PremissionReader.initSettingFile();

            string ip = settingFile.GetValueFromFile(PremissionReader.path, "ServerIp").ToString();
            object value = settingFile.GetValueFromFile(PremissionReader.path, "ServerPort");

            string port = string.IsNullOrEmpty(value?.ToString()) ? "9999" : value.ToString();
            settingFile.WriteToFile(PremissionReader.path, "ServerIp", ip);
            settingFile.WriteToFile(PremissionReader.path, "ServerPort", "9999");
            Console.WriteLine("IP: {0} PORT: {1}",ip,port);
            Server.SetupServer("tikshuvServer", ip, int.Parse(port));





            TikshuvServer.connections.serverMessageTextExperimental.Server.SetupServer(ip, 25367);


            while (true)


            {

            }
            
        }
    }
}
