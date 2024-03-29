using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Navbar.Commands;
using Navbar.Model;

namespace Navbar.ViewModel
{
    public class ModelSettingViewModel
    {
        //************* Initialization Section || Constructor *******************************************

            public ModelSettingViewModel() {
            //voltage = new Voltage();
            testingmodel = new TestingModel();
           // current = new Current();
           // lamp1 = new Lamps();
           //lamp1.voltage = voltage;
           // testingmodel.lamps[0]=lamp1;

            fun();

        }
        //************* Variable Declaration Section*******************************************
        public int online_voltage = 0;
        public int online_current = 0;
        public static string? folder_path = @"C:\HpTech\DatFiles";
        public static string model_name = "z101";
        public string filePath = folder_path + "\\" + model_name;

      public  TestingModel testingmodel { get; set; }
        public Voltage voltage;
        public Current current;
        public Lamps lamp1 { get; set; }



        //************* Command Declaration Section*******************************************

        public RelayCommand<object> Test => new(para => _LampOn(para));









        //************* Methdos Declaration Section*******************************************

        public void _LampOn(object parameter)
        {
            var data = parameter as object[];
         
            MessageBox.Show(testingmodel.lamps[0].lamp_name);

           // MessageBox.Show($"max voltage value: {testingmodel.lamps[0].voltage.max_voltage[0]}");
        }

        public void fun()
        {
           
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
