using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoPorHora;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
while (!decimal.TryParse(Console.ReadLine(), out precoInicial))
{
    Console.Write("Entrada inválida. Digite um número válido para o preço inicial: ");
}

Console.Write("Digite o preço por hora: ");
while (!decimal.TryParse(Console.ReadLine(), out precoPorHora))
{
    Console.Write("Entrada inválida. Digite um número válido para o preço por hora: ");
}

var es = new Estacionamento(precoInicial, precoPorHora);
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine(@"
Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

Console.WriteLine("O programa se encerrou.");
