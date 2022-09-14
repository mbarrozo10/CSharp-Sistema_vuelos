using Biblioteca;

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
           Aerolina.Vendedores= Inicializador.InicializarVendedores();
           // timer1.Start();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = Vendedor.VerificarLogin(txt_Usuario.Text, txt_Contraseña.Text, Aerolina.Vendedores);
                this.Hide();
                frm_MenuPrincipal menu = new frm_MenuPrincipal(vendedor);
                menu.ShowDialog();
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
            txt_Usuario.Text = Aerolina.Vendedores[i].Usuario;
            txt_Contraseña.Text = Aerolina.Vendedores[i].Contraseña;
        }

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