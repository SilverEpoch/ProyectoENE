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

namespace ProyectoENE.UI
{
    public partial class EditarUsuario : Form
    {
        private UsuarioService usuarioService;
        private Usuario usuarioActual;

        public EditarUsuario()
        {
            InitializeComponent();
        }
        public EditarUsuario(int id)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();

            // Cargar los datos del usuario
            usuarioActual = usuarioService.ObtenerUsuarioPorId(id);
            if (usuarioActual != null)
            {
                txt_Nombre.Text = usuarioActual.nombre;
                txt_Correo.Text = usuarioActual.correo;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
                this.Close();
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioActual.nombre = txt_Nombre.Text;
                usuarioActual.correo = txt_Correo.Text;

                // Validar datos
                if (string.IsNullOrEmpty(usuarioActual.nombre) || string.IsNullOrEmpty(usuarioActual.correo))
                {
                    MessageBox.Show("Todos los campos deben tener valores.");
                    return;
                }

                // Actualizar en la base de datos
                usuarioService.ActualizarUsuario(usuarioActual);
                MessageBox.Show("Usuario actualizado correctamente.");
                this.Close(); // Cerrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }
        }
    }
}
