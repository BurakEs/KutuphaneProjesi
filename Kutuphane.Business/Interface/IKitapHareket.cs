using Kutuphane.Business.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business
{
    public interface IKitapHareket
    {        //İnterface fonksiyon biçim tanımlaması.
        void Ekle(string SorguCümlesi);
        void Sil(string SorguCümlesi);
        void Güncelle(string SorguCümlesi);
        List<KitapHareketDTO> KitapHareketListesi(string SorguCümlesi);
    }
}
