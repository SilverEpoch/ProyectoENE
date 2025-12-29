using ProyectoENE.BusineesLogic;
using ProyectoENE.DataAccess;
using ProyectoENE.Models;
using ProyectoENE.UI;

namespace ProyectoENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Usuario InstanciaUsuario = new Usuario
            {
                nombre = txt_usuario.Text,
                clave = txt_clave.Text,
                correo = txt_correo.Text
            };

            UsuarioService usuarioService = new UsuarioService();

            try
            {
                // Llamamos al servicio para agregar el usuario
                usuarioService.AgregarUsuario(InstanciaUsuario);

                MessageBox.Show("Usuario ingresado exitosamente");

                // Limpiar campos
                txt_clave.Clear();
                txt_correo.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Verificar si el usuario fue encontrado
            Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUsuario(txt_usuario.Text);

            if (usuarioInstancia != null)
            {
                string usuario = usuarioInstancia.nombre;
                // Hacer algo con el usuario, si es necesario
            }
            else
            {
                MessageBox.Show("");
            }
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_Rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           listado a = new listado();
            a.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
