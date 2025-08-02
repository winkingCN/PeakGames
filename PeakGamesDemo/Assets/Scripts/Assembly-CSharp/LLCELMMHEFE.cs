using System;
using Org.BouncyCastle.Math;

public class LLCELMMHEFE : OHPHNNNHCOO
{
	[Obsolete("Use 'IsoTrailers' instead")]
	public const int DGEFLFACBGC = 188;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int ENMNLALPOJB = 12748;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int KPAFAJKLCJM = 13004;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int CEOOPPKFPHN = 13260;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int PLADFCIAGKA = 13516;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int HCIMKPBDMDM = 13772;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int OPCIBCMDCCF = 14028;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int NGIAAOJNPJI = 14284;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int BEJAOMNHOBB = 14540;

	private BJLAMONNNDD HABFKBCEIBN;

	private DGCIOOEELCP IEDPBFAFGGJ;

	private PLGGNEJEIIP EAABLGDBILH;

	private int EHGIDJJNLAM;

	private int FBLNDPJFNJB;

	private byte[] OJEJPICFOOJ;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return HABFKBCEIBN.KFKMEPMEBND + "with" + IEDPBFAFGGJ.KFKMEPMEBND + "/X9.31";
		}
	}

	public LLCELMMHEFE(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD HABFKBCEIBN, bool DNLBBOCJHCM)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		this.HABFKBCEIBN = HABFKBCEIBN;
		if (DNLBBOCJHCM)
		{
			EHGIDJJNLAM = 188;
			return;
		}
		if (LLINHKMIBFP.PMLGCANEMIO(HABFKBCEIBN))
		{
			throw new ArgumentException("no valid trailer", "digest");
		}
		EHGIDJJNLAM = LLINHKMIBFP.LFDPFEKIKII(HABFKBCEIBN);
	}

	public LLCELMMHEFE(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD HABFKBCEIBN)
		: this(IEDPBFAFGGJ, HABFKBCEIBN, false)
	{
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		EAABLGDBILH = (PLGGNEJEIIP)IJJHBEECMBP;
		IEDPBFAFGGJ.DIOELAHNLKJ(KGPBDABMHKH, EAABLGDBILH);
		FBLNDPJFNJB = EAABLGDBILH.FILOMPHGFKD.BitLength;
		OJEJPICFOOJ = new byte[(FBLNDPJFNJB + 7) / 8];
		OMOKOKFNBKI();
	}

	private void JKBFMHJLGDI(byte[] OJEJPICFOOJ)
	{
		Array.Clear(OJEJPICFOOJ, 0, OJEJPICFOOJ.Length);
	}

	public virtual void BPAJGOINFNL(byte BCIHLCMFAEK)
	{
		HABFKBCEIBN.BPAJGOINFNL(BCIHLCMFAEK);
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		HABFKBCEIBN.GONEEEFEDGF(MOPCLEEGDFB, JBAJPGIAPFF, NBEDPKHALCN);
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
	}

	public virtual byte[] HMJHAKCMGHC()
	{
		DKPCIGJKHKN();
		BigInteger bigInteger = new BigInteger(1, IEDPBFAFGGJ.DPACJDFHLKB(OJEJPICFOOJ, 0, OJEJPICFOOJ.Length));
		JKBFMHJLGDI(OJEJPICFOOJ);
		bigInteger = bigInteger.CLNHKLFJKHH(EAABLGDBILH.FILOMPHGFKD.FBGIHKPECCO(bigInteger));
		return ODBELJAHGIG.HOGKINKACAF((EAABLGDBILH.FILOMPHGFKD.BitLength + 7) / 8, bigInteger);
	}

	private void DKPCIGJKHKN()
	{
		int num = HABFKBCEIBN.EEMLLAMENHO();
		int num2;
		if (EHGIDJJNLAM == 188)
		{
			num2 = OJEJPICFOOJ.Length - num - 1;
			HABFKBCEIBN.LCNOFBMOHHM(OJEJPICFOOJ, num2);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 1] = 188;
		}
		else
		{
			num2 = OJEJPICFOOJ.Length - num - 2;
			HABFKBCEIBN.LCNOFBMOHHM(OJEJPICFOOJ, num2);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 2] = (byte)(EHGIDJJNLAM >> 8);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 1] = (byte)EHGIDJJNLAM;
		}
		OJEJPICFOOJ[0] = 107;
		for (int num3 = num2 - 2; num3 != 0; num3--)
		{
			OJEJPICFOOJ[num3] = 187;
		}
		OJEJPICFOOJ[num2 - 1] = 186;
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		try
		{
			OJEJPICFOOJ = IEDPBFAFGGJ.DPACJDFHLKB(PINNJBGMGOA, 0, PINNJBGMGOA.Length);
		}
		catch (Exception)
		{
			return false;
		}
		BigInteger bigInteger = new BigInteger(1, OJEJPICFOOJ);
		BigInteger iDHLPOFDLKJ;
		if ((bigInteger.IntValue & 0xF) == 12)
		{
			iDHLPOFDLKJ = bigInteger;
		}
		else
		{
			bigInteger = EAABLGDBILH.FILOMPHGFKD.FBGIHKPECCO(bigInteger);
			if ((bigInteger.IntValue & 0xF) != 12)
			{
				return false;
			}
			iDHLPOFDLKJ = bigInteger;
		}
		DKPCIGJKHKN();
		byte[] array = ODBELJAHGIG.HOGKINKACAF(OJEJPICFOOJ.Length, iDHLPOFDLKJ);
		bool result = NOGCEBKPPJE.PBBFCJBKJEN(OJEJPICFOOJ, array);
		JKBFMHJLGDI(OJEJPICFOOJ);
		JKBFMHJLGDI(array);
		return result;
	}
}
