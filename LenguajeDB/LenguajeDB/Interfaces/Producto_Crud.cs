using LenguajeDB.Conexion;
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
    public partial class Producto_Crud: Form
    {

        private Conn dbConn;
        public Producto_Crud()
        {
            InitializeComponent();
            dbConn = new Conn();
        }


        private void LoadData()
        {
            using (OracleConnection conn = Conn.GetOpenConnection())
            {
                try
                {
                    
                    string sql = "SELECT ID_PRODUCTO, DESCRIPCION, PRECIO, STOCK, ID_CATEGORIA, ID_SUCURSAL, ACTIVO FROM PRODUCTO";

                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }



        private void LoadSucursales()
        {
            using (OracleConnection conn = Conn.GetOpenConnection())
            {
                try
                {
                    
                    string sql = "SELECT ID_SUCURSAL, NOMBRE_SUCURSAL FROM SUCURSAL";

                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1_sucursal.DataSource = dt;
                    comboBox1_sucursal.DisplayMember = "NOMBRE_SUCURSAL";
                    comboBox1_sucursal.ValueMember = "ID_SUCURSAL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar sucursales: " + ex.Message);
                }
            }
        }


        private void Producto_Crud_Load(object sender, EventArgs e)
        {
            LoadCategorias();
            LoadSucursales();
            LoadData(); // Cargar productos existentes
        }

        private void LoadCategorias()
        {
            using (OracleConnection conn = Conn.GetOpenConnection())
            {
                try
                {
                   
                    string sql = "SELECT ID_CATEGORIA, NOMBRE_CATEGORIA FROM CATEGORIA";

                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox2_categoria.DataSource = dt;
                    comboBox2_categoria.DisplayMember = "NOMBRE_CATEGORIA";
                    comboBox2_categoria.ValueMember = "ID_CATEGORIA";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
            }

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = Conn.GetOpenConnection())
            {
                try
                {
                  
                    string sql = "INSERT INTO PRODUCTO (DESCRIPCION, PRECIO, STOCK, ID_CATEGORIA, ID_SUCURSAL, ACTIVO) " +
                                 "VALUES (:descripcion, :precio, :stock, :id_categoria, :id_sucursal, :activo)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("descripcion", altoTextBox1_descripcion.Text));
                        cmd.Parameters.Add(new OracleParameter("precio", Convert.ToDecimal(altoTextBox1_precio.Text)));
                        cmd.Parameters.Add(new OracleParameter("stock", Convert.ToInt32(altoTextBox1_stock.Text)));
                        cmd.Parameters.Add(new OracleParameter("id_categoria", (int)comboBox2_categoria.SelectedValue));
                        cmd.Parameters.Add(new OracleParameter("id_sucursal", (int)comboBox1_sucursal.SelectedValue));
                        cmd.Parameters.Add(new OracleParameter("activo", 1));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto registrado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el producto: " + ex.Message);
                }
            }
            LoadData(); // Recargar los datos en el DataGridView
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
            if (e.RowIndex >= 0) // Asegúrate de que se ha seleccionado una fila válida
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                altoTextBox1_descripcion.Text = row.Cells["DESCRIPCION"].Value.ToString();
                altoTextBox1_precio.Text = row.Cells["PRECIO"].Value.ToString();
                altoTextBox1_stock.Text = row.Cells["STOCK"].Value.ToString();
                comboBox2_categoria.SelectedValue = row.Cells["ID_CATEGORIA"].Value;
                comboBox1_sucursal.SelectedValue = row.Cells["ID_SUCURSAL"].Value;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_PRODUCTO"].Value);

                using (OracleConnection conn = Conn.GetOpenConnection())
                {
                    try
                    {

                        string sql = "UPDATE PRODUCTO SET DESCRIPCION = :descripcion, PRECIO = :precio, " +
                                     "STOCK = :stock, ID_CATEGORIA = :id_categoria, ID_SUCURSAL = :id_sucursal, ACTIVO = :activo " +
                                     "WHERE ID_PRODUCTO = :id_producto";

                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("descripcion", altoTextBox1_descripcion.Text));
                            cmd.Parameters.Add(new OracleParameter("precio", Convert.ToDecimal(altoTextBox1_precio.Text)));
                            cmd.Parameters.Add(new OracleParameter("stock", Convert.ToInt32(altoTextBox1_stock.Text)));
                            cmd.Parameters.Add(new OracleParameter("id_categoria", (int)comboBox2_categoria.SelectedValue));
                            cmd.Parameters.Add(new OracleParameter("id_sucursal", (int)comboBox1_sucursal.SelectedValue));
                            cmd.Parameters.Add(new OracleParameter("activo", 1)); // Actualizar estado a activo

                            cmd.Parameters.Add(new OracleParameter("id_producto", idProducto));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto actualizado exitosamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                    }
                }
                LoadData(); // Recargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("Selecciona un producto para actualizar.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_PRODUCTO"].Value);

                using (OracleConnection conn = Conn.GetOpenConnection())
                {
                    try
                    {

                        string sql = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO = :id_producto";

                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("id_producto", idProducto));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto eliminado exitosamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                    }
                }
                LoadData(); // Recargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }
    }
    }
