using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

public class IHDGPBGOHBP
{
	[CompilerGenerated]
	private sealed class FJCHEMFBECG<T>
	{
		internal global::LGAAONEBINM<T> IABKGDCLFAF;

		internal void AGFNGEFDHLA(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			IABKGDCLFAF((T)NEMEKIOEOLC, GHLABECMBPB);
		}
	}

	[CompilerGenerated]
	private sealed class BOMLDJDHHOG<TJson, TValue>
	{
		internal global::PEDFKAFDMHJ<TJson, TValue> JCFOMLGJIJL;

		internal object AGFNGEFDHLA(object MOPCLEEGDFB)
		{
			return JCFOMLGJIJL((TJson)MOPCLEEGDFB);
		}
	}

	private static int NMFGAINCCKK;

	private static IFormatProvider BGMNIMEBGJI;

	private static IDictionary<Type, KNOJFBJGMEA> IMLAFDFOGED;

	private static IDictionary<Type, KNOJFBJGMEA> JPHDNGPOJCD;

	private static IDictionary<Type, IDictionary<Type, MIHGHGCEPEC>> IEJAICIGECH;

	private static IDictionary<Type, IDictionary<Type, MIHGHGCEPEC>> CFAHFNMCIKL;

	private static IDictionary<Type, FODCGFENBAN> GDPMEGLLIKH;

	private static readonly object NOJFPGDNDLL;

	private static IDictionary<Type, IDictionary<Type, MethodInfo>> BOCKMAHGOOK;

	private static readonly object EOMDDFHFBKD;

	private static IDictionary<Type, CFCGDGPMACM> HKMAIPKDLJM;

	private static readonly object MFFPPECKNEP;

	private static IDictionary<Type, IList<MKCHFHLBFOM>> AMNLBCPGLGO;

	private static readonly object KKIHNHOICEL;

	private static JGHOOMMOCFJ DPLBIANEIAF;

	private static readonly object MGAFNPBCGHE;

	[CompilerGenerated]
	private static CLPHNHCLHHP EBCOMJBLIPP;

	[CompilerGenerated]
	private static KNOJFBJGMEA DNBOPLHGMHA;

	[CompilerGenerated]
	private static KNOJFBJGMEA JFHCKLHBBDI;

	[CompilerGenerated]
	private static KNOJFBJGMEA NOGHOEBDKAH;

	[CompilerGenerated]
	private static KNOJFBJGMEA OLIGILDNADD;

	[CompilerGenerated]
	private static KNOJFBJGMEA LJFDFKAJMJJ;

	[CompilerGenerated]
	private static KNOJFBJGMEA LCENBPDKFMA;

	[CompilerGenerated]
	private static KNOJFBJGMEA HCKDPEOEIKP;

	[CompilerGenerated]
	private static KNOJFBJGMEA PNMOOFJNCBC;

	[CompilerGenerated]
	private static KNOJFBJGMEA EMNCDKLDFEL;

	[CompilerGenerated]
	private static MIHGHGCEPEC MHFBJKHLAJJ;

	[CompilerGenerated]
	private static MIHGHGCEPEC LJCMDEPFBKH;

	[CompilerGenerated]
	private static MIHGHGCEPEC HBABPBEAEFJ;

	[CompilerGenerated]
	private static MIHGHGCEPEC FEJAFEEJMEJ;

	[CompilerGenerated]
	private static MIHGHGCEPEC CLECOHENMKD;

	[CompilerGenerated]
	private static MIHGHGCEPEC KBFCIFIJJOA;

	[CompilerGenerated]
	private static MIHGHGCEPEC AEPOEEHFFCN;

	[CompilerGenerated]
	private static MIHGHGCEPEC KAMAEMAHIGF;

	[CompilerGenerated]
	private static MIHGHGCEPEC KCLDNDHLLMF;

	[CompilerGenerated]
	private static MIHGHGCEPEC FHMDOKICKMC;

	[CompilerGenerated]
	private static MIHGHGCEPEC DFOGKDNLOKB;

	[CompilerGenerated]
	private static MIHGHGCEPEC IBIGIGOIAAG;

	[CompilerGenerated]
	private static CLPHNHCLHHP PBEHFLDOPFG;

	[CompilerGenerated]
	private static CLPHNHCLHHP AHGKLMHBKFC;

