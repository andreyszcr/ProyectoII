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
        public static void InsertarUsuarioBD(string usuario, string nombre, string apellido, string email, string contra)
        {
            string cn = conexionBD(@"LAPTOP-KGHR2GJB\SQLEXPRESS", @"andrey", @"300399", @"BIBLIOTECA");
            string conex = cn.ToString();
            string consulta = @"INSERT INTO Cedula (Cedula,Nombre,Apellidos,FechaNac,idTipoUsuario,email,Direccion,SEXO,Profesion,idCarrera) Values('" + usuario + @"','" + nombre + "','" + apellido + @"','" + email + @"','" + contra + @"')";
            SqlConnection bd = new SqlConnection(cn);
            SqlCommand MiComando = new SqlCommand(consulta, bd);
            bd.Open();
            MiComando.ExecuteNonQuery();
            bd.Close();
                
        }
        //****************************************************************************************************************************
        public static Boolean existeusuario(string usuario)
        {
            Boolean existe = false;

            string cn = conexionBD(@"LAPTOP-KGHR2GJB\SQLEXPRESS", @"andrey", @"300399", @"BIBLIOTECA");
            string consulta = @"SELECT Cedula, contraseña FROM Usuario WHERE Cedula='" + usuario + "'";
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
