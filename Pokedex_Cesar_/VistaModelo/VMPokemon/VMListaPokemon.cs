using Pokedex_Cesar_.Vistas.Pokemon;
using Pokedex_Cesar_.Modelo;
using Pokedex_Cesar_.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pokedex_Cesar_.VistaModelo.VMPokemon
{
    public class VMListaPokemon : BaseWiewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<MPokemon> _listaPokemons;
        #endregion
        #region CONSTRUCTOR
        public VMListaPokemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemons();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public ObservableCollection<MPokemon> ListaPokemons
        {
            get { return _listaPokemons; }
            set
            {
                SetValue(ref _listaPokemons, value);
                OnpropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task MostrarPokemons()
        {
            var funcion = new DPokemon();
            ListaPokemons = await funcion.MostrarPokemons();
        }
        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
