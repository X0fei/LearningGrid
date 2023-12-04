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
        public MainWindow()
        {
            InitializeComponent();
        }
        public void RegisterConfirm(object source, RoutedEventArgs args)
        {
            if (password.Text != conformPassword.Text)
            {
                conformPassword.Text = "Пароли должны совпадать";
            }
            else
            {
                loginData = login.Text;
                passwordData = password.Text;
            }
        }
    }
}