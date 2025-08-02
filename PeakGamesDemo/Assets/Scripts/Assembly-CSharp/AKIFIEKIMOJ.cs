using System;
using System.Text;

public abstract class AKIFIEKIMOJ
{
	protected byte[] EBGAFNAFCOG;

	protected byte[] HKBPEJNDDCP;

	protected int NHEMFEBHDBC;

	public virtual byte[] EKHNHMDPMON
	{
		get
		{
			return NOGCEBKPPJE.IKBFGGABMKP(EBGAFNAFCOG);
		}
	}

	public virtual byte[] ALEBOAFNGIB
	{
		get
		{
			return NOGCEBKPPJE.IKBFGGABMKP(HKBPEJNDDCP);
		}
	}

	public virtual int BPBEEKGFABI
	{
		get
		{
			return NHEMFEBHDBC;
		}
	}

	public virtual void DIOELAHNLKJ(byte[] OCGBNFINLBE, byte[] FPPIFEACFOK, int PLFEHOAKELF)
	{
		if (OCGBNFINLBE == null)
		{
			throw new ArgumentNullException("password");
		}
		if (FPPIFEACFOK == null)
		{
			throw new ArgumentNullException("salt");
		}
		EBGAFNAFCOG = NOGCEBKPPJE.IKBFGGABMKP(OCGBNFINLBE);
		HKBPEJNDDCP = NOGCEBKPPJE.IKBFGGABMKP(FPPIFEACFOK);
		NHEMFEBHDBC = PLFEHOAKELF;
	}

	[Obsolete("Use 'Password' property")]
	public byte[] FOPGLPDNHAK()
	{
		return EKHNHMDPMON;
	}

	[Obsolete("Use 'Salt' property")]
	public byte[] MPEAIEBOCPI()
	{
		return ALEBOAFNGIB;
	}

	[Obsolete("Use version with 'algorithm' parameter")]
	public abstract IGMAJHKIIPK AAKFHAGEAFN(int FICGFLDDPBO);

	public abstract IGMAJHKIIPK AAKFHAGEAFN(string ADLMOHOLCGL, int FICGFLDDPBO);

	[Obsolete("Use version with 'algorithm' parameter")]
	public abstract IGMAJHKIIPK AAKFHAGEAFN(int FICGFLDDPBO, int FEPFCBAHHIH);

	public abstract IGMAJHKIIPK AAKFHAGEAFN(string ADLMOHOLCGL, int FICGFLDDPBO, int FEPFCBAHHIH);

	public abstract IGMAJHKIIPK NEOJENNLIPD(int FICGFLDDPBO);

	public static byte[] OOABEPIGHNP(char[] OCGBNFINLBE)
	{
		if (OCGBNFINLBE == null)
		{
			return new byte[0];
		}
		return CCGLOIJJMKC.EDHFCNLPGJC(OCGBNFINLBE);
	}

	[Obsolete("Use version taking 'char[]' instead")]
	public static byte[] OOABEPIGHNP(string OCGBNFINLBE)
	{
		if (OCGBNFINLBE == null)
		{
			return new byte[0];
		}
		return CCGLOIJJMKC.EDHFCNLPGJC(OCGBNFINLBE);
	}

	public static byte[] HJPANDAOHDJ(char[] OCGBNFINLBE)
	{
		if (OCGBNFINLBE == null)
		{
			return new byte[0];
		}
		return Encoding.UTF8.GetBytes(OCGBNFINLBE);
	}

	[Obsolete("Use version taking 'char[]' instead")]
	public static byte[] HJPANDAOHDJ(string OCGBNFINLBE)
	{
		if (OCGBNFINLBE == null)
		{
			return new byte[0];
		}
		return Encoding.UTF8.GetBytes(OCGBNFINLBE);
	}

	public static byte[] BOJLOAIMHBD(char[] OCGBNFINLBE)
	{
		return BOJLOAIMHBD(OCGBNFINLBE, false);
	}

	public static byte[] BOJLOAIMHBD(char[] OCGBNFINLBE, bool ELAENCKDHON)
	{
		if (OCGBNFINLBE == null || OCGBNFINLBE.Length < 1)
		{
			return new byte[ELAENCKDHON ? 2 : 0];
		}
		byte[] array = new byte[(OCGBNFINLBE.Length + 1) * 2];
		Encoding.BigEndianUnicode.GetBytes(OCGBNFINLBE, 0, OCGBNFINLBE.Length, array, 0);
		return array;
	}
}
