using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vicky ID");

            int altura = 168;
            int edad = 89;
            string name = "Vicky";
            String info = "Nacio en NY, estudia ingeniería";
            var hobby = "deportista";

            string tarjetaId = $"La informacion de Vicky es la siguiente su edad s 89 años, su aluraq es 168";
            Console.WriteLine(info  );

            Console.ReadKey();

        }
    }
}
