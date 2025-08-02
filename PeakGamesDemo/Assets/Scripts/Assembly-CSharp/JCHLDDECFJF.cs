using System;
using System.Collections.Generic;
using System.IO;
using Spine;

public class JCHLDDECFJF
{
	internal class PHEALEKBPIF
	{
		internal string LIMMFGDCLAB;

		internal string HLCFGIFLPPE;

		internal int PBPEMFGPGFC;

		internal MGCLDKAFCIB IJKCGGPJDIG;

		public PHEALEKBPIF(MGCLDKAFCIB IJKCGGPJDIG, string HLCFGIFLPPE, int PBPEMFGPGFC, string LIMMFGDCLAB)
		{
			this.IJKCGGPJDIG = IJKCGGPJDIG;
			this.HLCFGIFLPPE = HLCFGIFLPPE;
			this.PBPEMFGPGFC = PBPEMFGPGFC;
			this.LIMMFGDCLAB = LIMMFGDCLAB;
		}
	}

	private EDENIAPLFEN JHLKFNEOEBO;

	private List<PHEALEKBPIF> HHDLADPAMIO = new List<PHEALEKBPIF>();

	public float GEBNMKAGJIG { get; set; }

	public JCHLDDECFJF(params GFNFFCGAGEH[] ANMHLKGBNIP)
		: this(new JKAOAAMMPPH(ANMHLKGBNIP))
	{
	}

	public JCHLDDECFJF(EDENIAPLFEN JHLKFNEOEBO)
	{
		if (JHLKFNEOEBO == null)
		{
			throw new ArgumentNullException("attachmentLoader", "attachmentLoader cannot be null.");
		}
		this.JHLKFNEOEBO = JHLKFNEOEBO;
		GEBNMKAGJIG = 1f;
	}

	public KGMHJGFNPFC FDOJFCCGLKM(string LCCKDPIBKPJ)
	{
		using (StreamReader jIGJDAHIIBA = new StreamReader(new FileStream(LCCKDPIBKPJ, FileMode.Open, FileAccess.Read, FileShare.Read)))
		{
			KGMHJGFNPFC kGMHJGFNPFC = FDOJFCCGLKM(jIGJDAHIIBA);
			kGMHJGFNPFC.IOCMOCCFALN = Path.GetFileNameWithoutExtension(LCCKDPIBKPJ);
			return kGMHJGFNPFC;
		}
	}

