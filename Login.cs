using ProyectoENE.BusineesLogic;
using ProyectoENE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoENE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
{
            UsuarioService usuarioService = new UsuarioService();

            string usuariotxt = txt_usuario.Text.Trim();  // Eliminar espacios en blanco
            string clavetxt = txt_clave.Text;

            try
            {

                // Verificar que el nombre de usuario no esté vacío
                if (string.IsNullOrEmpty(usuariotxt))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de usuario.");
                    return;
                }

                // Buscar el usuario en la base de datos
                Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUsuario(usuariotxt);

                if (usuarioInstancia != null)
                {
                    // Verificar la contraseña usando BCrypt
                    bool esValida = usuarioService.VerificarContraseña(clavetxt, usuarioInstancia.clave);

                    if (esValida)
                    {
                        MessageBox.Show("Bienvenido, " + usuarioInstancia.nombre);

                        // Abrir el menú principal
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide(); // Ocultar el formulario de login
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar usuario: " + ex.Message);
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_clave.Clear();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
