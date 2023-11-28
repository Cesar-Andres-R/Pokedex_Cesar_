using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex_Cesar_.Modelo;
using Pokedex_Cesar_.Datos;

namespace Pokedex_Cesar_.VistaModelo.VMPokemon
{
    public class VMRegistrarPokemon : BaseWiewModel
    {
        #region VARIABLES
        string _txtColorFondo;
        string _txtColorPoder;
        string _txtNombre;
        string _txtNro;
        string _txtPoder;
        string _txtIcono;
        #endregion
        #region CONSTRUCTOR
        public VMRegistrarPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string TxtColorFondo
        {
            get { return _txtColorFondo; }
            set { SetValue(ref _txtColorFondo, value); }
        }
        public string TxtColorPoder
        {
            get { return _txtColorPoder; }
            set { SetValue(ref _txtColorPoder, value); }
        }
        public string TxtNombre
        {
            get { return _txtNombre; }
            set { SetValue(ref _txtNombre, value); }
        }
        public string TxtNro
        {
            get { return _txtNro; }
            set { SetValue(ref _txtNro, value); }
        }
        public string TxtPoder
        {
            get { return _txtPoder; }
            set { SetValue(ref _txtPoder, value); }
        }
        public string TxtIcono
        {
            get { return _txtIcono; }
            set { SetValue(ref _txtIcono, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new DPokemon();
            var parametros = new MPokemon();
            parametros.ColorFondo = TxtColorFondo;
            parametros.ColorPoder = TxtColorPoder;
            parametros.Icono = TxtIcono;
            parametros.Nombre = TxtNombre;
            parametros.NroOrden = TxtNro;
            parametros.Poder = TxtPoder;

            await funcion.InsertarPokemon(parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
