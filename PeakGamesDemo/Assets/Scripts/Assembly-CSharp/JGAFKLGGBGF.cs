using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math;

public abstract class JGAFKLGGBGF
{
	protected static KBINBLGGLNE[] GHCCCBJDBJC = new KBINBLGGLNE[0];

	protected internal readonly BHPIABAGAPB DNLENPOIJNE;

	protected internal readonly KBINBLGGLNE PNCAGGBLFOH;

	protected internal readonly KBINBLGGLNE HCCNDKKAJIL;

	protected internal readonly KBINBLGGLNE[] IEHEIMJLFCI;

	protected internal readonly bool ANAHOJBBEDJ;

	protected internal IDictionary CGMGNKDNOIO;

	public virtual BHPIABAGAPB ECFGFKNLLGH
	{
		get
		{
			return DNLENPOIJNE;
		}
	}

	protected virtual int FMBBJLCHHDI
	{
		get
		{
			return (DNLENPOIJNE != null) ? DNLENPOIJNE.DHBHKHGFIKI : 0;
		}
	}

	[Obsolete("Use AffineXCoord, or Normalize() and XCoord, instead")]
	public virtual KBINBLGGLNE CBPFFIBINEH
	{
		get
		{
			return MIHJHLFLHNA().OBCJFNBLIPG;
		}
	}

	[Obsolete("Use AffineYCoord, or Normalize() and YCoord, instead")]
	public virtual KBINBLGGLNE MOAGLBJDKKL
	{
		get
		{
			return MIHJHLFLHNA().LGFGMGPDEIB;
		}
	}

	public virtual KBINBLGGLNE HBEBMBOOIMD
	{
		get
		{
			DFCAKCFCOAO();
			return OBCJFNBLIPG;
		}
	}

	public virtual KBINBLGGLNE CEFLFJNJILP
	{
		get
		{
			DFCAKCFCOAO();
			return LGFGMGPDEIB;
		}
	}

	public virtual KBINBLGGLNE OBCJFNBLIPG
	{
		get
		{
			return PNCAGGBLFOH;
		}
	}

	public virtual KBINBLGGLNE LGFGMGPDEIB
	{
		get
		{
			return HCCNDKKAJIL;
		}
	}

	protected internal KBINBLGGLNE NBPANDNEJGI
	{
		get
		{
			return PNCAGGBLFOH;
		}
	}

	protected internal KBINBLGGLNE FIJLKLCHMGH
	{
		get
		{
			return HCCNDKKAJIL;
		}
	}

	protected internal KBINBLGGLNE[] LAMGGDKLPJH
	{
		get
		{
			return IEHEIMJLFCI;
		}
	}

	public bool IFCDKFANPBO
	{
		get
		{
			return PNCAGGBLFOH == null && HCCNDKKAJIL == null;
		}
	}

	public bool BPGGHHMMCCB
	{
		get
		{
			return ANAHOJBBEDJ;
		}
	}

	protected internal abstract bool NLPBPDPOOAK { get; }

	protected JGAFKLGGBGF(BHPIABAGAPB NINILENHPHE, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, bool HPGABKNMEAG)
		: this(NINILENHPHE, AMFCENFNAJJ, CNLILOEEBOJ, AKFILKMBDON(NINILENHPHE), HPGABKNMEAG)
	{
	}

	internal JGAFKLGGBGF(BHPIABAGAPB NINILENHPHE, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG)
	{
		DNLENPOIJNE = NINILENHPHE;
		PNCAGGBLFOH = AMFCENFNAJJ;
		HCCNDKKAJIL = CNLILOEEBOJ;
		IEHEIMJLFCI = IJGNIJAMCML;
		ANAHOJBBEDJ = HPGABKNMEAG;
	}

	protected static KBINBLGGLNE[] AKFILKMBDON(BHPIABAGAPB NINILENHPHE)
	{
		int num = ((NINILENHPHE != null) ? NINILENHPHE.DHBHKHGFIKI : 0);
		if (num == 0 || num == 5)
		{
			return GHCCCBJDBJC;
		}
		KBINBLGGLNE kBINBLGGLNE = NINILENHPHE.HFENNGHNFLF(BigInteger.One);
		switch (num)
		{
		case 1:
		case 2:
		case 6:
			return new KBINBLGGLNE[1] { kBINBLGGLNE };
		case 3:
			return new KBINBLGGLNE[3] { kBINBLGGLNE, kBINBLGGLNE, kBINBLGGLNE };
		case 4:
			return new KBINBLGGLNE[2] { kBINBLGGLNE, NINILENHPHE.JEHECJGFJEB };
		default:
			throw new ArgumentException("unknown coordinate system");
		}
	}

