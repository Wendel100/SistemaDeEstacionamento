internal class Program
{
    public static void Main(string[] args)
    {
        string carro;
        List<string> Veiculo = new List<string>();

        Console.WriteLine("preço inicia");
        int preco_inicial = int.Parse(Console.ReadLine());
        Console.WriteLine("preço por/hora");
        int preco_hora = int.Parse(Console.ReadLine());
        int total = preco_hora * preco_inicial;
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
                        Console.WriteLine($"lista {lista_veiculos} + preço final {total}");
                    }
                    Console.WriteLine("continuar");
                    opcao = Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("encerrando....");
                    break;

            }

        }




    }
}