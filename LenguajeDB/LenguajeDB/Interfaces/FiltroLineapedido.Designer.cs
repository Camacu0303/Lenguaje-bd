namespace LenguajeDB.Interfaces
{
    partial class FiltroLineapedido
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
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinea
            // 
            this.dgvLinea.AllowUserToAddRows = false;
            this.dgvLinea.AllowUserToDeleteRows = false;
            this.dgvLinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinea.Location = new System.Drawing.Point(0, 0);
            this.dgvLinea.MultiSelect = false;
            this.dgvLinea.Name = "dgvLinea";
            this.dgvLinea.ReadOnly = true;
            this.dgvLinea.Size = new System.Drawing.Size(800, 450);
            this.dgvLinea.TabIndex = 54;
            this.dgvLinea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinea_CellContentClick);
            this.dgvLinea.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinea_CellDoubleClick);
            this.dgvLinea.SelectionChanged += new System.EventHandler(this.dgvLinea_SelectionChanged);
            // 
            // FiltroLineapedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FiltroLineapedido";
            this.Text = "Selecciona el detalle del pedido";
            this.Load += new System.EventHandler(this.FiltroLineapedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinea;
    }
}