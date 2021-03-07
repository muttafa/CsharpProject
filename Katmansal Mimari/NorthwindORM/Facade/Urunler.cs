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
    public class Urunler
    {
        public static DataTable Select()
        {
            Urun u = new Urun();
            SqlDataAdapter adp = new SqlDataAdapter("Urun_Listele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();

            adp.Fill(dt);

            return dt;
        }
        public static bool Insert(Urun u)
        {
            SqlCommand cmd = new SqlCommand("Urun_Ekle", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@HedefStokDuzeyi", u.HedefStokDuzeyi);
            cmd.Parameters.AddWithValue("@BirimFiyati", u.BirimFiyati);
            cmd.Parameters.AddWithValue("@KategoriID", u.KategoriID);
            cmd.Parameters.AddWithValue("@BirimdekiMiktar", u.BirimdekiMiktar);
            cmd.Parameters.AddWithValue("@TedarikciID", u.TedarikciID);
            return Tools.ExecuteNonQuery(cmd);

        }
        public static bool Delete(Urun u)
        {
            SqlCommand cmd = new SqlCommand("Urun_Sil", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunID", u.UrunID);

            return Tools.ExecuteNonQuery(cmd);
        }

        public static bool Guncelle(Urun u)
        {
            SqlCommand cmd = new SqlCommand("Urun_Guncelle", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunID", u.UrunID);
            cmd.Parameters.AddWithValue("@UrunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@HedefStokDuzeyi", u.HedefStokDuzeyi);
            cmd.Parameters.AddWithValue("@BirimFiyati", u.BirimFiyati);
            cmd.Parameters.AddWithValue("@KategoriID", u.KategoriID);
            cmd.Parameters.AddWithValue("@BirimdekiMiktar", u.BirimdekiMiktar);
            cmd.Parameters.AddWithValue("@TedarikciID", u.TedarikciID);

            return Tools.ExecuteNonQuery(cmd);



        }

    }
}

