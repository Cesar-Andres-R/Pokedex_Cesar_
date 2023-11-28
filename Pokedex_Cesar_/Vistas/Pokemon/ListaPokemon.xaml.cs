using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex_Cesar_.VistaModelo.VMPokemon;
using Pokedex_Cesar_.Vistas.Pokemon;

namespace Pokedex_Cesar_.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPokemon : ContentPage
	{
		public ListaPokemon ()
		{
            InitializeComponent();
            BindingContext = new VMListaPokemon(Navigation);
        }
	}
}