using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.Utils;
using Spine.Unity;
using UnityEngine;

namespace Utils
{
	public class PlayRandomSpineAnimations : MonoBehaviour
	{
		public static bool ComboItemWillExplode;

		private SkeletonAnimation IPGBLAHLGCC;

		private JDDHOECMHII OILKIKEJFGB;

		private JDDHOECMHII ONLFNMMFLLN;

		private JDDHOECMHII KLBHGBHCFKF;

		private JDDHOECMHII JAJMAOBNAOE;

		private JDDHOECMHII ABOPCIHIIBK;

		private JDDHOECMHII FIMGFABMPIC;

		private JDDHOECMHII CLGGPMOOLJF;

		private JDDHOECMHII OCAJDADEAMK;

		private JDDHOECMHII FJDGDBPFCHL;

		private JDDHOECMHII ABGMNJLPHHL;

		private JDDHOECMHII NLMIABKDNAN;

		private JDDHOECMHII GFHBPICHPEO;

		private JDDHOECMHII EIOIANMFBEM;

		private JDDHOECMHII IABFCIKPNDP;

		private JDDHOECMHII OPODBIECIDG;

		private JDDHOECMHII KLEHOIEKEND;

		private JDDHOECMHII JEDAEDCHICN;

		private JDDHOECMHII FJNCNHIPIAP;

		private JDDHOECMHII OLDOMNBDPFD;

		private JDDHOECMHII AOBPFCJKIKD;

		private JDDHOECMHII EPPPNHEBLFC;

		private JDDHOECMHII KMEGDACONMH;

		private JDDHOECMHII NDLHNLKBKLD;

		private JDDHOECMHII MPHCELADJJI;

		private JDDHOECMHII DGBDLBOHAKO;

		private JDDHOECMHII DKJFEBNNAEE;

		private JDDHOECMHII FDGMLEBJCID;

		private JDDHOECMHII PFLIKFFBPGE;

		private JDDHOECMHII NJMOGLHGFNK;

		private JDDHOECMHII EABJJGCILHO;

		private JDDHOECMHII EHLBJJNIFDJ;

		private bool NAFPOHGNCEP;

		private int FFIPLGKJCDE;

		private const int OFBBBLIKABD = 0;

		private const int JIGPPOACBBF = 1;

		private const int KKFPBEDDPII = 2;

		private const int IACDCKHMHIA = 3;

		private const int FNEMCLGAADL = 4;

		private const int HDPJHBOIFGL = 5;

		private int GAGLHHBHDFJ
		{
			get
			{
				KFCEILFGADG activeLevel = LevelBuilder.ActiveLevel;
				if (NAFPOHGNCEP || activeLevel == null || activeLevel.BKBFKFGBKDP)
				{
					return 0;
				}
				if (NAFPOHGNCEP)
				{
					NAFPOHGNCEP = activeLevel.NPMIKDPNBIA;
				}
				else if (activeLevel.NPMIKDPNBIA)
				{
					return 3;
				}
				if (activeLevel.EBMFPDNPIEM > 3 && ComboItemWillExplode)
				{
					return 2;
				}
				if (activeLevel.EBMFPDNPIEM <= 0)
				{
					return 5;
				}
				if (activeLevel.EBMFPDNPIEM <= 3)
				{
					return 4;
				}
				if (activeLevel.ABNJCFOELCB > 1 && activeLevel.EBMFPDNPIEM > 5 && !TutorialManager.TutorialActive && AudioManager.MMJKLIMKEHG)
				{
					return 1;
				}
				return 0;
			}
		}

