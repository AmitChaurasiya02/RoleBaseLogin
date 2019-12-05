using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RoleBaseLogin
{
    public static class commonfun
    {       
        public static SqlConnection connection()
        {
            string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            return con;
        }
    }
    
}