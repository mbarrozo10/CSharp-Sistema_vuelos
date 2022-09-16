using Biblioteca;
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
    }
}
