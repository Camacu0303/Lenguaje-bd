using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using LenguajeDB.Conexion;
using LenguajeDB.Interfaces;
using LenguajeDB.Funciones;
namespace LenguajeDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Conn conexion= new Conn();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener y abrir la conexión Oracle
                using (OracleConnection oracleConnection = Conn.GetOpenConnection())
                {
                    // Aquí puedes realizar operaciones con la conexión Oracle según tus necesidades
                    // Por ejemplo, ejecutar consultas SQL, actualizar datos, etc.
                    MessageBox.Show("Conexión exitosa a Oracle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a Oracle: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void altoButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register form= new Register();
            form.ShowDialog();
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            Funcion funcion= new Funcion();
            if (funcion.ConsultarUsuarioPorUsername(this.txtUsuario.Text, this.txtContrasena.Text)) { 
                Principal form= new Principal();
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
