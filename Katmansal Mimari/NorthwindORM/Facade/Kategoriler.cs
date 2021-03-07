using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindORM.Entity;
namespace NorthwindORM.Facade
{
   public class Kategoriler
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Kategori_Listele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Insert(Kategori k)
        {
            SqlCommand cmd = new SqlCommand("Kategori_Ekle", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adi", k.KategoriAdi);
            cmd.Parameters.AddWithValue("@Tanimi", k.Tanimi);

            return Tools.ExecuteNonQuery(cmd);
        }
        public static bool Delete(Kategori k)
        {
            SqlCommand cmd = new SqlCommand("KategoriSil", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KategoriID", k.KategoriID);
            return Tools.ExecuteNonQuery(cmd);
        }
        }
    }

