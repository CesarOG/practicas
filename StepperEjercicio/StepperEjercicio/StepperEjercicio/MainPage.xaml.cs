using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StepperEjercicio
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

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotacionLabel.Rotation = value;
            _displayLabel.Text = string.Format("El valor de rotación del Stepper es {0}",value);
        }
    }
}
