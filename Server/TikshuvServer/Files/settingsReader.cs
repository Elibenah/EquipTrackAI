using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TikshuvServer.Files
{
    internal class settingFile
    {
        
        
            public static string settingFilePath = "./Files/settings.txt";

            public static void createFileFolder()
            {
                if (Directory.Exists(settingFilePath))
                {
                    Console.WriteLine("Folder already exists.");
                }
                else
                {
                    try
                    {
                        Directory.CreateDirectory(settingFilePath);
                        Console.WriteLine("Folder created successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating folder: {ex.Message}");
                    }
                }
            }
            public static void CreateFile(string file)//creating file
            {
                if (!System.IO.File.Exists(file))
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(file))
                    {
                        //System.Console.WriteLine();
                    }
                }
            }
            
            public static void WriteToFile(string file, string Key, string Value)//write and overwrite to file
            {
                bool Exists = false;
                List<string> readText = File.ReadAllLines(file).ToList<string>();
                for (int i = 0; i < readText.Count; i++)
                {
                    if (readText[i].Contains(Key))
                    {
                        readText[i] = String.Format("{0} = {1}", Key, Value);
                        Exists = true;
                        break;
                    }
                }
                if (!Exists)
                {
                    readText.Add(String.Format("{0} = {1}", Key, Value));
                }
                System.IO.File.WriteAllLines(file, readText);
            }

            public static object GetValueFromFile(string file, string Key)//get value of key from save
            {
                List<string> readText = File.ReadAllLines(file).ToList<string>();
                for (int i = 0; i < readText.Count; i++)
                {
                    if (!readText[i].StartsWith("#"))
                    {
                        if (readText[i].Contains("" + Key + " "))
                        {
                            string x = readText[i].ToString();
                            StringSplitOptions options = StringSplitOptions.None;
                            string[] splitter = new string[] { " = " };
                            //string splitter = " = ";
                            x = x.Split(splitter, options)[1];
                            if (x.StartsWith("["))
                            {
                                string[] stringArray = JsonSerializer.Deserialize<string[]>(x);
                                return stringArray;
                            }
                            else
                            {
                                try
                                {
                                    return x;
                                }
                                catch (System.Exception)
                                {

                                    return "";
                                }
                            }

                        }
                    }
                }
                return "";
            }
        
    }
}
