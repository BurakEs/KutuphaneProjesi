using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.DataTransferObject
{
    public class KitapDTO //Veri Tabanındaki Kolon isimlerinin (Join işlemlerinde kullandıklarımda dahil olmak üzere) tek tek property olarak tanımlanması.
    {
        public int KtpId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string TurAdi { get; set; }
        public string BasimYeri { get; set; }
        public int SayfaSayisi { get; set; }
        public bool Durum { get; set; }
        public string Acıklama { get; set; }
        public int Sayisi { get; set; }


    }
}
