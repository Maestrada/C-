using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_datos
{
    public class CTelefonosDataAccess
    {
        private static readonly string CADENA_DE_CONEXION = ConfigurationManager.ConnectionStrings["ConexionLocal"].ConnectionString; //System.Configuration.ConfigurationManager.AppSettings["ConexionLocal"].Con;

        /// <summary>
        /// Filtrado por nombre y lista de telefonos
        /// </summary>
        /// <param name="busqueda"></param>
        /// <returns></returns>
        public List<CTelefonos> ListaDeTelefonos(string busqueda = "")
        {
            List<CTelefonos> listaTelefonos = new List<CTelefonos>();
            string query = @"
                        SELECT [IdTelefono]
                              ,[Nombre]
                              ,[Direccion]
                              ,[Telefono]
                              ,[Nota]
                              ,[FechaCreacion]
                          FROM [dbo].[Telefonos] WITH(NOLOCK) 
                           {0}
                         ORDER BY [FechaCreacion] ASC
";

            if (!string.IsNullOrEmpty(busqueda.Trim()))
            {
                query = query.Replace("{0}", "where Nombre Like '%'+@busqueda+'%' ");
            }
            else
            {
                query = query.Replace("{0}","");
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(CADENA_DE_CONEXION))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        if (!string.IsNullOrEmpty(busqueda.Trim()))
                        {
                            command.Parameters.AddWithValue("@busqueda", busqueda);
                        }

                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> columns = new List<string>();
                            for (int x = 0; x < reader.FieldCount; x++)
                            {
                                columns.Add(reader.GetName(x));
                            }

                            while (reader.Read())
                            {
                                listaTelefonos.Add( new CTelefonos(columns, reader));
                            }
                        }
                    }

                }
            }catch(Exception )
            {
                throw;
            }
                return listaTelefonos;

        }

        /// <summary>
        /// Actualizacion de registros
        /// </summary>
        /// <param name="cTelefonos"></param>
        /// <returns></returns>
        public bool ActualizarRegistro(CTelefonos cTelefonos)
        {
            bool exitoso = false;
            string query = @"
                              UPDATE dbo.Telefonos
                              SET
                              Nombre = @nombre,
                              Direccion = @direccion,
                              Telefono = @telefono,
                              Nota = @nota
                              WHERE  IdTelefono = @id";
            try
            {
                using (SqlConnection conn = new SqlConnection(CADENA_DE_CONEXION))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@nombre",cTelefonos._Nombre);
                        command.Parameters.AddWithValue("@direccion",cTelefonos._Direccion);
                        command.Parameters.AddWithValue("@telefono",cTelefonos._Telefono);
                        command.Parameters.AddWithValue("@nota",cTelefonos._Nota);
                        command.Parameters.AddWithValue("@id",cTelefonos._IdTelefono);

                        conn.Open();
                        exitoso = (command.ExecuteNonQuery() > 0);                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exitoso;
        }

        /// <summary>
        /// Creacion de registros
        /// </summary>
        /// <param name="cTelefonos"></param>
        /// <returns></returns>
        public Guid NuevoRegistro(CTelefonos cTelefonos)
        {
            cTelefonos._IdTelefono = Guid.NewGuid();
            string query = @"
                              INSERT INTO dbo.Telefonos
                              (
                                  IdTelefono, Nombre, Direccion, Telefono, Nota,FechaCreacion
                              )
                              VALUES
                              (   @Id, -- IdTelefono - uniqueidentifier
                                  @nombre,   -- Nombre - varchar(50)
                                  @direccion,   -- Direccion - varchar(150)
                                  @telefono,   -- Telefono - varchar(20)
                                  @nota,   -- Nota - varchar(150)
                                  @fecha
                                  )";
            try
            {
                using (SqlConnection conn = new SqlConnection(CADENA_DE_CONEXION))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@nombre",cTelefonos._Nombre);
                        command.Parameters.AddWithValue("@direccion",cTelefonos._Direccion);
                        command.Parameters.AddWithValue("@telefono",cTelefonos._Telefono);
                        command.Parameters.AddWithValue("@nota",cTelefonos._Nota);
                        command.Parameters.AddWithValue("@Id",cTelefonos._IdTelefono);
                        command.Parameters.AddWithValue("@fecha", DateTime.Now);

                        conn.Open();
                        if (command.ExecuteNonQuery() <= 0)
                        {
                            throw new Exception("Error al guardar el registro");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cTelefonos._IdTelefono;
        }

        /// <summary>
        /// Eliminacion de registros
        /// </summary>
        /// <param name="cTelefono"></param>
        /// <returns></returns>
        public bool EliminarRegistro(CTelefonos cTelefono)
        {
            bool exitoso = false;
            string query = @"	  DELETE FROM dbo.Telefonos
	                              WHERE IdTelefono  =@Id
                              ";
            try
            {
                using (SqlConnection conn = new SqlConnection(CADENA_DE_CONEXION))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = System.Data.CommandType.Text; 
                        command.Parameters.AddWithValue("@Id",cTelefono._IdTelefono);
                        conn.Open();
                        exitoso = (command.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exitoso;
        }
    }
}
