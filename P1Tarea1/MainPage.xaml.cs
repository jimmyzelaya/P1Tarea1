using P1Tarea1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        // FUNCION SUMAR
        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            var num1 = double.Parse(n1.Text);
            var num2 = double.Parse(n2.Text);

            var resul = num1 + num2;
            await DisplayAlert("RESULTADO", "La suma da: " + resul, "LISTO");

            var resultadoS = new Modelos.Resultado
            {
                rResultado = resul.ToString(),
            };

            var pagina = new Paginas.Page2();
            pagina.BindingContext = resultadoS;
            await Navigation.PushAsync(pagina);
        }

        // FUNCION RESTA
        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            var num1 = double.Parse(n1.Text);
            var num2 = double.Parse(n2.Text);

            var resul = num1 - num2;
            await DisplayAlert("RESULTADO", "La resta da: " + resul, "LISTO");

            var resultadoS = new Modelos.Resultado
            {
                rResultado = resul.ToString(),
            };

            var pagina = new Paginas.Page2();
            pagina.BindingContext = resultadoS;
            await Navigation.PushAsync(pagina);
        }

        // FUNCION DIVISION
        private async void btnDivision_Clicked(object sender, EventArgs e)
        {
            var num1 = double.Parse(n1.Text);
            var num2 = double.Parse(n2.Text);

            var resul = num1 / num2;
            await DisplayAlert("RESULTADO", "La division da: " + resul, "LISTO");

            var resultadoS = new Modelos.Resultado
            {
                rResultado = resul.ToString(),
            };

            var pagina = new Paginas.Page2();
            pagina.BindingContext = resultadoS;
            await Navigation.PushAsync(pagina);
        }

        // FUNCION MULTIPLICACION
        private async void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            var num1 = double.Parse(n1.Text);
            var num2 = double.Parse(n2.Text);

            var resul = num1 * num2;
            await DisplayAlert("RESULTADO", "La multiplicacion da: " + resul, "LISTO");

            var resultadoS = new Modelos.Resultado
            {
                rResultado = resul.ToString(),
            };

            var pagina = new Paginas.Page2();
            pagina.BindingContext = resultadoS;
            await Navigation.PushAsync(pagina);
        }
    }
}
