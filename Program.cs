using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaDeLinguagens
{
    internal class Program
    {
        static void Main()
        {

            Linguagens lista = new Linguagens();

            //Adicionando Linguagem a lista Linguagens
            lista.adicionarLinguagem(new Linguagem(1990, "AMOS BASIC", "François Lionet, Constantin Sotiropoulos", "STO BASIC"));
            lista.adicionarLinguagem(new Linguagem(1991, "Visual Basic", "Alan Cooper", "QuickBasic"));
            lista.adicionarLinguagem(new Linguagem(1995, "Ruby", "Yukihiro Matsumoto", "Smalltak;Perl"));
            lista.adicionarLinguagem(new Linguagem(2009, "Go", "Google", "C;Oberon;Limbo;Smalltalk"));
            lista.adicionarLinguagem(new Linguagem(2023, "LinguagemRemovida", "LinguagemRemovida", "LinguagemRemovida"));
            lista.adicionarLinguagem(new Linguagem());

            //Removendo a última Linguagem adicionada
            lista.removerLinguagem(lista.linguagens[4]);

            //Buscando por nome e imprimindo
            lista.buscarLinguagemPorNome("Visual").imprimir();

            //Buscando por ano e imprimindo
            lista.buscarPorAno(0).imprimir();

            //Buscando Desenvolvedor chefe e imprimindo
            lista.buscarPorDesenvolvedorChefe("Matsumoto").imprimir();

            //Buscando por Predescessor e imprimindo
            lista.buscarPorPredescessor("Smalltalk").imprimir();


            Console.ReadKey();
               
        }
    }
}
