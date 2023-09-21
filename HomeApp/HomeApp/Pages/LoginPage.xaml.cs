using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            string xaml = "<Button Text=\"⌛ Выполняется вход..\"  />";
            loginButton.LoadFromXaml(xaml);
        }
    }
}