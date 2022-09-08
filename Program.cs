using sistema_de_estacionamento_CSharp.src.Models;

decimal precoInicial;
decimal precoPorHora;

Console.WriteLine($"Seja bem vindo ao sistema de estacionamento!\n");

Console.WriteLine($"Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"\nAgora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu){

    Console.Clear();
    Console.WriteLine("Escolha a opção desejada:");
    Console.WriteLine("1 - Cadastro de veículo");
    Console.WriteLine("2 - Remoção de veículo");
    Console.WriteLine("3 - Lista de veículos cadastrados");
    Console.WriteLine("4 - Encerramento do sistema");

    switch (Console.ReadLine()) {

        case "1":
        estacionamento.AdicionarVeiculo();
        break;

        case "2":
        estacionamento.RemoverVeiculo();
        break;

        case "3":
        estacionamento.ListarVeiculos();
        break;

        case "4":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção inválida!");
        break;

    }
        
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O sistema foi encerrado");
