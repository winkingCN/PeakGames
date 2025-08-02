using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Assets.Scripts.CasualTools.Common.DB;
using UnityEngine;

public abstract class JEDMENFBGJI<T> where T : Entity
{
	private string GMHMLKKBOJI;

	protected JEDMENFBGJI()
	{
		string hKCKEACCMMA = MCPNNIHODDL();
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
		string[] array = JEOIMDLGKLD();
		if (array != null)
		{
			string[] array2 = array;
			foreach (string hKCKEACCMMA2 in array2)
			{
				KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA2);
			}
		}
	}

	public virtual void LFHHPPDJGDC(T LLIEHCKNJEM)
	{
		string hKCKEACCMMA = OAHFNMOIGLH(LLIEHCKNJEM);
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
		MBBJJJGFIKD mBBJJJGFIKD = KCAELBCNKFN.GABGKBAKHDP.KLGGEBEDDJJ(FIOJBHDKKKG());
		if (mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			LLIEHCKNJEM.PNLKNJNILDD((int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("seq"));
		}
	}

	public virtual void BJNFGAFBCGJ(T LLIEHCKNJEM)
	{
		if (!LLIEHCKNJEM.AIAEHPLOFGB().HasValue)
		{
			LFHHPPDJGDC(LLIEHCKNJEM);
			return;
		}
		T val = BGNCAGELKFL(LLIEHCKNJEM.AIAEHPLOFGB().Value);
		if (val != null)
		{
			GDFHLDAKIOM(LLIEHCKNJEM);
			return;
		}
		LLIEHCKNJEM.PNLKNJNILDD(null);
		LFHHPPDJGDC(LLIEHCKNJEM);
	}

	public virtual void EAADMJMDLCC(List<T> BOABPGJAONO)
	{
		if (BOABPGJAONO != null && BOABPGJAONO.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < BOABPGJAONO.Count; i++)
			{
				T lLIEHCKNJEM = BOABPGJAONO[i];
				stringBuilder.Append(OAHFNMOIGLH(lLIEHCKNJEM));
				stringBuilder.Append(';');
			}
			KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(stringBuilder.ToString());
		}
	}

	public virtual T BGNCAGELKFL(int BDKFNEDHAOJ)
	{
		string hKCKEACCMMA = string.Format("select * from {0} where {1}={2}", CMDKIHPAGPL(), HNDPDOOLBKC(), BDKFNEDHAOJ);
		MBBJJJGFIKD mBBJJJGFIKD = KCAELBCNKFN.GABGKBAKHDP.KLGGEBEDDJJ(hKCKEACCMMA);
		int count = mBBJJJGFIKD.DFOGCCJCNJJ.Count;
		if (count == 0)
		{
			return (T)null;
		}
		if (count > 1)
		{
			Debug.LogWarning("Many entities of type " + CMDKIHPAGPL() + " for key: " + BDKFNEDHAOJ);
		}
		DCMNFAKJKCH bCAKHCNOKDH = mBBJJJGFIKD.DFOGCCJCNJJ[0];
		return EOPGEOIHOAM(bCAKHCNOKDH);
	}

	public List<T> BGBNJNLDBNP()
	{
		string hKCKEACCMMA = string.Format("select * from {0}", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = KCAELBCNKFN.GABGKBAKHDP.KLGGEBEDDJJ(hKCKEACCMMA);
		List<T> list = new List<T>();
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ == null)
		{
			return list;
		}
		foreach (DCMNFAKJKCH item in mBBJJJGFIKD.DFOGCCJCNJJ)
		{
			list.Add(EOPGEOIHOAM(item));
		}
		return list;
	}

	public int DMPHDMOCBHD()
	{
		string nGKFCKIHIPE = string.Format("select count(*) as cnt from {0}", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count <= 0)
		{
			return 0;
		}
		DCMNFAKJKCH dCMNFAKJKCH = mBBJJJGFIKD.DFOGCCJCNJJ[0];
		return (int)dCMNFAKJKCH.ECNCPJGHBIG("cnt");
	}

	public virtual void GDFHLDAKIOM(T LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = FHIBIOKHLNE(LLIEHCKNJEM);
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int count = dictionary.Count;
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			num++;
			string key = item.Key;
			object value = item.Value;
			stringBuilder.Append(key).Append('=');
			if (value == null)
			{
				stringBuilder.Append("null");
			}
			else if (value is int || value is long)
			{
				stringBuilder.Append(value);
			}
			else if (value is float || value is double)
			{
				stringBuilder.Append(string.Format(CultureInfo.InvariantCulture, "{0:0.0000}", value));
			}
			else
			{
				stringBuilder.Append('\'');
				stringBuilder.Append((value as string).Replace("'", "''"));
				stringBuilder.Append('\'');
			}
			if (count != num)
			{
				stringBuilder.Append(',');
			}
		}
		string hKCKEACCMMA = string.Format("UPDATE {0}\n\t\t\t\tSET {1}\n\t\t\t\t\tWHERE {2}={3};", CMDKIHPAGPL(), stringBuilder, HNDPDOOLBKC(), LLIEHCKNJEM.AIAEHPLOFGB().Value);
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
	}

	public virtual void IKIOFOOBHDM(T LLIEHCKNJEM)
	{
		IKIOFOOBHDM(LLIEHCKNJEM.AIAEHPLOFGB().Value);
	}

	public virtual void IKIOFOOBHDM(int BDKFNEDHAOJ)
	{
		string hKCKEACCMMA = string.Format("delete from {0} where {1}={2}", CMDKIHPAGPL(), HNDPDOOLBKC(), BDKFNEDHAOJ);
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
	}

	private string FIOJBHDKKKG()
	{
		return GMHMLKKBOJI ?? (GMHMLKKBOJI = string.Format("select seq from sqlite_sequence where name=\"{0}\"", CMDKIHPAGPL()));
	}

	private string OAHFNMOIGLH(T LLIEHCKNJEM)
	{
		object[] array = BMKKJMIKDPO(LLIEHCKNJEM);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("insert into " + CMDKIHPAGPL() + " values (");
		for (int i = 0; i < array.Length; i++)
		{
			object obj = array[i];
			if (obj == null)
			{
				stringBuilder.Append("null");
			}
			else if (obj is int)
			{
				stringBuilder.Append(obj);
			}
			else if (obj is long)
			{
				stringBuilder.Append(obj);
			}
			else if (obj is float || obj is double)
			{
				stringBuilder.Append(string.Format(CultureInfo.InvariantCulture, "{0:0.0000}", obj));
			}
			else
			{
				stringBuilder.Append('\'');
				stringBuilder.Append((obj as string).Replace("'", "''"));
				stringBuilder.Append('\'');
			}
			if (i != array.Length - 1)
			{
				stringBuilder.Append(',');
			}
		}
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	protected string HCNJKKJJPFI(string IKNCPEPOKGJ)
	{
		return "'" + IKNCPEPOKGJ.Replace("'", "''") + "'";
	}

	protected MBBJJJGFIKD ODIPOJCEPEJ(string NGKFCKIHIPE)
	{
		return KCAELBCNKFN.GABGKBAKHDP.KLGGEBEDDJJ(NGKFCKIHIPE);
	}

	protected void OMBKLCBCMGP(string NGKFCKIHIPE)
	{
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(NGKFCKIHIPE);
	}

	protected virtual string HNDPDOOLBKC()
	{
		return "id";
	}

	public void BBGLCADIONK()
	{
		ODIPOJCEPEJ("delete from " + CMDKIHPAGPL());
	}

	protected T PEFIHEFDOIE(string NGKFCKIHIPE)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(NGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return (T)null;
		}
		return EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
	}

	protected List<T> LIGBBHCFEIJ(string NGKFCKIHIPE)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(NGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return null;
		}
		List<T> list = new List<T>(mBBJJJGFIKD.DFOGCCJCNJJ.Count);
		foreach (DCMNFAKJKCH item in mBBJJJGFIKD.DFOGCCJCNJJ)
		{
			list.Add(EOPGEOIHOAM(item));
		}
		return list;
	}

	protected abstract string CMDKIHPAGPL();

	protected abstract object[] BMKKJMIKDPO(T LLIEHCKNJEM);

	protected abstract string MCPNNIHODDL();

	protected virtual string[] JEOIMDLGKLD()
	{
		return null;
	}

	protected abstract Dictionary<string, object> FHIBIOKHLNE(T LLIEHCKNJEM);

	protected abstract T EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH);
}
