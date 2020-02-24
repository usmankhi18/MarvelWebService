using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTfullDemo
{
    public class DCalculate {
        public double FindDifference(string FromCurrency, string ToCurrency ) {
            double rate;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            SqlParameter param1,param2;
            DataSet ds = new DataSet();
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spLoadRates";

            param1 = new SqlParameter("@FromCountry", FromCurrency);
            param2 = new SqlParameter("@ToCountry", ToCurrency);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

             rate =  double.Parse(ds.Tables[0].Rows[0][ToCurrency].ToString());

            connection.Close();
            return rate;
        }
    }
}