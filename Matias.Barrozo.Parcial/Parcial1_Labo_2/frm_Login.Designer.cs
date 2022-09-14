namespace Parcial1_Labo_2
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(365, 112);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(47, 15);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(356, 193);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(67, 15);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Autocompletar.Location = new System.Drawing.Point(654, 393);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(114, 34);
            this.btn_Autocompletar.TabIndex = 2;
            this.btn_Autocompletar.Text = "Autocompletar";
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Location = new System.Drawing.Point(353, 326);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AutoEllipsis = true;
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.Location = new System.Drawing.Point(353, 287);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(341, 211);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 23);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(341, 130);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 23);
            this.txt_Usuario.TabIndex = 6;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Error.Location = new System.Drawing.Point(293, 76);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "frm_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Usuario;
        private Label lbl_Contraseña;
        private Button btn_Autocompletar;
        private Button btn_Salir;
        private Button btn_Ingresar;
        private TextBox txt_Contraseña;
        private TextBox txt_Usuario;
        private Label lbl_Error;
        private System.Windows.Forms.Timer timer1;
    }
}