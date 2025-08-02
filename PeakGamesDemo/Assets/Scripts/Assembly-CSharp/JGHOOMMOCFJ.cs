using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class JGHOOMMOCFJ
{
	private static NumberFormatInfo JABBDBFFDCH;

	private KNBDNBPCJME MBEMNOCDDBC;

	private Stack<KNBDNBPCJME> BDCEJENMGIE;

	private bool OCHPNLFIKIG;

	private char[] BAKMOMFPDLL;

	private int BPJGMFKOADF;

	private int LFPKJPCKCEB;

	private StringBuilder HNOEHNFJDOF;

	private bool DAPDHJJKGNB;

	private bool DKNEEIJCCCG;

	private TextWriter GHLABECMBPB;

	public int NAKBPLJLHGG
	{
		get
		{
			return LFPKJPCKCEB;
		}
		set
		{
			BPJGMFKOADF = BPJGMFKOADF / LFPKJPCKCEB * value;
			LFPKJPCKCEB = value;
		}
	}

	public bool LGHHBOKEPHC
	{
		get
		{
			return DAPDHJJKGNB;
		}
		set
		{
			DAPDHJJKGNB = value;
		}
	}

	public TextWriter LBONILKOFMB
	{
		get
		{
			return GHLABECMBPB;
		}
	}

	public bool PIBLOPJEGEL
	{
		get
		{
			return DKNEEIJCCCG;
		}
		set
		{
			DKNEEIJCCCG = value;
		}
	}

	static JGHOOMMOCFJ()
	{
		JABBDBFFDCH = NumberFormatInfo.InvariantInfo;
	}

	public JGHOOMMOCFJ()
	{
		HNOEHNFJDOF = new StringBuilder();
		GHLABECMBPB = new StringWriter(HNOEHNFJDOF);
		DIOELAHNLKJ();
	}

	public JGHOOMMOCFJ(StringBuilder OFPMFAMCHJE)
		: this(new StringWriter(OFPMFAMCHJE))
	{
	}

	public JGHOOMMOCFJ(TextWriter GHLABECMBPB)
	{
		if (GHLABECMBPB == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.GHLABECMBPB = GHLABECMBPB;
		DIOELAHNLKJ();
	}

	private void IIMDJEMGLFE(DMLFKMANPMJ BOBBMKHAAEF)
	{
		if (!MBEMNOCDDBC.CAFLBOJBKOF)
		{
			MBEMNOCDDBC.GMCGMPEEHJP++;
		}
		if (!DKNEEIJCCCG)
		{
			return;
		}
		if (OCHPNLFIKIG)
		{
			throw new AHFEPEFFHLL("A complete JSON symbol has already been written");
		}
		switch (BOBBMKHAAEF)
		{
		case DMLFKMANPMJ.InArray:
			if (!MBEMNOCDDBC.BMNADFFMADL)
			{
				throw new AHFEPEFFHLL("Can't close an array here");
			}
			break;
		case DMLFKMANPMJ.InObject:
			if (!MBEMNOCDDBC.AKBMPCENPPE || MBEMNOCDDBC.CAFLBOJBKOF)
			{
				throw new AHFEPEFFHLL("Can't close an object here");
			}
			break;
		case DMLFKMANPMJ.NotAProperty:
			if (MBEMNOCDDBC.AKBMPCENPPE && !MBEMNOCDDBC.CAFLBOJBKOF)
			{
				throw new AHFEPEFFHLL("Expected a property");
			}
			break;
		case DMLFKMANPMJ.Property:
			if (!MBEMNOCDDBC.AKBMPCENPPE || MBEMNOCDDBC.CAFLBOJBKOF)
			{
				throw new AHFEPEFFHLL("Can't add a property here");
			}
			break;
		case DMLFKMANPMJ.Value:
			if (!MBEMNOCDDBC.BMNADFFMADL && (!MBEMNOCDDBC.AKBMPCENPPE || !MBEMNOCDDBC.CAFLBOJBKOF))
			{
				throw new AHFEPEFFHLL("Can't add a value here");
			}
			break;
		}
	}

	private void DIOELAHNLKJ()
	{
		OCHPNLFIKIG = false;
		BAKMOMFPDLL = new char[4];
		BPJGMFKOADF = 0;
		LFPKJPCKCEB = 4;
		DAPDHJJKGNB = false;
		DKNEEIJCCCG = true;
		BDCEJENMGIE = new Stack<KNBDNBPCJME>();
		MBEMNOCDDBC = new KNBDNBPCJME();
		BDCEJENMGIE.Push(MBEMNOCDDBC);
	}

	private static void EAJPBGAACAI(int IDHLPOFDLKJ, char[] PEGNALIKDPB)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = IDHLPOFDLKJ % 16;
			if (num < 10)
			{
				PEGNALIKDPB[3 - i] = (char)(48 + num);
			}
			else
			{
				PEGNALIKDPB[3 - i] = (char)(65 + (num - 10));
			}
			IDHLPOFDLKJ >>= 4;
		}
	}

	private void KFDEIEFFCOJ()
	{
		if (DAPDHJJKGNB)
		{
			BPJGMFKOADF += LFPKJPCKCEB;
		}
	}

	private void HMKJAFHJMGN(string GFPBBLPMOOL)
	{
		if (DAPDHJJKGNB && !MBEMNOCDDBC.CAFLBOJBKOF)
		{
			for (int i = 0; i < BPJGMFKOADF; i++)
			{
				GHLABECMBPB.Write(' ');
			}
		}
		GHLABECMBPB.Write(GFPBBLPMOOL);
	}

	private void HGNCAFDBMCK()
	{
		HGNCAFDBMCK(true);
	}

	private void HGNCAFDBMCK(bool BOJDJJIJKDB)
	{
		if (BOJDJJIJKDB && !MBEMNOCDDBC.CAFLBOJBKOF && MBEMNOCDDBC.GMCGMPEEHJP > 1)
		{
			GHLABECMBPB.Write(',');
		}
		if (DAPDHJJKGNB && !MBEMNOCDDBC.CAFLBOJBKOF)
		{
			GHLABECMBPB.Write('\n');
		}
	}

	private void NJBEIPJFHHF(string GFPBBLPMOOL)
	{
		HMKJAFHJMGN(string.Empty);
		GHLABECMBPB.Write('"');
		int length = GFPBBLPMOOL.Length;
		for (int i = 0; i < length; i++)
		{
			switch (GFPBBLPMOOL[i])
			{
			case '\n':
				GHLABECMBPB.Write("\\n");
				continue;
			case '\r':
				GHLABECMBPB.Write("\\r");
				continue;
			case '\t':
				GHLABECMBPB.Write("\\t");
				continue;
			case '"':
			case '\\':
				GHLABECMBPB.Write('\\');
				GHLABECMBPB.Write(GFPBBLPMOOL[i]);
				continue;
			case '\f':
				GHLABECMBPB.Write("\\f");
				continue;
			case '\b':
				GHLABECMBPB.Write("\\b");
				continue;
			}
			if (GFPBBLPMOOL[i] >= ' ' && GFPBBLPMOOL[i] <= '~')
			{
				GHLABECMBPB.Write(GFPBBLPMOOL[i]);
				continue;
			}
			EAJPBGAACAI(GFPBBLPMOOL[i], BAKMOMFPDLL);
			GHLABECMBPB.Write("\\u");
			GHLABECMBPB.Write(BAKMOMFPDLL);
		}
		GHLABECMBPB.Write('"');
	}

	private void NDFGDBODBCI()
	{
		if (DAPDHJJKGNB)
		{
			BPJGMFKOADF -= LFPKJPCKCEB;
		}
	}

	public override string ToString()
	{
		if (HNOEHNFJDOF == null)
		{
			return string.Empty;
		}
		return HNOEHNFJDOF.ToString();
	}

	public void OMOKOKFNBKI()
	{
		OCHPNLFIKIG = false;
		BDCEJENMGIE.Clear();
		MBEMNOCDDBC = new KNBDNBPCJME();
		BDCEJENMGIE.Push(MBEMNOCDDBC);
		if (HNOEHNFJDOF != null)
		{
			HNOEHNFJDOF.Remove(0, HNOEHNFJDOF.Length);
		}
	}

	public void KBMOJGCCCEN(bool INFENIMONBM)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		HMKJAFHJMGN((!INFENIMONBM) ? "false" : "true");
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(decimal CFEHLBIDFCG)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		HMKJAFHJMGN(Convert.ToString(CFEHLBIDFCG, JABBDBFFDCH));
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(double CFEHLBIDFCG)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		string text = Convert.ToString(CFEHLBIDFCG, JABBDBFFDCH);
		HMKJAFHJMGN(text);
		if (text.IndexOf('.') == -1 && text.IndexOf('E') == -1)
		{
			GHLABECMBPB.Write(".0");
		}
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(int CFEHLBIDFCG)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		HMKJAFHJMGN(Convert.ToString(CFEHLBIDFCG, JABBDBFFDCH));
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(long CFEHLBIDFCG)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		HMKJAFHJMGN(Convert.ToString(CFEHLBIDFCG, JABBDBFFDCH));
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(string GFPBBLPMOOL)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		if (GFPBBLPMOOL == null)
		{
			HMKJAFHJMGN("null");
		}
		else
		{
			NJBEIPJFHHF(GFPBBLPMOOL);
		}
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KBMOJGCCCEN(ulong CFEHLBIDFCG)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Value);
		HGNCAFDBMCK();
		HMKJAFHJMGN(Convert.ToString(CFEHLBIDFCG, JABBDBFFDCH));
		MBEMNOCDDBC.CAFLBOJBKOF = false;
	}

	public void KDKCHLBKEEN()
	{
		IIMDJEMGLFE(DMLFKMANPMJ.InArray);
		HGNCAFDBMCK(false);
		BDCEJENMGIE.Pop();
		if (BDCEJENMGIE.Count == 1)
		{
			OCHPNLFIKIG = true;
		}
		else
		{
			MBEMNOCDDBC = BDCEJENMGIE.Peek();
			MBEMNOCDDBC.CAFLBOJBKOF = false;
		}
		NDFGDBODBCI();
		HMKJAFHJMGN("]");
	}

	public void AMOOKGONCNL()
	{
		IIMDJEMGLFE(DMLFKMANPMJ.NotAProperty);
		HGNCAFDBMCK();
		HMKJAFHJMGN("[");
		MBEMNOCDDBC = new KNBDNBPCJME();
		MBEMNOCDDBC.BMNADFFMADL = true;
		BDCEJENMGIE.Push(MBEMNOCDDBC);
		KFDEIEFFCOJ();
	}

	public void MLHNFLBDEDL()
	{
		IIMDJEMGLFE(DMLFKMANPMJ.InObject);
		HGNCAFDBMCK(false);
		BDCEJENMGIE.Pop();
		if (BDCEJENMGIE.Count == 1)
		{
			OCHPNLFIKIG = true;
		}
		else
		{
			MBEMNOCDDBC = BDCEJENMGIE.Peek();
			MBEMNOCDDBC.CAFLBOJBKOF = false;
		}
		NDFGDBODBCI();
		HMKJAFHJMGN("}");
	}

	public void IGJCBGHOCAK()
	{
		IIMDJEMGLFE(DMLFKMANPMJ.NotAProperty);
		HGNCAFDBMCK();
		HMKJAFHJMGN("{");
		MBEMNOCDDBC = new KNBDNBPCJME();
		MBEMNOCDDBC.AKBMPCENPPE = true;
		BDCEJENMGIE.Push(MBEMNOCDDBC);
		KFDEIEFFCOJ();
	}

	public void LDEPLFIBHOF(string PEPIBAOLJPJ)
	{
		IIMDJEMGLFE(DMLFKMANPMJ.Property);
		HGNCAFDBMCK();
		NJBEIPJFHHF(PEPIBAOLJPJ);
		if (DAPDHJJKGNB)
		{
			if (PEPIBAOLJPJ.Length > MBEMNOCDDBC.IDOCGKKCBOJ)
			{
				MBEMNOCDDBC.IDOCGKKCBOJ = PEPIBAOLJPJ.Length;
			}
			for (int num = MBEMNOCDDBC.IDOCGKKCBOJ - PEPIBAOLJPJ.Length; num >= 0; num--)
			{
				GHLABECMBPB.Write(' ');
			}
			GHLABECMBPB.Write(": ");
		}
		else
		{
			GHLABECMBPB.Write(':');
		}
		MBEMNOCDDBC.CAFLBOJBKOF = true;
	}
}
