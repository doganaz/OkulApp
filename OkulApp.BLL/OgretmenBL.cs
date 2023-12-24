using DAL;
using OkulApp1.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p =
                    {
                    new SqlParameter("@TcNo",ogrt.TcNo),
                    new SqlParameter("@OgretmenAdi",ogrt.OgretmenAdi),
                    new SqlParameter("@OgretmenSoyadi",ogrt.OgretmenSoyadi),                  
            };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert Into tblOgretmenler Values(@TcNo, @OgretmenAdi,@OgretmenSoyadi)", p) > 0;
        }
    }
}
