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
            cmb_FiltroHistorico.Items.Add("Destinos");
            cmb_FiltroHistorico.Items.Add("Pasajeros Frecuentes");
            cmb_FiltroHistorico.Items.Add("Ganancias totales");
            cmb_FiltroHistorico.Items.Add("Vuelos finalizados");
            cmb_FiltroHistorico.Items.Add("Aviones");
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                lbl_Fecha.ForeColor= Color.White;
                pic_SalirHistorico.Image = Resources.salir_blanco_84x24;
                pic_Cancelar.Image = Resources.cancelar_blanco_84x24;
                rtx_InfoVuelo.ForeColor= Color.White;
                rtx_InfoVuelo.BackColor = Color.FromArgb(34, 34, 34);
                pic_SalirHistorico.Image= Resources.salir_blanco_84x24;

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
                lbl_Fecha.ForeColor = Color.Black;  
                pic_SalirHistorico.Image = Resources.salir_negro_84x24;
                pic_Cancelar.Image = Resources.cancelar_negro_84x24;
                rtx_InfoVuelo.ForeColor = Color.Black;
                rtx_InfoVuelo.BackColor = Color.White;
                pic_SalirHistorico.Image= Resources.salir_negro_84x24;

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

            rtx_InfoVuelo.Text = Aerolinea.vuelos[Index].ToString();
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
            dgv_VuelosActivos.Enabled = true;
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
            dgv_VuelosActivos.Enabled = true;
            CargarDatagrid();
            Index = 0;

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
            cmb_FiltroHistorico.Text = String.Empty;
            dgv_Historico.DataSource = null;
            pic_Salir.Visible = true;
            btn_MasInfo.Visible = true;
            btn_Historico.Visible = true;
            pic_Modo.Visible = true;
            pic_Agregar.Visible = true;
            btn_AgregarCliente.Visible = true;
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
            pic_Agregar.Visible = false;
            pic_Vender.Visible = false;
            pic_Salir.Visible = false;
            btn_MasInfo.Visible = false;
            btn_Historico.Visible = false;
            pic_Modo.Visible = false;
            lbl_RecaudacionTotal.Text ="Recaudacion total: " +  Aerolinea.CalcularRecaudacionTotal().ToString();
            btn_AgregarCliente.Visible = false;
            pic_Pasajeros.Visible = false;

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
                    dgv_Historico.Columns.Add("TotalRecaudado", "TotalRecaudado");
                    int count = Enum.GetValues(typeof(Destino)).Length;
                    for (int i=0; i< count ;i++){
                        int contador=0;
                        float recaudacion=0;
                        for(int j = 0; j < Aerolinea.vuelos.Count; j++)
                        {
                            string? s = Enum.GetName(typeof(Destino),i);
                            if (Aerolinea.vuelos[j].Destino.ToString().Contains(s))
                            {
                                contador++;
                                recaudacion += Aerolinea.vuelos[j].Recaudacion;
                            }
                        }
                        DataGridViewRow filas = new DataGridViewRow();

                        filas.CreateCells(dgv_Historico);

                        filas.Cells[0].Value = Enum.GetName(typeof(Destino), i);
                        filas.Cells[1].Value = contador;
                        filas.Cells[2].Value = recaudacion;

                        dgv_Historico.Rows.Add(filas);

                    }
                    break;
                case "Pasajeros Frecuentes":
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = null;
                    dgv_Historico.DataSource = Aerolinea.clientes;
                    break;
                case "Ganancias totales":
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = null;
                    dgv_Historico.Columns.Add("Codigo", "Codigo de vuelo");
                    dgv_Historico.Columns.Add("Destino", "Destino");
                    dgv_Historico.Columns.Add("Ganancia", "Ganancia del vuelo");
                    dgv_Historico.Columns.Add("TipoServicio", "Tipo de servicio");
                    Recorrervuelos(Aerolinea.vuelos);
                    Recorrervuelos(Aerolinea.vuelosFinalizados);                 
                    break;
                case "Vuelos finalizados":
                    dgv_Historico.DataSource = null;
                    dgv_Historico.Columns.Clear();
                    dgv_Historico.DataSource = Aerolinea.vuelosFinalizados;
                    break;
                case "Aviones":
                    dgv_Historico.DataSource = null;
                    dgv_Historico.DataSource = Aerolinea.aviones;
                    break;
                default:
                    dgv_Historico.DataSource = null;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            frm_AgregarCliente frm = new frm_AgregarCliente();
            frm.ShowDialog();
        }


        private void Recorrervuelos(List<Vuelo> vuelos)
        {
            for (int i = 0; i < vuelos.Count; i++)
            {

                DataGridViewRow filas = new DataGridViewRow();

                filas.CreateCells(dgv_Historico);

                filas.Cells[0].Value = vuelos[i].Codigo;
                filas.Cells[1].Value = vuelos[i].Destino;
                filas.Cells[2].Value = vuelos[i].Recaudacion;


                if (vuelos[i].Destino.ToString() == "Recife" || vuelos[i].Destino.ToString() == "Roma"
                    || vuelos[i].Destino.ToString() == "Acapulco" || vuelos[i].Destino.ToString() == "Miami")
                {
                    filas.Cells[3].Value = "Internacional";
                }
                else
                {
                    filas.Cells[3].Value = "Cabotaje";
                }

                dgv_Historico.Rows.Add(filas);

            }

        }
    }
}
