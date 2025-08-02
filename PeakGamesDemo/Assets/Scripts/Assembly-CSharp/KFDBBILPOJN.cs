using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Spine;

public class KFDBBILPOJN
{
	internal class KLGJNBPGLAB
	{
		public int[] LIKIOBHLHHF;

		public float[] FHBFCAEGPOH;
	}

	public const int HFFDOOHBKBA = 0;

	public const int NPDMMJKAFGN = 1;

	public const int KJLFCFCNLLE = 2;

	public const int AENGFBCPEHL = 3;

	public const int OINFLILMBHF = 0;

	public const int ICJEOLDFFND = 1;

	public const int OHHKKOMMMAA = 2;

	public const int FIPPDEDMCKH = 0;

	public const int BEDBEFJCBKM = 1;

	public const int KKHHONGMJIG = 2;

	public const int FPEDCLOALPD = 0;

	public const int HCKHONFPKEG = 1;

	public const int EKEAHDJJEKG = 2;

	private EDENIAPLFEN JHLKFNEOEBO;

	private byte[] DJDKLOJBJCO = new byte[32];

	private List<JCHLDDECFJF.PHEALEKBPIF> HHDLADPAMIO = new List<JCHLDDECFJF.PHEALEKBPIF>();

	public static readonly NGPCELMDKGK[] MMJPOHGNPKO = new NGPCELMDKGK[5]
	{
		NGPCELMDKGK.Normal,
		NGPCELMDKGK.OnlyTranslation,
		NGPCELMDKGK.NoRotationOrReflection,
		NGPCELMDKGK.NoScale,
		NGPCELMDKGK.NoScaleOrReflection
	};

	public float GEBNMKAGJIG { get; set; }

	public KFDBBILPOJN(params GFNFFCGAGEH[] ANMHLKGBNIP)
		: this(new JKAOAAMMPPH(ANMHLKGBNIP))
	{
	}

	public KFDBBILPOJN(EDENIAPLFEN JHLKFNEOEBO)
	{
		if (JHLKFNEOEBO == null)
		{
			throw new ArgumentNullException("attachmentLoader");
		}
		this.JHLKFNEOEBO = JHLKFNEOEBO;
		GEBNMKAGJIG = 1f;
	}

	public KGMHJGFNPFC FDOJFCCGLKM(string LCCKDPIBKPJ)
	{
		using (FileStream mOPCLEEGDFB = new FileStream(LCCKDPIBKPJ, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			KGMHJGFNPFC kGMHJGFNPFC = FDOJFCCGLKM(mOPCLEEGDFB);
			kGMHJGFNPFC.IOCMOCCFALN = Path.GetFileNameWithoutExtension(LCCKDPIBKPJ);
			return kGMHJGFNPFC;
		}
	}

	public static string OJOGJGJLKHA(Stream MOPCLEEGDFB)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		try
		{
			int num = ONGMGLIAIPK(MOPCLEEGDFB, true);
			if (num > 1)
			{
				MOPCLEEGDFB.Position += num - 1;
			}
			num = ONGMGLIAIPK(MOPCLEEGDFB, true);
			if (num > 1)
			{
				num--;
				byte[] array = new byte[num];
				PCNDKGFHPJN(MOPCLEEGDFB, array, 0, num);
				return Encoding.UTF8.GetString(array, 0, num);
			}
			throw new ArgumentException("Stream does not contain a valid binary Skeleton Data.", "input");
		}
		catch (Exception ex)
		{
			throw new ArgumentException("Stream does not contain a valid binary Skeleton Data.\n" + ex, "input");
		}
	}

