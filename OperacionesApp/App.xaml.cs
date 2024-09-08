namespace OperacionesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage
            {
                Children =
                {
                    new CuadradoPage {Title = "Area Cuadrado"},
                    new CirculoPage { Title = "Area Circulo"},
                    new RectanguloPage { Title = "Area Rectangulo"}
                }
            };
        }
    }
}
