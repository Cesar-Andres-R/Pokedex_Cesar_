using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex_Cesar_.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_Cesar_.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pagina1 : ContentPage
	{
        public pagina1()
        {
            InitializeComponent();
            BindingContext = new VMpagina1(Navigation);
        }
    }
}