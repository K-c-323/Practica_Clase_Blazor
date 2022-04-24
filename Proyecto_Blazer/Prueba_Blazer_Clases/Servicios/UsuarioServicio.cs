using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using Prueba_Blazer_Clases.Data;
using Prueba_Blazer_Clases.Interfaces;

namespace Prueba_Blazer_Clases.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;
        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
        }

        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> Getlista()
        {
            return await usuarioRepositorio.Getlista();
        }

        public Task<Usuario> GetPorCodigo(string Codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
