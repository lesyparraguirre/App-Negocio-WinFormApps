using datos;
using dominio;
using System;

namespace negocio
{
    public class UsuarioNegocio
    {
        public Usuario Login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass))
            {
                return null;
            }

            UsuarioDatos datosUsuario = new UsuarioDatos();

            return datosUsuario.Login(user.Trim(), pass);
        }
    }
}