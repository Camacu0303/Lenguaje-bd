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
    public partial class FiltroLineapedido : Form
    {
        Devoluciones devoluciones;
        FiltroPedido filtroPedido;
        int Filtro;
        public FiltroLineapedido(Devoluciones devoluciones, FiltroPedido filtroPedido)
        {
            InitializeComponent();
            this.devoluciones = devoluciones;
            this.filtroPedido = filtroPedido;
            Filtro= filtroPedido.ID_pedido;
        }

        private void FiltroLineapedido_Load(object sender, EventArgs e)
        {
            Funciones_Pedidos funciones = new Funciones_Pedidos();


            // Llamar al método FiltrarPedidos con los valores obtenidos
            DataSet dsPedidos = funciones.FiltrarDetallePedido(Filtro);

            // Procesar el DataSet (por ejemplo, enlazarlo a un control DataGridView)
            if (dsPedidos.Tables.Count > 0)
            {
                dgvLinea.DataSource = dsPedidos.Tables[0];
            }
            else
            {
                MessageBox.Show("No hay resultados con los parámetros de búsqueda");
            }
        }

        private void dgvLinea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                DataGridViewRow row = dgvLinea.Rows[e.RowIndex];
                devoluciones.txt_id.Text = row.Cells[0].Value.ToString();
                devoluciones.numCantidad.Value = Decimal.Parse(row.Cells[2].Value.ToString());
                this.Close();
                filtroPedido.Close();
            }
        }

        private void dgvLinea_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLinea.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgvLinea.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void dgvLinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
