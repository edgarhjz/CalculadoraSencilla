using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa7
{
    public class Solicitud
    {
        public void sumarNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            int sumando1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int sumando2 = Convert.ToInt32(Console.ReadLine());
            int resultado = sumando1 + sumando2;
            Console.WriteLine("El resultado de la suma es = {0}\n", resultado);
        }
        
        public void restarNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            int minuendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int sustraendo = Convert.ToInt32(Console.ReadLine());
            int resultado = minuendo + sustraendo;
            Console.WriteLine("El resultado de la resta es = {0}\n", resultado);
        }

        public void multiplicarNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            int multiplicando = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int multiplicador = Convert.ToInt32(Console.ReadLine());
            int resultado = multiplicando + multiplicador;
            Console.WriteLine("El resultado de la multiplicación es = {0}\n", resultado);
        }

        public void dividirNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            int dividendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int resultado = dividendo + divisor;
            Console.WriteLine("El resultado de la suma es = {0}\n", resultado);
        }
    }
}
