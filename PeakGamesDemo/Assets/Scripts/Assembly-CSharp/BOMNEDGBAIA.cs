using System;

public class BOMNEDGBAIA : JEMNCGMEABF
{
	public const int MLDBEEHNIDI = 8;

	private const int EJDNMABMGPF = 16;

	private static readonly byte[] OCOKFKDMJLP = new byte[128]
	{
		1, 1, 1, 1, 1, 1, 1, 1, 31, 31,
		31, 31, 14, 14, 14, 14, 224, 224, 224, 224,
		241, 241, 241, 241, 254, 254, 254, 254, 254, 254,
		254, 254, 1, 254, 1, 254, 1, 254, 1, 254,
		31, 224, 31, 224, 14, 241, 14, 241, 1, 224,
		1, 224, 1, 241, 1, 241, 31, 254, 31, 254,
		14, 254, 14, 254, 1, 31, 1, 31, 1, 14,
		1, 14, 224, 254, 224, 254, 241, 254, 241, 254,
		254, 1, 254, 1, 254, 1, 254, 1, 224, 31,
		224, 31, 241, 14, 241, 14, 224, 1, 224, 1,
		241, 1, 241, 1, 254, 31, 254, 31, 254, 14,
		254, 14, 31, 1, 31, 1, 14, 1, 14, 1,
		254, 224, 254, 224, 254, 241, 254, 241
	};

	public BOMNEDGBAIA(byte[] IKNCPEPOKGJ)
		: base(IKNCPEPOKGJ)
	{
		if (DDGIJIBNJBG(IKNCPEPOKGJ))
		{
			throw new ArgumentException("attempt to create weak DES key");
		}
	}

	public BOMNEDGBAIA(byte[] IKNCPEPOKGJ, int EDKGBLMGFOO, int JJBNFEJMIPJ)
		: base(IKNCPEPOKGJ, EDKGBLMGFOO, JJBNFEJMIPJ)
	{
		if (DDGIJIBNJBG(IKNCPEPOKGJ, EDKGBLMGFOO))
		{
			throw new ArgumentException("attempt to create weak DES key");
		}
	}

	public static bool DDGIJIBNJBG(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF)
	{
		if (IKNCPEPOKGJ.Length - IBNDGNOIEEF < 8)
		{
			throw new ArgumentException("key material too short.");
		}
		for (int i = 0; i < 16; i++)
		{
			bool flag = false;
			for (int j = 0; j < 8; j++)
			{
				if (IKNCPEPOKGJ[j + IBNDGNOIEEF] != OCOKFKDMJLP[i * 8 + j])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	public static bool DDGIJIBNJBG(byte[] IKNCPEPOKGJ)
	{
		return DDGIJIBNJBG(IKNCPEPOKGJ, 0);
	}

	public static byte NNELNBBKMDI(byte BCIHLCMFAEK)
	{
		uint num = BCIHLCMFAEK ^ 1u;
		num ^= num >> 4;
		num ^= num >> 2;
		num ^= num >> 1;
		num &= 1u;
		return (byte)(BCIHLCMFAEK ^ num);
	}

	public static void NNELNBBKMDI(byte[] DIPNEDDIHBK)
	{
		for (int i = 0; i < DIPNEDDIHBK.Length; i++)
		{
			DIPNEDDIHBK[i] = NNELNBBKMDI(DIPNEDDIHBK[i]);
		}
	}

	public static void NNELNBBKMDI(byte[] DIPNEDDIHBK, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			DIPNEDDIHBK[JBAJPGIAPFF + i] = NNELNBBKMDI(DIPNEDDIHBK[JBAJPGIAPFF + i]);
		}
	}
}
