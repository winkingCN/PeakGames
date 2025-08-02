using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.Utils;
using DG.Tweening;
using Dialogs;
using GamePlayScene.Mechanics.Animations.Collections;
using UnityEngine;
using Utils;

public class KFCEILFGADG
{
	public static int INGPPJECAMI = 5;

	private float ABJLIOKICLP;

	public string PNGPLGHKFDI;

	public string BHHFNLJCCKC;

	private bool BBGGJPIABBK;

	private int ALJEEMADLLM;

	public CFOIPDKEFMM JHDMFHDHIFN;

	public Dictionary<FCPPDOMBLHL, HICNCEMBCBG> DCJNBADOLGD;

	public Dictionary<int, Queue<DNJKLNPHPOF>> HCPDKCHKNKA;

	public bool AOFJJGNOLDM;

	public LevelBuilder GIMBEKBFKMJ;

	public CaravanTopPanel BJEPPNGPMKO;

	public List<OGIFMLFEAEM> JKKJLDLMIOG;

	public bool CIPIEIHKJHN;

	public int[] NJHCINMDGKB = new int[Enum.GetNames(typeof(NOALGNJECAD)).Length];

	public int[] OEOBPBFCEPB = new int[Enum.GetNames(typeof(NOALGNJECAD)).Length];

	public int PDGLECFDLJJ;

	public bool NPMIKDPNBIA;

	public int KOJNPMCHBAE;

	public int HJCPDOGONIG;

	public int PPHBPKCJGMC;

	public int[] EMNDJNDGANP;

	public int MAEILEPNBAE;

	public HashSet<LEDBLDKJBAI> LLMDNGHAJDO;

	private int NONLIOLBKMM = 5;

	public Dictionary<NAAHKHPBAPA, int> CFDBAMKOABO;

	private KBDINLHCLJK IGPGENNGEMG = new KBDINLHCLJK(0);

	public bool BKBFKFGBKDP;

	public bool LJLIBGMBIGC;

	public DGFHEKMMJHL ELEHIDCIDJN;

	private int KAKFBLFIGAO;

	public bool EPGNODLFKDC;

	private WinAnimation JGNOJEKAKNF;

	public const int OCOMADKGAEJ = 2300;

	private const float NJANKONOEJN = 1f;

	public List<JFIEHOCCBNG> OGIJEDJHMNG = new List<JFIEHOCCBNG>();

	public List<LAGOKFDALBI> OGLGBIKJDCP = new List<LAGOKFDALBI>();

	private readonly Dictionary<NOALGNJECAD, List<LEDBLDKJBAI>> JDIFDAKOBHO = new Dictionary<NOALGNJECAD, List<LEDBLDKJBAI>>();

	private LLCJMMBBLEH CIIKGJEADDI;

	public float NAFLKPJGHHD
	{
		get
		{
			return ABJLIOKICLP;
		}
	}

	public int ABNJCFOELCB
	{
		get
		{
			return ALJEEMADLLM;
		}
	}

	public int EPLKIIOCNPE
	{
		get
		{
			return IGPGENNGEMG.JBGOANMLBFA;
		}
		private set
		{
			IGPGENNGEMG.JBGOANMLBFA = value;
		}
	}

	public int EBMFPDNPIEM
	{
		get
		{
			return KOJNPMCHBAE - EPLKIIOCNPE;
		}
	}

	public int KFHIMNCFLFD { get; set; }

	public KFCEILFGADG()
	{
		BHHFNLJCCKC = Guid.NewGuid().ToString();
		JKKJLDLMIOG = new List<OGIFMLFEAEM>();
		ELEHIDCIDJN = new DGFHEKMMJHL(this);
		LLMDNGHAJDO = new HashSet<LEDBLDKJBAI>();
		CFDBAMKOABO = new Dictionary<NAAHKHPBAPA, int>(7)
		{
			{
				NAAHKHPBAPA.Rocket,
				0
			},
			{
				NAAHKHPBAPA.Bomb,
				0
			},
			{
				NAAHKHPBAPA.DiscoBall,
				0
			},
			{
				NAAHKHPBAPA.BoxingGlove,
				0
			},
			{
				NAAHKHPBAPA.Anvil,
				0
			},
			{
				NAAHKHPBAPA.Hammer,
				0
			},
			{
				NAAHKHPBAPA.Dice,
				0
			}
		};
	}

