using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class PHHKFLHAFHG
{
	public const string ADLNBAMAOJD = "CloudUser";

	private const char LOAGPLLLFAN = ':';

	private const string MCDHJMHOBDC = "fb";

	private bool EEPEOANKBML;

	private FDJAIONEJKM JEFGIMHJPEO;

	private FDJAIONEJKM BIHDLEDFBGN;

	private readonly LLCJMMBBLEH OLDFNGMFPCJ;

	[CompilerGenerated]
	private static Action<string> JANLDOMIIEF;

	public bool HDKJPHIPLPC { get; private set; }

	public FDJAIONEJKM NDGDIONKNJF
	{
		get
		{
			return (!EEPEOANKBML) ? JEFGIMHJPEO : BIHDLEDFBGN;
		}
	}

	public static WaitForSeconds ANOHPAIFLCI
	{
		get
		{
			return (!MCJHHDACJBG.NDNBMGMPBLF) ? MCJHHDACJBG.DBKEKNNJLNO : MCJHHDACJBG.KNLADMIBAAD;
		}
	}

	public PHHKFLHAFHG()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "CloudService is initialized.");
		HDKJPHIPLPC = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM > 0;
		JEFGIMHJPEO = new FDJAIONEJKM();
		BIHDLEDFBGN = new FDJAIONEJKM();
		if (HDKJPHIPLPC)
		{
			NAAGDFCLOPE.GABGKBAKHDP.LMGDDIIJMHF("CloudUser", BHMJDMDKBCL);
			return;
		}
		NAAGDFCLOPE.GABGKBAKHDP.LMGDDIIJMHF("CloudUser", PANBGLOOMOC);
		OLDFNGMFPCJ = new LLCJMMBBLEH(LBMBDEFHPPA(), true, IAJNLGPHGLO.App);
	}

	public void MPDFGODOLAF()
	{
		string text = BNLJIDNCLPM();
		if (text != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Update cloud data on user change: {0}", text);
			if (OLDFNGMFPCJ != null)
			{
				OLDFNGMFPCJ.BPPFBMCJOAH();
			}
			NAAGDFCLOPE.GABGKBAKHDP.EGGICLINDJH("CloudUser", text);
		}
	}

	public void FJHHIDCICNG()
	{
		EEPEOANKBML = !EEPEOANKBML;
	}

	public static void PEDBOELHCPG()
	{
		NAAGDFCLOPE.GABGKBAKHDP.EGGICLINDJH("CloudUser", string.Empty);
	}

	private static void BHMJDMDKBCL(string MBBPBGHKLJM)
	{
		if (!string.IsNullOrEmpty(MBBPBGHKLJM))
		{
			AFJPGLHKOID.CPIGOAGGLBM("CloudBackup", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		}
	}

	private void PANBGLOOMOC(string MBBPBGHKLJM)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Cloud data is received: {0}", MBBPBGHKLJM);
		if (OLDFNGMFPCJ != null)
		{
			OLDFNGMFPCJ.BPPFBMCJOAH();
		}
		KLHAEAEALGM(MBBPBGHKLJM);
		ELMOKNPKLFE();
	}

	private void KLHAEAEALGM(string MBBPBGHKLJM)
	{
		try
		{
			string[] array = MBBPBGHKLJM.Split(':');
			EEPEOANKBML = "fb" == array[0];
			JEFGIMHJPEO = new FDJAIONEJKM(array[1], array[2]);
			BIHDLEDFBGN = new FDJAIONEJKM(array[3], array[4], array[5]);
			if (EEPEOANKBML && JEFGIMHJPEO.NAFCDEECGEF)
			{
				LECPGNKOABP.GABGKBAKHDP.BKPHBOCNCGO = JEFGIMHJPEO.GDMECFECCOM.ToString();
				LECPGNKOABP.GABGKBAKHDP.DBMLEMDDNCE = JEFGIMHJPEO.AJIFKBCELCA;
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.NativeToolsSupport, "Exception on parsing cloud data: {0}", ex.Message);
		}
	}

	private IEnumerator LBMBDEFHPPA()
	{
		if (!HDKJPHIPLPC)
		{
			yield return ANOHPAIFLCI;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "CloudService read data is timeouted.");
			ELMOKNPKLFE();
		}
	}

	private void ELMOKNPKLFE()
	{
		HDKJPHIPLPC = true;
		if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM <= 0)
		{
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new AEJCEEFPJIA()
			});
		}
	}

	private string BNLJIDNCLPM()
	{
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (lECPGNKOABP.GDMECFECCOM <= 0)
		{
			return null;
		}
		string text = lECPGNKOABP.BKPHBOCNCGO;
		string text2 = lECPGNKOABP.DBMLEMDDNCE;
		bool flag = lECPGNKOABP.EHNKLBBAKCA != null || text != null;
		string value = ((!flag) ? string.Empty : "fb");
		string text3 = JEFGIMHJPEO.GDMECFECCOM.ToString();
		string value2 = JEFGIMHJPEO.AJIFKBCELCA;
		string text4 = BIHDLEDFBGN.GDMECFECCOM.ToString();
		string value3 = BIHDLEDFBGN.AJIFKBCELCA;
		string value4 = BIHDLEDFBGN.EHNKLBBAKCA;
		if (flag)
		{
			text4 = lECPGNKOABP.GDMECFECCOM.ToString();
			value3 = lECPGNKOABP.FIPPLABNDON;
			value4 = lECPGNKOABP.EHNKLBBAKCA;
			if (text != null)
			{
				text3 = text;
			}
			if (text2 != null)
			{
				value2 = text2;
			}
		}
		else
		{
			text3 = lECPGNKOABP.GDMECFECCOM.ToString();
			value2 = lECPGNKOABP.FIPPLABNDON;
		}
		if (!flag && text4 == text3)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value).Append(':').Append(text3)
			.Append(':')
			.Append(value2)
			.Append(':')
			.Append(text4)
			.Append(':')
			.Append(value3)
			.Append(':')
			.Append(value4);
		return stringBuilder.ToString();
	}
}
