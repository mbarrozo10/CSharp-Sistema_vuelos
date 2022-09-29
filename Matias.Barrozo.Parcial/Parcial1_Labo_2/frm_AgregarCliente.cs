using Biblioteca;
using Parcial1_Labo_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Labo_2
{
    public partial class frm_AgregarCliente : Form
    {
        private Cliente? nuevo;
        public frm_AgregarCliente()
        {
            InitializeComponent();
           
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pic_Agregar_Click(object sender, EventArgs e)
        {
            Aerolinea.clientes.Add(nuevo);
            DialogResult = DialogResult.OK;
        }

        private void AgregarCliente(Cliente nuevo)
        {
            foreach (Cliente cliente in Aerolinea.clientes)
            {
                if (cliente.Equals(nuevo))
                {
                   throw new Exception( "Error, ya existe un usuario con ese dni");
                }
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = frm_Venta.CheckLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = frm_Venta.CheckLetras(e);
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = frm_Venta.CheckNumeros(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = frm_Venta.CheckNumeros(e);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == String.Empty || txt_Dni.Text == String.Empty || txt_Edad.Text == String.Empty || txt_Nombre.Text == String.Empty)
            {
                lbl_Error.Text = "Falta algun dato!!";
            }
            else
            {
                lbl_Info.Text = String.Empty;
                try
                {
                    nuevo = new Cliente(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text), int.Parse(txt_Edad.Text));
                    AgregarCliente(nuevo);
                    pic_Agregar.Visible = true;
                    lbl_Info.Text = nuevo.MostrarInformacion();
                    lbl_Error.Text = String.Empty;
                }
                catch (Exception exp)
                {
                    lbl_Error.Text = exp.Message;
                }
            }
        }

        private void frm_AgregarCliente_Load(object sender, EventArgs e)
        {
            ModoOscuro();
        }


        private void ModoOscuro()
        {
            if (!Aerolinea.modoOscuro)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                txt_Apellido.BackColor= Color.FromArgb(34, 34, 34);
                txt_Dni.BackColor= Color.FromArgb(34, 34, 34);
                txt_Nombre.BackColor= Color.FromArgb(34, 34, 34);
                txt_Edad.BackColor= Color.FromArgb(34, 34, 34);
                txt_Apellido.ForeColor = Color.White;
                txt_Nombre.ForeColor= Color.White;
                txt_Dni.ForeColor= Color.White;
                txt_Edad.ForeColor= Color.White;
                pic_Agregar.Image = Resources.agregar_blanco_84x24;
                pic_Cancelar.Image = Resources.cancelar_blanco_84x24;
                lbl_Apellido.ForeColor = Color.White;
                lbl_Dni.ForeColor = Color.White;
                lbl_Edad.ForeColor = Color.White;
                lbl_Error.ForeColor = Color.White;
                lbl_Info.ForeColor = Color.White;  
                lbl_Nombre.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                txt_Apellido.BackColor = Color.White;
                txt_Dni.BackColor = Color.White;
                txt_Nombre.BackColor = Color.White;
                txt_Edad.BackColor = Color.White;
                txt_Apellido.ForeColor = Color.Black;
                txt_Nombre.ForeColor = Color.Black;
                txt_Dni.ForeColor = Color.Black;
                txt_Edad.ForeColor = Color.Black;
                pic_Agregar.Image = Resources.agregar_negro_84x24;
                pic_Cancelar.Image = Resources.cancelar_negro_84x24;
                lbl_Dni.ForeColor = Color.Black;
                lbl_Edad.ForeColor = Color.Black;
                lbl_Error.ForeColor = Color.Black;
                lbl_Info.ForeColor = Color.Black;
                lbl_Nombre.ForeColor = Color.Black;
            }
        }
    }
}
