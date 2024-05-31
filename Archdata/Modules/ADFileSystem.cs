using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archdata.Modules
{
    public class ADFileSystem
    {
        public static byte[] ReadBin(string targetPath)
        {
            using (BinaryReader binaryReader = new BinaryReader(File.Open(targetPath, FileMode.Open)))
            {
                return binaryReader.ReadBytes(Convert.ToInt32(new FileInfo(targetPath).Length));
            }
        }

        public static void WriteBin(string targetPath, byte[] writableData)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(targetPath, FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(writableData);
            }
        }

        public static void AppendBin(string targetPath, byte[] appendData)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(targetPath, FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(appendData);
            }
        }
    }
}
