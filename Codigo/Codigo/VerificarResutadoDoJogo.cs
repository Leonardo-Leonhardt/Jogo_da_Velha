using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo
{
    internal class VerificarResutadoDoJogo
    {
        public static string VerificarResutado(char[,] tabuleito)
        {
            char[,] vitoria = {
            { '0', '1', '2' }, { '3', '4', '5' }, { '6', '7', '8' },
            { '0', '3', '6' }, { '1', '4', '7' }, { '2', '5', '8' },
            { '0', '4', '8' }, { '2', '4', '6' }
            };

            //foreach (var linha in vitoria)
            //{
            //    if (tabuleito[linha[0]] == tabuleito[linha[1]] && tabuleito[linha[1]] == tabuleito[linha[2]])
            //    {
            //        return tabuleito[linha[0]].ToString();
            //    }
            //}






            return "teste";
        }
    }
}
