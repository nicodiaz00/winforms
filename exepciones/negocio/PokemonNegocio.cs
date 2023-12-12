using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace adoNet
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection varConexion = new SqlConnection();
            SqlCommand varComando = new SqlCommand();
            SqlDataReader varLector;
            try
            {
                varConexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security =true";
                varComando.CommandType = System.Data.CommandType.Text;
                varComando.CommandText = "select Numero, Nombre, P.Descripcion,E.Descripcion as Tipo, D.Descripcion as Debilidad, UrlImagen  from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                varComando.Connection = varConexion;

                varConexion.Open();
                varLector=varComando.ExecuteReader();

                while (varLector.Read())
                {
                    Pokemon objetoPokemon = new Pokemon();
                    objetoPokemon.Numero = varLector.GetInt32(0);
                    objetoPokemon.Nombre = varLector.GetString(1);
                    objetoPokemon.Descripcion=varLector.GetString(2);
                    objetoPokemon.Tipo = new Elemento();
                    objetoPokemon.Tipo.Descripcion = varLector.GetString(3);//(string)varLector["Tipo"];
                    objetoPokemon.Debilidad = new Elemento();
                    objetoPokemon.Debilidad.Descripcion = varLector.GetString(4);

                    objetoPokemon.urlImagen = varLector.GetString(5);
                    


                    lista.Add(objetoPokemon);
                }
                varConexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
