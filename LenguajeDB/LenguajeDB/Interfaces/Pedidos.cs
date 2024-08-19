using LenguajeDB.Funciones.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeDB.Interfaces
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltroCliente frm= new FiltroCliente();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funciones_Pedidos funciones = new Funciones_Pedidos();

            int? idPedido = null;
            int? idCliente = null;

            // Intentar convertir el valor de txtPedidoFiltro a un número entero
            if (int.TryParse(txtPedidoFiltro.Text, out int parsedIdPedido))
            {
                idPedido = parsedIdPedido;
            }

            // Intentar convertir el valor de txtClienteFiltro a un número entero
            if (int.TryParse(txtClienteFiltro.Text, out int parsedIdCliente))
            {
                idCliente = parsedIdCliente;
            }

            // Llamar al método FiltrarPedidos con los valores obtenidos
            DataSet dsPedidos = funciones.FiltrarPedidos(idPedido, idCliente);

            // Procesar el DataSet (por ejemplo, enlazarlo a un control DataGridView)
            if (dsPedidos.Tables.Count > 0)
            {
                dgvPedidos.DataSource = dsPedidos.Tables[0];
            }
            else {
                MessageBox.Show("No hay resultados con los parámetros de búsqueda");
            }
        }
    }
}
