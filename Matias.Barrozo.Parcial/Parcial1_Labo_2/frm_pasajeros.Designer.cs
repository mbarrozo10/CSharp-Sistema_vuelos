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
            this.dgv_Pasajeros = new System.Windows.Forms.DataGridView();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Salir = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPasajesCompradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
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
            this.equipajeDataGridViewTextBoxColumn,
            this.cantPasajesCompradosDataGridViewTextBoxColumn});
            this.dgv_Pasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_Pasajeros.Location = new System.Drawing.Point(83, 26);
            this.dgv_Pasajeros.Name = "dgv_Pasajeros";
            this.dgv_Pasajeros.RowTemplate.Height = 25;
            this.dgv_Pasajeros.Size = new System.Drawing.Size(576, 334);
            this.dgv_Pasajeros.TabIndex = 0;
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Biblioteca.Pasajero);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(693, 403);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
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
            // cantPasajesCompradosDataGridViewTextBoxColumn
            // 
            this.cantPasajesCompradosDataGridViewTextBoxColumn.DataPropertyName = "CantPasajesComprados";
            this.cantPasajesCompradosDataGridViewTextBoxColumn.HeaderText = "CantPasajesComprados";
            this.cantPasajesCompradosDataGridViewTextBoxColumn.Name = "cantPasajesCompradosDataGridViewTextBoxColumn";
            // 
            // frm_pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dgv_Pasajeros);
            this.Name = "frm_pasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_pasajeros";
            this.Load += new System.EventHandler(this.frm_pasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Pasajeros;
        private Button btn_Salir;
        private BindingSource pasajeroBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn premiumDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn equipajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantPasajesCompradosDataGridViewTextBoxColumn;
    }
}