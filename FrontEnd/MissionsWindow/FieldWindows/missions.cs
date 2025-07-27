using Google.Protobuf.WellKnownTypes;
using HandyControl.Tools.Extension;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.FrontEnd.MissionsWindow;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccess;
using Tikshuv.Logic.DataAccsess;
using Point = System.Drawing.Point;

namespace Tikshuv.SubForms
{
    public partial class missions : Form
    {
        public DataManager dataManager;
        string currentMissionId = "";
        Logic.DataAccsess.mission newMission = new Logic.DataAccsess.mission();
        
        Logic.DataAccsess.mission pointedMission;
        Logic.DataAccsess.missionInHistroy currentMissionToAddToHistory;
        bool missionExisted = false;
        bool changedAccured = false;
        int existedRows = 0;
        int rowAddedIndex = 0;

        private Point mouseLocation;
        private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly Random random = new Random();

        public static string GenerateActivationCode(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(Characters.Length);
                sb.Append(Characters[index]);
            }
            return sb.ToString();
        }
        public missions()

        {
            ConnectionHandler.SendRequest("mission", "getAllMissions", "");
            ConnectionHandler.SendRequest("mission", "getAllHistoryMission", "");
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
            //ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
            //ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");

            currentMissionToAddToHistory = new Logic.DataAccsess.missionInHistroy();
            missionExisted = false;
            changedAccured = false;
            newMission.itemsInMissions = new Dictionary<string, List<EquipmentInMission>>();
            existedRows = 0;
            rowAddedIndex = 0;
            InitializeComponent();

            // Top gray stripe
            titleBar = new Panel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

            // Button X
            closeButton = new System.Windows.Forms.Button
            {
                Text = "X",
                ForeColor = Color.Black,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Width = 30,
                Height = 30,
                Dock = DockStyle.Right
            };


            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) => { this.Close(); };

            titleBar.Controls.Add(closeButton);
            this.Controls.Add(titleBar);

