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
    public class Reservas_Hotel
    {
        private int idReserva;
        private int idHabitacion;
        private int idUsuario;
        private int idServicio;
        private int idCliente;
        private DateTime fechaReserva;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }

        public bool InsertarReserva()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = @"
                    INSERT INTO Reservas (idHabitacion, idUsuario, idServicio, idCliente, fechaReserva) 
                    VALUES (@IdHabitacion, @IdUsuario, @IdServicio, @IdCliente, @FechaReserva);
                ";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdServicio", idServicio);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable CargarReservas()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = "SELECT * FROM RESERVAS_HOTEL;";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }

        public static DataTable BuscarReserva(string criterioBusqueda)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = @"
                    SELECT * FROM RESERVAS_HOTEL 
                    WHERE [Habitación asignada] LIKE @CriterioBusqueda 
                       OR [Cliente asignado] LIKE @CriterioBusqueda 
                       OR [Servicio contratado] LIKE @CriterioBusqueda 
                       OR [Registrado por] LIKE @CriterioBusqueda;
                ";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@CriterioBusqueda", "%" + criterioBusqueda + "%");
                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }

        public bool ModificarReserva()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = @"
                    UPDATE Reservas 
                    SET idHabitacion = @IdHabitacion, 
                        idUsuario = @IdUsuario, 
                        idServicio = @IdServicio, 
                        idCliente = @IdCliente,
                        fechaReserva = @FechaReserva
                    WHERE idReserva = @IdReserva;
                ";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdServicio", idServicio);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarReserva()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string comando = "DELETE FROM Reservas WHERE idReserva = @IdReserva;";
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static Reservas_Hotel ObtenerReservaPorId(int idReserva)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = "SELECT * FROM Reservas WHERE idReserva = @IdReserva;";
                SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Reservas_Hotel
                        {
                            IdReserva = Convert.ToInt32(reader["idReserva"]),
                            IdHabitacion = Convert.ToInt32(reader["idHabitacion"]),
                            IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                            IdServicio = Convert.ToInt32(reader["idServicio"]),
                            IdCliente = Convert.ToInt32(reader["idCliente"]),
                            FechaReserva = Convert.ToDateTime(reader["fechaReserva"])
                        };
                    }
                }
                return null;
            }
        }

        public static DataTable CargarReservasConFiltros(string filtroHabitacion, string filtroCliente, string filtroServicio)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consultaQuery = @"
                    SELECT * FROM RESERVAS_HOTEL 
                    WHERE ([Habitación asignada] LIKE @FiltroHabitacion OR @FiltroHabitacion = '')
                      AND ([Cliente asignado] LIKE @FiltroCliente OR @FiltroCliente = '')
                      AND ([Servicio contratado] LIKE @FiltroServicio OR @FiltroServicio = '');
                ";

                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@FiltroHabitacion", "%" + filtroHabitacion + "%");
                add.SelectCommand.Parameters.AddWithValue("@FiltroCliente", "%" + filtroCliente + "%");
                add.SelectCommand.Parameters.AddWithValue("@FiltroServicio", "%" + filtroServicio + "%");

                DataTable dataTables = new DataTable();
                add.Fill(dataTables);
                return dataTables;
            }
        }
    }
}