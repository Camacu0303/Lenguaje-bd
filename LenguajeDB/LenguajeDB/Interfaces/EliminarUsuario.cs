using LenguajeDB.Funciones;
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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private static readonly string Codigo = Util.GenerarCodigoAlfanumerico(8);
        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = Codigo;
            txtCodigo.PlaceholderText = Codigo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           ProcesarEliminacion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ProcesarEliminacion()
        {
            if (txtCodigo.Text == Codigo)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar esta cuenta?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Comprobar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    Funcion func = new Funcion();
                    func.EliminarUsuario(Sesion.ObtenerInstancia().IdUsuario);
                    MessageBox.Show("Cuenta eliminada exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Operación cancelada. La cuenta no ha sido eliminada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario actual o realizar otra acción
                }
            }
            else
            {
                MessageBox.Show("Entrada incorrecta. Por favor ingresa el código correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ProcesarEliminacion(int id)
        {
            string token = "token_predeterminado"; // Aquí deberías definir tu token predeterminado

            if (txtCodigo.Text == token)
            {
                DialogResult result = MessageBox.Show($"¿Estás seguro que deseas eliminar la cuenta con ID {id}?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Comprobar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Cuenta eliminada exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí puedes agregar la lógica para eliminar la cuenta (o llamar a otra función para hacerlo)
                    // Por ejemplo:
                    // EliminarCuenta(id);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Operación cancelada. La cuenta no ha sido eliminada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario actual o realizar otra acción
                }
            }
            else
            {
                MessageBox.Show("Entrada incorrecta. Por favor ingresa el código correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
