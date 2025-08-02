using System;
using System.Collections.Generic;
using System.IO;

public class FEECFKHIBHI
{
	private static IDictionary<int, IDictionary<int, int[]>> IOMOPECHJGK;

	private Stack<int> OJEHBMLOPNK;

	private int HGONLPJCCBF;

	private int CMOBKKMILNJ;

	private bool JLFCPKPHPLD;

	private bool EOIEIDCNBGL;

	private HECAJHFNLKF JBNPKCNEJGG;

	private bool NELIOAGCNEB;

	private bool EOKENCLIAPC;

	private bool LOGEJOJBLIJ;

	private TextReader JIGJDAHIIBA;

	private bool BGHMLJOCOBL;

	private bool ALACCDCNNCC;

	private object ONDJCFJNMIF;

	private GPDLLCPCBAP DJJGDFFDGFN;

	public bool NHMLDOIDONK
	{
		get
		{
			return JBNPKCNEJGG.NHMLDOIDONK;
		}
		set
		{
			JBNPKCNEJGG.NHMLDOIDONK = value;
		}
	}

	public bool ODEJFABEPOD
	{
		get
		{
			return JBNPKCNEJGG.ODEJFABEPOD;
		}
		set
		{
			JBNPKCNEJGG.ODEJFABEPOD = value;
		}
	}

	public bool AFMCBFBKMGM
	{
		get
		{
			return ALACCDCNNCC;
		}
		set
		{
			ALACCDCNNCC = value;
		}
	}

	public bool CNJMIMFCDDM
	{
		get
		{
			return EOIEIDCNBGL;
		}
	}

	public bool EEEJBIAKLJI
	{
		get
		{
			return JLFCPKPHPLD;
		}
	}

	public GPDLLCPCBAP FIPPLABNDON
	{
		get
		{
			return DJJGDFFDGFN;
		}
	}

	public object JBGOANMLBFA
	{
		get
		{
			return ONDJCFJNMIF;
		}
	}

	static FEECFKHIBHI()
	{
		HKAPGKHMLLI();
	}

	public FEECFKHIBHI(string OGNEGCLLDPB)
		: this(new StringReader(OGNEGCLLDPB), true)
	{
	}

	public FEECFKHIBHI(TextReader JIGJDAHIIBA)
		: this(JIGJDAHIIBA, false)
	{
	}

	private FEECFKHIBHI(TextReader JIGJDAHIIBA, bool PPAHPAOJOMO)
	{
		if (JIGJDAHIIBA == null)
		{
			throw new ArgumentNullException("reader");
		}
		NELIOAGCNEB = false;
		EOKENCLIAPC = false;
		LOGEJOJBLIJ = false;
		OJEHBMLOPNK = new Stack<int>();
		OJEHBMLOPNK.Push(65553);
		OJEHBMLOPNK.Push(65543);
		JBNPKCNEJGG = new HECAJHFNLKF(JIGJDAHIIBA);
		EOIEIDCNBGL = false;
		JLFCPKPHPLD = false;
		ALACCDCNNCC = true;
		this.JIGJDAHIIBA = JIGJDAHIIBA;
		BGHMLJOCOBL = PPAHPAOJOMO;
	}

