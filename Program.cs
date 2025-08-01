﻿// See https://aka.ms/new-console-template for more information
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();

void ExibirLogo()
{
  Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
  Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("Digite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostra todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      RegistrarBanda();
      break;
    case 2:
      Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
      break;
    case 3:
      Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
      break;
    case 4:
      Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
      break;
    case -1:
      Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
      break;
  }
}

void RegistrarBanda()
{
  Console.Clear();
  Console.WriteLine("Registro de bandas");
  Console.Write("Digite o nome da banda que quer registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  listaDasBandas.Add(nomeDaBanda);
  Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();

}

ExibirLogo();
ExibirOpcoesDoMenu();