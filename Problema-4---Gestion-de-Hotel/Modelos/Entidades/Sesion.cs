
using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Sesion
    {

        //<----------------------------------------------------------------------------------->
        //Indica cual es el usuario que actualmente esta ocupando la sesion
        public static Usuarios UsuarioActivo { get; private set; }
        //<----------------------------------------------------------------------------------->

        //Este apartado es el que perimte el inicio de sesion, ya que como se puede observar, posee 2 STRINGS (EMAIL Y CLAVE) que son datos que se piden en la pantalla de inicio
        public static bool Iniciar(string email, string clave)
        {
            Sesion sesion = new Sesion();
            if (!sesion.VerificarLogin(email, clave))
                return false;

            string query = @"SELECT * FROM Usuario WHERE correoElectronico = @Correo";

            using (SqlConnection conexion = ConexionDB.conectar())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Correo", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return false;

                    UsuarioActivo = new Usuarios
                    {
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        NombreSistemaUsuario = reader["nombreSistemaUsuario"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        CorreoElectronico = reader["correoElectronico"].ToString(),
                        IdRol = Convert.ToInt32(reader["idRol"]),
                        NumeroTelefono = reader["NumeroTelefono"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        RegistroUsuario = Convert.ToDateTime(reader["fechaRegistroUsuario"]),
                        FotoPerfil = reader["fotoPerfil"] as byte[],
                        FechaCumpleanios = reader["fechaCumpleanios"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCumpleanios"]) : DateTime.MinValue,
                        Genero = reader["genero"] != DBNull.Value ? reader["genero"].ToString() : null
                    };

                    return true;
                }
            }
        }
        //<----------------------------------------------------------------------------------->
        // Este apartado Verifica el Login de un usuario

        public bool VerificarLogin(string correo, string clave)
        {
            string hashEnBaseDeDatos = ""; // Recupera el hash desde SQL Server
            SqlConnection conn = ConexionDB.conectar();
            string query = "SELECT clave FROM Usuario WHERE correoElectronico = @Correo";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Correo", correo);

            if (cmd.ExecuteScalar() == null)
            {
                return false;

            }
            else
            {
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
            }
        }

        //<----------------------------------------------------------------------------------->

        //Al cerrar sesion se puede llamar este metodo que asignara el usuario activo actual a un NULL ya que no queremos que este el actual
        public static void Cerrar()
        {
            UsuarioActivo = null;
        }
        //<----------------------------------------------------------------------------------->

        public static bool Activa => UsuarioActivo != null;
        //<----------------------------------------------------------------------------------->
    }
}