using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RESTFulDemo
{
    public class SeriesResponse
    {
        [DataMember]
        public int status { get; set; }

        [DataMember]
        public List<Series> SeriesArray { get; set; }
    }

    public class Series
    {
        [DataMember]
        public int SeriesId { get; set; }

        [DataMember]
        public string SeriesName { get; set; }

        [DataMember]
        public int SeriesCount { get; set; }

        [DataMember]
        public string SeriesLogo { get; set; }
    }
}
