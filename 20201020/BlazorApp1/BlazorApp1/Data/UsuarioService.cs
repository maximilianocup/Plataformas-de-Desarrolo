using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Entidades;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        
        public async Task<List<Usuario>> ListUser()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> SelectUser(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetUsuario(id);
        }

        public async Task<Usuario> SaveUser(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GuardarUsuario(value);
        }

        




    }
}
