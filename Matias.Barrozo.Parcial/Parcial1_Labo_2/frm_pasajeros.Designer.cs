namespace Parcial1_Labo_2
{
    partial class frm_pasajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pasajeros));
            this.dgv_Pasajeros = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pic_Salir = new System.Windows.Forms.PictureBox();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Buscador = new System.Windows.Forms.Label();
            this.txt_BuscadorPasajero = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pasajeros
            // 
            this.dgv_Pasajeros.AutoGenerateColumns = false;
            this.dgv_Pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.premiumDataGridViewCheckBoxColumn,
            this.equipajeDataGridViewTextBoxColumn});
            this.dgv_Pasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_Pasajeros.Location = new System.Drawing.Point(64, 89);
            this.dgv_Pasajeros.Name = "dgv_Pasajeros";
            this.dgv_Pasajeros.RowTemplate.Height = 25;
            this.dgv_Pasajeros.Size = new System.Drawing.Size(576, 334);
            this.dgv_Pasajeros.TabIndex = 0;
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
            // premiumDataGridViewCheckBoxColumn
            // 
            this.premiumDataGridViewCheckBoxColumn.DataPropertyName = "Premium";
            this.premiumDataGridViewCheckBoxColumn.HeaderText = "Premium";
            this.premiumDataGridViewCheckBoxColumn.Name = "premiumDataGridViewCheckBoxColumn";
            this.premiumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // equipajeDataGridViewTextBoxColumn
            // 
            this.equipajeDataGridViewTextBoxColumn.DataPropertyName = "Equipaje";
            this.equipajeDataGridViewTextBoxColumn.HeaderText = "Equipaje";
            this.equipajeDataGridViewTextBoxColumn.Name = "equipajeDataGridViewTextBoxColumn";
            this.equipajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Biblioteca.Pasajero);
            // 
            // pic_Salir
            // 
            this.pic_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Salir.Image = global::Parcial1_Labo_2.Properties.Resources.salir_negro_84x24;
            this.pic_Salir.Location = new System.Drawing.Point(681, 398);
            this.pic_Salir.Name = "pic_Salir";
            this.pic_Salir.Size = new System.Drawing.Size(86, 25);
            this.pic_Salir.TabIndex = 1;
            this.pic_Salir.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Salir, "Vuelve al menu principal");
            this.pic_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Buscador
            // 
            this.lbl_Buscador.AutoSize = true;
            this.lbl_Buscador.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Buscador.ForeColor = System.Drawing.Color.Black;
            this.lbl_Buscador.Location = new System.Drawing.Point(64, 26);
            this.lbl_Buscador.Name = "lbl_Buscador";
            this.lbl_Buscador.Size = new System.Drawing.Size(64, 14);
            this.lbl_Buscador.TabIndex = 2;
            this.lbl_Buscador.Text = "Buscador";
            // 
            // txt_BuscadorPasajero
            // 
            this.txt_BuscadorPasajero.Location = new System.Drawing.Point(64, 43);
            this.txt_BuscadorPasajero.Name = "txt_BuscadorPasajero";
            this.txt_BuscadorPasajero.Size = new System.Drawing.Size(145, 23);
            this.txt_BuscadorPasajero.TabIndex = 3;
            this.tip_Ayuda.SetToolTip(this.txt_BuscadorPasajero, "Permite buscar pasajeros por nombre/apellido/dni");
            this.txt_BuscadorPasajero.TextChanged += new System.EventHandler(this.txt_BuscadorPasajero_TextChanged);
            this.txt_BuscadorPasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscadorPasajero_KeyPress);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.Location = new System.Drawing.Point(234, 47);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 14);
            this.lbl_Error.TabIndex = 4;
            // 
            // frm_pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_BuscadorPasajero);
            this.Controls.Add(this.lbl_Buscador);
            this.Controls.Add(this.pic_Salir);
            this.Controls.Add(this.dgv_Pasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_pasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_pasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Pasajeros;
        private BindingSource pasajeroBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn premiumDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn equipajeDataGridViewTextBoxColumn;
        private ToolTip tip_Ayuda;
        private PictureBox pic_Salir;
        private Label lbl_Buscador;
        private TextBox txt_BuscadorPasajero;
        private Label lbl_Error;
    }
}