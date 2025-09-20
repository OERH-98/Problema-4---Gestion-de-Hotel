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
    public class Empleadores
    {
        //Vincula la ID del usuario
        private int idUsuario;
        //Vincula el nombre del usuario
        private string nombre;
        //Vincula el apellido del usuario
        private string apellido;
        //Vincula la contraseña del usuario
        private string clave;
        //Vincula el correo del usuario
        private string correoElectronico;
        private string direccion;
        //Vincula el nombre del usuario dentro del sistema
        private string nombreSistemaUsuario;
        //Asigna el rol numero 1 ya que este numero es asignado especificamente para el administrador
        private int idRol;
        //Vincula el numero telefonico del usuario
        private string numeroTelefono;
        //Vincula la fecha
        private DateTime registroUsuario;
        //Foto de Perfil
        private byte[] fotoPerfil;
        //Fecha Cumpleaños
        private DateTime fechaCumpleanios;
        //Genero
        private string genero;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Clave { get => clave; set => clave = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NombreSistemaUsuario { get => nombreSistemaUsuario; set => nombreSistemaUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public DateTime RegistroUsuario { get => registroUsuario; set => registroUsuario = value; }
        public byte[] FotoPerfil { get => fotoPerfil; set => fotoPerfil = value; }
        public DateTime FechaCumpleanios { get => fechaCumpleanios; set => fechaCumpleanios = value; }
        public string Genero { get => genero; set => genero = value; }

        // Método para modificar la foto de perfil
        public bool ModificarFotoPerfil()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.conectar())
                {
                    string query = "UPDATE Usuario SET fotoPerfil = @FotoPerfil WHERE correoElectronico = @Correo";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Correo", CorreoElectronico);

                        if (FotoPerfil != null && FotoPerfil.Length > 0)
                            cmd.Parameters.Add("@FotoPerfil", SqlDbType.VarBinary, -1).Value = FotoPerfil;
                        else
                            cmd.Parameters.Add("@FotoPerfil", SqlDbType.VarBinary).Value = DBNull.Value;

                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar foto de perfil: {ex.Message}");
                return false;
            }
        }

        // Método para mostrar todos los usuarios
        public static DataTable MostrarUsuarios()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string query = "SELECT * FROM Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public static DataTable MostrarRecepcionistas()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string query = "SELECT * FROM RECEPCIONISTA";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public static DataTable MostrarGerentes()
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string query = "SELECT * FROM GERENTE";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        // Método para buscar usuarios por campos clave
        public static DataTable BuscarUsuarioRecepcionista(string buscar)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string query = @"SELECT * FROM RECEPCIONISTA
                                 WHERE [Nombre] LIKE @buscar
                                    OR [Apellido] LIKE @buscar
                                    OR [Correo Electrónico] LIKE @buscar";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public static DataTable BuscarUsuarioGerente(string buscar)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string query = @"SELECT * FROM GERENTE
                                 WHERE [Nombre] LIKE @buscar
                                    OR [Apellido] LIKE @buscar
                                    OR [Correo Electrónico] LIKE @buscar";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public bool ModificarUsuario()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "UPDATE Usuario\r\nSET\r\n    nombre = @Nombre,\r\n idRol = @Rol ,   apellido = @Apellido,\r\n    numeroTelefono = @Telefono,\r\n    direccion = @Direccion,\r\n    fechaCumpleanios = @Fecha,\r\n    nombreSistemaUsuario = @Usuario\r\nWHERE\r\n    correoElectronico = @Correo;";


            //Parametros de modificacion
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@Usuario", NombreSistemaUsuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Telefono", NumeroTelefono);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Fecha", FechaCumpleanios);
            cmd.Parameters.AddWithValue("@Correo", CorreoElectronico);
            cmd.Parameters.AddWithValue("@Rol", IdRol);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarUsuario()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "DELETE FROM Usuario WHERE correoElectronico = @Correo";
            //Parametros de eliminacion
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@Correo", CorreoElectronico);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
