﻿using LenguajeDB.Funciones;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Funciones_Usuarios funcion = new Funciones_Usuarios();
            if (funcion.RegistrarUsuario(this.txtUsuario.Text, this.txtContrasena.Text, this.txtNombre.Text, this.txtApellidos.Text, this.txtCorreo.Text, this.txtTelefono.Text, Utilidad.Rol.Cliente)) { 
                this.Close();
            }
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
