using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public partial class ItemHistory : Form
    {
        Logic.DataAccsess.missionInHistroy choosedMissionInHistory;
        private Point mouseLocation;

        public ItemHistory()
        {
            ConnectionHandler.SendRequest("mission", "getAllHistoryMission", "");
            InitializeComponent();
            // Top gray stripe
            titleBar = new Panel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

            // Button X
            closeButton = new Button
            {
                Text = "X",
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Width = 30,
                Height = 30,
                Dock = DockStyle.Right
            };

            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) => { this.Close(); };

            titleBar.Controls.Add(closeButton);
            this.Controls.Add(titleBar);

            Label titleLabel = new Label
            {
                Text = "היסטוריית משימות",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            titleLabel.Location = new Point(
                (titleBar.Width - titleLabel.Width) / 2,
                (titleBar.Height - titleLabel.Height) / 2
            );
            titleBar.Controls.Add(titleLabel);


            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseLocation = new Point(-e.X, -e.Y);
                }
            };

            titleBar.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point mousePose = Control.MousePosition;
                    mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                    Location = mousePose;
                }
            };

            foreach (missionInHistroy mission in publicData.historyMissions)
            {
                missionHistorySelectionComboBox.Items.Add(mission.missionName);
            }
        }
        private void selectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionHistoryGridView.Rows.Clear();
            foreach (missionInHistroy mission in publicData.historyMissions)
            {
                if (missionHistorySelectionComboBox.SelectedItem.ToString() == mission.missionName)
                {
                    choosedMissionInHistory = mission;
                    timeAddedTextBox.Text = mission.timeAdded;
                    missionIdTextBox.Text = mission.missionId;
                    deployItems();
                    break;
                }
            }
        }
        private void deployItems()
        {
            string type;
            string[] pieces;
            foreach (KeyValuePair<string, List<EquipmentInMission>> itemList in choosedMissionInHistory.itemsInMissions)
            {
                type = itemList.Key;
                foreach (EquipmentInMission serialNumberInItems in itemList.Value)
                {
                    pieces = serialNumberInItems.serialNumber.Split(new[] { ':' }, 2);
                    missionHistoryGridView.Rows.Add(type, pieces[0], pieces[1]);
                }
            }
        }
    }
}
