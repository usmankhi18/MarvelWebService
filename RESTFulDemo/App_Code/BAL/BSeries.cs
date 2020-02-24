using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RESTFulDemo
{
    public class BSeries
    {
        public DataTable GetAllSeries()
        {
            DataTable dtseries = new DataTable();
            DSeries dCalc = new DSeries();
            dtseries = dCalc.GetAllSeries();
            return dtseries;
        }
    }
}
