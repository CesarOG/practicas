using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderEjercicio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var random = new Random();
            double value = e.NewValue;
            _rotacionLabel.Rotation = value;
            _rotacionLabel.TextColor = Color.FromHex(String.Format("#{0:X6}", random.Next(0x1000000)));
            _displayLabel.Text = string.Format("El valor de rotación es {0}", value);
        }
    }
}
