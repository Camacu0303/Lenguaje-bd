namespace LenguajeDB.Interfaces
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearCuenta = new AltoControls.AltoButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new PlaceholderTextBox.PlaceholderTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtNombre = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtUsuario = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtContrasena = new PlaceholderTextBox.PlaceholderTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 348);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnCrearCuenta.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCuenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnCrearCuenta.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnCrearCuenta.Location = new System.Drawing.Point(313, 198);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Radius = 10;
            this.btnCrearCuenta.Size = new System.Drawing.Size(168, 30);
            this.btnCrearCuenta.Stroke = false;
            this.btnCrearCuenta.StrokeColor = System.Drawing.Color.Gray;
            this.btnCrearCuenta.TabIndex = 1;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.Transparency = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Crear cuenta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(26, 223);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "Ingrese el correo electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(229, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(26, 166);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PlaceholderText = "Introduce los apellidos";
            this.txtApellidos.Size = new System.Drawing.Size(229, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(26, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Introduce tu nombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(282, 109);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Introduce el usuario";
            this.txtUsuario.Size = new System.Drawing.Size(229, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(282, 166);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PlaceholderText = "Introduce la contraseña";
            this.txtContrasena.Size = new System.Drawing.Size(229, 20);
            this.txtContrasena.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(282, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(282, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contraseña";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(26, 280);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(542, 348);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton btnCrearCuenta;
        private PlaceholderTextBox.PlaceholderTextBox txtUsuario;
        private PlaceholderTextBox.PlaceholderTextBox txtContrasena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private PlaceholderTextBox.PlaceholderTextBox txtNombre;
        private PlaceholderTextBox.PlaceholderTextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private PlaceholderTextBox.PlaceholderTextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}