	public KGMHJGFNPFC FDOJFCCGLKM(TextReader JIGJDAHIIBA)
	{
		if (JIGJDAHIIBA == null)
		{
			throw new ArgumentNullException("reader", "reader cannot be null.");
		}
		float num = GEBNMKAGJIG;
		KGMHJGFNPFC kGMHJGFNPFC = new KGMHJGFNPFC();
		Dictionary<string, object> dictionary = JEOOJFGNJOO.NBPMNECNBHJ(JIGJDAHIIBA) as Dictionary<string, object>;
		if (dictionary == null)
		{
			throw new Exception("Invalid JSON.");
		}
		if (dictionary.ContainsKey("skeleton"))
		{
			Dictionary<string, object> dictionary2 = (Dictionary<string, object>)dictionary["skeleton"];
			kGMHJGFNPFC.AIELCDIFLFB = (string)dictionary2["hash"];
			kGMHJGFNPFC.DFCJKBHFPMG = (string)dictionary2["spine"];
			kGMHJGFNPFC.HHHMOGOKFHF = EOHHGHDJKLI(dictionary2, "width", 0f);
			kGMHJGFNPFC.JKNPBEOPMPK = EOHHGHDJKLI(dictionary2, "height", 0f);
			kGMHJGFNPFC.IMFECEPMNNP = EOHHGHDJKLI(dictionary2, "fps", 0f);
			kGMHJGFNPFC.LIIPMIDHPEP = JDANMONKNGD(dictionary2, "images", null);
		}
		foreach (Dictionary<string, object> item in (List<object>)dictionary["bones"])
		{
			GPJIPDIEIIL gPJIPDIEIIL = null;
			if (item.ContainsKey("parent"))
			{
				gPJIPDIEIIL = kGMHJGFNPFC.NMLBCOPEEDC((string)item["parent"]);
				if (gPJIPDIEIIL == null)
				{
					throw new Exception("Parent bone not found: " + item["parent"]);
				}
			}
			GPJIPDIEIIL gPJIPDIEIIL2 = new GPJIPDIEIIL(kGMHJGFNPFC.PGACGAFEFHD.Count, (string)item["name"], gPJIPDIEIIL);
			gPJIPDIEIIL2.EOFAGACBNFP = EOHHGHDJKLI(item, "length", 0f) * num;
			gPJIPDIEIIL2.AMFCENFNAJJ = EOHHGHDJKLI(item, "x", 0f) * num;
			gPJIPDIEIIL2.CNLILOEEBOJ = EOHHGHDJKLI(item, "y", 0f) * num;
			gPJIPDIEIIL2.ODLHFMOPCHL = EOHHGHDJKLI(item, "rotation", 0f);
			gPJIPDIEIIL2.IAFNPOKEFMB = EOHHGHDJKLI(item, "scaleX", 1f);
			gPJIPDIEIIL2.GFMCPIJHIGD = EOHHGHDJKLI(item, "scaleY", 1f);
			gPJIPDIEIIL2.BALNAGONJDA = EOHHGHDJKLI(item, "shearX", 0f);
			gPJIPDIEIIL2.DADFBNMBFCD = EOHHGHDJKLI(item, "shearY", 0f);
			string value = JDANMONKNGD(item, "transform", NGPCELMDKGK.Normal.ToString());
			gPJIPDIEIIL2.OJOPJNBLHLO = (NGPCELMDKGK)Enum.Parse(typeof(NGPCELMDKGK), value, true);
			kGMHJGFNPFC.LIKIOBHLHHF.JEACJNAKLDJ(gPJIPDIEIIL2);
		}
		if (dictionary.ContainsKey("slots"))
		{
			foreach (Dictionary<string, object> item2 in (List<object>)dictionary["slots"])
			{
				string iOCMOCCFALN = (string)item2["name"];
				string text = (string)item2["bone"];
				GPJIPDIEIIL gPJIPDIEIIL3 = kGMHJGFNPFC.NMLBCOPEEDC(text);
				if (gPJIPDIEIIL3 == null)
				{
					throw new Exception("Slot bone not found: " + text);
				}
				HMGLMNHOBHA hMGLMNHOBHA = new HMGLMNHOBHA(kGMHJGFNPFC.BKDKEAAAMBB.Count, iOCMOCCFALN, gPJIPDIEIIL3);
				if (item2.ContainsKey("color"))
				{
					string pLEGDJKNGEM = (string)item2["color"];
					hMGLMNHOBHA.GPGDCCMECGF = EFOKMEFOFEJ(pLEGDJKNGEM, 0);
					hMGLMNHOBHA.HJMBDGKAOBP = EFOKMEFOFEJ(pLEGDJKNGEM, 1);
					hMGLMNHOBHA.BCIHLCMFAEK = EFOKMEFOFEJ(pLEGDJKNGEM, 2);
					hMGLMNHOBHA.MNIMEAMHNMI = EFOKMEFOFEJ(pLEGDJKNGEM, 3);
				}
				if (item2.ContainsKey("dark"))
				{
					string pLEGDJKNGEM2 = (string)item2["dark"];
					hMGLMNHOBHA.FHPFAEDHEGG = EFOKMEFOFEJ(pLEGDJKNGEM2, 0, 6);
					hMGLMNHOBHA.AONHFIBNFLD = EFOKMEFOFEJ(pLEGDJKNGEM2, 1, 6);
					hMGLMNHOBHA.DLGDBCBCIED = EFOKMEFOFEJ(pLEGDJKNGEM2, 2, 6);
					hMGLMNHOBHA.CKPBGCMIIJL = true;
				}
				hMGLMNHOBHA.FKAJNAAKEFH = JDANMONKNGD(item2, "attachment", null);
				if (item2.ContainsKey("blend"))
				{
					hMGLMNHOBHA.DNLHLBINHHE = (AOOPCGDMICP)Enum.Parse(typeof(AOOPCGDMICP), (string)item2["blend"], true);
				}
				else
				{
					hMGLMNHOBHA.DNLHLBINHHE = AOOPCGDMICP.Normal;
				}
				kGMHJGFNPFC.MAKCMFCFDLP.JEACJNAKLDJ(hMGLMNHOBHA);
			}
		}
		if (dictionary.ContainsKey("ik"))
		{
			foreach (Dictionary<string, object> item3 in (List<object>)dictionary["ik"])
			{
				BMELPEKHKKJ bMELPEKHKKJ = new BMELPEKHKKJ((string)item3["name"]);
				bMELPEKHKKJ.CMAJLIAELDP = CFHAMLBKKLA(item3, "order", 0);
				foreach (string item4 in (List<object>)item3["bones"])
				{
					GPJIPDIEIIL gPJIPDIEIIL4 = kGMHJGFNPFC.NMLBCOPEEDC(item4);
					if (gPJIPDIEIIL4 == null)
					{
						throw new Exception("IK constraint bone not found: " + item4);
					}
					bMELPEKHKKJ.LIKIOBHLHHF.Add(gPJIPDIEIIL4);
				}
				string text3 = (string)item3["target"];
				bMELPEKHKKJ.CAEMELGEOAE = kGMHJGFNPFC.NMLBCOPEEDC(text3);
				if (bMELPEKHKKJ.CAEMELGEOAE == null)
				{
					throw new Exception("Target bone not found: " + text3);
				}
				bMELPEKHKKJ.IEFNLGDAINN = (JJCKAEJFAAM(item3, "bendPositive", true) ? 1 : (-1));
				bMELPEKHKKJ.MIIHPKNIPAB = EOHHGHDJKLI(item3, "mix", 1f);
				kGMHJGFNPFC.EFIPDNFLFND.JEACJNAKLDJ(bMELPEKHKKJ);
			}
		}
		if (dictionary.ContainsKey("transform"))
		{
			foreach (Dictionary<string, object> item5 in (List<object>)dictionary["transform"])
			{
				MNNBOEPCJGP mNNBOEPCJGP = new MNNBOEPCJGP((string)item5["name"]);
				mNNBOEPCJGP.CMAJLIAELDP = CFHAMLBKKLA(item5, "order", 0);
				foreach (string item6 in (List<object>)item5["bones"])
				{
					GPJIPDIEIIL gPJIPDIEIIL5 = kGMHJGFNPFC.NMLBCOPEEDC(item6);
					if (gPJIPDIEIIL5 == null)
					{
						throw new Exception("Transform constraint bone not found: " + item6);
					}
					mNNBOEPCJGP.LIKIOBHLHHF.JEACJNAKLDJ(gPJIPDIEIIL5);
				}
				string text5 = (string)item5["target"];
				mNNBOEPCJGP.CAEMELGEOAE = kGMHJGFNPFC.NMLBCOPEEDC(text5);
				if (mNNBOEPCJGP.CAEMELGEOAE == null)
				{
					throw new Exception("Target bone not found: " + text5);
				}
				mNNBOEPCJGP.ACIIIFFOMEC = JJCKAEJFAAM(item5, "local", false);
				mNNBOEPCJGP.JKBPDGBLPNO = JJCKAEJFAAM(item5, "relative", false);
				mNNBOEPCJGP.HCFAKEOFMPM = EOHHGHDJKLI(item5, "rotation", 0f);
				mNNBOEPCJGP.MLKPDGNHNAE = EOHHGHDJKLI(item5, "x", 0f) * num;
				mNNBOEPCJGP.INDIJOFPNGA = EOHHGHDJKLI(item5, "y", 0f) * num;
				mNNBOEPCJGP.LEDJLEBCJCH = EOHHGHDJKLI(item5, "scaleX", 0f);
				mNNBOEPCJGP.LCELCEPDPAB = EOHHGHDJKLI(item5, "scaleY", 0f);
				mNNBOEPCJGP.HJKFDFKINDC = EOHHGHDJKLI(item5, "shearY", 0f);
				mNNBOEPCJGP.OIBAIJIPGOM = EOHHGHDJKLI(item5, "rotateMix", 1f);
				mNNBOEPCJGP.DHNKOEMONHP = EOHHGHDJKLI(item5, "translateMix", 1f);
				mNNBOEPCJGP.DLEIMBNDMOF = EOHHGHDJKLI(item5, "scaleMix", 1f);
				mNNBOEPCJGP.OKJBKNEPKPN = EOHHGHDJKLI(item5, "shearMix", 1f);
				kGMHJGFNPFC.FOANDHFONAA.JEACJNAKLDJ(mNNBOEPCJGP);
			}
		}
		if (dictionary.ContainsKey("path"))
		{
			foreach (Dictionary<string, object> item7 in (List<object>)dictionary["path"])
			{
				GJNEKNOKICF gJNEKNOKICF = new GJNEKNOKICF((string)item7["name"]);
				gJNEKNOKICF.CMAJLIAELDP = CFHAMLBKKLA(item7, "order", 0);
				foreach (string item8 in (List<object>)item7["bones"])
				{
					GPJIPDIEIIL gPJIPDIEIIL6 = kGMHJGFNPFC.NMLBCOPEEDC(item8);
					if (gPJIPDIEIIL6 == null)
					{
						throw new Exception("Path bone not found: " + item8);
					}
					gJNEKNOKICF.LIKIOBHLHHF.JEACJNAKLDJ(gPJIPDIEIIL6);
				}
				string text7 = (string)item7["target"];
				gJNEKNOKICF.CAEMELGEOAE = kGMHJGFNPFC.MEKLNNENPDK(text7);
				if (gJNEKNOKICF.CAEMELGEOAE == null)
				{
					throw new Exception("Target slot not found: " + text7);
				}
				gJNEKNOKICF.FMJFEKINFLF = (KMDGGFDOOPL)Enum.Parse(typeof(KMDGGFDOOPL), JDANMONKNGD(item7, "positionMode", "percent"), true);
				gJNEKNOKICF.ENMOCNJMBKD = (OIGFPANDDIM)Enum.Parse(typeof(OIGFPANDDIM), JDANMONKNGD(item7, "spacingMode", "length"), true);
				gJNEKNOKICF.HCNEABGHJMH = (NOKBMFOFOMJ)Enum.Parse(typeof(NOKBMFOFOMJ), JDANMONKNGD(item7, "rotateMode", "tangent"), true);
				gJNEKNOKICF.HCFAKEOFMPM = EOHHGHDJKLI(item7, "rotation", 0f);
				gJNEKNOKICF.LDMDBPLADGD = EOHHGHDJKLI(item7, "position", 0f);
				if (gJNEKNOKICF.FMJFEKINFLF == KMDGGFDOOPL.Fixed)
				{
					gJNEKNOKICF.LDMDBPLADGD *= num;
				}
				gJNEKNOKICF.ILNOGLMCFMC = EOHHGHDJKLI(item7, "spacing", 0f);
				if (gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Length || gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Fixed)
				{
					gJNEKNOKICF.ILNOGLMCFMC *= num;
				}
				gJNEKNOKICF.OIBAIJIPGOM = EOHHGHDJKLI(item7, "rotateMix", 1f);
				gJNEKNOKICF.DHNKOEMONHP = EOHHGHDJKLI(item7, "translateMix", 1f);
				kGMHJGFNPFC.NDOOCKKIMHO.JEACJNAKLDJ(gJNEKNOKICF);
			}
		}
		if (dictionary.ContainsKey("skins"))
		{
			foreach (KeyValuePair<string, object> item9 in (Dictionary<string, object>)dictionary["skins"])
			{
				JPAALKCPGNB jPAALKCPGNB = new JPAALKCPGNB(item9.Key);
				foreach (KeyValuePair<string, object> item10 in (Dictionary<string, object>)item9.Value)
				{
					int pBPEMFGPGFC = kGMHJGFNPFC.IBOGMECEHLD(item10.Key);
					foreach (KeyValuePair<string, object> item11 in (Dictionary<string, object>)item10.Value)
					{
						try
						{
							OAMNGFLKEFI oAMNGFLKEFI = JNBDHGKGOJD((Dictionary<string, object>)item11.Value, jPAALKCPGNB, pBPEMFGPGFC, item11.Key, kGMHJGFNPFC);
							if (oAMNGFLKEFI != null)
							{
								jPAALKCPGNB.DJJIHPJOEBF(pBPEMFGPGFC, item11.Key, oAMNGFLKEFI);
							}
						}
						catch (Exception innerException)
						{
							throw new Exception("Error reading attachment: " + item11.Key + ", skin: " + jPAALKCPGNB, innerException);
						}
					}
				}
				kGMHJGFNPFC.CFPBCLCKDBM.JEACJNAKLDJ(jPAALKCPGNB);
				if (jPAALKCPGNB.IOCMOCCFALN == "default")
				{
					kGMHJGFNPFC.NAKPPHNCJOC = jPAALKCPGNB;
				}
			}
		}
		int i = 0;
		for (int count = HHDLADPAMIO.Count; i < count; i++)
		{
			PHEALEKBPIF pHEALEKBPIF = HHDLADPAMIO[i];
			JPAALKCPGNB jPAALKCPGNB2 = ((pHEALEKBPIF.HLCFGIFLPPE != null) ? kGMHJGFNPFC.COONIJFPADF(pHEALEKBPIF.HLCFGIFLPPE) : kGMHJGFNPFC.NAKPPHNCJOC);
			if (jPAALKCPGNB2 == null)
			{
				throw new Exception("Slot not found: " + pHEALEKBPIF.HLCFGIFLPPE);
			}
			OAMNGFLKEFI oAMNGFLKEFI2 = jPAALKCPGNB2.JGHJDGIANDD(pHEALEKBPIF.PBPEMFGPGFC, pHEALEKBPIF.LIMMFGDCLAB);
			if (oAMNGFLKEFI2 == null)
			{
				throw new Exception("Parent mesh not found: " + pHEALEKBPIF.LIMMFGDCLAB);
			}
			pHEALEKBPIF.IJKCGGPJDIG.EJEBCFHLAFF = (MGCLDKAFCIB)oAMNGFLKEFI2;
			pHEALEKBPIF.IJKCGGPJDIG.IFAIOMLBIAD();
		}
		HHDLADPAMIO.Clear();
		if (dictionary.ContainsKey("events"))
		{
			foreach (KeyValuePair<string, object> item12 in (Dictionary<string, object>)dictionary["events"])
			{
				Dictionary<string, object> eIALHGLMECL = (Dictionary<string, object>)item12.Value;
				MDBINBLMHMC mDBINBLMHMC = new MDBINBLMHMC(item12.Key);
				mDBINBLMHMC.IOCBLKCOMGI = CFHAMLBKKLA(eIALHGLMECL, "int", 0);
				mDBINBLMHMC.NCGJMNFFOJH = EOHHGHDJKLI(eIALHGLMECL, "float", 0f);
				mDBINBLMHMC.BECLAMGPAGN = JDANMONKNGD(eIALHGLMECL, "string", string.Empty);
				kGMHJGFNPFC.NJOHMGMPGBE.JEACJNAKLDJ(mDBINBLMHMC);
			}
		}
		if (dictionary.ContainsKey("animations"))
		{
			foreach (KeyValuePair<string, object> item13 in (Dictionary<string, object>)dictionary["animations"])
			{
				try
				{
					FKKGMNDHEIP((Dictionary<string, object>)item13.Value, item13.Key, kGMHJGFNPFC);
				}
				catch (Exception innerException2)
				{
					throw new Exception("Error reading animation: " + item13.Key, innerException2);
				}
			}
		}
		kGMHJGFNPFC.LIKIOBHLHHF.PBHLDFFHPND();
		kGMHJGFNPFC.MAKCMFCFDLP.PBHLDFFHPND();
		kGMHJGFNPFC.CFPBCLCKDBM.PBHLDFFHPND();
		kGMHJGFNPFC.NJOHMGMPGBE.PBHLDFFHPND();
		kGMHJGFNPFC.BNLBLHNEJAH.PBHLDFFHPND();
		kGMHJGFNPFC.EFIPDNFLFND.PBHLDFFHPND();
		return kGMHJGFNPFC;
	}

