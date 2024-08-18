using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Sucursales;
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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Funciones_Categoria funciones = new Funciones_Categoria();
            int activo = cmbActivo.SelectedIndex;

            bool exito = funciones.RegistrarCategoria(txtNombre.Text, activo, txtDesc.Text);
            if (exito)
            {
                MessageBox.Show("Se ha creado con éxito");
                txtNombre.Text = "";
                cmbActivo.SelectedIndex = -1;
                txtDesc.Text = "";
            }
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgv_Categorias.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                cmbActivo.SelectedIndex= Int32.Parse(row.Cells[2].Value.ToString());
                txtDesc.Text = row.Cells[3].Value.ToString();
               
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dgv_Categorias.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Categoria funciones = new Funciones_Categoria();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.ObtenerCategorias();

                // Verificar si el DataSet contiene datos
                if (sucursalesDataSet.Tables.Count > 0 && sucursalesDataSet.Tables["Categorias"].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in sucursalesDataSet.Tables[0].Rows)
                    {
                        dgv_Categorias.Rows.Add(
                            row["ID_CATEGORIA"],
                            row["NOMBRE"],
                            row["ACTIVO"],
                            row["DESCRIPCION"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron categorias.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Categoria funciones = new Funciones_Categoria();
            int activo = cmbActivo.SelectedIndex;

            bool exito = funciones.ModificarCategoria(Int32.Parse(txtId.Text), txtNombre.Text, activo, txtDesc.Text);
            if (exito)
            {
                MessageBox.Show("Se ha modificado con éxito");
                txtNombre.Text = "";
                cmbActivo.SelectedIndex = -1;
                txtDesc.Text = "";
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Categoria funciones = new Funciones_Categoria();
            int activo = cmbActivo.SelectedIndex;

            bool exito = funciones.EliminarCategoria(Int32.Parse(txtId.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtNombre.Text = "";
                cmbActivo.SelectedIndex = -1;
                txtDesc.Text = "";
            }
        }

        private void selectionCHG(object sender, EventArgs e)
        {
            if (dgv_Categorias.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgv_Categorias.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }

        private void dgv_Categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
