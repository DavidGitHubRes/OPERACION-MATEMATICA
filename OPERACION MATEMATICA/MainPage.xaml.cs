using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OPERACION_MATEMATICA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double xa = Convert.ToDouble(a.Text);
                double xb = Convert.ToDouble(b.Text);
                double resultado = Math.Pow((xa + xb), 2) / 2;

                result.Text = "RESULTADO: " + resultado;
            }catch (Exception ex)
            {
                DisplayAlert("Error","Revise los campos: Error--> " + ex.Message,"Aceptar");
            }
            finally
            {
                a.Focus();
            }
        }
    }
}
