using System;
using System.Collections.Generic;
using System.Linq;

namespace BuscaDeLinguagens
{

    public class Linguagens
    {
        public List<Linguagem> linguagens;

        public Linguagens()
        {
            linguagens = new List<Linguagem>();
        }

        //Método de Adicionar Linguagem
        public void adicionarLinguagem(Linguagem linguagem)
        {
            linguagens.Add(linguagem);
        }

        //Método de Remover Linguagem
        public void removerLinguagem(Linguagem linguagem)
        {
            linguagens.Remove(linguagem);
        }

        //Buscando por nome utilizando StartsWith
        public Linguagem buscarLinguagemPorNome(string nome)
        {

            var linguagem = linguagens.FirstOrDefault(ling => ling.nome.StartsWith(nome)); //Utilizando StartsWith

            if (linguagem != null)
            {
                linguagem.imprimir();
                return linguagem;
            }

            return null;
        }

        //Buscando por ano com Equals
        public Linguagem buscarPorAno(int ano)
        {
            var linguagem = linguagens.FirstOrDefault(ling => ling.ano.Equals(ano)); //Utilizando Equals

            if (linguagem != null)
            {
                linguagem.imprimir();
                return linguagem;
            }

            return null;
        }

        //Buscando por nome do Desenvolvedor Chefe com Contains
        public Linguagem buscarPorDesenvolvedorChefe(string nomeDesenvolvedorChefe)
        {
            var linguagem = linguagens.FirstOrDefault(ling => ling.desenvolvedorChefe.Contains(nomeDesenvolvedorChefe)); //Utilizando Contains

            if (linguagem != null)
            {
                linguagem.imprimir();
                return linguagem;
            }

            return null;
        }

        //Buscando por nome do Predescessor com Contains
        public Linguagem buscarPorPredescessor(string nomePredescessor)
        {
            var linguagem = linguagens.FirstOrDefault(ling => ling.predecessores.Contains(nomePredescessor)); //Utilizando Contains

            if (linguagem != null)
            {
                linguagem.imprimir();
                return linguagem;
            }

            return null;
        }
    }

}