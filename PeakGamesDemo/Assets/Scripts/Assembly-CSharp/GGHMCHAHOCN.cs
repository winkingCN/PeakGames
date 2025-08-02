using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

public class GGHMCHAHOCN : LNKPCJLANAO, MFHFAODDMLI
{
	public const int LKDNJJJADFG = 0;

	public const int DKGMGCHDIKF = 1;

	public const int KLPIPJADLJF = 2;

	public const int LHOEMPCNFKN = 3;

	public const int KDCAIPPEHKD = 4;

	public const int LDAHAGGELGN = 5;

	public const int MHADAGCKKEN = 6;

	public const int KEJGCFMGNLL = 7;

	public const int FJNDLEGJIDE = 8;

	internal readonly LNKPCJLANAO NEMEKIOEOLC;

	internal readonly int MOKLDCMGFFB;

	public int JPBIKBDCEKC
	{
		get
		{
			return MOKLDCMGFFB;
		}
	}

	public LNKPCJLANAO PNGPLGHKFDI
	{
		get
		{
			return NEMEKIOEOLC;
		}
	}

	public GGHMCHAHOCN(HMMHEPKCKCP GLBGFMFNJDH)
	{
		NEMEKIOEOLC = GLBGFMFNJDH;
		MOKLDCMGFFB = 4;
	}

	public GGHMCHAHOCN(EDOEBJJFOBM IOCMOCCFALN, int MOKLDCMGFFB)
	{
		NEMEKIOEOLC = IOCMOCCFALN;
		this.MOKLDCMGFFB = MOKLDCMGFFB;
	}

	public GGHMCHAHOCN(int MOKLDCMGFFB, LNKPCJLANAO IOCMOCCFALN)
	{
		NEMEKIOEOLC = IOCMOCCFALN;
		this.MOKLDCMGFFB = MOKLDCMGFFB;
	}

	public GGHMCHAHOCN(int MOKLDCMGFFB, string IOCMOCCFALN)
	{
		this.MOKLDCMGFFB = MOKLDCMGFFB;
		switch (MOKLDCMGFFB)
		{
		case 1:
		case 2:
		case 6:
			NEMEKIOEOLC = new KCKEFHLLGIO(IOCMOCCFALN);
			break;
		case 8:
			NEMEKIOEOLC = new KLKJHFKJLEM(IOCMOCCFALN);
			break;
		case 4:
			NEMEKIOEOLC = new HMMHEPKCKCP(IOCMOCCFALN);
			break;
		case 7:
		{
			byte[] array = JPNOJJFNOEM(IOCMOCCFALN);
			if (array == null)
			{
				throw new ArgumentException("IP Address is invalid", "name");
			}
			NEMEKIOEOLC = new CFMJBFILJCB(array);
			break;
		}
		default:
			throw new ArgumentException("can't process string for tag: " + MOKLDCMGFFB, "tag");
		}
	}

