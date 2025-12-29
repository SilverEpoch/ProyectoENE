using MySqlConnector;
using ProyectoENE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoENE.DataAccess
{
    public class UsuarioRepository

    {
        private Conexion dbConnection;

        

        private List<Usuario> listaUsuario = new List<Usuario>();

        
        public UsuarioRepository() {
            dbConnection = new Conexion();
        }

       

        //Metodo para guardar un usuario
        //Hasta aqui enviaremos los datos desde el formulario cuando guardemos
        //un usuario
        public void GuardarUsuario(Usuario usuarioParametro)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                //creamos variable con la consulta que se va a ejecutar 
                string query = "INSERT INTO usuario (nombre, clave, correo) VALUES (@nombre, @clave, @correo) ";
                //Le dedicamos al encargado de la conexion que ejecute con la cadena de conexion
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", usuarioParametro.nombre);
                command.Parameters.AddWithValue("@clave", usuarioParametro.clave);
                command.Parameters.AddWithValue("@correo", usuarioParametro.correo);

                //aqui es donde se ejecuta
                command.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los usuarios
        //Cuando necesitemos saber un usuario o varios,
        //Usamos este metodo
        public List<Usuario> ObtenerTodosUsuarios()
        {
            List<Usuario> usuarioParametro = new List<Usuario>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM usuario";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = (reader.GetInt32("id"));
                    usuario.nombre = (reader.GetString("nombre"));
                    usuario.correo = (reader.GetString("correo"));
                    listaUsuario.Add(usuario);
                }
            }
            return usuarioParametro;
        }

        //buscar un usuario por un criterio de busqueda(usuario)
        public Usuario ObtenerUsuarioPorUsuario(string ParametroUsuario)
        {
            Usuario usuario = null;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM usuario WHERE nombre = @Nombre";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", ParametroUsuario);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        id = reader.GetInt32("id"),
                        nombre = reader.GetString("nombre"),
                        clave = reader.GetString("clave"),
                        correo = reader.GetString("correo")
                    };
                }
            }

            return usuario;

        }

        //obtener usuario por ID
        public Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario usuario = null;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM usuario WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.id = (reader.GetInt32("id"));
                    usuario.nombre = (reader.GetString("nombre"));
                }
            }
            return usuario;
        }
        // Actualizar un usuario existente
        public void ActualizarUsuario(Usuario usuario)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE usuario SET nombre = @Nombre, correo = @Correo WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", usuario.id);
                command.Parameters.AddWithValue("@Nombre", usuario.nombre);
                command.Parameters.AddWithValue("@Correo", usuario.correo);

                command.ExecuteNonQuery();
            }
        }

        // Eliminar un usuario
        public void EliminarUsuario(int id)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "DELETE FROM usuario WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }
        public List<Usuario> BuscarPorCriterio(string criterio, string valor)
        {
            string query = "";

            List<Usuario> usuarios = new List<Usuario>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {

                if (criterio == "id")
                {
                    query = "SELECT * FROM usuario where id = @Valor";
                }
                if (criterio == "nombre")
                {
                    query = "SELECT * FROM usuario where nombre like @Valor";
                    valor = "%" + valor + "%";
                }
                if (criterio == "correo")
                {
                    query = "SELECT * FROM usuario where correo like @Valor";
                    valor = "%" + valor + "%";
                }


                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Valor", valor);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = reader.GetInt32("id");
                    usuario.nombre = reader.GetString("nombre");
                    usuario.correo = reader.GetString("correo");
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }
    }
}