	public KGMHJGFNPFC FDOJFCCGLKM(Stream MOPCLEEGDFB)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		float num = GEBNMKAGJIG;
		KGMHJGFNPFC kGMHJGFNPFC = new KGMHJGFNPFC();
		kGMHJGFNPFC.AIELCDIFLFB = HKEMOEMPHAP(MOPCLEEGDFB);
		if (kGMHJGFNPFC.AIELCDIFLFB.Length == 0)
		{
			kGMHJGFNPFC.AIELCDIFLFB = null;
		}
		kGMHJGFNPFC.DFCJKBHFPMG = HKEMOEMPHAP(MOPCLEEGDFB);
		if (kGMHJGFNPFC.DFCJKBHFPMG.Length == 0)
		{
			kGMHJGFNPFC.DFCJKBHFPMG = null;
		}
		kGMHJGFNPFC.HHHMOGOKFHF = BDGODEAFONI(MOPCLEEGDFB);
		kGMHJGFNPFC.JKNPBEOPMPK = BDGODEAFONI(MOPCLEEGDFB);
		bool flag = HLGIJNJPLCP(MOPCLEEGDFB);
		if (flag)
		{
			kGMHJGFNPFC.IMFECEPMNNP = BDGODEAFONI(MOPCLEEGDFB);
			kGMHJGFNPFC.LIIPMIDHPEP = HKEMOEMPHAP(MOPCLEEGDFB);
			if (kGMHJGFNPFC.LIIPMIDHPEP.Length == 0)
			{
				kGMHJGFNPFC.LIIPMIDHPEP = null;
			}
		}
		int i = 0;
		for (int num2 = ONGMGLIAIPK(MOPCLEEGDFB, true); i < num2; i++)
		{
			string iOCMOCCFALN = HKEMOEMPHAP(MOPCLEEGDFB);
			GPJIPDIEIIL lIMMFGDCLAB = ((i != 0) ? kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)] : null);
			GPJIPDIEIIL gPJIPDIEIIL = new GPJIPDIEIIL(i, iOCMOCCFALN, lIMMFGDCLAB);
			gPJIPDIEIIL.ODLHFMOPCHL = BDGODEAFONI(MOPCLEEGDFB);
			gPJIPDIEIIL.AMFCENFNAJJ = BDGODEAFONI(MOPCLEEGDFB) * num;
			gPJIPDIEIIL.CNLILOEEBOJ = BDGODEAFONI(MOPCLEEGDFB) * num;
			gPJIPDIEIIL.IAFNPOKEFMB = BDGODEAFONI(MOPCLEEGDFB);
			gPJIPDIEIIL.GFMCPIJHIGD = BDGODEAFONI(MOPCLEEGDFB);
			gPJIPDIEIIL.BALNAGONJDA = BDGODEAFONI(MOPCLEEGDFB);
			gPJIPDIEIIL.DADFBNMBFCD = BDGODEAFONI(MOPCLEEGDFB);
			gPJIPDIEIIL.EOFAGACBNFP = BDGODEAFONI(MOPCLEEGDFB) * num;
			gPJIPDIEIIL.OJOPJNBLHLO = MMJPOHGNPKO[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			if (flag)
			{
				AFDPGPBDKLH(MOPCLEEGDFB);
			}
			kGMHJGFNPFC.LIKIOBHLHHF.JEACJNAKLDJ(gPJIPDIEIIL);
		}
		int j = 0;
		for (int num3 = ONGMGLIAIPK(MOPCLEEGDFB, true); j < num3; j++)
		{
			string iOCMOCCFALN2 = HKEMOEMPHAP(MOPCLEEGDFB);
			GPJIPDIEIIL jJLEOELOOJP = kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			HMGLMNHOBHA hMGLMNHOBHA = new HMGLMNHOBHA(j, iOCMOCCFALN2, jJLEOELOOJP);
			int num4 = AFDPGPBDKLH(MOPCLEEGDFB);
			hMGLMNHOBHA.GPGDCCMECGF = (float)((num4 & 0xFF000000u) >> 24) / 255f;
			hMGLMNHOBHA.HJMBDGKAOBP = (float)((num4 & 0xFF0000) >> 16) / 255f;
			hMGLMNHOBHA.BCIHLCMFAEK = (float)((num4 & 0xFF00) >> 8) / 255f;
			hMGLMNHOBHA.MNIMEAMHNMI = (float)(num4 & 0xFF) / 255f;
			int num5 = AFDPGPBDKLH(MOPCLEEGDFB);
			if (num5 != -1)
			{
				hMGLMNHOBHA.CKPBGCMIIJL = true;
				hMGLMNHOBHA.FHPFAEDHEGG = (float)((num5 & 0xFF0000) >> 16) / 255f;
				hMGLMNHOBHA.AONHFIBNFLD = (float)((num5 & 0xFF00) >> 8) / 255f;
				hMGLMNHOBHA.DLGDBCBCIED = (float)(num5 & 0xFF) / 255f;
			}
			hMGLMNHOBHA.FKAJNAAKEFH = HKEMOEMPHAP(MOPCLEEGDFB);
			hMGLMNHOBHA.DNLHLBINHHE = (AOOPCGDMICP)ONGMGLIAIPK(MOPCLEEGDFB, true);
			kGMHJGFNPFC.MAKCMFCFDLP.JEACJNAKLDJ(hMGLMNHOBHA);
		}
		int k = 0;
		for (int num6 = ONGMGLIAIPK(MOPCLEEGDFB, true); k < num6; k++)
		{
			BMELPEKHKKJ bMELPEKHKKJ = new BMELPEKHKKJ(HKEMOEMPHAP(MOPCLEEGDFB));
			bMELPEKHKKJ.CMAJLIAELDP = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int l = 0;
			for (int num7 = ONGMGLIAIPK(MOPCLEEGDFB, true); l < num7; l++)
			{
				bMELPEKHKKJ.LIKIOBHLHHF.Add(kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)]);
			}
			bMELPEKHKKJ.CAEMELGEOAE = kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			bMELPEKHKKJ.MIIHPKNIPAB = BDGODEAFONI(MOPCLEEGDFB);
			bMELPEKHKKJ.IEFNLGDAINN = DGBALGMOMKK(MOPCLEEGDFB);
			kGMHJGFNPFC.EFIPDNFLFND.JEACJNAKLDJ(bMELPEKHKKJ);
		}
		int m = 0;
		for (int num8 = ONGMGLIAIPK(MOPCLEEGDFB, true); m < num8; m++)
		{
			MNNBOEPCJGP mNNBOEPCJGP = new MNNBOEPCJGP(HKEMOEMPHAP(MOPCLEEGDFB));
			mNNBOEPCJGP.CMAJLIAELDP = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int n = 0;
			for (int num9 = ONGMGLIAIPK(MOPCLEEGDFB, true); n < num9; n++)
			{
				mNNBOEPCJGP.LIKIOBHLHHF.JEACJNAKLDJ(kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)]);
			}
			mNNBOEPCJGP.CAEMELGEOAE = kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			mNNBOEPCJGP.ACIIIFFOMEC = HLGIJNJPLCP(MOPCLEEGDFB);
			mNNBOEPCJGP.JKBPDGBLPNO = HLGIJNJPLCP(MOPCLEEGDFB);
			mNNBOEPCJGP.HCFAKEOFMPM = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.MLKPDGNHNAE = BDGODEAFONI(MOPCLEEGDFB) * num;
			mNNBOEPCJGP.INDIJOFPNGA = BDGODEAFONI(MOPCLEEGDFB) * num;
			mNNBOEPCJGP.LEDJLEBCJCH = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.LCELCEPDPAB = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.HJKFDFKINDC = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.OIBAIJIPGOM = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.DHNKOEMONHP = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.DLEIMBNDMOF = BDGODEAFONI(MOPCLEEGDFB);
			mNNBOEPCJGP.OKJBKNEPKPN = BDGODEAFONI(MOPCLEEGDFB);
			kGMHJGFNPFC.FOANDHFONAA.JEACJNAKLDJ(mNNBOEPCJGP);
		}
		int num10 = 0;
		for (int num11 = ONGMGLIAIPK(MOPCLEEGDFB, true); num10 < num11; num10++)
		{
			GJNEKNOKICF gJNEKNOKICF = new GJNEKNOKICF(HKEMOEMPHAP(MOPCLEEGDFB));
			gJNEKNOKICF.CMAJLIAELDP = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int num12 = 0;
			for (int num13 = ONGMGLIAIPK(MOPCLEEGDFB, true); num12 < num13; num12++)
			{
				gJNEKNOKICF.LIKIOBHLHHF.JEACJNAKLDJ(kGMHJGFNPFC.LIKIOBHLHHF.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)]);
			}
			gJNEKNOKICF.CAEMELGEOAE = kGMHJGFNPFC.MAKCMFCFDLP.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			gJNEKNOKICF.FMJFEKINFLF = (KMDGGFDOOPL)Enum.GetValues(typeof(KMDGGFDOOPL)).GetValue(ONGMGLIAIPK(MOPCLEEGDFB, true));
			gJNEKNOKICF.ENMOCNJMBKD = (OIGFPANDDIM)Enum.GetValues(typeof(OIGFPANDDIM)).GetValue(ONGMGLIAIPK(MOPCLEEGDFB, true));
			gJNEKNOKICF.HCNEABGHJMH = (NOKBMFOFOMJ)Enum.GetValues(typeof(NOKBMFOFOMJ)).GetValue(ONGMGLIAIPK(MOPCLEEGDFB, true));
			gJNEKNOKICF.HCFAKEOFMPM = BDGODEAFONI(MOPCLEEGDFB);
			gJNEKNOKICF.LDMDBPLADGD = BDGODEAFONI(MOPCLEEGDFB);
			if (gJNEKNOKICF.FMJFEKINFLF == KMDGGFDOOPL.Fixed)
			{
				gJNEKNOKICF.LDMDBPLADGD *= num;
			}
			gJNEKNOKICF.ILNOGLMCFMC = BDGODEAFONI(MOPCLEEGDFB);
			if (gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Length || gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Fixed)
			{
				gJNEKNOKICF.ILNOGLMCFMC *= num;
			}
			gJNEKNOKICF.OIBAIJIPGOM = BDGODEAFONI(MOPCLEEGDFB);
			gJNEKNOKICF.DHNKOEMONHP = BDGODEAFONI(MOPCLEEGDFB);
			kGMHJGFNPFC.NDOOCKKIMHO.JEACJNAKLDJ(gJNEKNOKICF);
		}
		JPAALKCPGNB jPAALKCPGNB = FGAKCCABEDL(MOPCLEEGDFB, kGMHJGFNPFC, "default", flag);
		if (jPAALKCPGNB != null)
		{
			kGMHJGFNPFC.NAKPPHNCJOC = jPAALKCPGNB;
			kGMHJGFNPFC.CFPBCLCKDBM.JEACJNAKLDJ(jPAALKCPGNB);
		}
		int num14 = 0;
		for (int num15 = ONGMGLIAIPK(MOPCLEEGDFB, true); num14 < num15; num14++)
		{
			kGMHJGFNPFC.CFPBCLCKDBM.JEACJNAKLDJ(FGAKCCABEDL(MOPCLEEGDFB, kGMHJGFNPFC, HKEMOEMPHAP(MOPCLEEGDFB), flag));
		}
		int num16 = 0;
		for (int count = HHDLADPAMIO.Count; num16 < count; num16++)
		{
			JCHLDDECFJF.PHEALEKBPIF pHEALEKBPIF = HHDLADPAMIO[num16];
			JPAALKCPGNB jPAALKCPGNB2 = ((pHEALEKBPIF.HLCFGIFLPPE != null) ? kGMHJGFNPFC.COONIJFPADF(pHEALEKBPIF.HLCFGIFLPPE) : kGMHJGFNPFC.IBBFJANAMLO);
			if (jPAALKCPGNB2 == null)
			{
				throw new Exception("Skin not found: " + pHEALEKBPIF.HLCFGIFLPPE);
			}
			OAMNGFLKEFI oAMNGFLKEFI = jPAALKCPGNB2.JGHJDGIANDD(pHEALEKBPIF.PBPEMFGPGFC, pHEALEKBPIF.LIMMFGDCLAB);
			if (oAMNGFLKEFI == null)
			{
				throw new Exception("Parent mesh not found: " + pHEALEKBPIF.LIMMFGDCLAB);
			}
			pHEALEKBPIF.IJKCGGPJDIG.EJEBCFHLAFF = (MGCLDKAFCIB)oAMNGFLKEFI;
			pHEALEKBPIF.IJKCGGPJDIG.IFAIOMLBIAD();
		}
		HHDLADPAMIO.Clear();
		int num17 = 0;
		for (int num18 = ONGMGLIAIPK(MOPCLEEGDFB, true); num17 < num18; num17++)
		{
			MDBINBLMHMC mDBINBLMHMC = new MDBINBLMHMC(HKEMOEMPHAP(MOPCLEEGDFB));
			mDBINBLMHMC.IOCBLKCOMGI = ONGMGLIAIPK(MOPCLEEGDFB, false);
			mDBINBLMHMC.NCGJMNFFOJH = BDGODEAFONI(MOPCLEEGDFB);
			mDBINBLMHMC.BECLAMGPAGN = HKEMOEMPHAP(MOPCLEEGDFB);
			kGMHJGFNPFC.NJOHMGMPGBE.JEACJNAKLDJ(mDBINBLMHMC);
		}
		int num19 = 0;
		for (int num20 = ONGMGLIAIPK(MOPCLEEGDFB, true); num19 < num20; num19++)
		{
			FKKGMNDHEIP(HKEMOEMPHAP(MOPCLEEGDFB), MOPCLEEGDFB, kGMHJGFNPFC);
		}
		kGMHJGFNPFC.LIKIOBHLHHF.PBHLDFFHPND();
		kGMHJGFNPFC.MAKCMFCFDLP.PBHLDFFHPND();
		kGMHJGFNPFC.CFPBCLCKDBM.PBHLDFFHPND();
		kGMHJGFNPFC.NJOHMGMPGBE.PBHLDFFHPND();
		kGMHJGFNPFC.BNLBLHNEJAH.PBHLDFFHPND();
		kGMHJGFNPFC.EFIPDNFLFND.PBHLDFFHPND();
		kGMHJGFNPFC.NDOOCKKIMHO.PBHLDFFHPND();
		return kGMHJGFNPFC;
	}

	private JPAALKCPGNB FGAKCCABEDL(Stream MOPCLEEGDFB, KGMHJGFNPFC DCMDAJJBNAI, string COKOMFOMBBA, bool OBAJJEJENJB)
	{
		int num = ONGMGLIAIPK(MOPCLEEGDFB, true);
		if (num == 0)
		{
			return null;
		}
		JPAALKCPGNB jPAALKCPGNB = new JPAALKCPGNB(COKOMFOMBBA);
		for (int i = 0; i < num; i++)
		{
			int pBPEMFGPGFC = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int j = 0;
			for (int num2 = ONGMGLIAIPK(MOPCLEEGDFB, true); j < num2; j++)
			{
				string text = HKEMOEMPHAP(MOPCLEEGDFB);
				OAMNGFLKEFI oAMNGFLKEFI = JNBDHGKGOJD(MOPCLEEGDFB, DCMDAJJBNAI, jPAALKCPGNB, pBPEMFGPGFC, text, OBAJJEJENJB);
				if (oAMNGFLKEFI != null)
				{
					jPAALKCPGNB.DJJIHPJOEBF(pBPEMFGPGFC, text, oAMNGFLKEFI);
				}
			}
		}
		return jPAALKCPGNB;
	}

	private OAMNGFLKEFI JNBDHGKGOJD(Stream MOPCLEEGDFB, KGMHJGFNPFC DCMDAJJBNAI, JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC, string FKAJNAAKEFH, bool OBAJJEJENJB)
	{
		float num = GEBNMKAGJIG;
		string text = HKEMOEMPHAP(MOPCLEEGDFB);
		if (text == null)
		{
			text = FKAJNAAKEFH;
		}
		switch ((KOAJPENAIBI)MOPCLEEGDFB.ReadByte())
		{
		case KOAJPENAIBI.Region:
		{
			string text2 = HKEMOEMPHAP(MOPCLEEGDFB);
			float oDLHFMOPCHL = BDGODEAFONI(MOPCLEEGDFB);
			float num4 = BDGODEAFONI(MOPCLEEGDFB);
			float num5 = BDGODEAFONI(MOPCLEEGDFB);
			float iAFNPOKEFMB = BDGODEAFONI(MOPCLEEGDFB);
			float gFMCPIJHIGD = BDGODEAFONI(MOPCLEEGDFB);
			float num6 = BDGODEAFONI(MOPCLEEGDFB);
			float num7 = BDGODEAFONI(MOPCLEEGDFB);
			int num8 = AFDPGPBDKLH(MOPCLEEGDFB);
			if (text2 == null)
			{
				text2 = text;
			}
			MKEALIMJCFJ mKEALIMJCFJ = JHLKFNEOEBO.HNCBJFIPJNP(HLCFGIFLPPE, text, text2);
			if (mKEALIMJCFJ == null)
			{
				return null;
			}
			mKEALIMJCFJ.MJCBDBIDMGF = text2;
			mKEALIMJCFJ.AMFCENFNAJJ = num4 * num;
			mKEALIMJCFJ.CNLILOEEBOJ = num5 * num;
			mKEALIMJCFJ.IAFNPOKEFMB = iAFNPOKEFMB;
			mKEALIMJCFJ.GFMCPIJHIGD = gFMCPIJHIGD;
			mKEALIMJCFJ.ODLHFMOPCHL = oDLHFMOPCHL;
			mKEALIMJCFJ.HHHMOGOKFHF = num6 * num;
			mKEALIMJCFJ.JKNPBEOPMPK = num7 * num;
			mKEALIMJCFJ.GPGDCCMECGF = (float)((num8 & 0xFF000000u) >> 24) / 255f;
			mKEALIMJCFJ.HJMBDGKAOBP = (float)((num8 & 0xFF0000) >> 16) / 255f;
			mKEALIMJCFJ.BCIHLCMFAEK = (float)((num8 & 0xFF00) >> 8) / 255f;
			mKEALIMJCFJ.MNIMEAMHNMI = (float)(num8 & 0xFF) / 255f;
			mKEALIMJCFJ.MNIMJDFOILP();
			return mKEALIMJCFJ;
		}
		case KOAJPENAIBI.Boundingbox:
		{
			int num21 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			KLGJNBPGLAB kLGJNBPGLAB4 = GHOFFCBHBGD(MOPCLEEGDFB, num21);
			if (OBAJJEJENJB)
			{
				AFDPGPBDKLH(MOPCLEEGDFB);
			}
			KBLNEHAAAJK kBLNEHAAAJK = JHLKFNEOEBO.KMGJEJLCPLE(HLCFGIFLPPE, text);
			if (kBLNEHAAAJK == null)
			{
				return null;
			}
			kBLNEHAAAJK.MCCBDCEJDBC = num21 << 1;
			kBLNEHAAAJK.FHBFCAEGPOH = kLGJNBPGLAB4.FHBFCAEGPOH;
			kBLNEHAAAJK.LIKIOBHLHHF = kLGJNBPGLAB4.LIKIOBHLHHF;
			return kBLNEHAAAJK;
		}
		case KOAJPENAIBI.Mesh:
		{
			string text3 = HKEMOEMPHAP(MOPCLEEGDFB);
			int num9 = AFDPGPBDKLH(MOPCLEEGDFB);
			int num10 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			float[] oJKLIMMHOEH = HPKOKKIHEEB(MOPCLEEGDFB, num10 << 1, 1f);
			int[] nPDGLMEOKIO = KLBILIBNEEP(MOPCLEEGDFB);
			KLGJNBPGLAB kLGJNBPGLAB2 = GHOFFCBHBGD(MOPCLEEGDFB, num10);
			int num11 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int[] eDDNOJDPMCF = null;
			float num12 = 0f;
			float num13 = 0f;
			if (OBAJJEJENJB)
			{
				eDDNOJDPMCF = KLBILIBNEEP(MOPCLEEGDFB);
				num12 = BDGODEAFONI(MOPCLEEGDFB);
				num13 = BDGODEAFONI(MOPCLEEGDFB);
			}
			if (text3 == null)
			{
				text3 = text;
			}
			MGCLDKAFCIB mGCLDKAFCIB = JHLKFNEOEBO.MPDDHGBKGCP(HLCFGIFLPPE, text, text3);
			if (mGCLDKAFCIB == null)
			{
				return null;
			}
			mGCLDKAFCIB.MJCBDBIDMGF = text3;
			mGCLDKAFCIB.GPGDCCMECGF = (float)((num9 & 0xFF000000u) >> 24) / 255f;
			mGCLDKAFCIB.HJMBDGKAOBP = (float)((num9 & 0xFF0000) >> 16) / 255f;
			mGCLDKAFCIB.BCIHLCMFAEK = (float)((num9 & 0xFF00) >> 8) / 255f;
			mGCLDKAFCIB.MNIMEAMHNMI = (float)(num9 & 0xFF) / 255f;
			mGCLDKAFCIB.LIKIOBHLHHF = kLGJNBPGLAB2.LIKIOBHLHHF;
			mGCLDKAFCIB.FHBFCAEGPOH = kLGJNBPGLAB2.FHBFCAEGPOH;
			mGCLDKAFCIB.DBIIHGFAGJP = num10 << 1;
			mGCLDKAFCIB.NPDGLMEOKIO = nPDGLMEOKIO;
			mGCLDKAFCIB.OJKLIMMHOEH = oJKLIMMHOEH;
			mGCLDKAFCIB.IFAIOMLBIAD();
			mGCLDKAFCIB.FMABFHBBBJG = num11 << 1;
			if (OBAJJEJENJB)
			{
				mGCLDKAFCIB.PEMDNNKKDPG = eDDNOJDPMCF;
				mGCLDKAFCIB.EMFKAPJMDCC = num12 * num;
				mGCLDKAFCIB.FHAMOHDEGMK = num13 * num;
			}
			return mGCLDKAFCIB;
		}
		case KOAJPENAIBI.Linkedmesh:
		{
			string text4 = HKEMOEMPHAP(MOPCLEEGDFB);
			int num14 = AFDPGPBDKLH(MOPCLEEGDFB);
			string hLCFGIFLPPE = HKEMOEMPHAP(MOPCLEEGDFB);
			string lIMMFGDCLAB = HKEMOEMPHAP(MOPCLEEGDFB);
			bool hMGOODNADED = HLGIJNJPLCP(MOPCLEEGDFB);
			float num15 = 0f;
			float num16 = 0f;
			if (OBAJJEJENJB)
			{
				num15 = BDGODEAFONI(MOPCLEEGDFB);
				num16 = BDGODEAFONI(MOPCLEEGDFB);
			}
			if (text4 == null)
			{
				text4 = text;
			}
			MGCLDKAFCIB mGCLDKAFCIB2 = JHLKFNEOEBO.MPDDHGBKGCP(HLCFGIFLPPE, text, text4);
			if (mGCLDKAFCIB2 == null)
			{
				return null;
			}
			mGCLDKAFCIB2.MJCBDBIDMGF = text4;
			mGCLDKAFCIB2.GPGDCCMECGF = (float)((num14 & 0xFF000000u) >> 24) / 255f;
			mGCLDKAFCIB2.HJMBDGKAOBP = (float)((num14 & 0xFF0000) >> 16) / 255f;
			mGCLDKAFCIB2.BCIHLCMFAEK = (float)((num14 & 0xFF00) >> 8) / 255f;
			mGCLDKAFCIB2.MNIMEAMHNMI = (float)(num14 & 0xFF) / 255f;
			mGCLDKAFCIB2.HMGOODNADED = hMGOODNADED;
			if (OBAJJEJENJB)
			{
				mGCLDKAFCIB2.EMFKAPJMDCC = num15 * num;
				mGCLDKAFCIB2.FHAMOHDEGMK = num16 * num;
			}
			HHDLADPAMIO.Add(new JCHLDDECFJF.PHEALEKBPIF(mGCLDKAFCIB2, hLCFGIFLPPE, PBPEMFGPGFC, lIMMFGDCLAB));
			return mGCLDKAFCIB2;
		}
		case KOAJPENAIBI.Path:
		{
			bool mBEOPLHLANP = HLGIJNJPLCP(MOPCLEEGDFB);
			bool iKJCHJGJKGH = HLGIJNJPLCP(MOPCLEEGDFB);
			int num17 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			KLGJNBPGLAB kLGJNBPGLAB3 = GHOFFCBHBGD(MOPCLEEGDFB, num17);
			float[] array = new float[num17 / 3];
			int i = 0;
			for (int num18 = array.Length; i < num18; i++)
			{
				array[i] = BDGODEAFONI(MOPCLEEGDFB) * num;
			}
			if (OBAJJEJENJB)
			{
				AFDPGPBDKLH(MOPCLEEGDFB);
			}
			GMLCOKFENFN gMLCOKFENFN = JHLKFNEOEBO.HAOODEOAMHH(HLCFGIFLPPE, text);
			if (gMLCOKFENFN == null)
			{
				return null;
			}
			gMLCOKFENFN.MBEOPLHLANP = mBEOPLHLANP;
			gMLCOKFENFN.IKJCHJGJKGH = iKJCHJGJKGH;
			gMLCOKFENFN.MCCBDCEJDBC = num17 << 1;
			gMLCOKFENFN.FHBFCAEGPOH = kLGJNBPGLAB3.FHBFCAEGPOH;
			gMLCOKFENFN.LIKIOBHLHHF = kLGJNBPGLAB3.LIKIOBHLHHF;
			gMLCOKFENFN.BFGGGEPJGOI = array;
			return gMLCOKFENFN;
		}
		case KOAJPENAIBI.Point:
		{
			float oDLHFMOPCHL2 = BDGODEAFONI(MOPCLEEGDFB);
			float num19 = BDGODEAFONI(MOPCLEEGDFB);
			float num20 = BDGODEAFONI(MOPCLEEGDFB);
			if (OBAJJEJENJB)
			{
				AFDPGPBDKLH(MOPCLEEGDFB);
			}
			ENIPPOEKJPA eNIPPOEKJPA = JHLKFNEOEBO.NJIHKIHEHKL(HLCFGIFLPPE, text);
			if (eNIPPOEKJPA == null)
			{
				return null;
			}
			eNIPPOEKJPA.AMFCENFNAJJ = num19 * num;
			eNIPPOEKJPA.CNLILOEEBOJ = num20 * num;
			eNIPPOEKJPA.ODLHFMOPCHL = oDLHFMOPCHL2;
			return eNIPPOEKJPA;
		}
		case KOAJPENAIBI.Clipping:
		{
			int num2 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int num3 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			KLGJNBPGLAB kLGJNBPGLAB = GHOFFCBHBGD(MOPCLEEGDFB, num3);
			if (OBAJJEJENJB)
			{
				AFDPGPBDKLH(MOPCLEEGDFB);
			}
			ACEGNBDLKEG aCEGNBDLKEG = JHLKFNEOEBO.HLKKDHKIPOC(HLCFGIFLPPE, text);
			if (aCEGNBDLKEG == null)
			{
				return null;
			}
			aCEGNBDLKEG.OFHEPFHKOLC = DCMDAJJBNAI.MAKCMFCFDLP.Items[num2];
			aCEGNBDLKEG.MCCBDCEJDBC = num3 << 1;
			aCEGNBDLKEG.FHBFCAEGPOH = kLGJNBPGLAB.FHBFCAEGPOH;
			aCEGNBDLKEG.LIKIOBHLHHF = kLGJNBPGLAB.LIKIOBHLHHF;
			return aCEGNBDLKEG;
		}
		default:
			return null;
		}
	}

	private KLGJNBPGLAB GHOFFCBHBGD(Stream MOPCLEEGDFB, int BKJOIFFAGKE)
	{
		float num = GEBNMKAGJIG;
		int num2 = BKJOIFFAGKE << 1;
		KLGJNBPGLAB kLGJNBPGLAB = new KLGJNBPGLAB();
		if (!HLGIJNJPLCP(MOPCLEEGDFB))
		{
			kLGJNBPGLAB.FHBFCAEGPOH = HPKOKKIHEEB(MOPCLEEGDFB, num2, num);
			return kLGJNBPGLAB;
		}
		ExposedList<float> exposedList = new ExposedList<float>(num2 * 3 * 3);
		ExposedList<int> exposedList2 = new ExposedList<int>(num2 * 3);
		for (int i = 0; i < BKJOIFFAGKE; i++)
		{
			int num3 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			exposedList2.JEACJNAKLDJ(num3);
			for (int j = 0; j < num3; j++)
			{
				exposedList2.JEACJNAKLDJ(ONGMGLIAIPK(MOPCLEEGDFB, true));
				exposedList.JEACJNAKLDJ(BDGODEAFONI(MOPCLEEGDFB) * num);
				exposedList.JEACJNAKLDJ(BDGODEAFONI(MOPCLEEGDFB) * num);
				exposedList.JEACJNAKLDJ(BDGODEAFONI(MOPCLEEGDFB));
			}
		}
		kLGJNBPGLAB.FHBFCAEGPOH = exposedList.GDPLKNIEGDB();
		kLGJNBPGLAB.LIKIOBHLHHF = exposedList2.GDPLKNIEGDB();
		return kLGJNBPGLAB;
	}

	private float[] HPKOKKIHEEB(Stream MOPCLEEGDFB, int IDHLPOFDLKJ, float HJLOCAEAFMJ)
	{
		float[] array = new float[IDHLPOFDLKJ];
		if (HJLOCAEAFMJ == 1f)
		{
			for (int i = 0; i < IDHLPOFDLKJ; i++)
			{
				array[i] = BDGODEAFONI(MOPCLEEGDFB);
			}
		}
		else
		{
			for (int j = 0; j < IDHLPOFDLKJ; j++)
			{
				array[j] = BDGODEAFONI(MOPCLEEGDFB) * HJLOCAEAFMJ;
			}
		}
		return array;
	}

	private int[] KLBILIBNEEP(Stream MOPCLEEGDFB)
	{
		int num = ONGMGLIAIPK(MOPCLEEGDFB, true);
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (MOPCLEEGDFB.ReadByte() << 8) | MOPCLEEGDFB.ReadByte();
		}
		return array;
	}

	private void FKKGMNDHEIP(string IOCMOCCFALN, Stream MOPCLEEGDFB, KGMHJGFNPFC DCMDAJJBNAI)
	{
		ExposedList<DABFMEODJHE> exposedList = new ExposedList<DABFMEODJHE>();
		float num = GEBNMKAGJIG;
		float num2 = 0f;
		int i = 0;
		for (int num3 = ONGMGLIAIPK(MOPCLEEGDFB, true); i < num3; i++)
		{
			int pBPEMFGPGFC = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int j = 0;
			for (int num4 = ONGMGLIAIPK(MOPCLEEGDFB, true); j < num4; j++)
			{
				int num5 = MOPCLEEGDFB.ReadByte();
				int num6 = ONGMGLIAIPK(MOPCLEEGDFB, true);
				switch (num5)
				{
				case 0:
				{
					LPMOMNEGONC lPMOMNEGONC = new LPMOMNEGONC(num6);
					lPMOMNEGONC.PBPEMFGPGFC = pBPEMFGPGFC;
					for (int m = 0; m < num6; m++)
					{
						lPMOMNEGONC.BCEFHMIKFDC(m, BDGODEAFONI(MOPCLEEGDFB), HKEMOEMPHAP(MOPCLEEGDFB));
					}
					exposedList.JEACJNAKLDJ(lPMOMNEGONC);
					num2 = Math.Max(num2, lPMOMNEGONC.ENBKHCNKHCC[num6 - 1]);
					break;
				}
				case 1:
				{
					AIHPPKDLPLG aIHPPKDLPLG = new AIHPPKDLPLG(num6);
					aIHPPKDLPLG.PBPEMFGPGFC = pBPEMFGPGFC;
					for (int l = 0; l < num6; l++)
					{
						float hFLODNLEGFL2 = BDGODEAFONI(MOPCLEEGDFB);
						int num9 = AFDPGPBDKLH(MOPCLEEGDFB);
						float gPGDCCMECGF2 = (float)((num9 & 0xFF000000u) >> 24) / 255f;
						float hJMBDGKAOBP2 = (float)((num9 & 0xFF0000) >> 16) / 255f;
						float bCIHLCMFAEK2 = (float)((num9 & 0xFF00) >> 8) / 255f;
						float mNIMEAMHNMI2 = (float)(num9 & 0xFF) / 255f;
						aIHPPKDLPLG.BCEFHMIKFDC(l, hFLODNLEGFL2, gPGDCCMECGF2, hJMBDGKAOBP2, bCIHLCMFAEK2, mNIMEAMHNMI2);
						if (l < num6 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, l, aIHPPKDLPLG);
						}
					}
					exposedList.JEACJNAKLDJ(aIHPPKDLPLG);
					num2 = Math.Max(num2, aIHPPKDLPLG.ENBKHCNKHCC[(aIHPPKDLPLG.DABCDPAEDEE - 1) * 5]);
					break;
				}
				case 2:
				{
					DKOKKMLGGJI dKOKKMLGGJI = new DKOKKMLGGJI(num6);
					dKOKKMLGGJI.PBPEMFGPGFC = pBPEMFGPGFC;
					for (int k = 0; k < num6; k++)
					{
						float hFLODNLEGFL = BDGODEAFONI(MOPCLEEGDFB);
						int num7 = AFDPGPBDKLH(MOPCLEEGDFB);
						float gPGDCCMECGF = (float)((num7 & 0xFF000000u) >> 24) / 255f;
						float hJMBDGKAOBP = (float)((num7 & 0xFF0000) >> 16) / 255f;
						float bCIHLCMFAEK = (float)((num7 & 0xFF00) >> 8) / 255f;
						float mNIMEAMHNMI = (float)(num7 & 0xFF) / 255f;
						int num8 = AFDPGPBDKLH(MOPCLEEGDFB);
						float fHPFAEDHEGG = (float)((num8 & 0xFF0000) >> 16) / 255f;
						float aONHFIBNFLD = (float)((num8 & 0xFF00) >> 8) / 255f;
						float dLGDBCBCIED = (float)(num8 & 0xFF) / 255f;
						dKOKKMLGGJI.BCEFHMIKFDC(k, hFLODNLEGFL, gPGDCCMECGF, hJMBDGKAOBP, bCIHLCMFAEK, mNIMEAMHNMI, fHPFAEDHEGG, aONHFIBNFLD, dLGDBCBCIED);
						if (k < num6 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, k, dKOKKMLGGJI);
						}
					}
					exposedList.JEACJNAKLDJ(dKOKKMLGGJI);
					num2 = Math.Max(num2, dKOKKMLGGJI.ENBKHCNKHCC[(dKOKKMLGGJI.DABCDPAEDEE - 1) * 8]);
					break;
				}
				}
			}
		}
		int n = 0;
		for (int num10 = ONGMGLIAIPK(MOPCLEEGDFB, true); n < num10; n++)
		{
			int dHJJGGGLNNH = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int num11 = 0;
			for (int num12 = ONGMGLIAIPK(MOPCLEEGDFB, true); num11 < num12; num11++)
			{
				int num13 = MOPCLEEGDFB.ReadByte();
				int num14 = ONGMGLIAIPK(MOPCLEEGDFB, true);
				switch (num13)
				{
				case 0:
				{
					GFNJOILFDNB gFNJOILFDNB = new GFNJOILFDNB(num14);
					gFNJOILFDNB.DHJJGGGLNNH = dHJJGGGLNNH;
					for (int num17 = 0; num17 < num14; num17++)
					{
						gFNJOILFDNB.BCEFHMIKFDC(num17, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB));
						if (num17 < num14 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, num17, gFNJOILFDNB);
						}
					}
					exposedList.JEACJNAKLDJ(gFNJOILFDNB);
					num2 = Math.Max(num2, gFNJOILFDNB.ENBKHCNKHCC[(num14 - 1) * 2]);
					break;
				}
				case 1:
				case 2:
				case 3:
				{
					float num15 = 1f;
					CPCLJAHCDGN cPCLJAHCDGN;
					switch (num13)
					{
					case 2:
						cPCLJAHCDGN = new CFHAEHPHFEI(num14);
						break;
					case 3:
						cPCLJAHCDGN = new GLKBNKGOCDE(num14);
						break;
					default:
						cPCLJAHCDGN = new CPCLJAHCDGN(num14);
						num15 = num;
						break;
					}
					cPCLJAHCDGN.DHJJGGGLNNH = dHJJGGGLNNH;
					for (int num16 = 0; num16 < num14; num16++)
					{
						cPCLJAHCDGN.BCEFHMIKFDC(num16, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB) * num15, BDGODEAFONI(MOPCLEEGDFB) * num15);
						if (num16 < num14 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, num16, cPCLJAHCDGN);
						}
					}
					exposedList.JEACJNAKLDJ(cPCLJAHCDGN);
					num2 = Math.Max(num2, cPCLJAHCDGN.ENBKHCNKHCC[(num14 - 1) * 3]);
					break;
				}
				}
			}
		}
		int num18 = 0;
		for (int num19 = ONGMGLIAIPK(MOPCLEEGDFB, true); num18 < num19; num18++)
		{
			int gOPEKHCFFGB = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int num20 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			MGCNHAGJEIE mGCNHAGJEIE = new MGCNHAGJEIE(num20);
			mGCNHAGJEIE.GOPEKHCFFGB = gOPEKHCFFGB;
			for (int num21 = 0; num21 < num20; num21++)
			{
				mGCNHAGJEIE.BCEFHMIKFDC(num21, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), DGBALGMOMKK(MOPCLEEGDFB));
				if (num21 < num20 - 1)
				{
					FBDFAENOOFG(MOPCLEEGDFB, num21, mGCNHAGJEIE);
				}
			}
			exposedList.JEACJNAKLDJ(mGCNHAGJEIE);
			num2 = Math.Max(num2, mGCNHAGJEIE.ENBKHCNKHCC[(num20 - 1) * 3]);
		}
		int num22 = 0;
		for (int num23 = ONGMGLIAIPK(MOPCLEEGDFB, true); num22 < num23; num22++)
		{
			int jEJEFHFBHAJ = ONGMGLIAIPK(MOPCLEEGDFB, true);
			int num24 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			BNODOKNKNDG bNODOKNKNDG = new BNODOKNKNDG(num24);
			bNODOKNKNDG.JEJEFHFBHAJ = jEJEFHFBHAJ;
			for (int num25 = 0; num25 < num24; num25++)
			{
				bNODOKNKNDG.BCEFHMIKFDC(num25, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB));
				if (num25 < num24 - 1)
				{
					FBDFAENOOFG(MOPCLEEGDFB, num25, bNODOKNKNDG);
				}
			}
			exposedList.JEACJNAKLDJ(bNODOKNKNDG);
			num2 = Math.Max(num2, bNODOKNKNDG.ENBKHCNKHCC[(num24 - 1) * 5]);
		}
		int num26 = 0;
		for (int num27 = ONGMGLIAIPK(MOPCLEEGDFB, true); num26 < num27; num26++)
		{
			int num28 = ONGMGLIAIPK(MOPCLEEGDFB, true);
			GJNEKNOKICF gJNEKNOKICF = DCMDAJJBNAI.NDOOCKKIMHO.Items[num28];
			int num29 = 0;
			for (int num30 = ONGMGLIAIPK(MOPCLEEGDFB, true); num29 < num30; num29++)
			{
				int num31 = DGBALGMOMKK(MOPCLEEGDFB);
				int num32 = ONGMGLIAIPK(MOPCLEEGDFB, true);
				switch (num31)
				{
				case 0:
				case 1:
				{
					float num34 = 1f;
					BLIEJOGKBBN bLIEJOGKBBN;
					if (num31 == 1)
					{
						bLIEJOGKBBN = new NHPAKKGJBBI(num32);
						if (gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Length || gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Fixed)
						{
							num34 = num;
						}
					}
					else
					{
						bLIEJOGKBBN = new BLIEJOGKBBN(num32);
						if (gJNEKNOKICF.FMJFEKINFLF == KMDGGFDOOPL.Fixed)
						{
							num34 = num;
						}
					}
					bLIEJOGKBBN.CFOGCDKFLIH = num28;
					for (int num35 = 0; num35 < num32; num35++)
					{
						bLIEJOGKBBN.BCEFHMIKFDC(num35, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB) * num34);
						if (num35 < num32 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, num35, bLIEJOGKBBN);
						}
					}
					exposedList.JEACJNAKLDJ(bLIEJOGKBBN);
					num2 = Math.Max(num2, bLIEJOGKBBN.ENBKHCNKHCC[(num32 - 1) * 2]);
					break;
				}
				case 2:
				{
					DKEAHBHKOLB dKEAHBHKOLB = new DKEAHBHKOLB(num32);
					dKEAHBHKOLB.CFOGCDKFLIH = num28;
					for (int num33 = 0; num33 < num32; num33++)
					{
						dKEAHBHKOLB.BCEFHMIKFDC(num33, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB));
						if (num33 < num32 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, num33, dKEAHBHKOLB);
						}
					}
					exposedList.JEACJNAKLDJ(dKEAHBHKOLB);
					num2 = Math.Max(num2, dKEAHBHKOLB.ENBKHCNKHCC[(num32 - 1) * 3]);
					break;
				}
				}
			}
		}
		int num36 = 0;
		for (int num37 = ONGMGLIAIPK(MOPCLEEGDFB, true); num36 < num37; num36++)
		{
			JPAALKCPGNB jPAALKCPGNB = DCMDAJJBNAI.CFPBCLCKDBM.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
			int num38 = 0;
			for (int num39 = ONGMGLIAIPK(MOPCLEEGDFB, true); num38 < num39; num38++)
			{
				int pBPEMFGPGFC2 = ONGMGLIAIPK(MOPCLEEGDFB, true);
				int num40 = 0;
				for (int num41 = ONGMGLIAIPK(MOPCLEEGDFB, true); num40 < num41; num40++)
				{
					LJPHFIKMDHN lJPHFIKMDHN = (LJPHFIKMDHN)jPAALKCPGNB.JGHJDGIANDD(pBPEMFGPGFC2, HKEMOEMPHAP(MOPCLEEGDFB));
					bool flag = lJPHFIKMDHN.LIKIOBHLHHF != null;
					float[] fHBFCAEGPOH = lJPHFIKMDHN.FHBFCAEGPOH;
					int num42 = ((!flag) ? fHBFCAEGPOH.Length : (fHBFCAEGPOH.Length / 3 * 2));
					int num43 = ONGMGLIAIPK(MOPCLEEGDFB, true);
					BJBLIIGICII bJBLIIGICII = new BJBLIIGICII(num43);
					bJBLIIGICII.PBPEMFGPGFC = pBPEMFGPGFC2;
					bJBLIIGICII.DFHHMKMLCFF = lJPHFIKMDHN;
					for (int num44 = 0; num44 < num43; num44++)
					{
						float hFLODNLEGFL3 = BDGODEAFONI(MOPCLEEGDFB);
						int num45 = ONGMGLIAIPK(MOPCLEEGDFB, true);
						float[] array;
						if (num45 == 0)
						{
							array = ((!flag) ? fHBFCAEGPOH : new float[num42]);
						}
						else
						{
							array = new float[num42];
							int num46 = ONGMGLIAIPK(MOPCLEEGDFB, true);
							num45 += num46;
							if (num == 1f)
							{
								for (int num47 = num46; num47 < num45; num47++)
								{
									array[num47] = BDGODEAFONI(MOPCLEEGDFB);
								}
							}
							else
							{
								for (int num48 = num46; num48 < num45; num48++)
								{
									array[num48] = BDGODEAFONI(MOPCLEEGDFB) * num;
								}
							}
							if (!flag)
							{
								int num49 = 0;
								for (int num50 = array.Length; num49 < num50; num49++)
								{
									array[num49] += fHBFCAEGPOH[num49];
								}
							}
						}
						bJBLIIGICII.BCEFHMIKFDC(num44, hFLODNLEGFL3, array);
						if (num44 < num43 - 1)
						{
							FBDFAENOOFG(MOPCLEEGDFB, num44, bJBLIIGICII);
						}
					}
					exposedList.JEACJNAKLDJ(bJBLIIGICII);
					num2 = Math.Max(num2, bJBLIIGICII.ENBKHCNKHCC[num43 - 1]);
				}
			}
		}
		int num51 = ONGMGLIAIPK(MOPCLEEGDFB, true);
		if (num51 > 0)
		{
			HHDOJIEJCGJ hHDOJIEJCGJ = new HHDOJIEJCGJ(num51);
			int count = DCMDAJJBNAI.MAKCMFCFDLP.Count;
			for (int num52 = 0; num52 < num51; num52++)
			{
				float hFLODNLEGFL4 = BDGODEAFONI(MOPCLEEGDFB);
				int num53 = ONGMGLIAIPK(MOPCLEEGDFB, true);
				int[] array2 = new int[count];
				for (int num54 = count - 1; num54 >= 0; num54--)
				{
					array2[num54] = -1;
				}
				int[] array3 = new int[count - num53];
				int num55 = 0;
				int num56 = 0;
				for (int num57 = 0; num57 < num53; num57++)
				{
					int num58 = ONGMGLIAIPK(MOPCLEEGDFB, true);
					while (num55 != num58)
					{
						array3[num56++] = num55++;
					}
					array2[num55 + ONGMGLIAIPK(MOPCLEEGDFB, true)] = num55++;
				}
				while (num55 < count)
				{
					array3[num56++] = num55++;
				}
				for (int num59 = count - 1; num59 >= 0; num59--)
				{
					if (array2[num59] == -1)
					{
						array2[num59] = array3[--num56];
					}
				}
				hHDOJIEJCGJ.BCEFHMIKFDC(num52, hFLODNLEGFL4, array2);
			}
			exposedList.JEACJNAKLDJ(hHDOJIEJCGJ);
			num2 = Math.Max(num2, hHDOJIEJCGJ.ENBKHCNKHCC[num51 - 1]);
		}
		int num60 = ONGMGLIAIPK(MOPCLEEGDFB, true);
		if (num60 > 0)
		{
			JKFAGIAHNNK jKFAGIAHNNK = new JKFAGIAHNNK(num60);
			for (int num61 = 0; num61 < num60; num61++)
			{
				float hFLODNLEGFL5 = BDGODEAFONI(MOPCLEEGDFB);
				MDBINBLMHMC mDBINBLMHMC = DCMDAJJBNAI.NJOHMGMPGBE.Items[ONGMGLIAIPK(MOPCLEEGDFB, true)];
				DCBJAMHBAJB dCBJAMHBAJB = new DCBJAMHBAJB(hFLODNLEGFL5, mDBINBLMHMC);
				dCBJAMHBAJB.IOCBLKCOMGI = ONGMGLIAIPK(MOPCLEEGDFB, false);
				dCBJAMHBAJB.NCGJMNFFOJH = BDGODEAFONI(MOPCLEEGDFB);
				dCBJAMHBAJB.BECLAMGPAGN = ((!HLGIJNJPLCP(MOPCLEEGDFB)) ? mDBINBLMHMC.BECLAMGPAGN : HKEMOEMPHAP(MOPCLEEGDFB));
				jKFAGIAHNNK.BCEFHMIKFDC(num61, dCBJAMHBAJB);
			}
			exposedList.JEACJNAKLDJ(jKFAGIAHNNK);
			num2 = Math.Max(num2, jKFAGIAHNNK.ENBKHCNKHCC[num60 - 1]);
		}
		exposedList.PBHLDFFHPND();
		DCMDAJJBNAI.BNLBLHNEJAH.JEACJNAKLDJ(new GNGKKPOGGGM(IOCMOCCFALN, exposedList, num2));
	}

	private void FBDFAENOOFG(Stream MOPCLEEGDFB, int JHFDIBIBCPH, FPOBLOBNHGG CEMIIGGAEHH)
	{
		switch (MOPCLEEGDFB.ReadByte())
		{
		case 1:
			CEMIIGGAEHH.FGGBGOFPDAD(JHFDIBIBCPH);
			break;
		case 2:
			CEMIIGGAEHH.MHALBIPKNGP(JHFDIBIBCPH, BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB), BDGODEAFONI(MOPCLEEGDFB));
			break;
		}
	}

	private static sbyte DGBALGMOMKK(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		if (num == -1)
		{
			throw new EndOfStreamException();
		}
		return (sbyte)num;
	}

	private static bool HLGIJNJPLCP(Stream MOPCLEEGDFB)
	{
		return MOPCLEEGDFB.ReadByte() != 0;
	}

	private float BDGODEAFONI(Stream MOPCLEEGDFB)
	{
		DJDKLOJBJCO[3] = (byte)MOPCLEEGDFB.ReadByte();
		DJDKLOJBJCO[2] = (byte)MOPCLEEGDFB.ReadByte();
		DJDKLOJBJCO[1] = (byte)MOPCLEEGDFB.ReadByte();
		DJDKLOJBJCO[0] = (byte)MOPCLEEGDFB.ReadByte();
		return BitConverter.ToSingle(DJDKLOJBJCO, 0);
	}

	private static int AFDPGPBDKLH(Stream MOPCLEEGDFB)
	{
		return (MOPCLEEGDFB.ReadByte() << 24) + (MOPCLEEGDFB.ReadByte() << 16) + (MOPCLEEGDFB.ReadByte() << 8) + MOPCLEEGDFB.ReadByte();
	}

	private static int ONGMGLIAIPK(Stream MOPCLEEGDFB, bool JFPIADBNOHK)
	{
		int num = MOPCLEEGDFB.ReadByte();
		int num2 = num & 0x7F;
		if (((uint)num & 0x80u) != 0)
		{
			num = MOPCLEEGDFB.ReadByte();
			num2 |= (num & 0x7F) << 7;
			if (((uint)num & 0x80u) != 0)
			{
				num = MOPCLEEGDFB.ReadByte();
				num2 |= (num & 0x7F) << 14;
				if (((uint)num & 0x80u) != 0)
				{
					num = MOPCLEEGDFB.ReadByte();
					num2 |= (num & 0x7F) << 21;
					if (((uint)num & 0x80u) != 0)
					{
						num2 |= (MOPCLEEGDFB.ReadByte() & 0x7F) << 28;
					}
				}
			}
		}
		return (!JFPIADBNOHK) ? ((num2 >> 1) ^ -(num2 & 1)) : num2;
	}

	private string HKEMOEMPHAP(Stream MOPCLEEGDFB)
	{
		int num = ONGMGLIAIPK(MOPCLEEGDFB, true);
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return string.Empty;
		default:
		{
			num--;
			byte[] array = DJDKLOJBJCO;
			if (array.Length < num)
			{
				array = new byte[num];
			}
			PCNDKGFHPJN(MOPCLEEGDFB, array, 0, num);
			return Encoding.UTF8.GetString(array, 0, num);
		}
		}
	}

	private static void PCNDKGFHPJN(Stream MOPCLEEGDFB, byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		while (EOFAGACBNFP > 0)
		{
			int num = MOPCLEEGDFB.Read(DJDKLOJBJCO, IBNDGNOIEEF, EOFAGACBNFP);
			if (num <= 0)
			{
				throw new EndOfStreamException();
			}
			IBNDGNOIEEF += num;
			EOFAGACBNFP -= num;
		}
	}
}
