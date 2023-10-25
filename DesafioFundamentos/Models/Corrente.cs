using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Corrente : Conta
    {
        protected double Tarifa = 0.15;
        public override void Creditar(double valor)
        {
           saldo += valor;
        }
        
    }
}