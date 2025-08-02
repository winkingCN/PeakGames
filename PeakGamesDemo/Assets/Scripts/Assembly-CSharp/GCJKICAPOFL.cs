using System;
using System.Collections.Generic;
using Spine;

public class GCJKICAPOFL
{
	internal KGMHJGFNPFC MBBPBGHKLJM;

	internal ExposedList<NBKCFDOMAPI> LIKIOBHLHHF;

	internal ExposedList<LBBAMMPJKDA> MAKCMFCFDLP;

	internal ExposedList<LBBAMMPJKDA> COACJAFIPEI;

	internal ExposedList<JICANJGGKNH> EFIPDNFLFND;

	internal ExposedList<DLKMEPPLCGM> FOANDHFONAA;

	internal ExposedList<KNKKDGIBGLM> NDOOCKKIMHO;

	internal ExposedList<PMGDFPKMKNH> LFBIJLCNELM = new ExposedList<PMGDFPKMKNH>();

	internal ExposedList<NBKCFDOMAPI> PKMLALJKOHL = new ExposedList<NBKCFDOMAPI>();

	internal JPAALKCPGNB HLCFGIFLPPE;

	internal float GPGDCCMECGF = 1f;

	internal float HJMBDGKAOBP = 1f;

	internal float BCIHLCMFAEK = 1f;

	internal float MNIMEAMHNMI = 1f;

	internal float HFLODNLEGFL;

	internal bool FNEPOOBKNLF;

	internal bool AIPMEJLIOFD;

	internal float AMFCENFNAJJ;

	internal float CNLILOEEBOJ;

	public KGMHJGFNPFC LJDLCPHOBHB
	{
		get
		{
			return MBBPBGHKLJM;
		}
	}

	public ExposedList<NBKCFDOMAPI> PGACGAFEFHD
	{
		get
		{
			return LIKIOBHLHHF;
		}
	}

	public ExposedList<PMGDFPKMKNH> JOKDHLNJPCN
	{
		get
		{
			return LFBIJLCNELM;
		}
	}

	public ExposedList<LBBAMMPJKDA> BKDKEAAAMBB
	{
		get
		{
			return MAKCMFCFDLP;
		}
	}

	public ExposedList<LBBAMMPJKDA> GHKJECCFOPF
	{
		get
		{
			return COACJAFIPEI;
		}
	}

	public ExposedList<JICANJGGKNH> PCBLMDHFHII
	{
		get
		{
			return EFIPDNFLFND;
		}
	}

	public ExposedList<KNKKDGIBGLM> BHMEEPKAJOF
	{
		get
		{
			return NDOOCKKIMHO;
		}
	}

	public ExposedList<DLKMEPPLCGM> GOCDIAICJKK
	{
		get
		{
			return FOANDHFONAA;
		}
	}

	public JPAALKCPGNB NIADHAHOPKG
	{
		get
		{
			return HLCFGIFLPPE;
		}
		set
		{
			HLCFGIFLPPE = value;
		}
	}

	public float GOEFJMNOBHA
	{
		get
		{
			return GPGDCCMECGF;
		}
		set
		{
			GPGDCCMECGF = value;
		}
	}

