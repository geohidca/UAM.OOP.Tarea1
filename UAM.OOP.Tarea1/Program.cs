using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            IReproductores reproductores = new VHS(); // Esto es el Poliformisfo lo que hace es que IReproductores usa los metodos de VHS
            Lista l = new Lista();

            // diferentes formas de instanciar y hacer llamados 
            

            l.Insertar(new DVD (1, "DVD"));
            l.Insertar(new Netflix() { ID = 1, Nombre = "Netflix" });

            VHS vHS = new VHS(1, "VHS");
            l.Insertar(vHS);


            var item = l.Buscar(0);
            if (item is DVD)   //CASTING --> Esto es un ejemplo de CASTING
            {
                Console.WriteLine(((DVD)item).ID);
                Console.WriteLine(((DVD)item).Nombre);
            }
            else if (item is VHS)   //CASTING --> Esto es un ejemplo de CASTING
            {
                Console.WriteLine(((VHS)item).ID);
                Console.WriteLine(((VHS)item).Nombre);
            }
            else if (item is Netflix)   //CASTING --> Esto es un ejemplo de CASTING
            {
                Console.WriteLine(((Netflix)item).ID);
                Console.WriteLine(((Netflix)item).Nombre);
            }
            Console.ReadKey();
        }
    }
}
