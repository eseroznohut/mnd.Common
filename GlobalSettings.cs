using EdenetimAsistan.Shared;
using Microsoft.Win32;
using mnd.Common.Properties;
using System.Data.SqlClient;

namespace mnd.Common
{
    public class GlobalSettings
    {
        public static GlobalSettings Default;

        static GlobalSettings()
        {
            Default = new GlobalSettings();
        }

        public string SqlCnnString { get; set; }
        public string KullaniciParola { get; set; }
        public string KullaniciAdi { get; set; }


        public string Sunucu { get; set; }
        public string DbUser { get; set; }
        public string DbUserPass { get; set; }

        public string BeniHatirla { get; set; }

        public string BaglantiTip { get; set; }

       

        public GlobalSettings()
        {
            DegerleriYukle();
        }

        private void DegerleriYukle()
        {
            BeniHatirla = Registry.CurrentUser.OpenSubKey("mndApp")?.GetValue("BeniHatirla")?.ToString();
           
            KullaniciParola = GyCyripto.KriptoCoz(Registry.CurrentUser.OpenSubKey("mndApp")?.GetValue("Parola")?.ToString());
            KullaniciAdi = Registry.CurrentUser.OpenSubKey("mndApp")?.GetValue("KullaniciAdi")?.ToString();
            SqlCnnString = GyCyripto.KriptoCoz(Registry.CurrentUser.OpenSubKey("mndApp")?.GetValue("SqlPath")?.ToString());

            SqlConnectionStringBuilder cnnBuilder = new SqlConnectionStringBuilder(SqlCnnString);

            Sunucu = cnnBuilder.DataSource;
            DbUser = cnnBuilder.UserID;
            DbUserPass = cnnBuilder.Password;


        

        }

        public void Kaydet()
        {
            Registry.CurrentUser.CreateSubKey("mndApp").SetValue("BeniHatirla", BeniHatirla);

            Registry.CurrentUser.CreateSubKey("mndApp").SetValue("KullaniciAdi", KullaniciAdi);
            Registry.CurrentUser.CreateSubKey("mndApp").SetValue("Parola", GyCyripto.Kriptola(KullaniciParola) );


            SqlCnnString = $"server={Sunucu};database=MNDAPPDB;user id={DbUser};password={DbUserPass};MultipleActiveResultSets=true;App=Pandap-{KullaniciAdi}";
            Registry.CurrentUser.CreateSubKey("mndApp").SetValue("SqlPath", GyCyripto.Kriptola(SqlCnnString));

        }

    }
}
