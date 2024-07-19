namespace LenguajeDB
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new AltoControls.AltoButton();
            this.txtUsuario = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtContrasena = new PlaceholderTextBox.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnIniciarSesion.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnIniciarSesion.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnIniciarSesion.Location = new System.Drawing.Point(23, 280);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Radius = 10;
            this.btnIniciarSesion.Size = new System.Drawing.Size(168, 30);
            this.btnIniciarSesion.Stroke = false;
            this.btnIniciarSesion.StrokeColor = System.Drawing.Color.Gray;
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar sesiòn";
            this.btnIniciarSesion.Transparency = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(23, 137);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Introduce el usuario";
            this.txtUsuario.Size = new System.Drawing.Size(229, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(23, 204);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PlaceholderText = "Introduce la contraseña";
            this.txtContrasena.Size = new System.Drawing.Size(229, 20);
            this.txtContrasena.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inicia sesión en tu cuenta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(318, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "¿Olvidaste tu contraseña?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(318, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "¿No tienes una cuenta? Registro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(23, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Recuerdame";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 375);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(810, 392);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Inicio de sesiòn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AltoControls.AltoButton btnIniciarSesion;
        private PlaceholderTextBox.PlaceholderTextBox txtUsuario;
        private PlaceholderTextBox.PlaceholderTextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

