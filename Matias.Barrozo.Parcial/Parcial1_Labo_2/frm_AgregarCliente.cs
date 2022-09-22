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
    public partial class frm_AgregarCliente : Form
    {
        public frm_AgregarCliente()
        {
            InitializeComponent();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pic_Agregar_Click(object sender, EventArgs e)
        {
            if(txt_Apellido.Text ==String.Empty || txt_Dni.Text == String.Empty || txt_Edad.Text== String.Empty || txt_Nombre.Text== String.Empty)
            {
                lbl_Error.Text = "Falta algun dato!!";
            }
            else
            {
                try
                {
                    Cliente nuevo = new Cliente(txt_Nombre.Text,txt_Apellido.Text,int.Parse(txt_Dni.Text),int.Parse(txt_Edad.Text));
                    AgregarCliente(nuevo);
                    Aerolinea.clientes.Add(nuevo);
                    DialogResult = DialogResult.OK;
                }catch(Exception exp)
                {
                    lbl_Error.Text = exp.Message;
                }
                
            }
        }

        private void AgregarCliente(Cliente nuevo)
        {
            foreach (Cliente cliente in Aerolinea.clientes)
            {
                if (cliente.Equals(nuevo))
                {
                   throw new Exception( "Error, ya existe un usuario con ese dni");
                }
            }
        }
    }
}
