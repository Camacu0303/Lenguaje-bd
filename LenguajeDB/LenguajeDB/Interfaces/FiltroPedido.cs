using LenguajeDB.Funciones.Pedidos;
using LenguajeDB.Utilidad;
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
    public partial class FiltroPedido : Form
    {
        public Devoluciones frmDev;
        public int ID_pedido;
        public FiltroPedido(Devoluciones frmDev)
        {
            InitializeComponent();
            this.frmDev = frmDev;
        }

        private void FiltroPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            Funciones_Pedidos funciones = new Funciones_Pedidos();

            int? idPedido = null;


            // Intentar convertir el valor de txtPedidoFiltro a un número entero
            if (int.TryParse(txtPedidoFiltro.Text, out int parsedIdPedido))
            {
                idPedido = parsedIdPedido;
            }



            // Llamar al método FiltrarPedidos con los valores obtenidos
            DataSet dsPedidos = funciones.FiltrarPedidos(idPedido, txtClienteFiltro.Text);

            // Procesar el DataSet (por ejemplo, enlazarlo a un control DataGridView)
            if (dsPedidos.Tables.Count > 0)
            {
                dgvPedidos.DataSource = dsPedidos.Tables[0];
            }
            else
            {
                MessageBox.Show("No hay resultados con los parámetros de búsqueda");
            }
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgvPedidos.Rows[e.RowIndex];
                ID_pedido= Int32.Parse(row.Cells[0].Value.ToString());

                FiltroLineapedido frm = new FiltroLineapedido(frmDev, this);
                frm.ShowDialog();
                
            }
        }

        private void selectCHG(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgvPedidos.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
