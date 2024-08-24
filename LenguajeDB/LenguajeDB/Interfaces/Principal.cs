using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Clientes;
using LenguajeDB.Funciones.Pedidos;
using LenguajeDB.Funciones.Productos;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        public Cliente cliente { set; get; }
        private void button1_Click(object sender, EventArgs e)
        {
            FiltroCliente frm = new FiltroCliente(this);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int? idProducto = null;

            // Intentar convertir el valor de txtPedidoFiltro a un número entero
            if (int.TryParse(txtIDProducto.Text, out int parsedIdCliente))
            {
                idProducto = parsedIdCliente;
            }
            dgvFiltroProductos.Rows.Clear();
            try
            {
                Funciones_productos funciones = new Funciones_productos();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.FiltrarProducto(idProducto, txtDescProducto.Text);

                // Verificar si el DataSet contiene datos
                if (sucursalesDataSet.Tables.Count > 0 && sucursalesDataSet.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in sucursalesDataSet.Tables[0].Rows)
                    {
                        dgvFiltroProductos.Rows.Add(
                            row["ID_PRODUCTO"],
                            row["DESCRIPCION"],
                            row["PRECIO"],
                            row["STOCK"],
                            row["ID_CATEGORIA"],
                            row["ID_SUCURSAL"],
                            row["ACTIVO"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgvFiltroProductos.Rows[e.RowIndex];


                row.Selected = true;
                txtIDProdCompra.Text = row.Cells[0].Value.ToString();
                txtDescCompra.Text = row.Cells[1].Value.ToString();
                numPrecio.Value = Decimal.Parse(row.Cells[2].Value.ToString());
                numCantidad.Value = 1;
            }
        }

        private void selectCHG(object sender, EventArgs e)
        {
            if (dgvFiltroProductos.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgvFiltroProductos.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void btnClientesAbrir_Click(object sender, EventArgs e)
        {

        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            txtCalculo.Text = (numCantidad.Value * numPrecio.Value).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvCaja.Rows.Add(txtIDProdCompra.Text, txtDescCompra.Text, numPrecio.Value, numCantidad.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvCaja.Rows.Clear();
        }

        private void ModificarProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgvCaja.Rows[e.RowIndex];
                row.Selected = true;
                numTotalProd.Value = Int32.Parse(row.Cells[3].Value.ToString());
            }
        }

        private void selectCHG2(object sender, EventArgs e)
        {
            if (dgvFiltroProductos.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgvFiltroProductos.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void valCHG(object sender, EventArgs e)
        {
            if (dgvCaja.SelectedRows.Count > 0)
            {
                dgvCaja.SelectedRows[0].Cells[3].Value = numTotalProd.Value;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvCaja.SelectedRows.Count > 0)
            {
                dgvCaja.Rows.RemoveAt(dgvCaja.SelectedRows[0].Index);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            List<DetallePedido> productos = new List<DetallePedido>();
            if (dgvCaja.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCaja.Rows)
                {
                    if (!row.IsNewRow) // Verificar que no sea la fila nueva vacía
                    {
                        int idProducto = Convert.ToInt32(row.Cells[0].Value); // Columna 0 es ID_PRODUCTO
                        decimal precio = Convert.ToDecimal(row.Cells[2].Value); // Columna 2 es PRECIO
                        int cantidad = Convert.ToInt32(row.Cells[3].Value); // Columna 3 es CANTIDAD

                        // Crear instancia de DetallePedido y añadirla a la lista
                        DetallePedido detalle = new DetallePedido(0, 0, idProducto, cantidad, precio);
                        productos.Add(detalle);
                    }
                }
                Funciones_Pedidos funciones = new Funciones_Pedidos();
                List<LineaFactura> lineas = new List<LineaFactura>();
                Random rand = new Random();

                // Generar 10 LineasFactura con valores aleatorios
                foreach (DataGridViewRow row in dgvCaja.Rows)
                {
                    if (!row.IsNewRow) // Verificar que no sea la fila nueva vacía
                    {
                        int idProducto = Convert.ToInt32(row.Cells[0].Value); // Columna 0 es ID_PRODUCTO
                        String desc = row.Cells[1].Value.ToString();
                        decimal precio = Convert.ToDecimal(row.Cells[2].Value); // Columna 2 es PRECIO
                        int cantidad = Convert.ToInt32(row.Cells[3].Value); // Columna 3 es CANTIDAD

                        // Crear instancia de DetallePedido y añadirla a la lista
                        LineaFactura detalle = new LineaFactura(idProducto, desc, precio, cantidad);
                        lineas.Add(detalle);
                    }
                }
                if (funciones.RegistrarPedido(Int32.Parse(txtNuevoCliente.Text), productos))
                {
                    MessageBox.Show("Compra finalizada");
                    dgvCaja.Rows.Clear();
                    dgvFiltroProductos.Rows.Clear();
                    numTotalProd.Value = 0;
                    txtNuevoCliente.Text = string.Empty;
                    txtNuevoNombre.Text = string.Empty;
                    txtNuevoApellido.Text = string.Empty;
                    txtNuevoNum.Text = string.Empty;
                    txtIDProdCompra.Text = string.Empty;
                    numPrecio.Value = 0;
                    numCantidad.Value = 0;
                    txtCalculo.Text = string.Empty;
                }
                Imprimir imp = new Imprimir(lineas, cliente, new Totales(lineas));
                imp.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Agregue productos primero");
            }
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDescCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sucursales frm = new Sucursales();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Categoria frm = new Categoria();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Accesorios frm = new Accesorios();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Devoluciones frm= new Devoluciones();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Sesion.ObtenerInstancia().UserRole == Rol.Cliente)
            {
                tbCRLT.Enabled = false;
                btnUsuarios.Enabled = false;
                btnUsuarios.BackColor = Color.Gray;
                btnBuscarPedido.BackColor = Color.Gray;
                btnClientes.Enabled = false;
                btnClientes.BackColor = Color.Gray;

            }

            if (Sesion.ObtenerInstancia().UserRole != Rol.Admin)
            {
                btnEmpleados.Enabled = false;
                btnEmpleados.BackColor = Color.Gray;
            }
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtClienteFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPedidoFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
