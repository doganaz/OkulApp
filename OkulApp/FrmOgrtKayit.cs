using OkulApp.BLL;
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

namespace OkulApp
{
    public partial class FrmOgrtKayit : Form
    {
        public FrmOgrtKayit()
        {
            InitializeComponent();
        }

        private void btnKaydetOgrt_Click(object sender, EventArgs e)
        {
            try
            {
                var ogbl = new OgretmenBL();
                bool sonuc = ogbl.OgretmenEkle(new Ogretmen { TcNo = txtTc.Text.Trim(), OgretmenAdi = txtAdOgrt.Text.Trim(), OgretmenSoyadi = txtSoyadOgrt.Text.Trim()});
                MessageBox.Show(sonuc ? "Öğretmen ekleme başarılı" : "Ekleme başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu numaralı öğretmen zaten var");
                        break;
                    default:
                        MessageBox.Show("veritabanı hatası");
                        throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bir hata oluştu");
            }
        }
    }
}
