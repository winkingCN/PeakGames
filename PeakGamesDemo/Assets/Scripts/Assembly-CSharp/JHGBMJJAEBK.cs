using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security.Certificates;

public class JHGBMJJAEBK
{
	private static readonly JJGIGNBOBJG FLJFOJGEDGF = new JJGIGNBOBJG("CERTIFICATE");

	private FAGODOKGMEH ONJHFOEPJPH;

	private int LCBKAGFOMLP;

	private Stream JHAIEBEMALE;

	private MPMAOKNGPCF KIJHMFKEAHB(AOKAOIHEKIH IJFDHDOHBEF)
	{
		ALLINHNNNJN aLLINHNNNJN = (ALLINHNNNJN)IJFDHDOHBEF.DMHLIGLGJGI();
		if (aLLINHNNNJN.GMCGMPEEHJP > 1 && aLLINHNNNJN.ECNCPJGHBIG(0) is KLKJHFKJLEM && aLLINHNNNJN.ECNCPJGHBIG(0).Equals(NLPPJKFFBON.HIGAMNPBLBO))
		{
			ONJHFOEPJPH = DEPIBGIJJNK.BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO((PAANMJLACEF)aLLINHNNNJN.ECNCPJGHBIG(1), true)).DGMBHCFPAKD;
			return MDGKJLENLMO();
		}
		return LHOOBNMFHOM(NGNPCPDMGBC.BJLJCGFMFOO(aLLINHNNNJN));
	}

	private MPMAOKNGPCF MDGKJLENLMO()
	{
		if (ONJHFOEPJPH != null)
		{
			while (LCBKAGFOMLP < ONJHFOEPJPH.GMCGMPEEHJP)
			{
				object obj = ONJHFOEPJPH.ECNCPJGHBIG(LCBKAGFOMLP++);
				if (obj is ALLINHNNNJN)
				{
					return LHOOBNMFHOM(NGNPCPDMGBC.BJLJCGFMFOO(obj));
				}
			}
		}
		return null;
	}

	private MPMAOKNGPCF IHMCLCNMKNB(Stream EPKPLBOMHJL)
	{
		ALLINHNNNJN aLLINHNNNJN = FLJFOJGEDGF.LIMPKFOBIED(EPKPLBOMHJL);
		return (aLLINHNNNJN != null) ? LHOOBNMFHOM(NGNPCPDMGBC.BJLJCGFMFOO(aLLINHNNNJN)) : null;
	}

	protected virtual MPMAOKNGPCF LHOOBNMFHOM(NGNPCPDMGBC FMFABAKPMLB)
	{
		return new MPMAOKNGPCF(FMFABAKPMLB);
	}

	public MPMAOKNGPCF DIGKPHDCAGO(byte[] MOPCLEEGDFB)
	{
		return DIGKPHDCAGO(new MemoryStream(MOPCLEEGDFB, false));
	}

	public ICollection KOCKMLMHFJK(byte[] MOPCLEEGDFB)
	{
		return KOCKMLMHFJK(new MemoryStream(MOPCLEEGDFB, false));
	}

	public MPMAOKNGPCF DIGKPHDCAGO(Stream EPKPLBOMHJL)
	{
		if (EPKPLBOMHJL == null)
		{
			throw new ArgumentNullException("inStream");
		}
		if (!EPKPLBOMHJL.CanRead)
		{
			throw new ArgumentException("inStream must be read-able", "inStream");
		}
		if (JHAIEBEMALE == null)
		{
			JHAIEBEMALE = EPKPLBOMHJL;
			ONJHFOEPJPH = null;
			LCBKAGFOMLP = 0;
		}
		else if (JHAIEBEMALE != EPKPLBOMHJL)
		{
			JHAIEBEMALE = EPKPLBOMHJL;
			ONJHFOEPJPH = null;
			LCBKAGFOMLP = 0;
		}
		try
		{
			if (ONJHFOEPJPH != null)
			{
				if (LCBKAGFOMLP != ONJHFOEPJPH.GMCGMPEEHJP)
				{
					return MDGKJLENLMO();
				}
				ONJHFOEPJPH = null;
				LCBKAGFOMLP = 0;
				return null;
			}
			PFGADOAKFGI pFGADOAKFGI = new PFGADOAKFGI(EPKPLBOMHJL);
			int num = pFGADOAKFGI.ReadByte();
			if (num < 0)
			{
				return null;
			}
			pFGADOAKFGI.CNHKNKAFPKE(num);
			if (num != 48)
			{
				return IHMCLCNMKNB(pFGADOAKFGI);
			}
			return KIJHMFKEAHB(new AOKAOIHEKIH(pFGADOAKFGI));
		}
		catch (Exception fGDHECKFFDP)
		{
			throw new CertificateException("Failed to read certificate", fGDHECKFFDP);
		}
	}

	public ICollection KOCKMLMHFJK(Stream EPKPLBOMHJL)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		MPMAOKNGPCF value;
		while ((value = DIGKPHDCAGO(EPKPLBOMHJL)) != null)
		{
			list.Add(value);
		}
		return list;
	}
}