	private OAMNGFLKEFI JNBDHGKGOJD(Dictionary<string, object> EIALHGLMECL, JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC, string IOCMOCCFALN, KGMHJGFNPFC DCMDAJJBNAI)
	{
		float num = GEBNMKAGJIG;
		IOCMOCCFALN = JDANMONKNGD(EIALHGLMECL, "name", IOCMOCCFALN);
		string text = JDANMONKNGD(EIALHGLMECL, "type", "region");
		if (text == "skinnedmesh")
		{
			text = "weightedmesh";
		}
		if (text == "weightedmesh")
		{
			text = "mesh";
		}
		if (text == "weightedlinkedmesh")
		{
			text = "linkedmesh";
		}
		KOAJPENAIBI kOAJPENAIBI = (KOAJPENAIBI)Enum.Parse(typeof(KOAJPENAIBI), text, true);
		string text2 = JDANMONKNGD(EIALHGLMECL, "path", IOCMOCCFALN);
		switch (kOAJPENAIBI)
		{
		case KOAJPENAIBI.Region:
		{
			MKEALIMJCFJ mKEALIMJCFJ = JHLKFNEOEBO.HNCBJFIPJNP(HLCFGIFLPPE, IOCMOCCFALN, text2);
			if (mKEALIMJCFJ == null)
			{
				return null;
			}
			mKEALIMJCFJ.MJCBDBIDMGF = text2;
			mKEALIMJCFJ.AMFCENFNAJJ = EOHHGHDJKLI(EIALHGLMECL, "x", 0f) * num;
			mKEALIMJCFJ.CNLILOEEBOJ = EOHHGHDJKLI(EIALHGLMECL, "y", 0f) * num;
			mKEALIMJCFJ.IAFNPOKEFMB = EOHHGHDJKLI(EIALHGLMECL, "scaleX", 1f);
			mKEALIMJCFJ.GFMCPIJHIGD = EOHHGHDJKLI(EIALHGLMECL, "scaleY", 1f);
			mKEALIMJCFJ.ODLHFMOPCHL = EOHHGHDJKLI(EIALHGLMECL, "rotation", 0f);
			mKEALIMJCFJ.HHHMOGOKFHF = EOHHGHDJKLI(EIALHGLMECL, "width", 32f) * num;
			mKEALIMJCFJ.JKNPBEOPMPK = EOHHGHDJKLI(EIALHGLMECL, "height", 32f) * num;
			mKEALIMJCFJ.MNIMJDFOILP();
			if (EIALHGLMECL.ContainsKey("color"))
			{
				string pLEGDJKNGEM2 = (string)EIALHGLMECL["color"];
				mKEALIMJCFJ.GPGDCCMECGF = EFOKMEFOFEJ(pLEGDJKNGEM2, 0);
				mKEALIMJCFJ.HJMBDGKAOBP = EFOKMEFOFEJ(pLEGDJKNGEM2, 1);
				mKEALIMJCFJ.BCIHLCMFAEK = EFOKMEFOFEJ(pLEGDJKNGEM2, 2);
				mKEALIMJCFJ.MNIMEAMHNMI = EFOKMEFOFEJ(pLEGDJKNGEM2, 3);
			}
			mKEALIMJCFJ.MNIMJDFOILP();
			return mKEALIMJCFJ;
		}
		case KOAJPENAIBI.Boundingbox:
		{
			KBLNEHAAAJK kBLNEHAAAJK = JHLKFNEOEBO.KMGJEJLCPLE(HLCFGIFLPPE, IOCMOCCFALN);
			if (kBLNEHAAAJK == null)
			{
				return null;
			}
			GHOFFCBHBGD(EIALHGLMECL, kBLNEHAAAJK, CFHAMLBKKLA(EIALHGLMECL, "vertexCount", 0) << 1);
			return kBLNEHAAAJK;
		}
		case KOAJPENAIBI.Mesh:
		case KOAJPENAIBI.Linkedmesh:
		{
			MGCLDKAFCIB mGCLDKAFCIB = JHLKFNEOEBO.MPDDHGBKGCP(HLCFGIFLPPE, IOCMOCCFALN, text2);
			if (mGCLDKAFCIB == null)
			{
				return null;
			}
			mGCLDKAFCIB.MJCBDBIDMGF = text2;
			if (EIALHGLMECL.ContainsKey("color"))
			{
				string pLEGDJKNGEM = (string)EIALHGLMECL["color"];
				mGCLDKAFCIB.GPGDCCMECGF = EFOKMEFOFEJ(pLEGDJKNGEM, 0);
				mGCLDKAFCIB.HJMBDGKAOBP = EFOKMEFOFEJ(pLEGDJKNGEM, 1);
				mGCLDKAFCIB.BCIHLCMFAEK = EFOKMEFOFEJ(pLEGDJKNGEM, 2);
				mGCLDKAFCIB.MNIMEAMHNMI = EFOKMEFOFEJ(pLEGDJKNGEM, 3);
			}
			mGCLDKAFCIB.EMFKAPJMDCC = EOHHGHDJKLI(EIALHGLMECL, "width", 0f) * num;
			mGCLDKAFCIB.FHAMOHDEGMK = EOHHGHDJKLI(EIALHGLMECL, "height", 0f) * num;
			string text4 = JDANMONKNGD(EIALHGLMECL, "parent", null);
			if (text4 != null)
			{
				mGCLDKAFCIB.CGMJOIHFNOC = JJCKAEJFAAM(EIALHGLMECL, "deform", true);
				HHDLADPAMIO.Add(new PHEALEKBPIF(mGCLDKAFCIB, JDANMONKNGD(EIALHGLMECL, "skin", null), PBPEMFGPGFC, text4));
				return mGCLDKAFCIB;
			}
			float[] array = BPIBDIGCDBD(EIALHGLMECL, "uvs", 1f);
			GHOFFCBHBGD(EIALHGLMECL, mGCLDKAFCIB, array.Length);
			mGCLDKAFCIB.NPDGLMEOKIO = GGNJNACPMNG(EIALHGLMECL, "triangles");
			mGCLDKAFCIB.OJKLIMMHOEH = array;
			mGCLDKAFCIB.IFAIOMLBIAD();
			if (EIALHGLMECL.ContainsKey("hull"))
			{
				mGCLDKAFCIB.FMABFHBBBJG = CFHAMLBKKLA(EIALHGLMECL, "hull", 0) * 2;
			}
			if (EIALHGLMECL.ContainsKey("edges"))
			{
				mGCLDKAFCIB.PEMDNNKKDPG = GGNJNACPMNG(EIALHGLMECL, "edges");
			}
			return mGCLDKAFCIB;
		}
		case KOAJPENAIBI.Path:
		{
			GMLCOKFENFN gMLCOKFENFN = JHLKFNEOEBO.HAOODEOAMHH(HLCFGIFLPPE, IOCMOCCFALN);
			if (gMLCOKFENFN == null)
			{
				return null;
			}
			gMLCOKFENFN.MBEOPLHLANP = JJCKAEJFAAM(EIALHGLMECL, "closed", false);
			gMLCOKFENFN.IKJCHJGJKGH = JJCKAEJFAAM(EIALHGLMECL, "constantSpeed", true);
			int num2 = CFHAMLBKKLA(EIALHGLMECL, "vertexCount", 0);
			GHOFFCBHBGD(EIALHGLMECL, gMLCOKFENFN, num2 << 1);
			gMLCOKFENFN.BFGGGEPJGOI = BPIBDIGCDBD(EIALHGLMECL, "lengths", num);
			return gMLCOKFENFN;
		}
		case KOAJPENAIBI.Point:
		{
			ENIPPOEKJPA eNIPPOEKJPA = JHLKFNEOEBO.NJIHKIHEHKL(HLCFGIFLPPE, IOCMOCCFALN);
			if (eNIPPOEKJPA == null)
			{
				return null;
			}
			eNIPPOEKJPA.AMFCENFNAJJ = EOHHGHDJKLI(EIALHGLMECL, "x", 0f) * num;
			eNIPPOEKJPA.CNLILOEEBOJ = EOHHGHDJKLI(EIALHGLMECL, "y", 0f) * num;
			eNIPPOEKJPA.ODLHFMOPCHL = EOHHGHDJKLI(EIALHGLMECL, "rotation", 0f);
			return eNIPPOEKJPA;
		}
		case KOAJPENAIBI.Clipping:
		{
			ACEGNBDLKEG aCEGNBDLKEG = JHLKFNEOEBO.HLKKDHKIPOC(HLCFGIFLPPE, IOCMOCCFALN);
			if (aCEGNBDLKEG == null)
			{
				return null;
			}
			string text3 = JDANMONKNGD(EIALHGLMECL, "end", null);
			if (text3 != null)
			{
				HMGLMNHOBHA hMGLMNHOBHA = DCMDAJJBNAI.MEKLNNENPDK(text3);
				if (hMGLMNHOBHA == null)
				{
					throw new Exception("Clipping end slot not found: " + text3);
				}
				aCEGNBDLKEG.OFHEPFHKOLC = hMGLMNHOBHA;
			}
			GHOFFCBHBGD(EIALHGLMECL, aCEGNBDLKEG, CFHAMLBKKLA(EIALHGLMECL, "vertexCount", 0) << 1);
			return aCEGNBDLKEG;
		}
		default:
			return null;
		}
	}

