using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Navbar.Commands;
using Navbar.Model;
using Newtonsoft.Json;

namespace Navbar.ViewModel
{
    public class ModelSettingViewModel:BaseClass
    {
        //************* Initialization Section || Constructor *******************************************

            public ModelSettingViewModel()
        {
            testingmodel = new TestingModel();
          
            lamp1 = new Lamps();
            lamp2 = new Lamps();
            lamp3 = new Lamps();
            lamp4 = new Lamps();
            lamp5 = new Lamps();

            LoadProgramNames(program_folder_path);




        }
        //************* Variable Declaration Section*******************************************
        public int online_voltage = 0;
        public int online_current = 0;

        public static string program_folder_path = @"C:\HpTech";

    

        public  TestingModel testingmodel { get; set; }
        public Lamps lamp1 { get; set; }
        public Lamps lamp2{ get; set; }
        public Lamps lamp3 { get; set; }
        public Lamps lamp4 { get; set; }
        public Lamps lamp5 { get; set; }
        public  string[] Barcode { get; set; }= new string[4];
        public int[] validation { get; set; } = new int[4];



        //************* Command Declaration Section*******************************************

        public RelayCommand<object> Test => new(para => _LampOn(para));
        public RelayCommand<object> SaveProgram => new(para => SaveModel());









        //************* Methdo  Section*******************************************

        public void _LampOn(object parameter)
        {
            //var data = parameter as object[];
            ////MessageBox.Show(data[0].ToString());
            ////  MessageBox.Show(testingmodel.barcode[0]);
            //MessageBox.Show(lamp1.test_voltage[0].ToString());
            //// MessageBox.Show($"max voltage value: {testingmodel.lamps[0].voltage.max_voltage[0]}");


            ////*************
            //try
            //{     string folderPath = @"C:\HpTech";
            //      string ext = ".dat";
            //    string program_path = Path.Combine(folderPath, "Z101"+ ext);
            //    string json = File.ReadAllText(program_path);
            //    // MessageBox.Show(json);
            //    testingmodel = JsonConvert.DeserializeObject<TestingModel>(json);
            //    lamp1 = testingmodel.lamps[0];
            //    string l1 = JsonConvert.SerializeObject(lamp1);
            //    //lamp2 = testingmodel.lamps[1];
            //    //lamp3 = testingmodel.lamps[2];
            //    //lamp4 = testingmodel.lamps[3];
            //    //lamp5 = testingmodel.lamps[4];
            //    MessageBox.Show(l1);

            //    // MessageBox.Show($"volt: {lamp1.name}");

            //    MessageBox.Show("tv 0" + lamp1.test_voltage[0].ToString());





            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }


        ////////////   SAVE PROGRAM   ////////////////
        private void SaveModel()
        {
            try {
                testingmodel.barcode = Barcode;
                testingmodel.string_validation_length = validation;
                testingmodel.lamps[0] = lamp1;
                testingmodel.lamps[1] = lamp2;
                testingmodel.lamps[2] = lamp3;
                testingmodel.lamps[3] = lamp4;
                testingmodel.lamps[4] = lamp5;
                string program = JsonConvert.SerializeObject(testingmodel);
                //string filePath = Path.Combine(program_folder_path, $"{testingmodel.model_name}");
                string filePath = $"{program_folder_path}\\{testingmodel.model_name}.dat";
             
                // Write the JSON string to the file
                File.WriteAllText(filePath, program);
                MessageBox.Show($"Program Saved Succesfully {program}");
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString(),$"Error In Savign Your Program {testingmodel.model_name}");
            }
       

        }

        //******************Loading Existing Programs*****************************************
        public string[] _Cbox_Pname_Items = new string[50];

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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error While Program Loading");
            }
        }



    }


    //************* Class Declaration Section*******************************************




    public class BaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    //************* Convertor Declaration Section*******************************************

    public class MyConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
