using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorRacional
{
    class Program
    {
        static void Main(string[] args)
        {
            var (valor1, valor2, valor3) = (10, 1, 2);

            Console.WriteLine("los valores son: " +valor1+valor2+valor3);

            //== igual as 
            //!= diferente as 
            //> mayor que 
            //< menor que
            //>= mayor o igual 
            //<= menor igual


            bool resultado1 = valor1 == valor2;
            Console.WriteLine("El resultado de la comparacion: "+resultado1);

            bool resultado2 = valor1 != valor2;
            Console.WriteLine("El resultado de la comparacion: " + resultado2);

            Console.ReadKey();
        }
    }
}
