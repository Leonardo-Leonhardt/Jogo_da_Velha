using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo
{
    internal class Jogador
    {
        #region Variáveis
        private string _nome;
        private int _pontuacao = 0;
        private Jogador _jogador;
        #endregion

        #region Metodos
        protected void EscolherJogador()
        {
            Console.WriteLine("Digite o nome do jogador: ");
            _nome = Console.ReadLine();

        }

        public void SetName(string nome)
        {
            _nome = nome;
        }
        #endregion
    }
}
