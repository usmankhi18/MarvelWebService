using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RESTFulDemo
{
    public class MoviesResponse
    {
        [DataMember]
        public int status { get; set; }

        [DataMember]
        public List<Movies> MoviesArray { get; set; }
    }

    public class Movies
    {
        [DataMember]
        public int MovieId { get; set; }

        [DataMember]
        public string MovieName { get; set; }

        [DataMember]
        public int MovieYear { get; set; }

        [DataMember]
        public int SeriesId { get; set; }

        [DataMember]
        public string SeriesName { get; set; }

        [DataMember]
        public string MovieLogo { get; set; }

        [DataMember]
        public float MovieRating { get; set; }

        [DataMember]
        public string MoviePlot { get; set; }

        [DataMember]
        public string VideoID { get; set; }
    }
}
