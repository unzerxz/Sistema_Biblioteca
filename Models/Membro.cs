using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_biblioteca.Models
{
    public class Membro
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public List<Livros> LivrosEmprestados { get; set; }

        public Membro(string Nome, int Id)
        {
            this.Nome = Nome;
            this.Id = Id;
            LivrosEmprestados = new List<Livros>();
        }

        public void EmprestarLivros(Livros livros)
        {
            if(LivrosEmprestados.Count >= 3)
            {
                throw new Exception ("O usuario já atingiu o numero máximo de livros emprestados.");
            }
        }
    }
}