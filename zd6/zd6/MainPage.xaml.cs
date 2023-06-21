using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd6
{
    public partial class MainPage : CarouselPage
    {
        public MainPage(string Login, string Password)
        {
            InitializeComponent();
            login.Text = $"Ваш логин: {Login}";
            password.Text = $"Ваш пароль: {Password}";
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (swich1.IsToggled == true)
            {
                OnOff1.Text = "I";
                OnOff1.Margin = new Thickness(0, 8, 10, 0);
            }
            else
            {
                OnOff1.Text = "O";
                OnOff1.Margin = new Thickness(0, 8, 4, 0);
            }
        }

        private void swich2_Toggled(object sender, ToggledEventArgs e)
        {
            if (swich2.IsToggled == true)
            {
                OnOff2.Text = "I";
                OnOff2.Margin = new Thickness(0, 8, 3, 0);
            }
            else
            {
                OnOff2.Text = "O";
                OnOff2.Margin = new Thickness(0, 8, 0, 0);
            }
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            if (swich3.IsToggled == true)
            {
                OnOff3.Text = "✓";
            }
            else
                OnOff3.Text = "✕";
        }

        private void swich4_Toggled(object sender, ToggledEventArgs e)
        {
            if (swich4.IsToggled == true)
            {
                OnOff4.Text = "✓";
            }
            else
                OnOff4.Text = "✕";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double[] array = new double[4]{ Convert.ToDouble(slider1.Value), Convert.ToDouble(slider2.Value), Convert.ToDouble(slider3.Value), Convert.ToDouble(slider4.Value)};
            double Max = array.Max();
            MaxVlue.Text = $"Максимальное значение Slider'ов: {Max}";
            login.IsVisible = true;
            password.IsVisible = true;
        }

    }
}
