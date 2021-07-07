using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Task08.Helpers
{
    public static class SecurityHelper
    {
        public static Tuple<string, string> GetHashedPasswordAndSalt(string password)
        {
            byte[] saltBytes = new byte[16];
            using var generator = RandomNumberGenerator.Create();
            generator.GetBytes(saltBytes);

            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 32));

            string salt = Convert.ToBase64String(saltBytes);

            return new(hashedPassword, salt);
        }

        public static string GetHashedSaltedPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            var hashedSaltedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 32));
            return hashedSaltedPassword;
        }

    }
}
