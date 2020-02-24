using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RESTFulDemo
{
    public class Result
    {
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public double Amount { get; set; }
    }
}
