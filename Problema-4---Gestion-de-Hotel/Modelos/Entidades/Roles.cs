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
    public class Roles
    {
        private string nombreRol;
        private int idRol;

        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public static DataTable CargarRoles()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM Roles WHERE idRol IN (2, 3);";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }
    }
}
