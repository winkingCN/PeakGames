public class HCMCCCCKCMG
{
	private string GDFLIKNMBCL;

	private int EHJNMODJEAN;

	public bool OEGNOKFOOBH
	{
		get
		{
			return EHJNMODJEAN != -1;
		}
	}

	public HCMCCCCKCMG(string GDFLIKNMBCL)
	{
		this.GDFLIKNMBCL = GDFLIKNMBCL;
	}

	public string NMLDMNBOJFN()
	{
		if (EHJNMODJEAN == -1)
		{
			return null;
		}
		int num = GDFLIKNMBCL.IndexOf('.', EHJNMODJEAN);
		if (num == -1)
		{
			string result = GDFLIKNMBCL.Substring(EHJNMODJEAN);
			EHJNMODJEAN = -1;
			return result;
		}
		string result2 = GDFLIKNMBCL.Substring(EHJNMODJEAN, num - EHJNMODJEAN);
		EHJNMODJEAN = num + 1;
		return result2;
	}
}
