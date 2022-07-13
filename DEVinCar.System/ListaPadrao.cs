using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class ListaPadrao
    {
        internal static void CriarLista(VeiculoFactory veiculoFactory)
        {
            IVeiculo carro1 = veiculoFactory.CriarCarro(120, 4, ETipoCombustivelCarro.Gasolina, "Uno", "CCC-0001", 30000, "Vermelha", DateTime.Now);
            IVeiculo carro2 = veiculoFactory.CriarCarro(100, 2, ETipoCombustivelCarro.Flex, "Ka", "CCC-0002", 40000, "Azul", DateTime.Now);
            IVeiculo carro3 = veiculoFactory.CriarCarro(140, 4, ETipoCombustivelCarro.Flex, "HB20", "CCC-0003", 50000, "Preta", DateTime.Now);
            carro1.VenderVeiculo(DateTime.Now, 123123123);
            carro3.VenderVeiculo(DateTime.Now, 123123123);


            IVeiculo moto1 = veiculoFactory.CriarMotoTriciclo(60, 2, "Biz", "MMM-0001", 5000, "Azul", DateTime.Now);
            IVeiculo moto2 = veiculoFactory.CriarMotoTriciclo(80, 2, "CG", "MMM-0002", 5000, "Preta", DateTime.Now);
            IVeiculo moto3 = veiculoFactory.CriarMotoTriciclo(60, 3, "Triciclo", "MMM-0001", 5000, "Azul", DateTime.Now);
            moto2.VenderVeiculo(DateTime.Now, 12312313);
            moto3.VenderVeiculo(DateTime.Now, 12312313);

            IVeiculo camionete1 = veiculoFactory.CriarCamionete(4, 40, 130, ETipoCombustivelCamionete.Gasolina, "Saveiro", "CAM-0001", 80000, DateTime.Now);
            IVeiculo camionete2 = veiculoFactory.CriarCamionete(4, 40, 130, ETipoCombustivelCamionete.Diesel, "Hilux", "CAM-0002", 180000, DateTime.Now);
            IVeiculo camionete3 = veiculoFactory.CriarCamionete(4, 40, 130, ETipoCombustivelCamionete.Diesel, "Ranger", "CAM-0003", 120000, DateTime.Now);
            camionete1.VenderVeiculo(DateTime.Now, 123123123);
            camionete2.VenderVeiculo(DateTime.Now, 123123123);
        }
    }
}
