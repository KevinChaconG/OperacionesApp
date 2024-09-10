using Microsoft.Maui.Controls;

namespace OperacionesApp.Views
{
    public partial class CirculoPage : ContentPage
    {
        public CirculoPage()
        {
            InitializeComponent();
        }

        private void OnCalcularAreaCirculo(object sender, EventArgs e)
        {
            if (double.TryParse(radioEntry.Text, out double radio) && radio > 0)
            {
                double area = Math.PI * radio * radio;
                resultadoCirculoLabel.Text = $"Resultado: {area:F2}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese un valor válido para el radio", "Aceptar");
            }
        }

        private void OnLimpiarCirculo(object sender, EventArgs e)
        {
            radioEntry.Text = string.Empty;
            resultadoCirculoLabel.Text = "Resultado:";
        }
    }
}
