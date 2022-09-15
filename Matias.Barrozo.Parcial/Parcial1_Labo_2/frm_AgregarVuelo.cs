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
        static Vuelo vuelo;
        static DateTime llegada;
        private void frm_AgregarVuelo_Load(object sender, EventArgs e)
        {
            //cambiar por filtro de fecha
            dtp_Salida.MinDate = DateTime.Now;
            DateTime salida = new DateTime();
            foreach (Avion avion in Aerolinea.aviones) { 
                cmb_Avion.Items.Add(avion.Matricula);
           }

            for (int i = 0; i < 20; i++) {
                string? s =Enum.GetName(typeof(Destino),i);
                cmb_Destino.Items.Add(s);
            }
            for (int i = 0; i < 20; i++)
            {
                string? s = Enum.GetName(typeof(Destino), i);
                cmb_Origen.Items.Add(s);
            }
            for(int i = 0; i < 48; i++)
            {
                cmb_Salida.Items.Add(salida.ToString("hh:mm tt"));
                salida=salida.AddHours(0.5);
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
            if(cmb_Avion.Text != String.Empty && cmb_Destino.Text != String.Empty && txt_Codigo.Text != String.Empty && cmb_Origen.Text != String.Empty
                && dtp_Salida.Text!=String.Empty && cmb_Salida.Text!= String.Empty)
            {
                int duracion = Vuelo.CalcularDuracion(Enum.Parse<Destino>(cmb_Destino.Text));
                int i = Aerolinea.ConseguirIndex(cmb_Avion.Text);
                DateTime salida = new DateTime();
                int horaElegida = int.Parse(DateTime.Parse(cmb_Salida.Text).ToString("hh"));
                salida = DateTime.Parse(dtp_Salida.Text);
                salida = salida.AddHours(horaElegida);
                llegada = salida.AddHours(duracion);
                List<Pasajero> pasajeros= new List<Pasajero>();
                float costo = Vuelo.CalcularCosto(Enum.Parse<Destino>(cmb_Destino.Text), duracion);
                vuelo=  new Vuelo (Aerolinea.aviones[i], duracion,costo, Enum.Parse<Destino>(cmb_Destino.Text), Estado.Disponible,cmb_Origen.Text, salida,pasajeros,txt_Codigo.Text,llegada);
                Aerolinea.vuelos.Add(vuelo);
            }
            else
            {
                throw new Exception("Algun campo esta vacio owo");
            }
        }

        private void dtp_Salida_ValueChanged(object sender, EventArgs e)
        {
            
            ActualizaSalida();
        }

        private void cmb_Origen_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_Destino.Items.Clear();
            int x = 16;
            if (cmb_Origen.Text == "Buenos_Aires")
            {
                x = 20;
            }
            for (int i = 0; i < x; i++)
            {
                string? s = Enum.GetName(typeof(Destino), i);
                if (cmb_Origen.Text != s)
                {
                    cmb_Destino.Items.Add(s);
                } 
            }
        }

        private void ActualizaSalida()
        {
            if (cmb_Salida.Text != String.Empty && dtp_Salida.Text!= String.Empty)
            {
                
               
             //   lbl_Llegada.Text = "Horario de Llegada: " + salida.ToString("dd/mm/yyyy hh:mm tt");
            }
        }

        private void cmb_Salida_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizaSalida();
        }
    }
}
