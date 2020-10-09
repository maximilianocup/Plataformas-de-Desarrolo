using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _20200922
{
    class Tareas
    {
        public Tareas() { } 
        public Tareas(string v1, DateTime dateTime, int v2, Recursos recursos, bool v3)
        {
        }
        public int id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int ResponsableId { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }
    }
}
