using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace Capa_de_datos
{
    public class CD_Conexion
    {
        //Variables
        public SqlConnection Conexion;
        public string connectionString = ("Data Source=.;Initial catalog=Empleados_CND; Integrated Security=True; TrustServerCertificate=True; Encrypt=False;");


        public CD_Conexion() //Constructor
        {
            Conexion = new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        } 

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }



    }


}       

     

    

