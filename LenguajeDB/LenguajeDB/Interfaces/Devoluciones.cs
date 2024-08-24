using LenguajeDB.Funciones.Categoria;
using LenguajeDB.Funciones.Devoluciones;
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
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {

            if (Sesion.ObtenerInstancia().UserRole == Rol.Cliente)
            {
                // Configurar los botones y controles para usuarios clientes
                btn_actualizar.BackColor = Color.Gray;
                btn_eliminar.BackColor = Color.Gray;
                btn_registrar.BackColor = Color.Gray;
                btn_actualizar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_registrar.Enabled = false;

              
            }
        }


        private void LimpiarCampos()
        {
            txt_id.Text = "";
            txtMotivo.Text = "";
            numCantidad.Value = 0;
            txtID.Text = "";
;        }




        private void dgv_Accesorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Devoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                DataGridViewRow row = dgv_Devoluciones.Rows[e.RowIndex];
  
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_DETALLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            Funciones_Devolucion funciones = new Funciones_Devolucion();
            bool exito = funciones.RegistrarDevolucion(Int32.Parse(txt_id.Text), Int32.Parse(numCantidad.Value.ToString()), txtMotivo.Text);
            if (exito)
            {
                MessageBox.Show("Devolución creada con éxito");
                LimpiarCampos();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Funciones_Devolucion funciones = new Funciones_Devolucion();
            bool exito = funciones.ModificarDevolucion(Int32.Parse(txtID.Text), Int32.Parse(txt_id.Text), Int32.Parse(numCantidad.Value.ToString()), txtMotivo.Text);
            if (exito)
            {
                MessageBox.Show("Devolución modificada con éxito");
                LimpiarCampos();
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Funciones_Devolucion funciones = new Funciones_Devolucion();
            bool exito = funciones.EliminarDevolucion(Int32.Parse(txtID.Text));
            if (exito)
            {
                MessageBox.Show("Devolución eliminada con éxito");
                LimpiarCampos();
            }

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            dgv_Devoluciones.Rows.Clear(); // Limpiar filas existentes en el DataGridView

            try
            {
                Funciones_Devolucion funciones = new Funciones_Devolucion();
                DataSet devolucionesDataSet = funciones.ObtenerDevoluciones();

                if (devolucionesDataSet.Tables.Count > 0 && devolucionesDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in devolucionesDataSet.Tables[0].Rows)
                    {
                        dgv_Devoluciones.Rows.Add(
                            row["ID_DEVOLUCION"],
                            row["ID_DETALLE"],
                            row["FECHA_DEVOLUCION"],
                            row["CANTIDAD"],
                            row["MOTIVO"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron devoluciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las devoluciones: " + ex.Message);
            }
        }

        private void dgv_Devoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                DataGridViewRow row = dgv_Devoluciones.Rows[e.RowIndex];
            
            }
        }



        private void altoButton1_Click(object sender, EventArgs e)
        {





        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            FiltroPedido frm = new FiltroPedido(this);
            frm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectCHG(object sender, EventArgs e)
        {
            if (dgv_Devoluciones.CurrentRow != null)
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow row = dgv_Devoluciones.CurrentRow;

                // Seleccionar toda la fila
                row.Selected = true;
            }

        }
        private void dgv_Devoluciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que el clic fue dentro de una fila válida
            {
                // Obtener la fila correspondiente al clic
                DataGridViewRow row = dgv_Devoluciones.Rows[e.RowIndex];

                // Seleccionar toda la fila
                row.Selected = true;

                txtID.Text= row.Cells[0].Value.ToString();
                txt_id.Text= row.Cells[1].Value.ToString();
                numCantidad.Value = Int32.Parse(row.Cells[3].Value.ToString());
                txtMotivo.Text= row.Cells[4].Value.ToString();



            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            Funciones_Devolucion funciones = new Funciones_Devolucion();
            bool exito = funciones.EliminarDevolucion(Int32.Parse(txtID.Text));
            if (exito)
            {
                MessageBox.Show("Devolución modificada con éxito");
                LimpiarCampos();
            }
        }
    }
}