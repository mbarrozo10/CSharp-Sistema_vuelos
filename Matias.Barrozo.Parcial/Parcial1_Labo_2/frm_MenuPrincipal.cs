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
            dataGridView1.DataSource = null;
            for(int i=0;i<Aerolina.vuelos.Count;i++)
            {
                DataGridViewRow filas= new DataGridViewRow();
                filas.CreateCells(dataGridView1);
                filas.Cells[0].Value= Aerolina.vuelos[i].Avion.Matricula;
                filas.Cells[1].Value = Aerolina.vuelos[i].Duracion;
                filas.Cells[2].Value = Aerolina.vuelos[i].CalcularCosto();
                filas.Cells[3].Value = Aerolina.vuelos[i].Destino;
                filas.Cells[4].Value = Aerolina.vuelos[i].Estado;

                dataGridView1.Rows.Add(filas);

            }
           // dataGridView1.DataSource = Inicializador.vuelos;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;
        }
    }
}
