using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificareUtilizatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "\0";
            //string password = "\0";
            //Console.WriteLine("Username:");
            //name = Console.ReadLine();
            //Console.WriteLine("Password");
            //password = Console.ReadLine();

            DAO abc = new DAO();
            if (abc.login(new Utilizator("Theo", "1234", "Windows")))
                Console.WriteLine("A mers!");
            if (abc.login(new Utilizator("Theo", "1234215", "Windows"))) 
                Console.WriteLine("a mers");


        }
    }
}