	protected internal bool CBICFFCIJPC()
	{
		BigInteger bigInteger = ECFGFKNLLGH.PPPAFJOLKPD;
		return bigInteger == null || bigInteger.Equals(BigInteger.One) || !KHJLHEJBLOA.AGBHEEFGGBF(this, bigInteger).IFCDKFANPBO;
	}

	protected abstract bool MMFMOOHIGNJ();

	public JGAFKLGGBGF CAFDENIJKFD()
	{
		return MIHJHLFLHNA().NCFIMIMOGDF();
	}

	protected abstract JGAFKLGGBGF NCFIMIMOGDF();

	public virtual KBINBLGGLNE NOIPJPPAFOH(int EHJNMODJEAN)
	{
		return (EHJNMODJEAN >= 0 && EHJNMODJEAN < IEHEIMJLFCI.Length) ? IEHEIMJLFCI[EHJNMODJEAN] : null;
	}

	public virtual KBINBLGGLNE[] LLCGLIKIICP()
	{
		int num = IEHEIMJLFCI.Length;
		if (num == 0)
		{
			return IEHEIMJLFCI;
		}
		KBINBLGGLNE[] array = new KBINBLGGLNE[num];
		Array.Copy(IEHEIMJLFCI, 0, array, 0, num);
		return array;
	}

	protected virtual void DFCAKCFCOAO()
	{
		if (!OFFNNOKHJCM())
		{
			throw new InvalidOperationException("point not in normal form");
		}
	}

	public virtual bool OFFNNOKHJCM()
	{
		int num = FMBBJLCHHDI;
		return num == 0 || num == 5 || IFCDKFANPBO || LAMGGDKLPJH[0].EOJCHPEGABD;
	}

	public virtual JGAFKLGGBGF MIHJHLFLHNA()
	{
		if (IFCDKFANPBO)
		{
			return this;
		}
		int num = FMBBJLCHHDI;
		if (num == 0 || num == 5)
		{
			return this;
		}
		KBINBLGGLNE kBINBLGGLNE = LAMGGDKLPJH[0];
		if (kBINBLGGLNE.EOJCHPEGABD)
		{
			return this;
		}
		return MIHJHLFLHNA(kBINBLGGLNE.LEIECFOMCNL());
	}

	internal virtual JGAFKLGGBGF MIHJHLFLHNA(KBINBLGGLNE MNCAGKHPGFJ)
	{
		switch (FMBBJLCHHDI)
		{
		case 1:
		case 6:
			return OFFLFBOHOGM(MNCAGKHPGFJ, MNCAGKHPGFJ);
		case 2:
		case 3:
		case 4:
		{
			KBINBLGGLNE kBINBLGGLNE = MNCAGKHPGFJ.MIOEHGDPGAG();
			KBINBLGGLNE gNODHDLKFLC = kBINBLGGLNE.IBJBIGNPNEM(MNCAGKHPGFJ);
			return OFFLFBOHOGM(kBINBLGGLNE, gNODHDLKFLC);
		}
		default:
			throw new InvalidOperationException("not a projective coordinate system");
		}
	}

	protected virtual JGAFKLGGBGF OFFLFBOHOGM(KBINBLGGLNE IAEDCPOGCCE, KBINBLGGLNE GNODHDLKFLC)
	{
		return ECFGFKNLLGH.IMOPAOHAOAN(NBPANDNEJGI.IBJBIGNPNEM(IAEDCPOGCCE), FIJLKLCHMGH.IBJBIGNPNEM(GNODHDLKFLC), BPGGHHMMCCB);
	}

	public bool NAFCDEECGEF()
	{
		if (IFCDKFANPBO)
		{
			return true;
		}
		BHPIABAGAPB bHPIABAGAPB = ECFGFKNLLGH;
		if (bHPIABAGAPB != null)
		{
			if (!MMFMOOHIGNJ())
			{
				return false;
			}
			if (!CBICFFCIJPC())
			{
				return false;
			}
		}
		return true;
	}

	public virtual JGAFKLGGBGF FLDLCFHBMEA(KBINBLGGLNE HJLOCAEAFMJ)
	{
		return (!IFCDKFANPBO) ? ECFGFKNLLGH.IMOPAOHAOAN(NBPANDNEJGI.IBJBIGNPNEM(HJLOCAEAFMJ), FIJLKLCHMGH, LAMGGDKLPJH, BPGGHHMMCCB) : this;
	}

