using System;
using System.Collections.Generic;

namespace BuscaDeLinguagens
{
    public class Linguagem
    {
        public int ano;
        public string nome;
        public string desenvolvedorChefe;
        public string predecessores;

        public Linguagem()
        {
        }

        public Linguagem(int ano, string nome, string desenvolvedorChefe, string predecessores)
        {
            this.ano = ano;
            this.nome = nome;
            this.desenvolvedorChefe = desenvolvedorChefe;
            this.predecessores = predecessores;
        }

        //Imprime a linguagem - Se seu nome for nulo, ela retorna null.
        public void imprimir()
        {

            if (nome != null)
            {
                Console.WriteLine("\n----------------------------------------------------------------------");
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Ano de Cria��o: {ano}");
                Console.WriteLine($"Desenvolvedor Chefe: {desenvolvedorChefe}");
                Console.WriteLine($"Predecessores: {predecessores}");
                Console.WriteLine("----------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nnull");
            }

        }
    }
}