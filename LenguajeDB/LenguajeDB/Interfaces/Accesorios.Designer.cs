﻿namespace LenguajeDB.Interfaces
{
    partial class Accesorios
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
            this.dgv_Accesorios = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_registrar = new AltoControls.AltoButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtDesc = new PlaceholderTextBox.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new PlaceholderTextBox.PlaceholderTextBox();
            this.altoButton1 = new AltoControls.AltoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accesorios)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(189, 39);
            this.label6.TabIndex = 34;
            this.label6.Text = "Accesorios";
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
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dgv_Accesorios
            // 
            this.dgv_Accesorios.AllowUserToAddRows = false;
            this.dgv_Accesorios.AllowUserToDeleteRows = false;
            this.dgv_Accesorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Accesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accesorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.DESCRIPCION_PRODUCTO,
            this.STOCK_PRODUCTO,
            this.PRECIO_PRODUCTO,
            this.Column1,
            this.Column2});
            this.dgv_Accesorios.Location = new System.Drawing.Point(55, 92);
            this.dgv_Accesorios.MultiSelect = false;
            this.dgv_Accesorios.Name = "dgv_Accesorios";
            this.dgv_Accesorios.ReadOnly = true;
            this.dgv_Accesorios.Size = new System.Drawing.Size(915, 348);
            this.dgv_Accesorios.TabIndex = 21;
            this.dgv_Accesorios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dgv_Accesorios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accesorios_CellContentClick);
            this.dgv_Accesorios.SelectionChanged += new System.EventHandler(this.SelectionChg);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.ReadOnly = true;
            // 
            // DESCRIPCION_PRODUCTO
            // 
            this.DESCRIPCION_PRODUCTO.HeaderText = "Nombre";
            this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
            this.DESCRIPCION_PRODUCTO.ReadOnly = true;
            // 
            // STOCK_PRODUCTO
            // 
            this.STOCK_PRODUCTO.HeaderText = "Descripción";
            this.STOCK_PRODUCTO.Name = "STOCK_PRODUCTO";
            this.STOCK_PRODUCTO.ReadOnly = true;
            // 
            // PRECIO_PRODUCTO
            // 
            this.PRECIO_PRODUCTO.HeaderText = "Precio";
            this.PRECIO_PRODUCTO.Name = "PRECIO_PRODUCTO";
            this.PRECIO_PRODUCTO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoría";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
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
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(307, 30);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(459, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDesc, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtId, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbCategoria, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.numStock, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPrecio, 3, 1);
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
            this.label7.Location = new System.Drawing.Point(763, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(611, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Stock";
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
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(3, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 43;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(763, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 44;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(611, 30);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(120, 20);
            this.numStock.TabIndex = 45;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(459, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 46;
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.altoButton1.ForeColor = System.Drawing.Color.White;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton1.Location = new System.Drawing.Point(862, 56);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(108, 30);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 45;
            this.altoButton1.Text = "Recargar";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // Accesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1050, 601);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Accesorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Accesorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraTech - Gestor de Accesorios";
            this.Load += new System.EventHandler(this.Accesorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accesorios)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private AltoControls.AltoButton btn_eliminar;
        private AltoControls.AltoButton btn_actualizar;
        private System.Windows.Forms.DataGridView dgv_Accesorios;
        private AltoControls.AltoButton btn_registrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox txtNombre;
        private PlaceholderTextBox.PlaceholderTextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numStock;
        private PlaceholderTextBox.PlaceholderTextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private AltoControls.AltoButton altoButton1;
    }
}