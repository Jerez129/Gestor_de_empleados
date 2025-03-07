using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_de_datos
{

    public class CD_Empleados
    {

        private CD_Conexion Conexion = new CD_Conexion();
        //esto es para leer data de las tablas
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();


        public DataTable Mostrar()
        //Comandos de sql para mostrar los datos de la tabla
        //Abrir conexion y señal para el uso de proceso almacenado
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;

            //Comandos para visualizar datos en la tabla
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Insertar(int ID_Empleados, string Nombre, string Apellido, string Posicion, DateTime Fecha_ingreso)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;

            //Comandos para insertar datos en la tabla
            Comando.Parameters.AddWithValue("@ID_Empleados", ID_Empleados);
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Apellido", Apellido);
            Comando.Parameters.AddWithValue("@Posicion", Posicion);
            Comando.Parameters.AddWithValue("@Fecha_ingreso", Fecha_ingreso);


        }

        public void Editar(int ID_Empleados, string Nombre, string Apellido, string Posicion, DateTime Fecha_ingreso)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EditarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            //Comandos para editar datos en la tabla
            Comando.Parameters.AddWithValue("@ID_Empleados", ID_Empleados);
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Apellido", Apellido);
            Comando.Parameters.AddWithValue("@Posicion", Posicion);
            Comando.Parameters.AddWithValue("@Fecha_ingreso", Fecha_ingreso);
        }

        public void Eliminar(int ID)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EliminarEmpleado";
            Comando.CommandType = CommandType.StoredProcedure;

            Comando.Parameters.AddWithValue("@ID", ID);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }







    }










}
