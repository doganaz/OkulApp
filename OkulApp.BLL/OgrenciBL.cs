using OkulApp1.MODEL;
using System;
using System.Data.SqlClient;
using DAL;
namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            //SqlConnection cn = null;
            //SqlCommand cmd = null;
            //try
            //{
            //    using (cn = new SqlConnection("Data Source=localhost;Initial Catalog=OkulDb;user=sa; password=abc123"))
            //    {
            //        using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
            //        {
            //            SqlParameter[] p =
            //        {
            //        new SqlParameter("@Ad",ogr.Ad),
            //        new SqlParameter("@Soyad",ogr.Soyad),
            //        new SqlParameter("@Numara",ogr.Numara)
            //        };
            //            cmd.Parameters.AddRange(p);
            //            cn.Open();
            //            int sonuc = cmd.ExecuteNonQuery();
            //            return sonuc > 0;
            //        }
            //    }
            //    //cn = new SqlConnection("Data Source=localhost;Initial Catalog=OkulDb;user=sa; password=abc123");
            //    //cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn);

            //    //SqlParameter[] p =
            //    //{
            //    //    new SqlParameter("@Ad",ogr.Ad),
            //    //    new SqlParameter("@Soyad",ogr.Soyad),
            //    //    new SqlParameter("@Numara",ogr.Numara)
            //    //};
            //    //cmd.Parameters.AddRange(p); 

            //    //cn.Open();
            //    //int sonuc = cmd.ExecuteNonQuery();
            //    //return sonuc > 0;
            //}
            //catch (SqlException)
            //{
            //    //switch (ex.Number)
            //    //{
            //    //    case 2627:
            //    //        MessageBox.Show("bu numaralı öğrenci zaten var");
            //    //        break;
            //    //    default:
            //    //        MessageBox.Show("veritabanı hatası");
            //    //        break;
            //    //}
            //    throw;
            //}
            //catch (Exception)
            //{
            //    //MessageBox.Show("bir hata oluştu");
            //    throw;
            //}
            ////finally
            ////{
            ////    if (cn != null && cn.State != ConnectionState.Closed)
            ////    {
            ////        cn.Close();
            ////        cn.Dispose();
            ////        cmd.Dispose();
            ////    }
            //}

            SqlParameter[] p =
                    {
                    new SqlParameter("@Ad",ogr.Ad),
                    new SqlParameter("@Soyad",ogr.Soyad),
                    new SqlParameter("@Numara",ogr.Numara)
            };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert Into tblOgrenciler Values(@Ad,@Soyad,@Numara)", p) > 0;
        }
    }
}
//n Katmanlı Mimari