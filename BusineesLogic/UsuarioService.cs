using ProyectoENE.DataAccess;
using ProyectoENE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoENE.BusineesLogic
{
    public class UsuarioService
    {

        private UsuarioRepository usuarioRepository;
        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }


        public void AgregarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.nombre) || string.IsNullOrEmpty(usuario.clave) || string.IsNullOrEmpty(usuario.correo))
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            // Encriptar la contraseña del usuario
            usuario.clave = BCrypt.Net.BCrypt.HashPassword(usuario.clave);
            
            usuarioRepository.GuardarUsuario(usuario);
        }
        //obtener los usuarios
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return usuarioRepository.ObtenerTodosUsuarios();
        }
        public Usuario ObtenerUsuarioPorId(int id)
        {
            return usuarioRepository.ObtenerUsuarioPorId(id);
        }

        //llamamos al metodo que trae a un usuario segun su usuario
        public Usuario ObtenerUsuarioPorUsuario(string ParametroUsuario)
        {
            return usuarioRepository.ObtenerUsuarioPorUsuario(ParametroUsuario);
        }
        public bool VerificarContraseña(string inputPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedHashedPassword);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (usuario.id <= 0)
            {
                throw new ArgumentException("ID de usuario inválido.");
            }
            usuarioRepository.ActualizarUsuario(usuario);
        }
        public List<Usuario> BuscarUsuarios(string criterio, string valor)
        {
            // Validación del criterio (solo permitir criterios válidos)
            if (criterio != "id" && criterio != "nombre" && criterio != "correo")
            {
                throw new ArgumentException("Criterio de búsqueda no válido.");
            }

            // Pasar la solicitud al repositorio
            return usuarioRepository.BuscarPorCriterio(criterio, valor);
        }

        public void EliminarUsuario(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID de usuario inválido.");
            }

            usuarioRepository.EliminarUsuario(id);
        }




    }
}
