
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
    public partial class Clientes : Form
    {
        public Clientes()
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Clientes funciones = new Funciones_Clientes();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.ObtenerClientes();

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
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Funciones_Clientes funciones = new Funciones_Clientes();
            bool exito = funciones.RegistrarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha creado con éxito");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cmbActivo.SelectedIndex = -1;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Clientes funciones = new Funciones_Clientes();
            int activo = cmbActivo.SelectedIndex;

            bool exito = funciones.EliminarCliente(Int32.Parse(txtID.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cmbActivo.SelectedIndex = -1;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Clientes funciones = new Funciones_Clientes();
            int activo = cmbActivo.SelectedIndex;

            bool exito = funciones.ModificarCliente(Int32.Parse(txtID.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, cmbActivo.SelectedIndex);
            if (exito)
            {
                MessageBox.Show("Se ha modificado con éxito");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cmbActivo.SelectedIndex = -1;
            }
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtApellido.Text = row.Cells[2].Value.ToString();
                txtTelefono.Text = row.Cells[3].Value.ToString();
                txtCorreo.Text = row.Cells[4].Value.ToString();
                txtDireccion.Text = row.Cells[5].Value.ToString();
                cmbActivo.SelectedIndex = Int32.Parse(row.Cells[6].Value.ToString());

            }
        }

        private void selectCHG(object sender, EventArgs e)
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
