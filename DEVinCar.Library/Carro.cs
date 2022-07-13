using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class Carro : Veiculo
    {
        public int Potencia { get; set; }
        public int NumeroDePortas { get; set; }
        public ETipoCombustivelCarro TipoCombustivel { get; set; }

        public Carro(int potencia, int numeroDePortas, ETipoCombustivelCarro tipoCombustivel,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao) : base(nome, placa, valor, cor, dataDeFabricacao)
        {
            Potencia = potencia;
            NumeroDePortas = numeroDePortas;
            TipoCombustivel = tipoCombustivel;
        }


        public override string ListarInformacoes()
        {
            string mensagem = base.ListarInformacoes();

            mensagem +=
                $"\n      Potência: {Potencia} cv | {NumeroDePortas} portas" +
                $"\n      Tipo de combustível: {TipoCombustivel}";

            return mensagem;
        }
    }
}
