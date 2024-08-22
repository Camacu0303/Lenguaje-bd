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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LenguajeDB.Interfaces
{
    public partial class Accesorios : Form
    {
        public Accesorios()
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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accesorios_Load(object sender, EventArgs e)
        {
            cargarCategorias();

            if (Sesion.ObtenerInstancia().UserRole == Rol.Cliente)
            {
                // Set button colors to gray
                btn_actualizar.BackColor = Color.Gray;
                btn_eliminar.BackColor = Color.Gray;
                btn_registrar.BackColor = Color.Gray;
                btn_actualizar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_registrar.Enabled = false;

                txtId.Enabled = false;
                txtNombre.Enabled = false;
                cmbCategoria.Enabled = false;
                txtDesc.Enabled = false;
                numStock.Enabled = false;
                txtPrecio.Enabled = false;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Funciones_Accesorio funciones = new Funciones_Accesorio();
            bool exito = funciones.RegistrarAccesorio(txtNombre.Text, txtDesc.Text, Decimal.Parse(txtPrecio.Text), (int)numStock.Value, obtenerCategoria().IdCategoria);
            if (exito)
            {
                MessageBox.Show("Se ha creado con éxito");
                txtNombre.Text = "";
                cmbCategoria.SelectedIndex = -1;
                txtDesc.Text = "";
            }
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Accesorio funciones = new Funciones_Accesorio();
            bool exito = funciones.EliminarAccesorio(Int32.Parse(txtId.Text));
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtNombre.Text = "";
                cmbCategoria.SelectedIndex = -1;
                txtDesc.Text = "";
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            dgv_Accesorios.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Accesorio funciones = new Funciones_Accesorio();
                // Obtener los datos desde la base de datos
                DataSet sucursalesDataSet = funciones.ObtenerAccesorios();

                // Verificar si el DataSet contiene datos
                if (sucursalesDataSet.Tables.Count > 0 && sucursalesDataSet.Tables[0].Rows.Count > 0)
                {
                    // Iterar sobre cada fila del DataTable y agregarlas al DataGridView
                    foreach (DataRow row in sucursalesDataSet.Tables[0].Rows)
                    {
                        dgv_Accesorios.Rows.Add(
                            row["ID_ACCESORIO"],
                            row["NOMBRE"],
                            row["DESCRIPCION"],
                            row["PRECIO"],
                            row["STOCK"],
                            row["ID_CATEGORIA"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron accesorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los accesorios: " + ex.Message);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgv_Accesorios.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
                txtPrecio.Text = row.Cells[3].Value.ToString();
                numStock.Value = Decimal.Parse(row.Cells[4].Value.ToString());

                int idSeleccionado = Int32.Parse(row.Cells[5].Value.ToString());

                // Buscar el índice del elemento en el ComboBox por su ValueMember (IdCategoria)
                int indice = -1;
                foreach (CategoriaClass categoria in cmbCategoria.Items)
                {
                    if (categoria.IdCategoria == idSeleccionado)
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
                    MessageBox.Show($"No se encontró ninguna categoría con el ID {idSeleccionado}");
                }
            }
        }
        private void SelectionChg(object sender, EventArgs e)
        {
            if (dgv_Accesorios.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgv_Accesorios.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Accesorio funciones = new Funciones_Accesorio();
            bool exito = funciones.ModificarAccesorio(Int32.Parse(txtId.Text), txtNombre.Text, txtDesc.Text, Decimal.Parse(txtPrecio.Text), (int)numStock.Value, obtenerCategoria().IdCategoria);
            if (exito)
            {
                MessageBox.Show("Se ha eliminado con éxito");
                txtNombre.Text = "";
                cmbCategoria.SelectedIndex = -1;
                txtDesc.Text = "";
            }
        }
    }
}
