using LinqToObject4.Clases;
using System.ComponentModel.Design;

namespace LinqToObject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            int op = Menu();
            bool band = true;
            while (band)
            {
                switch (op)
                {
                    case 1: Empleado e = AltaEmpleado(empleados);
                            empleados.Add(e);
                            op = Menu();
                            break;
                    case 2: OrdenaEmpleadosAsc(empleados);
                        op = Menu();
                        break;
                    case 3: OrdenaEmpleadosDesc(empleados);
                        op = Menu();
                        break;
                    case 4: band = false; break;
                    default: Console.WriteLine("Ingrese una de las 4 opciones"); break;
                }
            }

        }

        static int Menu()
        {
            Console.WriteLine("1-Dar de alta un empleado, 2-Listar Empleados por sueldo de manera ascendente, 3-Listar Empleados por sueldo de manera descendente 4-Salir");
            int op = int.Parse(Console.ReadLine());
            return op;
        }

        static Empleado AltaEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Ingrese nombre del empleado");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            float sueldo = float.Parse(Console.ReadLine());
            Empleado e = new Empleado(empleados.Count(), nom, sueldo);
            return e;
        }


        static void OrdenaEmpleadosAsc(List<Empleado> empleados )
        {
            Console.WriteLine("Sueldo ID Nombre");
            var misempleadosa = empleados.OrderBy(e => e.Sueldo);
            foreach (var m in misempleadosa)
            {
                Console.WriteLine($"{m.Sueldo}  {m.ID}  {m.Nombre}");
            }
        }

        static void OrdenaEmpleadosDesc(List<Empleado> empleados)
        {
            Console.WriteLine("Sueldo ID Nombre");
            var misempleadosd = empleados.OrderByDescending(e => e.Sueldo);
            foreach (var m in misempleadosd)
            {
                Console.WriteLine($"{m.Sueldo}  {m.ID}  {m.Nombre}");
            }

        }
    }

}