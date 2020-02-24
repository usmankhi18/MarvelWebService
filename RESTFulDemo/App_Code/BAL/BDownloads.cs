using System.Data;

namespace RESTFulDemo
{
    public class BDownloads
    {
        public DataTable DownloadsByMoviesID(int MoviesID)
        {
            DataTable dtdownloads = new DataTable();
            DDownloads dCalc = new DDownloads();
            dtdownloads = dCalc.DownloadsByMoviesID(MoviesID);
            return dtdownloads;
        }
    }
}