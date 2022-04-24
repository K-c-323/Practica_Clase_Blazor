using Modelos;

namespace Prueba_Blazer_Clases.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<bool> Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(Usuario usuario);
        Task<IEnumerable<Usuario>> Getlista();
        Task<Usuario> GetPorCodigo(String Codigo);



    }
}
