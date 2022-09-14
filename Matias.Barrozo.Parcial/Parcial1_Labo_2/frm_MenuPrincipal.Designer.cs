namespace Parcial1_Labo_2
{
    partial class frm_MenuPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Pasajeros = new System.Windows.Forms.Button();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(90, 9);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(0, 15);
            this.lbl_Bienvenido.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(990, 500);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Avion,
            this.Duracion,
            this.Costo,
            this.Origen,
            this.Destino,
            this.Hora,
            this.Estado,
            this.Asientos});
            this.dataGridView1.Location = new System.Drawing.Point(90, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(975, 419);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Vuelo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Avion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.Avion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Avion.HeaderText = "Avion";
            this.Avion.Name = "Avion";
            this.Avion.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo Turista";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hora.HeaderText = "Salida";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Asientos
            // 
            this.Asientos.HeaderText = "Asientos";
            this.Asientos.Name = "Asientos";
            this.Asientos.ReadOnly = true;
            // 
            // btn_Pasajeros
            // 
            this.btn_Pasajeros.Enabled = false;
            this.btn_Pasajeros.Location = new System.Drawing.Point(196, 500);
            this.btn_Pasajeros.Name = "btn_Pasajeros";
            this.btn_Pasajeros.Size = new System.Drawing.Size(75, 23);
            this.btn_Pasajeros.TabIndex = 3;
            this.btn_Pasajeros.Text = "Pasajeros";
            this.btn_Pasajeros.UseVisualStyleBackColor = true;
            this.btn_Pasajeros.Click += new System.EventHandler(this.btn_Pasajeros_Click);
            // 
            // btn_Vender
            // 
            this.btn_Vender.Enabled = false;
            this.btn_Vender.Location = new System.Drawing.Point(90, 500);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(75, 23);
            this.btn_Vender.TabIndex = 4;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(768, 500);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(112, 23);
            this.btn_AgregarVuelo.TabIndex = 5;
            this.btn_AgregarVuelo.Text = "Agregar Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 545);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.btn_Pasajeros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Name = "frm_MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Bienvenido;
        private Button btn_Salir;
        private DataGridView dataGridView1;
        private Button btn_Pasajeros;
        private Button btn_Vender;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Avion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Asientos;
        private Button btn_AgregarVuelo;
    }
}