using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Navbar.View.CustomControles
{
    public partial class TestInput : UserControl
    {
        public static readonly DependencyProperty _vmin = DependencyProperty.Register("Vmin", typeof(string), typeof(TestInput), new PropertyMetadata("Min Voltage"));
        public string Vmin { get { return (string)GetValue(_vmin); } set { SetValue(_vmin, value); } }


        public static readonly DependencyProperty _vmax = DependencyProperty.Register("Vmax", typeof(string), typeof(TestInput), new PropertyMetadata("Max Voltage"));
        public string Vmax { get { return (string)GetValue(_vmax); } set { SetValue(_vmax, value); } }


        public static readonly DependencyProperty _vtest = DependencyProperty.Register("Vtest", typeof(string), typeof(TestInput), new PropertyMetadata("Test Voltage"));
        public string Vtest { get { return (string)GetValue(_vtest); } set { SetValue(_vtest, value); } }


        public static readonly DependencyProperty _voffset = DependencyProperty.Register("Voffset", typeof(string), typeof(TestInput), new PropertyMetadata("Offset Voltage"));
        public string Voffset { get { return (string)GetValue(_voffset); } set { SetValue(_voffset, value); } }




        public static readonly DependencyProperty _cmin = DependencyProperty.Register("Cmin", typeof(string), typeof(TestInput), new PropertyMetadata("Min Current"));
        public string Cmin { get { return (string)GetValue(_cmin); } set { SetValue(_cmin, value); } }


        public static readonly DependencyProperty _cmax = DependencyProperty.Register("Cmax", typeof(string), typeof(TestInput), new PropertyMetadata("Max Current"));
        public string Cmax { get { return (string)GetValue(_cmax); } set { SetValue(_cmax, value); } }


        public static readonly DependencyProperty _ctest = DependencyProperty.Register("Ctest", typeof(string), typeof(TestInput), new PropertyMetadata("Test Current"));
        public string Ctest { get { return (string)GetValue(_ctest); } set { SetValue(_ctest, value); } }


        public static readonly DependencyProperty _coffset = DependencyProperty.Register("Coffset", typeof(string), typeof(TestInput), new PropertyMetadata("Offset Current"));
        public string Coffset { get { return (string)GetValue(_coffset); } set { SetValue(_coffset, value); } }



        public static readonly DependencyProperty _lamp_on = DependencyProperty.Register("LampOn", typeof(ICommand), typeof(TestInput), new PropertyMetadata(null));
        public ICommand LampOn {get { return (ICommand)GetValue(_lamp_on);} set { SetValue(_lamp_on, value); }




        }
        public TestInput()
        {
            InitializeComponent();

        }
    }
}
