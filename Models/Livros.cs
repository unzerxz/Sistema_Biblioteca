using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_biblioteca.Models
{
    public class Livros
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string ISBN { get; set; }

        public bool Disponivel { get; set; }

        public int Id { get; set; }

        public Livros(string Titulo, string Autor, string ISBN, bool Disponivel)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = ISBN;
            this.Disponivel = Disponivel;
        }


        public void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}");

            Console.WriteLine($"Autor: {Autor}");

            Console.WriteLine($"Codigo: {ISBN}");

            Console.WriteLine($"Id: {Id}");
        }



        public void MarcarComoEmprestado()
        {

            Disponivel = false;
        }

        public void MarcarComoDevolvido()
        {
            Disponivel = true;
        }

    }

}