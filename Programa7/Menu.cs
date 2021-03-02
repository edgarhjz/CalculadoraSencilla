using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa7
{
    public class Menu
    {
        Solicitud operacion = new Solicitud();

        public void muestraMenu() 
        {
            bool Salir = false;
            int opcion = 0;

            while (!Salir) 
            {
                Console.WriteLine(" ### Calculadora de 2 números enteros positivos ###");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("\nElige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: operacion.sumarNumeros();
                        break;
                    case 2: operacion.restarNumeros();
                        break;
                    case 3: operacion.multiplicarNumeros();
                        break;
                    case 4: operacion.dividirNumeros();
                        break;
                    case 5: Salir = true;
                        break;
                }
            } 
        }
    }
}
