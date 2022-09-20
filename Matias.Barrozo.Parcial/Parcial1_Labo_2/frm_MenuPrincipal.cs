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
    public partial class frm_MenuPrincipal : Form
    {

        private static int Index;
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        public frm_MenuPrincipal(Vendedor vendedor) : this()
        {
            lbl_Bienvenido.Text = "Bienvenidx " + vendedor.ToString() ;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
            CargarDatagrid();
            modoOscuroClaro();
            // dataGridView1.DataSource = Inicializador.vuelos;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex;
            if (Aerolinea.vuelos[Index].Estado == Biblioteca.Estado.Disponible || Aerolinea.vuelos[Index].Pasajeros.Count < Aerolinea.vuelos[Index].Avion.CantidadAsientos)
            {
               pic_Vender.Visible = true;
               pic_Pasajeros.Visible = true;
            }
            else if (Aerolinea.vuelos[Index].Estado == Biblioteca.Estado.EnVuelo || Aerolinea.vuelos[Index].Estado == Biblioteca.Estado.Lleno)
            {
                pic_Pasajeros.Visible = true;
                pic_Vender.Visible = false;
            }
            else
            {
                pic_Vender.Visible = false;
                pic_Pasajeros.Visible = false;
            }

            btn_MasInfo.Enabled = true;

        }

        private void btn_Pasajeros_Click(object sender, EventArgs e)
        {
            frm_pasajeros pj = new frm_pasajeros(Index);
            pj.ShowDialog();
        }

        private void CargarDatagrid()
        {
            dgv_VuelosActivos.DataSource = null;
            dgv_VuelosActivos.Rows.Clear();
            for (int i = 0; i < Aerolinea.vuelos.Count; i++)
            {
                DataGridViewRow filas = new DataGridViewRow();
               
                filas.CreateCells(dgv_VuelosActivos);
                //DateTime ahora = DateTime.Now;
                //DateTime test = new DateTime(2022,9,13, 22,0,0);
                //int x = ahora.Hour-3;

                filas.Cells[0].Value = Aerolinea.vuelos[i].Avion.Matricula;
                filas.Cells[1].Value = Aerolinea.vuelos[i].Duracion;
                //  filas.Cells[2].Value = Vuelo.CalcularCosto(Aerolinea.vuelos[i].Destino, Aerolinea.vuelos[i].Duracion);
                filas.Cells[2].Value = Aerolinea.vuelos[i].Origen;
                filas.Cells[3].Value = Aerolinea.vuelos[i].Destino;
                filas.Cells[4].Value = Aerolinea.vuelos[i].Salida;
                filas.Cells[5].Value = Aerolinea.vuelos[i].Llegada; //new DateTime(ahora.Year,ahora.Month,ahora.Day,x,ahora.Minute,ahora.Second);
                filas.Cells[6].Value = Aerolinea.vuelos[i].Estado;
                filas.Cells[7].Value = Aerolinea.vuelos[i].Avion.CantidadAsientos - Aerolinea.vuelos[i].Pasajeros.Count;
                filas.Cells[8].Value = Aerolinea.vuelos[i].Avion.Wifi;
                filas.Cells[9].Value = Aerolinea.vuelos[i].Avion.Comida;
               
                dgv_VuelosActivos.Rows.Add(filas);

            }
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo vuelo = new frm_AgregarVuelo();
            //   vuelo.ShowDialog(); 
            if (vuelo.ShowDialog() == DialogResult.OK)
            {
                CargarDatagrid();
            }
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            frm_Venta venta = new frm_Venta(Index);
            if (venta.ShowDialog() == DialogResult.OK)
            {
                if (Aerolinea.vuelos[Index].Pasajeros.Count == Aerolinea.vuelos[Index].Avion.CantidadAsientos)
                {
                    Aerolinea.vuelos[Index].Estado = Biblioteca.Estado.Lleno;
                }
                CargarDatagrid();
            }
        }

        

        //botones de 84x24
        private void modoOscuroClaro()
        {
            if (Aerolinea.modoOscuro)
            {
                pic_Modo.Image = Resources.dia;
                this.BackColor = Color.FromArgb(34, 34, 34);
                Aerolinea.modoOscuro = false;
                pic_Pasajeros.Image = Resources.pasajeros_blanco_84x24;
                pic_Salir.Image = Resources.salir_blanco_84x24;
                pic_Agregar.Image = Resources.agregar_blanco;
                pic_Vender.Image= Resources.vender_blanco_84x24;    
                lbl_Bienvenido.ForeColor= Color.White;
                dgv_VuelosActivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_VuelosActivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_VuelosActivos.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_VuelosActivos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_VuelosActivos.RowsDefaultCellStyle.BackColor= Color.FromArgb(34, 34, 34);
                dgv_VuelosActivos.RowsDefaultCellStyle.ForeColor = Color.White;

            }
            else
            {
                dgv_VuelosActivos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv_VuelosActivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_VuelosActivos.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgv_VuelosActivos.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                pic_Modo.Image = Resources.night_mode1;
                this.BackColor = Color.White;
                Aerolinea.modoOscuro = true;
                lbl_Bienvenido.ForeColor = Color.Black;
                pic_Pasajeros.Image = Resources.pasajeros_negro_84x24;
                pic_Salir.Image = Resources.salir_negro_84x24;
                pic_Agregar.Image = Resources.agregar_negro;
                pic_Vender.Image = Resources.vender_negro_84x24;
                dgv_VuelosActivos.RowsDefaultCellStyle.BackColor = Color.White;
                dgv_VuelosActivos.RowsDefaultCellStyle.ForeColor = Color.Black;

            }
        }

        private void pic_Modo_Click(object sender, EventArgs e)
        {
            modoOscuroClaro();
        }

        private void btn_MasInfo_Click(object sender, EventArgs e)
        {
            pnl_Informacion.Visible = true;
            pnl_Informacion.Enabled = true;
           // this.SendToBack();
            pic_Agregar.Enabled = false;
            pic_Vender.Enabled = false;
            pic_Salir.Enabled = false;
            btn_MasInfo.Enabled = false;
            btn_Historico.Enabled = false;
            pic_Modo.Enabled = false;

            dgv_VuelosActivos.Enabled = false;
            lbl_Avion.Text = "Avion: " + Aerolinea.vuelos[Index].Avion.Matricula;
            lbl_Duracion.Text = "Duracion: " + Aerolinea.vuelos[Index].Duracion;
            lbl_CostoTurista.Text = "Precio turisa: " + Aerolinea.vuelos[Index].CostoDePasaje;
            lbl_CostoPremium.Text = "Precio premium: " + Aerolinea.vuelos[Index].CostoDePasaje* 1.15f;
            lbl_Recaudacion.Text = "Recaudacion: " + Aerolinea.vuelos[Index].Recaudacion;
            lbl_Origen.Text = "Origen: " + Aerolinea.vuelos[Index].Origen;
            lbl_Salida.Text = "Salida: " + Aerolinea.vuelos[Index].Salida;
            lbl_Llegada.Text = "Llegada: " + Aerolinea.vuelos[Index].Llegada;
            lbl_Destino.Text = "Destino: " + Aerolinea.vuelos[Index].Destino;
            lbl_BodegaLibre.Text = "Espacio de bodega libre: " + Aerolinea.vuelos[Index].BodegaRestante;
            lbl_AsientosPremium.Text = "Asientos libres Premium: " + Aerolinea.vuelos[Index].AsientosLibresPremium;
            lbl_AsientosTurista.Text = "Asientos libres Turista: " + Aerolinea.vuelos[Index].AsientosLibresTurista;
            lbl_Codigo.Text = "Codigo de Vuelo: " + Aerolinea.vuelos[Index].Codigo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            pnl_Informacion.Visible = false;
            pic_Agregar.Enabled = true;
            pic_Vender.Enabled = true;
            pic_Salir.Enabled = true;
            btn_MasInfo.Enabled = true;
            btn_Historico.Enabled = true;
            pic_Modo.Enabled = true;

        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            Aerolinea.vuelos[Index].Estado = Biblioteca.Estado.Cancelado;
            Vuelo vueloaux = Aerolinea.vuelos[Index];
            Aerolinea.vuelosFinalizados.Add(vueloaux);
            Aerolinea.vuelos.Remove(vueloaux);

            pnl_Informacion.Visible = false;
            pic_Agregar.Enabled = true;
            pic_Vender.Enabled = true;
            pic_Salir.Enabled = true;
            btn_MasInfo.Enabled = true;
            btn_Historico.Enabled = true;
            pic_Modo.Enabled = true;
            CargarDatagrid();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pnl_Historico.Hide();
            pic_Agregar.Enabled = true;
            pic_Vender.Enabled = true;
            pic_Salir.Enabled = true;
            btn_MasInfo.Enabled = true;
            btn_Historico.Enabled = true;
            pic_Modo.Enabled = true;
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            pnl_Historico.Show();
            pic_Agregar.Enabled = false;
            pic_Vender.Enabled = false;
            pic_Salir.Enabled = false;
            btn_MasInfo.Enabled = false;
            btn_Historico.Enabled = false;
            pic_Modo.Enabled = false;
            lbl_RecaudacionTotal.Text ="Recaudacion total: " +  Aerolinea.CalcularRecaudacionTotal().ToString();
            cmb_FiltroHistorico.Items.Add("Destinos");
            cmb_FiltroHistorico.Items.Add("Pasajeros Frecuentes");
            cmb_FiltroHistorico.Items.Add("Ganancias totales");
            cmb_FiltroHistorico.Items.Add("Vuelos finalizados");
            
            //  dgv_Historico.Columns.Add("test", "test");
           // dgv_Historico.Columns.Add("test2", "test2");
        }

        private void cmb_FiltroHistorico_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmb_FiltroHistorico.Text)
            {
                case "Destinos":
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = null;
                    dgv_Historico.Columns.Add("Destino", "Destino");
                    dgv_Historico.Columns.Add("CantidadViajes", "Cantidad de viajes");
                    break;
                case "Pasajeros Frecuentes":
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = null;
                    break;
                case "Ganancias totales":
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = null;
                    dgv_Historico.Columns.Add("Codigo", "Codigo de vuelo");
                    dgv_Historico.Columns.Add("Destino", "Destino");
                    dgv_Historico.Columns.Add("Ganancia", "Ganancia del vuelo");
                    dgv_Historico.Columns.Add("TipoServicio", "Tipo de servicio");
                    break;
                case "Vuelos finalizados":
                    dgv_Historico.DataSource = null;
                    dgv_Historico.DataSource = Aerolinea.vuelosFinalizados;
                    break;
                default:
                    dgv_Historico.DataSource = null;
                    break;
            }
        }
    }
}