	public float HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
		set
		{
			HJMBDGKAOBP = value;
		}
	}

	public float FPKDKHJKEEF
	{
		get
		{
			return BCIHLCMFAEK;
		}
		set
		{
			BCIHLCMFAEK = value;
		}
	}

	public float JEHECJGFJEB
	{
		get
		{
			return MNIMEAMHNMI;
		}
		set
		{
			MNIMEAMHNMI = value;
		}
	}

	public float PFNNFPIDHFN
	{
		get
		{
			return HFLODNLEGFL;
		}
		set
		{
			HFLODNLEGFL = value;
		}
	}

	public float CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
		set
		{
			AMFCENFNAJJ = value;
		}
	}

	public float MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
		set
		{
			CNLILOEEBOJ = value;
		}
	}

	public bool FPHHECMJJBI
	{
		get
		{
			return FNEPOOBKNLF;
		}
		set
		{
			FNEPOOBKNLF = value;
		}
	}

	public bool NIPKPCNJCLJ
	{
		get
		{
			return AIPMEJLIOFD;
		}
		set
		{
			AIPMEJLIOFD = value;
		}
	}

	public NBKCFDOMAPI POOHJHBAMCJ
	{
		get
		{
			return (LIKIOBHLHHF.Count != 0) ? LIKIOBHLHHF.Items[0] : null;
		}
	}

	public GCJKICAPOFL(KGMHJGFNPFC MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM == null)
		{
			throw new ArgumentNullException("data", "data cannot be null.");
		}
		this.MBBPBGHKLJM = MBBPBGHKLJM;
		LIKIOBHLHHF = new ExposedList<NBKCFDOMAPI>(MBBPBGHKLJM.LIKIOBHLHHF.Count);
		using (ExposedList<GPJIPDIEIIL>.Enumerator enumerator = MBBPBGHKLJM.LIKIOBHLHHF.FIFMNBJLBFK())
		{
			while (enumerator.MoveNext())
			{
				GPJIPDIEIIL current = enumerator.Current;
				NBKCFDOMAPI eJCNAJOHBFI;
				if (current.LIMMFGDCLAB == null)
				{
					eJCNAJOHBFI = new NBKCFDOMAPI(current, this, null);
				}
				else
				{
					NBKCFDOMAPI nBKCFDOMAPI = LIKIOBHLHHF.Items[current.LIMMFGDCLAB.EHJNMODJEAN];
					eJCNAJOHBFI = new NBKCFDOMAPI(current, this, nBKCFDOMAPI);
					nBKCFDOMAPI.NLADMJEEGNJ.JEACJNAKLDJ(eJCNAJOHBFI);
				}
				LIKIOBHLHHF.JEACJNAKLDJ(eJCNAJOHBFI);
			}
		}
		MAKCMFCFDLP = new ExposedList<LBBAMMPJKDA>(MBBPBGHKLJM.MAKCMFCFDLP.Count);
		COACJAFIPEI = new ExposedList<LBBAMMPJKDA>(MBBPBGHKLJM.MAKCMFCFDLP.Count);
		using (ExposedList<HMGLMNHOBHA>.Enumerator enumerator2 = MBBPBGHKLJM.MAKCMFCFDLP.FIFMNBJLBFK())
		{
			while (enumerator2.MoveNext())
			{
				HMGLMNHOBHA current2 = enumerator2.Current;
				NBKCFDOMAPI jEBEPBEGCCF = LIKIOBHLHHF.Items[current2.JJLEOELOOJP.EHJNMODJEAN];
				LBBAMMPJKDA eJCNAJOHBFI2 = new LBBAMMPJKDA(current2, jEBEPBEGCCF);
				MAKCMFCFDLP.JEACJNAKLDJ(eJCNAJOHBFI2);
				COACJAFIPEI.JEACJNAKLDJ(eJCNAJOHBFI2);
			}
		}
		EFIPDNFLFND = new ExposedList<JICANJGGKNH>(MBBPBGHKLJM.EFIPDNFLFND.Count);
		using (ExposedList<BMELPEKHKKJ>.Enumerator enumerator3 = MBBPBGHKLJM.EFIPDNFLFND.FIFMNBJLBFK())
		{
			while (enumerator3.MoveNext())
			{
				BMELPEKHKKJ current3 = enumerator3.Current;
				EFIPDNFLFND.JEACJNAKLDJ(new JICANJGGKNH(current3, this));
			}
		}
		FOANDHFONAA = new ExposedList<DLKMEPPLCGM>(MBBPBGHKLJM.FOANDHFONAA.Count);
		using (ExposedList<MNNBOEPCJGP>.Enumerator enumerator4 = MBBPBGHKLJM.FOANDHFONAA.FIFMNBJLBFK())
		{
			while (enumerator4.MoveNext())
			{
				MNNBOEPCJGP current4 = enumerator4.Current;
				FOANDHFONAA.JEACJNAKLDJ(new DLKMEPPLCGM(current4, this));
			}
		}
		NDOOCKKIMHO = new ExposedList<KNKKDGIBGLM>(MBBPBGHKLJM.NDOOCKKIMHO.Count);
		using (ExposedList<GJNEKNOKICF>.Enumerator enumerator5 = MBBPBGHKLJM.NDOOCKKIMHO.FIFMNBJLBFK())
		{
			while (enumerator5.MoveNext())
			{
				GJNEKNOKICF current5 = enumerator5.Current;
				NDOOCKKIMHO.JEACJNAKLDJ(new KNKKDGIBGLM(current5, this));
			}
		}
		CKFDCJIICFH();
		DGCKCELHAEG();
	}

	public void CKFDCJIICFH()
	{
		ExposedList<PMGDFPKMKNH> lFBIJLCNELM = LFBIJLCNELM;
		lFBIJLCNELM.BOPEPLONIFL();
		PKMLALJKOHL.BOPEPLONIFL();
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = LIKIOBHLHHF;
		int i = 0;
		for (int count = lIKIOBHLHHF.Count; i < count; i++)
		{
			lIKIOBHLHHF.Items[i].PCPLCHABPPO = false;
		}
		ExposedList<JICANJGGKNH> eFIPDNFLFND = EFIPDNFLFND;
		ExposedList<DLKMEPPLCGM> fOANDHFONAA = FOANDHFONAA;
		ExposedList<KNKKDGIBGLM> nDOOCKKIMHO = NDOOCKKIMHO;
		int count2 = PCBLMDHFHII.Count;
		int count3 = fOANDHFONAA.Count;
		int count4 = nDOOCKKIMHO.Count;
		int num = count2 + count3 + count4;
		for (int j = 0; j < num; j++)
		{
			int num2 = 0;
			while (true)
			{
				if (num2 < count2)
				{
					JICANJGGKNH jICANJGGKNH = eFIPDNFLFND.Items[num2];
					if (jICANJGGKNH.MBBPBGHKLJM.CMAJLIAELDP == j)
					{
						PKDEHBNKHCM(jICANJGGKNH);
						break;
					}
					num2++;
					continue;
				}
				int num3 = 0;
				while (true)
				{
					if (num3 < count3)
					{
						DLKMEPPLCGM dLKMEPPLCGM = fOANDHFONAA.Items[num3];
						if (dLKMEPPLCGM.MBBPBGHKLJM.CMAJLIAELDP == j)
						{
							DEOPDIDDIGA(dLKMEPPLCGM);
							break;
						}
						num3++;
						continue;
					}
					for (int k = 0; k < count4; k++)
					{
						KNKKDGIBGLM kNKKDGIBGLM = nDOOCKKIMHO.Items[k];
						if (kNKKDGIBGLM.MBBPBGHKLJM.CMAJLIAELDP == j)
						{
							FHIIAHGHMDM(kNKKDGIBGLM);
							break;
						}
					}
					break;
				}
				break;
			}
		}
		int l = 0;
		for (int count5 = lIKIOBHLHHF.Count; l < count5; l++)
		{
			LDALHEBPCJB(lIKIOBHLHHF.Items[l]);
		}
	}

	private void PKDEHBNKHCM(JICANJGGKNH KODAFOCDPLA)
	{
		NBKCFDOMAPI cAEMELGEOAE = KODAFOCDPLA.CAEMELGEOAE;
		LDALHEBPCJB(cAEMELGEOAE);
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = KODAFOCDPLA.LIKIOBHLHHF;
		NBKCFDOMAPI nBKCFDOMAPI = lIKIOBHLHHF.Items[0];
		LDALHEBPCJB(nBKCFDOMAPI);
		if (lIKIOBHLHHF.Count > 1)
		{
			NBKCFDOMAPI eJCNAJOHBFI = lIKIOBHLHHF.Items[lIKIOBHLHHF.Count - 1];
			if (!LFBIJLCNELM.KMDACNACKII(eJCNAJOHBFI))
			{
				PKMLALJKOHL.JEACJNAKLDJ(eJCNAJOHBFI);
			}
		}
		LFBIJLCNELM.JEACJNAKLDJ(KODAFOCDPLA);
		ANMMLPCLHBA(nBKCFDOMAPI.NLADMJEEGNJ);
		lIKIOBHLHHF.Items[lIKIOBHLHHF.Count - 1].PCPLCHABPPO = true;
	}

	private void FHIIAHGHMDM(KNKKDGIBGLM KODAFOCDPLA)
	{
		LBBAMMPJKDA cAEMELGEOAE = KODAFOCDPLA.CAEMELGEOAE;
		int eHJNMODJEAN = cAEMELGEOAE.MBBPBGHKLJM.EHJNMODJEAN;
		NBKCFDOMAPI jEBEPBEGCCF = cAEMELGEOAE.JEBEPBEGCCF;
		if (HLCFGIFLPPE != null)
		{
			LHCCABPHPEP(HLCFGIFLPPE, eHJNMODJEAN, jEBEPBEGCCF);
		}
		if (MBBPBGHKLJM.NAKPPHNCJOC != null && MBBPBGHKLJM.NAKPPHNCJOC != HLCFGIFLPPE)
		{
			LHCCABPHPEP(MBBPBGHKLJM.NAKPPHNCJOC, eHJNMODJEAN, jEBEPBEGCCF);
		}
		int i = 0;
		for (int count = MBBPBGHKLJM.CFPBCLCKDBM.Count; i < count; i++)
		{
			LHCCABPHPEP(MBBPBGHKLJM.CFPBCLCKDBM.Items[i], eHJNMODJEAN, jEBEPBEGCCF);
		}
		OAMNGFLKEFI dFHHMKMLCFF = cAEMELGEOAE.DFHHMKMLCFF;
		if (dFHHMKMLCFF is GMLCOKFENFN)
		{
			LHCCABPHPEP(dFHHMKMLCFF, jEBEPBEGCCF);
		}
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = KODAFOCDPLA.LIKIOBHLHHF;
		int count2 = lIKIOBHLHHF.Count;
		for (int j = 0; j < count2; j++)
		{
			LDALHEBPCJB(lIKIOBHLHHF.Items[j]);
		}
		LFBIJLCNELM.JEACJNAKLDJ(KODAFOCDPLA);
		for (int k = 0; k < count2; k++)
		{
			ANMMLPCLHBA(lIKIOBHLHHF.Items[k].NLADMJEEGNJ);
		}
		for (int l = 0; l < count2; l++)
		{
			lIKIOBHLHHF.Items[l].PCPLCHABPPO = true;
		}
	}

	private void DEOPDIDDIGA(DLKMEPPLCGM KODAFOCDPLA)
	{
		LDALHEBPCJB(KODAFOCDPLA.CAEMELGEOAE);
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = KODAFOCDPLA.LIKIOBHLHHF;
		int count = lIKIOBHLHHF.Count;
		if (KODAFOCDPLA.MBBPBGHKLJM.ACIIIFFOMEC)
		{
			for (int i = 0; i < count; i++)
			{
				NBKCFDOMAPI nBKCFDOMAPI = lIKIOBHLHHF.Items[i];
				LDALHEBPCJB(nBKCFDOMAPI.LIMMFGDCLAB);
				if (!LFBIJLCNELM.KMDACNACKII(nBKCFDOMAPI))
				{
					PKMLALJKOHL.JEACJNAKLDJ(nBKCFDOMAPI);
				}
			}
		}
		else
		{
			for (int j = 0; j < count; j++)
			{
				LDALHEBPCJB(lIKIOBHLHHF.Items[j]);
			}
		}
		LFBIJLCNELM.JEACJNAKLDJ(KODAFOCDPLA);
		for (int k = 0; k < count; k++)
		{
			ANMMLPCLHBA(lIKIOBHLHHF.Items[k].NLADMJEEGNJ);
		}
		for (int l = 0; l < count; l++)
		{
			lIKIOBHLHHF.Items[l].PCPLCHABPPO = true;
		}
	}

	private void LHCCABPHPEP(JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC, NBKCFDOMAPI DCMBBAEANKD)
	{
		foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item in HLCFGIFLPPE.NLADLMOLKLK)
		{
			if (item.Key.PBPEMFGPGFC == PBPEMFGPGFC)
			{
				LHCCABPHPEP(item.Value, DCMBBAEANKD);
			}
		}
	}

	private void LHCCABPHPEP(OAMNGFLKEFI DFHHMKMLCFF, NBKCFDOMAPI DCMBBAEANKD)
	{
		if (!(DFHHMKMLCFF is GMLCOKFENFN))
		{
			return;
		}
		int[] lIKIOBHLHHF = ((GMLCOKFENFN)DFHHMKMLCFF).LIKIOBHLHHF;
		if (lIKIOBHLHHF == null)
		{
			LDALHEBPCJB(DCMBBAEANKD);
			return;
		}
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF2 = LIKIOBHLHHF;
		int num = 0;
		int num2 = lIKIOBHLHHF.Length;
		while (num < num2)
		{
			int num3 = lIKIOBHLHHF[num++];
			num3 += num;
			while (num < num3)
			{
				LDALHEBPCJB(lIKIOBHLHHF2.Items[lIKIOBHLHHF[num++]]);
			}
		}
	}

	private void LDALHEBPCJB(NBKCFDOMAPI JEBEPBEGCCF)
	{
		if (!JEBEPBEGCCF.PCPLCHABPPO)
		{
			NBKCFDOMAPI lIMMFGDCLAB = JEBEPBEGCCF.LIMMFGDCLAB;
			if (lIMMFGDCLAB != null)
			{
				LDALHEBPCJB(lIMMFGDCLAB);
			}
			JEBEPBEGCCF.PCPLCHABPPO = true;
			LFBIJLCNELM.JEACJNAKLDJ(JEBEPBEGCCF);
		}
	}

	private static void ANMMLPCLHBA(ExposedList<NBKCFDOMAPI> LIKIOBHLHHF)
	{
		NBKCFDOMAPI[] items = LIKIOBHLHHF.Items;
		int i = 0;
		for (int count = LIKIOBHLHHF.Count; i < count; i++)
		{
			NBKCFDOMAPI nBKCFDOMAPI = items[i];
			if (nBKCFDOMAPI.PCPLCHABPPO)
			{
				ANMMLPCLHBA(nBKCFDOMAPI.NLADMJEEGNJ);
			}
			nBKCFDOMAPI.PCPLCHABPPO = false;
		}
	}

	public void DGCKCELHAEG()
	{
		ExposedList<NBKCFDOMAPI> pKMLALJKOHL = PKMLALJKOHL;
		NBKCFDOMAPI[] items = pKMLALJKOHL.Items;
		int i = 0;
		for (int count = pKMLALJKOHL.Count; i < count; i++)
		{
			NBKCFDOMAPI nBKCFDOMAPI = items[i];
			nBKCFDOMAPI.LMEFHJAFJLG = nBKCFDOMAPI.AMFCENFNAJJ;
			nBKCFDOMAPI.PEAEDDOIAGN = nBKCFDOMAPI.CNLILOEEBOJ;
			nBKCFDOMAPI.CLDDKKCPILB = nBKCFDOMAPI.ODLHFMOPCHL;
			nBKCFDOMAPI.IOLDFODFHAL = nBKCFDOMAPI.IAFNPOKEFMB;
			nBKCFDOMAPI.JBMAGEEAFKM = nBKCFDOMAPI.GFMCPIJHIGD;
			nBKCFDOMAPI.AIKGKNBOGCL = nBKCFDOMAPI.BALNAGONJDA;
			nBKCFDOMAPI.NIFFEDCOKDI = nBKCFDOMAPI.DADFBNMBFCD;
			nBKCFDOMAPI.LPDFKGBMKOH = true;
		}
		PMGDFPKMKNH[] items2 = LFBIJLCNELM.Items;
		int j = 0;
		for (int count2 = LFBIJLCNELM.Count; j < count2; j++)
		{
			items2[j].BPAJGOINFNL();
		}
	}

	public void ODJKPILHIOD()
	{
		CLFEIDBIMFJ();
		NJHOEOIMHML();
	}

	public void CLFEIDBIMFJ()
	{
		NBKCFDOMAPI[] items = LIKIOBHLHHF.Items;
		int i = 0;
		for (int count = LIKIOBHLHHF.Count; i < count; i++)
		{
			items[i].ODJKPILHIOD();
		}
		JICANJGGKNH[] items2 = EFIPDNFLFND.Items;
		int j = 0;
		for (int count2 = EFIPDNFLFND.Count; j < count2; j++)
		{
			JICANJGGKNH jICANJGGKNH = items2[j];
			jICANJGGKNH.IEFNLGDAINN = jICANJGGKNH.MBBPBGHKLJM.IEFNLGDAINN;
			jICANJGGKNH.MIIHPKNIPAB = jICANJGGKNH.MBBPBGHKLJM.MIIHPKNIPAB;
		}
		DLKMEPPLCGM[] items3 = FOANDHFONAA.Items;
		int k = 0;
		for (int count3 = FOANDHFONAA.Count; k < count3; k++)
		{
			DLKMEPPLCGM dLKMEPPLCGM = items3[k];
			MNNBOEPCJGP mBBPBGHKLJM = dLKMEPPLCGM.MBBPBGHKLJM;
			dLKMEPPLCGM.OIBAIJIPGOM = mBBPBGHKLJM.OIBAIJIPGOM;
			dLKMEPPLCGM.DHNKOEMONHP = mBBPBGHKLJM.DHNKOEMONHP;
			dLKMEPPLCGM.DLEIMBNDMOF = mBBPBGHKLJM.DLEIMBNDMOF;
			dLKMEPPLCGM.OKJBKNEPKPN = mBBPBGHKLJM.OKJBKNEPKPN;
		}
		KNKKDGIBGLM[] items4 = NDOOCKKIMHO.Items;
		int l = 0;
		for (int count4 = NDOOCKKIMHO.Count; l < count4; l++)
		{
			KNKKDGIBGLM kNKKDGIBGLM = items4[l];
			GJNEKNOKICF mBBPBGHKLJM2 = kNKKDGIBGLM.MBBPBGHKLJM;
			kNKKDGIBGLM.LDMDBPLADGD = mBBPBGHKLJM2.LDMDBPLADGD;
			kNKKDGIBGLM.ILNOGLMCFMC = mBBPBGHKLJM2.ILNOGLMCFMC;
			kNKKDGIBGLM.OIBAIJIPGOM = mBBPBGHKLJM2.OIBAIJIPGOM;
			kNKKDGIBGLM.DHNKOEMONHP = mBBPBGHKLJM2.DHNKOEMONHP;
		}
	}

	public void NJHOEOIMHML()
	{
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = MAKCMFCFDLP;
		LBBAMMPJKDA[] items = mAKCMFCFDLP.Items;
		COACJAFIPEI.BOPEPLONIFL();
		int i = 0;
		for (int count = mAKCMFCFDLP.Count; i < count; i++)
		{
			COACJAFIPEI.JEACJNAKLDJ(items[i]);
		}
		int j = 0;
		for (int count2 = mAKCMFCFDLP.Count; j < count2; j++)
		{
			items[j].ODJKPILHIOD();
		}
	}

	public NBKCFDOMAPI NMLBCOPEEDC(string KELMMDNAGGK)
	{
		if (KELMMDNAGGK == null)
		{
			throw new ArgumentNullException("boneName", "boneName cannot be null.");
		}
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = LIKIOBHLHHF;
		NBKCFDOMAPI[] items = lIKIOBHLHHF.Items;
		int i = 0;
		for (int count = lIKIOBHLHHF.Count; i < count; i++)
		{
			NBKCFDOMAPI nBKCFDOMAPI = items[i];
			if (nBKCFDOMAPI.MBBPBGHKLJM.IOCMOCCFALN == KELMMDNAGGK)
			{
				return nBKCFDOMAPI;
			}
		}
		return null;
	}

	public int EENCKHAKMIO(string KELMMDNAGGK)
	{
		if (KELMMDNAGGK == null)
		{
			throw new ArgumentNullException("boneName", "boneName cannot be null.");
		}
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = LIKIOBHLHHF;
		NBKCFDOMAPI[] items = lIKIOBHLHHF.Items;
		int i = 0;
		for (int count = lIKIOBHLHHF.Count; i < count; i++)
		{
			if (items[i].MBBPBGHKLJM.IOCMOCCFALN == KELMMDNAGGK)
			{
				return i;
			}
		}
		return -1;
	}

	public LBBAMMPJKDA MEKLNNENPDK(string NFKHLLDFHKO)
	{
		if (NFKHLLDFHKO == null)
		{
			throw new ArgumentNullException("slotName", "slotName cannot be null.");
		}
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = MAKCMFCFDLP;
		LBBAMMPJKDA[] items = mAKCMFCFDLP.Items;
		int i = 0;
		for (int count = mAKCMFCFDLP.Count; i < count; i++)
		{
			LBBAMMPJKDA lBBAMMPJKDA = items[i];
			if (lBBAMMPJKDA.MBBPBGHKLJM.IOCMOCCFALN == NFKHLLDFHKO)
			{
				return lBBAMMPJKDA;
			}
		}
		return null;
	}

	public int IBOGMECEHLD(string NFKHLLDFHKO)
	{
		if (NFKHLLDFHKO == null)
		{
			throw new ArgumentNullException("slotName", "slotName cannot be null.");
		}
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = MAKCMFCFDLP;
		LBBAMMPJKDA[] items = mAKCMFCFDLP.Items;
		int i = 0;
		for (int count = mAKCMFCFDLP.Count; i < count; i++)
		{
			if (items[i].MBBPBGHKLJM.IOCMOCCFALN.Equals(NFKHLLDFHKO))
			{
				return i;
			}
		}
		return -1;
	}

	public void NGKEKDBDPEN(string COKOMFOMBBA)
	{
		JPAALKCPGNB jPAALKCPGNB = MBBPBGHKLJM.COONIJFPADF(COKOMFOMBBA);
		if (jPAALKCPGNB == null)
		{
			throw new ArgumentException("Skin not found: " + COKOMFOMBBA, "skinName");
		}
		NGKEKDBDPEN(jPAALKCPGNB);
	}

	public void NGKEKDBDPEN(JPAALKCPGNB JPNHJDEOBFM)
	{
		if (JPNHJDEOBFM != null)
		{
			if (HLCFGIFLPPE != null)
			{
				JPNHJDEOBFM.MDFDKLHNHNK(this, HLCFGIFLPPE);
			}
			else
			{
				ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = MAKCMFCFDLP;
				int i = 0;
				for (int count = mAKCMFCFDLP.Count; i < count; i++)
				{
					LBBAMMPJKDA lBBAMMPJKDA = mAKCMFCFDLP.Items[i];
					string fKAJNAAKEFH = lBBAMMPJKDA.MBBPBGHKLJM.FKAJNAAKEFH;
					if (fKAJNAAKEFH != null)
					{
						OAMNGFLKEFI oAMNGFLKEFI = JPNHJDEOBFM.JGHJDGIANDD(i, fKAJNAAKEFH);
						if (oAMNGFLKEFI != null)
						{
							lBBAMMPJKDA.AIKFOHCPLKG = oAMNGFLKEFI;
						}
					}
				}
			}
		}
		HLCFGIFLPPE = JPNHJDEOBFM;
	}

	public OAMNGFLKEFI JGHJDGIANDD(string NFKHLLDFHKO, string FKAJNAAKEFH)
	{
		return JGHJDGIANDD(MBBPBGHKLJM.IBOGMECEHLD(NFKHLLDFHKO), FKAJNAAKEFH);
	}

	public OAMNGFLKEFI JGHJDGIANDD(int PBPEMFGPGFC, string FKAJNAAKEFH)
	{
		if (FKAJNAAKEFH == null)
		{
			throw new ArgumentNullException("attachmentName", "attachmentName cannot be null.");
		}
		if (HLCFGIFLPPE != null)
		{
			OAMNGFLKEFI oAMNGFLKEFI = HLCFGIFLPPE.JGHJDGIANDD(PBPEMFGPGFC, FKAJNAAKEFH);
			if (oAMNGFLKEFI != null)
			{
				return oAMNGFLKEFI;
			}
		}
		return (MBBPBGHKLJM.NAKPPHNCJOC == null) ? null : MBBPBGHKLJM.NAKPPHNCJOC.JGHJDGIANDD(PBPEMFGPGFC, FKAJNAAKEFH);
	}

	public void AKOHILHADLB(string NFKHLLDFHKO, string FKAJNAAKEFH)
	{
		if (NFKHLLDFHKO == null)
		{
			throw new ArgumentNullException("slotName", "slotName cannot be null.");
		}
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = MAKCMFCFDLP;
		int i = 0;
		for (int count = mAKCMFCFDLP.Count; i < count; i++)
		{
			LBBAMMPJKDA lBBAMMPJKDA = mAKCMFCFDLP.Items[i];
			if (!(lBBAMMPJKDA.MBBPBGHKLJM.IOCMOCCFALN == NFKHLLDFHKO))
			{
				continue;
			}
			OAMNGFLKEFI oAMNGFLKEFI = null;
			if (FKAJNAAKEFH != null)
			{
				oAMNGFLKEFI = JGHJDGIANDD(i, FKAJNAAKEFH);
				if (oAMNGFLKEFI == null)
				{
					throw new Exception("Attachment not found: " + FKAJNAAKEFH + ", for slot: " + NFKHLLDFHKO);
				}
			}
			lBBAMMPJKDA.AIKFOHCPLKG = oAMNGFLKEFI;
			return;
		}
		throw new Exception("Slot not found: " + NFKHLLDFHKO);
	}

	public JICANJGGKNH DMNEHMNNCAD(string OPAFPGMAKDC)
	{
		if (OPAFPGMAKDC == null)
		{
			throw new ArgumentNullException("constraintName", "constraintName cannot be null.");
		}
		ExposedList<JICANJGGKNH> eFIPDNFLFND = EFIPDNFLFND;
		int i = 0;
		for (int count = eFIPDNFLFND.Count; i < count; i++)
		{
			JICANJGGKNH jICANJGGKNH = eFIPDNFLFND.Items[i];
			if (jICANJGGKNH.MBBPBGHKLJM.IOCMOCCFALN == OPAFPGMAKDC)
			{
				return jICANJGGKNH;
			}
		}
		return null;
	}

	public DLKMEPPLCGM ACIMONIELHI(string OPAFPGMAKDC)
	{
		if (OPAFPGMAKDC == null)
		{
			throw new ArgumentNullException("constraintName", "constraintName cannot be null.");
		}
		ExposedList<DLKMEPPLCGM> fOANDHFONAA = FOANDHFONAA;
		int i = 0;
		for (int count = fOANDHFONAA.Count; i < count; i++)
		{
			DLKMEPPLCGM dLKMEPPLCGM = fOANDHFONAA.Items[i];
			if (dLKMEPPLCGM.MBBPBGHKLJM.IOCMOCCFALN == OPAFPGMAKDC)
			{
				return dLKMEPPLCGM;
			}
		}
		return null;
	}

	public KNKKDGIBGLM HAGPGEJFKOD(string OPAFPGMAKDC)
	{
		if (OPAFPGMAKDC == null)
		{
			throw new ArgumentNullException("constraintName", "constraintName cannot be null.");
		}
		ExposedList<KNKKDGIBGLM> nDOOCKKIMHO = NDOOCKKIMHO;
		int i = 0;
		for (int count = nDOOCKKIMHO.Count; i < count; i++)
		{
			KNKKDGIBGLM kNKKDGIBGLM = nDOOCKKIMHO.Items[i];
			if (kNKKDGIBGLM.MBBPBGHKLJM.IOCMOCCFALN.Equals(OPAFPGMAKDC))
			{
				return kNKKDGIBGLM;
			}
		}
		return null;
	}

	public void BPAJGOINFNL(float IEDLOAAAKAJ)
	{
		HFLODNLEGFL += IEDLOAAAKAJ;
	}

	public void JMAKPLAAAFP(out float AMFCENFNAJJ, out float CNLILOEEBOJ, out float HHHMOGOKFHF, out float JKNPBEOPMPK, ref float[] ENAGNCJFJKK)
	{
		float[] array = ENAGNCJFJKK;
		array = array ?? new float[8];
		LBBAMMPJKDA[] items = COACJAFIPEI.Items;
		float num = 2.1474836E+09f;
		float num2 = 2.1474836E+09f;
		float num3 = -2.1474836E+09f;
		float num4 = -2.1474836E+09f;
		int i = 0;
		for (int count = COACJAFIPEI.Count; i < count; i++)
		{
			LBBAMMPJKDA lBBAMMPJKDA = items[i];
			int num5 = 0;
			float[] array2 = null;
			OAMNGFLKEFI dFHHMKMLCFF = lBBAMMPJKDA.DFHHMKMLCFF;
			MKEALIMJCFJ mKEALIMJCFJ = dFHHMKMLCFF as MKEALIMJCFJ;
			if (mKEALIMJCFJ != null)
			{
				num5 = 8;
				array2 = array;
				if (array2.Length < 8)
				{
					array2 = (array = new float[8]);
				}
				mKEALIMJCFJ.EPLAHNOCDIB(lBBAMMPJKDA.JEBEPBEGCCF, array, 0);
			}
			else
			{
				MGCLDKAFCIB mGCLDKAFCIB = dFHHMKMLCFF as MGCLDKAFCIB;
				if (mGCLDKAFCIB != null)
				{
					MGCLDKAFCIB mGCLDKAFCIB2 = mGCLDKAFCIB;
					num5 = mGCLDKAFCIB2.DBIIHGFAGJP;
					array2 = array;
					if (array2.Length < num5)
					{
						array2 = (array = new float[num5]);
					}
					mGCLDKAFCIB2.EPLAHNOCDIB(lBBAMMPJKDA, 0, num5, array, 0);
				}
			}
			if (array2 != null)
			{
				for (int j = 0; j < num5; j += 2)
				{
					float val = array2[j];
					float val2 = array2[j + 1];
					num = Math.Min(num, val);
					num2 = Math.Min(num2, val2);
					num3 = Math.Max(num3, val);
					num4 = Math.Max(num4, val2);
				}
			}
		}
		AMFCENFNAJJ = num;
		CNLILOEEBOJ = num2;
		HHHMOGOKFHF = num3 - num;
		JKNPBEOPMPK = num4 - num2;
		ENAGNCJFJKK = array;
	}
}
