using System;
using System.Collections.Generic;

public class NKILAONHNNE
{
	public int KJLHFILAKOB;

	public string ELGCDBGLEIC;

	public string MBDEEBONIFB;

	public int KOPMPMIFHNF;

	public int OADDPGNIINO;

	public long FLPEILFNDPO;

	public long PFNNFPIDHFN;

	public int GDMECFECCOM;

	public NKILAONHNNE(Dictionary<string, object> MMLFCNPDEEG)
	{
		object value;
		MMLFCNPDEEG.TryGetValue("errNo", out value);
		object value2;
		MMLFCNPDEEG.TryGetValue("errorMsg", out value2);
		object value3;
		MMLFCNPDEEG.TryGetValue("host", out value3);
		object value4;
		MMLFCNPDEEG.TryGetValue("level", out value4);
		object value5;
		MMLFCNPDEEG.TryGetValue("time", out value5);
		object value6;
		MMLFCNPDEEG.TryGetValue("teamId", out value6);
		object value7;
		MMLFCNPDEEG.TryGetValue("userId", out value7);
		object value8;
		MMLFCNPDEEG.TryGetValue("serverTime", out value8);
		KJLHFILAKOB = Convert.ToInt32(value);
		KOPMPMIFHNF = Convert.ToInt32(value4);
		OADDPGNIINO = Convert.ToInt32(value6);
		ELGCDBGLEIC = value2 as string;
		MBDEEBONIFB = value3 as string;
		FLPEILFNDPO = Convert.ToInt64(value8);
		GDMECFECCOM = Convert.ToInt32(value7);
		PFNNFPIDHFN = Convert.ToInt64(value5);
	}

	public override string ToString()
	{
		return string.Format("ErrorNo: {0}, ErrorMessage: {1}", KJLHFILAKOB, ELGCDBGLEIC);
	}
}
