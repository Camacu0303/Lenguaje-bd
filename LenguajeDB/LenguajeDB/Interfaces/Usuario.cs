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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            EliminarUsuario form= new EliminarUsuario();
            form.ShowDialog();
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            var val = MessageBox.Show("¿Desea desactivar la cuenta?", "Aviso", MessageBoxButtons.OKCancel);
            if (val == DialogResult.OK)
            {
                Funcion func = new Funcion();
                int val2 = Sesion.ObtenerInstancia().IdUsuario;
                if (func.DesactivarUsuario(val2)) {
                    MessageBox.Show("Usuario desactivado con éxito");
                    Application.Exit();
                }
            }
        }
    }
}
