using Microsoft.Office.Interop.Excel; // Likely for Excel interaction, though not used in provided snippet
using Newtonsoft.Json; // Used for JSON serialization/deserialization, probably by ConnectionHandler or others
using System.Data.Entity; // Used for Entity Framework, probably by DataManager
using System.Drawing.Drawing2D; // Used for graphic path operations (rounded corners)
using System.Net.Http; // Added for HttpClient to interact with external APIs
using Tikshuv.Logic; // Assuming this contains ConnectionHandler, settingFile, localCardential, DataManager
using Tikshuv.Logic.DataAccess; // Specific namespace for DataManager, if different from Tikshuv.Logic
using System.Threading.Tasks; // For async operations
using System.Runtime.InteropServices;

// 
using System;
using System.Windows.Forms;
using System.Threading; // For Thread.Sleep

namespace Tikshuv.FrontEnd
{
   
    public partial class Main : Form
    {
        // UI related fields for custom form appearance
        private int cornerRadius = 15;
        public System.Drawing.Point mouseLocation; // Used for form dragging

        // Static database path variables 
        public static string equipmentDataBase;
        public static string missionListDataBase;
        public static string historyMissionListDataBase;
        public static string existItemsByTypeDataBase;

        // Debounce mechanism for UI events 
        private DateTime lastClickTime = DateTime.MinValue;
        private readonly TimeSpan debounceInterval = TimeSpan.FromSeconds(2); // 2-second debounce

        // Static instance of DataManager for local database operations
        public static DataManager LocalDB = new DataManager();

     
        // AIHelper instance for AI-powered form navigation
        private readonly LocalAIHelper _localAiHelper;

        
    
    
        [return: MarshalAs(UnmanagedType.Bool)]
        public  Main()
        {
            InitializeComponent();
            MessageBox.Show("Application Started"); // Informative message on startup

            // --- System Configuration & Network Initialization ---

            // 
            settingFile.createFileFolder();
            settingFile.CreateFile(settingFile.settingFilePath);

            // Retrieve Server IP from config or use default (127.0.0.1)
            object value = settingFile.GetValueFromFile(settingFile.settingFilePath, "ServerIp");
            string ip = string.IsNullOrEmpty(value?.ToString()) ? "127.0.0.1" : value.ToString();

            // Retrieve Server Port from config or use default (9999)
            value = settingFile.GetValueFromFile(settingFile.settingFilePath, "ServerPort");
            string port = string.IsNullOrEmpty(value?.ToString()) ? "9999" : value.ToString(); // Default to "9999"

            // Write IP and Port back to file (ensures default values are saved if not present)
            settingFile.WriteToFile(settingFile.settingFilePath, "ServerIp", ip);
            settingFile.WriteToFile(settingFile.settingFilePath, "ServerPort", "9999"); // 
            // Store credentials in localCardential static class
            localCardential.ipServer = ip;
            localCardential.portInServer = int.Parse(port);

            // Initialize the network connection handler
            ConnectionHandler.initConnection(localCardential.ipServer);

            // Attempt to connect to the server with retries
            int attempts = 0;
            while (!ConnectionHandler._client.IsConnected() && attempts < 3)
            {
                MessageBox.Show("Cannot reach server at IP: " + localCardential.ipServer + ". Retrying...");
                Thread.Sleep(1000); // Wait for 1 second before retrying
                attempts++;
            }

            // If connection fails after retries, exit the application
            if (!ConnectionHandler._client.IsConnected())
            {
                MessageBox.Show("Failed to connect to the server. Please close the application and try again.");
                Environment.Exit(0);
            }


            _localAiHelper = new LocalAIHelper();




            // --- Event Handlers Subscriptions ---

            // Subscribe to the form's Load event to send initial data requests asynchronously
            this.Load += async (_, __) =>
            {
                await Task.Run(() =>
                {
                    // Send various data requests to the server upon form loading
                    ConnectionHandler.SendRequest("solider", "soliderConnection", "");
                    ConnectionHandler.SendRequest("mission", "getAllMissions", "");
                    ConnectionHandler.SendRequest("mission", "getAllHistoryMission", "");
                    ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
                    ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
                    ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");
                });
            };

            // Subscribe to the form's Resize event for UI adjustments 
            this.Resize += new EventHandler(Form_Resize);

            // Note: main_Load method is an empty event handler, typically generated by the designer.
            // Its functionality is largely superseded by the async Load event handler above.






            experimentalSndMessages.ConnectionHandler.initConnection(ip);



            //Task.Run(async () =>
            //{
            //    await experimentalSndMessages.ConnectionHandler.TestSendMessage();
            //}).GetAwaiter().GetResult();

 

            //experimentalSndMessages.responseObject responseEx = Task.Run(async () =>
            //{
            //    return await experimentalSndMessages.ConnectionHandler.SendRequest("signature", "GetSignature", 123);
            //}).GetAwaiter().GetResult();

            //Console.WriteLine($"ResponseEx received: Data={responseEx.data}, Authorized={responseEx.authorized}");

            //await experimentalSndMessages.ConnectionHandler.TestSendMessage();
            // Test signature request
            //experimentalSndMessages.responseObject responseEx = experimentalSndMessages.ConnectionHandler.SendRequest("signature", "GetSignature", 123);
            //Console.WriteLine($"ResponseEx received: Data={responseEx.data}, Authorized={responseEx.authorized}");
        }

