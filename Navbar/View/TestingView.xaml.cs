using System.ComponentModel;
using System.Windows.Controls;
using Navbar.ViewModel;


namespace Navbar.View
{
    /// <summary>
    /// Interaction logic for TestingView.xaml
    /// </summary>
    public partial class TestingView 
    {
        
        public TestingView()
        {
            DataContext = new TestingViewModel();

           InitializeComponent();

        }
    }
}
