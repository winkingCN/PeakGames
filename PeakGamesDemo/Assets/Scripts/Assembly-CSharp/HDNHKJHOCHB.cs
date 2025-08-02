using System;
using System.Text.RegularExpressions;

public abstract class HDNHKJHOCHB
{
	public string ONBMHAMJPOJ;

	public int IPLKKJOIMPM;

	protected HDNHKJHOCHB(string CFGGBONGJNP)
	{
		Regex regex = new Regex("(<=|>=|!=|=|>|<)\\s*([0-9]+)");
		Match match = regex.Match(CFGGBONGJNP);
		ONBMHAMJPOJ = match.Groups[1].Value;
		IPLKKJOIMPM = int.Parse(match.Groups[2].Value);
	}

	public bool KFEIOECKONB(KFCEILFGADG GIOFHACJEGA)
	{
		int num = BHCEMBBCHKE(GIOFHACJEGA);
		switch (ONBMHAMJPOJ)
		{
		case "=":
			return num == IPLKKJOIMPM;
		case ">":
			return num > IPLKKJOIMPM;
		case "<":
			return num < IPLKKJOIMPM;
		case ">=":
			return num >= IPLKKJOIMPM;
		case "<=":
			return num <= IPLKKJOIMPM;
		case "!=":
			return num != IPLKKJOIMPM;
		default:
			throw new Exception("Unknown operand type:" + ONBMHAMJPOJ);
		}
	}

	public abstract int BHCEMBBCHKE(KFCEILFGADG GIOFHACJEGA);
}
