using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RESTFulDemo
{
    public class BCharacters
    {
        public DataTable GetAllCharacters()
        {
            DataTable dtseries = new DataTable();
            DCharacters dCalc = new DCharacters();
            dtseries = dCalc.GetAllCharacters();
            return dtseries;
        }

        public DataTable CharactersByMoviesID(int MoviesID)
        {
            DataTable dtseries = new DataTable();
            DCharacters dCalc = new DCharacters();
            dtseries = dCalc.CharactersByMoviesID(MoviesID);
            return dtseries;
        }
    }
}
