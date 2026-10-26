using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioFormsApp
{
    public partial class MenuPrincipalAdminForm : Form
    {
        private Usuario usuarioActual;
        public MenuPrincipalAdminForm(Usuario usuarioLog)
        {
            InitializeComponent();

            usuarioActual = usuarioLog;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosForm menu = new ProductosForm();
            this.Hide();
            menu.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
