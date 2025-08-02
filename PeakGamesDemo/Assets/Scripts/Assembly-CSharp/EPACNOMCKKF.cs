using System;
using System.Reflection;
using UnityEngine;

public class EPACNOMCKKF
{
	private static readonly PLNEBHAJOJP LJBDGPIHDIC;

	static EPACNOMCKKF()
	{
		LJBDGPIHDIC = PLNEBHAJOJP.PGEHJDFMKII();
	}

	public static void JPLFFCHJICB()
	{
		string text = LJBDGPIHDIC.JPLFFCHJICB();
		if (!string.IsNullOrEmpty(text))
		{
			string[] array = text.Split(',');
			string[] array2 = array;
			foreach (string dCCDPILJIPI in array2)
			{
				JPLFFCHJICB(dCCDPILJIPI);
			}
		}
	}

	internal static void JPLFFCHJICB(string DCCDPILJIPI)
	{
		int num = DCCDPILJIPI.LastIndexOf('.');
		string typeName = DCCDPILJIPI.Substring(0, num);
		string name = DCCDPILJIPI.Substring(num + 1);
		Type type = Type.GetType(typeName);
		if (type == null)
		{
			return;
		}
		MethodInfo method = type.GetMethod(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (method != null)
		{
			object obj = ((!typeof(ScriptableObject).IsAssignableFrom(type)) ? Activator.CreateInstance(type) : ScriptableObject.CreateInstance(type));
			if (obj != null)
			{
				method.Invoke(obj, new object[0]);
			}
		}
	}
}
