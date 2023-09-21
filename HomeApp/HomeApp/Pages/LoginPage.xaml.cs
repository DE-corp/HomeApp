using System;

using Xamarin.Forms;

namespace HomeApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            loginButton.Text = "Выполняется вход...";
        }
    }
}