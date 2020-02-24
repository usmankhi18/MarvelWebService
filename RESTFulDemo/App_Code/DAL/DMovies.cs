using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RESTFulDemo
{
    public class DMovies
    {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();
            SqlParameter param1;
        public DataTable GetAllMovies()
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadAllMovies";

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable MoviesBySeries(int SeriesId)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadMoviesBySeriesID";
            param1 = new SqlParameter("@SeriesId", SeriesId);
            command.Parameters.Add(param1);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable MoviesByCharacterID(int CharacterID)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadMoviesByCharacterID";
            param1 = new SqlParameter("@CharacterId", CharacterID);
            command.Parameters.Add(param1);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
