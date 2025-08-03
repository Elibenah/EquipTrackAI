using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Management;
using Microsoft.Win32;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Windows.Forms;

using Range = Microsoft.Office.Interop.Word.Range;
using Shape = Microsoft.Office.Interop.Word.Shape;
using Excel = Microsoft.Office.Interop.Excel;
using Tikshuv.Logic.DataAccsess;
using Microsoft.SqlServer.Server;
using Org.BouncyCastle.Asn1.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
namespace Tikshuv.FrontEnd.MissionsWindow
{
    public class documentProcessing
    {
        public static string officeLanguage = "";
        List<int> ownWordPID = new List<int>();
        public static void missionToDocument(mission mission)
        {
            checkIfRunning();

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            officeLanguage = wordApp.Language.ToString();
            Dictionary<string, List<string>> objects = new Dictionary<string, List<string>>();
            Dictionary<string,string> AttachmentForEeachItem = new Dictionary<string,string>();
            string cellValue = "";
            foreach (var item in mission.itemsInMissions)
            {
                objects.Add(item.Key, new List<string>());
                foreach (var obj in item.Value)
                {
                    objects[item.Key].Add(obj.serialNumber);
                    if(obj.attachmentOfEquiment != null && obj.attachmentOfEquiment.Count > 0)
                    {
                        cellValue = string.Join(", ", obj.attachmentOfEquiment
                                    .Where(item => item.inMission)         // Filter items where 'in' is true
                                    .Select(item => item.name));           // Project the 'name' property
                    }
                    

                    //string cellValue = string.Join(", ", Enumerable.Range(0, obj.attachmentOfEquiment.Count);
                    if(obj.serialNumber != "N\\A" && obj.serialNumber != "N/A")
                    {
                        AttachmentForEeachItem.Add(obj.serialNumber, cellValue);
                    }
                }
            }

            string sourceFilePath = @"./Files//template.docx";
            string destinationFilePath = @"./Files/missionDocument.docx";
            
            string folderPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            // Copy the file
            File.Copy(sourceFilePath, destinationFilePath, true);

            Document doc = wordApp.Documents.Open(folderPath + destinationFilePath);

            // Access the document content
            Microsoft.Office.Interop.Word.Range contentRange = doc.Content;

            // Select the entire content range
            contentRange.WholeStory();

            // Assuming this is the first (and only) table in the document
            Table table = doc.Tables[1];

            List<object> keyList = new List<object>(objects.Keys);
            int currentInt = 0;
            for (int i = 0; i < objects.Count; i++)
            {

                foreach (string serialNumber in (List<string>)objects[keyList[i].ToString()])
                {
                    Row newRow = table.Rows.Add();

                    // to orgenize correctly serial numbers that start with a numbers, cause it causes issues
                    if (Char.IsDigit(keyList[i].ToString()[0]))
                    {
                        table.Cell(i + 3 + currentInt, 5).Range.ParagraphFormat.ReadingOrder = WdReadingOrder.wdReadingOrderLtr;
                        table.Cell(i + 3 + currentInt, 5).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                    }
                    // to orgenize correctly item names that start with a numbers, cause it causes issues
                    if (Char.IsDigit(serialNumber[0]))
                    {
                        table.Cell(i + 3 + currentInt, 6).Range.ParagraphFormat.ReadingOrder = WdReadingOrder.wdReadingOrderLtr;
                        table.Cell(i + 3 + currentInt, 6).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    }

                    table.Cell(i + 3 + currentInt, 5).Range.Font.Name = "Arial";
                    table.Cell(i + 3 + currentInt, 5).Range.Font.BoldBi = 0;
                    table.Cell(i + 3 + currentInt, 5).Range.Font.Bold = 0;
                    table.Cell(i + 3 + currentInt, 5).Range.Underline = WdUnderline.wdUnderlineNone;
                    table.Cell(i + 3 + currentInt, 5).Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                    table.Cell(i + 3 + currentInt, 5).Range.Font.Size = 12;

                    table.Cell(i + 3 + currentInt, 6).Range.Font.Name = "Arial";
                    table.Cell(i + 3 + currentInt, 6).Range.Font.BoldBi = 0;
                    table.Cell(i + 3 + currentInt, 6).Range.Font.Bold = 0;
                    table.Cell(i + 3 + currentInt, 6).Range.Underline = WdUnderline.wdUnderlineNone;
                    table.Cell(i + 3 + currentInt, 6).Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                    table.Cell(i + 3 + currentInt, 6).Range.Font.Size = 12;

                    table.Cell(i + 3 + currentInt, 7).Range.Font.Name = "Arial";
                    table.Cell(i + 3 + currentInt, 7).Range.Font.BoldBi = 0;
                    table.Cell(i + 3 + currentInt, 7).Range.Font.Bold = 0;
                    table.Cell(i + 3 + currentInt, 7).Range.Underline = WdUnderline.wdUnderlineNone;
                    table.Cell(i + 3 + currentInt, 7).Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                    table.Cell(i + 3 + currentInt, 7).Range.Font.Size = 12;

                    
                    table.Cell(i + 3 + currentInt, 5).Range.Text = keyList[i].ToString();
                    table.Cell(i + 3 + currentInt, 6).Range.Text = serialNumber;
                    table.Cell(i + 3 + currentInt, 7).Range.Text = AttachmentForEeachItem[serialNumber];

                    currentInt++;
                }
            }

            Shape desiredTextBox = null;

            foreach (Shape shape in doc.Shapes)
            {
                if (shape.Type == MsoShapeType.msoTextBox && shape.TextFrame.HasText == -1)
                {
                    // Check the properties of the text box to identify the desired one
                    if (shape.TextFrame.TextRange.Text.Contains("הקלד שם פריסה"))
                    {
                        desiredTextBox = shape;
                        break;
                    }
                }
            }

            // Select the desired text box
            if (desiredTextBox != null)
            {
                desiredTextBox.Select();
                desiredTextBox.TextFrame.TextRange.Text = mission.missionName;
                desiredTextBox.TextFrame.TextRange.BoldBi = 1;
            }

            string wordAppPath = wordApp.Path;
            // Save the changes
            doc.Save();

            // Close the document
            doc.Close();

            // Quit the Word application
            wordApp.Quit();

            //Process.Start( @"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE", destinationFilePath);
            Process.Start(wordAppPath + "\\WINWORD.EXE", destinationFilePath);
        }
        private static void checkIfRunning()
        {
            Process[] wordProcesses = Process.GetProcessesByName("WINWORD");
            Process[] excelProcesses = Process.GetProcessesByName("EXCEL");

            if (wordProcesses.Length > 0)
            {
                foreach (Process wordProcess in wordProcesses)
                {
                    string title = wordProcess.MainWindowTitle;
                    if (title != null && (title == "" || title == "missionDocument.docx - Word"))
                    {
                        wordProcess.Kill();
                    }
                }
            }

            if (excelProcesses.Length > 0)
            {
                foreach (Process excelProcess in excelProcesses)
                {
                    string title = excelProcess.MainWindowTitle;
                    if (title != null && (title == "" || title == "listing.xlsx - Excel"))
                    {
                        excelProcess.Kill();
                    }
                }
            }
        }



