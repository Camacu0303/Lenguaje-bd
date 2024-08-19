namespace LenguajeDB.Interfaces
{
    partial class Pedidos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteFiltro = new PlaceholderTextBox.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedidoFiltro = new PlaceholderTextBox.PlaceholderTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.placeholderTextBox8 = new PlaceholderTextBox.PlaceholderTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placeholderTextBox7 = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderTextBox6 = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderTextBox5 = new PlaceholderTextBox.PlaceholderTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.placeholderTextBox4 = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderTextBox3 = new PlaceholderTextBox.PlaceholderTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.altoButton5 = new AltoControls.AltoButton();
            this.altoButton7 = new AltoControls.AltoButton();
            this.altoButton6 = new AltoControls.AltoButton();
            this.altoButton2 = new AltoControls.AltoButton();
            this.altoButton4 = new AltoControls.AltoButton();
            this.btnClientesAbrir = new AltoControls.AltoButton();
            this.altoButton8 = new AltoControls.AltoButton();
            this.btn_EmpleadosAbrir = new AltoControls.AltoButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dgvPedidos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtClienteFiltro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPedidoFiltro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 61);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(786, 462);
            this.dgvPedidos.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtClienteFiltro
            // 
            this.txtClienteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteFiltro.Location = new System.Drawing.Point(276, 23);
            this.txtClienteFiltro.Name = "txtClienteFiltro";
            this.txtClienteFiltro.PlaceholderText = "ID del cliente";
            this.txtClienteFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtClienteFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID del pedido";
            // 
            // txtPedidoFiltro
            // 
            this.txtPedidoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoFiltro.Location = new System.Drawing.Point(103, 23);
            this.txtPedidoFiltro.Name = "txtPedidoFiltro";
            this.txtPedidoFiltro.PlaceholderText = "Identificador del pedido";
            this.txtPedidoFiltro.Size = new System.Drawing.Size(124, 20);
            this.txtPedidoFiltro.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.placeholderTextBox8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.placeholderTextBox7);
            this.tabPage2.Controls.Add(this.placeholderTextBox6);
            this.tabPage2.Controls.Add(this.placeholderTextBox5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.placeholderTextBox4);
            this.tabPage2.Controls.Add(this.placeholderTextBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo pedido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 319);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(760, 235);
            this.dataGridView2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id del producto";
            // 
            // placeholderTextBox8
            // 
            this.placeholderTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox8.Location = new System.Drawing.Point(86, 53);
            this.placeholderTextBox8.Name = "placeholderTextBox8";
            this.placeholderTextBox8.PlaceholderText = "Código QR";
            this.placeholderTextBox8.Size = new System.Drawing.Size(103, 20);
            this.placeholderTextBox8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descripción";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::LenguajeDB.Properties.Resources.Search;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(640, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar producto";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(763, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // placeholderTextBox7
            // 
            this.placeholderTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox7.Location = new System.Drawing.Point(585, 8);
            this.placeholderTextBox7.Name = "placeholderTextBox7";
            this.placeholderTextBox7.PlaceholderText = "Número de teléfono del cliente";
            this.placeholderTextBox7.ReadOnly = true;
            this.placeholderTextBox7.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox7.TabIndex = 5;
            // 
            // placeholderTextBox6
            // 
            this.placeholderTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox6.Location = new System.Drawing.Point(429, 8);
            this.placeholderTextBox6.Name = "placeholderTextBox6";
            this.placeholderTextBox6.PlaceholderText = "Apellido del cliente";
            this.placeholderTextBox6.ReadOnly = true;
            this.placeholderTextBox6.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox6.TabIndex = 4;
            // 
            // placeholderTextBox5
            // 
            this.placeholderTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox5.Location = new System.Drawing.Point(264, 8);
            this.placeholderTextBox5.Name = "placeholderTextBox5";
            this.placeholderTextBox5.PlaceholderText = "Nombre del cliente";
            this.placeholderTextBox5.ReadOnly = true;
            this.placeholderTextBox5.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox5.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::LenguajeDB.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(112, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // placeholderTextBox4
            // 
            this.placeholderTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox4.Location = new System.Drawing.Point(6, 8);
            this.placeholderTextBox4.Name = "placeholderTextBox4";
            this.placeholderTextBox4.PlaceholderText = "Cliente";
            this.placeholderTextBox4.ReadOnly = true;
            this.placeholderTextBox4.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox4.TabIndex = 1;
            // 
            // placeholderTextBox3
            // 
            this.placeholderTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox3.Location = new System.Drawing.Point(264, 53);
            this.placeholderTextBox3.Name = "placeholderTextBox3";
            this.placeholderTextBox3.PlaceholderText = "Descripción del producto";
            this.placeholderTextBox3.Size = new System.Drawing.Size(370, 20);
            this.placeholderTextBox3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administrar datos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.altoButton5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.altoButton7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.altoButton6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.altoButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.altoButton4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClientesAbrir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.altoButton8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_EmpleadosAbrir, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 45);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // altoButton5
            // 
            this.altoButton5.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton5.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton5.BackColor = System.Drawing.Color.Transparent;
            this.altoButton5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton5.ForeColor = System.Drawing.Color.White;
            this.altoButton5.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton5.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton5.Location = new System.Drawing.Point(161, 7);
            this.altoButton5.Name = "altoButton5";
            this.altoButton5.Radius = 10;
            this.altoButton5.Size = new System.Drawing.Size(73, 30);
            this.altoButton5.Stroke = false;
            this.altoButton5.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton5.TabIndex = 8;
            this.altoButton5.Text = "Accesorios";
            this.altoButton5.Transparency = false;
            // 
            // altoButton7
            // 
            this.altoButton7.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton7.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton7.BackColor = System.Drawing.Color.Transparent;
            this.altoButton7.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton7.ForeColor = System.Drawing.Color.White;
            this.altoButton7.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton7.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton7.Location = new System.Drawing.Point(398, 7);
            this.altoButton7.Name = "altoButton7";
            this.altoButton7.Radius = 10;
            this.altoButton7.Size = new System.Drawing.Size(73, 30);
            this.altoButton7.Stroke = false;
            this.altoButton7.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton7.TabIndex = 10;
            this.altoButton7.Text = "Devoluciones";
            this.altoButton7.Transparency = false;
            // 
            // altoButton6
            // 
            this.altoButton6.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton6.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton6.BackColor = System.Drawing.Color.Transparent;
            this.altoButton6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton6.ForeColor = System.Drawing.Color.White;
            this.altoButton6.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton6.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton6.Location = new System.Drawing.Point(477, 7);
            this.altoButton6.Name = "altoButton6";
            this.altoButton6.Radius = 10;
            this.altoButton6.Size = new System.Drawing.Size(73, 30);
            this.altoButton6.Stroke = false;
            this.altoButton6.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton6.TabIndex = 9;
            this.altoButton6.Text = "Pedidos";
            this.altoButton6.Transparency = false;
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton2.ForeColor = System.Drawing.Color.White;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton2.Location = new System.Drawing.Point(82, 7);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(73, 30);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 3;
            this.altoButton2.Text = "Categorias";
            this.altoButton2.Transparency = false;
            // 
            // altoButton4
            // 
            this.altoButton4.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton4.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton4.BackColor = System.Drawing.Color.Transparent;
            this.altoButton4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton4.ForeColor = System.Drawing.Color.White;
            this.altoButton4.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton4.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton4.Location = new System.Drawing.Point(3, 7);
            this.altoButton4.Name = "altoButton4";
            this.altoButton4.Radius = 10;
            this.altoButton4.Size = new System.Drawing.Size(73, 30);
            this.altoButton4.Stroke = false;
            this.altoButton4.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton4.TabIndex = 5;
            this.altoButton4.Text = "Productos";
            this.altoButton4.Transparency = false;
            // 
            // btnClientesAbrir
            // 
            this.btnClientesAbrir.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnClientesAbrir.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnClientesAbrir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientesAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnClientesAbrir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClientesAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesAbrir.ForeColor = System.Drawing.Color.White;
            this.btnClientesAbrir.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnClientesAbrir.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btnClientesAbrir.Location = new System.Drawing.Point(319, 7);
            this.btnClientesAbrir.Name = "btnClientesAbrir";
            this.btnClientesAbrir.Radius = 10;
            this.btnClientesAbrir.Size = new System.Drawing.Size(73, 30);
            this.btnClientesAbrir.Stroke = false;
            this.btnClientesAbrir.StrokeColor = System.Drawing.Color.Gray;
            this.btnClientesAbrir.TabIndex = 6;
            this.btnClientesAbrir.Text = "Clientes";
            this.btnClientesAbrir.Transparency = false;
            // 
            // altoButton8
            // 
            this.altoButton8.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton8.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altoButton8.BackColor = System.Drawing.Color.Transparent;
            this.altoButton8.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton8.ForeColor = System.Drawing.Color.White;
            this.altoButton8.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton8.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.altoButton8.Location = new System.Drawing.Point(240, 7);
            this.altoButton8.Name = "altoButton8";
            this.altoButton8.Radius = 10;
            this.altoButton8.Size = new System.Drawing.Size(73, 30);
            this.altoButton8.Stroke = false;
            this.altoButton8.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton8.TabIndex = 11;
            this.altoButton8.Text = "Sucursales";
            this.altoButton8.Transparency = false;
            // 
            // btn_EmpleadosAbrir
            // 
            this.btn_EmpleadosAbrir.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_EmpleadosAbrir.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.btn_EmpleadosAbrir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EmpleadosAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btn_EmpleadosAbrir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_EmpleadosAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmpleadosAbrir.ForeColor = System.Drawing.Color.White;
            this.btn_EmpleadosAbrir.Inactive1 = System.Drawing.Color.LightSalmon;
            this.btn_EmpleadosAbrir.Inactive2 = System.Drawing.Color.LightSalmon;
            this.btn_EmpleadosAbrir.Location = new System.Drawing.Point(714, 7);
            this.btn_EmpleadosAbrir.Name = "btn_EmpleadosAbrir";
            this.btn_EmpleadosAbrir.Radius = 10;
            this.btn_EmpleadosAbrir.Size = new System.Drawing.Size(75, 30);
            this.btn_EmpleadosAbrir.Stroke = false;
            this.btn_EmpleadosAbrir.StrokeColor = System.Drawing.Color.Gray;
            this.btn_EmpleadosAbrir.TabIndex = 7;
            this.btn_EmpleadosAbrir.Text = "Empleados";
            this.btn_EmpleadosAbrir.Transparency = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Finalizar compra";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 44);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(752, 319);
            this.dataGridView3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(230)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::LenguajeDB.Properties.Resources.Search;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(387, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Buscar pedido";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private PlaceholderTextBox.PlaceholderTextBox txtClienteFiltro;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox txtPedidoFiltro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox4;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox7;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox6;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AltoControls.AltoButton altoButton5;
        private AltoControls.AltoButton altoButton7;
        private AltoControls.AltoButton altoButton6;
        private AltoControls.AltoButton altoButton2;
        private AltoControls.AltoButton altoButton4;
        private AltoControls.AltoButton btnClientesAbrir;
        private AltoControls.AltoButton altoButton8;
        private AltoControls.AltoButton btn_EmpleadosAbrir;
        private System.Windows.Forms.Button button3;
    }
}