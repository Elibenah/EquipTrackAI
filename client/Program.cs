using System.Data;
using Tikshuv.FrontEnd;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;
using Tikshuv.SubForms;
using Tikshuv.SubForms.LogicSubForms;
using System.Runtime.InteropServices;


namespace Tikshuv
{
    internal static class Program
    {


        //The main entry point for the application.
        
        [STAThread]
        static void Main()
        {
            AllocConsole();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());



        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}