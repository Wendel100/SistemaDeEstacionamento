internal class Program
{
    public static void Main(string[] args)
    {
        string carro;
        List<string> Veiculo = new List<string>();

        Console.WriteLine("preço inicia");
        double preco_inicial = double.Parse(Console.ReadLine());
        Console.WriteLine("preço por/hora");

        double preco_hora = double.Parse(Console.ReadLine());
        double total = preco_hora * preco_inicial;
        Console.Clear();

        Console.WriteLine("Opção: 1_cadastrar_viculo, 2_Remover_veiculo, 3_lista_veiculos, 4_encerrar");
       
         string opcao = Console.ReadLine();
        while (opcao!="4")
        {

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Nome do veiculo");
                    carro = Console.ReadLine();
                    Veiculo.Add(carro);
                    Console.WriteLine("continuar");
                    opcao = Console.ReadLine();
                    break;

                case "2":
                      Console.WriteLine("Nome do veiculo");
                    carro = Console.ReadLine();
                    Veiculo.Remove(carro);
                    Console.WriteLine("continuar");
                    opcao = Console.ReadLine();
                    break;

                case "3":
                    foreach (string lista_veiculos in Veiculo)
                    {
                        Console.WriteLine($"Placa de veiculos {lista_veiculos} + preço final {total}R$");
                    }
                    Console.WriteLine("continuar");
                    opcao = Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("encerrando....");
                    break;

                default:
                    Console.WriteLine("opção invalida");
                    break;

            }

        }




    }
}