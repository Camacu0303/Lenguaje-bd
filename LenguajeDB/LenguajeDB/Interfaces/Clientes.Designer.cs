namespace LenguajeDB.Interfaces
{
    partial class Clientes
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_eliminar = new AltoControls.AltoButton();
            this.btn_actualizar = new AltoControls.AltoButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_registrar = new AltoControls.AltoButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.placeholderTextBox1 = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderTextBox2 = new PlaceholderTextBox.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.placeholderTextBox3 = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderTextBox4 = new PlaceholderTextBox.PlaceholderTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.placeholderTextBox5 = new PlaceholderTextBox.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 39);
            this.label6.TabIndex = 34;
            this.label6.Text = "Clientes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_eliminar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_eliminar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_eliminar.Location = new System.Drawing.Point(791, 16);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Radius = 10;
            this.btn_eliminar.Size = new System.Drawing.Size(168, 30);
            this.btn_eliminar.Stroke = false;
            this.btn_eliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_eliminar.TabIndex = 33;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Transparency = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_actualizar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_actualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_actualizar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_actualizar.Location = new System.Drawing.Point(441, 16);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Radius = 10;
            this.btn_actualizar.Size = new System.Drawing.Size(168, 30);
            this.btn_actualizar.Stroke = false;
            this.btn_actualizar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_actualizar.TabIndex = 32;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Transparency = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.DESCRIPCION_PRODUCTO,
            this.PRECIO_PRODUCTO,
            this.STOCK_PRODUCTO});
            this.dataGridView1.Location = new System.Drawing.Point(55, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 348);
            this.dataGridView1.TabIndex = 21;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // DESCRIPCION_PRODUCTO
            // 
            this.DESCRIPCION_PRODUCTO.HeaderText = "Nombre";
            this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
            // 
            // PRECIO_PRODUCTO
            // 
            this.PRECIO_PRODUCTO.HeaderText = "Activo";
            this.PRECIO_PRODUCTO.Name = "PRECIO_PRODUCTO";
            // 
            // STOCK_PRODUCTO
            // 
            this.STOCK_PRODUCTO.HeaderText = "Descripción";
            this.STOCK_PRODUCTO.Name = "STOCK_PRODUCTO";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_registrar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_registrar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_registrar.Location = new System.Drawing.Point(91, 16);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Radius = 10;
            this.btn_registrar.Size = new System.Drawing.Size(168, 30);
            this.btn_registrar.Stroke = false;
            this.btn_registrar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.Transparency = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_registrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_actualizar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_eliminar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 538);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 63);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Location = new System.Drawing.Point(263, 30);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox1.TabIndex = 37;
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.Location = new System.Drawing.Point(393, 30);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Teléfono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.placeholderTextBox5, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.placeholderTextBox4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.placeholderTextBox2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.placeholderTextBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.placeholderTextBox3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 6, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(55, 474);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 58);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(653, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 43;
            // 
            // placeholderTextBox3
            // 
            this.placeholderTextBox3.Location = new System.Drawing.Point(523, 30);
            this.placeholderTextBox3.Name = "placeholderTextBox3";
            this.placeholderTextBox3.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox3.TabIndex = 46;
            // 
            // placeholderTextBox4
            // 
            this.placeholderTextBox4.Location = new System.Drawing.Point(3, 30);
            this.placeholderTextBox4.Name = "placeholderTextBox4";
            this.placeholderTextBox4.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox4.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(783, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Activo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(783, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // placeholderTextBox5
            // 
            this.placeholderTextBox5.Location = new System.Drawing.Point(653, 30);
            this.placeholderTextBox5.Name = "placeholderTextBox5";
            this.placeholderTextBox5.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox5.TabIndex = 49;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1050, 601);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private AltoControls.AltoButton btn_eliminar;
        private AltoControls.AltoButton btn_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AltoControls.AltoButton btn_registrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_PRODUCTO;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox1;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox3;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox5;
        private System.Windows.Forms.Label label8;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}