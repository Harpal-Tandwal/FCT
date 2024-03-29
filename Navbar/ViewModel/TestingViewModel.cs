using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Data;
using Microsoft.Win32;
using Navbar.Model;
using Navbar.View.CustomControles;
using Newtonsoft.Json;
using System.Windows.Controls;
using Navbar.Commands;
using System.Security.Policy;
using System.Collections.ObjectModel;
namespace Navbar.ViewModel
{
    public class TestingViewModel
    {
        public static string folderPath = @"C:\HpTech";
        public  static string fileName = "ABRA.dat";
        public string filePath = folderPath + "\\" + fileName;

        public string[,] Param = new string[5,6];

        public TestingViewModel()
        {
            LoadProgramParameters();
        }
    
        TestingModel test = new TestingModel();
        Voltage voltage = new Voltage();
        Current current = new Current();
        Lamps l = new Lamps();




        public string tbl_online_details { get; set; } = "testing on";
        public string tbl_status { get; set; } = "PASS";
        public string tbl_message { get; set; } = "message for failure";
        public string L1V1range { get; set; }

        public RelayCommand<string> LoadTest => new RelayCommand<string>(execute => SaveProgram());
      
        //function declarations
        public void LoadProgramNames(string path) {
            try
            { 
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(folderPath);
                    string[]? items = new string[files.Length];

                    // Output the file names
                    Console.WriteLine($"Files in folder '{folderPath}':");
                    int i = 0;
                    foreach (string file in files)
                    {
                        items[i++] = Path.GetFileName(file);
                    }
                    foreach (string file in items)
                    {
                        Console.WriteLine(file);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);

                }

            }
            catch(Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error While Program Loading");
            }



            ///*************************NEW PROGRAM*******************

        }


        public void SaveProgram()
        {

            test.model_name = "ABRA";
            test.barcodes = ["Z101TURN238952734", "Z101TURN238952734"];

            voltage.test_voltage = [9, 13, 16];
            voltage.offset_voltage = [0, 0, 0];
            voltage.min_voltage = [8.9f, 12.9f, 15.9f];
            //voltage.max_voltage = [9.1f, 13.5f, 16.2f];

            current.test_current = [1.3f, 2.4f, 3f];
            current.min_current = [1, 2, 3,];
            current.max_current = [2, 3, 4];





            //l.voltage= voltage;
            //l.current= current;
            test.lamps = [l];

            string json = JsonConvert.SerializeObject(test, Formatting.Indented);
            MessageBox.Show(json);
      //*****************Write data to dat file**********************   
            try
            {
                if (Directory.Exists(folderPath))
                {

                    Console.WriteLine(filePath);
                    File.WriteAllText(filePath, json);
                }
                else
                {
                    Directory.CreateDirectory(folderPath);

                    File.WriteAllText(filePath, json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //***************************************READ ALL PARAMETERS FROM DAT FILE***********************
public void LoadProgramParameters()
        {
           


            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    test = JsonConvert.DeserializeObject<TestingModel>(json);
                    // Console.WriteLine(data.lamps[0].voltage.test_voltage[0]);
                    //   L1V1range = $"{test.lamps[0].voltage.min_voltage[0]}V - {test.lamps[0].voltage.max_voltage[0]}V";

                 for(int i =0; i<test.lamps.Length;i++)
                    {
                        
                        
                       
                    }
                }

            }
            catch (Exception ex)
            {MessageBox.Show(ex.Message,$"Error While Loading {fileName} parameters ");
            }

        }





        
    }


}
