using System;
using System.Collections.Generic;
using System.Linq;

namespace mnd.Common.Helpers
{
    public class BOBIN_KONUM
    {
        public static string DH => nameof(DH);
        public static string DH1 => nameof(DH1);
        public static string DH2 => nameof(DH2);
        public static string DH3 => nameof(DH3);
        public static string DH_BITIS_DEPO => nameof(DH_BITIS_DEPO);


        public static string LTF => nameof(LTF);
        public static string LTF1 => nameof(LTF1);
        public static string LTF2 => nameof(LTF2);
        public static string LTF3 => nameof(LTF3);
        public static string LTF_SON_DEPO => nameof(LTF_SON_DEPO);




        public static string SH => nameof(SH);
        public static string SH1 => nameof(SH1);
        public static string SH2 => nameof(SH2);
        public static string SH3 => nameof(SH3);
        public static string SH_SON_DEPO => nameof(SH_SON_DEPO);



    }


    public class BOBIN_ISLEMADIM_DURUM
    {
        public static string HAZIR => nameof(HAZIR);
        public static string ÇALIŞIYOR => nameof(ÇALIŞIYOR);
        public static string BİTTİ => nameof(BİTTİ);

        public static string DURDURULDU => nameof(DURDURULDU);


    }


    public class RISKHESAPSEKLI
    {
        public static string GenelTakip => nameof(GenelTakip);
        public static string Operasyon => nameof(Operasyon);

        public static string Satış => nameof(Satış);

    }


    public class ULASIMTIP
    {
        public static string Karayolu => nameof(Karayolu);
        public static string Denizyolu => nameof(Denizyolu);


    }

    public class IRSALIYEDURUM
    {
        public static string BEKLIYOR => nameof(BEKLIYOR);
        public static string AKTARILDI => nameof(AKTARILDI);


    }

    public class PALETKONUM
    {
        public static string PAKETLEME => nameof(PAKETLEME);
        public static string DEPO_ONAY => nameof(DEPO_ONAY);
        public static string URETIME_GERI_VERILEN => nameof(URETIME_GERI_VERILEN);
        public static string DEPO => nameof(DEPO);
        public static string SEVKEMRI => nameof(SEVKEMRI);
        public static string SEVKEDILDI => nameof(SEVKEDILDI);
        public static string KARANTINA => nameof(KARANTINA);
     

        public static string AKTIFSEVKEMRI => nameof(AKTIFSEVKEMRI);

        public static string TUMU => nameof(TUMU);

    }


    public class SEVKSURECKONUM
    {
        public static string OPERASYON => nameof(OPERASYON);
        public static string DEPO => nameof(DEPO);
        public static string YUKLEME => nameof(YUKLEME);  // YADA operasyona bilgi

        public static string PLAN_YONETICI => nameof(PLAN_YONETICI);
        public static string OPERASYON_KONTROL => nameof(OPERASYON_KONTROL);
        public static string MUHASEBE => nameof(MUHASEBE);

        public static string AKTIFYUKLEME { get; set; }
    }

    public struct SATISTIPI
    {
        public const string YI = nameof(YI);
        public const string YD = nameof(YD);
    }

    public class KULLANICIROLLERI
    {
        public static string GUVENLIK => nameof(GUVENLIK);

        public static string ADMIN => nameof(ADMIN);
        public static string OPERASYON => nameof(OPERASYON);

        public static string YONETICI => nameof(YONETICI);
        public static string PAKETLEME => nameof(PAKETLEME);

        public static string KALITE => nameof(KALITE);
        public static string MAMULDEPO => nameof(MAMULDEPO);
        public static string PLANLAMA => nameof(PLANLAMA);
        public static string PLANLAMA_YONETICI => nameof(PLANLAMA_YONETICI);

        public static string MUHASEBE => nameof(MUHASEBE);
        public static string MUHASEBE_YONETICI => nameof(MUHASEBE_YONETICI);

