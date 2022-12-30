//introdução
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial : ");
int precoInicial = int.Parse(Console.ReadLine());
Console.WriteLine("\nAgora digite o preço por hora: ");
int precoPorHora = int.Parse(Console.ReadLine());

//Variaveis
List<string> placas = new List<string>();
int precoFinal = 0;

//Menu
while(true){
Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veiculo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar ");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        placas.Add(Console.ReadLine());
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.WriteLine("O veículo foi cadastrado");
        Console.Clear();
        break;
    case "2":
        Console.WriteLine("Digite a placa do veículo para remover: ");
        
        string placaAtual = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        int horas = int.Parse(Console.ReadLine());
        precoFinal = precoInicial + (precoPorHora * horas);
        Console.WriteLine($"O veiculo {placaAtual} foi removido e o preço total foi de: {precoFinal} ");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        placas.Remove(placaAtual);
        Console.Clear();
        break;
    case "3":
        for (int i = 0; i < placas.Count;i++)
        {
            Console.WriteLine(placas[i]);
        }
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
        break;
    case "4":
        Console.WriteLine("O programa se encerrou");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
        Environment.Exit(0);

        break;
    default:
        Console.WriteLine("Copmando Invalido");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
        break;
}
}