            // Allows you to drag the window by clicking on the panel
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

            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label
            {
                Text = "עריכת משימות",
                Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            titleLabel.Location = new Point(
                (titleBar.Width - titleLabel.Width) / 2,
                (titleBar.Height - titleLabel.Height) / 2
            );
            titleBar.Controls.Add(titleLabel);

            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");

            DataGridViewComboBoxColumn objectsColumn = (DataGridViewComboBoxColumn)missionGridView.Columns[0];
            foreach (Equipment iterator in publicData.existsEquipmentsList)
            {
                objectsColumn.Items.Add(iterator.type);
            }

            foreach (Tikshuv.Logic.DataAccsess.mission mission in publicData.missionsList)
            {
                namingMission.Items.Add(mission.missionName);
            }
            dataManager = new DataManager();
        }
        private void missionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                missionGridView.BeginEdit(true);
            }
        }
        private void missionGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check if the current column is the DataGridViewComboBoxColumn
            if ((e.Control is ComboBox))
            {
                // Unsubscribe from the SelectedIndexChanged event to ensure that the event handler is only subscribed once
                var comboBox = e.Control as ComboBox;
                comboBox.SelectionChangeCommitted -= ComboBox_SelectionChangeCommitted;
                comboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
            }
        }
        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int formerCount = missionGridView.Rows.Count;
            int currentPointedRow = missionGridView.CurrentRow.Index;
            for (int i = 0; i < formerCount; i++)
            {
                if (missionExisted && !changedAccured)
                {
                    i = currentPointedRow;
                    changedAccured = true;
                }
                string item = missionGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                string serialNumber = missionGridView.Rows[i].Cells[1].EditedFormattedValue.ToString();

                if (item != "" && serialNumber == "")
                {
                    DataGridViewComboBoxCell itemCell = (DataGridViewComboBoxCell)(missionGridView.Rows[i].Cells[0]);

                    foreach (KeyValuePair<string, List<string>> items in Missions.availableEquimpments)
                    {
                        if (!itemCell.Items.Contains(items.Key))
                        {
                            itemCell.Items.Add(items.Key);
                        }
                    }
                    itemCell.Value = item;
                    DataGridViewComboBoxCell serialNumberCell = (DataGridViewComboBoxCell)(missionGridView.Rows[i].Cells[1]);
                    serialNumberCell.Items.Clear();

                    if (Missions.availableEquimpments.ContainsKey(item))
                    {
                        serialNumberCell.Items.AddRange(Missions.availableEquimpments[item].ToArray());
                    }

                    serialNumberCell.Value = serialNumber;
                    if (serialNumberCell.Value != "")
                    {
                        missionGridView.TabIndex = formerCount;
                    }
                    else
                    {
                        missionGridView.TabIndex = i;
                    }
                }

                else if (item != "" && serialNumber != "" && i == rowAddedIndex)
                {
                    if (missionExisted)
                    {
                        newMission = pointedMission;
                    }
                    string missionName = namingMission.Text;
                    newMission.missionName = missionName;
                    newMission.isFixedMission = fixedMissionCheckBox.Checked;
                    EquipmentInMission itemToAdd = new EquipmentInMission();
                    itemToAdd.serialNumber = serialNumber;
                    //add info abouut signed attachment
                    if (!newMission.itemsInMissions.ContainsKey(item))
                    {
                        newMission.itemsInMissions.Add(item, new List<EquipmentInMission>() { itemToAdd });
                    }
                    else
                    {
                        newMission.itemsInMissions[item].Add(itemToAdd);
                    }
                    //check if the list updated automatically or keep it this way

                    Equipment iterator = publicData.existItemsByType[item].Cast<Equipment>().FirstOrDefault(c => c.serialNumber == serialNumber && !serialNumber.Contains("N\\A"));
                    if (iterator.serialNumber == serialNumber && !serialNumber.Contains("N\\A"))
                    {
                        iterator.currentMissionName = newMission.missionName;
                        if (newMission.isFixedMission)
                        {
                            iterator.fixedMissionName = newMission.missionName;
                        }
                        else
                        {
                            iterator.tempMissionName = newMission.missionName;
                        }
                    }


                    if (!serialNumber.Contains("N\\A"))
                    {
                        Missions.availableEquimpments[item].Remove(serialNumber);
                    }


                    if (!missionExisted)
                    {
                        //publicData.missionList.Add(newMission);
                    }
                    else
                    {
                        for (int j = 0; j < publicData.missionsList.Count; j++)
                        {
                            if (publicData.missionsList[j].missionName == newMission.missionName)
                            {
                                publicData.missionsList[j] = newMission;
                                break;
                            }
                        }
                    }

                    //ConnectionHandler.SendRequest("mission","addMission", newMission);
                    
                    
                }
                if (i == formerCount - 1)
                {
                }
            }
        }
        private void namingMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionGridView.Rows.Clear();
            foreach (mission choosedMission in publicData.missionsList)
            {
                if (choosedMission.missionName == namingMission.SelectedItem.ToString())
                {
                    missionExisted = true;
                    pointedMission = choosedMission;
                    
                    int i = 0;

                    foreach (KeyValuePair<string, List<EquipmentInMission>> item in choosedMission.itemsInMissions)
                    {
                        string type = item.Value.GetType().FullName;


                        List<EquipmentInMission> serialNumbersList = item.Value;

                        foreach (EquipmentInMission soloItem in serialNumbersList)
                        {
                            missionGridView.Rows.Add();
                            DataGridViewComboBoxCell itemBoxCell = (DataGridViewComboBoxCell)(missionGridView.Rows[i].Cells[1]);
                            DataGridViewComboBoxCell serialNumberBoxCell = (DataGridViewComboBoxCell)(missionGridView.Rows[i].Cells[0]);


                            DataGridViewTextBoxCell itemTextBoxCell = new DataGridViewTextBoxCell();
                            DataGridViewTextBoxCell serialNumberTextBoxCell = new DataGridViewTextBoxCell();


                            itemBoxCell.Items.Add(item.Key.ToString());
                            serialNumberBoxCell.Items.Add(soloItem.serialNumber);

                            itemBoxCell.Value = item.Key.ToString();
                            serialNumberBoxCell.Value = soloItem.serialNumber;


                            itemTextBoxCell.Value = itemBoxCell.Value;
                            itemTextBoxCell.Style = itemBoxCell.Style;
                            itemTextBoxCell.Tag = itemBoxCell.Tag;

                            serialNumberTextBoxCell.Value = serialNumberBoxCell.Value;
                            serialNumberTextBoxCell.Style = serialNumberBoxCell.Style;
                            serialNumberTextBoxCell.Tag = serialNumberBoxCell.Tag;





                            missionGridView.Rows[i].Cells[0] = itemTextBoxCell;
                            missionGridView.Rows[i].Cells[1] = serialNumberTextBoxCell;

                            

                            i++;
                        }
                    }
                    existedRows = i;
                    break;
                }

            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //newMission.missionId = GenerateActivationCode(16);
            //currentMissionId = UInt64.Parse(settingFile.GetValueFromFile(settingFile.settingFilePath, "uint64CurrentMissionId").ToString());
            string item, serialNumber;
            string missionName = namingMission.Text;
            newMission.missionName = missionName;
            newMission.isFixedMission = fixedMissionCheckBox.Checked;
            //newMission.itemsInMissions = new Dictionary<string, List<EquipmentInMission>>();
            foreach (DataGridViewRow row in missionGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    if (row.Cells[0].Value.ToString() != "" && row.Cells[1].Value.ToString() != "")
                    {
                        item = row.Cells[0].Value.ToString();
                        serialNumber = row.Cells[1].Value.ToString();

                        EquipmentInMission itemToAdd = new EquipmentInMission();
                        itemToAdd.serialNumber = serialNumber;
                        //add info abouut signed attachment
                        if (!newMission.itemsInMissions.ContainsKey(item))
                        {
                            newMission.itemsInMissions.Add(item, new List<EquipmentInMission>() { itemToAdd });
                        }
                        else
                        {
                            if(newMission.itemsInMissions[item].Cast<EquipmentInMission>().FirstOrDefault(c => c.serialNumber == serialNumber) != null)
                            {

                            }
                            else
                            {
                                newMission.itemsInMissions[item].Add(itemToAdd);
                            }
                        }
                    }
                }
            }
            //check if the list updated automatically or keep it this way
            foreach (DataGridViewRow row in missionGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    item = row.Cells[0].Value.ToString();
                    serialNumber = row.Cells[1].Value.ToString();
                    Equipment iterator = publicData.existItemsByType[item].Cast<Equipment>().FirstOrDefault(c => c.serialNumber == serialNumber && !serialNumber.Contains("N\\A"));
                    if (iterator != null && iterator.serialNumber == serialNumber && !serialNumber.Contains("N\\A"))
                    {
                        iterator.currentMissionName = newMission.missionName;
                        if (newMission.isFixedMission)
                        {
                            iterator.fixedMissionName = newMission.missionName;
                        }
                        else
                        {
                            iterator.tempMissionName = newMission.missionName;
                        }
                    }

                }
            }
            if (!missionExisted)
            {
                newMission.missionId = GenerateActivationCode(16);
                //publicData.missionsList.Add(newMission);
            }
            else
            {
                newMission.missionId = pointedMission.missionId;
                newMission.creatorName = pointedMission.creatorName;
            }
            ConnectionHandler.SendRequest("mission", "addMission", newMission);
            

            DialogResult result = MessageBox.Show(
                "חתימה דיגיטלית?",
                "בחר חתימה",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign
            );

            if (result == DialogResult.Yes)
            {

                var digitalSignature = new SignatureForm(newMission);
                digitalSignature.Show();
                
            }
            else
            {
                Signature missionSignature = new Signature();
                missionSignature.isSigned = false;
                missionSignature.missionId = newMission.missionId;
                missionSignature.missionName = newMission.missionName;
                ConnectionHandler.SendRequest("signature", "UpsertSignature",missionSignature);
                documentProcessing.missionToDocument(newMission);
            }

            

            
        }
        private void missionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (missionGridView.CurrentRow == null ||
                missionGridView.CurrentRow.Cells[0].Value == null ||
                  missionGridView.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("Missing row or cell data.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string item = missionGridView.CurrentRow.Cells[0].Value.ToString();
            string serialNumber = missionGridView.CurrentRow.Cells[1].Value.ToString();
            ;

            if (e.ColumnIndex == 2)
            {
                List<string> markedAttachmentList = new List<string>();
                Equipment obj = publicData.existItemsByType[item].Cast<Equipment>().FirstOrDefault(c => c.serialNumber == serialNumber);
                if (obj.Addons == null || obj.Addons.Count <= 0)
                {
                    return;
                }
                foreach (Attachment attachment in obj.Addons)
                {
                    markedAttachmentList.Add(attachment.name);
                }




                missionGridView.CurrentCell.Tag = markedAttachmentList;
                var cell = missionGridView.CurrentCell;
                System.Drawing.Rectangle cellRect = missionGridView.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);

                // Now you can use cellRect to get the size and location of the cell
                int cellX = cellRect.X + missionGridView.Location.X;
                int cellY = cellRect.Y + missionGridView.Location.Y;
                int cellWidth = cellRect.Width;
                int cellHeight = cellRect.Height;


                if (cell.Tag != null && cell.Tag is List<string>)
                {
                    var options = (List<string>)cell.Tag;
                    var dropdown = new CustomDropdown(options);
                    // Subscribe to the Closed event of the dropdown
                    if (newMission.itemsInMissions.ContainsKey(item))
                    {
                        var foundObject = newMission.itemsInMissions[item].Find(obj => obj.serialNumber == serialNumber);
                        if (foundObject != null)
                        {
                            if(foundObject.attachmentOfEquiment != null)
                            {
                                List<string> optionsToCheck = new List<string>();
                                foreach (Attachment attachment in foundObject.attachmentOfEquiment)
                                {
                                    if (attachment.inMission == true)
                                    {
                                        optionsToCheck.Add(attachment.name);
                                    }
                                }
                                dropdown.SetCheckedOptions(optionsToCheck);
                            }
                        }
                    }

                    dropdown.SubscribeClosingEvent((s, ev) =>
                    {
                        var checkedStates = dropdown.GetCheckedStates();
                        string cellValue = string.Join(", ", Enumerable.Range(0, dropdown.options.Count).Where(i => checkedStates[i]).Select(i => dropdown.options[i]));


                        if (!newMission.itemsInMissions.ContainsKey(item))
                        {
                            newMission.itemsInMissions.Add(item, new List<EquipmentInMission>() { new EquipmentInMission() { serialNumber = serialNumber } });
                        }
                        else if (!newMission.itemsInMissions[item].Any(obj => obj.serialNumber == serialNumber))
                        {
                            newMission.itemsInMissions[item].Add(new EquipmentInMission() { serialNumber = serialNumber });
                        }
                        List<Attachment> addonListToItem = newMission.itemsInMissions[item].Cast<EquipmentInMission>().FirstOrDefault(c => c.serialNumber == serialNumber).attachmentOfEquiment = new List<Attachment>();

                        string[] result = cellValue.Split(new string[] { ", " }, StringSplitOptions.None);
                        foreach (Attachment iterator in publicData.existingAttachments)
                        {
                            if (result.Contains(iterator.name))
                            {

                                Attachment attachment = new Attachment();
                                attachment.name = iterator.name;
                                attachment.isCredited = false;
                                attachment.inMission = true;
                                //var itemToRemove = mainDict["strat"].Cast<equipment>().FirstOrDefault(c => c.description == "2UA6471HF9");
                                //Equipment newItem = publicData.existItemsByType[item].Cast<Equipment>().FirstOrDefault(c => c.serialNumber == serialNumber);
                                //if (!newItem.Addons.Contains(attachment))
                                //{
                                //    newItem.Addons.Add(attachment);
                                //}
                                //else
                                //{
                                //    newItem.Addons.Cast<Attachment>().FirstOrDefault(c => c.name == attachment.name).inMission = true;
                                //}

                                if (!addonListToItem.Contains(attachment))
                                {
                                    addonListToItem.Add(attachment);
                                }
                                else
                                {
                                    //newItem.Addons.Cast<Attachment>().FirstOrDefault(c => c.name == attachment.name).inMission = true;
                                }
                            }
                        }


                    });
                    // Show the dropdown menu
                    dropdown.ShowMenu(this, new Point(cellX, cellY), cellWidth, cellHeight);
                }
            }

        DataGridViewRow row = missionGridView.CurrentRow;
        }
        private void missionGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void missionGridView_addedRow(object sender, EventArgs e)
        {
            if (missionGridView.CurrentRow != null)
            {
                rowAddedIndex = missionGridView.CurrentRow.Index;
            }

        }
        
    }
}


