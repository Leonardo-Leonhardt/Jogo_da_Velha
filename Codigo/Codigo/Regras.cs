using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo
{
    internal class Regras
    {
        #region Leitura de arquivo

        /// <summary>
        /// Metodo para ler o arquivo de regras.
        /// </summary>
        /// <returns>Retorna uma string com as regras.</returns>
        public string LerArquivo()
        {
            string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoProjeto = Path.GetFullPath(Path.Combine(diretorioAtual, "..", "..", "..", "..", ".."));

            string caminhoArquivo = Path.Combine(caminhoProjeto, "Regras", "Regras.txt");

            StringBuilder conteudoDoArquivo = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string? linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        conteudoDoArquivo.AppendLine(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao ler o arquivo:");
                Console.WriteLine(ex.ToString());
            }
            return conteudoDoArquivo.ToString();
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}