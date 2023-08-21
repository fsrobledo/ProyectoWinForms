using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();           
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=PC-DESKTOP\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, Codigo, Nombre, A.Descripcion, Precio, ImagenUrl, IdCategoria, IdMarca, C.Descripcion Categoria, M.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where IdCategoria = C.Id and IdMarca = M.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = decimal.Round((decimal)lector["Precio"], 2);
                    aux.TipoCategoria = new Categoria();
                    aux.TipoCategoria.Id = (int)lector["IdCategoria"];
                    aux.TipoCategoria.Descripcion = (string)lector["Categoria"];
                    aux.NombreMarca = new Marca();
                    aux.NombreMarca.Id = (int)lector["IdMarca"];
                    aux.NombreMarca.Descripcion = (string)lector["Marca"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) values ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Precio + ", @ImagenUrl, @IdMarca, @IdCategoria)");
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@IdMarca", nuevo.NombreMarca.Id);
                datos.setearParametro("@IdCategoria", nuevo.TipoCategoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, ImagenUrl = @ImagenUrl, IdMarca = @IdMarca, IdCategoria = @IdCategoria where Id = @Id");
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@ImagenUrl", art.ImagenUrl);
                datos.setearParametro("@IdMarca", art.NombreMarca.Id);
                datos.setearParametro("@IdCategoria", art.TipoCategoria.Id);
                datos.setearParametro("@Id", art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarItem(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> filtrar(string filtroCategoria, string filtroMarca)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdCategoria, A.IdMarca from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = IdMarca and C.Id = IdCategoria ";

                switch (filtroCategoria)
                {
                    case "Celulares":
                        consulta += "and IdCategoria = 1";
                        break;
                    case "Televisores":
                        consulta += "and IdCategoria = 2";
                        break;
                    case "Media":
                        consulta += "and IdCategoria = 3";
                        break;
                    case "Audio":
                        consulta += "and IdCategoria = 4";
                        break;
                    default:
                        break;
                }
                switch (filtroMarca)
                {
                    case "Samsung":
                        consulta += " and IdMarca = 1";
                        break;
                    case "Apple":
                        consulta += " and IdMarca = 2";
                        break;
                    case "Sony":
                        consulta += " and IdMarca = 3";
                        break;
                    case "Huawei":
                        consulta += " and IdMarca = 4";
                        break;
                    case "Motorola":
                        consulta += " and IdMarca = 5";
                        break;
                    default:
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = decimal.Round((decimal)datos.Lector["Precio"], 2);
                    aux.TipoCategoria = new Categoria();
                    aux.TipoCategoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.TipoCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.NombreMarca = new Marca();
                    aux.NombreMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.NombreMarca.Descripcion = (string)datos.Lector["Marca"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
