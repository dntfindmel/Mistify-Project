// Mystify
string mensagemBoasVindas = "Boas vindas ao Mystify!";

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"


█▀▄▀█ █▄█ █▀ ▀█▀ █ █▀▀ █▄█
█░▀░█ ░█░ ▄█ ░█░ █ █▀░ ░█░
");
    Console.WriteLine(mensagemBoasVindas);
}

void exibirOpcoesMenu()
{
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
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); 
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
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

ExibirMensagemBoasVindas();
exibirOpcoesMenu();