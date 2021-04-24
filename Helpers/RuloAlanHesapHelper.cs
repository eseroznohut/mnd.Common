using System;

namespace mnd.Common
{
    public class RuloAlanHesapHelper
    {
        public static double RuloAlanHesapla(long PaletNet_Kg, decimal? En, int MasuraSayisi)
        {
            long p1 = PaletNet_Kg * 4000000;

            var p2 = p1 / 2.71 / 3.14 / Convert.ToDouble(En.GetValueOrDefault()) / MasuraSayisi + Math.Pow(150, 2);

            var result1 = Math.Sqrt(p2) * MasuraSayisi * Convert.ToDouble(En.GetValueOrDefault()) / 1000000;

            var result = Math.Round(result1, 2);

            return result;

        }


    }
}
