using LenguajeDB.Funciones;
using LenguajeDB.Funciones.Accesorios;
using LenguajeDB.Funciones.Categoria;
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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dgv_Usuarios.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Usuarios funciones = new Funciones_Usuarios();
                // Obtener los datos desde la base de datos
                DataSet usuariosDataset = funciones.FiltrarUsuariosPorNombre(txtFiltro.Text);

                // Verificar si el DataSet contiene datos
                if (usuariosDataset.Tables.Count > 0 && usuariosDataset.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in usuariosDataset.Tables[0].Rows)
                    {
                        dgv_Usuarios.Rows.Add(
                            row["ID_USUARIO"],
                            row["USERNAME"],
                            row["PASSWORD"],
                            row["NOMBRE"],
                            row["APELLIDO"],
                            row["CORREO"],
                            row["TELEFONO"],
                            row["ACTIVO"],
                            row["ID_ROL"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            if (cmbRol.SelectedIndex > -1)
            {
                rol = (Rol)(cmbRol.SelectedIndex + 1);

                Funciones_Usuarios funcion = new Funciones_Usuarios();
                if (funcion.RegistrarUsuario(this.txtUsuario.Text, this.txtContrasena.Text, this.txtNombre.Text, this.txtApellidos.Text, this.txtCorreo.Text, this.txtTelefono.Text, rol))
                {
                    MessageBox.Show("Usuario registrado");   
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgv_Usuarios.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                String val= row.Cells[0].Value.ToString();
                txtID.Text = val;
                txtUsuario.Text = row.Cells[1].Value.ToString();
                txtContrasena.Text = row.Cells[2].Value.ToString();
                txtNombre.Text = row.Cells[3].Value.ToString();
                txtApellidos.Text = row.Cells[4].Value.ToString();
                txtCorreo.Text = row.Cells[5].Value.ToString();
                txtTelefono.Text = row.Cells[6].Value.ToString();
                cmbActivo.SelectedIndex = Int32.Parse(row.Cells[7].Value.ToString());
                cmbRol.SelectedIndex = Int32.Parse(row.Cells[8].Value.ToString())-1;
            }
        }

        private void selectCHG(object sender, EventArgs e)
        {
            if (dgv_Usuarios.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgv_Usuarios.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Usuarios funciones = new Funciones_Usuarios();

            // Convertir los valores del formulario en los parámetros del método
            bool exito = funciones.ModificarUsuario(
                Int32.Parse(txtID.Text),           // ID del usuario
                txtUsuario.Text,                  // Username
                txtContrasena.Text,               // Password
                txtNombre.Text,                   // Nombre
                txtApellidos.Text,                // Apellidos
                txtCorreo.Text,                   // Correo
                txtTelefono.Text,                 // Teléfono
                cmbActivo.SelectedIndex,          
                cmbRol.SelectedIndex + 1          
            );

            if (exito)
            {
                MessageBox.Show("Se ha modificado con éxito");
                // Limpiar campos después de la actualización exitosa
                txtID.Text = "";
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                cmbActivo.SelectedIndex = -1;    // Desmarcar el combo box
                cmbRol.SelectedIndex = -1;       // Desmarcar el combo box
            }
            else
            {
                MessageBox.Show("Se ha fallado con éxito");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Usuarios funciones = new Funciones_Usuarios();
            bool exito = funciones.EliminarUsuario(Int32.Parse(txtID.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtID.Text = "";
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                cmbActivo.SelectedIndex = -1;    // Desmarcar el combo box
                cmbRol.SelectedIndex = -1;       // Desmarcar el combo box
            }
            else {
                MessageBox.Show("Se ha fallado con éxito");
            }
        }
    }
}