		public void Start()
		{
			IPGBLAHLGCC = GetComponent<SkeletonAnimation>();
			if (!(IPGBLAHLGCC == null))
			{
				ONLFNMMFLLN = new JDDHOECMHII("idle", true, PLFJDKCHMAK);
				KLBHGBHCFKF = new JDDHOECMHII("idle2", false, LJNPHGMOLKG);
				ABOPCIHIIBK = new JDDHOECMHII("look_down_start", false, GNJGDCFDDAE);
				FIMGFABMPIC = new JDDHOECMHII("look_down_idle", true, OOBDKGLHGFC);
				CLGGPMOOLJF = new JDDHOECMHII("look_down_finish", false, BPNECFHPGEF);
				OCAJDADEAMK = new JDDHOECMHII("look_down2_start", false, KEPEAGEPLMD);
				FJDGDBPFCHL = new JDDHOECMHII("look_down2_idle", true, JOALFECKPEB);
				ABGMNJLPHHL = new JDDHOECMHII("look_down2_idle2", false, KFFBADHJBAI);
				NLMIABKDNAN = new JDDHOECMHII("look_down2_idle3", false, EFLBHILIHIM);
				GFHBPICHPEO = new JDDHOECMHII("look_down2_finish", false, OMLOLFIOLNO);
				EIOIANMFBEM = new JDDHOECMHII("look_at_cam_start", false, AADNLPOLKJD);
				IABFCIKPNDP = new JDDHOECMHII("look_at_cam_idle", true, MCPOCAGIPFO);
				OPODBIECIDG = new JDDHOECMHII("look_at_cam_idle2", false, DMAGNOFMMEP);
				KLEHOIEKEND = new JDDHOECMHII("look_at_cam_idle3", false, LGJADKBOEAL);
				JEDAEDCHICN = new JDDHOECMHII("look_at_cam_finish", false, OJOKPNBLDNJ);
				FJNCNHIPIAP = new JDDHOECMHII("cheer_up1", false, MPFHDDFCECJ);
				OLDOMNBDPFD = new JDDHOECMHII("cheer_up2", false, HIOKEIPONHO);
				AOBPFCJKIKD = new JDDHOECMHII("cheer_up3_start", false, GDKIHIKMJHI);
				EPPPNHEBLFC = new JDDHOECMHII("cheer_up3", true, GPEBJEKIOLE);
				KMEGDACONMH = new JDDHOECMHII("cheer_up3_finish", false, JENCEEKKMEM);
				NDLHNLKBKLD = new JDDHOECMHII("worried_start", false, DNLNBIACDNA);
				MPHCELADJJI = new JDDHOECMHII("worried_idle1", false, HJMGMKPFFED);
				DGBDLBOHAKO = new JDDHOECMHII("worried_idle2", false, EENGEMFOCJB);
				DKJFEBNNAEE = new JDDHOECMHII("worried_idle3", false, GKFFLDAJKHM);
				FDGMLEBJCID = new JDDHOECMHII("worried_idle4", false, JIGCDPBMLHG);
				PFLIKFFBPGE = new JDDHOECMHII("worried_finish", false, NDIBJNMGBCF);
				NJMOGLHGFNK = new JDDHOECMHII("fail_start", false, NNCCBGFBNHD);
				EABJJGCILHO = new JDDHOECMHII("fail_idle", true, BDMBENKIEKN);
				EHLBJJNIFDJ = new JDDHOECMHII("fail_finish", false, GPLDJGGPJOD);
				OILKIKEJFGB = ONLFNMMFLLN;
				IPGBLAHLGCC.state.DHOFLMAIDKL += OILKIKEJFGB.DHOFLMAIDKL;
			}
		}

		private void PLFJDKCHMAK(JHFLAELBLPM JKFDBAEMGMJ)
		{
			try
			{
				int num = GAGLHHBHDFJ;
				switch (num)
				{
				case 3:
					OBJKKLDHMIF(FJNCNHIPIAP);
					return;
				case 2:
					OBJKKLDHMIF(OLDOMNBDPFD);
					return;
				case 4:
					OBJKKLDHMIF(NDLHNLKBKLD);
					return;
				}
				JDDHOECMHII jDDHOECMHII = null;
				int num2 = UnityEngine.Random.Range(0, 10);
				if (num2 < 2)
				{
					jDDHOECMHII = ABOPCIHIIBK;
				}
				else if (num2 < 4)
				{
					jDDHOECMHII = EIOIANMFBEM;
				}
				else if (num2 < 6 && LevelBuilder.ActiveLevel.ABNJCFOELCB > 1 && !TutorialManager.TutorialActive)
				{
					jDDHOECMHII = OCAJDADEAMK;
				}
				else if (num == 1)
				{
					int num3 = UnityEngine.Random.Range(0, 10);
					if (num3 < 2)
					{
						jDDHOECMHII = AOBPFCJKIKD;
					}
					else if (num3 < 5)
					{
						jDDHOECMHII = KLBHGBHCFKF;
					}
				}
				else if (UnityEngine.Random.Range(0, 10) < 5)
				{
					jDDHOECMHII = KLBHGBHCFKF;
				}
				if (jDDHOECMHII != null && jDDHOECMHII != JAJMAOBNAOE)
				{
					OBJKKLDHMIF(jDDHOECMHII);
					JAJMAOBNAOE = jDDHOECMHII;
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.GamePlay, "Error playing Bruno Animation: Message:{0} Stack:{1}", ex.Message, ex.StackTrace);
				NHNBFBDHKGN.JFPLDMEBIJH("Bruno idle animation", ex.Message, ex.StackTrace);
			}
		}

