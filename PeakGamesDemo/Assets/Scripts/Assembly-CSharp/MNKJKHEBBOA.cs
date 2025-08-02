public class MNKJKHEBBOA : FJMKMKNJKOI
{
	public const int CBOEBBAKICB = 128;

	public const int BMKPGFNAMNC = 64;

	public const int PPEBFCFDIHP = 32;

	public const int EOBKLBHPMAG = 16;

	public const int EMHEFFNDODF = 8;

	public const int KJPJDPLAEPE = 4;

	public const int GDKFKIANJCF = 2;

	public const int MOFNOMLJDHE = 1;

	public const int EJDONAOBCIG = 32768;

	public MNKJKHEBBOA(int AJLMGHKKAAP)
		: base(AJLMGHKKAAP)
	{
	}

	private MNKJKHEBBOA(FJMKMKNJKOI AJLMGHKKAAP)
		: base(AJLMGHKKAAP.MIBPLNJNEGA(), AJLMGHKKAAP.KOHPFEHKIPK)
	{
	}

	public new static MNKJKHEBBOA BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC is MNKJKHEBBOA)
		{
			return (MNKJKHEBBOA)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is BJHANHIGLGB)
		{
			return BJLJCGFMFOO(BJHANHIGLGB.FCELHPADEGC((BJHANHIGLGB)NEMEKIOEOLC));
		}
		return new MNKJKHEBBOA(FJMKMKNJKOI.BJLJCGFMFOO(NEMEKIOEOLC));
	}

	public override string ToString()
	{
		byte[] array = MIBPLNJNEGA();
		if (array.Length == 1)
		{
			return "KeyUsage: 0x" + (array[0] & 0xFF).ToString("X");
		}
		return "KeyUsage: 0x" + (((array[1] & 0xFF) << 8) | (array[0] & 0xFF)).ToString("X");
	}
}
