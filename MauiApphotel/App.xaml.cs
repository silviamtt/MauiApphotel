using Microsoft.Extensions.DependencyInjection;

namespace MauiApphotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new NavigationPage(new Views.Contratacaodahospedagem()))
            {
                Width = 400,
                Height = 600,
            };

            return window;
        }
    }
}