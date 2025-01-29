﻿using System.Text;

namespace Codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string caminhoArquivo = "../../Regras/Regras.txt";

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

			Console.WriteLine(conteudoDoArquivo.ToString());
			Console.ReadKey();
		}
    }
}
