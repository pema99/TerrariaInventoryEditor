using System;

namespace TerrariaHack
{
	public class Color
	{
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }

        public override string ToString()
        {
            return string.Format("(R:{0} G:{1} B:{2})", R, G, B);
        }
	}
}

