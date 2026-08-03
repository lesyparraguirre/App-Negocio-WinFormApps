using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class UsuarioDatos
    {
        public bool Login(string user, string pass)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT * FROM Usuario WHERE nombre = @nombre AND contrasenia = @contrasenia");
                datos.SetearParametro("@nombre", user);
                datos.SetearParametro("@contrasenia", pass);

                datos.EjecutarLectura();

                return datos.Lector.Read();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
