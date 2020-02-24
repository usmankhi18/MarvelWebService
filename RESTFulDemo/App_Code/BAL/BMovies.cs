using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RESTFulDemo
{
    public class BMovies
    {
        public DataTable GetAllMovies()
        {
            DataTable dtseries = new DataTable();
            DMovies dCalc = new DMovies();
            dtseries = dCalc.GetAllMovies();
            return dtseries;
        }

        public DataTable MoviesBySeries(int SeriesId)
        {
            DataTable dtseries = new DataTable();
            DMovies dCalc = new DMovies();
            dtseries = dCalc.MoviesBySeries(SeriesId);
            return dtseries;
        }

        public DataTable MoviesByCharacterID(int CharacterID)
        {
            DataTable dtseries = new DataTable();
            DMovies dCalc = new DMovies();
            dtseries = dCalc.MoviesByCharacterID(CharacterID);
            return dtseries;
        }
    }
}
