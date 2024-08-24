namespace LenguajeDB.Interfaces
{
    partial class FiltroPedido
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
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteFiltro = new PlaceholderTextBox.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedidoFiltro = new PlaceholderTextBox.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarPedido.Image = global::LenguajeDB.Properties.Resources.Search;
            this.btnBuscarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedido.Location = new System.Drawing.Point(387, 11);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarPedido.TabIndex = 54;
            this.btnBuscarPedido.Text = "Buscar pedido";
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 57);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(800, 393);
            this.dgvPedidos.TabIndex = 53;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.selectCHG);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cliente";
            // 
            // txtClienteFiltro
            // 
            this.txtClienteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteFiltro.Location = new System.Drawing.Point(276, 12);
            this.txtClienteFiltro.Name = "txtClienteFiltro";
            this.txtClienteFiltro.PlaceholderText = "ID del cliente";
            this.txtClienteFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtClienteFiltro.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID del pedido";
            // 
            // txtPedidoFiltro
            // 
            this.txtPedidoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoFiltro.Location = new System.Drawing.Point(103, 12);
            this.txtPedidoFiltro.Name = "txtPedidoFiltro";
            this.txtPedidoFiltro.PlaceholderText = "Identificador del pedido";
            this.txtPedidoFiltro.Size = new System.Drawing.Size(124, 20);
            this.txtPedidoFiltro.TabIndex = 49;
            // 
            // FiltroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPedidoFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FiltroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecciona un pedido";
            this.Load += new System.EventHandler(this.FiltroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label2;
        private PlaceholderTextBox.PlaceholderTextBox txtClienteFiltro;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox txtPedidoFiltro;
    }
}