// Mystify
string mensagemBoasVindas = "Boas vindas ao Mystify!";
List<string> listaBandas = new List<string> { "Twenty One Pilots"};

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
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
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
    Console.WriteLine("******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesMenu();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("Exibindo bandas registradas");
    Console.WriteLine("***************************");

    foreach(string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nClique em qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();

    exibirOpcoesMenu();
}

exibirOpcoesMenu();