using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        static string Login;
        static string Password;
        public Welcome()
        {
            InitializeComponent();
        }
        private bool CheckFields(string login, string password)
        {
            if (login == null || login.Length <= 2)
            {
                this.DisplayToastAsync("Длина логина должна быть больше 2 символов");

                return false;
            }
            if (password == null || password.Length <= 4)
            {
                this.DisplayToastAsync("Длина пароля должна быть больше 4 символов");
                return false;
            }
            Login = login;
            Password = password;
            return true;
        }
        private void singInButton_Clicked(object sender, EventArgs e)
        {
            if (CheckFields(login.Text, password.Text))
            {
                Navigation.PushAsync(new MainPage(Login, Password));
            }
        }
    }
}