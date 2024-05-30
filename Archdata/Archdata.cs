using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotMesh.Archdata
{
    public class Archdata
    {
        public Archdata() { }

        public string Get() { return String.Empty; }

        public int GetInt() { return 0; }

        public bool GetBool() { return false; }

        public float GetFloat() { return 0f; }
    }

    public class ArchdataFile
    {
        public static string Get() { return String.Empty; }

        public static int GetInt() { return 0; }

        public static bool GetBool() { return false; }

        public static float GetFloat() { return 0f; }
    }
}
