using System;
using Kutuphane.Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.Uyeler
{
    public partial class FRMUyeEkle : DevExpress.XtraEditors.XtraForm
    {
        public int Secilenid, GuncellemeKontrol = 0;
        public FRMUyeEkle()
        {


            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (GuncellemeKontrol == 1)
            {
                #region Uye Guncelle
                if (TxtTcNo.Text != "" && TxtAdi.Text != "" && TxtSoyAdi.Text != "" && TxtAcik.Text != "" && (Convert.ToDouble(TxtTcNo.Text) >= 1000000000) && (Convert.ToDouble(TxtTcNo.Text) <= 99999999999))
                {
                    IUye Uyeler = new Uye();
                    Uyeler.Güncelle("update Uyeler set TcKimlikNo = '" + TxtTcNo.Text + "', Adi = '" + TxtAdi.Text + "', SoyAdi = '" + TxtSoyAdi.Text + "', KayıtTarihi='" + DateTimeKayıtTarihi.Value + "', Aciklama = '" + TxtAcik.Text + "' where UyeId=" + Secilenid + "");
                    MessageBox.Show("Güncelleme işlemi başarı ile gerçekleşti", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if ((Convert.ToDouble(TxtTcNo.Text) <= 1000000000) && (Convert.ToDouble(TxtTcNo.Text) >= 99999999999))
                    {
                        MessageBox.Show("Tc Kimlik No 11 Haneden Büyük veya Küçük Olamaz!!!");
                    }
                    else
                    {
                        MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
                    }
                }
                #endregion
            }
            else
            {
                #region Üye Ekleme
                if (TxtTcNo.Text != "" && TxtAdi.Text != "" && TxtSoyAdi.Text != "" && TxtAcik.Text != "" && (Convert.ToDouble(TxtTcNo.Text) >= 10000000000) && (Convert.ToDouble(TxtTcNo.Text) <= 99999999999))
                {
                    IUye Uyeler = new Uye();
                    Uyeler.Ekle("insert into Uyeler (TcKimlikNo,Adi,SoyAdi,KayıtTarihi,Aciklama) values ('" + TxtTcNo.Text + "','" + TxtAdi.Text + "','" + TxtSoyAdi.Text + "','" + DateTimeKayıtTarihi.Value.ToString("d") + "','" + TxtAcik.Text + "')");
                    MessageBox.Show(TxtTcNo.Text + " TC Nolu Kayıt Başarı İle Oluşturulmuştur.");
                    DialogResult secim = MessageBox.Show("Kayıt işlemine Devam etmek istermisiniz ?", "Üye Ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {
                        TxtTcNo.Text = "";
                        TxtAdi.Text = "";
                        TxtSoyAdi.Text = "";
                        TxtAcik.Text = "";
                        DateTimeKayıtTarihi.Value = DateTime.Now;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    if ((Convert.ToDouble(TxtTcNo.Text) <= 1000000000) && (Convert.ToDouble(TxtTcNo.Text) >= 99999999999))
                    {
                        MessageBox.Show("Tc Kimlik No 11 Haneden Büyük veya Küçük Olamaz!!!");
                    }
                    else
                    {
                        MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
                    }
                }
                #endregion
            }
        }

        private void FRMUyeEkle_Load(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1)
            {
                this.Text = "Üye Güncelleme ";
                this.LblUye.Text= "Üye Güncelleme";
                this.BtnKaydet.Text = "Güncelle";
                IUye Uyeler = new Uye();

                var SeciliIdBilgileri = Uyeler.UyeListesi("select * from Uyeler where UyeId=" + Secilenid + "");
                foreach (var item in SeciliIdBilgileri)
                {
                    TxtTcNo.Text = item.TcKimlikNo;
                    TxtAdi.Text = item.Adi;
                    TxtSoyAdi.Text = item.SoyAdi;
                    DateTimeKayıtTarihi.Value = item.KayıtTarihi;
                    TxtAcik.Text = item.Aciklama;
                }
            }

        }
    }
}