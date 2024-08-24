using LenguajeDB.Funciones.Accesorios;
using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Empleados;
using LenguajeDB.Funciones.Productos;
using LenguajeDB.Funciones.Sucursales;
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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            Funciones_empleados funciones = new Funciones_empleados();
            bool exito = funciones.RegistrarEmpleado(txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, obtenerSucursal().Id, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha creado con éxito");
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cargarSucursales();
        }
        private void cargarSucursales()
        {
            Funciones_Sucursal funciones = new Funciones_Sucursal();
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

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_empleados funciones = new Funciones_empleados();
                // Obtener los datos desde la base de datos
                DataSet Productos = funciones.ObtenerEmpleados();

                // Verificar si el DataSet contiene datos
                if (Productos.Tables.Count > 0 && Productos.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in Productos.Tables[0].Rows)
                    {
                        dataGridView1.Rows.Add(
                            row["ID_EMPLEADO"],
                            row["NOMBRE"],
                            row["APELLIDO"],
                            row["CORREO"],
                            row["TELEFONO"],
                            row["ID_SUCURSAL"],
                            row["ACTIVO"]

                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtID.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtApellido.Text = row.Cells[2].Value.ToString();
                txtCorreo.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[4].Value.ToString();
                int idSucursal = Int32.Parse(row.Cells[5].Value.ToString());
                cmbActivo.SelectedIndex = Int32.Parse(row.Cells[6].Value.ToString());

                
               

                int indice2 = -1;
                foreach (ItemCombo sucursal in cmbSucursal.Items)
                {
                    if (sucursal.Id == idSucursal)
                    {
                        indice2 = cmbSucursal.Items.IndexOf(sucursal);
                        break; 
                    }
                }         
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

        private void SELECTchg(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_empleados funciones = new Funciones_empleados();
            bool exito = funciones.ModificarEmpleado(Int32.Parse(txtID.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, obtenerSucursal().Id, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha modifcado con éxito");
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_empleados funciones = new Funciones_empleados();
            bool exito = funciones.EliminarEmpleado(Int32.Parse(txtID.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                cmbSucursal.SelectedIndex = -1;
                cmbActivo.SelectedIndex = -1;
            }
        }
    }
}
