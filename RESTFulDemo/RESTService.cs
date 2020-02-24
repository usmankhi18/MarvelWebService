using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;
using System.Runtime.Serialization;
using RESTfullDemo;
using System.Data;

namespace RESTFulDemo
{
    /// <summary>
    /// Basically this code is developed for HTTP GET, PUT, POST & DELETE operation.
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RESTSerivce : IRestSerivce
    {

        Result res = new Result();
        public Result ConvertCurrency(Currency c)
        {
            double amount;
            BCalculate bCalc = new BCalculate();
            amount = bCalc.Calculate(c);
            if (amount == 0)
            {
                res.status = 0;
                res.Amount = 0;
            }
            else
            {
                res.status = 1;
                res.Amount = amount;
            }
            return res;
        }

        SeriesResponse seriesres = new SeriesResponse();
        public SeriesResponse GetAllSeries()
        {
            DataTable series = new DataTable();
            BSeries bCalc = new BSeries();
            series = bCalc.GetAllSeries();
            List<Series> seriesList = new List<Series> { };
            if (series == null)
            {
                seriesres.status = 0;
                seriesres.SeriesArray = null;
            }
            else
            {
                seriesres.status = 1;
                Series ser;
                for (int i = 0; i < series.Rows.Count;i++ )
                {
                    ser = new Series();
                    ser.SeriesId = int.Parse(series.Rows[i][0].ToString());
                    ser.SeriesName = series.Rows[i][1].ToString();
                    ser.SeriesCount = int.Parse(series.Rows[i][2].ToString());
                    ser.SeriesLogo = series.Rows[i][3].ToString();
                    seriesList.Add(ser);
                }
                 seriesres.SeriesArray = seriesList;
            }
            return seriesres;
        }

        MoviesResponse moviesres = new MoviesResponse();
        public MoviesResponse GetAllMovies()
        {
            DataTable movies = new DataTable();
            BMovies bCalc = new BMovies();
            movies = bCalc.GetAllMovies();
            List<Movies> seriesList = new List<Movies> { };
            if (movies == null)
            {
                moviesres.status = 0;
                moviesres.MoviesArray = null;
            }
            else
            {
                moviesres.status = 1;
                Movies ser;
                for (int i = 0; i < movies.Rows.Count; i++)
                {
                    ser = new Movies();
                    ser.MovieId = int.Parse(movies.Rows[i][0].ToString());
                    ser.MovieName = movies.Rows[i][1].ToString();
                    ser.MovieYear = int.Parse(movies.Rows[i][2].ToString());
                    ser.SeriesId = int.Parse(movies.Rows[i][3].ToString());
                    ser.SeriesName = movies.Rows[i][4].ToString();
                    ser.MovieLogo = movies.Rows[i][5].ToString();
                    ser.MovieRating = float.Parse(movies.Rows[i][6].ToString());
                    ser.MoviePlot = movies.Rows[i][7].ToString();
                    ser.VideoID = movies.Rows[i]["VideoID"].ToString();
                    seriesList.Add(ser);
                }
                moviesres.MoviesArray = seriesList;
            }
            return moviesres;
        }

        public MoviesResponse MoviesBySeries(Input s)
        {
            DataTable movies = new DataTable();
            BMovies bCalc = new BMovies();
            movies = bCalc.MoviesBySeries(s.SeriesID);
            List<Movies> seriesList = new List<Movies> { };
            if (movies == null)
            {
                moviesres.status = 0;
                moviesres.MoviesArray = null;
            }
            else
            {
                moviesres.status = 1;
                Movies ser;
                for (int i = 0; i < movies.Rows.Count; i++)
                {
                    ser = new Movies();
                    ser.MovieId = int.Parse(movies.Rows[i][0].ToString());
                    ser.MovieName = movies.Rows[i][1].ToString();
                    ser.MovieYear = int.Parse(movies.Rows[i][2].ToString());
                    ser.SeriesId = int.Parse(movies.Rows[i][3].ToString());
                    ser.SeriesName = movies.Rows[i][4].ToString();
                    ser.MovieLogo = movies.Rows[i][5].ToString();
                    ser.MovieRating = float.Parse(movies.Rows[i][6].ToString());
                    ser.MoviePlot = movies.Rows[i][7].ToString();
                    ser.VideoID = movies.Rows[i]["VideoID"].ToString();
                    seriesList.Add(ser);
                }
                moviesres.MoviesArray = seriesList;
            }
            return moviesres;
        }

        public MoviesResponse MoviesByCharacterID(Input s)
        {
            DataTable movies = new DataTable();
            BMovies bCalc = new BMovies();
            movies = bCalc.MoviesByCharacterID(s.SeriesID);
            List<Movies> seriesList = new List<Movies> { };
            if (movies == null)
            {
                moviesres.status = 0;
                moviesres.MoviesArray = null;
            }
            else
            {
                moviesres.status = 1;
                Movies ser;
                for (int i = 0; i < movies.Rows.Count; i++)
                {
                    ser = new Movies();
                    ser.MovieId = int.Parse(movies.Rows[i][0].ToString());
                    ser.MovieName = movies.Rows[i][1].ToString();
                    ser.MovieYear = int.Parse(movies.Rows[i][2].ToString());
                    ser.SeriesId = int.Parse(movies.Rows[i][3].ToString());
                    ser.SeriesName = movies.Rows[i][4].ToString();
                    ser.MovieLogo = movies.Rows[i][5].ToString();
                    ser.MovieRating = float.Parse(movies.Rows[i][6].ToString());
                    ser.MoviePlot = movies.Rows[i][7].ToString();
                    ser.VideoID = movies.Rows[i]["VideoID"].ToString();
                    seriesList.Add(ser);
                }
                moviesres.MoviesArray = seriesList;
            }
            return moviesres;
        }

        CharactersResponse charactersres = new CharactersResponse();
        public CharactersResponse GetAllCharacters()
        {
            DataTable movies = new DataTable();
            BCharacters bCalc = new BCharacters();
            movies = bCalc.GetAllCharacters();
            List<Characters> seriesList = new List<Characters> { };
            if (movies == null)
            {
                charactersres.status = 0;
                charactersres.CharactersArray = null;
            }
            else
            {
                charactersres.status = 1;
                Characters ser;
                for (int i = 0; i < movies.Rows.Count; i++)
                {
                    ser = new Characters();
                    ser.CharacterId = int.Parse(movies.Rows[i][0].ToString());
                    ser.CharacterName = movies.Rows[i][1].ToString();
                    ser.CharacterRealName = movies.Rows[i][2].ToString();
                    ser.CharacterLogo = movies.Rows[i][3].ToString();
                    seriesList.Add(ser);
                }
                charactersres.CharactersArray = seriesList;
            }
            return charactersres;
        }

        public CharactersResponse CharactersByMoviesID(Input s)
        {
            DataTable movies = new DataTable();
            BCharacters bCalc = new BCharacters();
            movies = bCalc.CharactersByMoviesID(s.SeriesID);
            List<Characters> seriesList = new List<Characters> { };
            if (movies == null)
            {
                charactersres.status = 0;
                charactersres.CharactersArray = null;
            }
            else
            {
                charactersres.status = 1;
                Characters ser;
                for (int i = 0; i < movies.Rows.Count; i++)
                {
                    ser = new Characters();
                    ser.CharacterId = int.Parse(movies.Rows[i][0].ToString());
                    ser.CharacterName = movies.Rows[i][1].ToString();
                    ser.CharacterRealName = movies.Rows[i][2].ToString();
                    ser.CharacterLogo = movies.Rows[i][3].ToString();
                    seriesList.Add(ser);
                }
                charactersres.CharactersArray = seriesList;
            }
            return charactersres;
        }

        DownloadsResponse downloadres = new DownloadsResponse();
        public DownloadsResponse DownloadsByMoviesID(Input s)
        {
            DataTable downloads = new DataTable();
            BDownloads bCalc = new BDownloads();
            downloads = bCalc.DownloadsByMoviesID(s.SeriesID);
            List<Download> seriesList = new List<Download> { };
            if (downloads == null)
            {
                downloadres.status = 0;
                downloadres.DownloadsArray = null;
            }
            else
            {
                downloadres.status = 1;
                Download ser;
                for (int i = 0; i < downloads.Rows.Count; i++)
                {
                    ser = new Download();
                    ser.DownloadId = int.Parse(downloads.Rows[i]["DownloadId"].ToString());
                    ser.MovieId = int.Parse(downloads.Rows[i]["MovieId"].ToString());
                    ser.QualityId = int.Parse(downloads.Rows[i]["QualityId"].ToString());
                    ser.DownloadLink = downloads.Rows[i]["DownloadLink"].ToString();
                    ser.QualityName = downloads.Rows[i]["QualityName"].ToString();
                    seriesList.Add(ser);
                }
                downloadres.DownloadsArray = seriesList;
            }
            return downloadres;
        }
        //List<Person> objPerson = new List<Person>();
        //int personCount = 0;

        //public Person CreatePerson(Person createPerson)
        //{
        //    createPerson.ID = (++personCount).ToString();
        //    objPerson.Add(createPerson);
        //    return createPerson;
        //}

        //public List<Person> GetAllPerson()
        //{
        //    return objPerson.ToList();
        //}

        //public Person GetAPerson(string id)
        //{
        //    return objPerson.FirstOrDefault(e => e.ID.Equals(id));
        //}

        //public Person UpdatePerson(string id, Person updatePerson)
        //{
        //    Person p = objPerson.FirstOrDefault(e => e.ID.Equals(id));
        //    p.Name = updatePerson.Name;
        //    p.Age = updatePerson.Age;
        //    return p;
        //}

        //public void DeletePerson(string id)
        //{
        //    objPerson.RemoveAll(e => e.ID.Equals(id));
        //}


    }
}