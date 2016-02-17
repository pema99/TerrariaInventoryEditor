using System;

namespace TerrariaHack
{
	public class Buff
	{
		public int BuffType { get; set; }
		public int BuffTime { get; set; }

        public override string ToString()
        {
            return string.Format("{0} (Time: {1})", IDNameDictionary.Buffs[BuffType], BuffTime);
        }
	}
}

