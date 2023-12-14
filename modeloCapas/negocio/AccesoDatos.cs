using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection varConexion; //objeto para conectar
        private SqlCommand varComando;  //comando para ejecutar accion
        private SqlDataReader varLector; // se utiliza para leer un flujo de filas de datos
        public SqlDataReader Lector { get { return varLector; } }

        public AccesoDatos()
        {
            varConexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            varComando = new SqlCommand();
        }
        public void setearConsulta(string varConsulta)
        {
            varComando.CommandType = System.Data.CommandType.Text; //indica que el comando es una consulta de texto plano (SQL)
            varComando.CommandText = varConsulta;
        }
        public void ejecutarLectura() //con esta funcion comienza a leer en la BD
        {
            varComando.Connection = varConexion; // le digo a mi variable varComando que ahora va tener lo que tiene varConexion, que es la conexion hacia la db
            try
            {
                varConexion.Open();
                varLector = varComando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {   if(varLector!= null)
            {
                varLector.Close();
            }
            varConexion.Close();
        }

        
    }
}
