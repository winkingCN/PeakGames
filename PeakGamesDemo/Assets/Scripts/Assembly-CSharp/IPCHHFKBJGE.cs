using System;

public class IPCHHFKBJGE
{
	private readonly byte[] HJBOEOOLOOE;

	private readonly int CKKJMJHIJBN;

	public int NBACENGNIBB
	{
		get
		{
			return CKKJMJHIJBN;
		}
	}

	public IPCHHFKBJGE(byte[] HJBOEOOLOOE, int CKKJMJHIJBN)
	{
		if (HJBOEOOLOOE == null)
		{
			throw new ArgumentNullException("seed");
		}
		this.HJBOEOOLOOE = (byte[])HJBOEOOLOOE.Clone();
		this.CKKJMJHIJBN = CKKJMJHIJBN;
	}

	public byte[] GKBBKKNGJAK()
	{
		return (byte[])HJBOEOOLOOE.Clone();
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		IPCHHFKBJGE iPCHHFKBJGE = NEMEKIOEOLC as IPCHHFKBJGE;
		if (iPCHHFKBJGE == null)
		{
			return false;
		}
		return KIFDKLPDKMD(iPCHHFKBJGE);
	}

	protected bool KIFDKLPDKMD(IPCHHFKBJGE CJHEIBNHNNE)
	{
		return CKKJMJHIJBN == CJHEIBNHNNE.CKKJMJHIJBN && NOGCEBKPPJE.ICKLINNFHKK(HJBOEOOLOOE, CJHEIBNHNNE.HJBOEOOLOOE);
	}

	public override int GetHashCode()
	{
		return CKKJMJHIJBN.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(HJBOEOOLOOE);
	}
}
