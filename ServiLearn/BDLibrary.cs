using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BDLibrary
{
    public class BDLibrary
    {
        public string origen_datos;
        public string cadenaConexion;
        public string cadenaConexionSQLNCLI;

        public BDLibrary()
        {

        }

        public List<string> getColumnas(string tabla)
        {
            List<string> res = new List<string>();
            string consultaSelect = "SELECT TOP 1 * FROM " + tabla + ";";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            for (int i = 0; i < reader.FieldCount; ++i) res.Add(reader.GetName(i));

            conexion.Close();
            return res;
        }

        public List<object[]> Select(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;

            List<object[]> res = new List<object[]>();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int numColumnas = reader.FieldCount;
                object[] fila = new object[numColumnas];
                for (int i = 0; i < numColumnas; ++i) fila[i] = reader[i];
                res.Add(fila);
            }

            conexion.Close();


            return res;
        }

        public object SelectScalar(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;


            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            object res = comando.ExecuteScalar();

            conexion.Close();


            return res;
        }

        public void Update(string cadenaUpdate)
        {
            if (cadenaUpdate.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaUpdate, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void Delete(string cadenaDelete)
        {
            if (cadenaDelete.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaDelete, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Insert(string cadenaInsert)
        {
            if (cadenaInsert.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            MySqlCommand comando = new MySqlCommand(cadenaInsert, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        /*public void EjecutaProcedimiento(string name, SqlParameter[] param)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexionSQLNCLI);
            SqlCommand comando = new SqlCommand(name, conexion);
            foreach (SqlParameter p in param)
            {
                comando.Parameters.Add(p);
            }
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }*/

    }


    public class MySQLDB : BDLibrary
    {
        public MySQLDB()
        {
            origen_datos = "apsgrupo11";
            cadenaConexion = "user id=grupo11;server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com;password=villalbaaguayo2020;persistsecurityinfo=True;database=apsgrupo11;";
        }
    }




}
