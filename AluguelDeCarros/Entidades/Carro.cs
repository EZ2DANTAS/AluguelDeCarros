using AluguelDeCarros.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Entidades
{
    internal class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public DateTime Ano { get; set; }
        public string Nome { get; set; }
        public CorCarro Cor { get; set; }
        public SituacaoDeDisponibilidade Situacao { get; set; }

        public DateTime? TempoDeContrato { get; set; } = null;

       

        public Carro() { }
        public Carro(string placa, string marca, DateTime ano, string nome, CorCarro cor)
        {
            Placa = placa;
            Marca = marca;
            Ano = ano;
            Nome = nome;
            Cor = cor;
            Situacao = Enum.Parse<SituacaoDeDisponibilidade>("Disponivel");
           
        }


    }
}