	public static GGHMCHAHOCN BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is GGHMCHAHOCN)
		{
			return (GGHMCHAHOCN)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is PAANMJLACEF)
		{
			PAANMJLACEF pAANMJLACEF = (PAANMJLACEF)NEMEKIOEOLC;
			int num = pAANMJLACEF.JPBIKBDCEKC;
			switch (num)
			{
			case 0:
				return new GGHMCHAHOCN(num, ALLINHNNNJN.BJLJCGFMFOO(pAANMJLACEF, false));
			case 1:
				return new GGHMCHAHOCN(num, KCKEFHLLGIO.BJLJCGFMFOO(pAANMJLACEF, false));
			case 2:
				return new GGHMCHAHOCN(num, KCKEFHLLGIO.BJLJCGFMFOO(pAANMJLACEF, false));
			case 3:
				throw new ArgumentException("unknown tag: " + num);
			case 4:
				return new GGHMCHAHOCN(num, HMMHEPKCKCP.BJLJCGFMFOO(pAANMJLACEF, true));
			case 5:
				return new GGHMCHAHOCN(num, ALLINHNNNJN.BJLJCGFMFOO(pAANMJLACEF, false));
			case 6:
				return new GGHMCHAHOCN(num, KCKEFHLLGIO.BJLJCGFMFOO(pAANMJLACEF, false));
			case 7:
				return new GGHMCHAHOCN(num, PJGIGKJFGFI.BJLJCGFMFOO(pAANMJLACEF, false));
			case 8:
				return new GGHMCHAHOCN(num, KLKJHFKJLEM.BJLJCGFMFOO(pAANMJLACEF, false));
			}
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return BJLJCGFMFOO(EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC));
			}
			catch (IOException)
			{
				throw new ArgumentException("unable to parse encoded general name");
			}
		}
		throw new ArgumentException("unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static GGHMCHAHOCN BJLJCGFMFOO(PAANMJLACEF EFAFKMKCANI, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(PAANMJLACEF.BJLJCGFMFOO(EFAFKMKCANI, true));
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(MOKLDCMGFFB);
		stringBuilder.Append(": ");
		switch (MOKLDCMGFFB)
		{
		case 1:
		case 2:
		case 6:
			stringBuilder.Append(KCKEFHLLGIO.BJLJCGFMFOO(NEMEKIOEOLC).JDANMONKNGD());
			break;
		case 4:
			stringBuilder.Append(HMMHEPKCKCP.BJLJCGFMFOO(NEMEKIOEOLC).ToString());
			break;
		default:
			stringBuilder.Append(NEMEKIOEOLC.ToString());
			break;
		}
		return stringBuilder.ToString();
	}

	private byte[] JPNOJJFNOEM(string EKGHBOHDHEA)
	{
		if (OHEPKNFBBGA.BLKDNADEBJJ(EKGHBOHDHEA) || OHEPKNFBBGA.KCGCNFBKCMC(EKGHBOHDHEA))
		{
			int num = EKGHBOHDHEA.IndexOf('/');
			if (num < 0)
			{
				byte[] array = new byte[16];
				int[] eDHDKGIPCAI = GHHGPDCBOBD(EKGHBOHDHEA);
				MHANCIIFDDO(eDHDKGIPCAI, array, 0);
				return array;
			}
			byte[] array2 = new byte[32];
			int[] eDHDKGIPCAI2 = GHHGPDCBOBD(EKGHBOHDHEA.Substring(0, num));
			MHANCIIFDDO(eDHDKGIPCAI2, array2, 0);
			string text = EKGHBOHDHEA.Substring(num + 1);
			eDHDKGIPCAI2 = ((text.IndexOf(':') <= 0) ? JODEGKMHCBO(text) : GHHGPDCBOBD(text));
			MHANCIIFDDO(eDHDKGIPCAI2, array2, 16);
			return array2;
		}
		if (OHEPKNFBBGA.COHDBICODLD(EKGHBOHDHEA) || OHEPKNFBBGA.BDFOHKBEGGO(EKGHBOHDHEA))
		{
			int num2 = EKGHBOHDHEA.IndexOf('/');
			if (num2 < 0)
			{
				byte[] array3 = new byte[4];
				GHHLBDGJCHE(EKGHBOHDHEA, array3, 0);
				return array3;
			}
			byte[] array4 = new byte[8];
			GHHLBDGJCHE(EKGHBOHDHEA.Substring(0, num2), array4, 0);
			string text2 = EKGHBOHDHEA.Substring(num2 + 1);
			if (text2.IndexOf('.') > 0)
			{
				GHHLBDGJCHE(text2, array4, 4);
			}
			else
			{
				ODJDFAFHPCJ(text2, array4, 4);
			}
			return array4;
		}
		return null;
	}

	private void ODJDFAFHPCJ(string DHJODBJPGBJ, byte[] INHLPNDEHHK, int IBNDGNOIEEF)
	{
		int num = int.Parse(DHJODBJPGBJ);
		for (int i = 0; i != num; i++)
		{
			INHLPNDEHHK[i / 8 + IBNDGNOIEEF] |= (byte)(1 << i % 8);
		}
	}

	private void GHHLBDGJCHE(string EKGHBOHDHEA, byte[] INHLPNDEHHK, int IBNDGNOIEEF)
	{
		string[] array = EKGHBOHDHEA.Split('.', '/');
		foreach (string s in array)
		{
			INHLPNDEHHK[IBNDGNOIEEF++] = (byte)int.Parse(s);
		}
	}

	private int[] JODEGKMHCBO(string DHJODBJPGBJ)
	{
		int[] array = new int[8];
		int num = int.Parse(DHJODBJPGBJ);
		for (int i = 0; i != num; i++)
		{
			array[i / 16] |= 1 << i % 16;
		}
		return array;
	}

	private void MHANCIIFDDO(int[] EDHDKGIPCAI, byte[] INHLPNDEHHK, int AFEFGFIAJOF)
	{
		for (int i = 0; i != EDHDKGIPCAI.Length; i++)
		{
			INHLPNDEHHK[i * 2 + AFEFGFIAJOF] = (byte)(EDHDKGIPCAI[i] >> 8);
			INHLPNDEHHK[i * 2 + 1 + AFEFGFIAJOF] = (byte)EDHDKGIPCAI[i];
		}
	}

	private int[] GHHGPDCBOBD(string EKGHBOHDHEA)
	{
		if (LHFGHNFJIKM.GNEPOHDBAEJ(EKGHBOHDHEA, "::"))
		{
			EKGHBOHDHEA = EKGHBOHDHEA.Substring(1);
		}
		else if (LHFGHNFJIKM.BGIBPBNIHDL(EKGHBOHDHEA, "::"))
		{
			EKGHBOHDHEA = EKGHBOHDHEA.Substring(0, EKGHBOHDHEA.Length - 1);
		}
		IEnumerator enumerator = EKGHBOHDHEA.Split(':').GetEnumerator();
		int num = 0;
		int[] array = new int[8];
		int num2 = -1;
		while (enumerator.MoveNext())
		{
			string text = (string)enumerator.Current;
			if (text.Length == 0)
			{
				num2 = num;
				array[num++] = 0;
				continue;
			}
			if (text.IndexOf('.') < 0)
			{
				array[num++] = int.Parse(text, NumberStyles.AllowHexSpecifier);
				continue;
			}
			string[] array2 = text.Split('.');
			array[num++] = (int.Parse(array2[0]) << 8) | int.Parse(array2[1]);
			array[num++] = (int.Parse(array2[2]) << 8) | int.Parse(array2[3]);
		}
		if (num != array.Length)
		{
			Array.Copy(array, num2, array, array.Length - (num - num2), num - num2);
			for (int i = num2; i != array.Length - (num - num2); i++)
			{
				array[i] = 0;
			}
		}
		return array;
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return new JIHIOOKBBLB(MOKLDCMGFFB == 4, MOKLDCMGFFB, NEMEKIOEOLC);
	}
}
