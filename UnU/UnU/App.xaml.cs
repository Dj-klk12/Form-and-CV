using System;
using Xamarin.Forms;
using generarcv.View;
using Xamarin.Forms.Xaml;

namespace generarcv
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UnicaPag(
                "Nombre", "Apellido", "Dirección", "correo@example.com", "1234567890",
                "Experiencia 1", "Experiencia 2", "Experiencia 3", "Nivel de inglés",
                "Educación", "Aptitud 1", "Aptitud 2", "Aptitud 3", "Descripción"));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
