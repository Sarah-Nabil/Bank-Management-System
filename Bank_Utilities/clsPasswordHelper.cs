
using System;
using System.Security.Cryptography;

namespace Bank_Utilities
{
    public class clsPasswordHelper
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[SaltSize];

            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                return "PBKDF2$" + Iterations + "$"
                    + Convert.ToBase64String(salt) + "$"
                    + Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(
            string password,
            string storedPassword)
        {
            try
            {
                string[] parts = storedPassword.Split('$');

                if (parts.Length != 4 || parts[0] != "PBKDF2")
                    return false;

                int iterations = int.Parse(parts[1]);
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] storedHash = Convert.FromBase64String(parts[3]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(storedHash.Length);

                    if (hash.Length != storedHash.Length)
                        return false;

                    int difference = 0;

                    for (int i = 0; i < hash.Length; i++)
                    {
                        difference |= hash[i] ^ storedHash[i];
                    }

                    return difference == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
