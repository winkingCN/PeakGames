using System;
using System.Collections.Generic;
using UnityEngine;

internal class LNEGKOGBOAG
{
	public AndroidJavaObject JBOBAGEOMFC;

	public LNEGKOGBOAG(string DCELGKOIMPK, Dictionary<string, object> LGOLOOGGKNC, params string[] MIDCNFGAIFA)
	{
		JBOBAGEOMFC = new AndroidJavaObject(string.Format("com.crashlytics.android.answers.{0}", DCELGKOIMPK), MIDCNFGAIFA);
		foreach (KeyValuePair<string, object> item in LGOLOOGGKNC)
		{
			string key = item.Key;
			object value = item.Value;
			if (value == null)
			{
				Debug.Log(string.Format("[Answers] Expected custom attribute value to be non-null. Received: {0}", value));
			}
			else if (BEIFHIJKJDL(value))
			{
				JBOBAGEOMFC.Call<AndroidJavaObject>("putCustomAttribute", new object[2]
				{
					key,
					PMICJHNDLKP(value)
				});
			}
			else if (value is string)
			{
				JBOBAGEOMFC.Call<AndroidJavaObject>("putCustomAttribute", new object[2] { key, value });
			}
			else
			{
				Debug.Log(string.Format("[Answers] Expected custom attribute value to be a string or numeric. Received: {0}", value));
			}
		}
	}

	public void HLDIJPHLNAN(string ELKHFBGEJLK)
	{
		HGIPBGKODCN("putMethod", ELKHFBGEJLK);
	}

	public void CJLFDOPNCOP(bool? EEKJMDHEJCK)
	{
		DOLHKDIHMJD("putSuccess", EEKJMDHEJCK);
	}

	public void JANHFNFEDIL(string BJPPGCGDMLD)
	{
		HGIPBGKODCN("putContentName", BJPPGCGDMLD);
	}

	public void ADHINDEJJDH(string JAFLHIJPFKD)
	{
		HGIPBGKODCN("putContentType", JAFLHIJPFKD);
	}

	public void JKMGLGCGCOC(string IFACNDLFIOI)
	{
		HGIPBGKODCN("putContentId", IFACNDLFIOI);
	}

	public void MJCBNFAHAKH(string FMGPCBJLMDF)
	{
		MCLFPBHECPG("putCurrency", FMGPCBJLMDF);
	}

	public void MCLFPBHECPG(string GDMGHPJHPEH, string FMGPCBJLMDF)
	{
		if (FMGPCBJLMDF != null)
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("java.util.Currency");
			AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[1] { FMGPCBJLMDF });
			JBOBAGEOMFC.Call<AndroidJavaObject>("putCurrency", new object[1] { androidJavaObject });
		}
	}

	public void DOLHKDIHMJD(string GDMGHPJHPEH, bool? GAAJMMMHJIC)
	{
		if (GAAJMMMHJIC.HasValue)
		{
			JBOBAGEOMFC.Call<AndroidJavaObject>(GDMGHPJHPEH, new object[1] { GAAJMMMHJIC });
		}
	}

	public void MADFOJNOAHF(string GDMGHPJHPEH, int? GAAJMMMHJIC)
	{
		if (GAAJMMMHJIC.HasValue)
		{
			JBOBAGEOMFC.Call<AndroidJavaObject>(GDMGHPJHPEH, new object[1] { GAAJMMMHJIC });
		}
	}

	public void HGIPBGKODCN(string GDMGHPJHPEH, string GAAJMMMHJIC)
	{
		if (GAAJMMMHJIC != null)
		{
			JBOBAGEOMFC.Call<AndroidJavaObject>(GDMGHPJHPEH, new object[1] { GAAJMMMHJIC });
		}
	}

	public void OMAKCDLPNLA(string GDMGHPJHPEH, object GAAJMMMHJIC)
	{
		if (GAAJMMMHJIC != null)
		{
			JBOBAGEOMFC.Call<AndroidJavaObject>(GDMGHPJHPEH, new object[1]
			{
				new AndroidJavaObject("java.math.BigDecimal", GAAJMMMHJIC.ToString())
			});
		}
	}

	public void MPHHHLHKOIJ(string GDMGHPJHPEH, object GAAJMMMHJIC)
	{
		if (GAAJMMMHJIC != null)
		{
			JBOBAGEOMFC.Call<AndroidJavaObject>(GDMGHPJHPEH, new object[1] { PMICJHNDLKP(GAAJMMMHJIC) });
		}
	}

	private static bool BEIFHIJKJDL(object AACCPLMFDIE)
	{
		switch (Type.GetTypeCode(AACCPLMFDIE.GetType()))
		{
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
		case TypeCode.Decimal:
			return true;
		default:
			return false;
		}
	}

	private static AndroidJavaObject PMICJHNDLKP(object BOFHHECPKNF)
	{
		return new AndroidJavaObject("java.lang.Double", BOFHHECPKNF.ToString());
	}
}
