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
    public class Yazar : IYazar
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi)//Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }//Gelen Sorguyu işleme aşaması.

        public void Güncelle(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }//Gelen Sorguyu işleme aşaması.

        public List<DataTransferObject.YazarDTO> YazarListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader();//Okumak için datareader dan bir nesne oluşturuyoruz.
            List<YazarDTO> yzrdto = new List<YazarDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read())
            {


                yzrdto.Add(new YazarDTO //Listeye ekleme işlemi.
                {
                    Id = Convert.ToInt32(Okuyucu["Id"]),
                    YazarAdi = Okuyucu["YazarAdi"].ToString(),
                    DogumYili = Convert.ToDateTime(Okuyucu["DogumYili"]),
                    DogumYeri = Okuyucu["DogumYeri"].ToString(),
                    Aciklama = Okuyucu["Aciklama"].ToString()
                });
            }
            bag.baglantiKapat();
            return yzrdto;
            throw new NotImplementedException();
        }
    }
}
