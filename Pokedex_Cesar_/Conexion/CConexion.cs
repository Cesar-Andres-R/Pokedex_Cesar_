using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Pokedex_Cesar_.Conexion
{
    public class CConexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-pokedex-e7d60-default-rtdb.firebaseio.com/");
    }
}
