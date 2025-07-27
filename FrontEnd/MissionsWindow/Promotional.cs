using System.Data;
using Tikshuv.FrontEnd;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.SubForms
{
    public partial class Promotional : Form
    {
        mission pointedMission;
        missionInHistroy currentMissionToAddToHistory;
        Dictionary<string, List<EquipmentInMission>> deletedItems;
        private Point mouseLocation;
        public Promotional()
        {
            //credit.Click += creditMission_click;
            //missionGridView.CellContentClick += missionGridView_CellContentClick;
            //missionName.SelectedIndexChanged += missionName_SelectedIndexChanged;
            ConnectionHandler.SendRequest("mission", "getAllMissions", "");
            ConnectionHandler.SendRequest("mission", "getAllHistoryMission", "");
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
            ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
            ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");
            Missions.updateAvailableEquipment();
            InitializeComponent();
            this.missionName.SelectedIndexChanged += missionName_SelectedIndexChanged;
            this.credit.Click += creditMission_click;
            this.missionGridView.CellContentClick += missionGridView_CellContentClick;
            titleBar = new Panel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

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

            Label titleLabel = new Label
            {
                Text = "זיכוי משימות",
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

            deletedItems = new Dictionary<string, List<EquipmentInMission>>();
            foreach (Tikshuv.Logic.DataAccsess.mission mission in publicData.missionsList)
            {
                missionName.Items.Add(mission.missionName);
            }
        }
        private void missionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionGridView.Rows.Clear();
            missionGridView.AllowUserToDeleteRows = false;
            foreach (mission choosedMission in publicData.missionsList)
            {
                if (choosedMission.missionName == missionName.SelectedItem.ToString())
                {
                    pointedMission = choosedMission;
                    int i = 0;
                    foreach (KeyValuePair<string, List<EquipmentInMission>> item in choosedMission.itemsInMissions)
                    {
                        string type = item.Value.GetType().FullName;

                        List<EquipmentInMission> serialNumbersList = item.Value;

                        foreach (EquipmentInMission soloItem in serialNumbersList)
                        {
                            missionGridView.Rows.Add();
                            DataGridViewTextBoxCell itemTextBoxCell = new DataGridViewTextBoxCell();
                            DataGridViewTextBoxCell serialNumberTextBoxCell = new DataGridViewTextBoxCell();
                            itemTextBoxCell.Value = item.Key;
                            serialNumberTextBoxCell.Value = soloItem.serialNumber;
                            missionGridView.Rows[i].Cells[0] = itemTextBoxCell;
                            missionGridView.Rows[i].Cells[1] = serialNumberTextBoxCell;
                            i++;
                        }
                    }
                }
            }
        }
        private void creditMission_click(object sender, EventArgs e)
        {
            int currentRows = missionGridView.Rows.Count;
            
            for (int i = 0; i < currentRows; i++)
            {
                DataGridViewRow row = missionGridView.Rows[i];
                if (row != null)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {

                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[2];
                        EquipmentInMission soloItem = new EquipmentInMission();
                        List<Attachment> attachmentIsntChexked = new List<Attachment>();
                        //soloItem.serialNumber = row.Cells[1].Value.ToString();
                        soloItem = pointedMission.itemsInMissions[row.Cells[0].Value.ToString()].Find(c => c.serialNumber == row.Cells[1].Value.ToString());
                        //soloItem = deletedItems[row.Cells[0].Value.ToString()].Find(c => c.serialNumber == row.Cells[1].Value.ToString());
                        if (soloItem.attachmentOfEquiment != null)
                        {
                            attachmentIsntChexked = soloItem.attachmentOfEquiment.FindAll(c => c.isCredited == false && c.inMission == true);
                        }

                        if (attachmentIsntChexked.Count == 0)
                        {
                            if (cell.Value != null && (bool)cell.Value == true)
                            {
                                if (!deletedItems.ContainsKey(row.Cells[0].Value.ToString()))
                                {
                                    deletedItems.Add(row.Cells[0].Value.ToString(), new List<EquipmentInMission>() { soloItem });
                                }
                                else
                                {
                                    if (!deletedItems[row.Cells[0].Value.ToString()].Cast<EquipmentInMission>().Any(c => c.serialNumber == soloItem.serialNumber))
                                    {
                                        deletedItems[row.Cells[0].Value.ToString()].Add(soloItem);
                                    }
                                }
                                missionGridView.Rows.Remove(row);
                                i = i - 1;
                                currentRows = missionGridView.Rows.Count;
                            }
                        }
                        else
                        {
                            MessageBox.Show(" לא כל התוספות זוכו מהפריטים הנבחרים");
                            return;
                        }
                    }
                }

            }

            sendToServerDeletedItems();

            // error in crediting, while couting cant credit every row that had been marked
            if (pointedMission.itemsInMissions.Count == 0)
            {
                for (int i = 0; i < publicData.missionsList.Count; i++)
                {
                    if (publicData.missionsList[i].missionName == pointedMission.missionName)
                    {
                        publicData.missionsList.RemoveAt(i);
                    }
                    break;
                }
            }
        }
        private void sendToServerDeletedItems()
        {
            mission missionToRemoveItemFrom = pointedMission;
            missionToRemoveItemFrom.itemsInMissions = deletedItems;
            ConnectionHandler.SendRequest("mission", "removeItems", missionToRemoveItemFrom);
        }

        private void missionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string item = missionGridView.CurrentRow.Cells[0].Value.ToString();
            string serialNumber = missionGridView.CurrentRow.Cells[1].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                //var foundObject = newMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber);
                if (item != null && serialNumber != null)
                {
                    if (pointedMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber).attachmentOfEquiment != null)
                    {
                        if (pointedMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber).attachmentOfEquiment.Count > 0)
                        {
                            var attachmentList = pointedMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber).attachmentOfEquiment;
                            var attachmentListNames = new List<string>();
                            var attachmentListInMission = new List<string>();
                            foreach (var x in attachmentList)
                            {
                                attachmentListNames.Add(x.name);
                                if (x.inMission == true)
                                {
                                    attachmentListInMission.Add(x.name);
                                }
                            }


                            int cellX = missionGridView.Location.X;
                            int cellY = missionGridView.Location.Y;
                            int cellWidth = missionGridView.Width;
                            int cellHeight = missionGridView.Height;

                            var dropdown = new CustomDropdown(attachmentListNames);

                            dropdown.SetCheckedOptions(attachmentListInMission);

                            // Subscribe to the Closed event of the dropdown
                            dropdown.SubscribeClosingEvent((s, ev) =>
                            {
                                var checkedStates = dropdown.GetCheckedStates();
                                string cellValue = string.Join(", ", Enumerable.Range(0, dropdown.options.Count).Where(i => checkedStates[i]).Select(i => dropdown.options[i]));

                                List<Attachment> addonList = new List<Attachment>();
                                string[] result = cellValue.Split(new string[] { ", " }, StringSplitOptions.None);
                                if (cellValue == "")
                                {
                                    var obj = pointedMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber);
                                    foreach (var x in obj.attachmentOfEquiment)
                                    {
                                        if (x.inMission == true)
                                        {
                                            x.isCredited = true;
                                            if (!deletedItems.ContainsKey(item))
                                            {
                                                deletedItems.Add(item, new List<EquipmentInMission>() { obj });
                                            }
                                            else
                                            {
                                                if (!deletedItems[item].Cast<EquipmentInMission>().Any(c => c.serialNumber == serialNumber))
                                                {
                                                    deletedItems[item].Add(obj);
                                                }
                                            }

                                        }
                                    }
                                }
                            });

                            // Show the dropdown menu
                            dropdown.ShowMenu(this, new Point(cellX, cellY), cellWidth, cellHeight);
                        }
                    }
                }
            }
        }
    }
}

