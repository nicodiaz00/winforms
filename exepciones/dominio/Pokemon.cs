using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        /*private string nombre;
        private int numero;
        private string descripcion;

        public void setName(String name)
        {
            nombre = name;
        }
        public string getName()
        {
            return nombre;
        }

        public void setNumber(int number)
        {
            numero = number;
        }
        public int getNumber()
        {
            return numero;
        }
        public void setDescripcion(string des)
        {
            descripcion = des;
        }
        public string getDescription()
        {
            return descripcion;
        }
        */
        public int Numero{ get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string urlImagen { get; set; }

        public Elemento Tipo { get; set; }

        public Elemento Debilidad { get; set; } 
    }
}
