using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class FMHLMKJKDEG : GFIEDFFPKHM, IEquatable<FMHLMKJKDEG>, IList, EKEGMOKHCDK, IEnumerable, ICollection, IDictionary
{
	private IList<FMHLMKJKDEG> MJHBNNAOCLH;

	private bool HIPDDJJGAAI;

	private double MDCKFBMDIJC;

	private int LGNHHKMMMBK;

	private long IFJJNIMINEA;

	private IDictionary<string, FMHLMKJKDEG> HJLIGGBGIKM;

	private string GEDDMNJDMCI;

	private string BIPAJFCNEOB;

	private IOIMIGDIAFB NBFBPNNEKMN;

	private IList<KeyValuePair<string, FMHLMKJKDEG>> GCPGFJHEJKJ;

	int ICollection.BMIDKMGDNOI
	{
		get
		{
			return GMCGMPEEHJP;
		}
	}

	bool ICollection.EIAIPLMMEHO
	{
		get
		{
			return BOONPLAAKAF().IsSynchronized;
		}
	}

	object ICollection.DOCGDCAJCPN
	{
		get
		{
			return BOONPLAAKAF().SyncRoot;
		}
	}

	bool IDictionary.PCHEMFDAGFE
	{
		get
		{
			return LGHEJPAGMKF().IsFixedSize;
		}
	}

	bool IDictionary.NABJJDBFHHM
	{
		get
		{
			return LGHEJPAGMKF().IsReadOnly;
		}
	}

	ICollection IDictionary.MOMCJKLLLCI
	{
		get
		{
			LGHEJPAGMKF();
			IList<string> list = new List<string>();
			foreach (KeyValuePair<string, FMHLMKJKDEG> item in GCPGFJHEJKJ)
			{
				list.Add(item.Key);
			}
			return (ICollection)list;
		}
	}

	ICollection IDictionary.DGPJKDOICGP
	{
		get
		{
			LGHEJPAGMKF();
			IList<FMHLMKJKDEG> list = new List<FMHLMKJKDEG>();
			foreach (KeyValuePair<string, FMHLMKJKDEG> item in GCPGFJHEJKJ)
			{
				list.Add(item.Value);
			}
			return (ICollection)list;
		}
	}

	bool GFIEDFFPKHM.FGLCGLHAGEF
	{
		get
		{
			return KDHOKBONCAF;
		}
	}

	bool GFIEDFFPKHM.AIABLDAAKFO
	{
		get
		{
			return AHMLIGLBABJ;
		}
	}

	bool GFIEDFFPKHM.LKGAIDJBONC
	{
		get
		{
			return LCMPKCLPLGA;
		}
	}

	bool GFIEDFFPKHM.HMMBODHIEAE
	{
		get
		{
			return FDLEALNNABE;
		}
	}

	bool GFIEDFFPKHM.PHHNGGKFKNA
	{
		get
		{
			return LELMKIFMIDA;
		}
	}

	bool GFIEDFFPKHM.DMJDKGPCOGO
	{
		get
		{
			return KGMHCAIIJAB;
		}
	}

	bool GFIEDFFPKHM.EFOBKGPGBDP
	{
		get
		{
			return LNEEHGMPALE;
		}
	}

	bool IList.FKFDMFMKENM
	{
		get
		{
			return GFAGNACMOOO().IsFixedSize;
		}
	}

	bool IList.ANBEMANAJJG
	{
		get
		{
			return GFAGNACMOOO().IsReadOnly;
		}
	}

	object IDictionary.EDPMKKKIIKM
	{
		get
		{
			return LGHEJPAGMKF()[IKNCPEPOKGJ];
		}
		set
		{
			if (!(IKNCPEPOKGJ is string))
			{
				throw new ArgumentException("The key has to be a string");
			}
			FMHLMKJKDEG eDDNOJDPMCF = MOOFBEGJELO(value);
			this.set_Item((string)IKNCPEPOKGJ, eDDNOJDPMCF);
		}
	}

	object EKEGMOKHCDK.LFNDKHGODCL
	{
		get
		{
			LGHEJPAGMKF();
			return GCPGFJHEJKJ[MMLIOLEILLO].Value;
		}
		set
		{
			LGHEJPAGMKF();
			FMHLMKJKDEG value2 = MOOFBEGJELO(value);
			KeyValuePair<string, FMHLMKJKDEG> keyValuePair = GCPGFJHEJKJ[MMLIOLEILLO];
			HJLIGGBGIKM[keyValuePair.Key] = value2;
			KeyValuePair<string, FMHLMKJKDEG> value3 = new KeyValuePair<string, FMHLMKJKDEG>(keyValuePair.Key, value2);
			GCPGFJHEJKJ[MMLIOLEILLO] = value3;
		}
	}

	object IList.GAODMMNBBPL
	{
		get
		{
			return GFAGNACMOOO()[EHJNMODJEAN];
		}
		set
		{
			GFAGNACMOOO();
			FMHLMKJKDEG eDDNOJDPMCF = MOOFBEGJELO(value);
			this.set_Item(EHJNMODJEAN, eDDNOJDPMCF);
		}
	}

	public int GMCGMPEEHJP
	{
		get
		{
			return BOONPLAAKAF().Count;
		}
	}

	public bool KDHOKBONCAF
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Array;
		}
	}

	public bool AHMLIGLBABJ
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Boolean;
		}
	}

	public bool LCMPKCLPLGA
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Double;
		}
	}

	public bool FDLEALNNABE
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Int;
		}
	}

	public bool LELMKIFMIDA
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Long;
		}
	}

	public bool KGMHCAIIJAB
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.Object;
		}
	}

	public bool LNEEHGMPALE
	{
		get
		{
			return NBFBPNNEKMN == IOIMIGDIAFB.String;
		}
	}

	public ICollection<string> JDADAMJHIHM
	{
		get
		{
			LGHEJPAGMKF();
			return HJLIGGBGIKM.Keys;
		}
	}

	public FMHLMKJKDEG AHANCLBKKID
	{
		get
		{
			LGHEJPAGMKF();
			return HJLIGGBGIKM[DBDOELOICKF];
		}
		set
		{
			LGHEJPAGMKF();
			KeyValuePair<string, FMHLMKJKDEG> keyValuePair = new KeyValuePair<string, FMHLMKJKDEG>(DBDOELOICKF, value);
			if (HJLIGGBGIKM.ContainsKey(DBDOELOICKF))
			{
				for (int i = 0; i < GCPGFJHEJKJ.Count; i++)
				{
					if (GCPGFJHEJKJ[i].Key == DBDOELOICKF)
					{
						GCPGFJHEJKJ[i] = keyValuePair;
						break;
					}
				}
			}
			else
			{
				GCPGFJHEJKJ.Add(keyValuePair);
			}
			HJLIGGBGIKM[DBDOELOICKF] = value;
			BIPAJFCNEOB = null;
		}
	}

	public FMHLMKJKDEG AHANCLBKKID
	{
		get
		{
			BOONPLAAKAF();
			if (NBFBPNNEKMN == IOIMIGDIAFB.Array)
			{
				return MJHBNNAOCLH[EHJNMODJEAN];
			}
			return GCPGFJHEJKJ[EHJNMODJEAN].Value;
		}
		set
		{
			BOONPLAAKAF();
			if (NBFBPNNEKMN == IOIMIGDIAFB.Array)
			{
				MJHBNNAOCLH[EHJNMODJEAN] = value;
			}
			else
			{
				KeyValuePair<string, FMHLMKJKDEG> keyValuePair = GCPGFJHEJKJ[EHJNMODJEAN];
				KeyValuePair<string, FMHLMKJKDEG> value2 = new KeyValuePair<string, FMHLMKJKDEG>(keyValuePair.Key, value);
				GCPGFJHEJKJ[EHJNMODJEAN] = value2;
				HJLIGGBGIKM[keyValuePair.Key] = value;
			}
			BIPAJFCNEOB = null;
		}
	}

	public FMHLMKJKDEG()
	{
	}

	public FMHLMKJKDEG(bool INFENIMONBM)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Boolean;
		HIPDDJJGAAI = INFENIMONBM;
	}

	public FMHLMKJKDEG(double CFEHLBIDFCG)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Double;
		MDCKFBMDIJC = CFEHLBIDFCG;
	}

	public FMHLMKJKDEG(int CFEHLBIDFCG)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Int;
		LGNHHKMMMBK = CFEHLBIDFCG;
	}

	public FMHLMKJKDEG(long CFEHLBIDFCG)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Long;
		IFJJNIMINEA = CFEHLBIDFCG;
	}

	public FMHLMKJKDEG(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC is bool)
		{
			NBFBPNNEKMN = IOIMIGDIAFB.Boolean;
			HIPDDJJGAAI = (bool)NEMEKIOEOLC;
			return;
		}
		if (NEMEKIOEOLC is double)
		{
			NBFBPNNEKMN = IOIMIGDIAFB.Double;
			MDCKFBMDIJC = (double)NEMEKIOEOLC;
			return;
		}
		if (NEMEKIOEOLC is int)
		{
			NBFBPNNEKMN = IOIMIGDIAFB.Int;
			LGNHHKMMMBK = (int)NEMEKIOEOLC;
			return;
		}
		if (NEMEKIOEOLC is long)
		{
			NBFBPNNEKMN = IOIMIGDIAFB.Long;
			IFJJNIMINEA = (long)NEMEKIOEOLC;
			return;
		}
		if (NEMEKIOEOLC is string)
		{
			NBFBPNNEKMN = IOIMIGDIAFB.String;
			GEDDMNJDMCI = (string)NEMEKIOEOLC;
			return;
		}
		throw new ArgumentException("Unable to wrap the given object with JsonData");
	}

	public FMHLMKJKDEG(string GFPBBLPMOOL)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.String;
		GEDDMNJDMCI = GFPBBLPMOOL;
	}

	[SpecialName]
	public static FMHLMKJKDEG AGIIAGNEIKI(bool MBBPBGHKLJM)
	{
		return new FMHLMKJKDEG(MBBPBGHKLJM);
	}

	[SpecialName]
	public static FMHLMKJKDEG AGIIAGNEIKI(double MBBPBGHKLJM)
	{
		return new FMHLMKJKDEG(MBBPBGHKLJM);
	}

	[SpecialName]
	public static FMHLMKJKDEG AGIIAGNEIKI(int MBBPBGHKLJM)
	{
		return new FMHLMKJKDEG(MBBPBGHKLJM);
	}

	[SpecialName]
	public static FMHLMKJKDEG AGIIAGNEIKI(long MBBPBGHKLJM)
	{
		return new FMHLMKJKDEG(MBBPBGHKLJM);
	}

	[SpecialName]
	public static FMHLMKJKDEG AGIIAGNEIKI(string MBBPBGHKLJM)
	{
		return new FMHLMKJKDEG(MBBPBGHKLJM);
	}

	[SpecialName]
	public static bool KOFENMCMNKJ(FMHLMKJKDEG MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM.NBFBPNNEKMN != IOIMIGDIAFB.Boolean)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return MBBPBGHKLJM.HIPDDJJGAAI;
	}

	[SpecialName]
	public static double KOFENMCMNKJ(FMHLMKJKDEG MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM.NBFBPNNEKMN != IOIMIGDIAFB.Double)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a double");
		}
		return MBBPBGHKLJM.MDCKFBMDIJC;
	}

	[SpecialName]
	public static int KOFENMCMNKJ(FMHLMKJKDEG MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM.NBFBPNNEKMN != IOIMIGDIAFB.Int)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return MBBPBGHKLJM.LGNHHKMMMBK;
	}

	[SpecialName]
	public static long KOFENMCMNKJ(FMHLMKJKDEG MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM.NBFBPNNEKMN != IOIMIGDIAFB.Long)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold an int");
		}
		return MBBPBGHKLJM.IFJJNIMINEA;
	}

	[SpecialName]
	public static string KOFENMCMNKJ(FMHLMKJKDEG MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM.NBFBPNNEKMN != IOIMIGDIAFB.String)
		{
			throw new InvalidCastException("Instance of JsonData doesn't hold a string");
		}
		return MBBPBGHKLJM.GEDDMNJDMCI;
	}

	void ICollection.CopyTo(Array KDOGMDCDCEN, int EHJNMODJEAN)
	{
		BOONPLAAKAF().CopyTo(KDOGMDCDCEN, EHJNMODJEAN);
	}

	void IDictionary.Add(object IKNCPEPOKGJ, object EDDNOJDPMCF)
	{
		FMHLMKJKDEG value = MOOFBEGJELO(EDDNOJDPMCF);
		LGHEJPAGMKF().Add(IKNCPEPOKGJ, value);
		KeyValuePair<string, FMHLMKJKDEG> item = new KeyValuePair<string, FMHLMKJKDEG>((string)IKNCPEPOKGJ, value);
		GCPGFJHEJKJ.Add(item);
		BIPAJFCNEOB = null;
	}

	void IDictionary.Clear()
	{
		LGHEJPAGMKF().Clear();
		GCPGFJHEJKJ.Clear();
		BIPAJFCNEOB = null;
	}

	bool IDictionary.Contains(object IKNCPEPOKGJ)
	{
		return LGHEJPAGMKF().Contains(IKNCPEPOKGJ);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return ((EKEGMOKHCDK)this).GetEnumerator();
	}

	void IDictionary.Remove(object IKNCPEPOKGJ)
	{
		LGHEJPAGMKF().Remove(IKNCPEPOKGJ);
		for (int i = 0; i < GCPGFJHEJKJ.Count; i++)
		{
			if (GCPGFJHEJKJ[i].Key == (string)IKNCPEPOKGJ)
			{
				GCPGFJHEJKJ.RemoveAt(i);
				break;
			}
		}
		BIPAJFCNEOB = null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return BOONPLAAKAF().GetEnumerator();
	}

	bool GFIEDFFPKHM.GetBoolean()
	{
		if (NBFBPNNEKMN != IOIMIGDIAFB.Boolean)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a boolean");
		}
		return HIPDDJJGAAI;
	}

	double GFIEDFFPKHM.GetDouble()
	{
		if (NBFBPNNEKMN != IOIMIGDIAFB.Double)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a double");
		}
		return MDCKFBMDIJC;
	}

	int GFIEDFFPKHM.GetInt()
	{
		if (NBFBPNNEKMN != IOIMIGDIAFB.Int)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold an int");
		}
		return LGNHHKMMMBK;
	}

	long GFIEDFFPKHM.GetLong()
	{
		if (NBFBPNNEKMN != IOIMIGDIAFB.Long)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a long");
		}
		return IFJJNIMINEA;
	}

	string GFIEDFFPKHM.GetString()
	{
		if (NBFBPNNEKMN != IOIMIGDIAFB.String)
		{
			throw new InvalidOperationException("JsonData instance doesn't hold a string");
		}
		return GEDDMNJDMCI;
	}

	void GFIEDFFPKHM.SetBoolean(bool HIMINGHNIKN)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Boolean;
		HIPDDJJGAAI = HIMINGHNIKN;
		BIPAJFCNEOB = null;
	}

	void GFIEDFFPKHM.SetDouble(double HIMINGHNIKN)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Double;
		MDCKFBMDIJC = HIMINGHNIKN;
		BIPAJFCNEOB = null;
	}

	void GFIEDFFPKHM.SetInt(int HIMINGHNIKN)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Int;
		LGNHHKMMMBK = HIMINGHNIKN;
		BIPAJFCNEOB = null;
	}

	void GFIEDFFPKHM.SetLong(long HIMINGHNIKN)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.Long;
		IFJJNIMINEA = HIMINGHNIKN;
		BIPAJFCNEOB = null;
	}

	void GFIEDFFPKHM.SetString(string HIMINGHNIKN)
	{
		NBFBPNNEKMN = IOIMIGDIAFB.String;
		GEDDMNJDMCI = HIMINGHNIKN;
		BIPAJFCNEOB = null;
	}

	string GFIEDFFPKHM.ToJson()
	{
		return PDBENFDNJAI();
	}

	void GFIEDFFPKHM.ToJson(JGHOOMMOCFJ GHLABECMBPB)
	{
		PDBENFDNJAI(GHLABECMBPB);
	}

	int IList.Add(object EDDNOJDPMCF)
	{
		return JEACJNAKLDJ(EDDNOJDPMCF);
	}

	void IList.Clear()
	{
		GFAGNACMOOO().Clear();
		BIPAJFCNEOB = null;
	}

	bool IList.Contains(object EDDNOJDPMCF)
	{
		return GFAGNACMOOO().Contains(EDDNOJDPMCF);
	}

	int IList.IndexOf(object EDDNOJDPMCF)
	{
		return GFAGNACMOOO().IndexOf(EDDNOJDPMCF);
	}

	void IList.Insert(int EHJNMODJEAN, object EDDNOJDPMCF)
	{
		GFAGNACMOOO().Insert(EHJNMODJEAN, EDDNOJDPMCF);
		BIPAJFCNEOB = null;
	}

	void IList.Remove(object EDDNOJDPMCF)
	{
		GFAGNACMOOO().Remove(EDDNOJDPMCF);
		BIPAJFCNEOB = null;
	}

	void IList.RemoveAt(int EHJNMODJEAN)
	{
		GFAGNACMOOO().RemoveAt(EHJNMODJEAN);
		BIPAJFCNEOB = null;
	}

	IDictionaryEnumerator EKEGMOKHCDK.GetEnumerator()
	{
		LGHEJPAGMKF();
		return new FPIGGKDFOPK(GCPGFJHEJKJ.GetEnumerator());
	}

	void EKEGMOKHCDK.Insert(int MMLIOLEILLO, object IKNCPEPOKGJ, object EDDNOJDPMCF)
	{
		string text = (string)IKNCPEPOKGJ;
		FMHLMKJKDEG fMHLMKJKDEG = MOOFBEGJELO(EDDNOJDPMCF);
		this.set_Item(text, fMHLMKJKDEG);
		KeyValuePair<string, FMHLMKJKDEG> item = new KeyValuePair<string, FMHLMKJKDEG>(text, fMHLMKJKDEG);
		GCPGFJHEJKJ.Insert(MMLIOLEILLO, item);
	}

	void EKEGMOKHCDK.RemoveAt(int MMLIOLEILLO)
	{
		LGHEJPAGMKF();
		HJLIGGBGIKM.Remove(GCPGFJHEJKJ[MMLIOLEILLO].Key);
		GCPGFJHEJKJ.RemoveAt(MMLIOLEILLO);
	}

	private ICollection BOONPLAAKAF()
	{
		if (NBFBPNNEKMN == IOIMIGDIAFB.Array)
		{
			return (ICollection)MJHBNNAOCLH;
		}
		if (NBFBPNNEKMN == IOIMIGDIAFB.Object)
		{
			return (ICollection)HJLIGGBGIKM;
		}
		throw new InvalidOperationException("The JsonData instance has to be initialized first");
	}

	private IDictionary LGHEJPAGMKF()
	{
		if (NBFBPNNEKMN == IOIMIGDIAFB.Object)
		{
			return (IDictionary)HJLIGGBGIKM;
		}
		if (NBFBPNNEKMN != 0)
		{
			throw new InvalidOperationException("Instance of JsonData is not a dictionary");
		}
		NBFBPNNEKMN = IOIMIGDIAFB.Object;
		HJLIGGBGIKM = new Dictionary<string, FMHLMKJKDEG>();
		GCPGFJHEJKJ = new List<KeyValuePair<string, FMHLMKJKDEG>>();
		return (IDictionary)HJLIGGBGIKM;
	}

	private IList GFAGNACMOOO()
	{
		if (NBFBPNNEKMN == IOIMIGDIAFB.Array)
		{
			return (IList)MJHBNNAOCLH;
		}
		if (NBFBPNNEKMN != 0)
		{
			throw new InvalidOperationException("Instance of JsonData is not a list");
		}
		NBFBPNNEKMN = IOIMIGDIAFB.Array;
		MJHBNNAOCLH = new List<FMHLMKJKDEG>();
		return (IList)MJHBNNAOCLH;
	}

	private FMHLMKJKDEG MOOFBEGJELO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			return null;
		}
		if (NEMEKIOEOLC is FMHLMKJKDEG)
		{
			return (FMHLMKJKDEG)NEMEKIOEOLC;
		}
		return new FMHLMKJKDEG(NEMEKIOEOLC);
	}

	private static void JCOBHOEINIH(GFIEDFFPKHM NEMEKIOEOLC, JGHOOMMOCFJ GHLABECMBPB)
	{
		if (NEMEKIOEOLC == null)
		{
			GHLABECMBPB.KBMOJGCCCEN(null);
		}
		else if (NEMEKIOEOLC.LNEEHGMPALE)
		{
			GHLABECMBPB.KBMOJGCCCEN(NEMEKIOEOLC.JDANMONKNGD());
		}
		else if (NEMEKIOEOLC.AHMLIGLBABJ)
		{
			GHLABECMBPB.KBMOJGCCCEN(NEMEKIOEOLC.JJCKAEJFAAM());
		}
		else if (NEMEKIOEOLC.LCMPKCLPLGA)
		{
			GHLABECMBPB.KBMOJGCCCEN(NEMEKIOEOLC.AGJEOIPMGKI());
		}
		else if (NEMEKIOEOLC.FDLEALNNABE)
		{
			GHLABECMBPB.KBMOJGCCCEN(NEMEKIOEOLC.CFHAMLBKKLA());
		}
		else if (NEMEKIOEOLC.LELMKIFMIDA)
		{
			GHLABECMBPB.KBMOJGCCCEN(NEMEKIOEOLC.EICLJDHEHHP());
		}
		else if (NEMEKIOEOLC.KDHOKBONCAF)
		{
			GHLABECMBPB.AMOOKGONCNL();
			foreach (object item in (IEnumerable)NEMEKIOEOLC)
			{
				JCOBHOEINIH((FMHLMKJKDEG)item, GHLABECMBPB);
			}
			GHLABECMBPB.KDKCHLBKEEN();
		}
		else
		{
			if (!NEMEKIOEOLC.KGMHCAIIJAB)
			{
				return;
			}
			GHLABECMBPB.IGJCBGHOCAK();
			foreach (DictionaryEntry item2 in (IDictionary)NEMEKIOEOLC)
			{
				GHLABECMBPB.LDEPLFIBHOF((string)item2.Key);
				JCOBHOEINIH((FMHLMKJKDEG)item2.Value, GHLABECMBPB);
			}
			GHLABECMBPB.MLHNFLBDEDL();
		}
	}

	public int JEACJNAKLDJ(object EDDNOJDPMCF)
	{
		FMHLMKJKDEG value = MOOFBEGJELO(EDDNOJDPMCF);
		BIPAJFCNEOB = null;
		return GFAGNACMOOO().Add(value);
	}

	public void BOPEPLONIFL()
	{
		if (KGMHCAIIJAB)
		{
			((IDictionary)this).Clear();
		}
		else if (KDHOKBONCAF)
		{
			((IList)this).Clear();
		}
	}

	public bool Equals(FMHLMKJKDEG AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null)
		{
			return false;
		}
		if (AMFCENFNAJJ.NBFBPNNEKMN != NBFBPNNEKMN)
		{
			return false;
		}
		switch (NBFBPNNEKMN)
		{
		case IOIMIGDIAFB.None:
			return true;
		case IOIMIGDIAFB.Object:
			return HJLIGGBGIKM.Equals(AMFCENFNAJJ.HJLIGGBGIKM);
		case IOIMIGDIAFB.Array:
			return MJHBNNAOCLH.Equals(AMFCENFNAJJ.MJHBNNAOCLH);
		case IOIMIGDIAFB.String:
			return GEDDMNJDMCI.Equals(AMFCENFNAJJ.GEDDMNJDMCI);
		case IOIMIGDIAFB.Int:
			return LGNHHKMMMBK.Equals(AMFCENFNAJJ.LGNHHKMMMBK);
		case IOIMIGDIAFB.Long:
			return IFJJNIMINEA.Equals(AMFCENFNAJJ.IFJJNIMINEA);
		case IOIMIGDIAFB.Double:
			return MDCKFBMDIJC.Equals(AMFCENFNAJJ.MDCKFBMDIJC);
		case IOIMIGDIAFB.Boolean:
			return HIPDDJJGAAI.Equals(AMFCENFNAJJ.HIPDDJJGAAI);
		default:
			return false;
		}
	}

	public IOIMIGDIAFB LCKJNJIONMB()
	{
		return NBFBPNNEKMN;
	}

	public void GAEOAEEMOOE(IOIMIGDIAFB NBFBPNNEKMN)
	{
		if (this.NBFBPNNEKMN != NBFBPNNEKMN)
		{
			switch (NBFBPNNEKMN)
			{
			case IOIMIGDIAFB.Object:
				HJLIGGBGIKM = new Dictionary<string, FMHLMKJKDEG>();
				GCPGFJHEJKJ = new List<KeyValuePair<string, FMHLMKJKDEG>>();
				break;
			case IOIMIGDIAFB.Array:
				MJHBNNAOCLH = new List<FMHLMKJKDEG>();
				break;
			case IOIMIGDIAFB.String:
				GEDDMNJDMCI = null;
				break;
			case IOIMIGDIAFB.Int:
				LGNHHKMMMBK = 0;
				break;
			case IOIMIGDIAFB.Long:
				IFJJNIMINEA = 0L;
				break;
			case IOIMIGDIAFB.Double:
				MDCKFBMDIJC = 0.0;
				break;
			case IOIMIGDIAFB.Boolean:
				HIPDDJJGAAI = false;
				break;
			}
			this.NBFBPNNEKMN = NBFBPNNEKMN;
		}
	}

	public string PDBENFDNJAI()
	{
		if (BIPAJFCNEOB != null)
		{
			return BIPAJFCNEOB;
		}
		StringWriter stringWriter = new StringWriter();
		JGHOOMMOCFJ jGHOOMMOCFJ = new JGHOOMMOCFJ(stringWriter);
		jGHOOMMOCFJ.PIBLOPJEGEL = false;
		JCOBHOEINIH(this, jGHOOMMOCFJ);
		BIPAJFCNEOB = stringWriter.ToString();
		return BIPAJFCNEOB;
	}

	public void PDBENFDNJAI(JGHOOMMOCFJ GHLABECMBPB)
	{
		bool eDDNOJDPMCF = GHLABECMBPB.PIBLOPJEGEL;
		GHLABECMBPB.PIBLOPJEGEL = false;
		JCOBHOEINIH(this, GHLABECMBPB);
		GHLABECMBPB.PIBLOPJEGEL = eDDNOJDPMCF;
	}

	public override string ToString()
	{
		switch (NBFBPNNEKMN)
		{
		case IOIMIGDIAFB.Array:
			return "JsonData array";
		case IOIMIGDIAFB.Boolean:
			return HIPDDJJGAAI.ToString();
		case IOIMIGDIAFB.Double:
			return MDCKFBMDIJC.ToString();
		case IOIMIGDIAFB.Int:
			return LGNHHKMMMBK.ToString();
		case IOIMIGDIAFB.Long:
			return IFJJNIMINEA.ToString();
		case IOIMIGDIAFB.Object:
			return "JsonData object";
		case IOIMIGDIAFB.String:
			return GEDDMNJDMCI;
		default:
			return "Uninitialized JsonData";
		}
	}
}
