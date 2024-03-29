﻿using Biblioteca;
using Parcial1_Labo_2.Properties;

namespace Parcial1_Labo_2
{
    public partial class frm_AgregarVuelo : Form
    {
        public frm_AgregarVuelo()
        {
            InitializeComponent();
        }
        static Vuelo? vuelo;
        private void frm_AgregarVuelo_Load(object sender, EventArgs e)
        {
            dtp_Salida.MinDate = DateTime.Now.AddDays(1);
            DateTime salida = new DateTime();
            
            //cargo los Destinos
            for (int i = 0; i < 20; i++) {
                string? s =Enum.GetName(typeof(EDestino),i);
                cmb_Destino.Items.Add(s);
            }
            //cargo los origenes
            for (int i = 0; i < 20; i++)
            {
                string? s = Enum.GetName(typeof(EDestino), i);
                cmb_Origen.Items.Add(s);
            }
            //cargo los horarios
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
                int indiceAvion = Avion.ConseguirIndex(cmb_Avion.Text);
                DateTime salida = new DateTime();
                float horaElegida = float.Parse(DateTime.Parse(cmb_Salida.Text).ToString("HH,mm "));
                if (cmb_Salida.SelectedIndex % 2 == 1)
                {
                    horaElegida += 0.2f;
                }
                salida = DateTime.Parse(dtp_Salida.Text);
                salida = salida.AddHours(horaElegida);
                vuelo=  new Vuelo (Aerolinea.aviones[indiceAvion], Enum.Parse<EDestino>(cmb_Destino.Text), EEstado.Disponible
                                    ,Enum.Parse<EDestino>(cmb_Origen.Text), salida, new Dictionary<int,Pasajero>(), txt_Codigo.Text, horaElegida,
                                    Aerolinea.aviones[indiceAvion].Bodega, 0, 0, 0);
                Aerolinea.vuelos.Add(vuelo); 
            }
            else
            {
                throw new Exception("Algun campo esta vacio");
            }
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
                string? s = Enum.GetName(typeof(EDestino), i);
                if (cmb_Origen.Text != s)
                {
                    cmb_Destino.Items.Add(s);
                } 
            }
        }

        private void cmb_Avion_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = Avion.ConseguirIndex(cmb_Avion.Text);
            lbl_Asientos.Text = "Cantidad de asientos: " + Aerolinea.aviones[i].CantidadAsientos.ToString();
        }

        private void dtp_Salida_ValueChanged(object sender, EventArgs e)
        {
            cmb_Avion.Items.Clear();
            
            foreach (Avion avion in Aerolinea.aviones)
            {
                foreach (Vuelo vuelo in Aerolinea.vuelos)
                {   
                    if (avion.Equals(vuelo.Avion) && dtp_Salida.Value.ToString("dd/MM/yyyy") == vuelo.Salida.ToString("dd/MM/yyyy"))
                    { 
                        cmb_Avion.Items.Remove(avion.Matricula);
                        break;
                    }
                    else
                    {
                        if (!cmb_Avion.Items.Contains(avion.Matricula))
                        cmb_Avion.Items.Add(avion.Matricula);
                    }
                }
            }

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
                cmb_Avion.ForeColor = Color.White;
                cmb_Avion.BackColor = Color.FromArgb(34, 34, 34);
                txt_Codigo.BackColor = Color.FromArgb(34, 34, 34);
                txt_Codigo.ForeColor = Color.White;
                cmb_Destino.ForeColor = Color.White;
                cmb_Destino.BackColor = Color.FromArgb(34, 34, 34);
                cmb_Origen.BackColor = Color.FromArgb(34, 34, 34);
                cmb_Origen.ForeColor = Color.White;
                cmb_Salida.ForeColor = Color.White;
                cmb_Salida.BackColor = Color.FromArgb(34, 34, 34);
                dtp_Salida.CalendarForeColor = Color.White;
                dtp_Salida.CalendarMonthBackground = Color.FromArgb(34, 34, 34);
                dtp_Salida.CalendarTitleBackColor = Color.FromArgb(34, 34, 34);
                dtp_Salida.CalendarTitleForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                pic_Agregar.Image = Resources.agregar_negro_84x24;
                pic_Salir.Image = Resources.salir_negro_84x24;
                lbl_Asientos.ForeColor = Color.FromArgb(64,64,64);
                lbl_Avion.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_Codigo.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_destino.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_error.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_HoraSalida.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_Origen.ForeColor = Color.FromArgb(64, 64, 64);
                lbl_Salida.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Avion.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Avion.BackColor = Color.White;
                txt_Codigo.BackColor = Color.White;
                txt_Codigo.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Destino.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Destino.BackColor = Color.White;
                cmb_Origen.BackColor = Color.White;
                cmb_Origen.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Salida.ForeColor = Color.FromArgb(64, 64, 64);
                cmb_Salida.BackColor = Color.White;
                dtp_Salida.CalendarForeColor = Color.FromArgb(64, 64, 64);
                dtp_Salida.CalendarMonthBackground = Color.White;
                dtp_Salida.CalendarTitleBackColor = Color.White;
                dtp_Salida.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            }
        }
    }
}
