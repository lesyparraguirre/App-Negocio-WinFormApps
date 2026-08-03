using datos;
using System;

namespace negocio
{
    public class UsuarioNegocio
    {
        public bool Login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass))
            {
                return false;
            }

            UsuarioDatos datosUsuario = new UsuarioDatos();

            return datosUsuario.Login(user.Trim(), pass);
        }
    }
}