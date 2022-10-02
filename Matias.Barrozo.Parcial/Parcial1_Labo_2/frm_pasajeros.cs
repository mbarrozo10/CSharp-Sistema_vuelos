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
    public partial class frm_pasajeros : Form
    {
        private static int Index;
        public frm_pasajeros()
        {
            InitializeComponent();

        }
        public frm_pasajeros(int index): this()
        {
                Index = index;
        }

          private void frm_pasajeros_Load(object sender, EventArgs e)
        {
            ModoOscuro();
            dgv_Pasajeros.DataSource = null;
            dgv_Pasajeros.DataSource = Aerolinea.vuelos[Index].Pasajeros.Values.ToList();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private  void ModoOscuro()
        {
            if (!Aerolinea.modoOscuro)
            {
                dgv_Pasajeros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_Pasajeros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_Pasajeros.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_Pasajeros.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_Pasajeros.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_Pasajeros.RowsDefaultCellStyle.ForeColor = Color.White;
                pic_Salir.Image = Resources.salir_blanco_84x24;
                this.BackColor = Color.FromArgb(34, 34, 34);
                lbl_Error.ForeColor = Color.White;
                txt_BuscadorPasajero.BackColor = Color.FromArgb(34, 34, 34);
                txt_BuscadorPasajero.ForeColor = Color.White;
                lbl_Buscador.ForeColor= Color.White;
            }
            else
            {
                dgv_Pasajeros.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv_Pasajeros.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_Pasajeros.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgv_Pasajeros.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_Pasajeros.RowsDefaultCellStyle.BackColor = Color.White;
                dgv_Pasajeros.RowsDefaultCellStyle.ForeColor = Color.Black;
                this.BackColor = Color.White;
                pic_Salir.Image = Resources.salir_negro_84x24;
                lbl_Error.ForeColor = Color.Black;
                txt_BuscadorPasajero.BackColor = Color.White;
                txt_BuscadorPasajero.ForeColor = Color.Black;
                lbl_Buscador.ForeColor = Color.Black;
            }
        }

        private void txt_BuscadorPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool Encontro = false;
            List<Pasajero> filtrada = new List<Pasajero>();
            foreach (KeyValuePair<int,Pasajero> pasajero in Aerolinea.vuelos[Index].Pasajeros) { 

                if (pasajero.Value.Nombre.ToLower().Contains(txt_BuscadorPasajero.Text.ToLower()) ||
                     pasajero.Value.Apellido.ToLower().Contains(txt_BuscadorPasajero.Text.ToLower()) ||
                     pasajero.Value.GetHashCode().ToString().Contains(txt_BuscadorPasajero.Text))
                {
                    filtrada.Add(pasajero.Value);
                    Encontro = true;
                }
            }
 
            if (Encontro)
            {
                dgv_Pasajeros.DataSource = null;
                dgv_Pasajeros.DataSource = filtrada;
                lbl_Error.Text = String.Empty;
            }
            else
            {
                lbl_Error.Text = "No se encontro ningun pasajero";
            }
        }

        private void txt_BuscadorPasajero_TextChanged(object sender, EventArgs e)
        {
            if(txt_BuscadorPasajero.Text == String.Empty)
            {
                dgv_Pasajeros.DataSource = null;
                dgv_Pasajeros.DataSource = Aerolinea.vuelos[Index].Pasajeros.ToArray();
            }
        }
    }
}
