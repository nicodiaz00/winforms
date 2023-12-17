using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listarElemento()
        {
            List<Elemento> listaElemento= new List<Elemento>();
            AccesoDatos variableAccesoDato = new AccesoDatos();
            try
            {
                variableAccesoDato.setearConsulta("select Id, Descripcion from ELEMENTOS"); //aca dentro va la consulta sql
                variableAccesoDato.ejecutarLectura();

                while (variableAccesoDato.Lector.Read()) { 
                    Elemento elementoAuxiliar = new Elemento();
                    elementoAuxiliar.Id = variableAccesoDato.Lector.GetInt32(0);
                    elementoAuxiliar.Descripcion = variableAccesoDato.Lector.GetString(1);

                    listaElemento.Add(elementoAuxiliar);
                    
                }
                return listaElemento;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
