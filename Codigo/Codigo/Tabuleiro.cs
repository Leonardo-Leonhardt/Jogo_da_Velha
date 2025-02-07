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
        static char[] tabuleiro = {
            '0', '1', '2',
            '3', '4', '5',
            '6', '7', '8' 
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
            int index = jogada - '0';

            var validacao = Validarjogada(index);

            if (validacao)
            {
                tabuleiro[index] = simbulo;
            }
            else
            {
                Console.WriteLine("Jogada invalida");
            }
        }

        /// <summary>
        /// Metodo para validar a jogada.
        /// </summary>
        /// <param name="jogada"></param>
        /// <returns></returns>
        public bool Validarjogada(int jogada)
        {
            for (int i = 0; i < tabuleiro.Length; i++)
            {
                if (tabuleiro[jogada] != 'X' || tabuleiro[jogada] != 'O')
                {
                    return true;
                }
            }

            return false;

        }

        /// <summary>
        /// Metodo para imprimir o tabuleiro.
        /// </summary>
        public void ImprimirTabuleiro()
        {
            Console.Clear();
            Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");

        }
        public void TabuleiroVelha()
        {
            Console.WriteLine("");
        }
        #endregion
    }
}
