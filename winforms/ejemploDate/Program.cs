using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(); //generamos variable de tipo datetime muestra el dato puro (fecha minima de creacion)

            DateTime fechaActual = DateTime.Now; //mostramos la fecha actual

            Console.WriteLine(fecha.ToString("dddd/MMMM/yyyy"));

            Console.WriteLine(fechaActual.ToString("dddd/MMMM/yyyy"));

            Console.WriteLine(fechaActual.Year);

            Console.ReadKey();
        }
    }
}