	public void DJPJLDLJPBD(Dictionary<int, Queue<DNJKLNPHPOF>> KGDEKNEOBPL)
	{
		AOFJJGNOLDM = true;
		HCPDKCHKNKA = KGDEKNEOBPL;
	}

	public void CBHLJLCDHJK(int BDEBJHBJDII)
	{
		EPLKIIOCNPE = KOJNPMCHBAE - BDEBJHBJDII;
	}

	public void KEAEBEGPDKP()
	{
		ALJEEMADLLM++;
	}

	public Item OJDPAPIBONC(FCPPDOMBLHL KEKPBEKCPNN, int NMPJCKJIOKL)
	{
		if (KEKPBEKCPNN == FCPPDOMBLHL.None)
		{
			return null;
		}
		HICNCEMBCBG value;
		DCJNBADOLGD.TryGetValue(KEKPBEKCPNN, out value);
		if (value == null || !value.FACLJMKMCBD)
		{
			return null;
		}
		DNJKLNPHPOF nBHMBPFKCMI = value.EGNAIPPHGPM(NMPJCKJIOKL);
		return (!nBHMBPFKCMI.APDFDPJHIHE) ? null : GIMBEKBFKMJ.CreateItemFromItemGroupEntry(nBHMBPFKCMI);
	}

	private void GCDNOMPLEKP(NOALGNJECAD HBBIFNLDKPO)
	{
		foreach (HICNCEMBCBG value in DCJNBADOLGD.Values)
		{
			value.HCFANPLOMNL(HBBIFNLDKPO);
		}
	}

	public void AMFPKLEIMBO()
	{
		if (ABJLIOKICLP == 0f)
		{
			ABJLIOKICLP = Time.realtimeSinceStartup;
		}
		EPLKIIOCNPE++;
		KEAEBEGPDKP();
		BJEPPNGPMKO.MovesLeftText.FCJBBPHFNPJ = EBMFPDNPIEM.CMACDGCBKLO();
		if (EBMFPDNPIEM == NONLIOLBKMM)
		{
			BJEPPNGPMKO.StartLast5MovesAnimation();
		}
		if (EBMFPDNPIEM == 0)
		{
			SettingsPanel.Instance.DisableBottomPanel();
			TapListener.Instance.IncreaseBlockRequests();
		}
	}

	public void GKKIFODLNDE(NOALGNJECAD HBBIFNLDKPO)
	{
		NJHCINMDGKB[(int)HBBIFNLDKPO]++;
	}

	public void DJNEAFJLFIH(NOALGNJECAD HBBIFNLDKPO)
	{
		NJHCINMDGKB[(int)HBBIFNLDKPO]--;
	}

