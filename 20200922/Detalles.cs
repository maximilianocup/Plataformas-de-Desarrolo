using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _20200922
{
    public class Detalles
    {
        public int id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public int RecursoId { get; set; }
         Recursos Recurso { get; set; }
        public int TareaId { get; set; }
        public Tareas Tarea { get; set; }

    }
}
