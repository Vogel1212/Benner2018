using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCervejaria.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomeUsuario { get; set; }

        public string Senha { get; set; }
    }
}