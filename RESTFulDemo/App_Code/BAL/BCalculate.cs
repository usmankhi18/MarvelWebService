using RESTFulDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTfullDemo
{
    public class BCalculate {
        public double Calculate(Currency c)
        {
            double difference;
            DCalculate dCalc = new DCalculate();
            difference = dCalc.FindDifference(c.FromCurrency,c.ToCurrency);
            if (difference == 0)
            {
                return 0;
            }
            else
            {
                c.Amount = c.Amount * difference;
                return c.Amount;
            }
        }
    }
}