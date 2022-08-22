using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NDbUnit.Core;


namespace Layers.Framework.ADO.Net.Data
{
    public class BasedeDatos
    {
        public static string stringConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        INDbUnitTest mySqlDatabase = new NDbUnit.Core.SqlClient.SqlDbUnitTest(stringConnection);

        

    }
}
