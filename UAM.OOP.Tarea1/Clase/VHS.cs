using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Tarea1
{
    class VHS: IReproductores
    {
        #region Atributos
        private int _id;
        private string _nombre;
        #endregion;

        #region Propiedades

        public int ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }

        #endregion;

        #region Constructores
        public VHS()
        {
        }

        public VHS(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
        #endregion;

        #region Metodos

        public void FW()
        {
            Console.WriteLine("{0} - FW", _nombre);
        }

        public void play()
        {
            Console.WriteLine("{0} - play", _nombre);
        }

        public void RW()
        {
            Console.WriteLine("{0} - RW", _nombre);
        }

        public void stop()
        {
            Console.WriteLine("{0} - stop", _nombre);
        }

        #endregion;


    }
}
