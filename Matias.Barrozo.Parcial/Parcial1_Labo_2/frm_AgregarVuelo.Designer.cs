﻿namespace Parcial1_Labo_2
{
    partial class frm_AgregarVuelo
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
            this.lbl_Avion = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_Salida = new System.Windows.Forms.Label();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Asientos = new System.Windows.Forms.Label();
            this.cmb_Avion = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.dtp_Salida = new System.Windows.Forms.DateTimePicker();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.cmb_Salida = new System.Windows.Forms.ComboBox();
            this.lbl_HoraSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Avion
            // 
            this.lbl_Avion.AutoSize = true;
            this.lbl_Avion.Location = new System.Drawing.Point(95, 68);
            this.lbl_Avion.Name = "lbl_Avion";
            this.lbl_Avion.Size = new System.Drawing.Size(72, 15);
            this.lbl_Avion.TabIndex = 0;
            this.lbl_Avion.Text = "Elija el avion";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(624, 275);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(47, 15);
            this.lbl_destino.TabIndex = 1;
            this.lbl_destino.Text = "Destino";
            // 
            // lbl_Salida
            // 
            this.lbl_Salida.AutoSize = true;
            this.lbl_Salida.Location = new System.Drawing.Point(341, 68);
            this.lbl_Salida.Name = "lbl_Salida";
            this.lbl_Salida.Size = new System.Drawing.Size(87, 15);
            this.lbl_Salida.TabIndex = 2;
            this.lbl_Salida.Text = "Fecha de salida";
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Location = new System.Drawing.Point(341, 275);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(43, 15);
            this.lbl_Origen.TabIndex = 4;
            this.lbl_Origen.Text = "Origen";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(95, 156);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(94, 15);
            this.lbl_Codigo.TabIndex = 5;
            this.lbl_Codigo.Text = "Codigo de vuelo";
            // 
            // lbl_Asientos
            // 
            this.lbl_Asientos.AutoSize = true;
            this.lbl_Asientos.Location = new System.Drawing.Point(95, 244);
            this.lbl_Asientos.Name = "lbl_Asientos";
            this.lbl_Asientos.Size = new System.Drawing.Size(123, 15);
            this.lbl_Asientos.TabIndex = 6;
            this.lbl_Asientos.Text = "Cantidad de asientos: ";
            // 
            // cmb_Avion
            // 
            this.cmb_Avion.FormattingEnabled = true;
            this.cmb_Avion.Location = new System.Drawing.Point(95, 98);
            this.cmb_Avion.Name = "cmb_Avion";
            this.cmb_Avion.Size = new System.Drawing.Size(121, 23);
            this.cmb_Avion.TabIndex = 10;
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(624, 306);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(121, 23);
            this.cmb_Destino.TabIndex = 11;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(95, 187);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 23);
            this.txt_Codigo.TabIndex = 13;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(887, 346);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 15;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(788, 346);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 16;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(788, 306);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 17;
            // 
            // dtp_Salida
            // 
            this.dtp_Salida.CustomFormat = "hh:mm";
            this.dtp_Salida.Location = new System.Drawing.Point(341, 98);
            this.dtp_Salida.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtp_Salida.MinDate = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.dtp_Salida.Name = "dtp_Salida";
            this.dtp_Salida.Size = new System.Drawing.Size(200, 23);
            this.dtp_Salida.TabIndex = 18;
            this.dtp_Salida.Value = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.dtp_Salida.ValueChanged += new System.EventHandler(this.dtp_Salida_ValueChanged);
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(341, 306);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(121, 23);
            this.cmb_Origen.TabIndex = 19;
            this.cmb_Origen.SelectedValueChanged += new System.EventHandler(this.cmb_Origen_SelectedValueChanged);
            // 
            // cmb_Salida
            // 
            this.cmb_Salida.FormattingEnabled = true;
            this.cmb_Salida.Location = new System.Drawing.Point(341, 187);
            this.cmb_Salida.Name = "cmb_Salida";
            this.cmb_Salida.Size = new System.Drawing.Size(121, 23);
            this.cmb_Salida.TabIndex = 21;
            this.cmb_Salida.SelectedValueChanged += new System.EventHandler(this.cmb_Salida_SelectedValueChanged);
            // 
            // lbl_HoraSalida
            // 
            this.lbl_HoraSalida.AutoSize = true;
            this.lbl_HoraSalida.Location = new System.Drawing.Point(341, 156);
            this.lbl_HoraSalida.Name = "lbl_HoraSalida";
            this.lbl_HoraSalida.Size = new System.Drawing.Size(96, 15);
            this.lbl_HoraSalida.TabIndex = 22;
            this.lbl_HoraSalida.Text = "Horario de salida";
            // 
            // frm_AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 387);
            this.Controls.Add(this.lbl_HoraSalida);
            this.Controls.Add(this.cmb_Salida);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.dtp_Salida);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.cmb_Avion);
            this.Controls.Add(this.lbl_Asientos);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.lbl_Salida);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_Avion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_AgregarVuelo";
            this.Text = "frm_AgregarVuelo";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frm_AgregarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Avion;
        private Label lbl_destino;
        private Label lbl_Salida;
        private Label lbl_Origen;
        private Label lbl_Codigo;
        private Label lbl_Asientos;
        private ComboBox cmb_Avion;
        private ComboBox cmb_Destino;
        private TextBox txt_Codigo;
        private Button btn_Salir;
        private Button btn_Agregar;
        private Label lbl_error;
        private DateTimePicker dtp_Salida;
        private ComboBox cmb_Origen;
        private ComboBox cmb_Salida;
        private Label lbl_HoraSalida;
    }
}