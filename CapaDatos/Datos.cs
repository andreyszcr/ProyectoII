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
        
        //********************************************************************************************************

       
    }
}
