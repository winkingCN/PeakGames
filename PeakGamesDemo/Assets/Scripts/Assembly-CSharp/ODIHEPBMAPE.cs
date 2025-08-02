using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ODIHEPBMAPE
{
	[CompilerGenerated]
	private sealed class FHFOHOHIFNO
	{
		internal bool DLGDEOFEKDO;

		internal char AGFNGEFDHLA(char FMFABAKPMLB)
		{
			return (!char.IsControl(FMFABAKPMLB) && (FMFABAKPMLB != '\\' || DLGDEOFEKDO)) ? FMFABAKPMLB : ' ';
		}
	}

	[CompilerGenerated]
	private static Func<char, bool> EBCOMJBLIPP;

	public static string KAKEHGGBOBK(string JKHLMLIANAI)
	{
		int length = JKHLMLIANAI.Length;
		char[] array = new char[length];
		for (int i = 0; i < length; i++)
		{
			array[length - 1 - i] = JKHLMLIANAI[i];
		}
		return new string(array);
	}

	public static string HEIIAPJHGOF(string FCJBBPHFNPJ, bool DLGDEOFEKDO = false)
	{
		if (string.IsNullOrEmpty(FCJBBPHFNPJ))
		{
			return FCJBBPHFNPJ;
		}
		return new string(FCJBBPHFNPJ.Select((char FMFABAKPMLB) => (!char.IsControl(FMFABAKPMLB) && (FMFABAKPMLB != '\\' || DLGDEOFEKDO)) ? FMFABAKPMLB : ' ').ToArray());
	}

	public static string KPGFEPAPBHJ(string BBIEJBIHPLE, int DOPDNKDIGEI)
	{
		if (DOPDNKDIGEI <= 0 || BBIEJBIHPLE.Length < DOPDNKDIGEI)
		{
			return BBIEJBIHPLE;
		}
		char[] array = BBIEJBIHPLE.ToCharArray();
		bool flag = true;
		bool flag2 = false;
		int i = 0;
		int num = 0;
		for (; i < array.Length; i++)
		{
			if (flag)
			{
				num++;
				if (array[i] == '\n')
				{
					num = 0;
				}
				if (num >= DOPDNKDIGEI && char.IsWhiteSpace(array[i]))
				{
					array[i] = '\n';
					flag = false;
					flag2 = false;
				}
			}
			else if (!char.IsWhiteSpace(array[i]))
			{
				flag = true;
				num = 0;
			}
			else if (array[i] != '\n')
			{
				array[i] = '\0';
			}
			else
			{
				if (!flag2)
				{
					array[i] = '\0';
				}
				flag2 = true;
			}
		}
		return new string(array.Where((char FMFABAKPMLB) => FMFABAKPMLB != '\0').ToArray());
	}

	public static bool MEILPENBFOJ(string BBIEJBIHPLE, int ILKCPLDOEFA, out int PHEGOMMPNIL, out int LMGNPKFHNAO)
	{
		PHEGOMMPNIL = -1;
		LMGNPKFHNAO = -1;
		int length = BBIEJBIHPLE.Length;
		PHEGOMMPNIL = ILKCPLDOEFA;
		while (PHEGOMMPNIL < length && BBIEJBIHPLE[PHEGOMMPNIL] != '[' && BBIEJBIHPLE[PHEGOMMPNIL] != '(' && BBIEJBIHPLE[PHEGOMMPNIL] != '{')
		{
			PHEGOMMPNIL++;
		}
		if (PHEGOMMPNIL == length)
		{
			return false;
		}
		bool flag = false;
		for (LMGNPKFHNAO = PHEGOMMPNIL + 1; LMGNPKFHNAO < length; LMGNPKFHNAO++)
		{
			char c = BBIEJBIHPLE[LMGNPKFHNAO];
			if (c == ']' || c == ')' || c == '}')
			{
				if (flag)
				{
					return MEILPENBFOJ(BBIEJBIHPLE, LMGNPKFHNAO + 1, out PHEGOMMPNIL, out LMGNPKFHNAO);
				}
				return true;
			}
			if (c > 'ÿ')
			{
				flag = true;
			}
		}
		return false;
	}

	public static bool MIGINPHAHND()
	{
		if (Application.isPlaying)
		{
			return true;
		}
		return false;
	}

	public static string BGCJPEAMBIP(this Transform PBMDKDICLJP)
	{
		Transform parent = PBMDKDICLJP.parent;
		if (PBMDKDICLJP == null)
		{
			return PBMDKDICLJP.name;
		}
		return parent.BGCJPEAMBIP() + "/" + PBMDKDICLJP.name;
	}

	public static Transform JOCPCBOPDAD(string LIJOMDJHBFI)
	{
		return JOCPCBOPDAD(SceneManager.GetActiveScene(), LIJOMDJHBFI);
	}

	public static Transform JOCPCBOPDAD(Scene HPLOBNMLMMP, string LIJOMDJHBFI)
	{
		GameObject[] rootGameObjects = HPLOBNMLMMP.GetRootGameObjects();
		for (int i = 0; i < rootGameObjects.Length; i++)
		{
			Transform transform = rootGameObjects[i].transform;
			if (transform.name == LIJOMDJHBFI)
			{
				return transform;
			}
			if (LIJOMDJHBFI.StartsWith(transform.name + "/"))
			{
				return JOCPCBOPDAD(transform, LIJOMDJHBFI.Substring(transform.name.Length + 1));
			}
		}
		return null;
	}

	public static Transform JOCPCBOPDAD(Transform AFCMDCDBMIB, string LIJOMDJHBFI)
	{
		foreach (Transform item in AFCMDCDBMIB)
		{
			if (item.name == LIJOMDJHBFI)
			{
				return item;
			}
			if (!LIJOMDJHBFI.StartsWith(item.name + "/"))
			{
				continue;
			}
			return JOCPCBOPDAD(item, LIJOMDJHBFI.Substring(item.name.Length + 1));
		}
		return null;
	}

	[CompilerGenerated]
	private static bool MEJNHPMJJBI(char FMFABAKPMLB)
	{
		return FMFABAKPMLB != '\0';
	}
}
