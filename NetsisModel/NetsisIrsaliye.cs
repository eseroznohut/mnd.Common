using System;
using System.Collections.Generic;

namespace mnd.Common.NetsisModel
{
    public enum TFaturaTipi_Pandap
    {
        ft_Bos = 0,
        ft_Kapali = 1,
        ft_Acik = 2,
        ft_Muhtelif = 3,
        ft_Iade = 4,
        ft_ZIade = 5,
        ft_Ihracat = 6,
        ft_YurtIci = 7,
        ft_YurtDisi = 8
    }

    public class NetsisIrsaliye
    {
        public string KullaniciId { get; set; }
        public string NetsisKullaniciAdi { get; set; }
        public string NetsisParola { get; set; }

        public Ust Ust { get; set; }
        public List<FKalem> FKalemleri { get; set; }
    }

    public class Ust
    {
        public string CariKod { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime FiiliTarih { get; set; }
        public DateTime FIYATTARIHI { get; set; }
        public string Aciklama { get; set; }
        public int TIPI { get; set; }

        ///<summary>Teslim tip netsisId</summary>
        public int EXPORTTYPE { get; set; }

        public bool KDV_DAHILMI { get; set; }

        ///<summary>Satış tip özel kod1</summary>
        public string KOD1 { get; set; }

        ///<summary>Satış tip özel kod2</summary>
        public string KOD2 { get; set; }

        ///<summary>Teslim Tarihi</summary>
        public DateTime SIPARIS_TEST { get; set; }

        /// <summary>Fiyat açıklama Lme+ işçilik 2.kalem vs uzuyor m0 </summary>
        public string EKACK1 { get; set; }

        /// <summary>Pandap Test Not m0 </summary>
        public string EKACK8 { get; set; }

        /// <summary> m1 </summary>
        public string EKACK9 { get; set; }

        /// <summary> Fob net brut m2</summary>
        public string EKACK10 { get; set; }

        /// <summary> ödeme vade m3 </summary>
        public string EKACK11 { get; set; }

        /// <summary> Palet sayısı m4 </summary>
        public string EKACK12 { get; set; }

        /// <summary> banka bilgisi m5 </summary>
        public string EKACK13 { get; set; }

        /// <summary> iban  m6</summary>
        public string EKACK14 { get; set; }

        /// <summary> export satır kod m7</summary>
        public string EKACK15 { get; set; }

        /// <summary> Gtip m8 /// </summary>
        public string EKACK16 { get; set; }

        public string Proje_Kodu { get; set; }
        public string PlasiyerKod { get; set; }

        /// <summary> Finansal Garantor /// </summary>
        public string EKACK7 { get; set; }
        public string FATIRS_NO { get; set; }
        public string EXPORTREFNO { get; set; }
    }

    public class FKalem
    {
        public decimal _Lme { get; set; }

        public string _UrunFaturaAd { get; set; }
        public string _KapOlculeri { get; set; }
        public string _KapCinsi { get; set; }
        public int _KapAdet { get; set; }
        public string _GonderilmeSekli { get; set; }
        public string _OdemeYeri { get; set; }
        public double _KdvOran { get; set; }
        public double _KdvTutar { get; set; }
        public string _GTip { get; set; }


        public string NetsisStokKod { get; set; }

        public double STra_GCMIK { get; set; }
        public int Olcubr { get; set; }
        public int Stra_FiyatBirimi { get; set; }

        ///<summary>Satır Net Fiyat</summary>
        public double STra_NF { get; set; }

        ///<summary>Satır Birim Fiyat</summary>
        public double STra_BF { get; set; }

        public int STra_DOVTIP { get; set; }

        public int DOVTIP { get; set; }

        public double STra_DOVFIAT { get; set; }

        public DateTime Stra_FiiliTar { get; set; }
        public DateTime STra_testar { get; set; }

        public int DEPO_KODU { get; set; }

        ///<summary>Kalıklık </summary>
        public string SatirBaziAcik1 { get; set; }

        ///<summary>En </summary>
        public string SatirBaziAcik2 { get; set; }


        /// <summary>Irsaliye numarası gonderilecek netsiste silinirse triggerle pandaptan silinecek</summary>
        public int SatirBaziAcik10 { get; set; }

        public int STra_SatIsk { get; set; }
        public int _SatirId { get; set; }
        public decimal _Iscilik { get; set; }
        public string _DovizYipSimge { get; set; }
        public string _GtipSatirKod { get; set; }
        public string _GTipNo { get; set; }
    }


}
