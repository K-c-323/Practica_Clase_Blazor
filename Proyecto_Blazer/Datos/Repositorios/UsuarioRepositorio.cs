using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private String CadenaConexion; 
        public UsuarioRepositorio(String cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
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
            IEnumerable<Usuario> Lista = new List<Usuario>();

            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                String sql = "SELECT * FROM usuario;";
                Lista = await conexion.QueryAsync<Usuario>(sql);

            }
            catch (Exception ex)
            {

            }
            return Lista;
            

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
