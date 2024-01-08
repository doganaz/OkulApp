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
        public bool OgrenciIdSil(Ogrenci ogr)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@Id",ogr.OgrenciId)
            };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@Id", p) > 0;
        }
        public Ogrenci OgrenciBul(string numara)
        {
            var hlp = new Helper();
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler Where Numara=@Numara", p);
            Ogrenci ogr = null;
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
                ogr.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);
                
            }
            dr.Close();
            return ogr;
        }
        public bool OgrenciSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@Id", id) };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from tblOgrenciler Where OgrenciId=@Id", p)>0;

        }
        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@OgrenciId",ogr.OgrenciId)};

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;
        }
    }
}
//n Katmanlı Mimari
//Sil ve güncelle butonları aktifliği kaydın bulunması enabled true false öğrenci bulunma durumuna göre
//textboxların textleri temizlenmesi
//öğrenci bulunduğunda bul formunun kapnması
//try catchler katmanlar arası exception yönetimi
//Dispose Pattern - IDisposeble Interface
//Singleton Design Pattern