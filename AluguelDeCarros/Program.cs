using AluguelDeCarros.Entidades;
using AluguelDeCarros.Entidades.Enums;
using System;


namespace AluguelDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Garagem garagem = new Garagem();
            char continuar;
            do
            {
                Console.WriteLine("digite a opção desejada: ");

                Console.WriteLine("1 - Cadastrar Veiculo");
                Console.WriteLine("2 - Exibir Veiculos");
                Console.WriteLine("3 - Alugar Veiculo");
                Console.WriteLine("4 - Remover Veiculo");
                Console.WriteLine();
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Placa: (YYY1234)");
                        string placa = Console.ReadLine().ToLower();

                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();

                        Console.Write("Ano: (YYYY)");
                        DateTime ano = DateTime.Parse(Console.ReadLine());

                        Console.Write("Cor: ");
                        CorCarro cor = Enum.Parse<CorCarro>(Console.ReadLine());

                        garagem.AdicionarCarro(new Carro(placa, marca, ano, nome, cor));
                        break;

                    case 2:
                        Console.Clear();
                        garagem.ExibirCarros();
                        break;

                    case 3:

                        Console.WriteLine("Digite a placa do carro");
                        string placaAlugar = Console.ReadLine().ToLower();
                        garagem.AlugarCarro(placaAlugar);
                        break;

                    default:
                        Console.WriteLine("Digite corretamente !");
                        break;
                }

                Console.WriteLine("Aperte (S) depois confirme com Enter para continuar");
                continuar = char.Parse(Console.ReadLine().ToLower());

                while (continuar != 's')
                {
                    Console.WriteLine("Digite corretamente !!!");
                    Console.WriteLine("Aperte (S) depois confirme com Enter para continuar");
                    continuar = char.Parse(Console.ReadLine().ToLower());
                }

                Console.Clear();

            } while (continuar == 's');
        }
    }
}