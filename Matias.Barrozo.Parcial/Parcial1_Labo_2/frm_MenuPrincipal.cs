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
            lbl_Bienvenido.Text = "Bienvenidx " + vendedor.Nombre + " " + vendedor.Apellido;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Aerolinea.aviones = Inicializador.InicializarAviones();
            Aerolinea.vuelos = Inicializador.InicializarVuelos();
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
            if (Aerolinea.vuelos[Index].Estado == Biblioteca.Estado.Disponible)
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

        }

        private void btn_Pasajeros_Click(object sender, EventArgs e)
        {
            frm_pasajeros pj = new frm_pasajeros(Index);
            pj.ShowDialog();
        }

        private void CargarDatagrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Aerolinea.vuelos.Count; i++)
            {
                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(dataGridView1);
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
                filas.Cells[7].Value = Aerolinea.vuelos[i].AsientosLibres;
                filas.Cells[8].Value = Aerolinea.vuelos[i].Avion.Wifi;
                filas.Cells[9].Value = Aerolinea.vuelos[i].Avion.Comida;

                dataGridView1.Rows.Add(filas);

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
                CargarDatagrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Aerolinea.vuelos[Index].Recaudacion.ToString();
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
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.RowsDefaultCellStyle.BackColor= Color.FromArgb(34, 34, 34);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.White;

            }
            else
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                pic_Modo.Image = Resources.night_mode1;
                this.BackColor = Color.White;
                Aerolinea.modoOscuro = true;
                lbl_Bienvenido.ForeColor = Color.Black;
                pic_Pasajeros.Image = Resources.pasajeros_negro_84x24;
                pic_Salir.Image = Resources.salir_negro_84x24;
                pic_Agregar.Image = Resources.agregar_negro;
                pic_Vender.Image = Resources.vender_negro_84x24;
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            }
        }

        private void pic_Modo_Click(object sender, EventArgs e)
        {
            modoOscuroClaro();
        }
    }
}