        public static string SATIS => nameof(SATIS);
        public static string SATIS_DESTEK => nameof(SATIS_DESTEK);

        public static string SATISYONETICI_BOLGE => nameof(SATISYONETICI_BOLGE);
        public static string SATIS_YONETICI => nameof(SATIS_YONETICI);

        public static string SATINALMA => nameof(SATINALMA);
        public static string SATINALMA_YONETICI => nameof(SATINALMA_YONETICI);

        public static string URETIM_OPERATOR => nameof(URETIM_OPERATOR);


        public static string HDEPO_UZM_USER =>nameof(HDEPO_UZM_USER);

        public static string HDEPO_SORUMLUSU=> nameof(HDEPO_SORUMLUSU);



        


    }


    public class SATINALMA_SURECDURUM
    {

        public static string TALEPKAYIT => "TALEPKAYIT";
        public static string BIRIM_AMIR_ONAYINDA => "BIRIM_AMIR_ONAYINDA";
        public static string TALEP_ATAMA => "TALEP_ATAMA";
        public static string TEKLIF_ISTEME => "TEKLIF_ISTEME";
        public static string KARAR_FORMU_ONAY => "KARAR_FORMU_ONAY";
        public static string YONETICI_ONAYINDA => "YONETICI_ONAYINDA";
        public static string ONAYLANAN_SIPARISLER => "ONAYLANAN_SIPARISLER";
        public static string VERILEN_SIPARISLER => "VERILEN_SIPARISLER";
        public static string KALITE_ONAYI_BEKLEYENLER => "KALITE_ONAYI_BEKLEYENLER";
        public static string KALITE_ONAYLI_SIPARISLER => "KALITE_ONAYLI_SIPARISLER";
        public static string KALITE_RED => "KALITE_RED";
        public static string IRSALIYE_OLUSTURULANLAR => "IRSALIYE_OLUSTURULANLAR";
        public static string ARSIV => "ARSIV";
    }


    public class SIPARISSURECDURUM
    {
        public static string YENIKAYIT => "YENIKAYIT";
        public static string SATISTA => "SATIŞTA";

        public static string SATIS_BOLGEYONETICIONAYINDA => "SATIŞ BÖLGE YÖNETİCİ ONAYINDA";
        public static string SATIS_YONETICIONAYINDA => "SATIŞ YÖNETİCİ ONAYINDA";
        public static string PLANLAMADA => "PLANLAMADA";
        public static string YONETICIONAYINDA => "YÖNETİCİ ONAYINDA";
        public static string MUSTERIONAYINDA => "MÜŞTERİ ONAYINDA";
        public static string MUSTERIONAYLI => "MÜŞTERİ ONAYLI";
        public static string SIPARISKARANTINA => "SİPARİŞ KARANTİNADA";
        public static string KAPALISIPARIS => "KAPALI SİPARİŞ";

        public static string ARSIV => "ARŞİV";

        private static List<string> surecDurumListe;

        static SIPARISSURECDURUM()
        {
            surecDurumListe = new List<string>();

            Type tSipDurum = typeof(SIPARISSURECDURUM);

            var propList = tSipDurum.GetProperties().ToList().Select(c => (string)c.GetValue(tSipDurum));

            surecDurumListe.AddRange(propList);
        }

        public static List<string> SurecDurumListesiGetir()
        {
            return surecDurumListe;
        }
    }

    public class MUSTERIGRUBU
    {
        public static string POTANSIYELMUSTERI => "POTANSIYELMUSTERI";
        public static string POTANSIYELDISI => "POTANSIYELDISI";
        public static string MUSTERI => "MUSTERI";
    }

    public enum FormulEnum
    {
        Metraj_Rulodan,
        RuloAgirligiMax_Metrajdan,
        RuloAgirligiMax_Rulodan,
        Discap_Rulodan
    }

    public enum KayitModu
    {
        Add,
        Edit,
        Default
    }

    public enum Language
    {
        TR,
        EN
    }
}