using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entidades
{
    public class Detalle
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
    }
}
