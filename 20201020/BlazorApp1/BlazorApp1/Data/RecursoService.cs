using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using Model.Entidades;
namespace BlazorApp1.Data
{
    public class RecursoService
    {
        

        public async Task<List<Recurso>> ListResource()
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> SelectResource(int id)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetRecurso(id);
        }

        public async Task<Recurso> SaveResource(Recurso value)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GuardarRecurso(value);
        }

       
    }
}
