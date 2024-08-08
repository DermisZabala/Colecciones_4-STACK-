using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colecciones_STACK_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Personas = new Stack<string>();

            //Agregando elementos a la pila
            Personas.Push("Pepe");
            //Declarando un array para rellenar la pila
            string[] ALL_Nombres = new string[] {"Hamel","Lucas","Ana","Miguel","Sony"};

             

            //Rellenando la pila con los elementos que están almacenados en el array
            for (int i = 0; i<ALL_Nombres.Length; i++)
            {
                Personas.Push(ALL_Nombres[i]);
            }

            Console.WriteLine("Cantidad de elementos que tiene la PILA al comienzo");
            Console.WriteLine(Personas.Count);

            Console.WriteLine("\nPrimer elemento en salir de la PILA");
            Console.WriteLine(Personas.Peek());

            //Recorriendo la pila
            Console.WriteLine("\nRecorriendo la PILA con los elementos agregado del array 'ALL_Nombres'");
            foreach (string elementos in Personas)
            {
                Console.WriteLine(elementos);
            }

            //Quitando los 2 últimos elementos que entraron a la cola
            for(int i = 0; i<2; i++)
            {
                Personas.Pop();
            }
            Console.WriteLine();

            Console.WriteLine("\nRecorriendo la PILA luego de haber sacado los dos últimos elementos en entrar");
            foreach (string elementos in Personas)
            {
                Console.WriteLine(elementos);
            }
            
            //Copiando la colección 'Personas' en el array 'ALL_Nombres'
            ALL_Nombres = Personas.ToArray();

            Console.WriteLine("\nCopiando la PILA en el array 'ALL_Nombres'");
            foreach (string elementos in ALL_Nombres)
            {
                Console.WriteLine(elementos);
            }

            Console.WriteLine("\nPrimer elemento en salir de la PILA después de eliminar 2 elementos");
            Console.WriteLine(Personas.Peek());

            Console.WriteLine("\nCantidad de elementos en la PILA después de eliminar 2 elementos");
            Console.WriteLine(Personas.Count);


            //Sacando todos los elementos de la lista
            Console.WriteLine("\nUsando el método Clear para vaciar toda la PILA");
            Personas.Clear();

            Personas.Push("Carl");

            //Viendo si hay algun valor en el principio de la PILA
            Console.WriteLine("\nUsando el método 'TryPeek' para ver si hay algún elemento en la primera posición de la PILA");
            Console.WriteLine(Personas.TryPeek(out string s));

            //Sacando el ultimo elemento de la lista si es que la PILA tiene algun
            Console.WriteLine("\nSacando el ultimo elemento que entro a la PILA");
            Console.WriteLine(Personas.TryPop(out string a));

            /*Stack<int> numero = new Stack<int>();

            int[] numeros = new int[3] { 100, 200, 300 };

            int z = 0;

            for(int i = 0; i<3; i++)
            {
                numero.Push(z+=10);
            }

            Console.WriteLine("\nCopiando la pila en el array");
            numeros = numero.ToArray();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }*/



            Console.ReadKey();
        }
    }
}
