using Biblioteca;
using Parcial1_Labo_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Labo_2
{
    public partial class frm_Venta : Form
    {
        public frm_Venta()
        {
            InitializeComponent();
        }
        static float precioPremium=0;
        static float precioTurista = 0;
        int index;
        float recaudacion;
        int indexClientes;

        int cantidadPasajerosRestantes;
        public frm_Venta( int index) : this()
        {
            this.index = index;
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            dgv_Clientes.DataSource = null;
            dgv_Clientes.DataSource = Aerolinea.clientes;
            lbl_Codigo.Text += Aerolinea.vuelos[index].Codigo;
            lbl_Destino.Text += Aerolinea.vuelos[index].Destino.ToString();
            lbl_Duracion.Text += Aerolinea.vuelos[index].Duracion;
            lbl_Origen.Text+= Aerolinea.vuelos[index].Origen.ToString();
            precioPremium=(float) (Aerolinea.vuelos[index].CostoDePasaje * 1.15f);
            precioTurista=(float)(Aerolinea.vuelos[index].CostoDePasaje );
            lbl_PrecioSub.Text += precioTurista.ToString("N2");
            lbl_PrecioFinal.Text += (precioTurista * 1.21f * 1.90f).ToString("N2");
            modoOscuroClaro();
            recaudacion= Aerolinea.vuelos[index].Recaudacion;
            cantidadPasajerosRestantes = 0;
            rtx_PasajerosAgregados.Text = String.Empty;
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
        }

        public static bool CheckNumeros(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }

            return false;
        }

        public static bool CheckLetras(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                return true;
            }

            return false;
        }
        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckLetras(e);
        }

        private void chk_Premium_CheckedChanged(object sender, EventArgs e)
        {
            if (Aerolinea.vuelos[index].AsientosLibresPremium==Vuelo.CalcularAsientos(Aerolinea.vuelos[index].Avion.CantidadAsientos,0.20f))
            {
                lbl_Error.Text = "Error, ya no queda expacio premium";
                chk_Premium.Checked = false;
            }
            else
            {
                if (chk_Premium.Checked)
                {
                    nud_CantEquipaje.Maximum = 2;
                    lbl_PrecioSub.Text = "Precio subtotal: " + precioPremium.ToString("N2");
                    lbl_PrecioFinal.Text = "Precio Final: " + (precioPremium * 1.21f * 1.90f).ToString("N2");
                    lbl_KgMax.Text = "/21 kg";
                }
                else
                {

                    lbl_PrecioSub.Text = "Precio subtotal: " + precioTurista.ToString("N2");
                    lbl_PrecioFinal.Text = "Precio Final: " + (precioTurista *1.21f * 1.90f).ToString("N2");
                    nud_CantEquipaje.Maximum = 1;
                    lbl_KgMax.Text = "/25 kg";

                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool salir = false;

            if (txt_Apellido.Text != String.Empty && txt_Nombre.Text != String.Empty && txt_Dni.Text != String.Empty && txt_Edad.Text != String.Empty && 
                ((chk_Premium.Checked && int.Parse(txt_Kg.Text)<=42) || (!chk_Premium.Checked && int.Parse(txt_Kg.Text) <= 25)))
            {
                try
                {
                    if (txt_Kg.Text != String.Empty && (Aerolinea.vuelos[index].BodegaRestante - int.Parse(txt_Kg.Text)) < 0)
                    {
                        throw new Exception("No hay mas espacio en cabina");
                    }
                    Aerolinea.vuelos[index].UltimoAsiento++;
                    Pasajero pasajero = new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text), int.Parse(txt_Edad.Text), (int)(nud_CantEquipaje.Value), chk_Premium.Checked, chk_BolsoMano.Checked);
                    Aerolinea.vuelos[index].Pasajeros.Add(Aerolinea.vuelos[index].UltimoAsiento, pasajero);
                    rtx_PasajerosAgregados.Text += pasajero.ToString() + "\n";
                    if (nud_CantEquipaje.Value > 0 && txt_Kg.Text != String.Empty)
                    {
                        Aerolinea.vuelos[index].BodegaRestante -= int.Parse(txt_Kg.Text);
                    }

                    if (chk_Premium.Checked)
                    {
                        recaudacion += precioPremium * 1.21f;
                        Aerolinea.vuelos[index].AsientosLibresPremium += 1;
                    }
                    else
                    {
                        Aerolinea.vuelos[index].AsientosLibresTurista += 1;
                        recaudacion += precioTurista * 1.21f;
                    }


                    cantidadPasajerosRestantes++;
                    prg_CantidadRestante.Value = cantidadPasajerosRestantes;

                    chk_Premium.CheckState = CheckState.Unchecked;
                    txt_Apellido.Clear();
                    txt_Nombre.Clear();
                    txt_Dni.Clear();
                    txt_Edad.Clear();
                    nud_CantEquipaje.Value = 0;
                    txt_Kg.Clear();

                    if (cantidadPasajerosRestantes == nud_Cantidad.Value)
                    {
                        salir = true;
                    }
                    if (salir)
                    {
                        Aerolinea.vuelos[index].Recaudacion = recaudacion;
                        DialogResult = DialogResult.OK;
                    }
                   

                }catch(Exception ex)
                {
                    lbl_Error.Text=ex.Message;
                }
            }
            else
            {
                lbl_Error.Text = "Falta algun dato o algun dato es incorrecto";
            }
            Aerolinea.clientes[indexClientes].CantPasajesComprados += 1;
            

        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Cantidad.Value != 0)
            {
                btn_Aceptar.Enabled = true;
            }
            else
            {
                nud_Cantidad.Minimum = 1;
                prg_CantidadRestante.Value=(int)nud_Cantidad.Value;
            }
        }

        private void txt_Kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumeros(e);
            

        }

        private void nud_CantEquipaje_ValueChanged(object sender, EventArgs e)
        {
            if (nud_CantEquipaje.Value != 0)
            {
                txt_Kg.Enabled = true;
            }
            else
            {
                txt_Kg.Enabled = false;
            }
        }

        private void modoOscuroClaro()
        {
            if (!Aerolinea.modoOscuro)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                lbl_Codigo.ForeColor = Color.White;
                lbl_Origen.ForeColor = Color.White;
                lbl_Duracion.ForeColor = Color.White;
                lbl_Cantidad.ForeColor = Color.White;
                lbl_Nombre.ForeColor = Color.White;
                lbl_Apellido.ForeColor = Color.White;
                lbl_Dni.ForeColor = Color.White;
                lbl_Edad.ForeColor = Color.White;
                lbl_Equipaje.ForeColor = Color.White;
                lbl_Kg.ForeColor = Color.White;
                lbl_PrecioSub.ForeColor = Color.White;
                lbl_PrecioFinal.ForeColor = Color.White;
                chk_Premium.ForeColor= Color.White;
                txt_Apellido.BackColor = Color.FromArgb(34, 34, 34);
                txt_Nombre.BackColor = Color.FromArgb(34, 34, 34);
                txt_Dni.BackColor = Color.FromArgb(34, 34, 34);
                txt_Edad.BackColor = Color.FromArgb(34, 34, 34);
                nud_CantEquipaje.BackColor = Color.FromArgb(34, 34, 34);
                txt_Kg.BackColor = Color.FromArgb(34, 34, 34);
                txt_Apellido.ForeColor = Color.White;
                txt_Nombre.ForeColor = Color.White;
                txt_Dni.ForeColor = Color.White;
                txt_Edad.ForeColor = Color.White;
                nud_CantEquipaje.ForeColor = Color.White;
                txt_Kg.ForeColor = Color.White;
                pic_Agregar.Image= Resources.agregar_blanco_84x24;
                pic_Cancelar.Image = Resources.cancelar_blanco_84x24;
                lbl_KgMax.ForeColor= Color.White;
                chk_BolsoMano.ForeColor = Color.White;
                lbl_Destino.ForeColor = Color.White;
                lbl_Impuestos.ForeColor= Color.White;
                txt_Buscador.BackColor = Color.FromArgb(34, 34, 34);
                txt_Buscador.ForeColor = Color.White;
                lbl_ErrorBusqueda.ForeColor = Color.White;
                lbl_Error.ForeColor= Color.White;
               

            }
            else
            {
                this.BackColor = Color.White;
                lbl_Codigo.ForeColor = Color.Black;
                lbl_Origen.ForeColor = Color.Black;
                lbl_Duracion.ForeColor = Color.Black;
                lbl_Cantidad.ForeColor = Color.Black;
                lbl_Nombre.ForeColor = Color.Black;
                lbl_Apellido.ForeColor = Color.Black;
                lbl_Dni.ForeColor = Color.Black;
                lbl_Edad.ForeColor = Color.Black;
                lbl_Equipaje.ForeColor = Color.Black;
                lbl_Kg.ForeColor = Color.Black;
                lbl_PrecioSub.ForeColor = Color.Black;
                lbl_PrecioFinal.ForeColor = Color.Black;
                chk_Premium.ForeColor = Color.Black;
                txt_Apellido.BackColor = Color.White;
                txt_Nombre.BackColor = Color.White;
                txt_Dni.BackColor = Color.White;
                txt_Edad.BackColor = Color.White;
                nud_CantEquipaje.BackColor = Color.White;
                txt_Kg.BackColor = Color.White;
                txt_Apellido.ForeColor = Color.Black;
                txt_Nombre.ForeColor = Color.Black;
                txt_Dni.ForeColor = Color.Black;
                txt_Edad.ForeColor = Color.Black;
                nud_CantEquipaje.ForeColor = Color.Black;
                txt_Kg.ForeColor = Color.Black;
                pic_Agregar.Image = Resources.agregar_negro_84x24;
                pic_Cancelar.Image = Resources.cancelar_negro_84x24;
                lbl_KgMax.ForeColor = Color.Black;
                chk_BolsoMano.ForeColor = Color.Black;
                lbl_Destino.ForeColor = Color.Black;
                lbl_Impuestos.ForeColor = Color.Black;
                txt_Buscador.BackColor = Color.White;
                txt_Buscador.ForeColor = Color.Black;
                lbl_ErrorBusqueda.ForeColor = Color.Black;
                lbl_Error.ForeColor = Color.Black;
            }
        }


        private bool VerificarEspacio(int cantidadPedida)
        {
            return (Aerolinea.vuelos[index].Pasajeros.Count+cantidadPedida) > Aerolinea.vuelos[index].Avion.CantidadAsientos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (VerificarEspacio((int)nud_Cantidad.Value))
            {
                lbl_Error.Text = "Error, no hay espacio";
            }
            else
            {
                nud_Cantidad.Enabled = false;
                txt_Apellido.Enabled = true;
                txt_Nombre.Enabled = true;
                txt_Dni.Enabled = true;
                txt_Edad.Enabled = true;
                nud_CantEquipaje.Enabled = true;
                chk_Premium.Enabled = true;
                prg_CantidadRestante.Maximum = (int)nud_Cantidad.Value;
                pic_Agregar.Enabled = true;
                btn_Aceptar.Enabled = false;
                chk_BolsoMano.Enabled = true;
            }
        }

       

        private void dgv_Clientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexClientes=e.RowIndex;
        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == String.Empty)
            {
                dgv_Clientes.DataSource = null;
                dgv_Clientes.DataSource = Aerolinea.clientes;
            }
        }

        private void btn_AceptarCliente_Click(object sender, EventArgs e)
        {
            nud_Cantidad.Enabled = true;
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            frm_AgregarCliente frm = new frm_AgregarCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgv_Clientes.DataSource = null;
                dgv_Clientes.DataSource = Aerolinea.clientes;
            }
        }

        private void txt_Buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool Encontro = false;
            List<Cliente> filtrada = new List<Cliente>();
            for (int i = 0; i < Aerolinea.clientes.Count; i++)
            {


                if (Aerolinea.clientes[i].Nombre.ToLower().Contains(txt_Buscador.Text.ToLower()) ||
                     Aerolinea.clientes[i].Apellido.ToLower().Contains(txt_Buscador.Text.ToLower()) ||
                     Aerolinea.clientes[i].GetHashCode().ToString().Contains(txt_Buscador.Text))
                {

                    filtrada.Add(Aerolinea.clientes[i]);
                    Encontro = true;

                }

            }
            if (Encontro)
            {
                dgv_Clientes.DataSource = null;
                dgv_Clientes.DataSource = filtrada;
                lbl_ErrorBusqueda.Text = String.Empty;

            }
            else
            {
                lbl_ErrorBusqueda.Text = "No se encontro ningun pasajero, quiere agregarlo?";

            }
        }
    }
}
