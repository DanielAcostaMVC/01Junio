using ApuestasPolla.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ApuestasPolla.DAL;

namespace ApuestasPolla.DAL
{
    public class MetodosBaseDatos : Conexion
    {

        public Usuario Autenticar(string Usu, string Contrasena)
        {

            //Store procedure : InsertUserData
            SqlCommand cmd = defaultDB.CreateCommand();
            cmd.CommandText = "dbo.MVC_Login";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter UsuTipoPersonaParameter = new SqlParameter("Usuario", DbType.String);
            UsuTipoPersonaParameter.Value = Usu;
            cmd.Parameters.Add(UsuTipoPersonaParameter);

            SqlParameter ContraseñaParameter = new SqlParameter("Contrasena", DbType.Int32);
            ContraseñaParameter.Value = Contrasena;
            cmd.Parameters.Add(ContraseñaParameter);

            Usuario Usua = new Usuario();

            Open();
            using (IDataReader sprocReader = cmd.ExecuteReader())//Reader())
            {
                while (sprocReader.Read())
                {
                    Usua.Id = (sprocReader.IsDBNull(0)) ? 0 : sprocReader.GetInt32(0); 
                    Usua.Nombre = (sprocReader.IsDBNull(1)) ? string.Empty : sprocReader.GetString(1);
                    Usua.Sexo = (sprocReader.IsDBNull(2)) ? string.Empty : sprocReader.GetString(2);
                }
                Close();
            }
            return Usua;
        }
    }
}