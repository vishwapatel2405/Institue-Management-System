using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IMS_WebAPI.BAL
{
    public class Helper
    {
        protected NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ToString());
    }
}