	[CompilerGenerated]
	private static CLPHNHCLHHP KJIIAHLLKHE;

	static IHDGPBGOHBP()
	{
		NOJFPGDNDLL = new object();
		EOMDDFHFBKD = new object();
		MFFPPECKNEP = new object();
		KKIHNHOICEL = new object();
		MGAFNPBCGHE = new object();
		NMFGAINCCKK = 100;
		GDPMEGLLIKH = new Dictionary<Type, FODCGFENBAN>();
		BOCKMAHGOOK = new Dictionary<Type, IDictionary<Type, MethodInfo>>();
		HKMAIPKDLJM = new Dictionary<Type, CFCGDGPMACM>();
		AMNLBCPGLGO = new Dictionary<Type, IList<MKCHFHLBFOM>>();
		DPLBIANEIAF = new JGHOOMMOCFJ();
		BGMNIMEBGJI = DateTimeFormatInfo.InvariantInfo;
		IMLAFDFOGED = new Dictionary<Type, KNOJFBJGMEA>();
		JPHDNGPOJCD = new Dictionary<Type, KNOJFBJGMEA>();
		IEJAICIGECH = new Dictionary<Type, IDictionary<Type, MIHGHGCEPEC>>();
		CFAHFNMCIKL = new Dictionary<Type, IDictionary<Type, MIHGHGCEPEC>>();
		HAOCFDOCLOP();
		FKABCHKAEFJ();
	}

	private static bool GJGEKCCKEMD(Type NBFBPNNEKMN, string IOCMOCCFALN)
	{
		return NBFBPNNEKMN.GetInterface(IOCMOCCFALN, true) != null;
	}

	public static PropertyInfo[] PLNDMCJEGLM(Type NBFBPNNEKMN)
	{
		return NBFBPNNEKMN.GetProperties();
	}

