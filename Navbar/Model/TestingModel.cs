using Navbar.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Navbar.Model
{
    public class TestingModel:BaseClass
    {
        public string model_name { get; set; }
        public string[] barcode;
        public int[] string_validation_length;
          public Lamps[] lamps;
   
        public TestingModel()
        {
            model_name = string.Empty;
            barcode = new string[4];
            string_validation_length= new int[4];
          lamps = new Lamps[5];

     
        }

    }
        public class Lamps:BaseClass
    {
        //*********************Collection Declaration
        private string _name { get; set; }
        private ObservableCollection<float> _test_voltage;
        private ObservableCollection<float> _min_voltage;
        private ObservableCollection<float> _max_voltage;
        private ObservableCollection<float> _offset_voltage;
        private ObservableCollection<float> _test_current;
        private ObservableCollection<float> _min_current;
        private ObservableCollection<float> _max_current;
        private ObservableCollection<float> _offset_current;



        //public float[] min_voltage { get; set; }
        //public float[] max_voltage { get; set; }
        //public float[] offset_voltage { get; set; }

        //public float[] test_current { get; set; }
        //public float[] min_current { get; set; }
        //public float[] max_current { get; set; }
        //public float[] offset_current { get; set; }


        //********************Collection Definition**************

        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(name));
                }
            }
        }


        //*************************     Test voltage definition

        public ObservableCollection<float> test_voltage
        {
            get { return _test_voltage; }
            set
            {
                if (_test_voltage != value)
                {
                    _test_voltage = value;
                    OnPropertyChanged(nameof(test_voltage));
                }
            }
        }


        public ObservableCollection<float> min_voltage
        {
            get { return _min_voltage; }
            set
            {
                if (_min_voltage != value)
                {
                    _min_voltage = value;
                    OnPropertyChanged(nameof(min_voltage));
                }
            }
        }

        public ObservableCollection<float> max_voltage
        {
            get { return _max_voltage; }
            set
            {
                if (_max_voltage != value)
                {
                    _max_voltage = value;
                    OnPropertyChanged(nameof(max_voltage));
                }
            }
        }

        public ObservableCollection<float> offset_voltage
        {
            get { return _offset_voltage; }
            set
            {
                if (_offset_voltage != value)
                {
                    _offset_voltage = value;
                    OnPropertyChanged(nameof(_offset_voltage));
                }
            }
        }
        public ObservableCollection<float> test_current
        {
            get { return _test_current; }
            set
            {
                if (_test_current != value)
                {
                    _test_current = value;
                    OnPropertyChanged(nameof(test_current));
                }
            }
        }


        public ObservableCollection<float> min_current
        {
            get { return _min_current; }
            set
            {
                if (_min_current != value)
                {
                    _min_current = value;
                    OnPropertyChanged(nameof(min_current));
                }
            }
        }

        public ObservableCollection<float> max_current
        {
            get { return _max_current; }
            set
            {
                if (_max_current != value)
                {
                    _max_current = value;
                    OnPropertyChanged(nameof(max_current));
                }
            }
        }

        public ObservableCollection<float> offset_current
        {
            get { return _offset_current; }
            set
            {
                if (_offset_current != value)
                {
                    _offset_current = value;
                    OnPropertyChanged(nameof(offset_current));
                }
            }
        }

        void copyobj(ObservableCollection<float> original, ObservableCollection<float> other)
        {
            original.Clear();
            int i = 0;
            foreach(float value in other)
            {
                if (i++ <= 2) continue;
                original.Add(value);
            }
        }
        public void DeepCopyFrom(Lamps other)
        {
            // Deep copy the name property
            this.name = other.name;

            copyobj(this.test_voltage, other.test_voltage);
            copyobj(this.offset_voltage, other.offset_voltage);
            copyobj(this.max_voltage, other.max_voltage);
            copyobj(this.min_voltage, other.min_voltage);

            copyobj(this.test_current, other.test_current);
            copyobj(this.min_current, other.min_current);
            copyobj(this.max_current, other.max_current);
            copyobj(this.offset_current, other.offset_current);


        }

        public Lamps()
        {
             offset_voltage = new ObservableCollection<float>(new float[3]);
             max_voltage = new ObservableCollection<float>(new float[3]);
             min_voltage = new ObservableCollection<float>(new float[3]);
             test_voltage = new ObservableCollection<float>(new float[3]);



             test_current = new ObservableCollection<float>(new float[3]);
             min_current = new ObservableCollection<float>(new float[3]);
             max_current = new ObservableCollection<float>(new float[3]);
             offset_current = new ObservableCollection<float>(new float[3]);

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



