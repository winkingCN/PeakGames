using System;
using System.IO;
using System.Text;

public sealed class CIOOBJICIFI
{
	private static readonly string IAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;

	private const string FFAPKGOLBBL = "    ";

	private const int MJGKAMCOFEE = 32;

	private CIOOBJICIFI()
	{
	}

	private static void ONBGDIHNPHI(string DCBFAFMLPPJ, bool PLIDHCHODGK, EDOEBJJFOBM NEMEKIOEOLC, StringBuilder GHPCHPOHELF)
	{
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			string text = DCBFAFMLPPJ + "    ";
			GHPCHPOHELF.Append(DCBFAFMLPPJ);
			if (NEMEKIOEOLC is KBOHOKHJFBA)
			{
				GHPCHPOHELF.Append("BER Sequence");
			}
			else if (NEMEKIOEOLC is KOGPLMALOEH)
			{
				GHPCHPOHELF.Append("DER Sequence");
			}
			else
			{
				GHPCHPOHELF.Append("Sequence");
			}
			GHPCHPOHELF.Append(IAHDCIONPPF);
			{
				foreach (LNKPCJLANAO item in (ALLINHNNNJN)NEMEKIOEOLC)
				{
					if (item == null || item is OIONBALGCNP)
					{
						GHPCHPOHELF.Append(text);
						GHPCHPOHELF.Append("NULL");
						GHPCHPOHELF.Append(IAHDCIONPPF);
					}
					else
					{
						ONBGDIHNPHI(text, PLIDHCHODGK, item.IIHKEACDNID(), GHPCHPOHELF);
					}
				}
				return;
			}
		}
		if (NEMEKIOEOLC is JIHIOOKBBLB)
		{
			string text2 = DCBFAFMLPPJ + "    ";
			GHPCHPOHELF.Append(DCBFAFMLPPJ);
			if (NEMEKIOEOLC is FOGPHMBLIMH)
			{
				GHPCHPOHELF.Append("BER Tagged [");
			}
			else
			{
				GHPCHPOHELF.Append("Tagged [");
			}
			JIHIOOKBBLB jIHIOOKBBLB = (JIHIOOKBBLB)NEMEKIOEOLC;
			GHPCHPOHELF.Append(jIHIOOKBBLB.JPBIKBDCEKC.ToString());
			GHPCHPOHELF.Append(']');
			if (!jIHIOOKBBLB.PEMPMPFCPFN())
			{
				GHPCHPOHELF.Append(" IMPLICIT ");
			}
			GHPCHPOHELF.Append(IAHDCIONPPF);
			if (jIHIOOKBBLB.DHIKCKFGKID())
			{
				GHPCHPOHELF.Append(text2);
				GHPCHPOHELF.Append("EMPTY");
				GHPCHPOHELF.Append(IAHDCIONPPF);
			}
			else
			{
				ONBGDIHNPHI(text2, PLIDHCHODGK, jIHIOOKBBLB.NFMFKPLPLLH(), GHPCHPOHELF);
			}
			return;
		}
		if (NEMEKIOEOLC is ACMLPNKIJPN)
		{
			string text3 = DCBFAFMLPPJ + "    ";
			GHPCHPOHELF.Append(DCBFAFMLPPJ);
			GHPCHPOHELF.Append("BER Set");
			GHPCHPOHELF.Append(IAHDCIONPPF);
			{
				foreach (LNKPCJLANAO item2 in (FAGODOKGMEH)NEMEKIOEOLC)
				{
					if (item2 == null)
					{
						GHPCHPOHELF.Append(text3);
						GHPCHPOHELF.Append("NULL");
						GHPCHPOHELF.Append(IAHDCIONPPF);
					}
					else
					{
						ONBGDIHNPHI(text3, PLIDHCHODGK, item2.IIHKEACDNID(), GHPCHPOHELF);
					}
				}
				return;
			}
		}
		if (NEMEKIOEOLC is CDHAHIDPGBP)
		{
			string text4 = DCBFAFMLPPJ + "    ";
			GHPCHPOHELF.Append(DCBFAFMLPPJ);
			GHPCHPOHELF.Append("DER Set");
			GHPCHPOHELF.Append(IAHDCIONPPF);
			{
				foreach (LNKPCJLANAO item3 in (FAGODOKGMEH)NEMEKIOEOLC)
				{
					if (item3 == null)
					{
						GHPCHPOHELF.Append(text4);
						GHPCHPOHELF.Append("NULL");
						GHPCHPOHELF.Append(IAHDCIONPPF);
					}
					else
					{
						ONBGDIHNPHI(text4, PLIDHCHODGK, item3.IIHKEACDNID(), GHPCHPOHELF);
					}
				}
				return;
			}
		}
		if (NEMEKIOEOLC is KLKJHFKJLEM)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "ObjectIdentifier(" + ((KLKJHFKJLEM)NEMEKIOEOLC).EEFMIHDPJPG + ")" + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is PNKAJJJPEPA)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "Boolean(" + ((PNKAJJJPEPA)NEMEKIOEOLC).ELAOLKPILED + ")" + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is GLFDIPNOLKN)
		{
			GHPCHPOHELF.Append(string.Concat(DCBFAFMLPPJ, "Integer(", ((GLFDIPNOLKN)NEMEKIOEOLC).JBGOANMLBFA, ")", IAHDCIONPPF));
		}
		else if (NEMEKIOEOLC is OHNBHCLIOEI)
		{
			byte[] array = ((PJGIGKJFGFI)NEMEKIOEOLC).KLHNEKMCKKI();
			string text5 = ((!PLIDHCHODGK) ? string.Empty : ELNPNKELODC(DCBFAFMLPPJ, array));
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "BER Octet String[" + array.Length + "] " + text5 + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is CFMJBFILJCB)
		{
			byte[] array2 = ((PJGIGKJFGFI)NEMEKIOEOLC).KLHNEKMCKKI();
			string text6 = ((!PLIDHCHODGK) ? string.Empty : ELNPNKELODC(DCBFAFMLPPJ, array2));
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "DER Octet String[" + array2.Length + "] " + text6 + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is FJMKMKNJKOI)
		{
			FJMKMKNJKOI fJMKMKNJKOI = (FJMKMKNJKOI)NEMEKIOEOLC;
			byte[] array3 = fJMKMKNJKOI.MIBPLNJNEGA();
			string text7 = ((!PLIDHCHODGK) ? string.Empty : ELNPNKELODC(DCBFAFMLPPJ, array3));
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "DER Bit String[" + array3.Length + ", " + fJMKMKNJKOI.KOHPFEHKIPK + "] " + text7 + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is KCKEFHLLGIO)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "IA5String(" + ((KCKEFHLLGIO)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is GKCJIKGJBJA)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "UTF8String(" + ((GKCJIKGJBJA)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is JLGEDJAOAIJ)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "PrintableString(" + ((JLGEDJAOAIJ)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is EKOPFPAFGJO)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "VisibleString(" + ((EKOPFPAFGJO)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is GFMDJNIDEDM)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "BMPString(" + ((GFMDJNIDEDM)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is KLJAEMAGFDL)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "T61String(" + ((KLJAEMAGFDL)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is NKGGMLLJNEJ)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "GraphicString(" + ((NKGGMLLJNEJ)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is MNJEPIOLBFG)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "VideotexString(" + ((MNJEPIOLBFG)NEMEKIOEOLC).JDANMONKNGD() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is ECAOIPMOFLJ)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "UTCTime(" + ((ECAOIPMOFLJ)NEMEKIOEOLC).HHNHEBFACPL + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is DHKNJKJFPIP)
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "GeneralizedTime(" + ((DHKNJKJFPIP)NEMEKIOEOLC).FPLOJBLADJG() + ") " + IAHDCIONPPF);
		}
		else if (NEMEKIOEOLC is IPJAJPAKCDB)
		{
			GHPCHPOHELF.Append(IBENDGAFICG("BER", DCBFAFMLPPJ, PLIDHCHODGK, (IPJAJPAKCDB)NEMEKIOEOLC));
		}
		else if (NEMEKIOEOLC is PDDLHBNCLNM)
		{
			GHPCHPOHELF.Append(IBENDGAFICG("DER", DCBFAFMLPPJ, PLIDHCHODGK, (PDDLHBNCLNM)NEMEKIOEOLC));
		}
		else if (NEMEKIOEOLC is DLICBBHNDFH)
		{
			DLICBBHNDFH dLICBBHNDFH = (DLICBBHNDFH)NEMEKIOEOLC;
			GHPCHPOHELF.Append(string.Concat(DCBFAFMLPPJ, "DER Enumerated(", dLICBBHNDFH.JBGOANMLBFA, ")", IAHDCIONPPF));
		}
		else if (NEMEKIOEOLC is EKNLINDFMIM)
		{
			EKNLINDFMIM eKNLINDFMIM = (EKNLINDFMIM)NEMEKIOEOLC;
			GHPCHPOHELF.Append(DCBFAFMLPPJ + "External " + IAHDCIONPPF);
			string text8 = DCBFAFMLPPJ + "    ";
			if (eKNLINDFMIM.OCMOGHEOBBJ != null)
			{
				GHPCHPOHELF.Append(text8 + "Direct Reference: " + eKNLINDFMIM.OCMOGHEOBBJ.EEFMIHDPJPG + IAHDCIONPPF);
			}
			if (eKNLINDFMIM.MDAENJIDOMD != null)
			{
				GHPCHPOHELF.Append(text8 + "Indirect Reference: " + eKNLINDFMIM.MDAENJIDOMD.ToString() + IAHDCIONPPF);
			}
			if (eKNLINDFMIM.HDADBHNCPBE != null)
			{
				ONBGDIHNPHI(text8, PLIDHCHODGK, eKNLINDFMIM.HDADBHNCPBE, GHPCHPOHELF);
			}
			GHPCHPOHELF.Append(text8 + "Encoding: " + eKNLINDFMIM.HBAGPBEDGLH + IAHDCIONPPF);
			ONBGDIHNPHI(text8, PLIDHCHODGK, eKNLINDFMIM.HBNJBGDAPAH, GHPCHPOHELF);
		}
		else
		{
			GHPCHPOHELF.Append(DCBFAFMLPPJ + NEMEKIOEOLC.ToString() + IAHDCIONPPF);
		}
	}

	private static string IBENDGAFICG(string NBFBPNNEKMN, string DCBFAFMLPPJ, bool PLIDHCHODGK, PDDLHBNCLNM MJLIPMLIDHH)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (MJLIPMLIDHH.FHAFCOLHFPD())
		{
			try
			{
				ALLINHNNNJN aLLINHNNNJN = ALLINHNNNJN.BJLJCGFMFOO(MJLIPMLIDHH.NFMFKPLPLLH(16));
				stringBuilder.Append(DCBFAFMLPPJ + NBFBPNNEKMN + " ApplicationSpecific[" + MJLIPMLIDHH.IDDOGOEKBPN + "]" + IAHDCIONPPF);
				foreach (LNKPCJLANAO item in aLLINHNNNJN)
				{
					ONBGDIHNPHI(DCBFAFMLPPJ + "    ", PLIDHCHODGK, item.IIHKEACDNID(), stringBuilder);
				}
			}
			catch (IOException value)
			{
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return DCBFAFMLPPJ + NBFBPNNEKMN + " ApplicationSpecific[" + MJLIPMLIDHH.IDDOGOEKBPN + "] (" + DCDJMDOEKHC.ALIGGGKEJEN(MJLIPMLIDHH.EPCAJJBBAMO()) + ")" + IAHDCIONPPF;
	}

	[Obsolete("Use version accepting Asn1Encodable")]
	public static string AOLOOAAFAIH(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC is LNKPCJLANAO)
		{
			StringBuilder stringBuilder = new StringBuilder();
			ONBGDIHNPHI(string.Empty, false, ((LNKPCJLANAO)NEMEKIOEOLC).IIHKEACDNID(), stringBuilder);
			return stringBuilder.ToString();
		}
		return "unknown object type " + NEMEKIOEOLC.ToString();
	}

	public static string AOLOOAAFAIH(LNKPCJLANAO NEMEKIOEOLC)
	{
		return AOLOOAAFAIH(NEMEKIOEOLC, false);
	}

	public static string AOLOOAAFAIH(LNKPCJLANAO NEMEKIOEOLC, bool PLIDHCHODGK)
	{
		StringBuilder stringBuilder = new StringBuilder();
		ONBGDIHNPHI(string.Empty, PLIDHCHODGK, NEMEKIOEOLC.IIHKEACDNID(), stringBuilder);
		return stringBuilder.ToString();
	}

	private static string ELNPNKELODC(string DCBFAFMLPPJ, byte[] DIPNEDDIHBK)
	{
		DCBFAFMLPPJ += "    ";
		StringBuilder stringBuilder = new StringBuilder(IAHDCIONPPF);
		for (int i = 0; i < DIPNEDDIHBK.Length; i += 32)
		{
			if (DIPNEDDIHBK.Length - i > 32)
			{
				stringBuilder.Append(DCBFAFMLPPJ);
				stringBuilder.Append(DCDJMDOEKHC.ALIGGGKEJEN(DIPNEDDIHBK, i, 32));
				stringBuilder.Append("    ");
				stringBuilder.Append(HMJNOBHALDD(DIPNEDDIHBK, i, 32));
				stringBuilder.Append(IAHDCIONPPF);
				continue;
			}
			stringBuilder.Append(DCBFAFMLPPJ);
			stringBuilder.Append(DCDJMDOEKHC.ALIGGGKEJEN(DIPNEDDIHBK, i, DIPNEDDIHBK.Length - i));
			for (int j = DIPNEDDIHBK.Length - i; j != 32; j++)
			{
				stringBuilder.Append("  ");
			}
			stringBuilder.Append("    ");
			stringBuilder.Append(HMJNOBHALDD(DIPNEDDIHBK, i, DIPNEDDIHBK.Length - i));
			stringBuilder.Append(IAHDCIONPPF);
		}
		return stringBuilder.ToString();
	}

	private static string HMJNOBHALDD(byte[] DIPNEDDIHBK, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = JBAJPGIAPFF; i != JBAJPGIAPFF + NBEDPKHALCN; i++)
		{
			char c = (char)DIPNEDDIHBK[i];
			if (c >= ' ' && c <= '~')
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}
}
