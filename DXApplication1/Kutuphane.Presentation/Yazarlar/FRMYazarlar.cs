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

namespace Kutuphane.Presentation.Yazarlar
{
    public partial class FRMYazarlar : DevExpress.XtraEditors.XtraForm
    {
        IYazar Yazar;
        public FRMYazarlar()
        {
            InitializeComponent();
        }
        public void YazarListesiGöster()
        {
            Yazar = new Yazar();
            var sonuc = Yazar.YazarListesi("select * from Yazarlar"); //veri çekme işlemi.
            GridKontYazar.DataSource = sonuc;
        }

        private void FRMYazarlar_Load(object sender, EventArgs e)
        {
            YazarListesiGöster();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FRMYazarEkle FYazar = new FRMYazarEkle();
            FYazar.ShowDialog(); //Veri Ekleme için diğer formu çağırma.
            YazarListesiGöster();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridYazar.GetFocusedRowCellValue(ID)); //seçili satır id çekme işlemi
            FRMYazarEkle Gnclm = new FRMYazarEkle();
            Gnclm.Secilenid = SecilenId;
            Gnclm.GuncellemeKontrol = 1;
            Gnclm.ShowDialog();
            YazarListesiGöster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridYazar.GetFocusedRowCellValue(ID)); //seçili satır id çekme işlemi
            var SecilenYazar = gridYazar.GetFocusedRowCellValue(YazarAdı); //seçili satır Yazaradı çekme işlemi
            IYazar Yazarlar = new Yazar();
            DialogResult secim = MessageBox.Show(SecilenYazar.ToString() + " Tcli kişiyi silmek istediğinize Eminmisiniz ?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes) //Messagebox ile Son Kontrol kısmı.
            { Yazarlar.Sil("Delete From Yazarlar where Id=" + Secilenid + ""); MessageBox.Show("Silme İşlemi Başarı ile Gerçekleşti."); }
            else
            {
                MessageBox.Show("Silme İşlemi iptal edildi.");
            }
            YazarListesiGöster();
        }
    }
}