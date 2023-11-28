using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex_Cesar_.VistaModelo.VMPokemon;

namespace Pokedex_Cesar_.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrarPokemon : ContentPage
	{
		public RegistrarPokemon ()
		{
            InitializeComponent();
            BindingContext = new VMRegistrarPokemon(Navigation);
        }
	}
}