using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            practica pr = new practica();
            String nombre = "";

            try
            {
                Console.WriteLine("Digite su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("su nombre es " + nombre);


            }
            catch (Exception)
            {

            }


            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                Console.WriteLine("digite un numero pocitivo para restar o uno negativo para sumar");
                nombre = Console.ReadLine();
                Int32.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("digite el numero primer numero que decea sumar/restar");
                Int32.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine("digite el numero segundo numero que decea sumar/restar");
                Int32.TryParse(Console.ReadLine(), out num3);

                Console.WriteLine("El resultado es " + pr.sumaresta(num1, num2, num3));
            }
            catch (Exception)
            {

            }



            Console.ReadLine();
        }
    }

}
