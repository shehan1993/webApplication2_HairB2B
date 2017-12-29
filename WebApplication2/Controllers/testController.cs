using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebApplication2.Controllers
{ 
    public class testController : ApiController 

    {

        string[] listOfSearch = { "ABC", "DEF", "GHI" };



        public string[] Page_Load()
        {
            string[] x = new string[7];
            int i = 0;
            SqlConnection con = new SqlConnection("data source = EYEPAXWS-77\\EYEPAXWS77;database= SmallBakery;integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Debug.WriteLine(rdr["Name"]);
                x[i] = rdr["Name"].ToString();
                i++;

            }
            con.Close();

            return x;
        }







        public string[] Get()
        {
            string[] x = Page_Load();


            return x;

        }

        public void Get(int id)
                {
                    


                }
            


    }
}
