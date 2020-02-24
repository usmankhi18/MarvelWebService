using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RESTFulDemo
{
    public class DCharacters
    {
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter adapter;
        SqlParameter param1;
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        public DataTable GetAllCharacters()
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadAllCharacters";

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable CharactersByMoviesID(int MoviesID)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadCharactersByMoviesID";
            param1 = new SqlParameter("@MoviesId", MoviesID);
            command.Parameters.Add(param1);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
