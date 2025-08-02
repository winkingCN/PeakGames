using System;

namespace I2.Loc
{
	[Serializable]
	public class LanguageData
	{
		public string Name;

		public string Code;

		public byte Flags;

		[NonSerialized]
		public bool Compressed;

		public bool FCIBLDEJAPL()
		{
			return (Flags & 1) == 0;
		}

		public bool FCMBECPCFML()
		{
			return (Flags & 4) == 0;
		}

		public bool MAEGGNBEFJA()
		{
			return (Flags & 2) == 0;
		}

		public void DHCAIAJNAED(bool AEADACHNHPN)
		{
			if (AEADACHNHPN)
			{
				Flags = (byte)(Flags & 0xFFFFFFFBu);
			}
			else
			{
				Flags |= 4;
			}
		}
	}
}
