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
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(275, 21);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(0, 15);
            this.lbl_Bienvenido.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(665, 406);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Avion,
            this.Duracion,
            this.Costo,
            this.Destino,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(52, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(625, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // Avion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.Avion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Avion.HeaderText = "Avion";
            this.Avion.Name = "Avion";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo Turista";
            this.Costo.Name = "Costo";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private DataGridViewTextBoxColumn Avion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Estado;
    }
}