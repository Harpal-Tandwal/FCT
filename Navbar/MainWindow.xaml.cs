using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Navbar.View;

namespace Navbar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TestingView();
        }


        private void login_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new LoginView();
        }

        private void testing_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TestingView();    
        }

        private void model_setting_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ModelSettingView();
        }


    }
}