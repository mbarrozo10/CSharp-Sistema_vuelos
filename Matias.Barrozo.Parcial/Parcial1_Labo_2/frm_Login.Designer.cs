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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pic_Modo = new System.Windows.Forms.PictureBox();
            this.pic_Ingresar = new System.Windows.Forms.PictureBox();
            this.pic_Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Modo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ingresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(215, 114);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(47, 15);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(206, 195);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(67, 15);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Autocompletar.Location = new System.Drawing.Point(185, 404);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(114, 34);
            this.btn_Autocompletar.TabIndex = 2;
            this.btn_Autocompletar.Text = "Autocompletar";
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(191, 213);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 23);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(191, 132);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 23);
            this.txt_Usuario.TabIndex = 6;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Error.Location = new System.Drawing.Point(137, 73);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Modo
            // 
            this.pic_Modo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Modo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Modo.Image = global::Parcial1_Labo_2.Properties.Resources.night_mode1;
            this.pic_Modo.Location = new System.Drawing.Point(428, 28);
            this.pic_Modo.Name = "pic_Modo";
            this.pic_Modo.Size = new System.Drawing.Size(33, 33);
            this.pic_Modo.TabIndex = 8;
            this.pic_Modo.TabStop = false;
            this.pic_Modo.Click += new System.EventHandler(this.pic_Modo_Click);
            // 
            // pic_Ingresar
            // 
            this.pic_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Ingresar.Image")));
            this.pic_Ingresar.Location = new System.Drawing.Point(178, 270);
            this.pic_Ingresar.Name = "pic_Ingresar";
            this.pic_Ingresar.Size = new System.Drawing.Size(125, 42);
            this.pic_Ingresar.TabIndex = 9;
            this.pic_Ingresar.TabStop = false;
            this.pic_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // pic_Salir
            // 
            this.pic_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Salir.Image = global::Parcial1_Labo_2.Properties.Resources.Salir_Negro;
            this.pic_Salir.Location = new System.Drawing.Point(178, 316);
            this.pic_Salir.Name = "pic_Salir";
            this.pic_Salir.Size = new System.Drawing.Size(125, 42);
            this.pic_Salir.TabIndex = 10;
            this.pic_Salir.TabStop = false;
            this.pic_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.pic_Salir);
            this.Controls.Add(this.pic_Ingresar);
            this.Controls.Add(this.pic_Modo);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Modo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ingresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Usuario;
        private Label lbl_Contraseña;
        private Button btn_Autocompletar;
        private TextBox txt_Contraseña;
        private TextBox txt_Usuario;
        private Label lbl_Error;
        private PictureBox pic_Modo;
        private PictureBox pic_Ingresar;
        private PictureBox pic_Salir;
    }
}