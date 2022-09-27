using Biblioteca;
using Microsoft.VisualBasic;
using Parcial1_Labo_2.Properties;

namespace Parcial1_Labo_2
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           Aerolinea.Vendedores= Inicializador.InicializarVendedores();
            Aerolinea.clientes = Inicializador.InicializarClientes();
            Aerolinea.aviones = Inicializador.InicializarAviones();
            Aerolinea.vuelos = Inicializador.InicializarVuelos();
            Aerolinea.vuelosFinalizados = Inicializador.InicializarVuelos();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = Vendedor.VerificarLogin(txt_Usuario.Text, txt_Contraseña.Text, Aerolinea.Vendedores);
                this.Hide();
                frm_MenuPrincipal menu = new frm_MenuPrincipal(vendedor);
                menu.ShowDialog();
                modoOscuroClaro();
                this.Show();
                txt_Usuario.Clear();
                txt_Contraseña.Clear();

            }
            catch(Exception exepcion)
            {
                lbl_Error.ForeColor = Color.Red;
                lbl_Error.Text = exepcion.Message;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 5);
            txt_Usuario.Text = Aerolinea.Vendedores[i].Usuario;
            txt_Contraseña.Text = Aerolinea.Vendedores[i].Contraseña;
        }

        private void pic_Modo_Click(object sender, EventArgs e)
        {

            modoOscuroClaro();
        }


        private void modoOscuroClaro()
        {
            if (!Aerolinea.modoOscuro)
            {
                pic_Modo.Image = Resources.dia;
                this.BackColor = Color.FromArgb(34, 34, 34);
                lbl_Usuario.ForeColor = Color.White;
                lbl_Contraseña.ForeColor = Color.White;
                pic_Ingresar.Image = Resources.Ingresar_Blanco;
                pic_Salir.Image = Resources.Salir_blanco;
                txt_Contraseña.BackColor = Color.FromArgb(34, 34, 34);
                txt_Usuario.BackColor = Color.FromArgb(34, 34, 34);
                txt_Usuario.ForeColor = Color.White;
                txt_Contraseña.ForeColor = Color.White;
                Aerolinea.modoOscuro = true;
            }
            else
            {
                pic_Modo.Image = Resources.night_mode1;
                this.BackColor = Color.White;
                lbl_Usuario.ForeColor = Color.Black;
                lbl_Contraseña.ForeColor = Color.Black;
                pic_Ingresar.Image = Resources.Ingresar_Negro;
                pic_Salir.Image = Resources.Salir_Negro;
                txt_Contraseña.BackColor = Color.White;
                txt_Usuario.ForeColor = Color.Black;
                txt_Contraseña.ForeColor = Color.Black;
                txt_Usuario.BackColor = Color.White;
                Aerolinea.modoOscuro = false;
            }
        }

        //private void modoOscuro()
        //{
        //    pic_Modo.Image = Resources.dia;
        //    this.BackColor = Color.FromArgb(34, 34, 34);
        //    lbl_Usuario.ForeColor = Color.White;
        //    lbl_Contraseña.ForeColor = Color.White;
        //    pic_Ingresar.Image = Resources.Ingresar_Blanco;
        //    pic_Salir.Image = Resources.Salir_blanco;
        //    txt_Contraseña.BackColor = Color.FromArgb(34, 34, 34);
        //    txt_Usuario.BackColor = Color.FromArgb(34, 34, 34);
        //    txt_Usuario.ForeColor = Color.White;
        //    txt_Contraseña.ForeColor = Color.White;
        //    Aerolinea.modoOscuro = true;
        //}

        //private void modoClaro()
        //{
        //    pic_Modo.Image = Resources.night_mode1;
        //    this.BackColor = Color.White;
        //    lbl_Usuario.ForeColor = Color.Black;
        //    lbl_Contraseña.ForeColor = Color.Black;
        //    pic_Ingresar.Image = Resources.Ingresar_Negro;
        //    pic_Salir.Image = Resources.Salir_Negro;
        //    txt_Contraseña.BackColor = Color.White;
        //    txt_Usuario.ForeColor = Color.Black;
        //    txt_Contraseña.ForeColor = Color.Black;
        //    txt_Usuario.BackColor = Color.White;
        //    Aerolinea.modoOscuro = false;
        //}



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    DateTime hora = DateTime.Now;
        //  //  lbl_Hora.Text = hora.ToString("hh:mm:ss tt");
        //    if (hora.ToString("hh:mm:ss") == "9:12:00")
        //    {
        //        this.BackColor = Color.Red;
        //    }
        //}
    }
}