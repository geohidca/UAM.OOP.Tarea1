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
            Lista lista = new Lista();

            // diferentes formas de instanciar y hacer llamados 
            VHS vHS = new VHS(1, "VHS");
            lista.Insertar(vHS);

            lista.Insertar(new DVD (1, "DVD"));
            lista.Insertar(new Netflix() { ID = 1, Nombre = "Netflix" });

            

            Console.ReadKey();
        }
    }
}
