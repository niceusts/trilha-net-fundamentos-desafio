using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
        public int Serie {get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome}, Tenho {Idade} e sou {Serie}º serie");
        }

    }
}

// CLASSE SELADA É O FINAL DA HERANÇA. NINGUEM PODE HERDAR DELA, MAS O INVERSO PODE.