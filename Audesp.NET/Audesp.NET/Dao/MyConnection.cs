using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Audesp.NET.Dao
{
    public class MyConnection
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
    }
}