	public int GEHOAFJDMPE(NOALGNJECAD HBBIFNLDKPO)
	{
		bool flag = false;
		int num = 0;
		int num2 = NJHCINMDGKB[(int)HBBIFNLDKPO];
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == HBBIFNLDKPO)
			{
				flag = true;
				num = oGIFMLFEAEM.GMCGMPEEHJP - BJEPPNGPMKO.GetActiveCollectAnimationsCount(i);
			}
		}
		return (!flag) ? (-1) : (num - num2);
	}

	public bool NODDCJJNJEC(NOALGNJECAD DBPCNBOJHLJ)
	{
		if (BKBFKFGBKDP)
		{
			return false;
		}
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == DBPCNBOJHLJ && oGIFMLFEAEM.GMCGMPEEHJP > 0)
			{
				return true;
			}
		}
		return false;
	}

	public void LCKKMCJDDBC(NOALGNJECAD ECOPIDONACO)
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == ECOPIDONACO)
			{
				if (oGIFMLFEAEM.GMCGMPEEHJP > BJEPPNGPMKO.GetActiveCollectAnimationsCount(i) + 1)
				{
					return;
				}
			}
			else if (oGIFMLFEAEM.GMCGMPEEHJP > 0)
			{
				return;
			}
		}
		ELEHIDCIDJN.AELCCKHIMME();
		TapListener.Instance.IncreaseBlockRequests();
	}

	public void JPAFPKIDJDJ(NOALGNJECAD ECOPIDONACO)
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == ECOPIDONACO)
			{
				oGIFMLFEAEM.DFCJGFCNFDP(1);
				BJEPPNGPMKO.UpdateGoalCount(i, oGIFMLFEAEM.GMCGMPEEHJP);
			}
		}
	}

	public void ACJOALJFMHN(NOALGNJECAD ECOPIDONACO, bool LGMEMHBEKMB)
	{
		bool flag = true;
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == ECOPIDONACO && !BKBFKFGBKDP)
			{
				oGIFMLFEAEM.PNLODLPOLJB(1);
				MLAGNJGFOND(ECOPIDONACO, oGIFMLFEAEM);
				BJEPPNGPMKO.UpdateGoalCount(i, oGIFMLFEAEM.GMCGMPEEHJP, DELEFPDLNIM(ECOPIDONACO));
				if (!LGMEMHBEKMB)
				{
					BJEPPNGPMKO.IncreaseActiveCollectAnimationtCount(i);
				}
				BJEPPNGPMKO.PlayGoalCollectHit(i);
			}
			if (oGIFMLFEAEM.GMCGMPEEHJP != 0)
			{
				flag = false;
			}
		}
		if (!NPMIKDPNBIA && flag)
		{
			NPMIKDPNBIA = true;
			ELEHIDCIDJN.AELCCKHIMME();
			PPHBPKCJGMC = EPLKIIOCNPE;
			FocusListener.ResetGamePlayCrash();
			PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC(false);
			TapListener.Instance.IncreaseBlockRequests();
			BoosterTapListener.Instance.IncreaseBlockRequests();
			SettingsPanel.Instance.DisableBottomPanel();
			GIMBEKBFKMJ.CurrentTopPanel.StopLast5Moves();
			HintManager instance = HintManager.Instance;
			instance.DisableHints();
			instance.StopSpecialItemMarks();
			CIIKGJEADDI = new LLCJMMBBLEH(HHPMGOFCCBK());
		}
	}

	public void ELKFBOBDKMN()
	{
		if (CIIKGJEADDI != null)
		{
			CIIKGJEADDI.BPPFBMCJOAH();
			CIIKGJEADDI = null;
		}
	}

	private bool DELEFPDLNIM(NOALGNJECAD ECOPIDONACO)
	{
		bool result = false;
		switch (ECOPIDONACO)
		{
		case NOALGNJECAD.Bubble:
			result = LPEHEJADIKH(NOALGNJECAD.Soap) || LPEHEJADIKH(NOALGNJECAD.Washer);
			break;
		case NOALGNJECAD.Ivy:
			result = LPEHEJADIKH(NOALGNJECAD.Pot);
			break;
		}
		return result;
	}

	private bool LPEHEJADIKH(NOALGNJECAD ECOPIDONACO)
	{
		OGIFMLFEAEM oGIFMLFEAEM = HEHOGLHPCGH(ECOPIDONACO);
		return oGIFMLFEAEM != null && oGIFMLFEAEM.GMCGMPEEHJP != 0;
	}

	public void MLAGNJGFOND(NOALGNJECAD ECOPIDONACO)
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == ECOPIDONACO && !BKBFKFGBKDP)
			{
				MLAGNJGFOND(ECOPIDONACO, oGIFMLFEAEM);
			}
		}
	}

	public void MLAGNJGFOND(NOALGNJECAD ECOPIDONACO, OGIFMLFEAEM CFCMAHODGGK)
	{
		int num = NJHCINMDGKB[(int)ECOPIDONACO] + OEOBPBFCEPB[(int)ECOPIDONACO];
		if (CFCMAHODGGK.GMCGMPEEHJP - num <= 0 && ECOPIDONACO != NOALGNJECAD.SolidColor1 && ECOPIDONACO != NOALGNJECAD.SolidColor2 && ECOPIDONACO != NOALGNJECAD.SolidColor3 && ECOPIDONACO != NOALGNJECAD.SolidColor4 && ECOPIDONACO != NOALGNJECAD.SolidColor5 && ECOPIDONACO != NOALGNJECAD.SolidColor6)
		{
			GCDNOMPLEKP(ECOPIDONACO);
		}
	}

	public bool BBHKENOBFLO(NOALGNJECAD NBFBPNNEKMN)
	{
		OGIFMLFEAEM oGIFMLFEAEM = HEHOGLHPCGH(NBFBPNNEKMN);
		if (oGIFMLFEAEM != null)
		{
			int num = NJHCINMDGKB[(int)NBFBPNNEKMN] + OEOBPBFCEPB[(int)NBFBPNNEKMN];
			if (oGIFMLFEAEM.GMCGMPEEHJP - num <= 0)
			{
				return false;
			}
		}
		return true;
	}

	public int CICDFLLGAHA()
	{
		OGIFMLFEAEM oGIFMLFEAEM = HEHOGLHPCGH(NOALGNJECAD.Bubble);
		if (oGIFMLFEAEM != null)
		{
			return oGIFMLFEAEM.BNNIJEPHLBJ - LLJLGKECBBE.GABGKBAKHDP.KOBIBAJNFCO;
		}
		return 0;
	}

	public OGIFMLFEAEM HEHOGLHPCGH(NOALGNJECAD NBFBPNNEKMN)
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (oGIFMLFEAEM.ENBPGGCIADN == NBFBPNNEKMN)
			{
				return oGIFMLFEAEM;
			}
		}
		return null;
	}

	public void BIFLJLPOELJ()
	{
		KAKFBLFIGAO++;
	}

	public void GIMHNADJNIK()
	{
		KAKFBLFIGAO--;
		if (KAKFBLFIGAO < 0)
		{
			KAKFBLFIGAO = 0;
		}
	}

	public void INJHFIFHKOB()
	{
		KAKFBLFIGAO = 0;
	}

	public IEnumerator HHPMGOFCCBK()
	{
		yield return null;
		while (KAKFBLFIGAO > 0)
		{
			if (BKBFKFGBKDP)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
				yield break;
			}
			yield return null;
		}
		while (FallManager.AreThereActiveAnimations())
		{
			if (BKBFKFGBKDP)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
				yield break;
			}
			yield return null;
		}
		yield return MCJHHDACJBG.CHFOIGLAMPN;
		if (BKBFKFGBKDP)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
			yield break;
		}
		while (NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().LBGEOEHBJNF() != 0)
		{
			if (BKBFKFGBKDP)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
				yield break;
			}
			yield return null;
		}
		int[] nJHCINMDGKB = JHDMFHDHIFN.ELFBOKDHKGG.NJHCINMDGKB;
		if (EBMFPDNPIEM > 0 || nJHCINMDGKB[9] > 0 || nJHCINMDGKB[11] > 0 || nJHCINMDGKB[10] > 0)
		{
			FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
			SettingsPanel instance = SettingsPanel.Instance;
			if (instance != null && instance.BLBFOGEDAPH)
			{
				instance.Hide();
			}
			LevelBuilder.Recorder.GAMDCIKLKJC(true);
			GIMBEKBFKMJ.WinLogoAnimation.StartWinLogo(delegate
			{
				if (BKBFKFGBKDP)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
				}
				else
				{
					JGNOJEKAKNF = BJEPPNGPMKO.gameObject.AddComponent<WinAnimation>();
					JGNOJEKAKNF.Prepare(BJEPPNGPMKO, JHDMFHDHIFN);
					JGNOJEKAKNF.StartMovesLeft();
				}
			}, delegate
			{
				if (GIMBEKBFKMJ.IsTapToSkipEnabled())
				{
					EPGNODLFKDC = true;
					DOTween.Sequence().InsertCallback(1f, delegate
					{
						GIMBEKBFKMJ.TapToSkipCollider.enabled = true;
						if (GIMBEKBFKMJ.ShouldDisplayTapToSkipContent())
						{
							GIMBEKBFKMJ.TapToSkipText.enabled = true;
							GIMBEKBFKMJ.TapToSkipText.color = new Color(1f, 1f, 1f, 0f);
							GIMBEKBFKMJ.TapToSkipText.DOColor(new Color(1f, 1f, 1f, 1f), 0.5f);
							GIMBEKBFKMJ.TapToSkipText.ANLKLKAINEO.DOScale(1.1f, 0.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
							GIMBEKBFKMJ.IncreaseTapToSkipCount();
						}
					});
				}
			});
		}
		else
		{
			LNPKMGADMHD();
		}
	}

	public void FDALIJBFECF()
	{
		if (EPGNODLFKDC)
		{
			GIMBEKBFKMJ.TapToSkipText.enabled = false;
			if (JGNOJEKAKNF != null)
			{
				GIMBEKBFKMJ.TapToSkipCollider.enabled = false;
				JGNOJEKAKNF.SkipAnimations();
				GIMBEKBFKMJ.WinCharsAnimation.SkipAnimation();
			}
			else
			{
				ScoreManager.RaiseSudden((KOJNPMCHBAE - PPHBPKCJGMC) * 2300);
				GIMBEKBFKMJ.WinLogoAnimation.SkipAnimation();
			}
			LEGANDGOBEJ();
		}
	}

	private IEnumerator IOIJJMIFCNA()
	{
		yield return MCJHHDACJBG.KNLADMIBAAD;
		if (GIMBEKBFKMJ.TapToSkipText.enabled)
		{
			GIMBEKBFKMJ.TapToSkipText.DOColor(new Color(1f, 1f, 1f, 0f), 0.5f).OnComplete(delegate
			{
				GIMBEKBFKMJ.TapToSkipText.enabled = false;
				GIMBEKBFKMJ.TapToSkipText.DOKill();
			});
		}
	}

	public void LNPKMGADMHD()
	{
		if (GIMBEKBFKMJ.TapToSkipText.enabled)
		{
			new LLCJMMBBLEH(IOIJJMIFCNA());
		}
		GIMBEKBFKMJ.WinCharsAnimation.StartWinChars(delegate
		{
			if (BKBFKFGBKDP)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
			}
			else
			{
				LEGANDGOBEJ();
			}
		});
	}

	private void LEGANDGOBEJ()
	{
		BJEPPNGPMKO.AEKDDJFCIBF = true;
		GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((!LevelBuilder.LastLevel.EKGHEGKILLC) ? DialogLibrary.GABGKBAKHDP.WinDialog : DialogLibrary.GABGKBAKHDP.CLWinDialog, false);
		WinDialog component = gameObject.GetComponent<WinDialog>();
		component.Win(this);
		AudioManager.ForceStopAll();
		AudioManager.PlayStinger(KOOGPFAPGGD.StingerLevelComplete);
		GIMBEKBFKMJ.TapToSkipText.DOKill();
		GIMBEKBFKMJ.TapToSkipText.enabled = false;
		GIMBEKBFKMJ.TapToSkipCollider.enabled = false;
	}

	public void DJFBMDLNFEC()
	{
		Time.timeScale = 1f;
		TapListener.Instance.IncreaseBlockRequests();
		BoosterTapListener.Instance.IncreaseBlockRequests();
		new LLCJMMBBLEH(HBJEBDBEOED());
	}

	private IEnumerator HBJEBDBEOED()
	{
		yield return MCJHHDACJBG.KNLADMIBAAD;
		AudioManager.PlayStinger(KOOGPFAPGGD.StingerEndGameOfferIntro);
		KFHIMNCFLFD++;
		int num = Math.Min(KFHIMNCFLFD, 5);
		int num2 = num - 1;
		GameObject gameObject;
		if (num2 > 0)
		{
			gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EgoDialogs[num2], false, false, false, null, false);
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground(false, 0.5f);
		}
		else
		{
			gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EgoDialogs[num2], false, false, true, null, false);
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground(false, 0.5f);
		}
		PlayRandomSpineAnimations.ComboItemWillExplode = false;
		EgoDialog component = gameObject.GetComponent<EgoDialog>();
		if (component != null)
		{
			component.SetLevel(this, KFHIMNCFLFD);
		}
	}

	public void BJNCBHLLIGH()
	{
		SettingsPanel.Instance.DisableBottomPanel();
		new LLCJMMBBLEH(NCEMNMEMAKM());
	}

	private IEnumerator NCEMNMEMAKM()
	{
		yield return MCJHHDACJBG.KNLADMIBAAD;
		SettingsPanel.Instance.EnableBottomPanel();
		AudioManager.PlayStinger(KOOGPFAPGGD.StingerEndGameOfferIntro);
		GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((!LevelBuilder.LastLevel.EKGHEGKILLC) ? DialogLibrary.GABGKBAKHDP.NoPossibleMovesDialog : DialogLibrary.GABGKBAKHDP.CLNoPossibleMovesDialog, true);
		NoPossibleMovesDialog component = gameObject.GetComponent<NoPossibleMovesDialog>();
		component.SetContent(this);
	}

	public void INPDCFLCIIE(float DKIPEJPGACG)
	{
		new LLCJMMBBLEH(FLIDNIEBFEE(DKIPEJPGACG));
	}

	private IEnumerator FLIDNIEBFEE(float DKIPEJPGACG)
	{
		yield return new WaitForSeconds(DKIPEJPGACG);
		OOJBDEHGPOC();
	}

	public void OOJBDEHGPOC()
	{
		LevelBuilder.Recorder.PHPICMEFNAI();
		TapListener.Instance.DecreaseBlockRequests();
		BoosterTapListener.Instance.DecreaseBlockRequests();
		KOJNPMCHBAE += INGPPJECAMI;
		SettingsPanel.Instance.EnableBottomPanel();
		BJEPPNGPMKO.MovesLeftText.FCJBBPHFNPJ = EBMFPDNPIEM.CMACDGCBKLO();
		BJEPPNGPMKO.StopLast5Moves();
		GIMBEKBFKMJ.CurrentHintManager.EnableHints();
		GIMBEKBFKMJ.PopulateEgoItems();
	}

	public FCPPDOMBLHL IPFAJHMMGPF(List<FCPPDOMBLHL> JKPHLDCJHNA)
	{
		if (!CIPIEIHKJHN)
		{
			return FCPPDOMBLHL.None;
		}
		foreach (FCPPDOMBLHL item in JKPHLDCJHNA)
		{
			HICNCEMBCBG value;
			DCJNBADOLGD.TryGetValue(item, out value);
			if (value != null && value.COMOHDMIFJN && value.DNKDIJEDFHO(MAEILEPNBAE))
			{
				return item;
			}
		}
		return FCPPDOMBLHL.None;
	}

	public void KMEOMFGKMJC()
	{
		if (ELEHIDCIDJN.IFNGGNOPIBG())
		{
			return;
		}
		for (int i = 0; i < OGIJEDJHMNG.Count; i++)
		{
			JFIEHOCCBNG jFIEHOCCBNG = OGIJEDJHMNG[i];
			Item item = jFIEHOCCBNG as Item;
			if (item != null && item.gameObject.activeSelf)
			{
				jFIEHOCCBNG.ExplosionOccured(EBMFPDNPIEM);
			}
		}
	}

	public void PPOFGAFEACD()
	{
		for (int i = 0; i < OGLGBIKJDCP.Count; i++)
		{
			LAGOKFDALBI lAGOKFDALBI = OGLGBIKJDCP[i];
			Item item = lAGOKFDALBI as Item;
			if (item != null && item.gameObject.activeSelf)
			{
				lAGOKFDALBI.TouchOccured();
			}
		}
	}

	public bool CELPAPAMMFK()
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			int eNBPGGCIADN = (int)oGIFMLFEAEM.ENBPGGCIADN;
			if (oGIFMLFEAEM.GMCGMPEEHJP - OEOBPBFCEPB[eNBPGGCIADN] > 0)
			{
				return false;
			}
		}
		return true;
	}

	public bool BDIFIPAIELJ(NOALGNJECAD HBBIFNLDKPO)
	{
		for (int i = 0; i < JKKJLDLMIOG.Count; i++)
		{
			OGIFMLFEAEM oGIFMLFEAEM = JKKJLDLMIOG[i];
			if (HBBIFNLDKPO == oGIFMLFEAEM.ENBPGGCIADN)
			{
				int eNBPGGCIADN = (int)oGIFMLFEAEM.ENBPGGCIADN;
				if (oGIFMLFEAEM.GMCGMPEEHJP - OEOBPBFCEPB[eNBPGGCIADN] > 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	public void NBAMJKCNMHP(NOALGNJECAD NBFBPNNEKMN, List<int> GFGOPEFGJIG, Dictionary<FCPPDOMBLHL, HICNCEMBCBG> MMJECNJJJDO)
	{
		if (JDIFDAKOBHO.ContainsKey(NBFBPNNEKMN))
		{
			return;
		}
		List<LEDBLDKJBAI> list = new List<LEDBLDKJBAI>();
		JDIFDAKOBHO.Add(NBFBPNNEKMN, list);
		if (GFGOPEFGJIG.Count == 0)
		{
			HashSet<LEDBLDKJBAI> hashSet = new HashSet<LEDBLDKJBAI>();
			foreach (KeyValuePair<FCPPDOMBLHL, HICNCEMBCBG> item2 in MMJECNJJJDO)
			{
				List<int> list2 = item2.Value.DLJPFHJPABB;
				int i = 0;
				for (int count = list2.Count; i < count; i++)
				{
					ALIFCLNJKPH bDKFNEDHAOJ = (ALIFCLNJKPH)list2[i];
					LEDBLDKJBAI item = bDKFNEDHAOJ.AMLEHGPGGIC().OFBMGJCGHFE();
					hashSet.Add(item);
				}
			}
			{
				foreach (LEDBLDKJBAI item3 in hashSet)
				{
					if (!item3.Equals(LEDBLDKJBAI.None))
					{
						list.Add(item3);
					}
				}
				return;
			}
		}
		int j = 0;
		for (int count2 = GFGOPEFGJIG.Count; j < count2; j++)
		{
			if (GFGOPEFGJIG[j] != -1)
			{
				LEDBLDKJBAI lEDBLDKJBAI = LEDBLDKJBAI.None;
				switch (GFGOPEFGJIG[j])
				{
				case 0:
					lEDBLDKJBAI = LEDBLDKJBAI.Yellow;
					break;
				case 1:
					lEDBLDKJBAI = LEDBLDKJBAI.Red;
					break;
				case 2:
					lEDBLDKJBAI = LEDBLDKJBAI.Blue;
					break;
				case 3:
					lEDBLDKJBAI = LEDBLDKJBAI.Green;
					break;
				case 4:
					lEDBLDKJBAI = LEDBLDKJBAI.Purple;
					break;
				case 5:
					lEDBLDKJBAI = LEDBLDKJBAI.Orange;
					break;
				default:
					lEDBLDKJBAI = LEDBLDKJBAI.None;
					break;
				}
				list.Add(lEDBLDKJBAI);
			}
		}
	}

	public int APDPLIOJAHC(NOALGNJECAD HBBIFNLDKPO, LEDBLDKJBAI JOCKKMJBJLL)
	{
		List<LEDBLDKJBAI> value;
		if (!JDIFDAKOBHO.TryGetValue(HBBIFNLDKPO, out value))
		{
			return -1;
		}
		int i = 0;
		for (int count = value.Count; i < count; i++)
		{
			if (JOCKKMJBJLL == value[i])
			{
				return i;
			}
		}
		return -1;
	}

	public LEDBLDKJBAI FBKNLKDOAKD(NOALGNJECAD HBBIFNLDKPO, ref int EHJNMODJEAN)
	{
		List<LEDBLDKJBAI> value;
		if (!JDIFDAKOBHO.TryGetValue(HBBIFNLDKPO, out value))
		{
			return LEDBLDKJBAI.None;
		}
		int count = value.Count;
		if (count == 0)
		{
			return LEDBLDKJBAI.None;
		}
		EHJNMODJEAN = ++EHJNMODJEAN % count;
		return value[EHJNMODJEAN];
	}

	public LEDBLDKJBAI KIEPOCCJHIC(NOALGNJECAD HBBIFNLDKPO, ref int EHJNMODJEAN)
	{
		List<LEDBLDKJBAI> value;
		if (!JDIFDAKOBHO.TryGetValue(HBBIFNLDKPO, out value))
		{
			return LEDBLDKJBAI.None;
		}
		int count = value.Count;
		if (count == 0)
		{
			return LEDBLDKJBAI.None;
		}
		EHJNMODJEAN = BFGGHJGIHLJ.FDFDDKBDPEG(0, count, 10);
		return value[EHJNMODJEAN];
	}

	public void KIOHBMGLOMM()
	{
		NJHCINMDGKB = new int[Enum.GetNames(typeof(NOALGNJECAD)).Length];
	}

	public void LMHAIBOEDKI(int CMAJLIAELDP, short CKMIJIHDIPP)
	{
		JKKJLDLMIOG[CMAJLIAELDP].GMCGMPEEHJP = CKMIJIHDIPP;
		BJEPPNGPMKO.UpdateGoalCount(CMAJLIAELDP, CKMIJIHDIPP);
	}

	[CompilerGenerated]
	private void DLJPEHLEAGO()
	{
		if (BKBFKFGBKDP)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Cancelling win animations!");
		}
		else
		{
			LEGANDGOBEJ();
		}
	}
}
