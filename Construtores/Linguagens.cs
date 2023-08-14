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
            Linguagem linguagemEncontrada = new Linguagem();

            foreach(var linguagem in linguagens)
            {
                if (linguagem.nome != null) //Confere se o nome da linguagem não é nulo
                {
                    if (linguagem.nome.StartsWith(nome)) //Utilizando o StartsWith
                    {
                        linguagemEncontrada = linguagem;
                        break;
                    }
                }
            }

            return linguagemEncontrada;
        }

        //Buscando por ano com Equals
        public Linguagem buscarPorAno(int ano)
        {
            Linguagem linguagemEncontrada = new Linguagem();

            foreach (var linguagem in linguagens)
            {
                if (linguagem.ano.Equals(ano)) //Utilizando Equals
                {
                    linguagemEncontrada = linguagem;
                    break;
                }
            }

            return linguagemEncontrada; //Retornando Linguagem
        }

        //Buscando por nome do Desenvolvedor Chefe com Contains
        public Linguagem buscarPorDesenvolvedorChefe(string nomeDesenvolvedorChefe)
        {
            Linguagem linguagemEncontrada = new Linguagem();

            foreach (var linguagem in linguagens)
            {
                if (linguagem.desenvolvedorChefe != null) //Confere se a linguagem tem um desenvolvedor chefe como atributo
                {
                    if (linguagem.desenvolvedorChefe.Contains(nomeDesenvolvedorChefe)) //Utilizando Contains
                    {
                        linguagemEncontrada = linguagem;
                        break;
                    }
                }
            }

            return linguagemEncontrada; //Retornando Linguagem
        }

        //Buscando por nome do Predescessor com Contains
        public Linguagem buscarPorPredescessor(string nomePredescessor)
        {
            Linguagem linguagemEncontrada = new Linguagem();

            foreach (var linguagem in linguagens)
            {
                if (linguagem.predecessores != null) //Confere se a linguagem tem um desenvolvedor predescessor como atributo
                {
                    if (linguagem.predecessores.Contains(nomePredescessor)) //Utilizando Contains
                    {
                        linguagemEncontrada = linguagem;
                        break;
                    }
                }
            }

            return linguagemEncontrada;
        }
    }

}