// Mystify
using System.ComponentModel.DataAnnotations;

string mensagemBoasVindas = "Boas vindas ao Mystify!";
// List<string> listaBandas = new List<string> { "Twenty One Pilots"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"


█▀▄▀█ █▄█ █▀ ▀█▀ █ █▀▀ █▄█
█░▀░█ ░█░ ▄█ ░█░ █ █▀░ ░█░
");
    Console.WriteLine(mensagemBoasVindas);
}

void exibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] para registrar uma banda");
    Console.WriteLine("Digite [2] para mostrar todas as bandas");
    Console.WriteLine("Digite [3] para avaliar uma banda");
    Console.WriteLine("Digite [4] para exibir a média de uma banda");
    Console.WriteLine("Digite [-1] para sair do menu");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInt)
    {
        case 1: registrarBanda(); 
            break;
        case 2: mostrarBandas();
            break;
        case 3:
            avaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
            break;
        case -1:
            Console.WriteLine("Até logo! =)");
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
}

void registrarBanda()
{
    Console.Clear();
    exibirTituloOpcao("Registro das Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesMenu();
}

void mostrarBandas()
{
    Console.Clear();
    exibirTituloOpcao("Exibindo Bandas Registradas");

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nClique em qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();

    exibirOpcoesMenu();
}

void exibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string decoracao = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(decoracao);
    Console.WriteLine(titulo);
    Console.WriteLine(decoracao + "\n");
}

void avaliarBanda(){
    Console.Clear();
    exibirTituloOpcao("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"Digite sua nota para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("\nClique em qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesMenu();
    }
}

exibirOpcoesMenu();