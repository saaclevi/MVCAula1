using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao3b
{
    internal interface IVeículo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        int Ano { get; set; }
        string Placa { get; set; }

        void InfoGeral();
    }
}
