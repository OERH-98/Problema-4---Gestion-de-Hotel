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
    public class ServiciosHotel
    {
        private int idServicio;
        private string nombreServicio;
        private string descripcionServicio;
        private DateTime fechaRegistroServicio;

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }
        public DateTime FechaRegistroServicio { get => fechaRegistroServicio; set => fechaRegistroServicio = value; }
        public string DescripcionServicio { get => descripcionServicio; set => descripcionServicio = value; }

        public bool InsertarServicio()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = @"
                INSERT INTO SERVICIOS (nombreServicio, descripcionServicio) 
                VALUES (@NombreServicio, @DescripcionServicio);
            ";
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@NombreServicio", nombreServicio);
            cmd.Parameters.AddWithValue("@DescripcionServicio", descripcionServicio);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static DataTable CargarServicios()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM SERVICIOS_HOTEL;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

        public static DataTable BuscarServicio(string nombreServicio)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM SERVICIOS_HOTEL WHERE [Definicion del servicio] LIKE @NombreServicio;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            add.SelectCommand.Parameters.AddWithValue("@NombreServicio", "%" + nombreServicio + "%");
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }
    }
}