        //static int GetWordProcessId(Microsoft.Office.Interop.Word.Application wordApp)
        //{
        //    Process[] processes = Process.GetProcessesByName("WINWORD");
        //    foreach (Process process in processes)
        //    {
        //        bool x = IsWordApplication(process, wordApp);
        //        if (IsWordApplication(process, wordApp))
        //        {
        //            return process.Id;
        //        }
        //    }
        //    return -1;
        //}

        //static bool IsWordApplication(Process process, Microsoft.Office.Interop.Word.Application wordApp)
        //{
        //    try
        //    {
        //        IntPtr hwnd = process.MainWindowHandle;
        //        object application = System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");

        //        return (application == wordApp);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public static void excelProcess(DataGridView dataToExecute, string listing)
        {
            try
            {
                checkIfRunning();
                string destinationFilePath = @"listing.xlsx";
                //string destinationFilePath = @"./Files/listing.xlsx";
                //destinationFilePath = String.Format(@"./Files/listing {0}.xlsx",listing);
                // Create a new Excel application and workbook
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                // Create a new worksheet and set its name
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "DataGridViewData";

                // Export the column headers to Excel
                for (int i = 0; i < dataToExecute.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataToExecute.Columns[i].HeaderText;
                }

                // Export the data to Excel
                for (int i = 0; i < dataToExecute.Rows.Count; i++)
                {
                    for (int j = 0; j < dataToExecute.Columns.Count; j++)
                    {
                        if (dataToExecute.Rows[i].Cells[j] != null && dataToExecute.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataToExecute.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                }

                Excel.Range columns = worksheet.UsedRange.Columns;
                columns.AutoFit();
                // Save the workbook and close Excel
                workbook.SaveAs(destinationFilePath); // Change the file name and path as desired
                workbook.Close();
                excelApp.Quit();

                Process.Start(excelApp.Path + "\\EXCEL.EXE", destinationFilePath);

                Console.WriteLine("Export to Excel completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
