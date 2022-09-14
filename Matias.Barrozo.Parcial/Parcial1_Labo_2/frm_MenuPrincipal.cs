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
    public partial class frm_MenuPrincipal : Form
    {
        
        private static int Index;
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        public frm_MenuPrincipal(Vendedor vendedor): this()
        {
            lbl_Bienvenido.Text="Bienvenidx " + vendedor.Nombre + " " + vendedor.Apellido;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Aerolina.aviones= Inicializador.InicializarAviones();
            Aerolina.vuelos= Inicializador.InicializarVuelos();
            CargarDatagrid();
           // dataGridView1.DataSource = Inicializador.vuelos;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex;
            if (Aerolina.vuelos[Index].Estado == Biblioteca.Estado.Disponible)
            {
                btn_Vender.Enabled = true;
                btn_Pasajeros.Enabled = true;
            }
            else if (Aerolina.vuelos[Index].Estado== Biblioteca.Estado.EnVuelo || Aerolina.vuelos[Index].Estado ==Biblioteca.Estado.Lleno)
            {
                btn_Pasajeros.Enabled = true;
                btn_Vender.Enabled = false;
            }
            else
            {
                btn_Vender.Enabled = false;
                btn_Pasajeros.Enabled=false;

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
            for (int i = 0; i < Aerolina.vuelos.Count; i++)
            {
                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(dataGridView1);
                //DateTime ahora = DateTime.Now;
                //DateTime test = new DateTime(2022,9,13, 22,0,0);
                //int x = ahora.Hour-3;

                filas.Cells[0].Value = Aerolina.vuelos[i].Codigo;
                filas.Cells[1].Value = Aerolina.vuelos[i].Avion.Matricula;
                filas.Cells[2].Value = Aerolina.vuelos[i].Duracion;
                filas.Cells[3].Value = "22";//Aerolina.vuelos[i].CalcularCosto();
                filas.Cells[4].Value = Aerolina.vuelos[i].Origen;
                filas.Cells[5].Value = Aerolina.vuelos[i].Destino;
                filas.Cells[6].Value = Aerolina.vuelos[i].Salida; //new DateTime(ahora.Year,ahora.Month,ahora.Day,x,ahora.Minute,ahora.Second);
                filas.Cells[7].Value = Aerolina.vuelos[i].Estado;
                filas.Cells[8].Value = Aerolina.vuelos[i].AsientosLibres;

                dataGridView1.Rows.Add(filas);

            }
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo vuelo = new frm_AgregarVuelo();
         //   vuelo.ShowDialog(); 
            if(vuelo.ShowDialog() == DialogResult.OK)
            {
                CargarDatagrid();
            }
        }
    }
}
