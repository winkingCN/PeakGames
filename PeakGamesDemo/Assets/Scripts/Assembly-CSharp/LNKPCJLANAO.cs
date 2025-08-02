using System.IO;

public abstract class LNKPCJLANAO : HGIAHEKANFO
{
	public const string FEMIAPIDLON = "DER";

	public const string BEODEEOEJLD = "BER";

	public byte[] PPCPBIEGJKM()
	{
		MemoryStream memoryStream = new MemoryStream();
		KDNENBIPFBJ kDNENBIPFBJ = new KDNENBIPFBJ(memoryStream);
		kDNENBIPFBJ.ELPOLPFGCHA(this);
		return memoryStream.ToArray();
	}

	public byte[] PPCPBIEGJKM(string NJPMJNHGDNE)
	{
		if (NJPMJNHGDNE.Equals("DER"))
		{
			MemoryStream memoryStream = new MemoryStream();
			JBLJHINPLMC jBLJHINPLMC = new JBLJHINPLMC(memoryStream);
			jBLJHINPLMC.ELPOLPFGCHA(this);
			return memoryStream.ToArray();
		}
		return PPCPBIEGJKM();
	}

	public byte[] KMBJLPOKIAC()
	{
		try
		{
			return PPCPBIEGJKM("DER");
		}
		catch (IOException)
		{
			return null;
		}
	}

	public sealed override int GetHashCode()
	{
		return IIHKEACDNID().DLFOFMGBLDL();
	}

	public sealed override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		HGIAHEKANFO hGIAHEKANFO = NEMEKIOEOLC as HGIAHEKANFO;
		if (hGIAHEKANFO == null)
		{
			return false;
		}
		EDOEBJJFOBM eDOEBJJFOBM = IIHKEACDNID();
		EDOEBJJFOBM eDOEBJJFOBM2 = hGIAHEKANFO.IIHKEACDNID();
		return eDOEBJJFOBM == eDOEBJJFOBM2 || eDOEBJJFOBM.JEIBPIEIFGK(eDOEBJJFOBM2);
	}

	public abstract EDOEBJJFOBM IIHKEACDNID();
}