        // Default Load event handler 
        private void main_Load(object sender, EventArgs e)
        {
            // No specific logic here; initial data loading moved to the async this.Load event handler
        }

    
        //Handles the form's Resize event to re-apply rounded corners when the form dimensions change.
  
        private void Form_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCorners(this.cornerRadius);
        }

      
        //Applies rounded corners to the form's region.
        //This creates a custom window shape.
       
        //<param name="radius">The radius of the rounded corners.</param>
        private void ApplyRoundedCorners(int radius)
        {
            var path = new GraphicsPath();
            int adjustedRadius = radius * 2; // Diameter for arc creation

            path.StartFigure();
            // Add arcs for each of the four corners
            path.AddArc(new System.Drawing.Rectangle(0, 0, adjustedRadius, adjustedRadius), 180, 90); // Top-left corner
            path.AddArc(new System.Drawing.Rectangle(this.Width - adjustedRadius - 1, 0, adjustedRadius, adjustedRadius), 270, 90); // Top-right corner
            path.AddArc(new System.Drawing.Rectangle(this.Width - adjustedRadius - 1, this.Height - adjustedRadius - 1, adjustedRadius, adjustedRadius), 0, 90); // Bottom-right corner
            path.AddArc(new System.Drawing.Rectangle(0, this.Height - adjustedRadius - 1, adjustedRadius, adjustedRadius), 90, 90); // Bottom-left corner
            path.CloseFigure(); // Close the figure to complete the path

            this.Region = new Region(path); // Apply the path as the form's region
            path.Dispose(); // Dispose of the GraphicsPath object to free resources and prevent memory leaks
        }

 
        // Event handler for the Settings button click.
        // Opens the settings form as a modal dialog.
    
        private void settings_Click(object sender, EventArgs e)
        {
            settings Settings = new settings(); // Assuming 'settings' is a WinForms Form class
            Settings.ShowDialog(); // Show the settings form modally
        }

    
        //Event handler for the Storage button click.
        // Opens the storage form as a modal dialog.

        private void storage_Click(object sender, EventArgs e)
        {
            storage Storage = new storage(); // Assuming 'storage' is a WinForms Form class
            Storage.ShowDialog(); // Show the storage form modally
        }

     
        // Event handler for the Missions button click.
        // Opens the missions form as a modal dialog.
 
        private void missions_Click(object sender, EventArgs e)
        {
            Missions Missions = new Missions(); // Assuming 'Missions' is a WinForms Form class
            Missions.ShowDialog(); // Show the missions form modally
        }

    
        // Event handler for the ScreenSize button click 
        // Toggles the window state between maximized and normal.

        private void ScreenSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Restore to normal state
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None; // Maintain borderless custom design
                ScreenSize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Full_screen)); // Change icon
            }
            else
            {
                // Maximize the window
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None; // Maintain borderless custom design
                ScreenSize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.small_screen)); // Change icon
            }
        }

      
        // Event handler for the Minimize button click.
        //Minimizes the application window.

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        // Event handler for the Close button click.
        // Exits the entire application.
 
        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

      
        // Handles the mouse down event on panel5 
        // Stores the initial mouse position relative to the panel.
       
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new System.Drawing.Point(-e.X, -e.Y);
        }

      
        // Handles the mouse move event on panel5 (likely for form dragging).
        // Moves the form when the left mouse button is held down.

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Point mousePose = Control.MousePosition; // Get screen coordinates of mouse
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);     // Adjust by initial offset
                Location = mousePose;                                   // Set form's new location
            }
        }

        // --- Mouse Hover/Leave events for displaying labels on UI elements ---
        private void storage_MouseHover(object sender, EventArgs e)
        {
            storageLable.Text = "מחסן"; // Display "Storage" label
        }

        private void storage_MouseLeave(object sender, EventArgs e)
        {
            storageLable.Text = ""; // Clear "Storage" label
        }

        private void missions_MouseHover(object sender, EventArgs e)
        {
            MissionLable.Text = "משימות"; // Display "Missions" label
        }

        private void missions_MouseLeave(object sender, EventArgs e)
        {
            MissionLable.Text = ""; // Clear "Missions" label
        }

        private void settings_MouseHover(object sender, EventArgs e)
        {
            SettingsLable.Text = "הגדרות"; // Display "Settings" label
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            SettingsLable.Text = ""; // Clear "Settings" label
        }

        // Empty PictureBox click event handler 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // No specific logic here
        }

        // This property controls whether the AI assistant button is currently awaiting a response.
        // It's used for debouncing or disabling the button to prevent multiple rapid requests.
        private bool isWaitingForResponse = false;

      
        // Actual asynchronous event handler for the AI "Ask" button click.
        // Validates user input and calls the AIHelper to process the request.
     
        private void btnAskAi_Click(object sender, EventArgs e)
        {
            string userInput = txtAiInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _localAiHelper.HandleUserRequest(userInput, this); // 

            txtAiInput.Text = "";
            txtAiInput.PlaceholderText = "שאל שאלה (למשל: איפה הציוד)";
        }

       
        // Disposes of the HttpClient instance when the form is closed to free up resources.
        // This is crucial for preventing socket exhaustion over time.
 
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
           
            base.OnFormClosed(e); // Call the base class method
        }
    }
}