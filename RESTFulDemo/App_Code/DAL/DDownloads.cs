using System.Data;
using System.Data.SqlClient;

namespace RESTFulDemo
{
    public class DDownloads
    {
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter adapter;
        SqlParameter param1;
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        public DataTable DownloadsByMoviesID(int MoviesID)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spMoviesPrintDownload";
            param1 = new SqlParameter("@ID", MoviesID);
            command.Parameters.Add(param1);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}