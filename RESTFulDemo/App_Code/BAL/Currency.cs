using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RESTFulDemo
{
    [DataContract]
    public class Currency
    {
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public string FromCurrency { get; set; }
        [DataMember]
        public string ToCurrency { get; set; }
    }

    [DataContract]
    public class Input
    {
        [DataMember]
        public int SeriesID { get; set; }
    }
}
