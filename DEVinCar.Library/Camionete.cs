using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class Camionete : Veiculo
    {
        public Camionete(string nome, string placa, double valor, string cor, DateTime dataDeFabricacao) : base(nome, placa, valor, cor, dataDeFabricacao)
        {
        }

        public int NumeroDePortas { get; set; }
        public int CapacidadeDaCacamba { get; set; }
        public int Potencia { get; set; }
        public string TipoCombustivel { get; set; } // ??

        public override string ListarInformacoes()
        {
            string mensagem = base.ListarInformacoes();
            mensagem +=
                $"\nNúmero de portas: {NumeroDePortas}" +
                $"\nPotência: {Potencia} cv" +
                $"\nCapacidade da caçamba: {CapacidadeDaCacamba} litros" +
                $"\nTipo de combustível: {TipoCombustivel}";

            return mensagem;
        }

        public override void AlterarCor(string novaCor)
        {
            throw new InvalidOperationException("Não é possível alterar a cor deste tipo de veículo");
        }
    }
}
