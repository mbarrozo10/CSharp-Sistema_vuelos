namespace Parcial1_Labo_2
{
    partial class frm_Venta
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
            this.lbl_PrecioFinal = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.prg_CantidadRestante = new System.Windows.Forms.ProgressBar();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.lbl_Duracion = new System.Windows.Forms.Label();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_PrecioSub = new System.Windows.Forms.Label();
            this.chk_Premium = new System.Windows.Forms.CheckBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_Equipaje = new System.Windows.Forms.Label();
            this.lbl_Kg = new System.Windows.Forms.Label();
            this.txt_Kg = new System.Windows.Forms.TextBox();
            this.nud_CantEquipaje = new System.Windows.Forms.NumericUpDown();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pic_Agregar = new System.Windows.Forms.PictureBox();
            this.pic_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_KgMax = new System.Windows.Forms.Label();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPasajesCompradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chk_BolsoMano = new System.Windows.Forms.CheckBox();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.btn_AceptarCliente = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_ErrorBusqueda = new System.Windows.Forms.Label();
            this.lbl_Impuestos = new System.Windows.Forms.Label();
            this.rtx_PasajerosAgregados = new System.Windows.Forms.RichTextBox();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PrecioFinal
            // 
            this.lbl_PrecioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrecioFinal.AutoSize = true;
            this.lbl_PrecioFinal.Location = new System.Drawing.Point(1023, 521);
            this.lbl_PrecioFinal.Name = "lbl_PrecioFinal";
            this.lbl_PrecioFinal.Size = new System.Drawing.Size(71, 15);
            this.lbl_PrecioFinal.TabIndex = 2;
            this.lbl_PrecioFinal.Text = "Precio Final:";
            this.tip_Ayuda.SetToolTip(this.lbl_PrecioFinal, "Precio del pasaje con impuestos");
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(803, 289);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 4;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(803, 204);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_Dni.TabIndex = 5;
            this.lbl_Dni.Text = "DNI";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(803, 131);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 6;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(803, 56);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // prg_CantidadRestante
            // 
            this.prg_CantidadRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prg_CantidadRestante.Location = new System.Drawing.Point(83, 588);
            this.prg_CantidadRestante.Maximum = 4;
            this.prg_CantidadRestante.Name = "prg_CantidadRestante";
            this.prg_CantidadRestante.Size = new System.Drawing.Size(670, 23);
            this.prg_CantidadRestante.TabIndex = 8;
            this.tip_Ayuda.SetToolTip(this.prg_CantidadRestante, "Muestra el progreso segun la cantidad de personas que se van a agregar");
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(83, 454);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(100, 15);
            this.lbl_Codigo.TabIndex = 13;
            this.lbl_Codigo.Text = "Codigo de vuelo: ";
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Location = new System.Drawing.Point(83, 487);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(49, 15);
            this.lbl_Origen.TabIndex = 12;
            this.lbl_Origen.Text = "Origen: ";
            // 
            // lbl_Duracion
            // 
            this.lbl_Duracion.AutoSize = true;
            this.lbl_Duracion.Location = new System.Drawing.Point(83, 521);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(112, 15);
            this.lbl_Duracion.TabIndex = 11;
            this.lbl_Duracion.Text = "Duracion del vuelo: ";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Location = new System.Drawing.Point(83, 551);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(53, 15);
            this.lbl_Destino.TabIndex = 10;
            this.lbl_Destino.Text = "Destino: ";
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Enabled = false;
            this.nud_Cantidad.Location = new System.Drawing.Point(604, 42);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(38, 23);
            this.nud_Cantidad.TabIndex = 14;
            this.tip_Ayuda.SetToolTip(this.nud_Cantidad, "Selector de cantidad de pasajeros, maximo hasta 4, comprueba que haya espacio al " +
        "momento de aceptar");
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(463, 50);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(126, 15);
            this.lbl_Cantidad.TabIndex = 15;
            this.lbl_Cantidad.Text = "Cantidad de pasajeros:";
            // 
            // lbl_PrecioSub
            // 
            this.lbl_PrecioSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrecioSub.AutoSize = true;
            this.lbl_PrecioSub.Location = new System.Drawing.Point(1023, 444);
            this.lbl_PrecioSub.Name = "lbl_PrecioSub";
            this.lbl_PrecioSub.Size = new System.Drawing.Size(90, 15);
            this.lbl_PrecioSub.TabIndex = 16;
            this.lbl_PrecioSub.Text = "Precio Subtotal:";
            this.tip_Ayuda.SetToolTip(this.lbl_PrecioSub, "Precio del pasaje sin impuesto");
            // 
            // chk_Premium
            // 
            this.chk_Premium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Premium.AutoSize = true;
            this.chk_Premium.Enabled = false;
            this.chk_Premium.Location = new System.Drawing.Point(1000, 78);
            this.chk_Premium.Name = "chk_Premium";
            this.chk_Premium.Size = new System.Drawing.Size(75, 19);
            this.chk_Premium.TabIndex = 17;
            this.chk_Premium.Text = "Premium";
            this.tip_Ayuda.SetToolTip(this.chk_Premium, "Check de premium, si esta activado amplia la cantidad (a 2) de equipaje y su peso" +
        " total hasta 42");
            this.chk_Premium.UseVisualStyleBackColor = true;
            this.chk_Premium.CheckedChanged += new System.EventHandler(this.chk_Premium_CheckedChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(803, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 18;
            this.tip_Ayuda.SetToolTip(this.txt_Nombre, "Ingreso del nombre, solo acepta letras");
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(803, 158);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 19;
            this.tip_Ayuda.SetToolTip(this.txt_Apellido, "Ingreso del apellido, solo acepta letras");
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Dni.Enabled = false;
            this.txt_Dni.Location = new System.Drawing.Point(803, 235);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 23);
            this.txt_Dni.TabIndex = 20;
            this.tip_Ayuda.SetToolTip(this.txt_Dni, "Ingreso de dni, solo acepta numeros en un rango");
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Edad
            // 
            this.txt_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Edad.Enabled = false;
            this.txt_Edad.Location = new System.Drawing.Point(803, 321);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 23);
            this.txt_Edad.TabIndex = 21;
            this.tip_Ayuda.SetToolTip(this.txt_Edad, "Ingreso de edad, solo acepta numeros en un rango");
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // lbl_Equipaje
            // 
            this.lbl_Equipaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Equipaje.AutoSize = true;
            this.lbl_Equipaje.Location = new System.Drawing.Point(1000, 131);
            this.lbl_Equipaje.Name = "lbl_Equipaje";
            this.lbl_Equipaje.Size = new System.Drawing.Size(52, 15);
            this.lbl_Equipaje.TabIndex = 22;
            this.lbl_Equipaje.Text = "Equipaje";
            // 
            // lbl_Kg
            // 
            this.lbl_Kg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Kg.AutoSize = true;
            this.lbl_Kg.Location = new System.Drawing.Point(1095, 131);
            this.lbl_Kg.Name = "lbl_Kg";
            this.lbl_Kg.Size = new System.Drawing.Size(21, 15);
            this.lbl_Kg.TabIndex = 23;
            this.lbl_Kg.Text = "Kg";
            // 
            // txt_Kg
            // 
            this.txt_Kg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Kg.Enabled = false;
            this.txt_Kg.Location = new System.Drawing.Point(1095, 158);
            this.txt_Kg.MaxLength = 2;
            this.txt_Kg.Name = "txt_Kg";
            this.txt_Kg.Size = new System.Drawing.Size(34, 23);
            this.txt_Kg.TabIndex = 24;
            this.tip_Ayuda.SetToolTip(this.txt_Kg, "Ingreso del peso del equipaje, si es premium llega hasta 42, sino hasta 25");
            this.txt_Kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kg_KeyPress);
            // 
            // nud_CantEquipaje
            // 
            this.nud_CantEquipaje.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nud_CantEquipaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_CantEquipaje.Enabled = false;
            this.nud_CantEquipaje.Location = new System.Drawing.Point(1014, 158);
            this.nud_CantEquipaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantEquipaje.Name = "nud_CantEquipaje";
            this.nud_CantEquipaje.Size = new System.Drawing.Size(38, 23);
            this.nud_CantEquipaje.TabIndex = 25;
            this.tip_Ayuda.SetToolTip(this.nud_CantEquipaje, "Selector de cantidad de equipaje, si no es premium solo es 1");
            this.nud_CantEquipaje.ValueChanged += new System.EventHandler(this.nud_CantEquipaje_ValueChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(663, 20);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 26;
            // 
            // pic_Agregar
            // 
            this.pic_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Agregar.Enabled = false;
            this.pic_Agregar.Image = global::Parcial1_Labo_2.Properties.Resources.agregar_negro_84x24;
            this.pic_Agregar.Location = new System.Drawing.Point(1133, 584);
            this.pic_Agregar.Name = "pic_Agregar";
            this.pic_Agregar.Size = new System.Drawing.Size(87, 27);
            this.pic_Agregar.TabIndex = 27;
            this.pic_Agregar.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Agregar, "Agrega el pasajero, si faltan mas por agregar limpia la informacion, si es el ult" +
        "imo vuelve al menu anterior");
            this.pic_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pic_Cancelar
            // 
            this.pic_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Cancelar.Image = global::Parcial1_Labo_2.Properties.Resources.cancelar_negro_84x24;
            this.pic_Cancelar.Location = new System.Drawing.Point(1023, 584);
            this.pic_Cancelar.Name = "pic_Cancelar";
            this.pic_Cancelar.Size = new System.Drawing.Size(87, 27);
            this.pic_Cancelar.TabIndex = 28;
            this.pic_Cancelar.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Cancelar, "Vuelve al menu anterior");
            this.pic_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(663, 42);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 29;
            this.btn_Aceptar.Text = "Aceptar";
            this.tip_Ayuda.SetToolTip(this.btn_Aceptar, "Confirma la cantidad de pasajeros, si no hay espacio lo notifica");
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_KgMax
            // 
            this.lbl_KgMax.AutoSize = true;
            this.lbl_KgMax.Location = new System.Drawing.Point(1135, 161);
            this.lbl_KgMax.Name = "lbl_KgMax";
            this.lbl_KgMax.Size = new System.Drawing.Size(40, 15);
            this.lbl_KgMax.TabIndex = 30;
            this.lbl_KgMax.Text = "/25 kg";
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AutoGenerateColumns = false;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.cantPasajesCompradosDataGridViewTextBoxColumn});
            this.dgv_Clientes.DataSource = this.clienteBindingSource;
            this.dgv_Clientes.Location = new System.Drawing.Point(32, 56);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.RowTemplate.Height = 25;
            this.dgv_Clientes.Size = new System.Drawing.Size(385, 352);
            this.dgv_Clientes.TabIndex = 31;
            this.dgv_Clientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Clientes_RowHeaderMouseClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantPasajesCompradosDataGridViewTextBoxColumn
            // 
            this.cantPasajesCompradosDataGridViewTextBoxColumn.DataPropertyName = "CantPasajesComprados";
            this.cantPasajesCompradosDataGridViewTextBoxColumn.HeaderText = "CantPasajesComprados";
            this.cantPasajesCompradosDataGridViewTextBoxColumn.Name = "cantPasajesCompradosDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Biblioteca.Cliente);
            // 
            // chk_BolsoMano
            // 
            this.chk_BolsoMano.AutoSize = true;
            this.chk_BolsoMano.Enabled = false;
            this.chk_BolsoMano.Location = new System.Drawing.Point(1000, 239);
            this.chk_BolsoMano.Name = "chk_BolsoMano";
            this.chk_BolsoMano.Size = new System.Drawing.Size(105, 19);
            this.chk_BolsoMano.TabIndex = 32;
            this.chk_BolsoMano.Text = "Bolso de mano";
            this.tip_Ayuda.SetToolTip(this.chk_BolsoMano, "Check de bolso de mano");
            this.chk_BolsoMano.UseVisualStyleBackColor = true;
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(32, 20);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(100, 23);
            this.txt_Buscador.TabIndex = 33;
            this.tip_Ayuda.SetToolTip(this.txt_Buscador, "Busca segun nombre,apellido y dni si no lo encuentra se informa y se puede agrega" +
        "r\r\n\r\n");
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscador_KeyPress);
            // 
            // btn_AceptarCliente
            // 
            this.btn_AceptarCliente.Location = new System.Drawing.Point(342, 423);
            this.btn_AceptarCliente.Name = "btn_AceptarCliente";
            this.btn_AceptarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarCliente.TabIndex = 35;
            this.btn_AceptarCliente.Text = "Aceptar";
            this.tip_Ayuda.SetToolTip(this.btn_AceptarCliente, "Una vez seleccionado el cliente se habilita, activa la cantidad de pasajeros a co" +
        "mprar");
            this.btn_AceptarCliente.UseVisualStyleBackColor = true;
            this.btn_AceptarCliente.Click += new System.EventHandler(this.btn_AceptarCliente_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(32, 423);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 36;
            this.btn_Agregar.Text = "Agregar";
            this.tip_Ayuda.SetToolTip(this.btn_Agregar, "Agrega un cliente");
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // lbl_ErrorBusqueda
            // 
            this.lbl_ErrorBusqueda.AutoSize = true;
            this.lbl_ErrorBusqueda.Location = new System.Drawing.Point(158, 23);
            this.lbl_ErrorBusqueda.Name = "lbl_ErrorBusqueda";
            this.lbl_ErrorBusqueda.Size = new System.Drawing.Size(0, 15);
            this.lbl_ErrorBusqueda.TabIndex = 37;
            // 
            // lbl_Impuestos
            // 
            this.lbl_Impuestos.AutoSize = true;
            this.lbl_Impuestos.Location = new System.Drawing.Point(1023, 481);
            this.lbl_Impuestos.Name = "lbl_Impuestos";
            this.lbl_Impuestos.Size = new System.Drawing.Size(124, 15);
            this.lbl_Impuestos.TabIndex = 38;
            this.lbl_Impuestos.Text = "Impuestos: 90%  + IVA";
            // 
            // rtx_PasajerosAgregados
            // 
            this.rtx_PasajerosAgregados.Location = new System.Drawing.Point(522, 161);
            this.rtx_PasajerosAgregados.Name = "rtx_PasajerosAgregados";
            this.rtx_PasajerosAgregados.ReadOnly = true;
            this.rtx_PasajerosAgregados.Size = new System.Drawing.Size(168, 192);
            this.rtx_PasajerosAgregados.TabIndex = 39;
            this.rtx_PasajerosAgregados.Text = "";
            this.tip_Ayuda.SetToolTip(this.rtx_PasajerosAgregados, "Muestra el nombre y apellido de los pasajeros agregados");
            // 
            // frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1290, 655);
            this.ControlBox = false;
            this.Controls.Add(this.rtx_PasajerosAgregados);
            this.Controls.Add(this.lbl_Impuestos);
            this.Controls.Add(this.lbl_ErrorBusqueda);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_AceptarCliente);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.chk_BolsoMano);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.lbl_KgMax);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.pic_Cancelar);
            this.Controls.Add(this.pic_Agregar);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.nud_CantEquipaje);
            this.Controls.Add(this.txt_Kg);
            this.Controls.Add(this.lbl_Kg);
            this.Controls.Add(this.lbl_Equipaje);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.chk_Premium);
            this.Controls.Add(this.lbl_PrecioSub);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.lbl_Duracion);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.prg_CantidadRestante);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_PrecioFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frm_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Venta";
            this.Load += new System.EventHandler(this.frm_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_PrecioFinal;
        private Label lbl_Edad;
        private Label lbl_Dni;
        private Label lbl_Apellido;
        private Label lbl_Nombre;
        private ProgressBar prg_CantidadRestante;
        private Label lbl_Codigo;
        private Label lbl_Origen;
        private Label lbl_Duracion;
        private Label lbl_Destino;
        private NumericUpDown nud_Cantidad;
        private Label lbl_Cantidad;
        private Label lbl_PrecioSub;
        private CheckBox chk_Premium;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private TextBox txt_Edad;
        private Label lbl_Equipaje;
        private Label lbl_Kg;
        private TextBox txt_Kg;
        private NumericUpDown nud_CantEquipaje;
        private Label lbl_Error;
        private PictureBox pic_Agregar;
        private PictureBox pic_Cancelar;
        private Button btn_Aceptar;
        private Label lbl_KgMax;
        private DataGridView dgv_Clientes;
        private CheckBox chk_BolsoMano;
        private TextBox txt_Buscador;
        private Button btn_AceptarCliente;
        private Button btn_Agregar;
        private Label lbl_ErrorBusqueda;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantPasajesCompradosDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private Label lbl_Impuestos;
        private RichTextBox rtx_PasajerosAgregados;
        private ToolTip tip_Ayuda;
    }
}