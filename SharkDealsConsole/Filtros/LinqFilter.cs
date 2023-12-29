using SharkDealsConsole.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkDealsConsole.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsJogosEmOrdemAlfabetica(List<Jogo> jogos)
        {
            var todosOsJogos = jogos.OrderBy(jogo=>jogo.Nome).ToList();
            foreach (Jogo jogo in todosOsJogos) 
            {
                Console.WriteLine($" - {jogo.Nome}") ;
            }
        }
        
        public static void FiltrarJogosPorMenorPrecoComDesconto(List<Jogo> jogos)
        {
            var jogosPorMenorPreco = jogos.OrderBy(jogo => jogo.PrecoDeVenda).ToList();
            Console.WriteLine("Jogos por menor preço com desconto:");
            foreach(Jogo jogo in jogosPorMenorPreco)
            {
                Console.WriteLine($" - {jogo.Nome} - {jogo.PrecoDeVenda}");
            }
        }

        public static void FiltrarJogosPorMenorPrecoSemDesconto(List<Jogo> jogos)
        {
            var jogosPorMenorPreco = jogos.OrderBy(jogo => jogo.PrecoNormal).ToList();
            Console.WriteLine("Jogo por menor preço sem desconto:");
            foreach(Jogo jogo in jogosPorMenorPreco)
            {
                Console.WriteLine($" - {jogo.Nome} - {jogo.PrecoNormal}");
            }
        }

        public static void FiltrarJogosPorMaiorPrecoComDesconto(List<Jogo> jogos) 
        {
            var jogosPorMaiorPreco = jogos.OrderByDescending(jogo => jogo.PrecoDeVenda).ToList();
            Console.WriteLine("Jogos por maior preço com desconto:");
            foreach(Jogo jogo in jogosPorMaiorPreco)
            {
                Console.WriteLine($" - {jogo.Nome} = {jogo.PrecoDeVenda}");
            }
        }

        public static void FiltrarJogosPorMaiorPrecoSemDesconto(List<Jogo> jogos)
        {
            var jogosPorMaiorPreco = jogos.OrderByDescending(jogo => jogo.PrecoNormal).ToList();
            Console.WriteLine("Jogos por maior preço sem desconto:");
            foreach(Jogo jogo in jogosPorMaiorPreco)
            {
                Console.WriteLine($" - {jogo.Nome} - {jogo.PrecoNormal}");
            }
        }
        public static void ExibirDetalhesDeUmJogoEspecifico(List<Jogo> jogos, string nomeDoJogo)
        {
            if (jogos.Exists(jogo => jogo.Nome == nomeDoJogo))
            {
                Jogo game = jogos.Find(jogo => jogo.Nome == nomeDoJogo);
                Console.WriteLine($"Detalhes do jogo {game.Nome}:");
                Console.WriteLine(game);

            }
            else
            {
                Console.WriteLine("Jogo não encontrado!");
            }
        }
    }
}
