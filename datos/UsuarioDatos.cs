using Datos;
using dominio;
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
        public Usuario Login(string user, string pass)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(
            @"SELECT u.Id, u.Nombre, u.IdRol, r.Descripcion
              FROM Usuario u
              INNER JOIN Rol r ON u.IdRol = r.Id
              WHERE u.Nombre = @nombre
              AND u.Contrasenia = @contrasenia");

                datos.SetearParametro("@nombre", user);
                datos.SetearParametro("@contrasenia", pass);

                datos.EjecutarLectura();
                if (datos.Lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Nombre = (string)datos.Lector["Nombre"];

                    usuario.Rol = new Rol();
                    usuario.Rol.Id = (int)datos.Lector["IdRol"];
                    usuario.Rol.Descripcion = (string)datos.Lector["Descripcion"];

                    return usuario;
                }

                return null;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
