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
    public partial class listado : Form
    {
        public listado()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            try
            {
                UsuarioService usuarioService = new UsuarioService();
                dgv_busqueda.DataSource = usuarioService.ObtenerTodosUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cmb_criterio.Text;
            string valor = txt_buscado.Text;

            //Buscar(criterio, valor);
            try
            {
                // Instanciar el servicio
                UsuarioService usuarioService = new UsuarioService();



                // Validar que se haya seleccionado un criterio y que se haya ingresado un valor
                if (string.IsNullOrEmpty(criterio))
                {
                    MessageBox.Show("Por favor, selecciona un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(valor))
                {
                    MessageBox.Show("Por favor, ingresa un valor de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al servicio para buscar las categorías
                List<Usuario> resultados = usuarioService.BuscarUsuarios(criterio, valor);
                // Mostrar los resultados en el DataGridView
                //dgv_resultado.AutoGenerateColumns = true;
                dgv_busqueda.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_buscado_TextChanged(object sender, EventArgs e)
        {
            string criterio = cmb_criterio.Text;
            string valor = txt_buscado.Text;

            //Buscar(criterio, valor);
            try
            {
                // Instanciar el servicio
                UsuarioService usuarioService = new UsuarioService();



                // Validar que se haya seleccionado un criterio y que se haya ingresado un valor
                if (string.IsNullOrEmpty(criterio))
                {
                    MessageBox.Show("Por favor, selecciona un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(valor))
                {
                    MessageBox.Show("Por favor, ingresa un valor de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al servicio para buscar las categorías
                List<Usuario> resultados = usuarioService.BuscarUsuarios(criterio, valor);



                // Mostrar los resultados en el DataGridView
                //dgv_resultado.AutoGenerateColumns = true;
                dgv_busqueda.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda:," + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_busqueda_SelectionChanged(object sender, EventArgs e)
        {
            /*if (dgv_busqueda.Rows.Count > 0)
            {
                lbl_id.Text = dgv_busqueda.Rows[0].Cells[0].Value.ToString();

            }*/
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_busqueda.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado
                int idUsuario = Convert.ToInt32(dgv_busqueda.SelectedRows[0].Cells["id"].Value);

                // Abrir el formulario de edición
                EditarUsuario formEditar = new EditarUsuario(idUsuario);
                formEditar.ShowDialog();

                // Recargar la lista después de editar
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que haya una fila seleccionada
                if (dgv_busqueda.SelectedRows.Count > 0)
                {
                    // Obtén el ID del usuario seleccionado
                    int usuarioId = Convert.ToInt32(dgv_busqueda.SelectedRows[0].Cells["id"].Value);

                    // Crear instancia del servicio
                    UsuarioService usuarioService = new UsuarioService();

                    // Mostrar cuadro de confirmación
                    var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                                                       "Confirmar eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Llamada al servicio para eliminar al usuario
                        usuarioService.EliminarUsuario(usuarioId);
                        MessageBox.Show("Usuario eliminado con éxito.");

                        // Recargar la lista después de eliminar
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un usuario para eliminar.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }
          
        }
    }
    
}
