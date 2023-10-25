using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario {get; set;}

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Eu sou o profeesor {Nome}, tenho {Idade} e meu salario é {Salario}");
        }
    }
}