using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Id = 1, Nome = "Paulo", Email = "Test@gmail.com"};
                    //p.Nome = "Junior";
                    //p.Id = 1;
                    //p.Email = "test@gmail.com";
            Console.WriteLine("Nome:" + p.Nome);
            Console.WriteLine("ID:" + p.Id);
            Console.WriteLine("Email:" + p.Email);

            p.GetInfo();
            p.GetInfo("Humberto");
        }
    }
}
