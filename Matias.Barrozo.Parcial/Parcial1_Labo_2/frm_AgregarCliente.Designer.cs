namespace Parcial1_Labo_2
{
    partial class frm_AgregarCliente
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
            this.pic_Agregar = new System.Windows.Forms.PictureBox();
            this.pic_Cancelar = new System.Windows.Forms.PictureBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Agregar
            // 
            this.pic_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Agregar.Image = global::Parcial1_Labo_2.Properties.Resources.agregar_negro_84x24;
            this.pic_Agregar.Location = new System.Drawing.Point(514, 242);
            this.pic_Agregar.Name = "pic_Agregar";
            this.pic_Agregar.Size = new System.Drawing.Size(86, 25);
            this.pic_Agregar.TabIndex = 0;
            this.pic_Agregar.TabStop = false;
            this.pic_Agregar.Visible = false;
            this.pic_Agregar.Click += new System.EventHandler(this.pic_Agregar_Click);
            // 
            // pic_Cancelar
            // 
            this.pic_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Cancelar.Image = global::Parcial1_Labo_2.Properties.Resources.cancelar_negro_84x24;
            this.pic_Cancelar.Location = new System.Drawing.Point(641, 242);
            this.pic_Cancelar.Name = "pic_Cancelar";
            this.pic_Cancelar.Size = new System.Drawing.Size(84, 25);
            this.pic_Cancelar.TabIndex = 1;
            this.pic_Cancelar.TabStop = false;
            this.pic_Cancelar.Click += new System.EventHandler(this.pic_Cancelar_Click);
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(293, 173);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 23);
            this.txt_Edad.TabIndex = 2;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(293, 47);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 3;
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(69, 173);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 23);
            this.txt_Dni.TabIndex = 4;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(69, 47);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(69, 29);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(514, 181);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 7;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(293, 155);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 8;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(293, 29);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 9;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(69, 155);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(25, 15);
            this.lbl_Dni.TabIndex = 10;
            this.lbl_Dni.Text = "Dni";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(505, 47);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 15);
            this.lbl_Info.TabIndex = 11;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(318, 242);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frm_AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.pic_Cancelar);
            this.Controls.Add(this.pic_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frm_AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_Agregar;
        private PictureBox pic_Cancelar;
        private TextBox txt_Edad;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private TextBox txt_Nombre;
        private Label lbl_Nombre;
        private Label lbl_Error;
        private Label lbl_Edad;
        private Label lbl_Apellido;
        private Label lbl_Dni;
        private Label lbl_Info;
        private Button btn_Aceptar;
    }
}