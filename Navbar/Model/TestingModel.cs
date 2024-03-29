using Navbar.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navbar.Model
{
    public class TestingModel
    {
        public string model_name { get; set; }
        public string[] barcodes;
        public Lamps[] lamps;


        public TestingModel() 
        {
            model_name = string.Empty;
            barcodes = new string[4];
            lamps = new Lamps[5];
        }   

    }

    public class Lamps
    {
        public string lamp_name { get; set; }
        public Voltage voltage { get; set; }

        public Current current { get; set; }

        public Lamps()
        {   voltage = new Voltage();
            current = new Current();
            lamp_name= string.Empty;

        }



    }
    public class Voltage
    {
        public float[] test_voltage { get; set; }
        public float[] min_voltage { get; set; }
        public string[] max_voltage { get; set; }
        public float[] offset_voltage { get; set; }
        public Voltage()
        {
            offset_voltage = new float[3];
            max_voltage = new string[3];
            min_voltage = new float[3];
            test_voltage = new float[3];
            }

    }
    public class Current
    {
        public float[] test_current = new float[3];
        public float[] min_current = new float[3];
        public float[] max_current = new float[3];
        public float[] offset_current = new float[3];

    }


    public class VoltageNew : BaseClass
    {
        private ObservableCollection<string> minVoltage;
        private ObservableCollection<string> maxVoltage;
        private ObservableCollection<string> testVoltage;
        private ObservableCollection<string> offsetVoltage;

        public ObservableCollection<string> MinVoltage
        {
            get { return minVoltage; }
            set
            {
                if (minVoltage != value)
                {
                    minVoltage = value;
                    OnPropertyChanged(nameof(MinVoltage));
                }
            }
        }

        public ObservableCollection<string> MaxVoltage
        {
            get { return maxVoltage; }
            set
            {
                if (maxVoltage != value)
                {
                    maxVoltage = value;
                    OnPropertyChanged(nameof(MaxVoltage));
                }
            }
        }

        public ObservableCollection<string> TestVoltage
        {
            get { return testVoltage; }
            set
            {
                if (testVoltage != value)
                {
                    testVoltage = value;
                    OnPropertyChanged(nameof(TestVoltage));
                }
            }
        }

        public ObservableCollection<string> OffsetVoltage
        {
            get { return offsetVoltage; }
            set
            {
                if (offsetVoltage != value)
                {
                    offsetVoltage = value;
                    OnPropertyChanged(nameof(OffsetVoltage));
                }
            }
        }


    }
    public class BaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}



