using System;
using System.Collections.Generic;
using Kutuphane.Business;
using Kutuphane.Business.DataTransferObject;
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
    public partial class FRMUyeBazlıArama : DevExpress.XtraEditors.XtraForm
    {
        public FRMUyeBazlıArama()
        {
            InitializeComponent();
        }
        public int Uyeıd;
        private void FRMUyeBazlıArama_Load(object sender, EventArgs e)
        {
            IKitapHareket KitapH = new KitapHareket(); //Veri Tabanı Gelen id ile veri listeleme.
            var sonuc = KitapH.KitapHareketListesi("select KhId,Uyeler.UyeId,KtpId,Uyeler.Adi,Uyeler.SoyAdi,Kitaplar.KitapAdi,VerilisTarihi,VerilisSuresi,TeslimTarihi,KitapHareket.Aciklama from Uyeler,KitapHareket,Kitaplar where KitapHareket.UyeId=Uyeler.UyeId And KitapHareket.KitapId=KtpId And Uyeler.UyeId=" +Uyeıd+ "");
            if (sonuc.Count > 0) //Gelen veri varmı ?
            {
               
                GridKontUyeArama.DataSource = sonuc;
            }
            else //Gelen Veri yoksa >
            {
                MessageBox.Show("Seçmiş Olduğunuz Üye ile ilgili bir işlem bulunmamaktadır.", "Sonuç YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void gridUyeArama_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string durum = Convert.ToString(gridUyeArama.GetRowCellValue(e.RowHandle, Coldurumu)); //Üyenin Kitap teslim etme alışkanlığı
            if (durum.Contains("TESLİM ALINDI"))
            {
                e.Appearance.BackColor = Color.LimeGreen;
            }
            if (durum.Contains("Bugün Teslim Edilecek"))
            {
                e.Appearance.BackColor = Color.DarkGoldenrod;
            }
            if (durum.Contains("Gün içinde Teslim Edilecek"))
            {
                e.Appearance.BackColor = Color.Yellow;
            }
            if (durum.Contains("Gün Gecikti."))
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
    }
}