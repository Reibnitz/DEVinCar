using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class MensagensConsole
    {
        public static EOpcaoInicial EscolherOpcaoInicial()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine
            ("   ___     ___   __   __    _              ___                   \n" +
            "  |   \\   | __|  \\ \\ / /   (_)    _ _     / __|   __ _      _ _\n" +
            "  | |) |  | _|    \\ V /    | |   | ' \\   | (__   / _` |    | '_| \n" +
            "  |___/   |___|   _\\_/_   _|_|_  |_||_|   \\___|  \\__,_|   _|_|_  \n" +
            "_|\"\"\"\"\"|_|\"\"\"\"\"|_| \"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|\n" +
            "\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-' ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n   Sistema de controle de veículos\n");
            Console.WriteLine("     [1] Adicionar veículo");
            Console.WriteLine("     [2] Buscar veículos no sistema");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoInicial)opcaoEscolhida;
        }

        public static EOpcaoTipoVeiculo EscolherOpcaoDeVeiculoParaAdicionar()
        {
            Console.WriteLine("\n   Adicionar veículo\n");
            Console.WriteLine("     [1] Moto/Triciclo");
            Console.WriteLine("     [2] Carro");
            Console.WriteLine("     [3] Camionete");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 3);

            return (EOpcaoTipoVeiculo)opcaoEscolhida;
        }

        public static void CriarMotoTriciclo(IVeiculoFactory veiculoFactory)
        {
            string nome = DefinirValorTexto("   Informe o modelo: ");
            string placa = DefinirValorTexto("   Informe a placa: ");
            double valor = DefinirValorNumerico("   Informe o preço: ");
            string cor = DefinirValorTexto("   Informe a cor: ");
            DateTime dataDeFabricacao = DefinirData("   Informe a data de fabricação [dd/mm/aaaa]: ");
            int potencia = (int)DefinirValorNumerico("   Informe a potência: ");
            int numeroRodas = (int)DefinirValorNumerico("   Informe o número de rodas: ");

            IVeiculo motoTriciclo = veiculoFactory.CriarMotoTriciclo(potencia, numeroRodas, nome, placa, valor, cor, dataDeFabricacao);

            Console.WriteLine("\n   Veículo adicionado com sucesso");
            Console.WriteLine($"        {motoTriciclo}");
        }

        public static void CriarCarro(IVeiculoFactory veiculoFactory)
        {
            string nome = DefinirValorTexto("   Informe o modelo: ");
            string placa = DefinirValorTexto("   Informe a placa: ");
            double valor = DefinirValorNumerico("   Informe o preço: ");
            string cor = DefinirValorTexto("   Informe a cor: ");
            DateTime dataDeFabricacao = DefinirData("   Informe a data de fabricação [dd/mm/aaaa]: ");
            int potencia = (int)DefinirValorNumerico("   Informe a potência: ");
            int numeroDePortas = (int)DefinirValorNumerico("   Informe o número de portas: ");
            ETipoCombustivelCarro tipoCombustivel = (ETipoCombustivelCarro)DefinirCombustivel("   Informe o tipo de combustível [1] Gasolina | [2] Flex: ");

            IVeiculo carro = veiculoFactory.CriarCarro(potencia, numeroDePortas, tipoCombustivel, nome, placa, valor, cor, dataDeFabricacao);

            Console.WriteLine("\n   Veículo adicionado com sucesso");
            Console.WriteLine($"        {carro}");
        }

        public static void CriarCamionete(IVeiculoFactory veiculoFactory)
        {
            string nome = DefinirValorTexto("   Informe o modelo: ");
            string placa = DefinirValorTexto("   Informe a placa: ");
            double valor = DefinirValorNumerico("   Informe o preço: ");
            DateTime dataDeFabricacao = DefinirData("   Informe a data de fabricação [dd/mm/aaaa]: ");
            int numeroDePortas = (int)DefinirValorNumerico("   Informe o número de portas: ");
            int capacidadeDaCacamba = (int)DefinirValorNumerico("   Informe a capacidade da caçamba: ");
            int potencia = (int)DefinirValorNumerico("   Informe a potência: ");
            ETipoCombustivelCamionete tipoCombustivel = (ETipoCombustivelCamionete)DefinirCombustivel("   Informe o tipo de combustível [1] Gasolina | [2] Diesel: ");

            IVeiculo camionete = veiculoFactory.CriarCamionete(numeroDePortas, capacidadeDaCacamba, potencia, tipoCombustivel, nome, placa, valor, dataDeFabricacao);

            Console.WriteLine("\n   Veículo adicionado com sucesso");
            Console.WriteLine($"        {camionete}");
        }

        private static DateTime DefinirData(string mensagem)
        {
            Console.Write(mensagem);
            string? input = Console.ReadLine();

            bool respostaValida = DateTime.TryParse(input, out DateTime data);
            if (!respostaValida)
                throw new InputInvalidoException(input);

            return data;
        }

        private static double DefinirValorNumerico(string mensagem)
        {
            Console.Write(mensagem);
            string? input = Console.ReadLine();

            bool respostaValida = double.TryParse(input, out double valor);
            if (!respostaValida)
                throw new InputInvalidoException(input);

            return valor;
        }

        private static string DefinirValorTexto(string mensagem)
        {
            Console.Write(mensagem);

            string? valorTexto = Console.ReadLine();
            if (valorTexto == null)
                throw new InputInvalidoException(valorTexto);

            return valorTexto;
        }

        private static int DefinirCombustivel(string mensagem)
        {
            Console.Write(mensagem);
            int valorInformado = VerificarInput(limite: 2);

            return valorInformado;
        }

        public static EOpcaoListagem EscolherOpcaoDeListagem()
        {
            Console.WriteLine("\n   Buscar veículos no sistema\n");
            Console.WriteLine("     [1] Listar todos os veículos");
            Console.WriteLine("     [2] Listar todas as Motos/Triciclos");
            Console.WriteLine("     [3] Listar todos os Carros");
            Console.WriteLine("     [4] Listar todos os Camionetes");
            Console.WriteLine("     [5] Listar veículos disponíveis");
            Console.WriteLine("     [6] Listar veículos vendidos");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 6);

            return (EOpcaoListagem)opcaoEscolhida;
        }

        public static EOpcaoOrdenacao EscolherOpcaoDeOrdenacao()
        {
            Console.WriteLine("\n   Definir ordenação da lista\n");
            Console.WriteLine("     [1] Listar por menor preço vendido");
            Console.WriteLine("     [2] Listar por maior preço vendido");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoOrdenacao)opcaoEscolhida;
        }

        public static bool DesejaContinuar()
        {
            Console.WriteLine("\n   Deseja realizar outra operação?\n");
            Console.WriteLine("     [1] Sim");
            Console.WriteLine("     [2] Não");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return opcaoEscolhida == 1 ? true : false;
        }

        private static int VerificarInput(int limite)
        {
            string? input = Console.ReadLine();
            bool respostaValida = int.TryParse(input, out int opcaoEscolhida);

            if (!respostaValida)
                throw new InputInvalidoException(input);
            if (opcaoEscolhida > limite)
                throw new OpcaoNaoExistenteException(opcaoEscolhida);

            return opcaoEscolhida;
        }
    }
}
