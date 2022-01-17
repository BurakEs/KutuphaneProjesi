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

namespace Kutuphane.Presentation.Kitaplar
{
    public partial class FRMKitapBazlıArama : DevExpress.XtraEditors.XtraForm
    {
        public int kitapid;
        public FRMKitapBazlıArama()
        {
            InitializeComponent();

        }

        private void FRMKitapBazlıArama_Load(object sender, EventArgs e)
        {
            IKitapHareket KitapH = new KitapHareket(); //Diğer Formdan Gelen id ile verileri çağırma işlemi.
            var sonuc = KitapH.KitapHareketListesi("select KhId,Uyeler.UyeId,KtpId,Uyeler.Adi,Uyeler.SoyAdi,Kitaplar.KitapAdi,VerilisTarihi,VerilisSuresi,TeslimTarihi,KitapHareket.Aciklama from Uyeler,KitapHareket,Kitaplar where KitapHareket.UyeId=Uyeler.UyeId And KitapHareket.KitapId=KtpId And KtpId="+kitapid+"");
            if ( sonuc.Count > 0) //Veri varmı yokmu kontrolü
            {
                GridKontKitapArama.DataSource = sonuc;
            }
            else
            {
                MessageBox.Show("Seçmiş Olduğunuz Kitap ile ilgili bir işlem bulunmamaktadır.", "Sonuç YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //Formu direk kapamak için veri yoksa eğer.
            }

        }

        private void gridKitapArama_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string durum = Convert.ToString(gridKitapArama.GetRowCellValue(e.RowHandle, Coldurumu)); //Kolonları Günlerine göre renklendirme işlemi.
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