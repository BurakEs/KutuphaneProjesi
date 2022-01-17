using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Kutuphane.DataAccess
{
    public class Baglanti
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Smog6\\Desktop\\KutuphaneProjesi\\Kutuphane\\DXApplication1\\Kutuphane.Presentation\\bin\\Debug\\Kutuphane.accdb");

        public OleDbConnection baglantiac() //Bağlantıyı openlamak için yazılan fonks.
        {
            conn.Open();
            return conn;
        }
        public OleDbConnection baglantiKapat() //Bağlantı Kapatmak için yazılan fonks.
        {
            conn.Close();
            return conn;
        }

    }
}
