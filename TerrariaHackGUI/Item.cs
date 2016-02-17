using System;

namespace TerrariaHack
{
	public class Item
	{
		public int Count { get; set; }
		public int ID { get; set; }
		public byte Prefix { get; set; }

        public override string ToString()
        {
            if (ID != 0)
                return string.Format("{0} {1}{2}", Count, Prefix == 0 ? "" : IDNameDictionary.Prefixes[Prefix] + " ", IDNameDictionary.ItemNames[ID]);
            else
                return "Empty Slot";
        }
	}
}

