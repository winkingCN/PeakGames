using System;
using System.IO;

public class BKHIKPBFIAG : Stream
{
	private const int CGCJKPHBNBN = 512;

	protected NNHGBFFHNMG IGNEOOOFEMO;

	protected int PLGJJDHIOMH;

	protected byte[] GHPCHPOHELF = new byte[512];

	protected byte[] APOLOIOKCMP = new byte[1];

	protected bool EEHLMFLGNAK;

	protected Stream BILGCJNPJGJ;

	protected bool MBEOPLHLANP;

	public sealed override bool OEIHDCMBCBA
	{
		get
		{
			return false;
		}
	}

	public sealed override bool GEEJNFKINOG
	{
		get
		{
			return false;
		}
	}

	public sealed override bool APIAGFPBBPE
	{
		get
		{
			return !MBEOPLHLANP;
		}
	}

	public virtual int IEBJHMIKDMD
	{
		get
		{
			return PLGJJDHIOMH;
		}
		set
		{
			PLGJJDHIOMH = value;
		}
	}

	public sealed override long EJIAJLPHOGC
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public sealed override long LJCIBEOLCHF
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public virtual long NCBPFEKLBCE
	{
		get
		{
			return IGNEOOOFEMO.IOKPEPLADED;
		}
	}

	public virtual long INPNDOIHFKF
	{
		get
		{
			return IGNEOOOFEMO.MDLEDIJMGHC;
		}
	}

	public BKHIKPBFIAG(Stream BILGCJNPJGJ)
		: this(BILGCJNPJGJ, false)
	{
	}

	public BKHIKPBFIAG(Stream BILGCJNPJGJ, bool ENEMOKBHJHI)
		: this(BILGCJNPJGJ, FEGNGLHCNAL(ENEMOKBHJHI))
	{
	}

	public BKHIKPBFIAG(Stream BILGCJNPJGJ, NNHGBFFHNMG IGNEOOOFEMO)
	{
		if (IGNEOOOFEMO == null)
		{
			IGNEOOOFEMO = new NNHGBFFHNMG();
		}
		if (IGNEOOOFEMO.KKJCMLLCLAL == null && IGNEOOOFEMO.CJCMPNIDOML == null)
		{
			IGNEOOOFEMO.EHLPFDMFEKP();
		}
		this.BILGCJNPJGJ = BILGCJNPJGJ;
		EEHLMFLGNAK = IGNEOOOFEMO.KKJCMLLCLAL == null;
		this.IGNEOOOFEMO = IGNEOOOFEMO;
	}

	public BKHIKPBFIAG(Stream BILGCJNPJGJ, int GIOFHACJEGA)
		: this(BILGCJNPJGJ, GIOFHACJEGA, false)
	{
	}

	public BKHIKPBFIAG(Stream BILGCJNPJGJ, int GIOFHACJEGA, bool ENEMOKBHJHI)
	{
		this.BILGCJNPJGJ = BILGCJNPJGJ;
		EEHLMFLGNAK = true;
		IGNEOOOFEMO = new NNHGBFFHNMG();
		IGNEOOOFEMO.NAIKIJLGMPC(GIOFHACJEGA, ENEMOKBHJHI);
	}

	private static NNHGBFFHNMG FEGNGLHCNAL(bool ENEMOKBHJHI)
	{
		NNHGBFFHNMG nNHGBFFHNMG = new NNHGBFFHNMG();
		nNHGBFFHNMG.EHLPFDMFEKP(ENEMOKBHJHI);
		return nNHGBFFHNMG;
	}

	public override void Close()
	{
		if (!MBEOPLHLANP)
		{
			NAEOEKKEIOK();
			base.Close();
		}
	}

	private void NAEOEKKEIOK()
	{
		try
		{
			OJILOEAPDCL();
		}
		catch (IOException)
		{
		}
		finally
		{
			MBEOPLHLANP = true;
			BBLBNCKNGDL();
			LHFGHNFJIKM.PCHCAFHEJJM(BILGCJNPJGJ);
			BILGCJNPJGJ = null;
		}
	}

	public virtual void BBLBNCKNGDL()
	{
		if (IGNEOOOFEMO != null)
		{
			if (EEHLMFLGNAK)
			{
				IGNEOOOFEMO.AONAGNNALOM();
			}
			else
			{
				IGNEOOOFEMO.BIMEKKEKKPB();
			}
			IGNEOOOFEMO.KNLOBIILDMP();
			IGNEOOOFEMO = null;
		}
	}

	public virtual void OJILOEAPDCL()
	{
		do
		{
			IGNEOOOFEMO.BHHDNEGGGGJ = GHPCHPOHELF;
			IGNEOOOFEMO.FOJDONLMBLJ = 0;
			IGNEOOOFEMO.PMJBPCFCGJO = GHPCHPOHELF.Length;
			int num = ((!EEHLMFLGNAK) ? IGNEOOOFEMO.HHFIBDKMPBP(4) : IGNEOOOFEMO.GNJMLEHEFEM(4));
			if (num != 1 && num != 0)
			{
				throw new IOException(((!EEHLMFLGNAK) ? "in" : "de") + "flating: " + IGNEOOOFEMO.NOIOHIPHFHA);
			}
			int num2 = GHPCHPOHELF.Length - IGNEOOOFEMO.PMJBPCFCGJO;
			if (num2 > 0)
			{
				BILGCJNPJGJ.Write(GHPCHPOHELF, 0, num2);
			}
		}
		while (IGNEOOOFEMO.HCNAGHNCFLL > 0 || IGNEOOOFEMO.PMJBPCFCGJO == 0);
		Flush();
	}

	public override void Flush()
	{
		BILGCJNPJGJ.Flush();
	}

	public sealed override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		throw new NotSupportedException();
	}

	public sealed override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotSupportedException();
	}

	public sealed override void SetLength(long EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] BCIHLCMFAEK, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (NBEDPKHALCN == 0)
		{
			return;
		}
		IGNEOOOFEMO.BLJFIEBCEPL = BCIHLCMFAEK;
		IGNEOOOFEMO.HBCHEGLPAIJ = JBAJPGIAPFF;
		IGNEOOOFEMO.HCNAGHNCFLL = NBEDPKHALCN;
		do
		{
			IGNEOOOFEMO.BHHDNEGGGGJ = GHPCHPOHELF;
			IGNEOOOFEMO.FOJDONLMBLJ = 0;
			IGNEOOOFEMO.PMJBPCFCGJO = GHPCHPOHELF.Length;
			if (((!EEHLMFLGNAK) ? IGNEOOOFEMO.HHFIBDKMPBP(PLGJJDHIOMH) : IGNEOOOFEMO.GNJMLEHEFEM(PLGJJDHIOMH)) != 0)
			{
				throw new IOException(((!EEHLMFLGNAK) ? "in" : "de") + "flating: " + IGNEOOOFEMO.NOIOHIPHFHA);
			}
			BILGCJNPJGJ.Write(GHPCHPOHELF, 0, GHPCHPOHELF.Length - IGNEOOOFEMO.PMJBPCFCGJO);
		}
		while (IGNEOOOFEMO.HCNAGHNCFLL > 0 || IGNEOOOFEMO.PMJBPCFCGJO == 0);
	}

	public override void WriteByte(byte BCIHLCMFAEK)
	{
		APOLOIOKCMP[0] = BCIHLCMFAEK;
		Write(APOLOIOKCMP, 0, 1);
	}
}
