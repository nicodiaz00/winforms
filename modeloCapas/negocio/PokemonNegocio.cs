using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listarPokemon()
        {
			List<Pokemon> listPokemon = new List<Pokemon>();
			AccesoDatos varAccesoDatos = new AccesoDatos();
			try
			{
				varAccesoDatos.setearConsulta("select P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad");
				varAccesoDatos.ejecutarLectura();

				while (varAccesoDatos.Lector.Read())
				{
					Pokemon varPokemon = new Pokemon();
					varPokemon.Numero = varAccesoDatos.Lector.GetInt32(0);
					varPokemon.Nombre = varAccesoDatos.Lector.GetString(1);
					varPokemon.Descripcion = varAccesoDatos.Lector.GetString(2);
					varPokemon.UrlImagen = varAccesoDatos.Lector.GetString(3);
					varPokemon.Tipo = new Elemento();
					varPokemon.Tipo.Descripcion = varAccesoDatos.Lector.GetString(4);
                    varPokemon.Debilidad = new Elemento();
                    varPokemon.Debilidad.Descripcion = varAccesoDatos.Lector.GetString(5);



                    listPokemon.Add(varPokemon);
				}
				return listPokemon;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				varAccesoDatos.cerrarConexion();
			}
        }
    }
}
