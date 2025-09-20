using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Usuarios
    {
        //<----------------------------------------------------------------------------------->
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
        //<----------------------------------------------------------------------------------->

        //Encapsulamos los campos con "Ctrl + ."


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

        //<----------------------------------------------------------------------------------->
        // Por alguna razón esta clase es necesaria para que el CRUD funcione correctamente 
        // Aunque no se utilice en ningun otro lado realmente no se por que
    }
}