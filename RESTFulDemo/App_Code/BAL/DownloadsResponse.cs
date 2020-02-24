using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RESTFulDemo
{
    public class DownloadsResponse
    {
            [DataMember]
            public int status { get; set; }

            [DataMember]
            public List<Download> DownloadsArray { get; set; }
     }

        public class Download
        {
            [DataMember]
            public int DownloadId { get; set; }

            [DataMember]
            public int MovieId { get; set; }

            [DataMember]
            public int QualityId { get; set; }

            [DataMember]
            public string DownloadLink { get; set; }

            [DataMember]
            public string QualityName { get; set; }
    }
    }