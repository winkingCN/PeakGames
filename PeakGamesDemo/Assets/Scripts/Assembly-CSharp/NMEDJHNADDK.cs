using System.IO;

public class NMEDJHNADDK : EIMOMMNKKEG
{
	protected class CCLFKJBLGND : BKHIKPBFIAG
	{
		public CCLFKJBLGND(Stream BILGCJNPJGJ, NNHGBFFHNMG IGNEOOOFEMO, bool EEHLMFLGNAK)
			: base(BILGCJNPJGJ, IGNEOOOFEMO)
		{
			base.EEHLMFLGNAK = EEHLMFLGNAK;
			IEBJHMIKDMD = 2;
		}

		public override void Flush()
		{
		}
	}

	public const int EBEJMOJFJJB = 0;

	public const int FEBKBPBNNBB = 1;

	public const int PGHCJFGFLIO = 9;

	public const int JHIBACOFNIA = -1;

	protected readonly NNHGBFFHNMG LNCEHPJHOKD;

	protected readonly NNHGBFFHNMG KHFCBOFKABH;

	public NMEDJHNADDK()
		: this(-1)
	{
	}

	public NMEDJHNADDK(int GIOFHACJEGA)
	{
		LNCEHPJHOKD = new NNHGBFFHNMG();
		LNCEHPJHOKD.EHLPFDMFEKP();
		KHFCBOFKABH = new NNHGBFFHNMG();
		KHFCBOFKABH.NAIKIJLGMPC(GIOFHACJEGA);
	}

	public virtual Stream CMBDCJOOPPK(Stream BILGCJNPJGJ)
	{
		return new CCLFKJBLGND(BILGCJNPJGJ, KHFCBOFKABH, true);
	}

	public virtual Stream GLOBHILMJCN(Stream BILGCJNPJGJ)
	{
		return new CCLFKJBLGND(BILGCJNPJGJ, LNCEHPJHOKD, false);
	}
}
