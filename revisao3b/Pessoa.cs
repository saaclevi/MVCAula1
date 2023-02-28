using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao3b
{
    internal class Pessoa
    {
        /*private int Id;
        public int GetId()
        {
            return Id;
        }
        public int SetId()
        {
            ID = Id;
        }

        public int GetId()
        {
            return Id;
        */

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        /*public Pessoa(string email, string nome)
        {
            Email = email;
            Nome = nome;
        }*/

        public void GetInfo()
        {
            Console.WriteLine("Info : " + Nome);
        }
        public void GetInfo(string nome)
        {
            Console.WriteLine("Nome: " + nome);
        }
    }
}
