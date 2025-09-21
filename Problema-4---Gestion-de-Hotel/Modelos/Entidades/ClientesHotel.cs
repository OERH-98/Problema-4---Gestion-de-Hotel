using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class ClientesHotel
    {
        private int idCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private DateTime fechaRegistroCliente;
        private DateTime fechaCumpleanios;
        private string numeroTelefono;
        private string dui;
        private string direccionCliente;
        private string genero;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public DateTime FechaRegistroCliente { get => fechaRegistroCliente; set => fechaRegistroCliente = value; }
        public DateTime FechaCumpleanios { get => fechaCumpleanios; set => fechaCumpleanios = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string DUI { get => dui; set => dui = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public string Genero { get => genero; set => genero = value; }

        public bool InsertarCliente()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = @"
                    INSERT INTO Clientes (nombreCliente, apellidoCliente, fechaCumpleanios, numeroTelefono, DUI, direccionCliente, genero) 
                    VALUES (@NombreCliente, @ApellidoCliente, @FechaCumpleanios, @NumeroTelefono, @DUI, @DireccionCliente, @Genero);
                ";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", apellidoCliente);
                cmd.Parameters.AddWithValue("@FechaCumpleanios", fechaCumpleanios);
                cmd.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono);
                cmd.Parameters.AddWithValue("@DUI", dui);
                cmd.Parameters.AddWithValue("@DireccionCliente", direccionCliente);
                cmd.Parameters.AddWithValue("@Genero", genero);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable CargarClientes()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = "SELECT * FROM CLIENTELA;";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }

        public static DataTable BuscarCliente(string criterioBusqueda)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = @"
                    SELECT * FROM CLIENTELA 
                    WHERE [Nombre] LIKE @CriterioBusqueda 
                       OR [Apellido] LIKE @CriterioBusqueda 
                       OR [Dui] LIKE @CriterioBusqueda 
                       OR [Telefono] LIKE @CriterioBusqueda;
                ";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@CriterioBusqueda", "%" + criterioBusqueda + "%");
                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }

        public bool ModificarCliente()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = @"
                    UPDATE Clientes 
                    SET nombreCliente = @NombreCliente, 
                        apellidoCliente = @ApellidoCliente, 
                        fechaCumpleanios = @FechaCumpleanios, 
                        numeroTelefono = @NumeroTelefono, 
                        DUI = @DUI, 
                        direccionCliente = @DireccionCliente,
                        genero = @Genero
                    WHERE idCliente = @IdCliente;
                ";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", apellidoCliente);
                cmd.Parameters.AddWithValue("@FechaCumpleanios", fechaCumpleanios);
                cmd.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono);
                cmd.Parameters.AddWithValue("@DUI", dui);
                cmd.Parameters.AddWithValue("@DireccionCliente", direccionCliente);
                cmd.Parameters.AddWithValue("@Genero", genero);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarCliente()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = "DELETE FROM Clientes WHERE idCliente = @IdCliente;";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static ClientesHotel ObtenerClientePorId(int idCliente)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = "SELECT * FROM Clientes WHERE idCliente = @IdCliente;";
                SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ClientesHotel
                        {
                            IdCliente = Convert.ToInt32(reader["idCliente"]),
                            NombreCliente = reader["nombreCliente"].ToString(),
                            ApellidoCliente = reader["apellidoCliente"].ToString(),
                            FechaRegistroCliente = Convert.ToDateTime(reader["fechaRegistroCliente"]),
                            FechaCumpleanios = Convert.ToDateTime(reader["fechaCumpleanios"]),
                            NumeroTelefono = reader["numeroTelefono"].ToString(),
                            DUI = reader["DUI"].ToString(),
                            DireccionCliente = reader["direccionCliente"].ToString(),
                            Genero = reader["genero"].ToString()
                        };
                    }
                }
                return null;
            }
        }

        public static DataTable CargarClientesConFiltros(string filtroNombre, string filtroApellido, string filtroDUI)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = @"
                    SELECT * FROM CLIENTELA 
                    WHERE ([Nombre] LIKE @FiltroNombre OR @FiltroNombre = '')
                      AND ([Apellido] LIKE @FiltroApellido OR @FiltroApellido = '')
                      AND ([Dui] LIKE @FiltroDUI OR @FiltroDUI = '');
                ";

                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@FiltroNombre", "%" + filtroNombre + "%");
                add.SelectCommand.Parameters.AddWithValue("@FiltroApellido", "%" + filtroApellido + "%");
                add.SelectCommand.Parameters.AddWithValue("@FiltroDUI", "%" + filtroDUI + "%");

                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }
    }
}