using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KelimeOyunu
{
    class Veritabani
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataTable dt;

        Random rnd;
        string sorgu;

        int soru;

        public Veritabani(string tablo)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NLC5D20\\SQL;Initial Catalog=Kelimeler;Integrated Security=True");
            sorgu = "SELECT * FROM " + tablo;
            da = new SqlDataAdapter(sorgu, baglanti);
            dt = new DataTable();
            da.Fill(dt);
        }

        public string Soru()
        {
            rnd = new Random();
            soru = rnd.Next(dt.Rows.Count);

            return dt.Rows[soru][1].ToString(); ;
        }

        public string Cevap()
        {
            return dt.Rows[soru][2].ToString();
        }



    }
}
