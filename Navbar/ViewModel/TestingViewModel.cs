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
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
namespace Navbar.ViewModel
{
    public class TestingViewModel:BaseClass
    {

       
 //*******************  Valiable devlarations Section 
       


        public static string folderPath = @"C:\HpTech";
        public  static string ProgramName;
        public string[] _Cbox_Pname_Items = new string[50];
      



        public string tbl_online_details { get; set; } = "testing on";
        public string tbl_status { get; set; } = "PASS";
        public string tbl_message { get; set; } = "message for failure";
        public string L1V1range { get; set; } = "raw data";

     



        public TestingViewModel()
        {
            LoadProgramNames(folderPath);

            testingmodel = new TestingModel();
            lamp1= new Lamps();

            //lamp1= new Lamps();
            //lamp1 = testingmodel.lamps[1];
            //lamp1 = testingmodel.lamps[2];
            //lamp1 = testingmodel.lamps[3];
            //lamp1 = testingmodel.lamps[4];


        }





        //********************* PROGRAM NAME LOADING IN  COMBOBOX ************************************************************************

        public string[] Cbox_Pname_Items
        {
            get { return _Cbox_Pname_Items; }
            set
            {
                if (_Cbox_Pname_Items != value)
                {
                    _Cbox_Pname_Items = value;
                    OnPropertyChanged(nameof(Cbox_Pname_Items));
                }
            }
        }

       
        public void LoadProgramNames(string path)
        {
            try
            { 
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);
                    int i = 0;
                    foreach (string file in files)
                    {
                        Cbox_Pname_Items[i++] = Path.GetFileNameWithoutExtension(file);
                    }
                    
                }
                else
                {
                    Directory.CreateDirectory(path);

                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}", "Error While Program Loading");
            }
        }



        //***************************************    Loading program parameter name After selection on COMBOBOX   ***********************

        public int online_voltage = 0;
        public int online_current = 0;
        private TestingModel _testingmodel;
        public TestingModel testingmodel
        {
            get { return _testingmodel; }
            set
            {
                if (_testingmodel != value)
                {
                    _testingmodel = value;
                    OnPropertyChanged(nameof(testingmodel));
                }
            }
        }
        public RelayCommand<object> LoadParameters => new(execute => LoadProgramParameters());

        private string _selectedItem;
        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));

                    // Execute command when item is selected
                    LoadParameters.Execute(value);
                }
            }
        }
        private Lamps _lamps;
        public Lamps lamp1
        {
            get { return _lamps; }
            set
            {
                if (_lamps != value)
                {
                    _lamps = value;
                    OnPropertyChanged(nameof(lamp1));

                   
                }
            }
        }

        public void LoadProgramParameters()
        {
            string ext = ".dat";
            string program_path= Path.Combine(folderPath, SelectedItem+ext);

            //MessageBox.Show($"{program_path} paramereter loading called");
            try
            {
                string json = File.ReadAllText(program_path);
               // MessageBox.Show(json);
                testingmodel = JsonConvert.DeserializeObject<TestingModel>(json);
                lamp1.DeepCopyFrom(testingmodel.lamps[0]);
                string l1 = JsonConvert.SerializeObject(lamp1);
                //lamp2 = testingmodel.lamps[1];
                //lamp3 = testingmodel.lamps[2];
                //lamp4 = testingmodel.lamps[3];
                //lamp5 = testingmodel.lamps[4];
                MessageBox.Show(l1);
              
             

                MessageBox.Show("tv 0"+lamp1.min_voltage[0].ToString());


                //MessageBox.Show("tv 0" + lamp1.test_voltage[1].ToString());

                //MessageBox.Show("tv 0" + lamp1.test_voltage[2].ToString());

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //******************* Test Start ****************
        public RelayCommand<object> TestStart => new(execute => TestingStart());

        private void TestingStart()
        {
            if (InitialConditions())
            {
                MessageBox.Show("testing start");
            }
            //lamp 1 testing
            SetVoltage(lamp1.test_voltage[0]);
          MessageBox.Show(  getVoltage().ToString() );
           
        }


        //************* Instrument control Section **************
        float Onlinevoltage;
        bool InitialConditions()
        {

            return true;
        }
        float getVoltage()
        {
          
            return Onlinevoltage;
        }
         void SetVoltage(float voltage)
        {
            Onlinevoltage = voltage;
           
        }

    }




}
