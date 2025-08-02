using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class MPHIIHDHBBF : JLODNMAAHAC
{
	private JLODNMAAHAC DDHOMPOAEEM;

	private string BJGKMPBJEJP;

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			return new MPHIIHDHBBF(this);
		}
		set
		{
			DGFIHEEHLKF dGFIHEEHLKF = new DGFIHEEHLKF();
			dGFIHEEHLKF.JEACJNAKLDJ(value);
			EPKMIBEOIJJ(dGFIHEEHLKF);
		}
	}

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			return new MPHIIHDHBBF(this, OMGPFPGELOM);
		}
		set
		{
			FDKLGGOAFPJ fDKLGGOAFPJ = new FDKLGGOAFPJ();
			fDKLGGOAFPJ.JEACJNAKLDJ(OMGPFPGELOM, value);
			EPKMIBEOIJJ(fDKLGGOAFPJ);
		}
	}

	public override int JJNCOPEDMJA
	{
		get
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(0);
			EPKMIBEOIJJ(dHMEDJGLPHF);
			return 0;
		}
		set
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(value);
			EPKMIBEOIJJ(dHMEDJGLPHF);
		}
	}

	public override float JJAOJGHMNED
	{
		get
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(0f);
			EPKMIBEOIJJ(dHMEDJGLPHF);
			return 0f;
		}
		set
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(value);
			EPKMIBEOIJJ(dHMEDJGLPHF);
		}
	}

	public override double PMICJHNDLKP
	{
		get
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(0.0);
			EPKMIBEOIJJ(dHMEDJGLPHF);
			return 0.0;
		}
		set
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(value);
			EPKMIBEOIJJ(dHMEDJGLPHF);
		}
	}

	public override bool OLICILPDIGA
	{
		get
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(false);
			EPKMIBEOIJJ(dHMEDJGLPHF);
			return false;
		}
		set
		{
			AKDPOOMBAMD dHMEDJGLPHF = new AKDPOOMBAMD(value);
			EPKMIBEOIJJ(dHMEDJGLPHF);
		}
	}

	public override DGFIHEEHLKF NLOOFFLFPPE
	{
		get
		{
			DGFIHEEHLKF dGFIHEEHLKF = new DGFIHEEHLKF();
			EPKMIBEOIJJ(dGFIHEEHLKF);
			return dGFIHEEHLKF;
		}
	}

	public override FDKLGGOAFPJ JPIHKOGIKHA
	{
		get
		{
			FDKLGGOAFPJ fDKLGGOAFPJ = new FDKLGGOAFPJ();
			EPKMIBEOIJJ(fDKLGGOAFPJ);
			return fDKLGGOAFPJ;
		}
	}

	public MPHIIHDHBBF(JLODNMAAHAC LELOKDCLJMD)
	{
		DDHOMPOAEEM = LELOKDCLJMD;
		BJGKMPBJEJP = null;
	}

	public MPHIIHDHBBF(JLODNMAAHAC LELOKDCLJMD, string OMGPFPGELOM)
	{
		DDHOMPOAEEM = LELOKDCLJMD;
		BJGKMPBJEJP = OMGPFPGELOM;
	}

	private void EPKMIBEOIJJ(JLODNMAAHAC DHMEDJGLPHF)
	{
		if (BJGKMPBJEJP == null)
		{
			DDHOMPOAEEM.JEACJNAKLDJ(DHMEDJGLPHF);
		}
		else
		{
			DDHOMPOAEEM.JEACJNAKLDJ(BJGKMPBJEJP, DHMEDJGLPHF);
		}
		DDHOMPOAEEM = null;
	}

	public override void JEACJNAKLDJ(JLODNMAAHAC GFADEOLDFDI)
	{
		DGFIHEEHLKF dGFIHEEHLKF = new DGFIHEEHLKF();
		dGFIHEEHLKF.JEACJNAKLDJ(GFADEOLDFDI);
		EPKMIBEOIJJ(dGFIHEEHLKF);
	}

	public override void JEACJNAKLDJ(string OMGPFPGELOM, JLODNMAAHAC GFADEOLDFDI)
	{
		FDKLGGOAFPJ fDKLGGOAFPJ = new FDKLGGOAFPJ();
		fDKLGGOAFPJ.JEACJNAKLDJ(OMGPFPGELOM, GFADEOLDFDI);
		EPKMIBEOIJJ(fDKLGGOAFPJ);
	}

	[SpecialName]
	public static bool OCAFFLHPIMM(MPHIIHDHBBF MNIMEAMHNMI, object BCIHLCMFAEK)
	{
		if (BCIHLCMFAEK == null)
		{
			return true;
		}
		return object.ReferenceEquals(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	[SpecialName]
	public static bool BLPPLFIKFPN(MPHIIHDHBBF MNIMEAMHNMI, object BCIHLCMFAEK)
	{
		return !OCAFFLHPIMM(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			return true;
		}
		return object.ReferenceEquals(this, NEMEKIOEOLC);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		return string.Empty;
	}

	public override string NHMGCGBMCNM(string KECKLEJAGKP)
	{
		return string.Empty;
	}
}
