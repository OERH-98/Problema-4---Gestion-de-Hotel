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
    public class Habitaciones
    {
        private int idHabitacion;
        private string numeroHabitacion;

        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }

        public static DataTable CargarHabitaciones()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM Habitaciones;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }
    }
}
