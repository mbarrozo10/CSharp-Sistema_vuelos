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
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Aerolina.vuelos[Index].Pasajeros;

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
