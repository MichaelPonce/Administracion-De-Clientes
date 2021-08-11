using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Conexion
    {
        public static SqlConnection Conectarbd()
        {
            SqlConnection cm = new SqlConnection("workstation id=AprodelboSA.mssql.somee.com;packet size=4096;user id=jdk123_SQLLogin_1;pwd=x6vfjngt8n;data source=AprodelboSA.mssql.somee.com;persist security info=False;initial catalog=AprodelboSA");

            cm.Open();
            return cm;
        }
    }
}
