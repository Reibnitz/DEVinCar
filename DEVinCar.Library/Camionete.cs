using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class Camionete : Veiculo
    {

        public int NumeroDePortas { get; set; }
        public int CapacidadeDaCacamba { get; set; }
        public int Potencia { get; set; }
        public string TipoCombustivel { get; set; } // ??
        public const string Cor = "roxa";

        public Camionete(int numeroDePortas, int capacidadeDaCacamba, int potencia, string tipoCombustivel,
            string nome, string placa, double valor, DateTime dataDeFabricacao) : base(nome, placa, valor, Cor, dataDeFabricacao)
        {
            NumeroDePortas = numeroDePortas;
            CapacidadeDaCacamba = capacidadeDaCacamba;
            Potencia = potencia;
            TipoCombustivel = tipoCombustivel;
        }

        public override string ListarInformacoes()
        {
            string mensagem = base.ListarInformacoes();
            mensagem +=
                $"\n      Potência: {Potencia} cv | {NumeroDePortas} portas" +
                $"\n      Capacidade da caçamba: {CapacidadeDaCacamba} litros | Tipo de combustível: {TipoCombustivel}";

            return mensagem;
        }

        public override void AlterarCor(string novaCor)
        {
            throw new InvalidOperationException("Não é possível alterar a cor deste tipo de veículo");
        }
    }
}
