using Biblioteca;
using Parcial1_Labo_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        static Vuelo? vuelo;
        static DateTime llegada;
        private void frm_AgregarVuelo_Load(object sender, EventArgs e)
        {
            //cambiar por filtro de fecha
            dtp_Salida.MinDate = DateTime.Now.AddDays(1);
            DateTime salida = new DateTime();
            foreach (Avion avion in Aerolinea.aviones) { 
                if(avion.Estado)
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
                cmb_Salida.Items.Add(salida.ToString("HH:mm"));
                salida=salida.AddHours(0.5);
            }
            ModoOscuro();

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
                float horaElegida = float.Parse(DateTime.Parse(cmb_Salida.Text).ToString("HH,mm "));
                if (cmb_Salida.SelectedIndex % 2 == 1)
                {
                    horaElegida += 0.2f;
                }
                salida = DateTime.Parse(dtp_Salida.Text);
                salida = salida.AddHours(horaElegida);
                if (duracion + horaElegida >= 24)
                {
                    llegada = salida.AddDays(1);
                }
                llegada = salida.AddHours(duracion);
                float costo = Vuelo.CalcularCosto(Enum.Parse<Destino>(cmb_Destino.Text), duracion);
                vuelo=  new Vuelo (Aerolinea.aviones[i], duracion,costo, Enum.Parse<Destino>(cmb_Destino.Text), Estado.Disponible
                                    ,cmb_Origen.Text, salida, new List<Pasajero>(), txt_Codigo.Text, llegada, 
                                    Aerolinea.aviones[i].Bodega, 0, 0, 0);
                Aerolinea.vuelos.Add(vuelo);
                Aerolinea.vuelos[i].Avion.HorasVuelo += duracion;
                Aerolinea.vuelos[i].Avion.Estado = false;
            }
            else
            {
                throw new Exception("Algun campo esta vacio owo");
            }
        }

        private void dtp_Salida_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Origen_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_Destino.Items.Clear();
            int x = 16;
            if (cmb_Origen.Text == "Buenos_Aires")
            {
                x = 20;
            }else
            {
                cmb_Destino.Text = "";
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

        
        private void cmb_Salida_SelectedValueChanged(object sender, EventArgs e)
        {
        }



        private void ModoOscuro()
        {
            if (!Aerolinea.modoOscuro)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                pic_Agregar.Image = Resources.agregar_blanco_84x24;
                pic_Salir.Image = Resources.salir_blanco_84x24;
                lbl_Asientos.ForeColor = Color.White;
                lbl_Avion.ForeColor = Color.White;
                lbl_Codigo.ForeColor = Color.White;
                lbl_destino.ForeColor = Color.White;
                lbl_error.ForeColor = Color.White;
                lbl_HoraSalida.ForeColor = Color.White;
                lbl_Origen.ForeColor = Color.White;
                lbl_Salida.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                pic_Agregar.Image = Resources.agregar_negro_84x24;
                pic_Salir.Image = Resources.salir_negro_84x24;

                lbl_Asientos.ForeColor = Color.Black;
                lbl_Avion.ForeColor = Color.Black;
                lbl_Codigo.ForeColor = Color.Black;
                lbl_destino.ForeColor = Color.Black;
                lbl_error.ForeColor = Color.Black;
                lbl_HoraSalida.ForeColor = Color.Black;
                lbl_Origen.ForeColor = Color.Black;
                lbl_Salida.ForeColor = Color.Black;
            }
        }

        private void cmb_Avion_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = Aerolinea.ConseguirIndex(cmb_Avion.Text);
            lbl_Asientos.Text = "Cantidad de asientos: " + Aerolinea.aviones[i].CantidadAsientos.ToString();
        }
    }
}
