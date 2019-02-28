using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace advinanza
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          
            InitializeComponent();
            BotonSorteo.Text = "Click aquí, para validar su número";
            BotonSorteo.Clicked += BotonSorteo_Clicked;
            Numero.Text = "Digite el número para adivinar";
            

            
        }

        private void BotonSorteo_Clicked(object sender, EventArgs e)
        {
            var adivinanza = "500";
            Console.WriteLine ("Digite el número: ");
            Numero.Text = "Digite el numero";
            if (adivinanza == Entrada.Text)
                Numero.Text = "Exito";
            else
                Numero.Text = "Numero incorrecto";

          
            
        }
    }
}
