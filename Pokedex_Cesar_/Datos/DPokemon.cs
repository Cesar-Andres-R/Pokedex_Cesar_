using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using Pokedex_Cesar_.Modelo;
using Pokedex_Cesar_.Conexion;

namespace Pokedex_Cesar_.Datos
{
    public class DPokemon
    {
        public async Task InsertarPokemon(MPokemon paramtros)
        {
            await CConexion.firebase.Child("Pokemon")
            .PostAsync(new MPokemon()
            {
                ColorFondo = "#" + paramtros.ColorFondo,
                ColorPoder = "#" + paramtros.ColorPoder,
                Icono = paramtros.Icono,
                Nombre = paramtros.Nombre,
                NroOrden = paramtros.NroOrden,
                Poder = paramtros.Poder
            });
        }
        public async Task<ObservableCollection<MPokemon>> MostrarPokemons()
        {
            //return (await CConexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<MPokemon>())
            //    .Select(item => new MPokemon
            //    {
            //        IdPokemon = item.Key,
            //        Nombre = item.Object.Nombre,
            //        ColorFondo = item.Object.ColorFondo,
            //        ColorPoder = item.Object.ColorPoder,
            //        Icono = item.Object.Icono,
            //        NroOrden = item.Object.NroOrden,
            //        Poder = item.Object.Poder
            //    }).ToList();

            var data = await Task.Run(() => CConexion.firebase
                .Child("Pokemon")
                .AsObservable<MPokemon>()
                .AsObservableCollection());
            return data;
        }
    }
}
