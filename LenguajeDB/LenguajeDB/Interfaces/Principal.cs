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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario(object sender, EventArgs e)
        {
            Usuario form= new Usuario();
            form.ShowDialog();
        }


        private void altoButton1_Click(object sender, EventArgs e)
        {
            Categoria frm = new Categoria();
            frm.ShowDialog();
        }

        private void altoButton4_Click(object sender, EventArgs e)
        {
            Producto_Crud frm = new Producto_Crud();
            frm.ShowDialog();
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            Empleados frm= new Empleados();
            frm.ShowDialog();
        }

        private void altoButton5_Click(object sender, EventArgs e)
        {
            Accesorios frm= new Accesorios();
            frm.ShowDialog();
        }

        private void altoButton6_Click(object sender, EventArgs e)
        {

        }

        private void altoButton7_Click(object sender, EventArgs e)
        {

        }

        private void altoButton8_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Sesion.ObtenerInstancia().UserRole!=Rol.Admin) {
                btn_EmpleadosAbrir.Visible = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
