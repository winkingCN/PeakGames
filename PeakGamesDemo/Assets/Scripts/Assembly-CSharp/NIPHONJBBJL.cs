public class NIPHONJBBJL : JIDJCBGKJPF
{
	private string INECNEPDJDN;

	private bool DCNGAGBMBGC;

	public NIPHONJBBJL(string EJBMABJCEDN)
	{
		INECNEPDJDN = EJBMABJCEDN;
	}

	public bool IONCPAHMPIL()
	{
		if (INECNEPDJDN == null)
		{
			return false;
		}
		string[] array = INECNEPDJDN.Split(',');
		if (array.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].ToLower();
			if (text.Equals("android"))
			{
				return true;
			}
		}
		return false;
	}
}
