using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.DataTransferObject
{
    public class YazarDTO //Veri Tabanındaki Kolon isimlerinin (Join işlemlerinde kullandıklarımda dahil olmak üzere) tek tek property olarak tanımlanması.
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public DateTime DogumYili { get; set; }
        public string DogumYeri { get; set; }
        public string Aciklama { get; set; }
    }
}