		private void LJNPHGMOLKG(JHFLAELBLPM JKFDBAEMGMJ)
		{
			switch (GAGLHHBHDFJ)
			{
			case 3:
				OBJKKLDHMIF(FJNCNHIPIAP);
				break;
			case 2:
				OBJKKLDHMIF(OLDOMNBDPFD);
				break;
			case 4:
				OBJKKLDHMIF(NDLHNLKBKLD);
				break;
			default:
				OBJKKLDHMIF(ONLFNMMFLLN);
				break;
			}
		}

		private void AADNLPOLKJD(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4)
			{
				OBJKKLDHMIF(JEDAEDCHICN);
			}
			else
			{
				OBJKKLDHMIF(IABFCIKPNDP);
			}
		}

		private void MCPOCAGIPFO(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || UnityEngine.Random.Range(0, 10) > 3)
			{
				OBJKKLDHMIF(JEDAEDCHICN);
				return;
			}
			int num2 = UnityEngine.Random.Range(0, 10);
			if (num2 < 5)
			{
				if (num2 >= 2)
				{
					OBJKKLDHMIF(OPODBIECIDG);
				}
				else
				{
					OBJKKLDHMIF(KLEHOIEKEND);
				}
			}
		}

		private void DMAGNOFMMEP(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4)
			{
				OBJKKLDHMIF(JEDAEDCHICN);
			}
			else
			{
				OBJKKLDHMIF(IABFCIKPNDP);
			}
		}

		private void LGJADKBOEAL(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4)
			{
				OBJKKLDHMIF(JEDAEDCHICN);
			}
			else
			{
				OBJKKLDHMIF(IABFCIKPNDP);
			}
		}

		private void OJOKPNBLDNJ(JHFLAELBLPM JKFDBAEMGMJ)
		{
			switch (GAGLHHBHDFJ)
			{
			case 3:
				OBJKKLDHMIF(FJNCNHIPIAP);
				break;
			case 2:
				OBJKKLDHMIF(OLDOMNBDPFD);
				break;
			case 4:
				OBJKKLDHMIF(NDLHNLKBKLD);
				break;
			default:
				OBJKKLDHMIF(ONLFNMMFLLN);
				break;
			}
		}

		private void GNJGDCFDDAE(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4)
			{
				OBJKKLDHMIF(CLGGPMOOLJF);
			}
			else
			{
				OBJKKLDHMIF(FIMGFABMPIC);
			}
		}

		private void OOBDKGLHGFC(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || UnityEngine.Random.Range(0, 10) > 3)
			{
				OBJKKLDHMIF(CLGGPMOOLJF);
			}
		}

		private void BPNECFHPGEF(JHFLAELBLPM JKFDBAEMGMJ)
		{
			switch (GAGLHHBHDFJ)
			{
			case 3:
				OBJKKLDHMIF(FJNCNHIPIAP);
				break;
			case 2:
				OBJKKLDHMIF(OLDOMNBDPFD);
				break;
			case 4:
				OBJKKLDHMIF(NDLHNLKBKLD);
				break;
			default:
				OBJKKLDHMIF(ONLFNMMFLLN);
				break;
			}
		}

		private void KEPEAGEPLMD(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || LevelBuilder.ActiveLevel.ABNJCFOELCB < 2 || TutorialManager.TutorialActive)
			{
				OBJKKLDHMIF(GFHBPICHPEO);
			}
			else
			{
				OBJKKLDHMIF(FJDGDBPFCHL);
			}
		}

		private void JOALFECKPEB(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || UnityEngine.Random.Range(0, 10) > 3 || LevelBuilder.ActiveLevel.ABNJCFOELCB < 2 || TutorialManager.TutorialActive)
			{
				OBJKKLDHMIF(GFHBPICHPEO);
				return;
			}
			int num2 = UnityEngine.Random.Range(0, 10);
			if (num2 < 5)
			{
				if (num2 >= 2)
				{
					OBJKKLDHMIF(ABGMNJLPHHL);
				}
				else
				{
					OBJKKLDHMIF(NLMIABKDNAN);
				}
			}
		}

		private void KFFBADHJBAI(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || LevelBuilder.ActiveLevel.ABNJCFOELCB < 2 || TutorialManager.TutorialActive)
			{
				OBJKKLDHMIF(GFHBPICHPEO);
			}
			else
			{
				OBJKKLDHMIF(FJDGDBPFCHL);
			}
		}

		private void EFLBHILIHIM(JHFLAELBLPM JKFDBAEMGMJ)
		{
			int num = GAGLHHBHDFJ;
			if (num == 3 || num == 2 || num == 4 || LevelBuilder.ActiveLevel.ABNJCFOELCB < 2 || TutorialManager.TutorialActive)
			{
				OBJKKLDHMIF(GFHBPICHPEO);
			}
			else
			{
				OBJKKLDHMIF(FJDGDBPFCHL);
			}
		}

		private void OMLOLFIOLNO(JHFLAELBLPM JKFDBAEMGMJ)
		{
			switch (GAGLHHBHDFJ)
			{
			case 3:
				OBJKKLDHMIF(FJNCNHIPIAP);
				break;
			case 2:
				OBJKKLDHMIF(OLDOMNBDPFD);
				break;
			case 4:
				OBJKKLDHMIF(NDLHNLKBKLD);
				break;
			default:
				OBJKKLDHMIF(ONLFNMMFLLN);
				break;
			}
		}

		private void MPFHDDFCECJ(JHFLAELBLPM JKFDBAEMGMJ)
		{
			NAFPOHGNCEP = true;
			OBJKKLDHMIF(ONLFNMMFLLN);
		}

		private void HIOKEIPONHO(JHFLAELBLPM JKFDBAEMGMJ)
		{
			ComboItemWillExplode = false;
			OBJKKLDHMIF(ONLFNMMFLLN);
		}

		private void GDKIHIKMJHI(JHFLAELBLPM JKFDBAEMGMJ)
		{
			FFIPLGKJCDE = 0;
			if (GAGLHHBHDFJ != 1)
			{
				OBJKKLDHMIF(KMEGDACONMH);
				return;
			}
			float fMIEEHFENDJ = 1f;
			if (AudioManager.MPHNEKNMGML == 2)
			{
				fMIEEHFENDJ = 1.14f;
			}
			OBJKKLDHMIF(EPPPNHEBLFC, fMIEEHFENDJ);
		}

		private void GPEBJEKIOLE(JHFLAELBLPM JKFDBAEMGMJ)
		{
			FFIPLGKJCDE++;
			if (GAGLHHBHDFJ != 1 || FFIPLGKJCDE > 4)
			{
				OBJKKLDHMIF(KMEGDACONMH);
			}
		}

		private void JENCEEKKMEM(JHFLAELBLPM JKFDBAEMGMJ)
		{
			switch (GAGLHHBHDFJ)
			{
			case 3:
				OBJKKLDHMIF(FJNCNHIPIAP);
				break;
			case 2:
				OBJKKLDHMIF(OLDOMNBDPFD);
				break;
			case 4:
				OBJKKLDHMIF(NDLHNLKBKLD);
				break;
			default:
				OBJKKLDHMIF(ONLFNMMFLLN);
				break;
			}
		}

		private void DNLNBIACDNA(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 5)
			{
				OBJKKLDHMIF(NJMOGLHGFNK);
				return;
			}
			if (GAGLHHBHDFJ != 4)
			{
				OBJKKLDHMIF(PFLIKFFBPGE);
				return;
			}
			switch (UnityEngine.Random.Range(0, 4))
			{
			case 0:
				OBJKKLDHMIF(MPHCELADJJI);
				break;
			case 1:
				OBJKKLDHMIF(DGBDLBOHAKO);
				break;
			case 2:
				OBJKKLDHMIF(DKJFEBNNAEE);
				break;
			case 3:
				OBJKKLDHMIF(FDGMLEBJCID);
				break;
			}
		}

		private void HJMGMKPFFED(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 5)
			{
				OBJKKLDHMIF(NJMOGLHGFNK);
				return;
			}
			if (GAGLHHBHDFJ != 4)
			{
				OBJKKLDHMIF(PFLIKFFBPGE);
				return;
			}
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				OBJKKLDHMIF(DGBDLBOHAKO);
				break;
			case 1:
				OBJKKLDHMIF(DKJFEBNNAEE);
				break;
			case 2:
				OBJKKLDHMIF(FDGMLEBJCID);
				break;
			}
		}

		private void EENGEMFOCJB(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 5)
			{
				OBJKKLDHMIF(NJMOGLHGFNK);
				return;
			}
			if (GAGLHHBHDFJ != 4)
			{
				OBJKKLDHMIF(PFLIKFFBPGE);
				return;
			}
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				OBJKKLDHMIF(MPHCELADJJI);
				break;
			case 1:
				OBJKKLDHMIF(DKJFEBNNAEE);
				break;
			case 2:
				OBJKKLDHMIF(FDGMLEBJCID);
				break;
			}
		}

		private void GKFFLDAJKHM(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 5)
			{
				OBJKKLDHMIF(NJMOGLHGFNK);
				return;
			}
			if (GAGLHHBHDFJ != 4)
			{
				OBJKKLDHMIF(PFLIKFFBPGE);
				return;
			}
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				OBJKKLDHMIF(MPHCELADJJI);
				break;
			case 1:
				OBJKKLDHMIF(DGBDLBOHAKO);
				break;
			case 2:
				OBJKKLDHMIF(FDGMLEBJCID);
				break;
			}
		}

		private void JIGCDPBMLHG(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 5)
			{
				OBJKKLDHMIF(NJMOGLHGFNK);
				return;
			}
			if (GAGLHHBHDFJ != 4)
			{
				OBJKKLDHMIF(PFLIKFFBPGE);
				return;
			}
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				OBJKKLDHMIF(MPHCELADJJI);
				break;
			case 1:
				OBJKKLDHMIF(DGBDLBOHAKO);
				break;
			case 2:
				OBJKKLDHMIF(DKJFEBNNAEE);
				break;
			}
		}

		private void NDIBJNMGBCF(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 3)
			{
				OBJKKLDHMIF(FJNCNHIPIAP);
			}
			else
			{
				OBJKKLDHMIF(ONLFNMMFLLN);
			}
		}

		private void NNCCBGFBNHD(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ != 5)
			{
				OBJKKLDHMIF(EHLBJJNIFDJ);
			}
			else
			{
				OBJKKLDHMIF(EABJJGCILHO);
			}
		}

		private void BDMBENKIEKN(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ != 5)
			{
				OBJKKLDHMIF(EHLBJJNIFDJ);
			}
		}

		private void GPLDJGGPJOD(JHFLAELBLPM NBOKLOHDENL)
		{
			if (GAGLHHBHDFJ == 3)
			{
				OBJKKLDHMIF(FJNCNHIPIAP);
			}
			else
			{
				OBJKKLDHMIF(ONLFNMMFLLN);
			}
		}

		private void OBJKKLDHMIF(JDDHOECMHII BFANLMJKGLB, float FMIEEHFENDJ = 1f)
		{
			IPGBLAHLGCC.state.DHOFLMAIDKL -= OILKIKEJFGB.DHOFLMAIDKL;
			IPGBLAHLGCC.state.DHOFLMAIDKL += BFANLMJKGLB.DHOFLMAIDKL;
			IPGBLAHLGCC.state.LMHOONAMFIJ(0, BFANLMJKGLB.PNGPLGHKFDI, BFANLMJKGLB.MELBODIIPKN);
			IPGBLAHLGCC.state.OEPAHOAODPE = FMIEEHFENDJ;
			OILKIKEJFGB = BFANLMJKGLB;
		}
	}
}
