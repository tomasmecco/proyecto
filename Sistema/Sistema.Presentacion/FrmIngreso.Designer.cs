namespace Sistema.Presentacion
{
    partial class FrmIngreso
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
            this.components = new System.ComponentModel.Container();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelArticulos = new System.Windows.Forms.Panel();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnCerrarArticulos = new System.Windows.Forms.Button();
            this.BtnFiltrarArticulos = new System.Windows.Forms.Button();
            this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.BtnVerArticulo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProveedores = new System.Windows.Forms.Button();
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.TxtSerieComprobante = new System.Windows.Forms.TextBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.TxtNumComprobante = new System.Windows.Forms.TextBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtTotalimpuestoD = new System.Windows.Forms.TextBox();
            this.TxtSubtotalD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PanelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PanelArticulos);
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.TxtTotalImpuesto);
            this.groupBox2.Controls.Add(this.TxtSubtotal);
            this.groupBox2.Controls.Add(this.DgvDetalle);
            this.groupBox2.Controls.Add(this.BtnVerArticulo);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 445);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // PanelArticulos
            // 
            this.PanelArticulos.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelArticulos.Controls.Add(this.LblTotalArticulos);
            this.PanelArticulos.Controls.Add(this.DgvArticulos);
            this.PanelArticulos.Controls.Add(this.BtnCerrarArticulos);
            this.PanelArticulos.Controls.Add(this.BtnFiltrarArticulos);
            this.PanelArticulos.Controls.Add(this.TxtBuscarArticulo);
            this.PanelArticulos.Controls.Add(this.label12);
            this.PanelArticulos.Location = new System.Drawing.Point(6, 110);
            this.PanelArticulos.Name = "PanelArticulos";
            this.PanelArticulos.Size = new System.Drawing.Size(854, 308);
            this.PanelArticulos.TabIndex = 11;
            this.PanelArticulos.Visible = false;
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalArticulos.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblTotalArticulos.Location = new System.Drawing.Point(698, 269);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(48, 16);
            this.LblTotalArticulos.TabIndex = 14;
            this.LblTotalArticulos.Text = "Total:";
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(0, 39);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(844, 213);
            this.DgvArticulos.TabIndex = 13;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick);
            // 
            // BtnCerrarArticulos
            // 
            this.BtnCerrarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarArticulos.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrarArticulos.Location = new System.Drawing.Point(819, 0);
            this.BtnCerrarArticulos.Name = "BtnCerrarArticulos";
            this.BtnCerrarArticulos.Size = new System.Drawing.Size(25, 23);
            this.BtnCerrarArticulos.TabIndex = 12;
            this.BtnCerrarArticulos.Text = "X";
            this.BtnCerrarArticulos.UseVisualStyleBackColor = true;
            this.BtnCerrarArticulos.Click += new System.EventHandler(this.BtnCerrarArticulos_Click);
            // 
            // BtnFiltrarArticulos
            // 
            this.BtnFiltrarArticulos.Location = new System.Drawing.Point(354, 7);
            this.BtnFiltrarArticulos.Name = "BtnFiltrarArticulos";
            this.BtnFiltrarArticulos.Size = new System.Drawing.Size(110, 23);
            this.BtnFiltrarArticulos.TabIndex = 11;
            this.BtnFiltrarArticulos.Text = "Buscar";
            this.BtnFiltrarArticulos.UseVisualStyleBackColor = true;
            this.BtnFiltrarArticulos.Click += new System.EventHandler(this.BtnFiltrarArticulos_Click);
            // 
            // TxtBuscarArticulo
            // 
            this.TxtBuscarArticulo.Location = new System.Drawing.Point(89, 10);
            this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
            this.TxtBuscarArticulo.Size = new System.Drawing.Size(237, 20);
            this.TxtBuscarArticulo.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Buscar";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(699, 418);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 13;
            // 
            // TxtTotalImpuesto
            // 
            this.TxtTotalImpuesto.Enabled = false;
            this.TxtTotalImpuesto.Location = new System.Drawing.Point(699, 345);
            this.TxtTotalImpuesto.Name = "TxtTotalImpuesto";
            this.TxtTotalImpuesto.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalImpuesto.TabIndex = 12;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(699, 384);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotal.TabIndex = 11;
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(11, 57);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(791, 270);
            this.DgvDetalle.TabIndex = 10;
            this.DgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            this.DgvDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvDetalle_RowsRemoved);
            // 
            // BtnVerArticulo
            // 
            this.BtnVerArticulo.Location = new System.Drawing.Point(555, 28);
            this.BtnVerArticulo.Name = "BtnVerArticulo";
            this.BtnVerArticulo.Size = new System.Drawing.Size(110, 23);
            this.BtnVerArticulo.TabIndex = 9;
            this.BtnVerArticulo.Text = "Ver";
            this.BtnVerArticulo.UseVisualStyleBackColor = true;
            this.BtnVerArticulo.Click += new System.EventHandler(this.BtnVerArticulo_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(84, 28);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(438, 20);
            this.TxtCodigo.TabIndex = 8;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(619, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Artículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtImpuesto);
            this.groupBox1.Controls.Add(this.BtnBuscarProveedores);
            this.groupBox1.Controls.Add(this.CboComprobante);
            this.groupBox1.Controls.Add(this.TxtSerieComprobante);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.TxtNumComprobante);
            this.groupBox1.Controls.Add(this.TxtIdProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Location = new System.Drawing.Point(669, 81);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.TxtImpuesto.TabIndex = 11;
            this.TxtImpuesto.Text = "0.18";
            // 
            // BtnBuscarProveedores
            // 
            this.BtnBuscarProveedores.Location = new System.Drawing.Point(554, 29);
            this.BtnBuscarProveedores.Name = "BtnBuscarProveedores";
            this.BtnBuscarProveedores.Size = new System.Drawing.Size(110, 23);
            this.BtnBuscarProveedores.TabIndex = 10;
            this.BtnBuscarProveedores.Text = "Buscar";
            this.BtnBuscarProveedores.UseVisualStyleBackColor = true;
            this.BtnBuscarProveedores.Click += new System.EventHandler(this.BtnBuscarProveedores_Click);
            // 
            // CboComprobante
            // 
            this.CboComprobante.FormattingEnabled = true;
            this.CboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "TICKET",
            "GUIA",
            "COMPROBANTE"});
            this.CboComprobante.Location = new System.Drawing.Point(99, 81);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.Size = new System.Drawing.Size(121, 21);
            this.CboComprobante.TabIndex = 9;
            this.CboComprobante.Text = "FACTURA";
            // 
            // TxtSerieComprobante
            // 
            this.TxtSerieComprobante.Location = new System.Drawing.Point(250, 82);
            this.TxtSerieComprobante.Name = "TxtSerieComprobante";
            this.TxtSerieComprobante.Size = new System.Drawing.Size(111, 20);
            this.TxtSerieComprobante.TabIndex = 8;
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Enabled = false;
            this.TxtNombreProveedor.Location = new System.Drawing.Point(250, 31);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(271, 20);
            this.TxtNombreProveedor.TabIndex = 7;
            // 
            // TxtNumComprobante
            // 
            this.TxtNumComprobante.Location = new System.Drawing.Point(376, 81);
            this.TxtNumComprobante.Name = "TxtNumComprobante";
            this.TxtNumComprobante.Size = new System.Drawing.Size(145, 20);
            this.TxtNumComprobante.TabIndex = 6;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Enabled = false;
            this.TxtIdProveedor.Location = new System.Drawing.Point(99, 31);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(121, 20);
            this.TxtIdProveedor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Impuesto (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "COMPROBANTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SERIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprobante (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*)Indica que el dato es obligatorio";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(278, 612);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(152, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(123, 612);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(129, 23);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.BackColor = System.Drawing.Color.DarkBlue;
            this.PanelMostrar.Controls.Add(this.TxtTotalD);
            this.PanelMostrar.Controls.Add(this.TxtTotalimpuestoD);
            this.PanelMostrar.Controls.Add(this.TxtSubtotalD);
            this.PanelMostrar.Controls.Add(this.label15);
            this.PanelMostrar.Controls.Add(this.label14);
            this.PanelMostrar.Controls.Add(this.label13);
            this.PanelMostrar.Controls.Add(this.BtnCerrarDetalle);
            this.PanelMostrar.Controls.Add(this.DgvMostrarDetalle);
            this.PanelMostrar.Location = new System.Drawing.Point(142, 0);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(704, 363);
            this.PanelMostrar.TabIndex = 7;
            this.PanelMostrar.Visible = false;
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.Enabled = false;
            this.TxtTotalD.Location = new System.Drawing.Point(589, 330);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalD.TabIndex = 7;
            // 
            // TxtTotalimpuestoD
            // 
            this.TxtTotalimpuestoD.Enabled = false;
            this.TxtTotalimpuestoD.Location = new System.Drawing.Point(589, 278);
            this.TxtTotalimpuestoD.Name = "TxtTotalimpuestoD";
            this.TxtTotalimpuestoD.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalimpuestoD.TabIndex = 6;
            // 
            // TxtSubtotalD
            // 
            this.TxtSubtotalD.Enabled = false;
            this.TxtSubtotalD.Location = new System.Drawing.Point(589, 304);
            this.TxtSubtotalD.Name = "TxtSubtotalD";
            this.TxtSubtotalD.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotalD.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(492, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Subtotal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(492, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total Impuesto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(492, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total";
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarDetalle.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(677, 4);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(24, 23);
            this.BtnCerrarDetalle.TabIndex = 1;
            this.BtnCerrarDetalle.Text = "X";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = true;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // DgvMostrarDetalle
            // 
            this.DgvMostrarDetalle.AllowUserToAddRows = false;
            this.DgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarDetalle.Location = new System.Drawing.Point(3, 33);
            this.DgvMostrarDetalle.Name = "DgvMostrarDetalle";
            this.DgvMostrarDetalle.ReadOnly = true;
            this.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalle.Size = new System.Drawing.Size(695, 239);
            this.DgvMostrarDetalle.TabIndex = 0;
            // 
            // BtnAnular
            // 
            this.BtnAnular.Location = new System.Drawing.Point(219, 364);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(133, 23);
            this.BtnAnular.TabIndex = 6;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = true;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(9, 368);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(341, 15);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(89, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(9, 15);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(315, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(585, 368);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(31, 13);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 41);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(840, 313);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(1, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(872, 670);
            this.TabGeneral.TabIndex = 2;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 683);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PanelArticulos.ResumeLayout(false);
            this.PanelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelMostrar.ResumeLayout(false);
            this.PanelMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtSerieComprobante;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.TextBox TxtNumComprobante;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtTotalImpuesto;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Button BtnVerArticulo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Button BtnBuscarProveedores;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.Panel PanelArticulos;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Button BtnCerrarArticulos;
        private System.Windows.Forms.Button BtnFiltrarArticulos;
        private System.Windows.Forms.TextBox TxtBuscarArticulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.TextBox TxtTotalimpuestoD;
        private System.Windows.Forms.TextBox TxtSubtotalD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.DataGridView DgvMostrarDetalle;
    }
}