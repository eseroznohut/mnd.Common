using System;
using System.Security;
using System.Text;

namespace EdenetimAsistan.Shared
{
    public static class GyCyripto
    {
        //var encrptoString = GyCyripto.EncryptString(GyCyripto.ToSecureString(PasswordTextBox.Text));
        //var decrptoString = GyCyripto.ToInsecureString(GyCyripto.DecryptString(crptoString));

        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("tuzlama");

        public static string Kriptola(string clearText)
        {
            var securestring = ToSecureString(clearText);
            return EncryptString(securestring);
        }

        public static string KriptoCoz(string encryptedData)
        {
            var secureString = DecryptString(encryptedData);

            return ToInsecureString(secureString);


        }


        private static string EncryptString(System.Security.SecureString input)
        {
            byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
                null,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        private static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    null,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        private static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        private static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }
    }
}
