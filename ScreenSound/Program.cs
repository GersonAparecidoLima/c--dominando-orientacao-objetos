﻿using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda vozDaVerdade = new Banda("Voz Da Verdade");
vozDaVerdade.AdicionarNota(new Avaliacao(10));
vozDaVerdade.AdicionarNota(new Avaliacao(8));
vozDaVerdade.AdicionarNota(new Avaliacao(6));
Banda dianteDoTrono = new("Diante Do Trono");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(vozDaVerdade.Nome, vozDaVerdade);
bandasRegistradas.Add(dianteDoTrono.Nome, dianteDoTrono);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    // int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    //int opcaoEscolhidaNumerica = int.TryParse(opcaoEscolhida);
        

    int opcaoEscolhidaNumerica;

    bool ehNumero = int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica);

    if (ehNumero)
    {
        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
            menuASerExibido.Executar(bandasRegistradas);
            if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }
    else
    {
       // Console.WriteLine("Não é um número válido.");
       // Console.Read();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}

ExibirOpcoesDoMenu();