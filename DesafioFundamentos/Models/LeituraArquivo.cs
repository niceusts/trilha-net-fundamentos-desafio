using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class LeituraArquivo
    {
        // public (bool sucesso, string[] linhasArquivo, int quantidadeLinhas) LerArquivo(string caminho)
        public (bool Sucesso, string[] LinhasArquivo, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }


        }
    }
}