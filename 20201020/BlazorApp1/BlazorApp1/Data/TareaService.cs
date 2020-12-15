﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using Model.Entidades;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        

        public async Task<List<Tarea>> ListTask()
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> SelectTask(int id)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GetTarea(id);
        }

        public async Task<Tarea> SaveTask(Tarea value)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            return await remoteService.GuardarTarea(value);
        }

        public async Task<bool> DeleteTask(int id)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44332/api/");
            await remoteService.BorrarTarea(id);
            return true;
        }


    }
}
