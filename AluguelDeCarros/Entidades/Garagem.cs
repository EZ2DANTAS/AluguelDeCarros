using AluguelDeCarros.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Entidades
{
    internal class Garagem : Carro
    {
        List<Carro> carros = new List<Carro>();

        public Garagem() { }

        public void AdicionarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        public void RemCarro(Carro carro)
        {
            carros.Remove(carro);
        }

        public void AlugarCarro(string placa)
        {
            try
            {

                Carro resultPlaca = carros.Find(x => x.Placa == placa);
                
                if (resultPlaca != null)
                {
                    DateTime agora = DateTime.Now;

                    Console.WriteLine("Dias de aluguel: ");
                    TimeSpan tempo = TimeSpan.Parse(Console.ReadLine());
                    DateTime FinalContrato = agora.AddDays(tempo.Days);

                    int position = carros.FindIndex(x => x.Situacao == SituacaoDeDisponibilidade.Disponivel); 
                    carros[position].Situacao = SituacaoDeDisponibilidade.Indisponivel;

                    int positionContrato = carros.FindIndex(x => x.TempoDeContrato == null);
                    carros[positionContrato].TempoDeContrato = FinalContrato;


                    Console.WriteLine("O Contrato se Encerra: "+ FinalContrato.ToString("dd/MM/yyyy HH:mm"));
                    Console.ReadLine();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            
        }

       

        public void ExibirCarros()
        {
            Console.WriteLine("1 - Carros Alugados");
            Console.WriteLine("2 - Carros Disponiveis");
            Console.WriteLine("3 - Todos os Carros");
            int op = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            if (op == 1)
            {
                foreach (Carro car in carros)
                {
                    if(car.Situacao == SituacaoDeDisponibilidade.Indisponivel)
                    {
                        sb.AppendLine("Nome: " + car.Nome);
                        sb.AppendLine("Marca: " + car.Marca);
                        sb.AppendLine("Placa: " + car.Placa);
                        sb.AppendLine("Cor: " + car.Cor);
                        sb.AppendLine("Ano: " + car.Ano.Year);
                        sb.AppendLine("Situação:  " + car.Situacao);
                        sb.AppendLine("Tempo de Contrato(dia de encerramento): " + car.TempoDeContrato.ToString());
                        sb.AppendLine("\n\n\n");
                    }
                }
            }else if (op == 2)
            {
                foreach (Carro car in carros)
                {
                    if (car.Situacao == SituacaoDeDisponibilidade.Disponivel)
                    {
                        sb.AppendLine("Nome: " + car.Nome);
                        sb.AppendLine("Marca: " + car.Marca);
                        sb.AppendLine("Placa: " + car.Placa);
                        sb.AppendLine("Cor: " + car.Cor);
                        sb.AppendLine("Ano: " + car.Ano.Year);
                        sb.AppendLine("Situação:  " + car.Situacao);
                        sb.AppendLine("Tempo de Contrato(dia de encerramento): " + car.TempoDeContrato.ToString());
                        sb.AppendLine("\n\n\n");
                    }
                }
            }else if(op == 3)
            {
                foreach (Carro car in carros)
                {
                        sb.AppendLine("Nome: " + car.Nome);
                        sb.AppendLine("Marca: " + car.Marca);
                        sb.AppendLine("Placa: " + car.Placa);
                        sb.AppendLine("Cor: " + car.Cor);
                        sb.AppendLine("Ano: " + car.Ano.Year);
                        sb.AppendLine("Situação:  " + car.Situacao);
                        sb.AppendLine("Tempo de Contrato(dia de encerramento): " + car.TempoDeContrato.ToString());
                        sb.AppendLine("\n\n\n");
                }
            }
            else
            {
                Console.WriteLine("DIGITE CORRETAMENTE");
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }



    }
}
