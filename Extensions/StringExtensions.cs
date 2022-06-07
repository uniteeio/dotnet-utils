using System;
using System.Security.Cryptography;
using System.Text;

namespace Unitee.Extensions
{
    public static class StringExtensions
    {
        public static Guid ToGuid(this string src)
        {
            var stringBytes = Encoding.UTF8.GetBytes(src);
            var hashedBytes = SHA1.Create().ComputeHash(stringBytes);
            Array.Resize(ref hashedBytes, 16);
            return new Guid(hashedBytes);
        }
    }
}