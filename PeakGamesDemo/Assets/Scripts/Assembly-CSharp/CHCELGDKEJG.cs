using System;

public class CHCELGDKEJG : IGMAJHKIIPK
{
	private readonly IGMAJHKIIPK IJJHBEECMBP;

	private readonly byte[] NDEFBOJOALL;

	public IGMAJHKIIPK KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	public CHCELGDKEJG(IGMAJHKIIPK IJJHBEECMBP, byte[] NDEFBOJOALL)
		: this(IJJHBEECMBP, NDEFBOJOALL, 0, NDEFBOJOALL.Length)
	{
	}

	public CHCELGDKEJG(IGMAJHKIIPK IJJHBEECMBP, byte[] NDEFBOJOALL, int PDNBKOFPCNJ, int EPBBNMDACEO)
	{
		if (NDEFBOJOALL == null)
		{
			throw new ArgumentNullException("iv");
		}
		this.IJJHBEECMBP = IJJHBEECMBP;
		this.NDEFBOJOALL = new byte[EPBBNMDACEO];
		Array.Copy(NDEFBOJOALL, PDNBKOFPCNJ, this.NDEFBOJOALL, 0, EPBBNMDACEO);
	}

	public byte[] OLAEDCABKDH()
	{
		return (byte[])NDEFBOJOALL.Clone();
	}
}
