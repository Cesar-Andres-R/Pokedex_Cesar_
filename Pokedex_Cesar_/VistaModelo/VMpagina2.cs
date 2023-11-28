using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex_Cesar_.Modelo;

namespace Pokedex_Cesar_.VistaModelo
{
    public class VMpagina2 : BaseWiewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MiUsuario> listaUsuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarUsuarios()
        {
            listaUsuarios = new List<MiUsuario> {
                new MiUsuario
                {
                    Nombre = "PepeMapache",
                    Imagen = "https://i.ibb.co/HHpNTgy/mapache.png"
                }
                ,
                new MiUsuario
                {
                    Nombre = "AliciaZorrita",
                    Imagen = "https://i.ibb.co/LJpX4Nh/zorro.png"
                },
                new MiUsuario
                {
                    Nombre = "LuluConeja",
                    Imagen = "https://i.ibb.co/hdbS0X1/conejo.png"
                }
            };
        }
        public async Task Alerta(MiUsuario parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "OK");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesosSimplescommand => new Command(ProcesosSimples);
        public ICommand Alertacommand => new Command<MiUsuario>(async (p) => await Alerta(p));
        #endregion

    }
}
