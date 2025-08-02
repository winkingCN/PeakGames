using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class DPKJGBCDECA
{
	public virtual DPKJGBCDECA AHANCLBKKID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual DPKJGBCDECA AHANCLBKKID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string JBGOANMLBFA
	{
		get
		{
			return string.Empty;
		}
		set
		{
		}
	}

	public virtual int GMCGMPEEHJP
	{
		get
		{
			return 0;
		}
	}

	public virtual IEnumerable<DPKJGBCDECA> JHEDPFKFFJB
	{
		get
		{
			yield break;
		}
	}

	public IEnumerable<DPKJGBCDECA> KOMIFDPBDNB
	{
		get
		{
			foreach (DPKJGBCDECA item in JHEDPFKFFJB)
			{
				foreach (DPKJGBCDECA item2 in item.KOMIFDPBDNB)
				{
					yield return item2;
				}
			}
		}
	}

	public virtual int JJNCOPEDMJA
	{
		get
		{
			int result = 0;
			if (int.TryParse(JBGOANMLBFA, out result))
			{
				return result;
			}
			return 0;
		}
		set
		{
			JBGOANMLBFA = value.ToString();
		}
	}

	public virtual float JJAOJGHMNED
	{
		get
		{
			float result = 0f;
			if (float.TryParse(JBGOANMLBFA, out result))
			{
				return result;
			}
			return 0f;
		}
		set
		{
			JBGOANMLBFA = value.ToString();
		}
	}

	public virtual double PMICJHNDLKP
	{
		get
		{
			double result = 0.0;
			if (double.TryParse(JBGOANMLBFA, out result))
			{
				return result;
			}
			return 0.0;
		}
		set
		{
			JBGOANMLBFA = value.ToString();
		}
	}

	public virtual bool OLICILPDIGA
	{
		get
		{
			bool result = false;
			if (bool.TryParse(JBGOANMLBFA, out result))
			{
				return result;
			}
			return !string.IsNullOrEmpty(JBGOANMLBFA);
		}
		set
		{
			JBGOANMLBFA = ((!value) ? "false" : "true");
		}
	}

	public virtual OMOOJCDPFEL NLOOFFLFPPE
	{
		get
		{
			return this as OMOOJCDPFEL;
		}
	}

	public virtual ICCEIIKBABF JPIHKOGIKHA
	{
		get
		{
			return this as ICCEIIKBABF;
		}
	}

	public virtual void JEACJNAKLDJ(string OMGPFPGELOM, DPKJGBCDECA GFADEOLDFDI)
	{
	}

	public virtual void JEACJNAKLDJ(DPKJGBCDECA GFADEOLDFDI)
	{
		JEACJNAKLDJ(string.Empty, GFADEOLDFDI);
	}

	public virtual DPKJGBCDECA CJOHLENDJGO(string OMGPFPGELOM)
	{
		return null;
	}

	public virtual DPKJGBCDECA CJOHLENDJGO(int LHOJEJCFKCN)
	{
		return null;
	}

	public virtual DPKJGBCDECA CJOHLENDJGO(DPKJGBCDECA LELOKDCLJMD)
	{
		return LELOKDCLJMD;
	}

	public override string ToString()
	{
		return "JSONNode";
	}

	public virtual string NHMGCGBMCNM(string KECKLEJAGKP)
	{
		return "JSONNode";
	}

	[SpecialName]
	public static DPKJGBCDECA AGIIAGNEIKI(string IBBBMACIBGK)
	{
		return new EOMIKBDENCM(IBBBMACIBGK);
	}

	[SpecialName]
	public static string AGIIAGNEIKI(DPKJGBCDECA ELNCCDELMMH)
	{
		return (!OCAFFLHPIMM(ELNCCDELMMH, null)) ? ELNCCDELMMH.JBGOANMLBFA : null;
	}

	[SpecialName]
	public static bool OCAFFLHPIMM(DPKJGBCDECA MNIMEAMHNMI, object BCIHLCMFAEK)
	{
		if (BCIHLCMFAEK == null && MNIMEAMHNMI is CNDAJPPEAPE)
		{
			return true;
		}
		return object.ReferenceEquals(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	[SpecialName]
	public static bool BLPPLFIKFPN(DPKJGBCDECA MNIMEAMHNMI, object BCIHLCMFAEK)
	{
		return !OCAFFLHPIMM(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		return object.ReferenceEquals(this, NEMEKIOEOLC);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	internal static string CDFEDEOOJDC(string JHHODCEBMLD)
	{
		string text = string.Empty;
		foreach (char c in JHHODCEBMLD)
		{
			switch (c)
			{
			case '\\':
				text += "\\\\";
				break;
			case '"':
				text += "\\\"";
				break;
			case '\n':
				text += "\\n";
				break;
			case '\r':
				text += "\\r";
				break;
			case '\t':
				text += "\\t";
				break;
			case '\b':
				text += "\\b";
				break;
			case '\f':
				text += "\\f";
				break;
			default:
				text += c;
				break;
			}
		}
		return text;
	}

	public static DPKJGBCDECA DHCLOMIANOE(string LGMNAIAFHAH)
	{
		Stack<DPKJGBCDECA> stack = new Stack<DPKJGBCDECA>();
		DPKJGBCDECA dPKJGBCDECA = null;
		int i = 0;
		string text = string.Empty;
		string text2 = string.Empty;
		bool flag = false;
		for (; i < LGMNAIAFHAH.Length; i++)
		{
			switch (LGMNAIAFHAH[i])
			{
			case '{':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				stack.Push(new ICCEIIKBABF());
				if (BLPPLFIKFPN(dPKJGBCDECA, null))
				{
					text2 = text2.Trim();
					if (dPKJGBCDECA is OMOOJCDPFEL)
					{
						dPKJGBCDECA.JEACJNAKLDJ(stack.Peek());
					}
					else if (text2 != string.Empty)
					{
						dPKJGBCDECA.JEACJNAKLDJ(text2, stack.Peek());
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				dPKJGBCDECA = stack.Peek();
				break;
			case '[':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				stack.Push(new OMOOJCDPFEL());
				if (BLPPLFIKFPN(dPKJGBCDECA, null))
				{
					text2 = text2.Trim();
					if (dPKJGBCDECA is OMOOJCDPFEL)
					{
						dPKJGBCDECA.JEACJNAKLDJ(stack.Peek());
					}
					else if (text2 != string.Empty)
					{
						dPKJGBCDECA.JEACJNAKLDJ(text2, stack.Peek());
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				dPKJGBCDECA = stack.Peek();
				break;
			case ']':
			case '}':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				if (stack.Count == 0)
				{
					throw new Exception("JSON Parse: Too many closing brackets");
				}
				stack.Pop();
				if (text != string.Empty)
				{
					text2 = text2.Trim();
					if (dPKJGBCDECA is OMOOJCDPFEL)
					{
						dPKJGBCDECA.JEACJNAKLDJ(AGIIAGNEIKI(text));
					}
					else if (text2 != string.Empty)
					{
						dPKJGBCDECA.JEACJNAKLDJ(text2, AGIIAGNEIKI(text));
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				if (stack.Count > 0)
				{
					dPKJGBCDECA = stack.Peek();
				}
				break;
			case ':':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				text2 = text;
				text = string.Empty;
				break;
			case '"':
				flag ^= true;
				break;
			case ',':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				if (text != string.Empty)
				{
					if (dPKJGBCDECA is OMOOJCDPFEL)
					{
						dPKJGBCDECA.JEACJNAKLDJ(AGIIAGNEIKI(text));
					}
					else if (text2 != string.Empty)
					{
						dPKJGBCDECA.JEACJNAKLDJ(text2, AGIIAGNEIKI(text));
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				break;
			case '\t':
			case ' ':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
				}
				break;
			case '\\':
				i++;
				if (flag)
				{
					char c = LGMNAIAFHAH[i];
					switch (c)
					{
					case 't':
						text += '\t';
						break;
					case 'r':
						text += '\r';
						break;
					case 'n':
						text += '\n';
						break;
					case 'b':
						text += '\b';
						break;
					case 'f':
						text += '\f';
						break;
					case 'u':
					{
						string s = LGMNAIAFHAH.Substring(i + 1, 4);
						text += (char)int.Parse(s, NumberStyles.AllowHexSpecifier);
						i += 4;
						break;
					}
					default:
						text += c;
						break;
					}
				}
				break;
			default:
				text += LGMNAIAFHAH[i];
				break;
			case '\n':
			case '\r':
				break;
			}
		}
		if (flag)
		{
			throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
		}
		return dPKJGBCDECA;
	}

	public virtual void LFIJNCAPDMO(BinaryWriter DOLOAHGOLMI)
	{
	}

	public void INGAIONMOKK(Stream LOPFNIFAMGK)
	{
		BinaryWriter dOLOAHGOLMI = new BinaryWriter(LOPFNIFAMGK);
		LFIJNCAPDMO(dOLOAHGOLMI);
	}

	public void PFHMFCMPGGL(Stream LOPFNIFAMGK)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public void HFLCHEMOGJO(string PNAKDHJADAN)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public string DIJKIEBHINP()
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static DPKJGBCDECA NBPMNECNBHJ(BinaryReader IOGJHEBPJHF)
	{
		KIEAFNHCIGJ kIEAFNHCIGJ = (KIEAFNHCIGJ)IOGJHEBPJHF.ReadByte();
		switch (kIEAFNHCIGJ)
		{
		case KIEAFNHCIGJ.Array:
		{
			int num2 = IOGJHEBPJHF.ReadInt32();
			OMOOJCDPFEL oMOOJCDPFEL = new OMOOJCDPFEL();
			for (int j = 0; j < num2; j++)
			{
				oMOOJCDPFEL.JEACJNAKLDJ(NBPMNECNBHJ(IOGJHEBPJHF));
			}
			return oMOOJCDPFEL;
		}
		case KIEAFNHCIGJ.Class:
		{
			int num = IOGJHEBPJHF.ReadInt32();
			ICCEIIKBABF iCCEIIKBABF = new ICCEIIKBABF();
			for (int i = 0; i < num; i++)
			{
				string oMGPFPGELOM = IOGJHEBPJHF.ReadString();
				DPKJGBCDECA gFADEOLDFDI = NBPMNECNBHJ(IOGJHEBPJHF);
				iCCEIIKBABF.JEACJNAKLDJ(oMGPFPGELOM, gFADEOLDFDI);
			}
			return iCCEIIKBABF;
		}
		case KIEAFNHCIGJ.Value:
			return new EOMIKBDENCM(IOGJHEBPJHF.ReadString());
		case KIEAFNHCIGJ.IntValue:
			return new EOMIKBDENCM(IOGJHEBPJHF.ReadInt32());
		case KIEAFNHCIGJ.DoubleValue:
			return new EOMIKBDENCM(IOGJHEBPJHF.ReadDouble());
		case KIEAFNHCIGJ.BoolValue:
			return new EOMIKBDENCM(IOGJHEBPJHF.ReadBoolean());
		case KIEAFNHCIGJ.FloatValue:
			return new EOMIKBDENCM(IOGJHEBPJHF.ReadSingle());
		default:
			throw new Exception("Error deserializing JSON. Unknown tag: " + kIEAFNHCIGJ);
		}
	}

	public static DPKJGBCDECA FGKNJFIIBAK(string PNAKDHJADAN)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static DPKJGBCDECA JOOPBIGLBOP(Stream LOPFNIFAMGK)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static DPKJGBCDECA MCGEEIJHLOK(string PMFKIDAOJPO)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static DPKJGBCDECA KLCFOIHBBJH(Stream LOPFNIFAMGK)
	{
		using (BinaryReader iOGJHEBPJHF = new BinaryReader(LOPFNIFAMGK))
		{
			return NBPMNECNBHJ(iOGJHEBPJHF);
		}
	}

	public static DPKJGBCDECA KJGIFGKABNC(string PMFKIDAOJPO)
	{
		byte[] buffer = Convert.FromBase64String(PMFKIDAOJPO);
		MemoryStream memoryStream = new MemoryStream(buffer);
		memoryStream.Position = 0L;
		return KLCFOIHBBJH(memoryStream);
	}
}
