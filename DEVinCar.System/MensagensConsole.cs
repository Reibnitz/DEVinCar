using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class MensagensConsole
    {
        public static void OpcoesIniciais()
        {
            Console.WriteLine("---------- Bem-vindo ao sistema DEVinCar ----------");
            Console.WriteLine("1- Adicionar veículo");
            Console.WriteLine("2- Buscar veículos no sistema");
        }

        public static void OpcoesDeVeiculosParaAdicionar()
        {
            Console.WriteLine("\n1- Moto/Triciclo");
            Console.WriteLine("2- Carro");  
            Console.WriteLine("3- Camionete");
        }

        public static void OpcoesGeraisDeListagem()
        {
            Console.WriteLine("\n1- Listar todos os veículos");
            Console.WriteLine("2- Listar veículos disponíveis");
            Console.WriteLine("1- Listar veículos vendidos");
        }

        public static void OpcoesDeVeiculosListagem()
        {
            Console.WriteLine("\n1- Motos/Triciclos");
            Console.WriteLine("2- Carros");
            Console.WriteLine("3- Camionetes");
            Console.WriteLine("4- Todos");
        }

        public static void OpcoesDeOrdemDePreco()
        {
            Console.WriteLine("\n1- Listar por menor preço vendido");
            Console.WriteLine("2- Listar por maior preço vendido");
        }
    }
}
