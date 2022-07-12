using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class MotoTriciclo : Veiculo
    {
        public int Potencia { get; set; }
        public int NumeroDeRodas { get; set; }

        public MotoTriciclo(int potencia, int numeroDeRodas, 
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao) : base(nome, placa, valor, cor, dataDeFabricacao)
        {
            Potencia = potencia;
            NumeroDeRodas = numeroDeRodas;
        }

        public override string ListarInformacoes()
        {
            string mensagem = base.ListarInformacoes();
            mensagem +=
                $"\nPotência: {Potencia}" +
                $"\nTipo: {(NumeroDeRodas == 2 ? "Moto" : "Triciclo")}";

            return mensagem;
        }
    }
}
