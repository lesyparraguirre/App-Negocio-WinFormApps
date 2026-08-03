using Negocio;
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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();

            ProductoNegocio negocio = new ProductoNegocio();
            var lista = negocio.ListarProductos();

            dataGridView2.DataSource = lista;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
