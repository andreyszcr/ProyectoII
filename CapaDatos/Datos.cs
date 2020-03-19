using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CapaDatos
{
    public class Datos
    {
        public static string conexionBD(string servidor, string usuario, string contraseña, string basedatos)
        {
            var cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = servidor;
            cadena.IntegratedSecurity = false;
            cadena.UserID = usuario;
            cadena.Password = contraseña;
            cadena.InitialCatalog = basedatos;

            var conexionBD = cadena.ToString();


            return conexionBD;

        }
        //*******************************************************************************************************
        
        //****************************************************************************************************************************
        public static Boolean existeusuario(string usuario)
        {
            Boolean existe = false;

            string cn = conexionBD(@"ALBERTO-PC\QSOFT", @"sa", @"QsoftMSDEsa2005", @"BIBLIOTECA");
            string consulta = @"SELECT Cedula FROM Usuario WHERE Cedula='" + usuario + "'";
            SqlConnection conex = new SqlConnection(cn);
            conex.Open();
            SqlCommand query = new SqlCommand(consulta, conex);
            query.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (1 == dt.Rows.Count)

                existe = true;

            else
                existe = false;


            return existe;


        }
        //************************************************************************************************
        public static string extraerUsuario(string usuario)
        {
            string cn = conexionBD(@"LAPTOP-KGHR2GJB\SQLEXPRESS", @"andrey", @"300399", @"TareaCorta");
            string consulta = @"SELECT Usuario, contraseña FROM Registro WHERE Usuario='" + usuario + "'";
            SqlConnection conex = new SqlConnection(cn);
            conex.Open();
            SqlCommand query = new SqlCommand(consulta, conex);
            query.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string res = dt.Rows[0][0].ToString();

            return res;

        }
        //****************************************************************************************************
        public static string extraerContraseña(string usuario)
        {
            string cn = conexionBD(@"LAPTOP-KGHR2GJB\SQLEXPRESS", @"andrey", @"300399", @"TareaCorta");
            string consulta = @"SELECT contraseña FROM Registro WHERE Usuario='" + usuario + "'";
            SqlConnection conex = new SqlConnection(cn);
            conex.Open();
            SqlCommand query = new SqlCommand(consulta, conex);
            query.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string res = dt.Rows[0][0].ToString();

            return res;

        }
        //********************************************************************************************************

       
    }
}
