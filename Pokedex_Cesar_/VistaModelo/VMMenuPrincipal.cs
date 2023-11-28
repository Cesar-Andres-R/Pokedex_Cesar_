using Pokedex_Cesar_.Modelo;
using Pokedex_Cesar_.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pokedex_Cesar_.VistaModelo
{
    internal class VMMenuPrincipal : BaseWiewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MMenuPrincipal> listaPaginas { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMMenuPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarPaginas()
        {
            listaPaginas = new List<MMenuPrincipal> {
                new MMenuPrincipal
                {
                    Pagina = "Entry, DataPicker, Picker, Label, Navegacion",
                    Icono = "https://i.ibb.co/jfCjZBz/descargar.jpg"
                }
                ,
                new MMenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://i.ibb.co/dQK1N8X/descargar-1.jpg"
                },
                new MMenuPrincipal
                {
                    Pagina = "Crud Pokémon",
                    Icono = "https://i.ibb.co/kSjKRCX/chimchar.jpg"
                }
            };
        }
        public async Task Navegar(MMenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, DataPicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crud Pokémon"))
            {
                await Navigation.PushAsync(new CrudPokemon());
            }
        }
        #endregion
        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesosSimplescommand => new Command(ProcesosSimples);
        public ICommand Navegarcommand => new Command<MMenuPrincipal>(async (p) => await Navegar(p));
        #endregion

    }
}
