using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace Dialogs
{
	public class EpisodeNavigationDialog : FullscreenDialog
	{
		private readonly int JDFANJKJJJF = 4;

		private readonly float CNNDHPKLOJG = 11.76f;

		private readonly float KDDCFLIKEOM = -7f;

		public EpisodeNavigationItem EpisodeItemPrefab;

		public SpriteRenderer BackgroundSpriteRenderer;

		public VerticalScrollController ScrollController;

		public Transform BottomMenu;

		public Transform TopShadow;

		public TextMeshPro CloseText;

		public Texture2D CLTexture;

		private List<JFGLEMFBNDB> LAKDGKIPIHI = new List<JFGLEMFBNDB>();

		private Dictionary<int, EpisodeNavigationItem> BMPDNGCMADC = new Dictionary<int, EpisodeNavigationItem>();

		private global::FHOJBJMMNOD<JFGLEMFBNDB, EpisodeNavigationItem> JKANNLPGLPJ;

		private int GDBIIIGHGLC;

		private int NLOKNODBMHO;

		private Texture2D[] LKINCDNPDOM;

		private int GFCFHIMLJHD;

		private float LJJNNJPDEBJ;

		private int LAHMDLEHIFG;

		private int BLEPLCKELBC = -1;

		public void Start()
		{
			float x = base.transform.lossyScale.x;
			BackgroundSpriteRenderer.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
		}

		public override void PlayDialogInAnimation()
		{
			Sequence sequence = DOTween.Sequence();
			sequence.Append(BackgroundSpriteRenderer.DOFade(1f, 0.5f));
			sequence.AppendCallback(base.JNHCICHFNHL);
			sequence.SetEase(Ease.Linear);
			BottomMenu.transform.position = new Vector3(0f, ONCMBJKLKIL.HINDAIPFFJL.y + (1f + ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL) * base.transform.localScale.x, 0f);
		}

		public override Sequence PlayDialogOutAnimation()
		{
			JBLHLNCOLHD();
			ScrollController.Content.gameObject.SetActive(false);
			Sequence sequence = DOTween.Sequence();
			sequence.Insert(0f, BackgroundSpriteRenderer.DOColor(new Color(13f / 51f, 16f / 51f, 0.36862746f, 0f), 0.3f));
			SpriteRenderer[] componentsInChildren = BottomMenu.transform.GetComponentsInChildren<SpriteRenderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				sequence.Insert(0f, componentsInChildren[i].DOFade(0f, 0.3f));
			}
			sequence.Insert(0f, CloseText.DOFade(0f, 0.3f));
			return sequence;
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			GFCFHIMLJHD = 64;
			LKINCDNPDOM = new Texture2D[7];
			base.transform.position = Vector3.zero;
			BackgroundSpriteRenderer.color = new Color(13f / 51f, 16f / 51f, 0.36862746f, 1f);
			TopShadow.transform.position = new Vector3(0f, ONCMBJKLKIL.ECLBGPBLGMD.y + 0.2f * base.transform.lossyScale.y, 0f);
			int currentEpisodeNo = MapManager.Instance.AGBOBACEIEP;
			int num = currentEpisodeNo - 1;
			GDBIIIGHGLC = num / 10;
			NLOKNODBMHO = ((num % 10 <= 5) ? (GDBIIIGHGLC - 1) : (GDBIIIGHGLC + 1));
			LKINCDNPDOM[GDBIIIGHGLC] = LJDGBAMMEAM.NKKJHAKFKEJ("NewMapAssets/EpisodeNavigation" + (GDBIIIGHGLC + 1));
			if (NLOKNODBMHO >= 0 && NLOKNODBMHO < LKINCDNPDOM.Length)
			{
				LKINCDNPDOM[NLOKNODBMHO] = LJDGBAMMEAM.NKKJHAKFKEJ("NewMapAssets/EpisodeNavigation" + (NLOKNODBMHO + 1));
			}
			for (int num2 = GFCFHIMLJHD; num2 >= 0; num2--)
			{
				int num3 = num2 + 1;
				Vector2 levelsForEpisode = MapManager.GetLevelsForEpisode(num3);
				JFGLEMFBNDB jFGLEMFBNDB = new JFGLEMFBNDB();
				if (num2 == GFCFHIMLJHD)
				{
					jFGLEMFBNDB.LAKELHJCAHM = true;
					jFGLEMFBNDB.JPONIAPKDDG = CLTexture;
					jFGLEMFBNDB.PPLOMOBAEIB = string.Empty;
					jFGLEMFBNDB.NAFCFOIIBAO = string.Empty;
					jFGLEMFBNDB.DPMEHKMMBIP = NKILHODNBDE.GHBGCADFLFB("ChampionsLeague");
					jFGLEMFBNDB.OKMNNEHGGKO = ((!PNAJOCHGJFO.LOEHJECLFHL.Equals("English")) ? EpisodeUnlockedDialog.DefaultCurveProps : EpisodeUnlockedDialog.EpisodeCurveProps[0]);
				}
				else
				{
					JFGLEMFBNDB jFGLEMFBNDB2 = new JFGLEMFBNDB();
					jFGLEMFBNDB2.DNIBBPGALFM = num3;
					jFGLEMFBNDB2.PPLOMOBAEIB = NKILHODNBDE.GHBGCADFLFB("Episode") + " " + num3;
					jFGLEMFBNDB2.NAFCFOIIBAO = NKILHODNBDE.GHBGCADFLFB("Levels") + "  " + (int)levelsForEpisode.x + "-" + (int)levelsForEpisode.y;
					jFGLEMFBNDB2.DPMEHKMMBIP = NKILHODNBDE.GHBGCADFLFB("EpisodeTitle_" + num3);
					jFGLEMFBNDB2.JPONIAPKDDG = LKINCDNPDOM[(num3 - 1) / 10];
					jFGLEMFBNDB2.OKMNNEHGGKO = ((!PNAJOCHGJFO.LOEHJECLFHL.Equals("English")) ? EpisodeUnlockedDialog.DefaultCurveProps : EpisodeUnlockedDialog.EpisodeCurveProps[num3]);
					jFGLEMFBNDB = jFGLEMFBNDB2;
				}
				LAKDGKIPIHI.Add(jFGLEMFBNDB);
			}
			float num4 = ONCMBJKLKIL.EMFKAPJMDCC / 10.24f;
			LEJICLFDBAJ gNGIGAPBFCN = ONCMBJKLKIL.GNGIGAPBFCN;
			float num5 = (gNGIGAPBFCN.ECLBGPBLGMD + gNGIGAPBFCN.HINDAIPFFJL) / 2f + 1.75f;
			ScrollController.Init(ONCMBJKLKIL.ILFBJBBBFID);
			ScrollController.SetScrollAreaHeight(ONCMBJKLKIL.FHAMOHDEGMK / num4 - num5);
			ScrollController.ScrollArea.offset = Vector2.up * (num5 / 2f);
			ScrollController.SetOffsets(0f, KDDCFLIKEOM * num4);
			ScrollController.SetContentSize((float)(GFCFHIMLJHD + 1) * CNNDHPKLOJG - 4.7f / num4);
			ScrollController.SetLocalPos((!IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN) ? ((float)(GFCFHIMLJHD + 1 - currentEpisodeNo) * CNNDHPKLOJG) : 0f);
			ScrollController.JBOFOOHGDGC();
			JKANNLPGLPJ = new global::FHOJBJMMNOD<JFGLEMFBNDB, EpisodeNavigationItem>(ScrollController, EpisodeItemPrefab, 4);
			JKANNLPGLPJ.FEHBHKPHBFC(JDFANJKJJJF, CNNDHPKLOJG, 0f, 7f);
			JKANNLPGLPJ.BBOMMEKKAEB(LAKDGKIPIHI);
			JKANNLPGLPJ.GEKBMINLCLJ(OJPABGFGLDA);
			StartCoroutine(ADKFNPFOCBC());
		}

		public override bool CanHandleBackButton()
		{
			return true;
		}

		private IEnumerator ADKFNPFOCBC()
		{
			LJJNNJPDEBJ = ScrollController.Content.transform.localPosition.y;
			while (true)
			{
				float value = LJJNNJPDEBJ - ScrollController.Content.localPosition.y;
				if (Math.Abs(value) > CNNDHPKLOJG * 0.75f)
				{
					break;
				}
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			LAHMDLEHIFG = 1;
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			FPGFIAKIIID();
			AFJPGLHKOID.CPIGOAGGLBM("EpisodeNavigationClose", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, LAHMDLEHIFG, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		}

		private void OJPABGFGLDA(int EHJNMODJEAN)
		{
			HCPBNMAAJBP(EHJNMODJEAN);
		}

		private void HCPBNMAAJBP(int EHJNMODJEAN)
		{
			if (BLEPLCKELBC == -1)
			{
				BLEPLCKELBC = EHJNMODJEAN;
			}
			int num = BLEPLCKELBC - EHJNMODJEAN;
			BLEPLCKELBC = EHJNMODJEAN;
			int num2 = GFCFHIMLJHD - 1 - EHJNMODJEAN;
			int num3 = num2 / 10;
			bool flag = (num > 0 && num2 == num3 * 10 + 7) || (num < 0 && num2 == num3 * 10 + 3);
			int num4 = num3 + num;
			if (!flag || (GDBIIIGHGLC == num3 && NLOKNODBMHO == num4))
			{
				return;
			}
			if (LKINCDNPDOM[num3] == null)
			{
				LKINCDNPDOM[num3] = LJDGBAMMEAM.NKKJHAKFKEJ("NewMapAssets/EpisodeNavigation" + (num3 + 1));
			}
			if (num4 >= 0 && num4 < LKINCDNPDOM.Length && LKINCDNPDOM[num4] == null)
			{
				LKINCDNPDOM[num4] = LJDGBAMMEAM.NKKJHAKFKEJ("NewMapAssets/EpisodeNavigation" + (num4 + 1));
			}
			bool flag2 = GDBIIIGHGLC != num4 && GDBIIIGHGLC != num3;
			for (int i = 0; i < LAKDGKIPIHI.Count; i++)
			{
				int num5 = (LAKDGKIPIHI[i].DNIBBPGALFM - 1) / 10;
				if (!LAKDGKIPIHI[i].LAKELHJCAHM)
				{
					if (num5 == num3)
					{
						LAKDGKIPIHI[i].JPONIAPKDDG = LKINCDNPDOM[num3];
					}
					else if (num5 == num4)
					{
						LAKDGKIPIHI[i].JPONIAPKDDG = LKINCDNPDOM[num4];
					}
					else
					{
						LAKDGKIPIHI[i].JPONIAPKDDG = null;
					}
				}
			}
			if (flag2 && GDBIIIGHGLC >= 0 && GDBIIIGHGLC < LKINCDNPDOM.Length)
			{
				Resources.UnloadAsset(LKINCDNPDOM[GDBIIIGHGLC]);
				LKINCDNPDOM[GDBIIIGHGLC] = null;
			}
			JKANNLPGLPJ.CABDGJJMBLD();
			GDBIIIGHGLC = num3;
			NLOKNODBMHO = num4;
		}

		private void FPGFIAKIIID()
		{
			StopAllCoroutines();
			LAKDGKIPIHI = null;
			foreach (KeyValuePair<int, EpisodeNavigationItem> item in BMPDNGCMADC)
			{
				UnityEngine.Object.Destroy(item.Value);
			}
			JKANNLPGLPJ.ICDJLHGBPKP();
			BMPDNGCMADC = null;
			Resources.UnloadUnusedAssets();
		}
	}
}
