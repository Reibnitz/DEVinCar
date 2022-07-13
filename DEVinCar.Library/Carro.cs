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
        public bool EhFlex { get; set; }

        public Carro(int potencia, int numeroDePortas, bool ehFlex,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao) : base(nome, placa, valor, cor, dataDeFabricacao)
        {
            Potencia = potencia;
            NumeroDePortas = numeroDePortas;
            EhFlex = ehFlex;
        }


        public override string ListarInformacoes()
        {
            string mensagem = base.ListarInformacoes();

            mensagem +=
                $"\n      Potência: {Potencia} cv | {NumeroDePortas} portas" +
                $"\n      Tipo de combustível: ";

            mensagem += EhFlex ? "Flex" : "Gasolina";

            return mensagem;
        }
    }
}
