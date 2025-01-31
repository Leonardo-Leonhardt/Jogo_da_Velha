using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo
{
    internal class Tabuleiro
    {
        #region Variáveis
        static char[,] tabuleiro = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };
        #endregion

        #region Metodos 
        /// <summary>
        /// Metodo para lançar a jogada no tabuleiro.
        /// </summary>
        /// <param name="jogada"></param>
        /// <param name="simbulo"></param>
        public void LancaJogado(char jogada, char simbulo)
        {
            for(int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(tabuleiro[i,j] == jogada)
                    {
                        tabuleiro[i, j] = simbulo;
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para imprimir o tabuleiro.
        /// </summary>
        public void ImprimirTabuleiro()
        {
            Console.Clear();
            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]} ");

        }
        public void TabuleiroVelha()
        {
            Console.WriteLine("");
        }
        #endregion
    }
}
