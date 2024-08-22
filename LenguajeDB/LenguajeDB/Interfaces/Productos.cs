using LenguajeDB.Conexion;
using LenguajeDB.Funciones.Accesorios;
using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Productos;
using LenguajeDB.Funciones.Sucursales;
using LenguajeDB.Utilidad;
using Oracle.ManagedDataAccess.Client;
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
    public partial class Productos : Form
    {

        private Conn dbConn;
        public Productos()
        {
            InitializeComponent();
            dbConn = new Conn();
        }

        private void Producto_Crud_Load(object sender, EventArgs e)
        {

        }
        private CategoriaClass obtenerCategoria()
        {

            if (cmbCategoria.SelectedItem != null)
            {
                CategoriaClass categoriaSeleccionada = (CategoriaClass)cmbCategoria.SelectedItem;

                return categoriaSeleccionada;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoría.");
                return null;
            }
        }
        private ItemCombo obtenerSucursal()
        {

            if (cmbSucursal.SelectedItem != null)
            {
                ItemCombo sucursalSeleccionada = (ItemCombo)cmbSucursal.SelectedItem;

                return sucursalSeleccionada;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una sucursal.");
                return null;
            }
        }



        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Funciones_productos funciones = new Funciones_productos();
            bool exito = funciones.RegistrarProducto(txtDescripcion.Text, numPrecio.Value, Int32.Parse(numStock.Value.ToString()), obtenerCategoria().IdCategoria, obtenerSucursal().Id, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha creado con éxito");
                txtDescripcion.Text = "";
                txtId.Text = "";
                cmbActivo.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
                numPrecio.Value = 0;
                numStock.Value = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void altoTextBox1_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void altoTextBox1_precio_Click(object sender, EventArgs e)
        {

        }

        private void altoTextBox1_stock_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_productos funciones = new Funciones_productos();
            bool exito = funciones.ModificarProducto(Int32.Parse(txtId.Text), txtDescripcion.Text, numPrecio.Value, Int32.Parse(numStock.Value.ToString()), obtenerCategoria().IdCategoria, obtenerSucursal().Id, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha modificado con éxito");
                txtDescripcion.Text = "";
                txtId.Text = "";
                cmbActivo.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
                numPrecio.Value = 0;
                numStock.Value = 0;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_productos funciones = new Funciones_productos();
            bool exito = funciones.EliminarProducto(Int32.Parse(txtId.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtDescripcion.Text = "";
                txtId.Text = "";
                cmbActivo.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
                numPrecio.Value = 0;
                numStock.Value = 0;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarSucursales();
            if (Sesion.ObtenerInstancia().UserRole == Rol.Cliente)
            {
                // Set button colors to gray
                btn_actualizar.BackColor = Color.Gray;
                btn_eliminar.BackColor = Color.Gray;
                btn_registrar.BackColor = Color.Gray;
                btn_actualizar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_registrar.Enabled = false;
                txtDescripcion.Enabled = false;
                txtId.Enabled = false;
                cmbActivo.Enabled = false;
                cmbCategoria.Enabled = false;
                cmbSucursal.Enabled = false;
                numPrecio.Enabled = false;
                numStock.Enabled = false;
            }
        }

        private void cargarSucursales()
        {
            Funciones_Sucursal funciones = new  Funciones_Sucursal();
            DataSet categoriasDataSet = funciones.ObtenerSucursales();

            // Verificar si el DataSet contiene datos
            if (categoriasDataSet.Tables.Count > 0 && categoriasDataSet.Tables[0].Rows.Count > 0)
            {
                // Crear una lista para almacenar las categorías
                List<ItemCombo> sucursales = new List<ItemCombo>();

                // Iterar sobre cada fila del DataTable y agregarlas a la lista de categorías
                foreach (DataRow row in categoriasDataSet.Tables[0].Rows)
                {
                    int idSucursal = Convert.ToInt32(row["ID_SUCURSAL"]);
                    string Nombre = row["NOMBRE"].ToString();

                    // Crear objeto Categoria y agregarlo a la lista
                    ItemCombo itemCombo = new ItemCombo(idSucursal, Nombre);
                    sucursales.Add(itemCombo);
                }

                // Asignar la lista de categorías al ComboBox
                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "Texto";
                cmbSucursal.ValueMember = "Id";

            }
            else
            {
                MessageBox.Show("No se encontraron categorías.");
            }
        }

        private void cargarCategorias()
        {
            Funciones_Categoria funciones = new Funciones_Categoria();
            DataSet categoriasDataSet = funciones.ObtenerCategorias();

            // Verificar si el DataSet contiene datos
            if (categoriasDataSet.Tables.Count > 0 && categoriasDataSet.Tables[0].Rows.Count > 0)
            {
                // Crear una lista para almacenar las categorías
                List<CategoriaClass> categorias = new List<CategoriaClass>();

                // Iterar sobre cada fila del DataTable y agregarlas a la lista de categorías
                foreach (DataRow row in categoriasDataSet.Tables[0].Rows)
                {
                    int idCategoria = Convert.ToInt32(row["ID_CATEGORIA"]);
                    string descripcion = row["NOMBRE"].ToString();

                    // Crear objeto Categoria y agregarlo a la lista
                    CategoriaClass categoria = new CategoriaClass(idCategoria, descripcion);
                    categorias.Add(categoria);
                }

                // Asignar la lista de categorías al ComboBox
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Descripcion";
                cmbCategoria.ValueMember = "IdCategoria";

            }
            else
            {
                MessageBox.Show("No se encontraron categorías.");
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dvgProductos.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_productos funciones = new Funciones_productos();
                // Obtener los datos desde la base de datos
                DataSet Productos = funciones.ConsultarProductos();

                // Verificar si el DataSet contiene datos
                if (Productos.Tables.Count > 0 && Productos.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in Productos.Tables[0].Rows)
                    {
                        dvgProductos.Rows.Add(
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

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dvgProductos.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtId.Text = row.Cells[0].Value.ToString();
                txtDescripcion.Text = row.Cells[1].Value.ToString();
                numPrecio.Value = decimal.Parse(row.Cells[2].Value.ToString());
                numStock.Value = decimal.Parse(row.Cells[3].Value.ToString());
                cmbActivo.SelectedIndex = Int32.Parse(row.Cells[6].Value.ToString());

                int idCategoria = Int32.Parse(row.Cells[4].Value.ToString());
                int idSucursal = Int32.Parse(row.Cells[5].Value.ToString());

                // Buscar el índice del elemento en el ComboBox por su ValueMember (IdCategoria)
                int indice = -1;
                foreach (CategoriaClass categoria in cmbCategoria.Items)
                {
                    if (categoria.IdCategoria == idCategoria)
                    {
                        indice = cmbCategoria.Items.IndexOf(categoria);
                        break; // Salir del bucle una vez encontrado el índice
                    }
                }

                // Seleccionar el elemento en el ComboBox si se encontró el índice
                if (indice != -1)
                {
                    cmbCategoria.SelectedIndex = indice;
                }
                else
                {
                    MessageBox.Show($"No se encontró ninguna categoría con el ID {idCategoria}");
                }

                int indice2 = -1;
                foreach (ItemCombo sucursal in cmbSucursal.Items)
                {
                    if (sucursal.Id == idSucursal)
                    {
                        indice2 = cmbSucursal.Items.IndexOf(sucursal);
                        break; // Salir del bucle una vez encontrado el índice
                    }
                }

                // Seleccionar el elemento en el ComboBox si se encontró el índice
                if (indice2 != -1)
                {
                    cmbSucursal.SelectedIndex = indice2;
                }
                else
                {
                    MessageBox.Show($"No se encontró ninguna sucursal con el ID {idSucursal}");
                }
            }
        }

        private void selectCHG(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dvgProductos.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }
    }
}
