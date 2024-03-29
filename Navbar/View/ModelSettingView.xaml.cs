using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Shapes;
using Navbar.Commands;
using Navbar.Model;
using Navbar.ViewModel;
using Newtonsoft.Json;
using static Navbar.ViewModel.TestingViewModel;


namespace Navbar.View
{
    /// <summary>
    /// Interaction logic for ModelSettingView.xaml
    /// </summary>
    public partial class ModelSettingView
    {
        //  TestingModel test = new TestingModel();
        // Lamps l = new Lamps();
        // Voltage voltage = new Voltage();
        //  Current current = new Current();

        //static string model_name = "Z101";
        // static  string folderPath = @"C:\HpTech";
        //string filePath = $"{folderPath}\\{model_name}.dat";
        public ModelSettingView()
        {
            DataContext = new ModelSettingViewModel(); 
            InitializeComponent();
        }

        //private void btn_save_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    SaveProgram();
        //}



        //public void SaveProgram()
        //{

        //test.model_name = "ABRA";
        //test.barcodes[0] = tbx_barcode1.Text;


        //voltage.test_voltage = [9, 13, 16];
        //voltage.offset_voltage = [0, 0, 0];
        //voltage.min_voltage = [8.9f, 12.9f, 15.9f];
        //voltage.max_voltage = [9.1f, 13.5f, 16.2f];
        //Current current = new Current();
        //current.test_current = [1.3f, 2.4f, 3f];
        //current.min_current = [1, 2, 3,];
        //current.max_current = [2, 3, 4];
        ////current.offset_current = [0, 0, 0];


        //    l.lamp_name = "stop";
        //    l.voltage = voltage;
        //    l.current = current;
        //    test.lamps = [l];


        //    string json = JsonConvert.SerializeObject(test, Formatting.Indented);



        //    try
        //    {
        //        if (Directory.Exists(folderPath))
        //        {
        //            File.WriteAllText(filePath, json);
        //            MessageBox.Show(json,"data saved to file");
        //        }
        //        else
        //        {
        //            Directory.CreateDirectory(folderPath);
        //            File.WriteAllText(filePath, json);
        //            MessageBox.Show(json, "data saved to file");

        //        }

        //    }

        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}


        ////    public RelayCommand<object> Test => new(para => _LampOn(para));

        ////    public void _LampOn(object parameter)
        ////    {
        ////        var data = parameter as object[];

        ////        MessageBox.Show($"min value: {data[0].ToString()}");
        ////        MessageBox.Show($"max value: {data[1].ToString()}");
        ////    }


        ////}

        ////public class MyConvertor : IMultiValueConverter
        ////{
        ////    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        ////    {
        ////        return values.Clone();
        ////    }

        ////    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        ////    {
        ////        throw new NotImplementedException();
        ////    }
        ////}


        ////public class Voltage : BaseClass
        ////{
        ////    private ObservableCollection<string> minVoltage;
        ////    private ObservableCollection<string> maxVoltage;
        ////    private ObservableCollection<string> testVoltage;
        ////    private ObservableCollection<string> offsetVoltage;

        ////    public ObservableCollection<string> MinVoltage
        ////    {
        ////        get { return minVoltage; }
        ////        set
        ////        {
        ////            if (minVoltage != value)
        ////            {
        ////                minVoltage = value;
        ////                OnPropertyChanged(nameof(MinVoltage));
        ////            }
        ////        }
        ////    }

        ////    public ObservableCollection<string> MaxVoltage
        ////    {
        ////        get { return maxVoltage; }
        ////        set
        ////        {
        ////            if (maxVoltage != value)
        ////            {
        ////                maxVoltage = value;
        ////                OnPropertyChanged(nameof(MaxVoltage));
        ////            }
        ////        }
        ////    }

        ////    public ObservableCollection<string> TestVoltage
        ////    {
        ////        get { return testVoltage; }
        ////        set
        ////        {
        ////            if (testVoltage != value)
        ////            {
        ////                testVoltage = value;
        ////                OnPropertyChanged(nameof(TestVoltage));
        ////            }
        ////        }
        ////    }

        ////    public ObservableCollection<string> OffsetVoltage
        ////    {
        ////        get { return offsetVoltage; }
        ////        set
        ////        {
        ////            if (offsetVoltage != value)
        ////            {
        ////                offsetVoltage = value;
        ////                OnPropertyChanged(nameof(OffsetVoltage));
        ////            }
        ////        }
        ////    }


        ////}




        }

}
