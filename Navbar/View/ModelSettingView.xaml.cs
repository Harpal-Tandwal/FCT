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
 
    public partial class ModelSettingView
    {
     
        public ModelSettingView()
        {
            DataContext = new ModelSettingViewModel(); 
            InitializeComponent();
        }





    }

}
