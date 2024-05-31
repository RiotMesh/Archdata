using Archdata.Modules;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*--- WIP ROAD
 * X > MAIN SKELETON
 * X > MODULES
 * X > BASE64 EN/DE CODE
 * O > MANUAL DISABLE/ENABLE BINARY MODE
 * O > MANUAL DISABLE/ENABLE BASE64 MODE
 * O > SUPPORT CUSTOM VIRTUAL METHOD FOR EN/DE CRYPTING
*/
namespace RiotMesh.Archdata
{
    public class Archdata
    {
        internal string archdataFilePath;

        public Archdata(string adFilePath)
        {
            archdataFilePath = adFilePath;
        }

        public string Get(string key)
        {
            byte[] baseData = ADFileSystem.ReadBin(archdataFilePath);
            string decodedData = ADCryptor.Decode(Encoding.UTF8.GetString(baseData));
            return GetValueByKey(key, decodedData);
        }

        public int GetInt(string key)
        {
            if (int.TryParse(Get(key), out int convertedValue))
            {
                return convertedValue;
            }
            else
                throw new Exception($"Founded value in key '{key}' does not match integer type!");
        }

        public bool GetBool(string key)
        {
            string keyValue = Get(key);
            if (keyValue == "true")
                return true;
            else if (keyValue == "false")
                return false;
            else
                throw new Exception($"Founded value in key '{key}' does not match boolean type!");
        }

        public float GetFloat(string key)
        {
            if (float.TryParse(Get(key), out float convertedValue))
            {
                return convertedValue;
            }
            else
                throw new Exception($"Founded value in key '{key}' does not match float type!");
        }

        internal string GetValueByKey(string key, string context)
        {
            Match rxMatch = Regex.Match(context, $"{key} : (.+?)\r?\n");
            if (rxMatch.Success)
            {
                return rxMatch.Groups[1].Value;
            }
            else throw new Exception($"Key '{key}' not found in configuration file!");
        }

        /*internal string ReplaceValueByKey(string input, string key, string newValue)
        {
            var regex = new Regex($"{key} : (.+?)\r?\n");
            if (regex.IsMatch(input))
            {
                return regex.Replace(input, $"{key} : {newValue}\r\n");
            }
            return "key nf";
        }*/
    }

    public class ArchdataFile
    {
        public static string Get() { return String.Empty; }

        public static int GetInt() { return 0; }

        public static bool GetBool() { return false; }

        public static float GetFloat() { return 0f; }
    }
}