	private static void OBNFBFOEKDB(Type NBFBPNNEKMN)
	{
		if (GDPMEGLLIKH.ContainsKey(NBFBPNNEKMN))
		{
			return;
		}
		FODCGFENBAN value = default(FODCGFENBAN);
		value.KDHOKBONCAF = NBFBPNNEKMN.IsArray;
		if (GJGEKCCKEMD(NBFBPNNEKMN, "System.Collections.IList"))
		{
			value.GCKGEHAPNEL = true;
		}
		PropertyInfo[] array = PLNDMCJEGLM(NBFBPNNEKMN);
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name != "Item"))
			{
				ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
				if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(int))
				{
					value.PGPNPAFPICI = propertyInfo.PropertyType;
				}
			}
		}
		lock (NOJFPGDNDLL)
		{
			try
			{
				GDPMEGLLIKH.Add(NBFBPNNEKMN, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void MBFGDPPPJMA(Type NBFBPNNEKMN)
	{
		if (HKMAIPKDLJM.ContainsKey(NBFBPNNEKMN))
		{
			return;
		}
		CFCGDGPMACM value = default(CFCGDGPMACM);
		if (GJGEKCCKEMD(NBFBPNNEKMN, "System.Collections.IDictionary"))
		{
			value.MEMLOGOICMC = true;
		}
		value.GBBCHGMFNFH = new Dictionary<string, MKCHFHLBFOM>();
		PropertyInfo[] array = PLNDMCJEGLM(NBFBPNNEKMN);
		foreach (PropertyInfo propertyInfo in array)
		{
			if (propertyInfo.Name == "Item")
			{
				ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
				if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(string))
				{
					value.PGPNPAFPICI = propertyInfo.PropertyType;
				}
			}
			else
			{
				MKCHFHLBFOM value2 = default(MKCHFHLBFOM);
				value2.DFIAILPEFKI = propertyInfo;
				value2.ENBPGGCIADN = propertyInfo.PropertyType;
				value.GBBCHGMFNFH.Add(propertyInfo.Name, value2);
			}
		}
		FieldInfo[] fields = NBFBPNNEKMN.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MKCHFHLBFOM value3 = default(MKCHFHLBFOM);
			value3.DFIAILPEFKI = fieldInfo;
			value3.LFILKKJNPGD = true;
			value3.ENBPGGCIADN = fieldInfo.FieldType;
			value.GBBCHGMFNFH.Add(fieldInfo.Name, value3);
		}
		lock (MFFPPECKNEP)
		{
			try
			{
				HKMAIPKDLJM.Add(NBFBPNNEKMN, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void CPNLLAJCBJB(Type NBFBPNNEKMN)
	{
		if (AMNLBCPGLGO.ContainsKey(NBFBPNNEKMN))
		{
			return;
		}
		IList<MKCHFHLBFOM> list = new List<MKCHFHLBFOM>();
		PropertyInfo[] array = PLNDMCJEGLM(NBFBPNNEKMN);
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Item"))
			{
				MKCHFHLBFOM item = default(MKCHFHLBFOM);
				item.DFIAILPEFKI = propertyInfo;
				item.LFILKKJNPGD = false;
				list.Add(item);
			}
		}
		FieldInfo[] fields = NBFBPNNEKMN.GetFields();
		foreach (FieldInfo dFIAILPEFKI in fields)
		{
			MKCHFHLBFOM item2 = default(MKCHFHLBFOM);
			item2.DFIAILPEFKI = dFIAILPEFKI;
			item2.LFILKKJNPGD = true;
			list.Add(item2);
		}
		lock (KKIHNHOICEL)
		{
			try
			{
				AMNLBCPGLGO.Add(NBFBPNNEKMN, list);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static MethodInfo EGDKOJBIGLC(Type IHLDAKEMHEI, Type KIDLDLOKPEP)
	{
		lock (EOMDDFHFBKD)
		{
			if (!BOCKMAHGOOK.ContainsKey(IHLDAKEMHEI))
			{
				BOCKMAHGOOK.Add(IHLDAKEMHEI, new Dictionary<Type, MethodInfo>());
			}
		}
		if (BOCKMAHGOOK[IHLDAKEMHEI].ContainsKey(KIDLDLOKPEP))
		{
			return BOCKMAHGOOK[IHLDAKEMHEI][KIDLDLOKPEP];
		}
		MethodInfo method = IHLDAKEMHEI.GetMethod("op_Implicit", new Type[1] { KIDLDLOKPEP });
		lock (EOMDDFHFBKD)
		{
			try
			{
				BOCKMAHGOOK[IHLDAKEMHEI].Add(KIDLDLOKPEP, method);
				return method;
			}
			catch (ArgumentException)
			{
				return BOCKMAHGOOK[IHLDAKEMHEI][KIDLDLOKPEP];
			}
		}
	}

	private static object PGMJGDOBNGL(Type ACBPOPCECMB, FEECFKHIBHI JIGJDAHIIBA)
	{
		JIGJDAHIIBA.CELOEBEMCKP();
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayEnd)
		{
			return null;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Null)
		{
			if (!ACBPOPCECMB.IsClass)
			{
				throw new AHFEPEFFHLL(string.Format("Can't assign null to an instance of type {0}", ACBPOPCECMB));
			}
			return null;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Double || JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Int || JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Long || JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.String || JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Boolean)
		{
			Type type = JIGJDAHIIBA.JBGOANMLBFA.GetType();
			if (ACBPOPCECMB.IsAssignableFrom(type))
			{
				return JIGJDAHIIBA.JBGOANMLBFA;
			}
			if (CFAHFNMCIKL.ContainsKey(type) && CFAHFNMCIKL[type].ContainsKey(ACBPOPCECMB))
			{
				MIHGHGCEPEC mIHGHGCEPEC = CFAHFNMCIKL[type][ACBPOPCECMB];
				return mIHGHGCEPEC(JIGJDAHIIBA.JBGOANMLBFA);
			}
			if (IEJAICIGECH.ContainsKey(type) && IEJAICIGECH[type].ContainsKey(ACBPOPCECMB))
			{
				MIHGHGCEPEC mIHGHGCEPEC2 = IEJAICIGECH[type][ACBPOPCECMB];
				return mIHGHGCEPEC2(JIGJDAHIIBA.JBGOANMLBFA);
			}
			if (ACBPOPCECMB.IsEnum)
			{
				return Enum.ToObject(ACBPOPCECMB, JIGJDAHIIBA.JBGOANMLBFA);
			}
			MethodInfo methodInfo = EGDKOJBIGLC(ACBPOPCECMB, type);
			if (methodInfo != null)
			{
				return methodInfo.Invoke(null, new object[1] { JIGJDAHIIBA.JBGOANMLBFA });
			}
			throw new AHFEPEFFHLL(string.Format("Can't assign value '{0}' (type {1}) to type {2}", JIGJDAHIIBA.JBGOANMLBFA, type, ACBPOPCECMB));
		}
		object obj = null;
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayStart)
		{
			if (ACBPOPCECMB.FullName == "System.Object")
			{
				ACBPOPCECMB = typeof(object[]);
			}
			OBNFBFOEKDB(ACBPOPCECMB);
			FODCGFENBAN fODCGFENBAN = GDPMEGLLIKH[ACBPOPCECMB];
			if (!fODCGFENBAN.KDHOKBONCAF && !fODCGFENBAN.GCKGEHAPNEL)
			{
				throw new AHFEPEFFHLL(string.Format("Type {0} can't act as an array", ACBPOPCECMB));
			}
			IList list;
			Type type2;
			if (!fODCGFENBAN.KDHOKBONCAF)
			{
				list = (IList)Activator.CreateInstance(ACBPOPCECMB);
				type2 = fODCGFENBAN.PGPNPAFPICI;
			}
			else
			{
				list = new ArrayList();
				type2 = ACBPOPCECMB.GetElementType();
			}
			while (true)
			{
				object obj2 = PGMJGDOBNGL(type2, JIGJDAHIIBA);
				if (obj2 == null && JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayEnd)
				{
					break;
				}
				list.Add(obj2);
			}
			if (fODCGFENBAN.KDHOKBONCAF)
			{
				int count = list.Count;
				obj = Array.CreateInstance(type2, count);
				for (int i = 0; i < count; i++)
				{
					((Array)obj).SetValue(list[i], i);
				}
			}
			else
			{
				obj = list;
			}
		}
		else if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ObjectStart)
		{
			if (ACBPOPCECMB == typeof(object))
			{
				ACBPOPCECMB = typeof(Dictionary<string, object>);
			}
			MBFGDPPPJMA(ACBPOPCECMB);
			CFCGDGPMACM cFCGDGPMACM = HKMAIPKDLJM[ACBPOPCECMB];
			obj = Activator.CreateInstance(ACBPOPCECMB);
			while (true)
			{
				JIGJDAHIIBA.CELOEBEMCKP();
				if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ObjectEnd)
				{
					break;
				}
				string text = (string)JIGJDAHIIBA.JBGOANMLBFA;
				if (cFCGDGPMACM.GBBCHGMFNFH.ContainsKey(text))
				{
					MKCHFHLBFOM mKCHFHLBFOM = cFCGDGPMACM.GBBCHGMFNFH[text];
					if (mKCHFHLBFOM.LFILKKJNPGD)
					{
						((FieldInfo)mKCHFHLBFOM.DFIAILPEFKI).SetValue(obj, PGMJGDOBNGL(mKCHFHLBFOM.ENBPGGCIADN, JIGJDAHIIBA));
						continue;
					}
					PropertyInfo propertyInfo = (PropertyInfo)mKCHFHLBFOM.DFIAILPEFKI;
					if (propertyInfo.CanWrite)
					{
						propertyInfo.SetValue(obj, PGMJGDOBNGL(mKCHFHLBFOM.ENBPGGCIADN, JIGJDAHIIBA), null);
					}
					else
					{
						PGMJGDOBNGL(mKCHFHLBFOM.ENBPGGCIADN, JIGJDAHIIBA);
					}
				}
				else if (!cFCGDGPMACM.MEMLOGOICMC)
				{
					if (!JIGJDAHIIBA.AFMCBFBKMGM)
					{
						throw new AHFEPEFFHLL(string.Format("The type {0} doesn't have the property '{1}'", ACBPOPCECMB, text));
					}
					JGHBDJJFDNG(JIGJDAHIIBA);
				}
				else
				{
					((IDictionary)obj).Add(text, PGMJGDOBNGL(cFCGDGPMACM.PGPNPAFPICI, JIGJDAHIIBA));
				}
			}
		}
		return obj;
	}

	private static GFIEDFFPKHM PGMJGDOBNGL(CLPHNHCLHHP BOEBAMFLHBM, FEECFKHIBHI JIGJDAHIIBA)
	{
		JIGJDAHIIBA.CELOEBEMCKP();
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayEnd || JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Null)
		{
			return null;
		}
		GFIEDFFPKHM gFIEDFFPKHM = BOEBAMFLHBM();
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.String)
		{
			gFIEDFFPKHM.HPLEOGFJKHP((string)JIGJDAHIIBA.JBGOANMLBFA);
			return gFIEDFFPKHM;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Double)
		{
			gFIEDFFPKHM.MLAJMIDBPEN((double)JIGJDAHIIBA.JBGOANMLBFA);
			return gFIEDFFPKHM;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Int)
		{
			gFIEDFFPKHM.ONDIBFPKMMI((int)JIGJDAHIIBA.JBGOANMLBFA);
			return gFIEDFFPKHM;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Long)
		{
			gFIEDFFPKHM.ABADIOPNMFD((long)JIGJDAHIIBA.JBGOANMLBFA);
			return gFIEDFFPKHM;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.Boolean)
		{
			gFIEDFFPKHM.CPIICKIHJDK((bool)JIGJDAHIIBA.JBGOANMLBFA);
			return gFIEDFFPKHM;
		}
		if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayStart)
		{
			gFIEDFFPKHM.GAEOAEEMOOE(IOIMIGDIAFB.Array);
			while (true)
			{
				GFIEDFFPKHM gFIEDFFPKHM2 = PGMJGDOBNGL(BOEBAMFLHBM, JIGJDAHIIBA);
				if (gFIEDFFPKHM2 == null && JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ArrayEnd)
				{
					break;
				}
				gFIEDFFPKHM.Add(gFIEDFFPKHM2);
			}
		}
		else if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ObjectStart)
		{
			gFIEDFFPKHM.GAEOAEEMOOE(IOIMIGDIAFB.Object);
			while (true)
			{
				JIGJDAHIIBA.CELOEBEMCKP();
				if (JIGJDAHIIBA.FIPPLABNDON == GPDLLCPCBAP.ObjectEnd)
				{
					break;
				}
				string key = (string)JIGJDAHIIBA.JBGOANMLBFA;
				gFIEDFFPKHM[key] = PGMJGDOBNGL(BOEBAMFLHBM, JIGJDAHIIBA);
			}
		}
		return gFIEDFFPKHM;
	}

	private static void JGHBDJJFDNG(FEECFKHIBHI JIGJDAHIIBA)
	{
		CAECJHEHFLO(() => new MPNCDJIIAMI(), JIGJDAHIIBA);
	}

	private static void HAOCFDOCLOP()
	{
		IMLAFDFOGED[typeof(byte)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((byte)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(char)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToString((char)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(DateTime)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToString((DateTime)NEMEKIOEOLC, BGMNIMEBGJI));
		};
		IMLAFDFOGED[typeof(decimal)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN((decimal)NEMEKIOEOLC);
		};
		IMLAFDFOGED[typeof(sbyte)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((sbyte)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(short)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((short)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(ushort)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((ushort)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(uint)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN(Convert.ToUInt64((uint)NEMEKIOEOLC));
		};
		IMLAFDFOGED[typeof(ulong)] = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			GHLABECMBPB.KBMOJGCCCEN((ulong)NEMEKIOEOLC);
		};
	}

	private static void FKABCHKAEFJ()
	{
		MIHGHGCEPEC jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToByte((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(byte), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToUInt64((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(ulong), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToSByte((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(sbyte), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToInt16((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(short), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToUInt16((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(ushort), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToUInt32((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(uint), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToSingle((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(float), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToDouble((int)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(int), typeof(double), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToDecimal((double)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(double), typeof(decimal), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToUInt32((long)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(long), typeof(uint), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToChar((string)MOPCLEEGDFB);
		EPJEHMDJOCA(IEJAICIGECH, typeof(string), typeof(char), jCFOMLGJIJL);
		jCFOMLGJIJL = (object MOPCLEEGDFB) => Convert.ToDateTime((string)MOPCLEEGDFB, BGMNIMEBGJI);
		EPJEHMDJOCA(IEJAICIGECH, typeof(string), typeof(DateTime), jCFOMLGJIJL);
	}

	private static void EPJEHMDJOCA(IDictionary<Type, IDictionary<Type, MIHGHGCEPEC>> AEPNIOFMGPL, Type GEPIMGIDCKO, Type EMOOBMNNMAA, MIHGHGCEPEC JCFOMLGJIJL)
	{
		if (!AEPNIOFMGPL.ContainsKey(GEPIMGIDCKO))
		{
			AEPNIOFMGPL.Add(GEPIMGIDCKO, new Dictionary<Type, MIHGHGCEPEC>());
		}
		AEPNIOFMGPL[GEPIMGIDCKO][EMOOBMNNMAA] = JCFOMLGJIJL;
	}

	private static void FIMIAMGJADB(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB, bool JAFIJMCJGHP, int BGLFLIOOKMO)
	{
		if (BGLFLIOOKMO > NMFGAINCCKK)
		{
			throw new AHFEPEFFHLL(string.Format("Max allowed object depth reached while trying to export from type {0}", NEMEKIOEOLC.GetType()));
		}
		if (NEMEKIOEOLC == null)
		{
			GHLABECMBPB.KBMOJGCCCEN(null);
			return;
		}
		if (NEMEKIOEOLC is GFIEDFFPKHM)
		{
			if (JAFIJMCJGHP)
			{
				GHLABECMBPB.LBONILKOFMB.Write(((GFIEDFFPKHM)NEMEKIOEOLC).PDBENFDNJAI());
			}
			else
			{
				((GFIEDFFPKHM)NEMEKIOEOLC).PDBENFDNJAI(GHLABECMBPB);
			}
			return;
		}
		if (NEMEKIOEOLC is string)
		{
			GHLABECMBPB.KBMOJGCCCEN((string)NEMEKIOEOLC);
			return;
		}
		if (NEMEKIOEOLC is double)
		{
			GHLABECMBPB.KBMOJGCCCEN((double)NEMEKIOEOLC);
			return;
		}
		if (NEMEKIOEOLC is int)
		{
			GHLABECMBPB.KBMOJGCCCEN((int)NEMEKIOEOLC);
			return;
		}
		if (NEMEKIOEOLC is bool)
		{
			GHLABECMBPB.KBMOJGCCCEN((bool)NEMEKIOEOLC);
			return;
		}
		if (NEMEKIOEOLC is long)
		{
			GHLABECMBPB.KBMOJGCCCEN((long)NEMEKIOEOLC);
			return;
		}
		if (NEMEKIOEOLC is Array)
		{
			GHLABECMBPB.AMOOKGONCNL();
			foreach (object item in (Array)NEMEKIOEOLC)
			{
				FIMIAMGJADB(item, GHLABECMBPB, JAFIJMCJGHP, BGLFLIOOKMO + 1);
			}
			GHLABECMBPB.KDKCHLBKEEN();
			return;
		}
		if (NEMEKIOEOLC is IList)
		{
			GHLABECMBPB.AMOOKGONCNL();
			foreach (object item2 in (IList)NEMEKIOEOLC)
			{
				FIMIAMGJADB(item2, GHLABECMBPB, JAFIJMCJGHP, BGLFLIOOKMO + 1);
			}
			GHLABECMBPB.KDKCHLBKEEN();
			return;
		}
		if (NEMEKIOEOLC is IDictionary)
		{
			GHLABECMBPB.IGJCBGHOCAK();
			foreach (DictionaryEntry item3 in (IDictionary)NEMEKIOEOLC)
			{
				GHLABECMBPB.LDEPLFIBHOF((string)item3.Key);
				FIMIAMGJADB(item3.Value, GHLABECMBPB, JAFIJMCJGHP, BGLFLIOOKMO + 1);
			}
			GHLABECMBPB.MLHNFLBDEDL();
			return;
		}
		Type type = NEMEKIOEOLC.GetType();
		if (JPHDNGPOJCD.ContainsKey(type))
		{
			KNOJFBJGMEA kNOJFBJGMEA = JPHDNGPOJCD[type];
			kNOJFBJGMEA(NEMEKIOEOLC, GHLABECMBPB);
			return;
		}
		if (IMLAFDFOGED.ContainsKey(type))
		{
			KNOJFBJGMEA kNOJFBJGMEA2 = IMLAFDFOGED[type];
			kNOJFBJGMEA2(NEMEKIOEOLC, GHLABECMBPB);
			return;
		}
		if (NEMEKIOEOLC is Enum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type);
			if (underlyingType == typeof(long) || underlyingType == typeof(uint) || underlyingType == typeof(ulong))
			{
				GHLABECMBPB.KBMOJGCCCEN((ulong)NEMEKIOEOLC);
			}
			else
			{
				GHLABECMBPB.KBMOJGCCCEN((int)NEMEKIOEOLC);
			}
			return;
		}
		CPNLLAJCBJB(type);
		IList<MKCHFHLBFOM> list = AMNLBCPGLGO[type];
		GHLABECMBPB.IGJCBGHOCAK();
		foreach (MKCHFHLBFOM item4 in list)
		{
			if (item4.LFILKKJNPGD)
			{
				GHLABECMBPB.LDEPLFIBHOF(item4.DFIAILPEFKI.Name);
				FIMIAMGJADB(((FieldInfo)item4.DFIAILPEFKI).GetValue(NEMEKIOEOLC), GHLABECMBPB, JAFIJMCJGHP, BGLFLIOOKMO + 1);
				continue;
			}
			PropertyInfo propertyInfo = (PropertyInfo)item4.DFIAILPEFKI;
			if (propertyInfo.CanRead)
			{
				GHLABECMBPB.LDEPLFIBHOF(item4.DFIAILPEFKI.Name);
				FIMIAMGJADB(propertyInfo.GetValue(NEMEKIOEOLC, null), GHLABECMBPB, JAFIJMCJGHP, BGLFLIOOKMO + 1);
			}
		}
		GHLABECMBPB.MLHNFLBDEDL();
	}

	public static string PDBENFDNJAI(object NEMEKIOEOLC)
	{
		lock (MGAFNPBCGHE)
		{
			DPLBIANEIAF.OMOKOKFNBKI();
			FIMIAMGJADB(NEMEKIOEOLC, DPLBIANEIAF, true, 0);
			return DPLBIANEIAF.ToString();
		}
	}

	public static void PDBENFDNJAI(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		FIMIAMGJADB(NEMEKIOEOLC, GHLABECMBPB, false, 0);
	}

	public static FMHLMKJKDEG DMJOGBEIBNM(FEECFKHIBHI JIGJDAHIIBA)
	{
		return (FMHLMKJKDEG)CAECJHEHFLO(() => new FMHLMKJKDEG(), JIGJDAHIIBA);
	}

	public static FMHLMKJKDEG DMJOGBEIBNM(TextReader JIGJDAHIIBA)
	{
		FEECFKHIBHI jIGJDAHIIBA = new FEECFKHIBHI(JIGJDAHIIBA);
		return (FMHLMKJKDEG)CAECJHEHFLO(() => new FMHLMKJKDEG(), jIGJDAHIIBA);
	}

	public static FMHLMKJKDEG DMJOGBEIBNM(string BIPAJFCNEOB)
	{
		return (FMHLMKJKDEG)CAECJHEHFLO(() => new FMHLMKJKDEG(), BIPAJFCNEOB);
	}

	public static T DMJOGBEIBNM<T>(FEECFKHIBHI JIGJDAHIIBA)
	{
		return (T)PGMJGDOBNGL(typeof(T), JIGJDAHIIBA);
	}

	public static T DMJOGBEIBNM<T>(TextReader JIGJDAHIIBA)
	{
		FEECFKHIBHI jIGJDAHIIBA = new FEECFKHIBHI(JIGJDAHIIBA);
		return (T)PGMJGDOBNGL(typeof(T), jIGJDAHIIBA);
	}

	public static T DMJOGBEIBNM<T>(string BIPAJFCNEOB)
	{
		FEECFKHIBHI jIGJDAHIIBA = new FEECFKHIBHI(BIPAJFCNEOB);
		return (T)PGMJGDOBNGL(typeof(T), jIGJDAHIIBA);
	}

	public static GFIEDFFPKHM CAECJHEHFLO(CLPHNHCLHHP BOEBAMFLHBM, FEECFKHIBHI JIGJDAHIIBA)
	{
		return PGMJGDOBNGL(BOEBAMFLHBM, JIGJDAHIIBA);
	}

	public static GFIEDFFPKHM CAECJHEHFLO(CLPHNHCLHHP BOEBAMFLHBM, string BIPAJFCNEOB)
	{
		FEECFKHIBHI jIGJDAHIIBA = new FEECFKHIBHI(BIPAJFCNEOB);
		return PGMJGDOBNGL(BOEBAMFLHBM, jIGJDAHIIBA);
	}

	public static void JCOMLBJGPLK<T>(global::LGAAONEBINM<T> IABKGDCLFAF)
	{
		KNOJFBJGMEA value = delegate(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
		{
			IABKGDCLFAF((T)NEMEKIOEOLC, GHLABECMBPB);
		};
		JPHDNGPOJCD[typeof(T)] = value;
	}

	public static void EPJEHMDJOCA<TJson, TValue>(global::PEDFKAFDMHJ<TJson, TValue> JCFOMLGJIJL)
	{
		MIHGHGCEPEC jCFOMLGJIJL = (object MOPCLEEGDFB) => JCFOMLGJIJL((TJson)MOPCLEEGDFB);
		EPJEHMDJOCA(CFAHFNMCIKL, typeof(TJson), typeof(TValue), jCFOMLGJIJL);
	}

	public static void DGBPADOPDOF()
	{
		JPHDNGPOJCD.Clear();
	}

	public static void OBPHNMCBHGL()
	{
		CFAHFNMCIKL.Clear();
	}

	[CompilerGenerated]
	private static GFIEDFFPKHM KBDFLLHPKPO()
	{
		return new MPNCDJIIAMI();
	}

	[CompilerGenerated]
	private static void CGMINOPFJPD(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((byte)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void KOJCJDOOMIE(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToString((char)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void CJAFGOIDCOD(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToString((DateTime)NEMEKIOEOLC, BGMNIMEBGJI));
	}

	[CompilerGenerated]
	private static void KHKHKCKHBDL(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN((decimal)NEMEKIOEOLC);
	}

	[CompilerGenerated]
	private static void NNBOIEOBIFJ(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((sbyte)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void IALNMCFFDEJ(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((short)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void MAKCPJDMLJM(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToInt32((ushort)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void NIDGGNJHIPA(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN(Convert.ToUInt64((uint)NEMEKIOEOLC));
	}

	[CompilerGenerated]
	private static void PIJOAKBLPCM(object NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		GHLABECMBPB.KBMOJGCCCEN((ulong)NEMEKIOEOLC);
	}

	[CompilerGenerated]
	private static object OFLBMKKJAOE(object MOPCLEEGDFB)
	{
		return Convert.ToByte((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object MFBKCEHKIFI(object MOPCLEEGDFB)
	{
		return Convert.ToUInt64((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object MFGIKKDMOJO(object MOPCLEEGDFB)
	{
		return Convert.ToSByte((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object JJOPBOOBLLG(object MOPCLEEGDFB)
	{
		return Convert.ToInt16((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object MOEGPDIGPGB(object MOPCLEEGDFB)
	{
		return Convert.ToUInt16((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object DDDNNCDCIEG(object MOPCLEEGDFB)
	{
		return Convert.ToUInt32((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object KIIGONMNHPA(object MOPCLEEGDFB)
	{
		return Convert.ToSingle((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object PHILCNDIALG(object MOPCLEEGDFB)
	{
		return Convert.ToDouble((int)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object IBBDLMFLPAG(object MOPCLEEGDFB)
	{
		return Convert.ToDecimal((double)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object BPLCPLIIHML(object MOPCLEEGDFB)
	{
		return Convert.ToUInt32((long)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object EMNAJDCAFOG(object MOPCLEEGDFB)
	{
		return Convert.ToChar((string)MOPCLEEGDFB);
	}

	[CompilerGenerated]
	private static object CGDOPNGMLEN(object MOPCLEEGDFB)
	{
		return Convert.ToDateTime((string)MOPCLEEGDFB, BGMNIMEBGJI);
	}

	[CompilerGenerated]
	private static GFIEDFFPKHM IBFJCJGMMED()
	{
		return new FMHLMKJKDEG();
	}

	[CompilerGenerated]
	private static GFIEDFFPKHM GHDHMFPJLEL()
	{
		return new FMHLMKJKDEG();
	}

	[CompilerGenerated]
	private static GFIEDFFPKHM EAMGFCIAFMB()
	{
		return new FMHLMKJKDEG();
	}
}
