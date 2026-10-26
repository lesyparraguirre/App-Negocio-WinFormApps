using dominio;
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
    public partial class MenuPrincipalUsuarioForm : Form
    {
        private Usuario usuarioActual;
        public MenuPrincipalUsuarioForm(Usuario usuarioLog)
        {
            InitializeComponent();

            usuarioActual = usuarioLog;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipalUsuarioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
