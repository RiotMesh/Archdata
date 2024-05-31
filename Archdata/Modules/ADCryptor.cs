using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archdata.Modules
{
    internal class ADCryptor
    {
        public static string Encode(string value)
        {
            byte[] data = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(data);
        }

        public static string Decode(string value)
        {
            byte[] data = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(data);
        }
    }
}
