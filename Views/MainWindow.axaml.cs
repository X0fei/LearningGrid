using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace LearningGrid.Views
{
    public partial class MainWindow : Window
    {
        string loginData;
        string passwordData;
        string gender;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void RegisterConfirm(object source, RoutedEventArgs args)
        {
            if (password.Text != conformPassword.Text)
            {
                conformPassword.Text = "";
            }
            else
            {
                loginData = login.Text;
                passwordData = password.Text;
                if (female.IsChecked == true)
                    gender = "female";
                else if (male.IsChecked == true)
                    gender = "male";
                else
                    gender = "none";
                new Window2().Show();
                Close();
            }
        }
    }
}