using Biblioteca;
using Parcial1_Labo_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
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
        static float precioPremium = 0;
        static float precioTurista = 0;
        int indiceVuelo;
        int indiceClientes;
        float totalAPagar=0;
        List<Pasajero> auxiliar= new List<Pasajero>();

        int cantidadPasajerosRestantes;
        public frm_Venta( int index) : this()
        {
            this.indiceVuelo = index;
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            dgv_Clientes.DataSource = null;
            dgv_Clientes.DataSource = Aerolinea.clientes;
            lbl_Codigo.Text += Aerolinea.vuelos[indiceVuelo].Codigo;
            lbl_Destino.Text += Aerolinea.vuelos[indiceVuelo].Destino.ToString();
            lbl_Duracion.Text += Aerolinea.vuelos[indiceVuelo].Duracion;
            lbl_Origen.Text+= Aerolinea.vuelos[indiceVuelo].Origen.ToString();
            precioPremium=(float) (Aerolinea.vuelos[indiceVuelo].CostoDePasaje * 1.15f);
            precioTurista=(float)(Aerolinea.vuelos[indiceVuelo].CostoDePasaje );
            lbl_PrecioSub.Text += precioTurista.ToString("N2");
            lbl_PrecioFinal.Text += (precioTurista * 1.21f * 1.90f).ToString("N2");
            modoOscuroClaro();
            cantidadPasajerosRestantes = 0;
            rtx_PasajerosAgregados.Text = String.Empty;
            dgv_Clientes.Enabled = true;
            txt_Buscador.Enabled = true;
            pic_AceptarCliente.Enabled = true;
            pic_AgregarCliente.Enabled = true;
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
            if (Aerolinea.vuelos[indiceVuelo].AsientosLibresPremium==Vuelo.CalcularAsientos(Aerolinea.vuelos[indiceVuelo].Avion.CantidadAsientos,0.20f))
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
                    //lbl_KgMax.Text = "/42 kg";
                }
                else
                {

                    lbl_PrecioSub.Text = "Precio subtotal: " + precioTurista.ToString("N2");
                    lbl_PrecioFinal.Text = "Precio Final: " + (precioTurista *1.21f * 1.90f).ToString("N2");
                    nud_CantEquipaje.Maximum = 1;
                    //lbl_KgMax.Text = "/25 kg";

                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text != String.Empty && txt_Nombre.Text != String.Empty && txt_Dni.Text != String.Empty && txt_Edad.Text != String.Empty && 
                ((chk_Premium.Checked && int.Parse(txt_Kg.Text)<=42) || (!chk_Premium.Checked && int.Parse(txt_Kg.Text) <= 25)))
            {
                try
                {
                    if (txt_Kg.Text != String.Empty && (Aerolinea.vuelos[indiceVuelo].BodegaRestante - int.Parse(txt_Kg.Text)) < 0)
                    {
                        throw new Exception("No hay mas espacio en cabina");
                    }
                    Pasajero pasajero = new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text), int.Parse(txt_Edad.Text), (int)(nud_CantEquipaje.Value), chk_Premium.Checked, chk_BolsoMano.Checked);
                    auxiliar.Add(pasajero);
                    rtx_PasajerosAgregados.Text += pasajero.ToString() + "\n";
                    cantidadPasajerosRestantes++;
                    prg_CantidadRestante.Value = cantidadPasajerosRestantes;

                    chk_Premium.CheckState = CheckState.Unchecked;
                    txt_Apellido.Clear();
                    txt_Nombre.Clear();
                    txt_Dni.Clear();
                    txt_Edad.Clear();
                    nud_CantEquipaje.Value = 0;
                    chk_BolsoMano.Checked = false;
                    txt_Kg.Text="0";

                    if (cantidadPasajerosRestantes == nud_Cantidad.Value)
                    { 
                        pnl_ConfirmarCompra.Visible = true;
                        pic_AceptarCantidad.Enabled = false;
                        pic_Cancelar.Enabled = false;
                        KeyValuePair<int,Pasajero> aux = Aerolinea.vuelos[indiceVuelo].Pasajeros.Last();
                        int asiento = aux.Key ;
                        foreach (Pasajero pas in auxiliar)
                        {
                            asiento++;
                            rtx_InfoPasajerosFinal.Text += pas.ToString() + "\nAsiento: " +asiento +"\n" ;
                            if (pas.Premium)
                            {
                                totalAPagar += precioPremium* 1.90f * 1.21f ;
                            }
                            else
                            {
                                totalAPagar += precioTurista * 1.90f * 1.21f;
                            }
                            
                        }
                        lbl_TotalPagar.Text ="Total a pagar: " + totalAPagar.ToString("N2");
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
            

        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Cantidad.Value != 0)
            {
                pic_AceptarCantidad.Enabled = true;
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
            if(txt_Kg.Text== String.Empty)
            {
                txt_Kg.Text = "0";
            }

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
            if(nud_CantEquipaje.Value==2)
            {
                lbl_KgMax.Text = "/42 Kg";
            }
            else
            {
                lbl_KgMax.Text = "/25 Kg";
            }
        }

    

        private void dgv_Clientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indiceClientes=e.RowIndex;
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
            dgv_Clientes.Enabled = false;
            txt_Buscador.Enabled = false;
            pic_AceptarCliente.Enabled = false;
            pic_AgregarCliente.Enabled = false;
            lbl_ClienteComprador.Text = "Comprador: " + Aerolinea.clientes[indiceClientes].ToString();
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
                lbl_ErrorBusqueda.Text = "No se encontro ningun cliente, quiere agregarlo?";

            }
        }

        private void pic_CancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pic_AceptarCompra_Click(object sender, EventArgs e)
        {
            int cantidadAgregados=0;
            foreach (Pasajero pasajero in auxiliar)
            {
                Aerolinea.vuelos[indiceVuelo].UltimoAsiento++;
                Aerolinea.vuelos[indiceVuelo].Pasajeros.Add(Aerolinea.vuelos[indiceVuelo].UltimoAsiento, pasajero);
                cantidadAgregados++;
                if (pasajero.Premium)
                {
                    Aerolinea.vuelos[indiceVuelo].AsientosLibresPremium--;
                }else
                    Aerolinea.vuelos[indiceVuelo].AsientosLibresTurista--;
            }
            Aerolinea.clientes[indiceClientes].CantPasajesComprados += cantidadAgregados;
            DialogResult = DialogResult.OK;
        }

        private void pic_AceptarCantidad_Click(object sender, EventArgs e)
        {

            if (nud_Cantidad.Value > 0)
            {
                if (Aerolinea.vuelos[indiceVuelo].VerificarEspacio((int)(nud_Cantidad.Value)))
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
                    pic_AceptarCantidad.Enabled = false;
                    chk_BolsoMano.Enabled = true;
                }

            }
            else
                lbl_Error.Text = "Seleccione una cantidad mayor a 0";
        }

        //Modo oscuro
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
                chk_Premium.ForeColor = Color.White;
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
                pic_Agregar.Image = Resources.agregar_blanco_84x24;
                pic_Cancelar.Image = Resources.cancelar_blanco_84x24;
                lbl_KgMax.ForeColor = Color.White;
                chk_BolsoMano.ForeColor = Color.White;
                lbl_Destino.ForeColor = Color.White;
                lbl_Impuestos.ForeColor = Color.White;
                txt_Buscador.BackColor = Color.FromArgb(34, 34, 34);
                txt_Buscador.ForeColor = Color.White;
                lbl_ErrorBusqueda.ForeColor = Color.White;
                lbl_Error.ForeColor = Color.White;
                lbl_ClienteComprador.ForeColor = Color.White;
                pic_AceptarCantidad.Image = Resources.Aceptar_84x24_blanco;
                pic_AgregarCliente.Image = Resources.agregar_blanco_84x24;
                pic_AceptarCliente.Image = Resources.Aceptar_84x24_blanco;
                dgv_Clientes.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
                dgv_Clientes.DefaultCellStyle.ForeColor = Color.White;
                lbl_Buscador.ForeColor = Color.White;
                pic_AceptarCompra.Image= Resources.Aceptar_84x24_blanco;
                pic_CancelarCompra.Image = Resources.cancelar_blanco_84x24;
                rtx_InfoPasajerosFinal.BackColor = Color.FromArgb(34, 34, 34);
                rtx_InfoPasajerosFinal.ForeColor = Color.White;
                lbl_TotalPagar.ForeColor= Color.White;
                rtx_PasajerosAgregados.ForeColor = Color.White;
                rtx_PasajerosAgregados.BackColor = Color.FromArgb(34, 34, 34);

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
                lbl_ClienteComprador.ForeColor = Color.Black;
                pic_AceptarCantidad.Image = Resources.Aceptar_84x24_negro;
                pic_AgregarCliente.Image = Resources.agregar_negro_84x24;
                pic_AceptarCliente.Image = Resources.Aceptar_84x24_negro;
                lbl_Buscador.ForeColor = Color.Black;
                dgv_Clientes.DefaultCellStyle.BackColor = Color.White;
                dgv_Clientes.DefaultCellStyle.ForeColor = Color.Black;
                pic_AceptarCompra.Image = Resources.Aceptar_84x24_negro;
                pic_CancelarCompra.Image = Resources.cancelar_negro_84x24;
                rtx_InfoPasajerosFinal.BackColor = Color.White;
                rtx_InfoPasajerosFinal.ForeColor = Color.Black;
                lbl_TotalPagar.ForeColor = Color.Black;
                rtx_PasajerosAgregados.ForeColor = Color.Black;
                rtx_PasajerosAgregados.BackColor = Color.White;

            }
        }

        
    }
}
