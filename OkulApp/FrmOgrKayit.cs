using OkulApp1.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;

namespace OkulApp
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        //bool OgrenciEkle(Ogrenci ogr)
        //{

        //    SqlConnection cn = null;
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        using(cn = new SqlConnection("Data Source=localhost;Initial Catalog=OkulDb;user=sa; password=abc123"))
        //        {
        //            using(cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
        //            {
        //                SqlParameter[] p =
        //            {
        //            new SqlParameter("@Ad",ogr.Ad),
        //            new SqlParameter("@Soyad",ogr.Soyad),
        //            new SqlParameter("@Numara",ogr.Numara)
        //            };
        //                cmd.Parameters.AddRange(p);

        //                cn.Open();
        //                int sonuc = cmd.ExecuteNonQuery();
        //                return sonuc > 0;
        //            }
        //        }
        //        //cn = new SqlConnection("Data Source=localhost;Initial Catalog=OkulDb;user=sa; password=abc123");
        //        //cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn);

        //        //SqlParameter[] p =
        //        //{
        //        //    new SqlParameter("@Ad",ogr.Ad),
        //        //    new SqlParameter("@Soyad",ogr.Soyad),
        //        //    new SqlParameter("@Numara",ogr.Numara)
        //        //};
        //        //cmd.Parameters.AddRange(p); 

        //        //cn.Open();
        //        //int sonuc = cmd.ExecuteNonQuery();
        //        //return sonuc > 0;
        //    }
        //    catch (SqlException)
        //    {
        //        //switch (ex.Number)
        //        //{
        //        //    case 2627:
        //        //        MessageBox.Show("bu numaralı öğrenci zaten var");
        //        //        break;
        //        //    default:
        //        //        MessageBox.Show("veritabanı hatası");
        //        //        break;
        //        //}
        //        throw;
        //    }
        //    catch (Exception)
        //    {
        //        //MessageBox.Show("bir hata oluştu");
        //        throw;
        //    }
        //    //finally
        //    //{
        //    //    if (cn != null && cn.State != ConnectionState.Closed)
        //    //    {
        //    //        cn.Close();
        //    //        cn.Dispose();
        //    //        cmd.Dispose();
        //    //    }
        //    //}
        //}
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc=obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Öğrenci ekleme başarılı" : "Ekleme başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu numaralı öğrenci zaten var");
                        break;
                    default:
                        MessageBox.Show("veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bir hata oluştu");
            }
        }
    }

    interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);   
    }

    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }
    }
}
