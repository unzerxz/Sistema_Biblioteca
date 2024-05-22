using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_biblioteca.Models
{
    public class Biblioteca
    {
        public List<Livros> LivrosCadastrados { get; set; }

        public List<Membro> MembrosCadastrados { get; set; }
    }
}