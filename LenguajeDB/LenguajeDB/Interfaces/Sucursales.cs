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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            if (Sesion.ObtenerInstancia().UserRole!=Rol.Admin)
            {
                btn_actualizar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_registrar.Enabled = false;
                txtId.Enabled = false;
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                txtUbicacion.Enabled = false;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Funciones_Sucursal funciones = new Funciones_Sucursal();
            bool exito= funciones.RegistrarSucursal(txtNombre.Text, txtUbicacion.Text, txtTelefono.Text);
            if (exito) {
                MessageBox.Show("Se ha creado con éxito");
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtUbicacion.Text = "";
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dgv_Sucursales.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Sucursal funciones = new Funciones_Sucursal();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.ObtenerSucursales();

                // Verificar si el DataSet contiene datos
                if (sucursalesDataSet.Tables.Count > 0 && sucursalesDataSet.Tables["Sucursales"].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in sucursalesDataSet.Tables["Sucursales"].Rows)
                    {
                        dgv_Sucursales.Rows.Add(
                            row["ID_SUCURSAL"],
                            row["NOMBRE"],
                            row["UBICACION"],
                            row["TELEFONO"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron sucursales.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgv_Sucursales.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtId.Text= row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtUbicacion.Text = row.Cells[2].Value.ToString();
                txtTelefono.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Changed(object sender, EventArgs e)
        {
            if (dgv_Sucursales.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgv_Sucursales.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Sucursal funciones = new Funciones_Sucursal();
            bool exito = funciones.ModificarSucursal(Int32.Parse(txtId.Text), txtNombre.Text, txtUbicacion.Text, txtTelefono.Text);
            if (exito)
            {
                MessageBox.Show("Se ha modificado con éxito");
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtUbicacion.Text = "";
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Sucursal funciones = new Funciones_Sucursal();
            bool exito = funciones.EliminarSucursal(Int32.Parse(txtId.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtUbicacion.Text = "";
            }
        }
    }
}
