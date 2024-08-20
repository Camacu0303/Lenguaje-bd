using LenguajeDB.Funciones;
using LenguajeDB.Funciones.Accesorios;
using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Clientes;
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
    public partial class FiltroCliente : Form
    {
        private Pedidos frmPedidos;
        public FiltroCliente(Pedidos frmPedidos)
        {
            InitializeComponent();
            this.frmPedidos = frmPedidos;
        }

        private void FiltroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? idCliente = null;

            // Intentar convertir el valor de txtPedidoFiltro a un número entero
            if (int.TryParse(txtId.Text, out int parsedIdCliente))
            {
                idCliente = parsedIdCliente;
            }
            dgvClientes.Rows.Clear();
            try
            {
                Funciones_Clientes funciones = new Funciones_Clientes();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.FiltrarClientes(idCliente, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text);

                // Verificar si el DataSet contiene datos
                if (sucursalesDataSet.Tables.Count > 0 && sucursalesDataSet.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in sucursalesDataSet.Tables[0].Rows)
                    {
                        dgvClientes.Rows.Add(
                            row["ID_CLIENTE"],
                            row["NOMBRE"],
                            row["APELLIDO"],
                            row["TELEFONO"],
                            row["CORREO"],
                            row["DIRECCION"],
                            row["ACTIVO"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los accesorios: " + ex.Message);
            }

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                frmPedidos.txtNuevoCliente.Text= row.Cells[0].Value.ToString();
                frmPedidos.txtNuevoNombre.Text= row.Cells[1].Value.ToString();
                frmPedidos.txtNuevoApellido.Text= row.Cells[2].Value.ToString();
                frmPedidos.txtNuevoNum.Text= row.Cells[3].Value.ToString();
                this.Close();
            }
        }

        private void SelectCHG(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgvClientes.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }
    }
}