	private static void HKAPGKHMLLI()
	{
		IOMOPECHJGK = new Dictionary<int, IDictionary<int, int[]>>();
		LDDBBBLKIAH(ONDKJBJAONJ.Array);
		KAAICCKPCIC(ONDKJBJAONJ.Array, 91, 91, 65549);
		LDDBBBLKIAH(ONDKJBJAONJ.ArrayPrime);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 34, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 91, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 93, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 123, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 65537, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 65538, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 65539, 65550, 65551, 93);
		KAAICCKPCIC(ONDKJBJAONJ.ArrayPrime, 65540, 65550, 65551, 93);
		LDDBBBLKIAH(ONDKJBJAONJ.Object);
		KAAICCKPCIC(ONDKJBJAONJ.Object, 123, 123, 65545);
		LDDBBBLKIAH(ONDKJBJAONJ.ObjectPrime);
		KAAICCKPCIC(ONDKJBJAONJ.ObjectPrime, 34, 65546, 65547, 125);
		KAAICCKPCIC(ONDKJBJAONJ.ObjectPrime, 125, 125);
		LDDBBBLKIAH(ONDKJBJAONJ.Pair);
		KAAICCKPCIC(ONDKJBJAONJ.Pair, 34, 65552, 58, 65550);
		LDDBBBLKIAH(ONDKJBJAONJ.PairRest);
		KAAICCKPCIC(ONDKJBJAONJ.PairRest, 44, 44, 65546, 65547);
		KAAICCKPCIC(ONDKJBJAONJ.PairRest, 125, 65554);
		LDDBBBLKIAH(ONDKJBJAONJ.String);
		KAAICCKPCIC(ONDKJBJAONJ.String, 34, 34, 65541, 34);
		LDDBBBLKIAH(ONDKJBJAONJ.Text);
		KAAICCKPCIC(ONDKJBJAONJ.Text, 91, 65548);
		KAAICCKPCIC(ONDKJBJAONJ.Text, 123, 65544);
		LDDBBBLKIAH(ONDKJBJAONJ.Value);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 34, 65552);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 91, 65548);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 123, 65544);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 65537, 65537);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 65538, 65538);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 65539, 65539);
		KAAICCKPCIC(ONDKJBJAONJ.Value, 65540, 65540);
		LDDBBBLKIAH(ONDKJBJAONJ.ValueRest);
		KAAICCKPCIC(ONDKJBJAONJ.ValueRest, 44, 44, 65550, 65551);
		KAAICCKPCIC(ONDKJBJAONJ.ValueRest, 93, 65554);
	}

	private static void KAAICCKPCIC(ONDKJBJAONJ BCAKHCNOKDH, int CFHAAFPFMCG, params int[] GMEOPEFHNLK)
	{
		IOMOPECHJGK[(int)BCAKHCNOKDH].Add(CFHAAFPFMCG, GMEOPEFHNLK);
	}

	private static void LDDBBBLKIAH(ONDKJBJAONJ HCCLPKEEAHB)
	{
		IOMOPECHJGK.Add((int)HCCLPKEEAHB, new Dictionary<int, int[]>());
	}

	private void LBKJGLFLPHM(string CFEHLBIDFCG)
	{
		double result;
		int result2;
		long result3;
		if ((CFEHLBIDFCG.IndexOf('.') != -1 || CFEHLBIDFCG.IndexOf('e') != -1 || CFEHLBIDFCG.IndexOf('E') != -1) && double.TryParse(CFEHLBIDFCG, out result))
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Double;
			ONDJCFJNMIF = result;
		}
		else if (int.TryParse(CFEHLBIDFCG, out result2))
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Int;
			ONDJCFJNMIF = result2;
		}
		else if (long.TryParse(CFEHLBIDFCG, out result3))
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Long;
			ONDJCFJNMIF = result3;
		}
		else
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Int;
			ONDJCFJNMIF = 0;
		}
	}

	private void KIGJBENOMIC()
	{
		if (CMOBKKMILNJ == 91)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.ArrayStart;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 93)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.ArrayEnd;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 123)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.ObjectStart;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 125)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.ObjectEnd;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 34)
		{
			if (NELIOAGCNEB)
			{
				NELIOAGCNEB = false;
				EOKENCLIAPC = true;
				return;
			}
			if (DJJGDFFDGFN == GPDLLCPCBAP.None)
			{
				DJJGDFFDGFN = GPDLLCPCBAP.String;
			}
			NELIOAGCNEB = true;
		}
		else if (CMOBKKMILNJ == 65541)
		{
			ONDJCFJNMIF = JBNPKCNEJGG.IMDJJNLOEAD;
		}
		else if (CMOBKKMILNJ == 65539)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Boolean;
			ONDJCFJNMIF = false;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 65540)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Null;
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 65537)
		{
			LBKJGLFLPHM(JBNPKCNEJGG.IMDJJNLOEAD);
			EOKENCLIAPC = true;
		}
		else if (CMOBKKMILNJ == 65546)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.PropertyName;
		}
		else if (CMOBKKMILNJ == 65538)
		{
			DJJGDFFDGFN = GPDLLCPCBAP.Boolean;
			ONDJCFJNMIF = true;
			EOKENCLIAPC = true;
		}
	}

	private bool CCJPDKOAAMJ()
	{
		if (EOIEIDCNBGL)
		{
			return false;
		}
		JBNPKCNEJGG.NMLDMNBOJFN();
		if (JBNPKCNEJGG.CNJMIMFCDDM)
		{
			NKKOEHGDNKD();
			return false;
		}
		HGONLPJCCBF = JBNPKCNEJGG.FIPPLABNDON;
		return true;
	}

	public void NKKOEHGDNKD()
	{
		if (!EOIEIDCNBGL)
		{
			EOIEIDCNBGL = true;
			JLFCPKPHPLD = true;
			if (BGHMLJOCOBL)
			{
				JIGJDAHIIBA.Dispose();
			}
			JIGJDAHIIBA = null;
		}
	}

	public bool CELOEBEMCKP()
	{
		if (EOIEIDCNBGL)
		{
			return false;
		}
		if (JLFCPKPHPLD)
		{
			JLFCPKPHPLD = false;
			OJEHBMLOPNK.Clear();
			OJEHBMLOPNK.Push(65553);
			OJEHBMLOPNK.Push(65543);
		}
		NELIOAGCNEB = false;
		EOKENCLIAPC = false;
		DJJGDFFDGFN = GPDLLCPCBAP.None;
		ONDJCFJNMIF = null;
		if (!LOGEJOJBLIJ)
		{
			LOGEJOJBLIJ = true;
			if (!CCJPDKOAAMJ())
			{
				return false;
			}
		}
		while (true)
		{
			if (EOKENCLIAPC)
			{
				if (OJEHBMLOPNK.Peek() == 65553)
				{
					JLFCPKPHPLD = true;
				}
				return true;
			}
			CMOBKKMILNJ = OJEHBMLOPNK.Pop();
			KIGJBENOMIC();
			if (CMOBKKMILNJ == HGONLPJCCBF)
			{
				if (!CCJPDKOAAMJ())
				{
					break;
				}
				continue;
			}
			int[] array;
			try
			{
				array = IOMOPECHJGK[CMOBKKMILNJ][HGONLPJCCBF];
			}
			catch (KeyNotFoundException gHBFGCLPBGD)
			{
				throw new AHFEPEFFHLL((ONDKJBJAONJ)HGONLPJCCBF, gHBFGCLPBGD);
			}
			if (array[0] != 65554)
			{
				for (int num = array.Length - 1; num >= 0; num--)
				{
					OJEHBMLOPNK.Push(array[num]);
				}
			}
		}
		if (OJEHBMLOPNK.Peek() != 65553)
		{
			throw new AHFEPEFFHLL("Input doesn't evaluate to proper JSON text");
		}
		if (EOKENCLIAPC)
		{
			return true;
		}
		return false;
	}
}
