﻿using Datos.Interfaces;
using Datos.Repositorios;
using Golozinas.Data;
using Golozinas.Interfaces;
using Modelos;

namespace Golozinas.Servicios
{
    public class UsuariosServicios : IUsuariosServicios
    {

        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;
        public UsuariosServicios(MySQLConfiguration configuration)
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

        public async Task<IEnumerable<Usuario>> GetLista()
        {
            return await usuarioRepositorio.GetLista();
        }

        public Task<Usuario> GetPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
