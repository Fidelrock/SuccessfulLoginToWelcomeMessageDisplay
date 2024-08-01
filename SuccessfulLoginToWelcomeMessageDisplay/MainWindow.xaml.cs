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

namespace SuccessfulLoginToWelcomeMessageDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _username;

        public MainWindow(string username)
        {
            InitializeComponent();
            _username = username;
            DisplayWelcomeMessage();
        }

        private void DisplayWelcomeMessage()
        {
            txtWelcome.Text = $"Welcome back, {_username}!";
        }
    }
}
