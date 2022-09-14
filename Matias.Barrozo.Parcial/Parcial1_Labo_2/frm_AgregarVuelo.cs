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
    public partial class frm_AgregarVuelo : Form
    {
        public frm_AgregarVuelo()
        {
            InitializeComponent();
        }

        private void frm_AgregarVuelo_Load(object sender, EventArgs e)
        {
            //cambiar por filtro de fecha
            foreach(Avion avion in Aerolina.aviones) { 
                cmb_Avion.Items.Add(avion.Matricula);
           }

            for (int i = 0; i < 18; i++) {
                string s =Enum.GetName(typeof(Destino),i);
                cmb_Destino.Items.Add(s);
            }
               
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarVuelo();
                DialogResult = DialogResult.OK;
            }
            catch(Exception excep)
            {
                lbl_error.Text=excep.Message;
            }
        }

        private void AgregarVuelo()
        {
            if(cmb_Avion.Text != String.Empty && cmb_Destino.Text != String.Empty && txt_Codigo.Text != String.Empty && txt_Origen.Text != String.Empty)
            {
                int i = Aerolina.ConseguirIndex(cmb_Avion.Text);
                int duracion = Vuelo.CalcularDuracion(Enum.Parse<Destino>(cmb_Destino.Text));
                List<Pasajero> pasajeros= new List<Pasajero>();
                float costo = Vuelo.CalcularCosto(Enum.Parse<Destino>(cmb_Destino.Text), duracion);
                Vuelo vuelo=  new Vuelo (Aerolina.aviones[i], duracion,costo, Enum.Parse<Destino>(cmb_Destino.Text), Estado.Disponible,txt_Origen.Text, cdr_Salida.SelectionStart,pasajeros,txt_Codigo.Text);
                Aerolina.vuelos.Add(vuelo);
              

            }
            else
            {
                throw new Exception("Algun campo esta vacio owo");
            }
        }
    }
}
