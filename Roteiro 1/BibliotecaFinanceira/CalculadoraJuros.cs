using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinanceira
{
    public class CalculadoraJuros
    {
        public double CalcularJurosSimples(double valorPrincipal, double taxaJuros, int tempo)
        {
            return valorPrincipal * taxaJuros * tempo;
        }
        internal double CalculoInterna(double valorPrincipal, double taxaJuros, int tempo)
        {
            return valorPrincipal * Math.Pow(1 + taxaJuros, tempo) - valorPrincipal;
        }
    }
}
