using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject4.Clases
{
    internal class Empleado
    {
        private int _id;
        private string _nombre;
        private float _sueldo;

        public int ID { get; set; }

        public string Nombre { get; set; }

        public float Sueldo { get; set; }

        public Empleado(int iD, string nombre, float sueldo)
        {
            ID = iD;
            Nombre = nombre;
            Sueldo = sueldo;
        }


        public void OrdenarAsc()
        {

        }
    }
}
