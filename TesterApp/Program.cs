using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archdata.Modules;
using static System.Net.Mime.MediaTypeNames;

namespace TesterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing: 1234567890qwertyuiopasdfghjklzxcvbnm");


            byte[] data = Encoding.UTF8.GetBytes("1234567890qwertyuiopasdfghjklzxcvbnm");
            ADFileSystem.WriteBin("test.ad", data);

            Console.WriteLine("File: " + BitConverter.ToString(ADFileSystem.ReadBin("test.ad")));

            Console.WriteLine("Decoded: " + Encoding.UTF8.GetString(ADFileSystem.ReadBin("test.ad")));

            Console.ReadKey();
        }
    }
}
