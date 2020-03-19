using System;
using CapaDatos.Datos;
using System.Data.Sql;
using System.Data.SqlClient;

public class Inserts
{
	public Class1()
	{
	}

	Datos cn = new Datos();

    public static void InsertarUsuarioBD(string cedula, string nombre, string apellidos, Date FechaNac, int idTipoUsuari, string tel, string email, string contra, char sexo, int carrera, string profe)
    {
        try
        {
            string cn = conexionBD(@"ALBERTO-PC\QSOFT", @"sa", @"QsoftMSDEsa2005", @"BIBLIOTECA");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Insertar_Usuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cedula", cedula));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            cmd.Parameters.Add(new SqlParameter("@fechanac", FechaNac));
            cmd.Parameters.Add(new SqlParameter("@idTipoUsuario", idTipoUsuari));
            cmd.Parameters.Add(new SqlParameter("@telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@contraseña", contra));
            cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
            cmd.Parameters.Add(new SqlParameter("@idCarrera", carrera));
            cmd.Parameters.Add(new SqlParameter("@profesion", profe));
            cmd.ExecuteNonQuery();
        }
        catch (SqlException e)
        {

        }




    }
}
 