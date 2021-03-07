﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindORM.Facade;

namespace NorthwindORM
{
    public class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        
        public static SqlConnection Baglanti
        {
            get { return baglanti; }
          
        }
        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State!= System.Data.ConnectionState.Open)
                    cmd.Connection.Open();
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (cmd.Connection.State != System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }

            }
            }

    }
}