	private void GHOFFCBHBGD(Dictionary<string, object> EIALHGLMECL, LJPHFIKMDHN DFHHMKMLCFF, int IEOIFMMIKPE)
	{
		DFHHMKMLCFF.DBIIHGFAGJP = IEOIFMMIKPE;
		float[] array = BPIBDIGCDBD(EIALHGLMECL, "vertices", 1f);
		float num = GEBNMKAGJIG;
		if (IEOIFMMIKPE == array.Length)
		{
			if (num != 1f)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] *= num;
				}
			}
			DFHHMKMLCFF.FHBFCAEGPOH = array;
			return;
		}
		ExposedList<float> exposedList = new ExposedList<float>(IEOIFMMIKPE * 3 * 3);
		ExposedList<int> exposedList2 = new ExposedList<int>(IEOIFMMIKPE * 3);
		int j = 0;
		int num2 = array.Length;
		while (j < num2)
		{
			int num3 = (int)array[j++];
			exposedList2.JEACJNAKLDJ(num3);
			for (int num4 = j + num3 * 4; j < num4; j += 4)
			{
				exposedList2.JEACJNAKLDJ((int)array[j]);
				exposedList.JEACJNAKLDJ(array[j + 1] * GEBNMKAGJIG);
				exposedList.JEACJNAKLDJ(array[j + 2] * GEBNMKAGJIG);
				exposedList.JEACJNAKLDJ(array[j + 3]);
			}
		}
		DFHHMKMLCFF.LIKIOBHLHHF = exposedList2.GDPLKNIEGDB();
		DFHHMKMLCFF.FHBFCAEGPOH = exposedList.GDPLKNIEGDB();
	}

	private void FKKGMNDHEIP(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, KGMHJGFNPFC DCMDAJJBNAI)
	{
		float num = GEBNMKAGJIG;
		ExposedList<DABFMEODJHE> exposedList = new ExposedList<DABFMEODJHE>();
		float num2 = 0f;
		if (EIALHGLMECL.ContainsKey("slots"))
		{
			foreach (KeyValuePair<string, object> item in (Dictionary<string, object>)EIALHGLMECL["slots"])
			{
				string key = item.Key;
				int pBPEMFGPGFC = DCMDAJJBNAI.IBOGMECEHLD(key);
				Dictionary<string, object> dictionary = (Dictionary<string, object>)item.Value;
				foreach (KeyValuePair<string, object> item2 in dictionary)
				{
					List<object> list = (List<object>)item2.Value;
					string key2 = item2.Key;
					switch (key2)
					{
					case "attachment":
					{
						LPMOMNEGONC lPMOMNEGONC = new LPMOMNEGONC(list.Count);
						lPMOMNEGONC.PBPEMFGPGFC = pBPEMFGPGFC;
						int num4 = 0;
						foreach (Dictionary<string, object> item3 in list)
						{
							float hFLODNLEGFL2 = (float)item3["time"];
							lPMOMNEGONC.BCEFHMIKFDC(num4++, hFLODNLEGFL2, (string)item3["name"]);
						}
						exposedList.JEACJNAKLDJ(lPMOMNEGONC);
						num2 = Math.Max(num2, lPMOMNEGONC.ENBKHCNKHCC[lPMOMNEGONC.DABCDPAEDEE - 1]);
						break;
					}
					case "color":
					{
						AIHPPKDLPLG aIHPPKDLPLG = new AIHPPKDLPLG(list.Count);
						aIHPPKDLPLG.PBPEMFGPGFC = pBPEMFGPGFC;
						int num5 = 0;
						foreach (Dictionary<string, object> item4 in list)
						{
							float hFLODNLEGFL3 = (float)item4["time"];
							string pLEGDJKNGEM3 = (string)item4["color"];
							aIHPPKDLPLG.BCEFHMIKFDC(num5, hFLODNLEGFL3, EFOKMEFOFEJ(pLEGDJKNGEM3, 0), EFOKMEFOFEJ(pLEGDJKNGEM3, 1), EFOKMEFOFEJ(pLEGDJKNGEM3, 2), EFOKMEFOFEJ(pLEGDJKNGEM3, 3));
							FBDFAENOOFG(item4, aIHPPKDLPLG, num5);
							num5++;
						}
						exposedList.JEACJNAKLDJ(aIHPPKDLPLG);
						num2 = Math.Max(num2, aIHPPKDLPLG.ENBKHCNKHCC[(aIHPPKDLPLG.DABCDPAEDEE - 1) * 5]);
						break;
					}
					case "twoColor":
					{
						DKOKKMLGGJI dKOKKMLGGJI = new DKOKKMLGGJI(list.Count);
						dKOKKMLGGJI.PBPEMFGPGFC = pBPEMFGPGFC;
						int num3 = 0;
						foreach (Dictionary<string, object> item5 in list)
						{
							float hFLODNLEGFL = (float)item5["time"];
							string pLEGDJKNGEM = (string)item5["light"];
							string pLEGDJKNGEM2 = (string)item5["dark"];
							dKOKKMLGGJI.BCEFHMIKFDC(num3, hFLODNLEGFL, EFOKMEFOFEJ(pLEGDJKNGEM, 0), EFOKMEFOFEJ(pLEGDJKNGEM, 1), EFOKMEFOFEJ(pLEGDJKNGEM, 2), EFOKMEFOFEJ(pLEGDJKNGEM, 3), EFOKMEFOFEJ(pLEGDJKNGEM2, 0, 6), EFOKMEFOFEJ(pLEGDJKNGEM2, 1, 6), EFOKMEFOFEJ(pLEGDJKNGEM2, 2, 6));
							FBDFAENOOFG(item5, dKOKKMLGGJI, num3);
							num3++;
						}
						exposedList.JEACJNAKLDJ(dKOKKMLGGJI);
						num2 = Math.Max(num2, dKOKKMLGGJI.ENBKHCNKHCC[(dKOKKMLGGJI.DABCDPAEDEE - 1) * 8]);
						break;
					}
					default:
						throw new Exception("Invalid timeline type for a slot: " + key2 + " (" + key + ")");
					}
				}
			}
		}
		if (EIALHGLMECL.ContainsKey("bones"))
		{
			foreach (KeyValuePair<string, object> item6 in (Dictionary<string, object>)EIALHGLMECL["bones"])
			{
				string key3 = item6.Key;
				int num6 = DCMDAJJBNAI.EENCKHAKMIO(key3);
				if (num6 == -1)
				{
					throw new Exception("Bone not found: " + key3);
				}
				Dictionary<string, object> dictionary5 = (Dictionary<string, object>)item6.Value;
				foreach (KeyValuePair<string, object> item7 in dictionary5)
				{
					List<object> list2 = (List<object>)item7.Value;
					string key4 = item7.Key;
					switch (key4)
					{
					case "rotate":
					{
						GFNJOILFDNB gFNJOILFDNB = new GFNJOILFDNB(list2.Count);
						gFNJOILFDNB.DHJJGGGLNNH = num6;
						int num11 = 0;
						foreach (Dictionary<string, object> item8 in list2)
						{
							gFNJOILFDNB.BCEFHMIKFDC(num11, (float)item8["time"], (float)item8["angle"]);
							FBDFAENOOFG(item8, gFNJOILFDNB, num11);
							num11++;
						}
						exposedList.JEACJNAKLDJ(gFNJOILFDNB);
						num2 = Math.Max(num2, gFNJOILFDNB.ENBKHCNKHCC[(gFNJOILFDNB.DABCDPAEDEE - 1) * 2]);
						break;
					}
					case "translate":
					case "scale":
					case "shear":
					{
						float num7 = 1f;
						CPCLJAHCDGN cPCLJAHCDGN;
						if (key4 == "scale")
						{
							cPCLJAHCDGN = new CFHAEHPHFEI(list2.Count);
						}
						else if (key4 == "shear")
						{
							cPCLJAHCDGN = new GLKBNKGOCDE(list2.Count);
						}
						else
						{
							cPCLJAHCDGN = new CPCLJAHCDGN(list2.Count);
							num7 = num;
						}
						cPCLJAHCDGN.DHJJGGGLNNH = num6;
						int num8 = 0;
						foreach (Dictionary<string, object> item9 in list2)
						{
							float hFLODNLEGFL4 = (float)item9["time"];
							float num9 = EOHHGHDJKLI(item9, "x", 0f);
							float num10 = EOHHGHDJKLI(item9, "y", 0f);
							cPCLJAHCDGN.BCEFHMIKFDC(num8, hFLODNLEGFL4, num9 * num7, num10 * num7);
							FBDFAENOOFG(item9, cPCLJAHCDGN, num8);
							num8++;
						}
						exposedList.JEACJNAKLDJ(cPCLJAHCDGN);
						num2 = Math.Max(num2, cPCLJAHCDGN.ENBKHCNKHCC[(cPCLJAHCDGN.DABCDPAEDEE - 1) * 3]);
						break;
					}
					default:
						throw new Exception("Invalid timeline type for a bone: " + key4 + " (" + key3 + ")");
					}
				}
			}
		}
		if (EIALHGLMECL.ContainsKey("ik"))
		{
			foreach (KeyValuePair<string, object> item10 in (Dictionary<string, object>)EIALHGLMECL["ik"])
			{
				BMELPEKHKKJ eJCNAJOHBFI = DCMDAJJBNAI.DMNEHMNNCAD(item10.Key);
				List<object> list3 = (List<object>)item10.Value;
				MGCNHAGJEIE mGCNHAGJEIE = new MGCNHAGJEIE(list3.Count);
				mGCNHAGJEIE.GOPEKHCFFGB = DCMDAJJBNAI.EFIPDNFLFND.NFLFPHCMIOK(eJCNAJOHBFI);
				int num12 = 0;
				foreach (Dictionary<string, object> item11 in list3)
				{
					float hFLODNLEGFL5 = (float)item11["time"];
					float mIIHPKNIPAB = EOHHGHDJKLI(item11, "mix", 1f);
					bool flag = JJCKAEJFAAM(item11, "bendPositive", true);
					mGCNHAGJEIE.BCEFHMIKFDC(num12, hFLODNLEGFL5, mIIHPKNIPAB, flag ? 1 : (-1));
					FBDFAENOOFG(item11, mGCNHAGJEIE, num12);
					num12++;
				}
				exposedList.JEACJNAKLDJ(mGCNHAGJEIE);
				num2 = Math.Max(num2, mGCNHAGJEIE.ENBKHCNKHCC[(mGCNHAGJEIE.DABCDPAEDEE - 1) * 3]);
			}
		}
		if (EIALHGLMECL.ContainsKey("transform"))
		{
			foreach (KeyValuePair<string, object> item12 in (Dictionary<string, object>)EIALHGLMECL["transform"])
			{
				MNNBOEPCJGP eJCNAJOHBFI2 = DCMDAJJBNAI.ACIMONIELHI(item12.Key);
				List<object> list4 = (List<object>)item12.Value;
				BNODOKNKNDG bNODOKNKNDG = new BNODOKNKNDG(list4.Count);
				bNODOKNKNDG.JEJEFHFBHAJ = DCMDAJJBNAI.FOANDHFONAA.NFLFPHCMIOK(eJCNAJOHBFI2);
				int num13 = 0;
				foreach (Dictionary<string, object> item13 in list4)
				{
					float hFLODNLEGFL6 = (float)item13["time"];
					float oIBAIJIPGOM = EOHHGHDJKLI(item13, "rotateMix", 1f);
					float dHNKOEMONHP = EOHHGHDJKLI(item13, "translateMix", 1f);
					float dLEIMBNDMOF = EOHHGHDJKLI(item13, "scaleMix", 1f);
					float oKJBKNEPKPN = EOHHGHDJKLI(item13, "shearMix", 1f);
					bNODOKNKNDG.BCEFHMIKFDC(num13, hFLODNLEGFL6, oIBAIJIPGOM, dHNKOEMONHP, dLEIMBNDMOF, oKJBKNEPKPN);
					FBDFAENOOFG(item13, bNODOKNKNDG, num13);
					num13++;
				}
				exposedList.JEACJNAKLDJ(bNODOKNKNDG);
				num2 = Math.Max(num2, bNODOKNKNDG.ENBKHCNKHCC[(bNODOKNKNDG.DABCDPAEDEE - 1) * 5]);
			}
		}
		if (EIALHGLMECL.ContainsKey("paths"))
		{
			foreach (KeyValuePair<string, object> item14 in (Dictionary<string, object>)EIALHGLMECL["paths"])
			{
				int num14 = DCMDAJJBNAI.CEDOGALELLO(item14.Key);
				if (num14 == -1)
				{
					throw new Exception("Path constraint not found: " + item14.Key);
				}
				GJNEKNOKICF gJNEKNOKICF = DCMDAJJBNAI.NDOOCKKIMHO.Items[num14];
				Dictionary<string, object> dictionary10 = (Dictionary<string, object>)item14.Value;
				foreach (KeyValuePair<string, object> item15 in dictionary10)
				{
					List<object> list5 = (List<object>)item15.Value;
					string key5 = item15.Key;
					switch (key5)
					{
					case "position":
					case "spacing":
					{
						float num16 = 1f;
						BLIEJOGKBBN bLIEJOGKBBN;
						if (key5 == "spacing")
						{
							bLIEJOGKBBN = new NHPAKKGJBBI(list5.Count);
							if (gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Length || gJNEKNOKICF.ENMOCNJMBKD == OIGFPANDDIM.Fixed)
							{
								num16 = num;
							}
						}
						else
						{
							bLIEJOGKBBN = new BLIEJOGKBBN(list5.Count);
							if (gJNEKNOKICF.FMJFEKINFLF == KMDGGFDOOPL.Fixed)
							{
								num16 = num;
							}
						}
						bLIEJOGKBBN.CFOGCDKFLIH = num14;
						int num17 = 0;
						foreach (Dictionary<string, object> item16 in list5)
						{
							bLIEJOGKBBN.BCEFHMIKFDC(num17, (float)item16["time"], EOHHGHDJKLI(item16, key5, 0f) * num16);
							FBDFAENOOFG(item16, bLIEJOGKBBN, num17);
							num17++;
						}
						exposedList.JEACJNAKLDJ(bLIEJOGKBBN);
						num2 = Math.Max(num2, bLIEJOGKBBN.ENBKHCNKHCC[(bLIEJOGKBBN.DABCDPAEDEE - 1) * 2]);
						break;
					}
					case "mix":
					{
						DKEAHBHKOLB dKEAHBHKOLB = new DKEAHBHKOLB(list5.Count);
						dKEAHBHKOLB.CFOGCDKFLIH = num14;
						int num15 = 0;
						foreach (Dictionary<string, object> item17 in list5)
						{
							dKEAHBHKOLB.BCEFHMIKFDC(num15, (float)item17["time"], EOHHGHDJKLI(item17, "rotateMix", 1f), EOHHGHDJKLI(item17, "translateMix", 1f));
							FBDFAENOOFG(item17, dKEAHBHKOLB, num15);
							num15++;
						}
						exposedList.JEACJNAKLDJ(dKEAHBHKOLB);
						num2 = Math.Max(num2, dKEAHBHKOLB.ENBKHCNKHCC[(dKEAHBHKOLB.DABCDPAEDEE - 1) * 3]);
						break;
					}
					}
				}
			}
		}
		if (EIALHGLMECL.ContainsKey("deform"))
		{
			foreach (KeyValuePair<string, object> item18 in (Dictionary<string, object>)EIALHGLMECL["deform"])
			{
				JPAALKCPGNB jPAALKCPGNB = DCMDAJJBNAI.COONIJFPADF(item18.Key);
				foreach (KeyValuePair<string, object> item19 in (Dictionary<string, object>)item18.Value)
				{
					int num18 = DCMDAJJBNAI.IBOGMECEHLD(item19.Key);
					if (num18 == -1)
					{
						throw new Exception("Slot not found: " + item19.Key);
					}
					foreach (KeyValuePair<string, object> item20 in (Dictionary<string, object>)item19.Value)
					{
						List<object> list6 = (List<object>)item20.Value;
						LJPHFIKMDHN lJPHFIKMDHN = (LJPHFIKMDHN)jPAALKCPGNB.JGHJDGIANDD(num18, item20.Key);
						if (lJPHFIKMDHN == null)
						{
							throw new Exception("Deform attachment not found: " + item20.Key);
						}
						bool flag2 = lJPHFIKMDHN.LIKIOBHLHHF != null;
						float[] fHBFCAEGPOH = lJPHFIKMDHN.FHBFCAEGPOH;
						int num19 = ((!flag2) ? fHBFCAEGPOH.Length : (fHBFCAEGPOH.Length / 3 * 2));
						BJBLIIGICII bJBLIIGICII = new BJBLIIGICII(list6.Count);
						bJBLIIGICII.PBPEMFGPGFC = num18;
						bJBLIIGICII.DFHHMKMLCFF = lJPHFIKMDHN;
						int num20 = 0;
						foreach (Dictionary<string, object> item21 in list6)
						{
							float[] array;
							if (!item21.ContainsKey("vertices"))
							{
								array = ((!flag2) ? fHBFCAEGPOH : new float[num19]);
							}
							else
							{
								array = new float[num19];
								int num21 = CFHAMLBKKLA(item21, "offset", 0);
								float[] array2 = BPIBDIGCDBD(item21, "vertices", 1f);
								Array.Copy(array2, 0, array, num21, array2.Length);
								if (num != 1f)
								{
									int i = num21;
									for (int num22 = i + array2.Length; i < num22; i++)
									{
										array[i] *= num;
									}
								}
								if (!flag2)
								{
									for (int j = 0; j < num19; j++)
									{
										array[j] += fHBFCAEGPOH[j];
									}
								}
							}
							bJBLIIGICII.BCEFHMIKFDC(num20, (float)item21["time"], array);
							FBDFAENOOFG(item21, bJBLIIGICII, num20);
							num20++;
						}
						exposedList.JEACJNAKLDJ(bJBLIIGICII);
						num2 = Math.Max(num2, bJBLIIGICII.ENBKHCNKHCC[bJBLIIGICII.DABCDPAEDEE - 1]);
					}
				}
			}
		}
		if (EIALHGLMECL.ContainsKey("drawOrder") || EIALHGLMECL.ContainsKey("draworder"))
		{
			List<object> list7 = (List<object>)EIALHGLMECL[(!EIALHGLMECL.ContainsKey("drawOrder")) ? "draworder" : "drawOrder"];
			HHDOJIEJCGJ hHDOJIEJCGJ = new HHDOJIEJCGJ(list7.Count);
			int count = DCMDAJJBNAI.MAKCMFCFDLP.Count;
			int num23 = 0;
			foreach (Dictionary<string, object> item22 in list7)
			{
				int[] array3 = null;
				if (item22.ContainsKey("offsets"))
				{
					array3 = new int[count];
					for (int num24 = count - 1; num24 >= 0; num24--)
					{
						array3[num24] = -1;
					}
					List<object> list8 = (List<object>)item22["offsets"];
					int[] array4 = new int[count - list8.Count];
					int num25 = 0;
					int num26 = 0;
					foreach (Dictionary<string, object> item23 in list8)
					{
						int num27 = DCMDAJJBNAI.IBOGMECEHLD((string)item23["slot"]);
						if (num27 == -1)
						{
							throw new Exception("Slot not found: " + item23["slot"]);
						}
						while (num25 != num27)
						{
							array4[num26++] = num25++;
						}
						int num28 = num25 + (int)(float)item23["offset"];
						array3[num28] = num25++;
					}
					while (num25 < count)
					{
						array4[num26++] = num25++;
					}
					for (int num29 = count - 1; num29 >= 0; num29--)
					{
						if (array3[num29] == -1)
						{
							array3[num29] = array4[--num26];
						}
					}
				}
				hHDOJIEJCGJ.BCEFHMIKFDC(num23++, (float)item22["time"], array3);
			}
			exposedList.JEACJNAKLDJ(hHDOJIEJCGJ);
			num2 = Math.Max(num2, hHDOJIEJCGJ.ENBKHCNKHCC[hHDOJIEJCGJ.DABCDPAEDEE - 1]);
		}
		if (EIALHGLMECL.ContainsKey("events"))
		{
			List<object> list9 = (List<object>)EIALHGLMECL["events"];
			JKFAGIAHNNK jKFAGIAHNNK = new JKFAGIAHNNK(list9.Count);
			int num30 = 0;
			foreach (Dictionary<string, object> item24 in list9)
			{
				MDBINBLMHMC mDBINBLMHMC = DCMDAJJBNAI.JNEAMBOCBII((string)item24["name"]);
				if (mDBINBLMHMC == null)
				{
					throw new Exception("Event not found: " + item24["name"]);
				}
				DCBJAMHBAJB dCBJAMHBAJB = new DCBJAMHBAJB((float)item24["time"], mDBINBLMHMC);
				dCBJAMHBAJB.IOCBLKCOMGI = CFHAMLBKKLA(item24, "int", mDBINBLMHMC.IOCBLKCOMGI);
				dCBJAMHBAJB.NCGJMNFFOJH = EOHHGHDJKLI(item24, "float", mDBINBLMHMC.NCGJMNFFOJH);
				dCBJAMHBAJB.BECLAMGPAGN = JDANMONKNGD(item24, "string", mDBINBLMHMC.BECLAMGPAGN);
				jKFAGIAHNNK.BCEFHMIKFDC(num30++, dCBJAMHBAJB);
			}
			exposedList.JEACJNAKLDJ(jKFAGIAHNNK);
			num2 = Math.Max(num2, jKFAGIAHNNK.ENBKHCNKHCC[jKFAGIAHNNK.DABCDPAEDEE - 1]);
		}
		exposedList.PBHLDFFHPND();
		DCMDAJJBNAI.BNLBLHNEJAH.JEACJNAKLDJ(new GNGKKPOGGGM(IOCMOCCFALN, exposedList, num2));
	}

	private static void FBDFAENOOFG(Dictionary<string, object> IEIGEAKCJBO, FPOBLOBNHGG CEMIIGGAEHH, int JHFDIBIBCPH)
	{
		if (!IEIGEAKCJBO.ContainsKey("curve"))
		{
			return;
		}
		object obj = IEIGEAKCJBO["curve"];
		if (obj.Equals("stepped"))
		{
			CEMIIGGAEHH.FGGBGOFPDAD(JHFDIBIBCPH);
			return;
		}
		List<object> list = obj as List<object>;
		if (list != null)
		{
			CEMIIGGAEHH.MHALBIPKNGP(JHFDIBIBCPH, (float)list[0], (float)list[1], (float)list[2], (float)list[3]);
		}
	}

	private static float[] BPIBDIGCDBD(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, float HJLOCAEAFMJ)
	{
		List<object> list = (List<object>)EIALHGLMECL[IOCMOCCFALN];
		float[] array = new float[list.Count];
		if (HJLOCAEAFMJ == 1f)
		{
			int i = 0;
			for (int count = list.Count; i < count; i++)
			{
				array[i] = (float)list[i];
			}
		}
		else
		{
			int j = 0;
			for (int count2 = list.Count; j < count2; j++)
			{
				array[j] = (float)list[j] * HJLOCAEAFMJ;
			}
		}
		return array;
	}

	private static int[] GGNJNACPMNG(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN)
	{
		List<object> list = (List<object>)EIALHGLMECL[IOCMOCCFALN];
		int[] array = new int[list.Count];
		int i = 0;
		for (int count = list.Count; i < count; i++)
		{
			array[i] = (int)(float)list[i];
		}
		return array;
	}

	private static float EOHHGHDJKLI(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, float DLJMKKALKBD)
	{
		if (!EIALHGLMECL.ContainsKey(IOCMOCCFALN))
		{
			return DLJMKKALKBD;
		}
		return (float)EIALHGLMECL[IOCMOCCFALN];
	}

	private static int CFHAMLBKKLA(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, int DLJMKKALKBD)
	{
		if (!EIALHGLMECL.ContainsKey(IOCMOCCFALN))
		{
			return DLJMKKALKBD;
		}
		return (int)(float)EIALHGLMECL[IOCMOCCFALN];
	}

	private static bool JJCKAEJFAAM(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, bool DLJMKKALKBD)
	{
		if (!EIALHGLMECL.ContainsKey(IOCMOCCFALN))
		{
			return DLJMKKALKBD;
		}
		return (bool)EIALHGLMECL[IOCMOCCFALN];
	}

	private static string JDANMONKNGD(Dictionary<string, object> EIALHGLMECL, string IOCMOCCFALN, string DLJMKKALKBD)
	{
		if (!EIALHGLMECL.ContainsKey(IOCMOCCFALN))
		{
			return DLJMKKALKBD;
		}
		return (string)EIALHGLMECL[IOCMOCCFALN];
	}

	private static float EFOKMEFOFEJ(string PLEGDJKNGEM, int OAKMHDKMGHA, int LCPGHLEPDBC = 8)
	{
		if (PLEGDJKNGEM.Length != LCPGHLEPDBC)
		{
			throw new ArgumentException("Color hexidecimal length must be " + LCPGHLEPDBC + ", recieved: " + PLEGDJKNGEM, "hexString");
		}
		return (float)Convert.ToInt32(PLEGDJKNGEM.Substring(OAKMHDKMGHA * 2, 2), 16) / 255f;
	}
}
