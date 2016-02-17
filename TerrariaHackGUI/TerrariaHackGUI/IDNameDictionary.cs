using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaHack
{
    public static class IDNameDictionary
    {
        public static Dictionary<int, string> ItemNames = new Dictionary<int, string>();
        public static Dictionary<int, string> Prefixes = new Dictionary<int, string>();
        public static Dictionary<int, string> Buffs = new Dictionary<int, string>();

        public static void Initialize()
        {
            foreach (string Line in File.ReadLines("Items.txt"))
            {
                try
                {
                    var Split = Line.Split('\t');
                    ItemNames.Add(int.Parse(Split[0].Trim()), Split[1]);
                }
                catch (Exception e) { }
            }

            foreach (string Line in File.ReadLines("Prefix.txt"))
            {
                try
                {
                    var Split = Line.Split('\t');
                    Prefixes.Add(int.Parse(Split[0]), Split[1]);
                }
                catch (Exception e) { }
            }

            foreach (string Line in File.ReadLines("Buffs.txt"))
            {
                try
                {
                    var Split = Line.Split('\t');
                    Prefixes.Add(int.Parse(Split[0]), Split[1]);
                }
                catch (Exception e) { }
            }
        }
    }
}
