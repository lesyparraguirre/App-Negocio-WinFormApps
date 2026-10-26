using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text;

            UsuarioNegocio negocio = new UsuarioNegocio();

            Usuario usuarioLog = negocio.Login(user, pass);

            if (usuarioLog != null)
            {
                if(usuarioLog.Rol.Id == 1)
                {
                    lblError.Text = "";

                    MenuPrincipalAdminForm menu = new MenuPrincipalAdminForm(usuarioLog);

                    this.Hide();
                    menu.ShowDialog();

                    this.Show();
                }
                else if(usuarioLog.Rol.Id == 2)
                {
                    lblError.Text = "";

                    MenuPrincipalUsuarioForm menu = new MenuPrincipalUsuarioForm(usuarioLog);

                    this.Hide();
                    menu.ShowDialog();

                    this.Show();
                }
               
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos.";

                txtUsuario.Clear();
                txtContraseña.Clear();

                txtUsuario.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
