using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class JLODNMAAHAC
{
	public virtual JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JLODNMAAHAC AHANCLBKKID
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

	public virtual IEnumerable<JLODNMAAHAC> JHEDPFKFFJB
	{
		get
		{
			yield break;
		}
	}

	public IEnumerable<JLODNMAAHAC> KOMIFDPBDNB
	{
		get
		{
			foreach (JLODNMAAHAC item in JHEDPFKFFJB)
			{
				foreach (JLODNMAAHAC item2 in item.KOMIFDPBDNB)
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

	public virtual DGFIHEEHLKF NLOOFFLFPPE
	{
		get
		{
			return this as DGFIHEEHLKF;
		}
	}

	public virtual FDKLGGOAFPJ JPIHKOGIKHA
	{
		get
		{
			return this as FDKLGGOAFPJ;
		}
	}

	public virtual void JEACJNAKLDJ(string OMGPFPGELOM, JLODNMAAHAC GFADEOLDFDI)
	{
	}

	public virtual void JEACJNAKLDJ(JLODNMAAHAC GFADEOLDFDI)
	{
		JEACJNAKLDJ(string.Empty, GFADEOLDFDI);
	}

	public virtual JLODNMAAHAC CJOHLENDJGO(string OMGPFPGELOM)
	{
		return null;
	}

	public virtual JLODNMAAHAC CJOHLENDJGO(int LHOJEJCFKCN)
	{
		return null;
	}

	public virtual JLODNMAAHAC CJOHLENDJGO(JLODNMAAHAC LELOKDCLJMD)
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
	public static JLODNMAAHAC AGIIAGNEIKI(string IBBBMACIBGK)
	{
		return new AKDPOOMBAMD(IBBBMACIBGK);
	}

	[SpecialName]
	public static string AGIIAGNEIKI(JLODNMAAHAC ELNCCDELMMH)
	{
		return (!OCAFFLHPIMM(ELNCCDELMMH, null)) ? ELNCCDELMMH.JBGOANMLBFA : null;
	}

	[SpecialName]
	public static bool OCAFFLHPIMM(JLODNMAAHAC MNIMEAMHNMI, object BCIHLCMFAEK)
	{
		if (BCIHLCMFAEK == null && MNIMEAMHNMI is MPHIIHDHBBF)
		{
			return true;
		}
		return object.ReferenceEquals(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	[SpecialName]
	public static bool BLPPLFIKFPN(JLODNMAAHAC MNIMEAMHNMI, object BCIHLCMFAEK)
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

	public static JLODNMAAHAC DHCLOMIANOE(string LGMNAIAFHAH)
	{
		Stack<JLODNMAAHAC> stack = new Stack<JLODNMAAHAC>();
		JLODNMAAHAC jLODNMAAHAC = null;
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
				stack.Push(new FDKLGGOAFPJ());
				if (BLPPLFIKFPN(jLODNMAAHAC, null))
				{
					text2 = text2.Trim();
					if (jLODNMAAHAC is DGFIHEEHLKF)
					{
						jLODNMAAHAC.JEACJNAKLDJ(stack.Peek());
					}
					else if (text2 != string.Empty)
					{
						jLODNMAAHAC.JEACJNAKLDJ(text2, stack.Peek());
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				jLODNMAAHAC = stack.Peek();
				break;
			case '[':
				if (flag)
				{
					text += LGMNAIAFHAH[i];
					break;
				}
				stack.Push(new DGFIHEEHLKF());
				if (BLPPLFIKFPN(jLODNMAAHAC, null))
				{
					text2 = text2.Trim();
					if (jLODNMAAHAC is DGFIHEEHLKF)
					{
						jLODNMAAHAC.JEACJNAKLDJ(stack.Peek());
					}
					else if (text2 != string.Empty)
					{
						jLODNMAAHAC.JEACJNAKLDJ(text2, stack.Peek());
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				jLODNMAAHAC = stack.Peek();
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
					if (jLODNMAAHAC is DGFIHEEHLKF)
					{
						jLODNMAAHAC.JEACJNAKLDJ(AGIIAGNEIKI(text));
					}
					else if (text2 != string.Empty)
					{
						jLODNMAAHAC.JEACJNAKLDJ(text2, AGIIAGNEIKI(text));
					}
				}
				text2 = string.Empty;
				text = string.Empty;
				if (stack.Count > 0)
				{
					jLODNMAAHAC = stack.Peek();
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
					if (jLODNMAAHAC is DGFIHEEHLKF)
					{
						jLODNMAAHAC.JEACJNAKLDJ(AGIIAGNEIKI(text));
					}
					else if (text2 != string.Empty)
					{
						jLODNMAAHAC.JEACJNAKLDJ(text2, AGIIAGNEIKI(text));
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
		return jLODNMAAHAC;
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

	public void APNJAPLPHMB(string PNAKDHJADAN)
	{
		Directory.CreateDirectory(new FileInfo(PNAKDHJADAN).Directory.FullName);
		using (FileStream lOPFNIFAMGK = File.OpenWrite(PNAKDHJADAN))
		{
			INGAIONMOKK(lOPFNIFAMGK);
		}
	}

	public string IOFHILIFIKJ()
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			INGAIONMOKK(memoryStream);
			memoryStream.Position = 0L;
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	public static JLODNMAAHAC NBPMNECNBHJ(BinaryReader IOGJHEBPJHF)
	{
		NOJFCOMCGBO nOJFCOMCGBO = (NOJFCOMCGBO)IOGJHEBPJHF.ReadByte();
		switch (nOJFCOMCGBO)
		{
		case NOJFCOMCGBO.Array:
		{
			int num2 = IOGJHEBPJHF.ReadInt32();
			DGFIHEEHLKF dGFIHEEHLKF = new DGFIHEEHLKF();
			for (int j = 0; j < num2; j++)
			{
				dGFIHEEHLKF.JEACJNAKLDJ(NBPMNECNBHJ(IOGJHEBPJHF));
			}
			return dGFIHEEHLKF;
		}
		case NOJFCOMCGBO.Class:
		{
			int num = IOGJHEBPJHF.ReadInt32();
			FDKLGGOAFPJ fDKLGGOAFPJ = new FDKLGGOAFPJ();
			for (int i = 0; i < num; i++)
			{
				string oMGPFPGELOM = IOGJHEBPJHF.ReadString();
				JLODNMAAHAC gFADEOLDFDI = NBPMNECNBHJ(IOGJHEBPJHF);
				fDKLGGOAFPJ.JEACJNAKLDJ(oMGPFPGELOM, gFADEOLDFDI);
			}
			return fDKLGGOAFPJ;
		}
		case NOJFCOMCGBO.Value:
			return new AKDPOOMBAMD(IOGJHEBPJHF.ReadString());
		case NOJFCOMCGBO.IntValue:
			return new AKDPOOMBAMD(IOGJHEBPJHF.ReadInt32());
		case NOJFCOMCGBO.DoubleValue:
			return new AKDPOOMBAMD(IOGJHEBPJHF.ReadDouble());
		case NOJFCOMCGBO.BoolValue:
			return new AKDPOOMBAMD(IOGJHEBPJHF.ReadBoolean());
		case NOJFCOMCGBO.FloatValue:
			return new AKDPOOMBAMD(IOGJHEBPJHF.ReadSingle());
		default:
			throw new Exception("Error deserializing JSON. Unknown tag: " + nOJFCOMCGBO);
		}
	}

	public static JLODNMAAHAC FGKNJFIIBAK(string PNAKDHJADAN)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JLODNMAAHAC JOOPBIGLBOP(Stream LOPFNIFAMGK)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JLODNMAAHAC MCGEEIJHLOK(string PMFKIDAOJPO)
	{
		throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JLODNMAAHAC KLCFOIHBBJH(Stream LOPFNIFAMGK)
	{
		using (BinaryReader iOGJHEBPJHF = new BinaryReader(LOPFNIFAMGK))
		{
			return NBPMNECNBHJ(iOGJHEBPJHF);
		}
	}

	public static JLODNMAAHAC EOCDBIHEMJM(string PNAKDHJADAN)
	{
		using (FileStream lOPFNIFAMGK = File.OpenRead(PNAKDHJADAN))
		{
			return KLCFOIHBBJH(lOPFNIFAMGK);
		}
	}

	public static JLODNMAAHAC KJGIFGKABNC(string PMFKIDAOJPO)
	{
		byte[] buffer = Convert.FromBase64String(PMFKIDAOJPO);
		MemoryStream memoryStream = new MemoryStream(buffer);
		memoryStream.Position = 0L;
		return KLCFOIHBBJH(memoryStream);
	}
}
