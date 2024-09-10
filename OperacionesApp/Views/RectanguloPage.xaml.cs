using Microsoft.Maui.Controls;

namespace OperacionesApp.Views
{
    public partial class RectanguloPage : ContentPage
    {
        public RectanguloPage()
        {
            InitializeComponent();
        }

        private void OnCalcularAreaRectangulo(object sender, EventArgs e)
        {
            if (double.TryParse(baseEntry.Text, out double baseRect) && baseRect > 0 &&
                double.TryParse(alturaEntry.Text, out double alturaRect) && alturaRect > 0)
            {
                double area = baseRect * alturaRect;
                resultadoRectanguloLabel.Text = $"Resultado: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese valores válidos para la base y la altura", "Aceptar");
            }
        }

        private void OnLimpiarRectangulo(object sender, EventArgs e)
        {
            baseEntry.Text = string.Empty;
            alturaEntry.Text = string.Empty;
            resultadoRectanguloLabel.Text = "Resultado:";
        }
    }
}
