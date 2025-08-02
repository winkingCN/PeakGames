using System;

public class PNKAJJJPEPA : EDOEBJJFOBM
{
	private readonly byte EDDNOJDPMCF;

	public static readonly PNKAJJJPEPA FMJAIBMGPJO = new PNKAJJJPEPA(false);

	public static readonly PNKAJJJPEPA OKKOIIMLJOM = new PNKAJJJPEPA(true);

	public bool ELAOLKPILED
	{
		get
		{
			return EDDNOJDPMCF != 0;
		}
	}

	public PNKAJJJPEPA(byte[] HIMINGHNIKN)
	{
		if (HIMINGHNIKN.Length != 1)
		{
			throw new ArgumentException("byte value should have 1 byte in it", "val");
		}
		EDDNOJDPMCF = HIMINGHNIKN[0];
	}

	private PNKAJJJPEPA(bool EDDNOJDPMCF)
	{
		this.EDDNOJDPMCF = (byte)(EDDNOJDPMCF ? byte.MaxValue : 0);
	}

	public static PNKAJJJPEPA BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is PNKAJJJPEPA)
		{
			return (PNKAJJJPEPA)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static PNKAJJJPEPA BJLJCGFMFOO(bool EDDNOJDPMCF)
	{
		return (!EDDNOJDPMCF) ? FMJAIBMGPJO : OKKOIIMLJOM;
	}

	public static PNKAJJJPEPA BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is PNKAJJJPEPA)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return DADPGGIAGHN(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(1, new byte[1] { EDDNOJDPMCF });
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		PNKAJJJPEPA pNKAJJJPEPA = LABMKGMAEGK as PNKAJJJPEPA;
		if (pNKAJJJPEPA == null)
		{
			return false;
		}
		return ELAOLKPILED == pNKAJJJPEPA.ELAOLKPILED;
	}

	protected override int BGFGDLGFEPI()
	{
		return ELAOLKPILED.GetHashCode();
	}

	public override string ToString()
	{
		return (!ELAOLKPILED) ? "FALSE" : "TRUE";
	}

	internal static PNKAJJJPEPA DADPGGIAGHN(byte[] EDDNOJDPMCF)
	{
		if (EDDNOJDPMCF.Length != 1)
		{
			throw new ArgumentException("BOOLEAN value should have 1 byte in it", "value");
		}
		PNKAJJJPEPA result;
		switch (EDDNOJDPMCF[0])
		{
		case 0:
			result = FMJAIBMGPJO;
			break;
		case byte.MaxValue:
			result = OKKOIIMLJOM;
			break;
		default:
			result = new PNKAJJJPEPA(EDDNOJDPMCF);
			break;
		}
		return result;
	}
}
