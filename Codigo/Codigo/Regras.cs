using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo
{
	internal class Regras
	{

		public override string ToString()
		{
			string caminhoArquivo = "../../../Regras/Regras.txt";

			StringBuilder conteudoDoArquivo = new StringBuilder();

			try
			{
				using (StreamReader sr = new StreamReader(caminhoArquivo))
				{

					string linha;

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
	}
}