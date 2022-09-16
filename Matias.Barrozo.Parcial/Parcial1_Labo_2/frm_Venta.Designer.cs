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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PrecioFinal
            // 
            this.lbl_PrecioFinal.AutoSize = true;
            this.lbl_PrecioFinal.Location = new System.Drawing.Point(883, 428);
            this.lbl_PrecioFinal.Name = "lbl_PrecioFinal";
            this.lbl_PrecioFinal.Size = new System.Drawing.Size(71, 15);
            this.lbl_PrecioFinal.TabIndex = 2;
            this.lbl_PrecioFinal.Text = "Precio Final:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(663, 289);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 4;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(663, 204);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_Dni.TabIndex = 5;
            this.lbl_Dni.Text = "DNI";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(663, 131);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 6;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(663, 56);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // prg_CantidadRestante
            // 
            this.prg_CantidadRestante.Location = new System.Drawing.Point(83, 495);
            this.prg_CantidadRestante.Maximum = 4;
            this.prg_CantidadRestante.Name = "prg_CantidadRestante";
            this.prg_CantidadRestante.Size = new System.Drawing.Size(670, 23);
            this.prg_CantidadRestante.TabIndex = 8;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(83, 56);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(100, 15);
            this.lbl_Codigo.TabIndex = 13;
            this.lbl_Codigo.Text = "Codigo de vuelo: ";
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Location = new System.Drawing.Point(83, 131);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(49, 15);
            this.lbl_Origen.TabIndex = 12;
            this.lbl_Origen.Text = "Origen: ";
            // 
            // lbl_Duracion
            // 
            this.lbl_Duracion.AutoSize = true;
            this.lbl_Duracion.Location = new System.Drawing.Point(83, 204);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(112, 15);
            this.lbl_Duracion.TabIndex = 11;
            this.lbl_Duracion.Text = "Duracion del vuelo: ";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Location = new System.Drawing.Point(83, 289);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(53, 15);
            this.lbl_Destino.TabIndex = 10;
            this.lbl_Destino.Text = "Destino: ";
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(212, 355);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(38, 23);
            this.nud_Cantidad.TabIndex = 14;
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(83, 357);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(126, 15);
            this.lbl_Cantidad.TabIndex = 15;
            this.lbl_Cantidad.Text = "Cantidad de pasajeros:";
            // 
            // lbl_PrecioSub
            // 
            this.lbl_PrecioSub.AutoSize = true;
            this.lbl_PrecioSub.Location = new System.Drawing.Point(883, 394);
            this.lbl_PrecioSub.Name = "lbl_PrecioSub";
            this.lbl_PrecioSub.Size = new System.Drawing.Size(90, 15);
            this.lbl_PrecioSub.TabIndex = 16;
            this.lbl_PrecioSub.Text = "Precio Subtotal:";
            // 
            // chk_Premium
            // 
            this.chk_Premium.AutoSize = true;
            this.chk_Premium.Enabled = false;
            this.chk_Premium.Location = new System.Drawing.Point(860, 78);
            this.chk_Premium.Name = "chk_Premium";
            this.chk_Premium.Size = new System.Drawing.Size(75, 19);
            this.chk_Premium.TabIndex = 17;
            this.chk_Premium.Text = "Premium";
            this.chk_Premium.UseVisualStyleBackColor = true;
            this.chk_Premium.CheckedChanged += new System.EventHandler(this.chk_Premium_CheckedChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(663, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 18;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(663, 158);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 19;
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Enabled = false;
            this.txt_Dni.Location = new System.Drawing.Point(663, 235);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 23);
            this.txt_Dni.TabIndex = 20;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Edad
            // 
            this.txt_Edad.Enabled = false;
            this.txt_Edad.Location = new System.Drawing.Point(663, 321);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 23);
            this.txt_Edad.TabIndex = 21;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // lbl_Equipaje
            // 
            this.lbl_Equipaje.AutoSize = true;
            this.lbl_Equipaje.Location = new System.Drawing.Point(860, 131);
            this.lbl_Equipaje.Name = "lbl_Equipaje";
            this.lbl_Equipaje.Size = new System.Drawing.Size(52, 15);
            this.lbl_Equipaje.TabIndex = 22;
            this.lbl_Equipaje.Text = "Equipaje";
            // 
            // lbl_Kg
            // 
            this.lbl_Kg.AutoSize = true;
            this.lbl_Kg.Location = new System.Drawing.Point(955, 131);
            this.lbl_Kg.Name = "lbl_Kg";
            this.lbl_Kg.Size = new System.Drawing.Size(21, 15);
            this.lbl_Kg.TabIndex = 23;
            this.lbl_Kg.Text = "Kg";
            // 
            // txt_Kg
            // 
            this.txt_Kg.Enabled = false;
            this.txt_Kg.Location = new System.Drawing.Point(955, 158);
            this.txt_Kg.Name = "txt_Kg";
            this.txt_Kg.Size = new System.Drawing.Size(34, 23);
            this.txt_Kg.TabIndex = 24;
            this.txt_Kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kg_KeyPress);
            // 
            // nud_CantEquipaje
            // 
            this.nud_CantEquipaje.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nud_CantEquipaje.Enabled = false;
            this.nud_CantEquipaje.Location = new System.Drawing.Point(874, 158);
            this.nud_CantEquipaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantEquipaje.Name = "nud_CantEquipaje";
            this.nud_CantEquipaje.Size = new System.Drawing.Size(38, 23);
            this.nud_CantEquipaje.TabIndex = 25;
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
            this.pic_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Agregar.Enabled = false;
            this.pic_Agregar.Image = global::Parcial1_Labo_2.Properties.Resources.agregar_negro_84x24;
            this.pic_Agregar.Location = new System.Drawing.Point(993, 491);
            this.pic_Agregar.Name = "pic_Agregar";
            this.pic_Agregar.Size = new System.Drawing.Size(87, 27);
            this.pic_Agregar.TabIndex = 27;
            this.pic_Agregar.TabStop = false;
            this.pic_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pic_Cancelar
            // 
            this.pic_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Cancelar.Image = global::Parcial1_Labo_2.Properties.Resources.cancelar_negro_84x24;
            this.pic_Cancelar.Location = new System.Drawing.Point(883, 491);
            this.pic_Cancelar.Name = "pic_Cancelar";
            this.pic_Cancelar.Size = new System.Drawing.Size(87, 27);
            this.pic_Cancelar.TabIndex = 28;
            this.pic_Cancelar.TabStop = false;
            this.pic_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 562);
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
            this.Name = "frm_Venta";
            this.Text = "frm_Venta";
            this.Load += new System.EventHandler(this.frm_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).EndInit();
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
    }
}