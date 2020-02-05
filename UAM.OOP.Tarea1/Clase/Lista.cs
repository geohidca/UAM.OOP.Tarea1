using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Tarea1
{
    class Lista : Icrud<IReproductores>
    {
        List<IReproductores> lista;

        public void Insertar(IReproductores term)
        {
            lista.Add(term);
        }

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }

        public IReproductores Buscar(int indice)
        {

            if (indice < lista.Count)
            {
                return lista[indice];
            }
            else { return null; }
        }

    }
}
