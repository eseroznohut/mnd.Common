using System;
using System.Linq;

namespace mnd.Common
{

    /// TODO sevkiyat emrini açınca sorun verdi bobin adet bul da yanlış çalışıyor paketleme veri girişi yaparken kontrol et

    public class BobinSayiHelper
    {


        public static int BobinAdetBul(string bobinNo)
        {

            if (bobinNo.ToUpper().Contains("S")) return 1;

            bobinNo = bobinNo.TrimEnd(';').Replace(";", ",").Replace("*", "").Replace("--", "-");

            if (bobinNo.Count(f => f == ',') == 0 && bobinNo.Count(f => f == '-') > 2)
            {
                bobinNo = bobinNo.Replace('-', ',');
            }

            if (bobinNo.Count(f => f == ',') == 0 && bobinNo.Count(f => f == '/') > 1)
            {
                bobinNo = bobinNo.Replace('/', ',');
            }

            var sayilar = bobinNo.Split(',');

            int bobinSayisi = 0;

            foreach (var item in sayilar)
            {
                var altgrup_sayilar = item.Split('-');

                if (altgrup_sayilar.Count() == 1)
                    bobinSayisi += 1;
                else
                    bobinSayisi += Math.Abs(int.Parse(altgrup_sayilar[1]) - int.Parse(altgrup_sayilar[0])) + 1;
            }

            return bobinSayisi;
        }
    }
}
