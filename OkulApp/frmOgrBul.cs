using OkulApp.BLL;
using OkulApp1.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class frmOgrBul : Form
    {
        FrmOgrKayit frm;
        public frmOgrBul(FrmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
            if (ogr != null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;
                frm.txtNumara.Text = ogr.Numara;
                frm.OgrenciId = ogr.OgrenciId;
                
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı!!");
            }

            //using(SqlConnection cn=new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler Where Numara=@Numara",cn))
            //    {
            //        SqlParameter[] p = { new SqlParameter("@Numara", txtNumara.Text.Trim()) };
            //        cmd.Parameters.AddRange(p);
            //        cn.Open();
            //        SqlDataReader dr=cmd.ExecuteReader();
            //        Ogrenci ogr = null;
            //        if(dr.Read())
            //        {
            //            //ogr = new Ogrenci();
            //            //ogr.Ad = dr["Ad"].ToString();
            //            //ogr.Soyad = dr["Soyad"].ToString();
            //            //ogr.Numara = dr["Numara"].ToString();
            //            //ogr.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);

            //            frm.txtAd.Text = ogr.Ad;
            //            frm.txtSoyad.Text = ogr.Soyad;
            //            frm.txtNumara.Text = ogr.Numara;

            //            //var frm = new FrmOgrKayit();
            //            //frm.txtAd.Text = ogr.Ad;
            //            //frm.Show();
            //            ///MessageBox.Show($"Ad:{ogr.Ad} Soyad:{ogr.Soyad}");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Öğrenci bulunamadı!");
            //        }
            //        dr.Close();
            //    }
        }
    }
}
