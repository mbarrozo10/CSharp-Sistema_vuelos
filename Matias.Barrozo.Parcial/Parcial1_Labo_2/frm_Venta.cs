using Biblioteca;
using Parcial1_Labo_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Labo_2
{
    public partial class frm_Venta : Form
    {
        public frm_Venta()
        {
            InitializeComponent();
        }
        static double precioPremium=0.2f;
        int index;

        int i=0;
        public frm_Venta( int index) : this()
        {
            this.index = index;
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            lbl_Codigo.Text += Aerolinea.vuelos[index].Codigo;
            lbl_Destino.Text += Aerolinea.vuelos[index].Destino.ToString();
            lbl_Duracion.Text += Aerolinea.vuelos[index].Duracion;
            lbl_Origen.Text+= Aerolinea.vuelos[index].Origen.ToString();
            lbl_PrecioSub.Text += Aerolinea.vuelos[index].CostoDePasaje;
            lbl_PrecioFinal.Text += Aerolinea.vuelos[index].CostoDePasaje;
            precioPremium= Aerolinea.vuelos[index].CostoDePasaje * 1.15;
            modoOscuroClaro();
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
        }

        private bool CheckNumeros(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }

            return false;
        }

        private bool CheckLetras(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                return true;
            }

            return false;
        }
        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckLetras(e);
        }

        private void chk_Premium_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Premium.Checked)
            {
                nud_CantEquipaje.Maximum = 2;
               
                lbl_PrecioFinal.Text = "Precio Final: " + precioPremium.ToString("N4");
            }
            else
            {
                lbl_PrecioFinal.Text = "Precio Final: " + Aerolinea.vuelos[index].CostoDePasaje;
                nud_CantEquipaje.Maximum = 1;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool salir = false;
            //    for(int i = 0; i < nud_Cantidad.Value; i++)
            //   {
            nud_Cantidad.Enabled = false;
        if(txt_Apellido.Text!=String.Empty&& txt_Nombre.Text!= String.Empty && txt_Dni.Text!=String.Empty&& txt_Edad.Text!=String.Empty)
        {
                Aerolinea.vuelos[index].Pasajeros.Add(new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text),int.Parse(txt_Edad.Text), (int)(nud_CantEquipaje.Value),chk_Premium.Checked));
                txt_Apellido.Text = "";
                txt_Nombre.Text = "";
                txt_Dni.Text = "";
                txt_Edad.Text = "";
                nud_CantEquipaje.Value = 0;
                txt_Kg.Text = "";
                //vueloActual.AsientosLibres -= (int)nud_Cantidad.Value-1; +
                Aerolinea.vuelos[index].AsientosLibres -= 1;
                i++;
                prg_CantidadRestante.Value = i;

                if (chk_Premium.Checked)
                {
                    Aerolinea.vuelos[index].Recaudacion += (float) precioPremium;
                }
                else
                {
                    Aerolinea.vuelos[index].Recaudacion += (float)Aerolinea.vuelos[index].CostoDePasaje;
                }
                chk_Premium.CheckState = CheckState.Unchecked;
        }   
        else
        {
            lbl_Error.Text = "Falta algun dato";
        }
            
        if (i == nud_Cantidad.Value  )
        { 
            salir = true;
        }
        if (salir)
        {
        DialogResult = DialogResult.OK;
        }

        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Cantidad.Value != 0)
            {
                txt_Apellido.Enabled = true;
                txt_Nombre.Enabled = true;
                txt_Dni.Enabled = true;
                txt_Edad.Enabled = true;
                nud_CantEquipaje.Enabled = true;
               
                chk_Premium.Enabled = true;
                prg_CantidadRestante.Maximum = (int)nud_Cantidad.Value;
                pic_Agregar.Enabled = true;
            }
            else
            {
                nud_Cantidad.Minimum = 1;
                prg_CantidadRestante.Value=(int)nud_Cantidad.Value;
            }
        }

        private void txt_Kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
        }

        private void nud_CantEquipaje_ValueChanged(object sender, EventArgs e)
        {
            if (nud_CantEquipaje.Value != 0)
            {
                txt_Kg.Enabled = true;
            }
            else
            {
                txt_Kg.Enabled = false;
            }
        }

        private void modoOscuroClaro()
        {
            if (!Aerolinea.modoOscuro)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                lbl_Codigo.ForeColor = Color.White;
                lbl_Origen.ForeColor = Color.White;
                lbl_Duracion.ForeColor = Color.White;
                lbl_Cantidad.ForeColor = Color.White;
                lbl_Nombre.ForeColor = Color.White;
                lbl_Apellido.ForeColor = Color.White;
                lbl_Dni.ForeColor = Color.White;
                lbl_Edad.ForeColor = Color.White;
                lbl_Equipaje.ForeColor = Color.White;
                lbl_Kg.ForeColor = Color.White;
                lbl_PrecioSub.ForeColor = Color.White;
                lbl_PrecioFinal.ForeColor = Color.White;
                chk_Premium.ForeColor= Color.White;
                txt_Apellido.BackColor = Color.FromArgb(34, 34, 34);
                txt_Nombre.BackColor = Color.FromArgb(34, 34, 34);
                txt_Dni.BackColor = Color.FromArgb(34, 34, 34);
                txt_Edad.BackColor = Color.FromArgb(34, 34, 34);
                nud_CantEquipaje.BackColor = Color.FromArgb(34, 34, 34);
                txt_Kg.BackColor = Color.FromArgb(34, 34, 34);
                txt_Apellido.ForeColor = Color.White;
                txt_Nombre.ForeColor = Color.White;
                txt_Dni.ForeColor = Color.White;
                txt_Edad.ForeColor = Color.White;
                nud_CantEquipaje.ForeColor = Color.White;
                txt_Kg.ForeColor = Color.White;
                pic_Agregar.Image= Resources.agregar_blanco_84x24;
                pic_Cancelar.Image = Resources.cancelar_blanco_84x24;

            }
            else
            {
                this.BackColor = Color.White;
                lbl_Codigo.ForeColor = Color.Black;
                lbl_Origen.ForeColor = Color.Black;
                lbl_Duracion.ForeColor = Color.Black;
                lbl_Cantidad.ForeColor = Color.Black;
                lbl_Nombre.ForeColor = Color.Black;
                lbl_Apellido.ForeColor = Color.Black;
                lbl_Dni.ForeColor = Color.Black;
                lbl_Edad.ForeColor = Color.Black;
                lbl_Equipaje.ForeColor = Color.Black;
                lbl_Kg.ForeColor = Color.Black;
                lbl_PrecioSub.ForeColor = Color.Black;
                lbl_PrecioFinal.ForeColor = Color.Black;
                chk_Premium.ForeColor = Color.Black;
                txt_Apellido.BackColor = Color.White;
                txt_Nombre.BackColor = Color.White;
                txt_Dni.BackColor = Color.White;
                txt_Edad.BackColor = Color.White;
                nud_CantEquipaje.BackColor = Color.White;
                txt_Kg.BackColor = Color.White;
                txt_Apellido.ForeColor = Color.Black;
                txt_Nombre.ForeColor = Color.Black;
                txt_Dni.ForeColor = Color.Black;
                txt_Edad.ForeColor = Color.Black;
                nud_CantEquipaje.ForeColor = Color.Black;
                txt_Kg.ForeColor = Color.Black;
                pic_Agregar.Image = Resources.agregar_negro_84x24;
                pic_Cancelar.Image = Resources.cancelar_negro_84x24;
            }
        }
    }
}