	public virtual JGAFKLGGBGF DEFAMIAKKGM(KBINBLGGLNE HJLOCAEAFMJ)
	{
		return (!IFCDKFANPBO) ? ECFGFKNLLGH.IMOPAOHAOAN(NBPANDNEJGI, FIJLKLCHMGH.IBJBIGNPNEM(HJLOCAEAFMJ), LAMGGDKLPJH, BPGGHHMMCCB) : this;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as JGAFKLGGBGF);
	}

	public virtual bool KIFDKLPDKMD(JGAFKLGGBGF CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		BHPIABAGAPB bHPIABAGAPB = ECFGFKNLLGH;
		BHPIABAGAPB bHPIABAGAPB2 = CJHEIBNHNNE.ECFGFKNLLGH;
		bool flag = null == bHPIABAGAPB;
		bool flag2 = null == bHPIABAGAPB2;
		bool flag3 = IFCDKFANPBO;
		bool flag4 = CJHEIBNHNNE.IFCDKFANPBO;
		if (flag3 || flag4)
		{
			return flag3 && flag4 && (flag || flag2 || bHPIABAGAPB.KIFDKLPDKMD(bHPIABAGAPB2));
		}
		JGAFKLGGBGF jGAFKLGGBGF = this;
		JGAFKLGGBGF jGAFKLGGBGF2 = CJHEIBNHNNE;
		if (!flag || !flag2)
		{
			if (flag)
			{
				jGAFKLGGBGF2 = jGAFKLGGBGF2.MIHJHLFLHNA();
			}
			else if (flag2)
			{
				jGAFKLGGBGF = jGAFKLGGBGF.MIHJHLFLHNA();
			}
			else
			{
				if (!bHPIABAGAPB.KIFDKLPDKMD(bHPIABAGAPB2))
				{
					return false;
				}
				JGAFKLGGBGF[] array = new JGAFKLGGBGF[2]
				{
					this,
					bHPIABAGAPB.PHDNPDCNJJA(jGAFKLGGBGF2)
				};
				bHPIABAGAPB.NPDHPEDPAPA(array);
				jGAFKLGGBGF = array[0];
				jGAFKLGGBGF2 = array[1];
			}
		}
		return jGAFKLGGBGF.OBCJFNBLIPG.KIFDKLPDKMD(jGAFKLGGBGF2.OBCJFNBLIPG) && jGAFKLGGBGF.LGFGMGPDEIB.KIFDKLPDKMD(jGAFKLGGBGF2.LGFGMGPDEIB);
	}

	public override int GetHashCode()
	{
		BHPIABAGAPB bHPIABAGAPB = ECFGFKNLLGH;
		int num = ((bHPIABAGAPB != null) ? (~bHPIABAGAPB.GetHashCode()) : 0);
		if (!IFCDKFANPBO)
		{
			JGAFKLGGBGF jGAFKLGGBGF = MIHJHLFLHNA();
			num ^= jGAFKLGGBGF.OBCJFNBLIPG.GetHashCode() * 17;
			num ^= jGAFKLGGBGF.LGFGMGPDEIB.GetHashCode() * 257;
		}
		return num;
	}

	public override string ToString()
	{
		if (IFCDKFANPBO)
		{
			return "INF";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		stringBuilder.Append(NBPANDNEJGI);
		stringBuilder.Append(',');
		stringBuilder.Append(FIJLKLCHMGH);
		for (int i = 0; i < IEHEIMJLFCI.Length; i++)
		{
			stringBuilder.Append(',');
			stringBuilder.Append(IEHEIMJLFCI[i]);
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	public virtual byte[] PPCPBIEGJKM()
	{
		return PPCPBIEGJKM(ANAHOJBBEDJ);
	}

	public abstract byte[] PPCPBIEGJKM(bool BDKLBMAKEIN);

	public abstract JGAFKLGGBGF JEACJNAKLDJ(JGAFKLGGBGF BCIHLCMFAEK);

	public abstract JGAFKLGGBGF FBGIHKPECCO(JGAFKLGGBGF BCIHLCMFAEK);

	public abstract JGAFKLGGBGF BHKOFHMDACN();

	public virtual JGAFKLGGBGF BMHHHPFDNMA(int EKFOKNPODBK)
	{
		if (EKFOKNPODBK < 0)
		{
			throw new ArgumentException("cannot be negative", "e");
		}
		JGAFKLGGBGF jGAFKLGGBGF = this;
		while (--EKFOKNPODBK >= 0)
		{
			jGAFKLGGBGF = jGAFKLGGBGF.LLGLJBDLBOP();
		}
		return jGAFKLGGBGF;
	}

	public abstract JGAFKLGGBGF LLGLJBDLBOP();

	public abstract JGAFKLGGBGF IBJBIGNPNEM(BigInteger BCIHLCMFAEK);

	public virtual JGAFKLGGBGF GFLGEFHLIGE(JGAFKLGGBGF BCIHLCMFAEK)
	{
		return LLGLJBDLBOP().JEACJNAKLDJ(BCIHLCMFAEK);
	}

	public virtual JGAFKLGGBGF LFFNDDCHCMH()
	{
		return GFLGEFHLIGE(this);
	}
}
