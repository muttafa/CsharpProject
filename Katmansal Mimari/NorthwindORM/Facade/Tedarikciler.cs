﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindORM.Facade
{
   public class Tedarikciler
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Tedarikci_Listele",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
    }
}
