
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Bank_Utilities
{
    public class clsRememberMe
    {
        private static readonly string KeyPath =
            @"HKEY_CURRENT_USER\Software\YourSoftware\Bank";

        private static readonly string ValueName1 = "UserName";
        private static readonly string ValueName2 = "Password";

        public static bool RememberUsernameAndPassword(
            string Username, string Password)
        {
            try
            {
                byte[] encryptedBytes = ProtectedData.Protect(
                    Encoding.UTF8.GetBytes(Password),
                    null,
                    DataProtectionScope.CurrentUser);

                string encryptedPassword =
                    Convert.ToBase64String(encryptedBytes);

                Registry.SetValue(
                    KeyPath,
                    ValueName1,
                    Username,
                    RegistryValueKind.String);

                Registry.SetValue(
                    KeyPath,
                    ValueName2,
                    encryptedPassword,
                    RegistryValueKind.String);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetStoredCredential(
            ref string Username, ref string Password)
        {
            try
            {
                Username = Registry.GetValue(
                    KeyPath, ValueName1, null) as string;

                string encryptedPassword = Registry.GetValue(
                    KeyPath, ValueName2, null) as string;

                if (string.IsNullOrWhiteSpace(Username) ||
                    string.IsNullOrWhiteSpace(encryptedPassword))
                {
                    Username = "";
                    Password = "";
                    return false;
                }

                byte[] encryptedBytes =
                    Convert.FromBase64String(encryptedPassword);

                byte[] decryptedBytes = ProtectedData.Unprotect(
                    encryptedBytes,
                    null,
                    DataProtectionScope.CurrentUser);

                Password = Encoding.UTF8.GetString(decryptedBytes);

                return true;
            }
            catch
            {
                Username = "";
                Password = "";
                return false;
            }
        }

        public static bool DeleteCredentials()
        {
            try
            {
                Registry.CurrentUser.DeleteSubKey(
                    @"Software\YourSoftware\Bank", false);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
