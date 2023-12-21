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
				varAccesoDatos.setearConsulta("select P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad");
				varAccesoDatos.ejecutarLectura();

				while (varAccesoDatos.Lector.Read())
				{
					Pokemon varPokemon = new Pokemon();
					varPokemon.Id = (int)varAccesoDatos.Lector["Id"];
					varPokemon.Numero = varAccesoDatos.Lector.GetInt32(0);
					varPokemon.Nombre = varAccesoDatos.Lector.GetString(1);
					varPokemon.Descripcion = varAccesoDatos.Lector.GetString(2);
					if (!(varAccesoDatos.Lector.IsDBNull(varAccesoDatos.Lector.GetOrdinal("UrlImagen"))))
					{
                        varPokemon.UrlImagen = varAccesoDatos.Lector.GetString(3);
                    }
					
					varPokemon.Tipo = new Elemento();
					varPokemon.Tipo.Descripcion = varAccesoDatos.Lector.GetString(4);
					varPokemon.Tipo.Id = (int)varAccesoDatos.Lector["IdTipo"];
                    varPokemon.Debilidad = new Elemento();
					varPokemon.Debilidad.Id = (int)varAccesoDatos.Lector["IdDebilidad"];
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
		public void agregarPokemon(Pokemon agregoPokemon)
		{
			AccesoDatos variableAccesoDatos = new AccesoDatos(); // creo la variable para acceder al metodo que me permite conectar al servidor
			                                                     //No creo una lista porque la funcion solo ingresa registros no muestra nada, es una funcion VOID no retonra nada
			try
			{
				variableAccesoDatos.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion,Activo,IdTipo,IdDebilidad,UrlImagen)values("+ agregoPokemon.Numero + ",'"+ agregoPokemon.Nombre + "','"+agregoPokemon.Descripcion+"',1,@idTipo,@idDebilidad,@urlImagen)");
				variableAccesoDatos.setearParametro("idTipo",agregoPokemon.Tipo.Id);
				variableAccesoDatos.setearParametro("idDebilidad", agregoPokemon.Debilidad.Id);
				variableAccesoDatos.setearParametro("urlImagen", agregoPokemon.UrlImagen);
				variableAccesoDatos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				variableAccesoDatos.cerrarConexion();
			}
		}
		public void modificarPokemon(Pokemon varModPokemon)
		{
			AccesoDatos variableconexion = new AccesoDatos();
			try
			{
				variableconexion.setearConsulta("update POKEMONS set Numero = @numero, Nombre =@nombre, Descripcion = @descripcion, UrlImagen = @urlImagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad where id = @id");
				variableconexion.setearParametro("@numero", varModPokemon.Numero);
				variableconexion.setearParametro("@nombre", varModPokemon.Nombre);
				variableconexion.setearParametro("@descripcion", varModPokemon.Descripcion);
				variableconexion.setearParametro("@urlImagen", varModPokemon.UrlImagen);
				variableconexion.setearParametro("idTipo", varModPokemon.Tipo.Id);
				variableconexion.setearParametro("idDebilidad", varModPokemon.Debilidad.Id);
				variableconexion.setearParametro("id", varModPokemon.Id); //debeo crear propo en pokemonclas
				variableconexion.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally {
				variableconexion.cerrarConexion();
			}
		}
		public void eliminarPokemon(int idPokemon) {
			AccesoDatos variableDatos = new AccesoDatos();
			try
			{
                variableDatos.setearConsulta("delete from POKEMONS where id= @id");
                variableDatos.setearParametro("@id", idPokemon);
				variableDatos.ejecutarAccion();
            }
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }
}
