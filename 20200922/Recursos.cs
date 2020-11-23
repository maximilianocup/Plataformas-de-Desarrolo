using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _20200922
{
    public class Recursos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        Usuarios Usuario { get; set; }

    }
}
