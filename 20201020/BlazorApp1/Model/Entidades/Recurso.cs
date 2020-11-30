using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entidades
{
    public class Recurso
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
