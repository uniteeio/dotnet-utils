using System;
using System.Text;

namespace ImproveYourDotnetStyle.Extensions
{
    public static class StringExtensions
    {
        public static Guid ToGuid(this string src)
        {
            byte[] stringBytes = Encoding.UTF8.GetBytes(src);
            byte[] hashedBytes = new System.Security.Cryptography
                    .SHA1CryptoServiceProvider()
                .ComputeHash(stringBytes);
            Array.Resize(ref hashedBytes, 16);
            return new Guid(hashedBytes);
        }
    }
}