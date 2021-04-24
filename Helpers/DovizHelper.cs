namespace mnd.Common
{
    public class DovizHelper
    {
        public static string SimgeyeDonustur(string dovizAd)
        {
            if (dovizAd == null) return "";
            if (dovizAd.ToUpper() == "USD") return "$";
            if (dovizAd.ToUpper() == "EUR") return "€";
            if (dovizAd.ToUpper() == "GBP") return "£";
            if (dovizAd.ToUpper() == "TL") return "₺";

            return "";

        }

        public static int NetsisDovizKodGetir(string dovizAd)
        {
            if (dovizAd.ToUpper() == "USD") return 2;
            if (dovizAd.ToUpper() == "EUR") return 3;
            if (dovizAd.ToUpper() == "GBP") return 5;
            if (dovizAd.ToUpper() == "TL") return 0;

            return 0;

        }
    }
}
