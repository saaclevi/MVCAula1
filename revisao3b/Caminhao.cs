using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao3b
{
    internal class Caminhao : IVeículo 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Eixos { get; set; }  

        public void InfoGeral()
        {
            Console.WriteLine("Marca do Caminhão: " + Marca);
            Console.WriteLine("Eixos: " + Eixos);
        }
    }
}
