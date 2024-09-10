using Microsoft.Maui.Controls;

namespace OperacionesApp.Views
{
    public partial class CuadradoPage : ContentPage
    {
        public CuadradoPage()
        {
            InitializeComponent();
        }

        private void OnCalcularAreaCuadrado(object sender, EventArgs e)
        {
            if (double.TryParse(ladoEntry.Text, out double lado) && lado > 0)
            {
                double area = lado * lado;
                resultadoCuadradoLabel.Text = $"Resultado: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese un valor válido para el lado", "Aceptar");
            }
        }

        private void OnLimpiarCuadrado(object sender, EventArgs e)
        {
            ladoEntry.Text = string.Empty;
            resultadoCuadradoLabel.Text = "Resultado:";
        }
    }
}
