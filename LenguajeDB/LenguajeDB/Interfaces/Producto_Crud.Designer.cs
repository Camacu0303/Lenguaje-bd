namespace LenguajeDB.Interfaces
{
    partial class Producto_Crud
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
            this.btn_registrar = new AltoControls.AltoButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1_sucursal = new System.Windows.Forms.ComboBox();
            this.comboBox2_categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.altoTextBox1_descripcion = new AltoControls.AltoTextBox();
            this.altoTextBox1_precio = new AltoControls.AltoTextBox();
            this.altoTextBox1_stock = new AltoControls.AltoTextBox();
            this.btn_actualizar = new AltoControls.AltoButton();
            this.btn_eliminar = new AltoControls.AltoButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_registrar.Location = new System.Drawing.Point(91, 35);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Radius = 10;
            this.btn_registrar.Size = new System.Drawing.Size(168, 30);
            this.btn_registrar.Stroke = false;
            this.btn_registrar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.Transparency = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.DESCRIPCION_PRODUCTO,
            this.PRECIO_PRODUCTO,
            this.STOCK_PRODUCTO,
            this.ID_CATEGORIA,
            this.ID_SUCURSAL});
            this.dataGridView1.Location = new System.Drawing.Point(52, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 348);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // DESCRIPCION_PRODUCTO
            // 
            this.DESCRIPCION_PRODUCTO.HeaderText = "Descripcion";
            this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
            // 
            // PRECIO_PRODUCTO
            // 
            this.PRECIO_PRODUCTO.HeaderText = "Precio";
            this.PRECIO_PRODUCTO.Name = "PRECIO_PRODUCTO";
            // 
            // STOCK_PRODUCTO
            // 
            this.STOCK_PRODUCTO.HeaderText = "Stock";
            this.STOCK_PRODUCTO.Name = "STOCK_PRODUCTO";
            // 
            // ID_CATEGORIA
            // 
            this.ID_CATEGORIA.HeaderText = "Categoria";
            this.ID_CATEGORIA.Name = "ID_CATEGORIA";
            // 
            // ID_SUCURSAL
            // 
            this.ID_SUCURSAL.HeaderText = "Sucursal";
            this.ID_SUCURSAL.Name = "ID_SUCURSAL";
            // 
            // comboBox1_sucursal
            // 
            this.comboBox1_sucursal.FormattingEnabled = true;
            this.comboBox1_sucursal.Location = new System.Drawing.Point(359, 65);
            this.comboBox1_sucursal.Name = "comboBox1_sucursal";
            this.comboBox1_sucursal.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_sucursal.TabIndex = 4;
            this.comboBox1_sucursal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_sucursal_SelectedIndexChanged);
            // 
            // comboBox2_categoria
            // 
            this.comboBox2_categoria.FormattingEnabled = true;
            this.comboBox2_categoria.Location = new System.Drawing.Point(504, 65);
            this.comboBox2_categoria.Name = "comboBox2_categoria";
            this.comboBox2_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox2_categoria.TabIndex = 5;
            this.comboBox2_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_categoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(379, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(528, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(717, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(717, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(717, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // altoTextBox1_descripcion
            // 
            this.altoTextBox1_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1_descripcion.Br = System.Drawing.Color.White;
            this.altoTextBox1_descripcion.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1_descripcion.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1_descripcion.Location = new System.Drawing.Point(832, 12);
            this.altoTextBox1_descripcion.Name = "altoTextBox1_descripcion";
            this.altoTextBox1_descripcion.Size = new System.Drawing.Size(160, 33);
            this.altoTextBox1_descripcion.TabIndex = 14;
            this.altoTextBox1_descripcion.Text = "altoTextBox1";
            this.altoTextBox1_descripcion.Click += new System.EventHandler(this.altoTextBox1_descripcion_Click);
            // 
            // altoTextBox1_precio
            // 
            this.altoTextBox1_precio.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1_precio.Br = System.Drawing.Color.White;
            this.altoTextBox1_precio.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1_precio.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1_precio.Location = new System.Drawing.Point(832, 53);
            this.altoTextBox1_precio.Name = "altoTextBox1_precio";
            this.altoTextBox1_precio.Size = new System.Drawing.Size(160, 33);
            this.altoTextBox1_precio.TabIndex = 15;
            this.altoTextBox1_precio.Text = "altoTextBox1";
            this.altoTextBox1_precio.Click += new System.EventHandler(this.altoTextBox1_precio_Click);
            // 
            // altoTextBox1_stock
            // 
            this.altoTextBox1_stock.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1_stock.Br = System.Drawing.Color.White;
            this.altoTextBox1_stock.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1_stock.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1_stock.Location = new System.Drawing.Point(832, 96);
            this.altoTextBox1_stock.Name = "altoTextBox1_stock";
            this.altoTextBox1_stock.Size = new System.Drawing.Size(160, 33);
            this.altoTextBox1_stock.TabIndex = 16;
            this.altoTextBox1_stock.Text = "altoTextBox1";
            this.altoTextBox1_stock.Click += new System.EventHandler(this.altoTextBox1_stock_Click);
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
            this.btn_actualizar.Location = new System.Drawing.Point(441, 35);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Radius = 10;
            this.btn_actualizar.Size = new System.Drawing.Size(168, 30);
            this.btn_actualizar.Stroke = false;
            this.btn_actualizar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_actualizar.TabIndex = 17;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Transparency = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(791, 35);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Radius = 10;
            this.btn_eliminar.Size = new System.Drawing.Size(168, 30);
            this.btn_eliminar.Stroke = false;
            this.btn_eliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Transparency = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "Productos";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 501);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 100);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // Producto_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1050, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.altoTextBox1_stock);
            this.Controls.Add(this.altoTextBox1_precio);
            this.Controls.Add(this.altoTextBox1_descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2_categoria);
            this.Controls.Add(this.comboBox1_sucursal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Producto_Crud";
            this.Text = "Producto_Crud";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoButton btn_registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1_sucursal;
        private System.Windows.Forms.ComboBox comboBox2_categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SUCURSAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox altoTextBox1_descripcion;
        private AltoControls.AltoTextBox altoTextBox1_precio;
        private AltoControls.AltoTextBox altoTextBox1_stock;
        private AltoControls.AltoButton btn_actualizar;
        private AltoControls.AltoButton btn_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}