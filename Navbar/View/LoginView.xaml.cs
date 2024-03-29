using System.Windows.Controls;
using Navbar.ViewModel;


namespace Navbar.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            DataContext = new LoginViewModel();
            InitializeComponent();
        }
    }
}
