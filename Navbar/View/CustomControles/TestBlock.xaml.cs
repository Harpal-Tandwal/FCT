using Navbar.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;


namespace Navbar.View.CustomControles
{
    /// <summary>
    /// Interaction logic for TestBlock.xaml
    /// </summary>
    public partial class TestBlock 
    {
        public static readonly DependencyProperty Text1Property =DependencyProperty.Register("Text1", typeof(string), typeof(TestBlock));

        public static readonly DependencyProperty Text2Property =DependencyProperty.Register("Text2", typeof(string), typeof(TestBlock));

        public static readonly DependencyProperty Text3Property =DependencyProperty.Register("Text3", typeof(string), typeof(TestBlock));

        public static readonly DependencyProperty Text4Property =DependencyProperty.Register("Text4", typeof(string), typeof(TestBlock));

        public static readonly DependencyProperty Text5Property= DependencyProperty.Register("Text5",typeof(string), typeof(TestBlock));

        public static readonly DependencyProperty Text6Property = DependencyProperty.Register("Text6", typeof(string), typeof(TestBlock));

        public string Text1
        {
            get { return (string)GetValue(Text1Property); }
            set { SetValue(Text1Property, value); }
        }

        public string Text2
        {
            get { return (string)GetValue(Text2Property); }
            set { SetValue(Text2Property, value); }
        }

        public string Text3
        {
            get { return (string)GetValue(Text3Property); }
            set { SetValue(Text3Property, value); }
        }

        public string Text4
        {
            get { return (string)GetValue(Text4Property); }
            set { SetValue(Text4Property, value); }
        }

        public string Text5
        {
            get { return (string)GetValue(Text5Property); }
            set { SetValue(Text5Property, value); }
        }

        public string Text6
        {
            get { return (string)GetValue(Text6Property); }
            set { SetValue(Text6Property, value); }
        }



        public TestBlock()
        {
            InitializeComponent();
        }

    }
}
