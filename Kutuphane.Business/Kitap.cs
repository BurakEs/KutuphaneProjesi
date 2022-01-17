using Kutuphane.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Kutuphane.Business.DataTransferObject;

namespace Kutuphane.Business
{
    public class Kitap :IKitap
    {
         Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Güncelle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public List<DataTransferObject.KitapDTO> KitapListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi); 
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<KitapDTO> kdto = new List<KitapDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {
                
                
                kdto.Add(new KitapDTO //Listeye ekleme işlemi.
                {
                    KtpId = Convert.ToInt32(Okuyucu["KtpId"].ToString()),
                    KitapAdi = Okuyucu["KitapAdi"].ToString(),
                    YazarAdi = Okuyucu["YazarAdi"].ToString(),
                    TurAdi = Okuyucu["TurAdi"].ToString(),
                    BasimYeri = Okuyucu["BasimYeri"].ToString(),
                    SayfaSayisi = Convert.ToInt32(Okuyucu["SayfaSayisi"].ToString()),
                    Durum = Convert.ToBoolean(Okuyucu["Durum"]),
                    Acıklama = Okuyucu["Acıklama"].ToString(),
                });
            }
            bag.baglantiKapat();
            return kdto;
   
        }
        public List<DataTransferObject.KitapDTO> KitapSayisi(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader();
            List<KitapDTO> kdto = new List<KitapDTO>();
            while (Okuyucu.Read())
            {


                kdto.Add(new KitapDTO
                {
                    Sayisi = Convert.ToInt32(Okuyucu["Sayi"].ToString()),
 
                });
            }
            bag.baglantiKapat();
            return kdto;

        }
    }
}
