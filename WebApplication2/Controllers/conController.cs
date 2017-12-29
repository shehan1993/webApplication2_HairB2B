using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Diagnostics;

using QC = System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class conController : ApiController
    {

        static public void Main()
        {
            using (var connection = new QC.SqlConnection(
                "Server=tcp:EYEPAXWS-77\\EYEPAXWS77.database.windows.net,1433;" +
                "Database=SmallBakery;" + "integrated security=SSPI;"

                ))
            {
                connection.Open();
                Console.WriteLine("Connected successfully.");

                Console.WriteLine("Press any key to finish...");
                Console.ReadKey(true);
            }
        }


    }
}
