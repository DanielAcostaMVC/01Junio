using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ApuestasPolla.DAL
{
    public class Conexion
    {
        public Conexion()
        {
            defaultDBInstance = new System.Data.SqlClient.SqlConnection("Data Source=CUMBAL;Database=MVCpruebas;Integrated Security=True;");//ConfigurationManager.ConnectionStrings["TestHabilidadesDB"].ToString());            
        }

        private SqlConnection defaultDBInstance;

        public SqlConnection defaultDB
        {
            get
            {
                return defaultDBInstance;
            }
        }

        public void Open()
        {
            defaultDB.Open();
        }

        public void Close()
        {
            defaultDB.Close();
        }
    }
}