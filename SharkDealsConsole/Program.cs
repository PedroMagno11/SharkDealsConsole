using SharkDealsConsole.Filtros;
using SharkDealsConsole.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        var jogos = JsonSerializer.Deserialize<List<Jogo>>(resposta)!;

        ExibirMenu(jogos);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void ExibirMenu(List<Jogo> jogos)
{
    Console.WriteLine("Digite 1 - Ver todos os jogos por ordem alfabética.");
    Console.WriteLine("Digite 2 - Ver todos os jogos filtrados por menores preços com desconto.");
    Console.WriteLine("Digite 3 - Ver todos os jogos filtrados por maiores preços com desconto.");   
    Console.WriteLine("Digite 4 - Ver todos os jogos filtrados por menores preços sem desconto.");
    Console.WriteLine("Digite 5 - Ver todos os jogos filtrados por maiores preços sem desconto.");
    Console.WriteLine("Digite 6 - Ver detalher de um jogo específico.");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.Clear();
            LinqFilter.FiltrarTodosOsJogosEmOrdemAlfabetica(jogos);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        case 2:
            Console.Clear();
            LinqFilter.FiltrarJogosPorMenorPrecoComDesconto(jogos);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        case 3:
            Console.Clear();
            LinqFilter.FiltrarJogosPorMaiorPrecoComDesconto(jogos);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        case 4:
            Console.Clear();
            LinqFilter.FiltrarJogosPorMenorPrecoSemDesconto(jogos);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        case 5:
            Console.Clear();
            LinqFilter.FiltrarJogosPorMaiorPrecoSemDesconto(jogos);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        case 6:
            Console.Clear();
            Console.Write("Informe o nome do jogo que deseja: ");
            string nomeDoJogo = Console.ReadLine()!;
            LinqFilter.ExibirDetalhesDeUmJogoEspecifico(jogos, nomeDoJogo);
            Console.ReadLine();
            Console.Clear();
            ExibirMenu(jogos);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}