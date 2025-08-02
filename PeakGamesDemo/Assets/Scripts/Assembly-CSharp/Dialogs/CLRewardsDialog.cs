using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils.Analytics;
using DG.Tweening;
using DataHelpers;
using NewMapScene;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class CLRewardsDialog : FullscreenDialog
	{
		public static bool DialogActive;

		public VerticalScrollController ScrollController;

		public TextMeshPro YourRank;

		public GameObject RewardsEntryPrefab;

		public GameObject[] CoinRewards;

		public GameObject RewardItemContainer;

		public TextMeshPro ItemAmount;

		public TextMeshPro NoRewardText;

		public TextMeshPro ButtonText;

		public SpriteRenderer RewardItemSpriteRenderer;

		public SpriteRenderer RewardItemShadowSpriteRenderer;

		public Transform JapaneseSunContent;

		public GameObject LoadingIndicator;

		public Transform BackgroundImage;

		public Transform ClaimButton;

		public Transform BottomMask;

		public RewardText CoinRewardText;

		private global::FHOJBJMMNOD<BDELNAHPDFB, CLRewardsEntry> JKANNLPGLPJ;

		private Action JCOKJJGCPHI;

		private Action JBJKNCHCDOK;

		private bool EKCINKDJPDI;

		private int DJJBGNGNLNI;

		private CLRewardItem MLHENHABGMO;

		private ClLeaderboard HCJJHPGMEHK;

		private readonly Dictionary<int, List<CLRewardItem>> INCCLAOPKJE = new Dictionary<int, List<CLRewardItem>>();

		private float EDEONNLKCDF;

		private float ANJBHOECJME;

		private int LOPCMGEBLNH;

		public void Start()
		{
			float x = base.transform.lossyScale.x;
			BackgroundImage.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = ((!(ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL > 0f)) ? 0f : (ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL - 0.104114f));
				float num2 = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num3 = (ONCMBJKLKIL.FHAMOHDEGMK - num2) * 0.5f - num;
				Vector3 localPosition = ClaimButton.transform.localPosition;
				localPosition.y = -7.86f - num3;
				ClaimButton.transform.localPosition = localPosition;
				Vector3 localPosition2 = BottomMask.localPosition;
				localPosition2.y = -8.96f - num3;
				BottomMask.localPosition = localPosition2;
				Vector2 size = ScrollController.ScrollArea.size;
				size.y += num3;
				ScrollController.ScrollArea.size = size;
				Vector2 offset = ScrollController.ScrollArea.offset;
				offset.y -= num3 * 0.5f;
				ScrollController.ScrollArea.offset = offset;
				EDEONNLKCDF = num3 * 0.5f;
				if (JKANNLPGLPJ != null)
				{
					ScrollController.SetOffsets(0f - EDEONNLKCDF, 0f - EDEONNLKCDF);
					ScrollController.SetContentSize(ANJBHOECJME);
					ScrollController.SetLocalPos((float)LOPCMGEBLNH * 1.4f);
					ScrollController.JBOFOOHGDGC();
				}
			}
		}

		public override void DialogCreated()
		{
			DialogActive = true;
			base.transform.localPosition = new Vector3(0f, 1000f, 0f);
			base.NCJFEFMJKFA = Time.frameCount;
			DJJBGNGNLNI = IDFPAFEJPPH.GABGKBAKHDP.OHAPPDGAKNG;
			YourRank.FCJBBPHFNPJ = "#" + DJJBGNGNLNI;
			ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Continue");
			JNHCICHFNHL();
			FCPPFFMGFFE();
			JapaneseSunContent.transform.DORotate(new Vector3(0f, 0f, -179.99f), 15f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
		}

		private void PDHNGJPKLPB(NAAHKHPBAPA GEKKLIKPAPP)
		{
			switch (GEKKLIKPAPP)
			{
			case NAAHKHPBAPA.BoxingGlove:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 1.26f;
				break;
			case NAAHKHPBAPA.Rocket:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.9f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.96f;
				break;
			case NAAHKHPBAPA.Dice:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.9f;
				RewardItemSpriteRenderer.transform.localPosition = RewardItemSpriteRenderer.transform.localPosition + Vector3.right * 0.06f;
				break;
			case NAAHKHPBAPA.Bomb:
			case NAAHKHPBAPA.Extra5Moves:
				break;
			}
		}

		private void ENIHNAEFMNK(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.transform.localPosition = Vector3.zero;
		}

		public override Sequence PlayDialogOutAnimation()
		{
			return DOTween.Sequence();
		}

		public override void OnDialogClosed()
		{
			DialogActive = false;
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
		}

		private void FCPPFFMGFFE()
		{
			IList<ClMember> list = IDFPAFEJPPH.GABGKBAKHDP.NDABFDHPIBB;
			if (list == null)
			{
				return;
			}
			JOMEIIAHOMO();
			int count = list.Count;
			List<BDELNAHPDFB> list2 = new List<BDELNAHPDFB>();
			int num = 0;
			int num2 = 0;
			long num3 = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			foreach (ClMember item in list)
			{
				num++;
				BDELNAHPDFB bDELNAHPDFB = new BDELNAHPDFB();
				bDELNAHPDFB.KKMJBOCCMCF = long.Parse(item.id);
				bDELNAHPDFB.DJADMBLKBKJ = item.score;
				bDELNAHPDFB.OHAPPDGAKNG = num;
				bDELNAHPDFB.KJACEODCOHN = item.nickname;
				BDELNAHPDFB bDELNAHPDFB2 = bDELNAHPDFB;
				List<CLRewardItem> value = null;
				if (INCCLAOPKJE.TryGetValue(num, out value))
				{
					bDELNAHPDFB2.BIEIJGOBEIA = value[0].amount;
					bDELNAHPDFB2.IHHMGILLMDB = value[0].id;
				}
				if (bDELNAHPDFB2.KKMJBOCCMCF == num3)
				{
					num2 = num;
				}
				list2.Add(bDELNAHPDFB2);
			}
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<BDELNAHPDFB, CLRewardsEntry>(ScrollController, RewardsEntryPrefab.GetComponent<CLRewardsEntry>(), 15, 0.86f);
				JKANNLPGLPJ.FEHBHKPHBFC(11, 1.4f, 0.7f);
				ScrollController.Init();
				ScrollController.SetOffsets(0f - EDEONNLKCDF, 0f - EDEONNLKCDF);
			}
			LOPCMGEBLNH = num2;
			ANJBHOECJME = (float)count * 1.4f + 0.4f;
			JKANNLPGLPJ.BBOMMEKKAEB(list2);
			ScrollController.SetContentSize(ANJBHOECJME);
			ScrollController.SetLocalPos((float)num2 * 1.4f);
			ScrollController.JBOFOOHGDGC();
		}

		private void JOMEIIAHOMO()
		{
			CLRewardsJson cLRewardsJson = IDFPAFEJPPH.GABGKBAKHDP.COGMBHJAPNO();
			if (cLRewardsJson == null)
			{
				return;
			}
			foreach (CLRewardItem reward in cLRewardsJson.rewards)
			{
				if (!INCCLAOPKJE.ContainsKey(reward.rank))
				{
					INCCLAOPKJE.Add(reward.rank, new List<CLRewardItem>());
				}
				INCCLAOPKJE[reward.rank].Add(reward);
			}
			List<CLRewardItem> value = null;
			INCCLAOPKJE.TryGetValue(DJJBGNGNLNI, out value);
			if (value == null)
			{
				return;
			}
			ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Claim");
			NoRewardText.enabled = false;
			MLHENHABGMO = value[0];
			NAAHKHPBAPA id = (NAAHKHPBAPA)MLHENHABGMO.id;
			if ((id.LGOKFILDDDD() || id.MCMDJCBFENO()) && MapManager.Instance != null)
			{
				MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
			}
			if (DJJBGNGNLNI < 4)
			{
				ENIHNAEFMNK(RewardItemContainer, false);
				int num = DJJBGNGNLNI - 1;
				ENIHNAEFMNK(CoinRewards[0], num == 0);
				ENIHNAEFMNK(CoinRewards[1], num == 1);
				ENIHNAEFMNK(CoinRewards[2], num == 2);
				CoinRewardText.SetRewardAmount(MLHENHABGMO.amount);
				return;
			}
			ENIHNAEFMNK(CoinRewards[0], false);
			ENIHNAEFMNK(CoinRewards[1], false);
			ENIHNAEFMNK(CoinRewards[2], false);
			CoinRewardText.Activate(false);
			ENIHNAEFMNK(RewardItemContainer, MLHENHABGMO.id != 0);
			if (MLHENHABGMO.id > 0)
			{
				NAAHKHPBAPA id2 = (NAAHKHPBAPA)MLHENHABGMO.id;
				Sprite spriteByInventoryType = SharedImageLibrary.Instance.GetSpriteByInventoryType(id2);
				RewardItemSpriteRenderer.sprite = spriteByInventoryType;
				RewardItemShadowSpriteRenderer.sprite = spriteByInventoryType;
				PDHNGJPKLPB(id2);
				if (MLHENHABGMO.id != 1 && MLHENHABGMO.amount > 0)
				{
					ItemAmount.enabled = true;
					ItemAmount.FCJBBPHFNPJ = "x" + MLHENHABGMO.amount;
				}
			}
		}

		public void ClaimClicked()
		{
			BDLCDEKAPHA item = new BDLCDEKAPHA(delegate(bool EEKJMDHEJCK)
			{
				StopAllCoroutines();
				if (EEKJMDHEJCK)
				{
					try
					{
						if (INCCLAOPKJE.ContainsKey(DJJBGNGNLNI) && MLHENHABGMO != null)
						{
							JsonStarChestGifts jsonStarChestGifts = new JsonStarChestGifts
							{
								life_refill = 0
							};
							NAAHKHPBAPA id = (NAAHKHPBAPA)MLHENHABGMO.id;
							int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(id, MLHENHABGMO.amount);
							switch (id)
							{
							case NAAHKHPBAPA.Coins:
								jsonStarChestGifts.coin = MLHENHABGMO.amount;
								GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(MBEBGNDIKCM);
								break;
							case NAAHKHPBAPA.Hammer:
								jsonStarChestGifts.hammer = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.Anvil:
								jsonStarChestGifts.anvil = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.BoxingGlove:
								jsonStarChestGifts.boxingglove = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.Rocket:
								jsonStarChestGifts.rocket = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.Bomb:
								jsonStarChestGifts.bomb = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.DiscoBall:
								jsonStarChestGifts.discoball = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.Dice:
								jsonStarChestGifts.dice = MLHENHABGMO.amount;
								JBJKNCHCDOK = JCOKJJGCPHI;
								PMMDOOHHINN(FICFHHEBEDO);
								break;
							case NAAHKHPBAPA.Life:
								jsonStarChestGifts.life_refill = 1;
								break;
							}
							JsonInventory jsonInventory = new JsonInventory();
							jsonInventory.LDOCFEGBGNK();
							JsonLevelStarChest jsonLevelStarChest = new JsonLevelStarChest
							{
								gifts = jsonStarChestGifts,
								inventory = jsonInventory
							};
							jsonLevelStarChest.LLGLAHKBJJG();
							AFJPGLHKOID.KNAEDLINDAG(jsonLevelStarChest);
						}
						IDFPAFEJPPH.GABGKBAKHDP.MNJCFNHNILM();
						MapManager.Instance.ShouldShowChampionsLeague();
						return;
					}
					catch (Exception ex)
					{
						GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CLRewardsDialog, "Error giving champions league rewards to the player. Error:{0} StackTrace:{1}", ex.Message, ex.StackTrace);
						return;
					}
					finally
					{
						Close();
					}
				}
				LoadingIndicator.SetActive(false);
				JNHCICHFNHL();
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
			});
			StopAllCoroutines();
			StartCoroutine(GEEHOBDJAKB());
			JBLHLNCOLHD();
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		private IEnumerator GEEHOBDJAKB()
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			LoadingIndicator.SetActive(true);
		}

		public void PrepareDialog(Action IMHLFAHONPP, bool OKAGICINMBN)
		{
			PMMDOOHHINN(IMHLFAHONPP);
			EKCINKDJPDI = OKAGICINMBN;
		}

		private void MBEBGNDIKCM()
		{
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			IJIMKNBDAKJ(MLHENHABGMO.amount, JBJKNCHCDOK);
		}

		private void FICFHHEBEDO()
		{
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			FOLKKFOJFAG(MLHENHABGMO.id, MLHENHABGMO.amount, JBJKNCHCDOK);
		}

		private void FOLKKFOJFAG(int LBHBFGNIHCL, int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartRewardCollectAnimation((NAAHKHPBAPA)LBHBFGNIHCL, NNIDKMJGAJO, IMHLFAHONPP);
			}
		}

		private static void IJIMKNBDAKJ(int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartCoinCollectAnimation(NNIDKMJGAJO, IMHLFAHONPP, 20, NewMapPage.CoinAnimationStartPosition);
			}
		}

		private void PMMDOOHHINN(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		[CompilerGenerated]
		private void KMLMHCKACJM(bool EEKJMDHEJCK)
		{
			StopAllCoroutines();
			if (EEKJMDHEJCK)
			{
				try
				{
					if (INCCLAOPKJE.ContainsKey(DJJBGNGNLNI) && MLHENHABGMO != null)
					{
						JsonStarChestGifts jsonStarChestGifts = new JsonStarChestGifts
						{
							life_refill = 0
						};
						NAAHKHPBAPA id = (NAAHKHPBAPA)MLHENHABGMO.id;
						int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(id, MLHENHABGMO.amount);
						switch (id)
						{
						case NAAHKHPBAPA.Coins:
							jsonStarChestGifts.coin = MLHENHABGMO.amount;
							GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(MBEBGNDIKCM);
							break;
						case NAAHKHPBAPA.Hammer:
							jsonStarChestGifts.hammer = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.Anvil:
							jsonStarChestGifts.anvil = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.BoxingGlove:
							jsonStarChestGifts.boxingglove = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.Rocket:
							jsonStarChestGifts.rocket = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.Bomb:
							jsonStarChestGifts.bomb = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.DiscoBall:
							jsonStarChestGifts.discoball = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.Dice:
							jsonStarChestGifts.dice = MLHENHABGMO.amount;
							JBJKNCHCDOK = JCOKJJGCPHI;
							PMMDOOHHINN(FICFHHEBEDO);
							break;
						case NAAHKHPBAPA.Life:
							jsonStarChestGifts.life_refill = 1;
							break;
						}
						JsonInventory jsonInventory = new JsonInventory();
						jsonInventory.LDOCFEGBGNK();
						JsonLevelStarChest jsonLevelStarChest = new JsonLevelStarChest
						{
							gifts = jsonStarChestGifts,
							inventory = jsonInventory
						};
						jsonLevelStarChest.LLGLAHKBJJG();
						AFJPGLHKOID.KNAEDLINDAG(jsonLevelStarChest);
					}
					IDFPAFEJPPH.GABGKBAKHDP.MNJCFNHNILM();
					MapManager.Instance.ShouldShowChampionsLeague();
					return;
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CLRewardsDialog, "Error giving champions league rewards to the player. Error:{0} StackTrace:{1}", ex.Message, ex.StackTrace);
					return;
				}
				finally
				{
					Close();
				}
			}
			LoadingIndicator.SetActive(false);
			JNHCICHFNHL();
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
		}
	}
}
