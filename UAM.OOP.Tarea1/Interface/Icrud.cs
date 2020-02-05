using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Tarea1
{
    interface Icrud<T>
    {
        void Insertar(T term);
        void Eliminar(int indice);
        T Buscar(int indice);
    }
}
