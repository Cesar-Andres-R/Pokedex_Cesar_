using Pokedex_Cesar_.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex_Cesar_.Vistas;

namespace Pokedex_Cesar_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Guardamos esto para volverlo a utilizar
            //MainPage = new NavigationPage(new MenuPrincipal());
            MainPage = new NavigationPage(new ListaPokemon());
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
