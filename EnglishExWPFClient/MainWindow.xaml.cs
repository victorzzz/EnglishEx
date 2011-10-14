using System;
using System.Collections.Generic;
using System.Linq;
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
using EnglishExWPFClient.AccountServiceReference;

namespace EnglishExWPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EnglishExAccountClient accountServiceClient = new EnglishExAccountClient();
            string token = null;
            string errorMessage = null;
            bool loginResult = accountServiceClient.Login(userNameTextBox.Text, passwordTextBox.Text, ref errorMessage, ref token);
            if (loginResult)
            {
                resultLabel.Content = "OK, token: " + token;
            }
            else
            {
                resultLabel.Content = "ERROR : " + errorMessage;
            }
        }
    }
}
