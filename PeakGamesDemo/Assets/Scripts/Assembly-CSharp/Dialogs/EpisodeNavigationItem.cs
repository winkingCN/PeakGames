using Assets.Scripts.MapScene;
using Assets.Scripts.Utils.TextCurver;
using DG.Tweening;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace Dialogs
{
	public class EpisodeNavigationItem : VerticalScrollEntry
	{
		public GameObject Quad;

		public SpriteRenderer LockImage;

		public TextMeshPro TitleActiveText;

		public TextMeshPro TitlePassiveText;

		public TextMeshPro EpisodeText;

		public TextMeshPro LevelText;

		public SpriteRenderer ActiveFrameRight;

		public SpriteRenderer ActiveFrameLeft;

		public SpriteRenderer PassiveFrameRight;

		public SpriteRenderer PassiveFrameLeft;

		public SpriteRenderer EpisodeBgActive;

		public SpriteRenderer EpisodeBgPassive;

		public SpriteRenderer RibbonLeftActive;

		public SpriteRenderer RibbonRightActive;

		public SpriteRenderer RibbonLeftPassive;

		public SpriteRenderer RibbonRightPassive;

		public SpriteRenderer RibbonLeftCL;

		public SpriteRenderer RibbonRightCL;

		public SpriteRenderer RibbonLeftGlow;

		public SpriteRenderer RibbonRightGlow;

		public SpriteRenderer GlowFrameRight;

		public SpriteRenderer GlowFrameLeft;

		public SpriteRenderer CLFrameRight;

		public SpriteRenderer CLFrameLeft;

		public SpriteRenderer LevelsLeftActive;

		public SpriteRenderer LevelsRightActive;

		public SpriteRenderer LevelsLeftPassive;

		public SpriteRenderer LevelsRightPassive;

		public GameObject Seperator;

		public GameObject JapanesseSun;

		public TextCurver ActiveTextCurver;

		public TextCurver PassiveTextCurver;

		public MeshRenderer CurrentMeshRenderer;

		public SpriteRenderer[] GlowAnimationSpriteRenderers;

		private const float IAEDCPOGCCE = 0.1992f;

		private const float GNODHDLKFLC = 0.2293f;

		private bool GHBCLNBAIEP;

		private readonly Color PHOLEAKGKOG = new Color(0.52156866f, 0.36862746f, 0.21960784f);

		private readonly Color DIMEALNLFDI = new Color(0.3529412f, 0.4117647f, 7f / 15f);

		private Tweener DLIOGCCABLI;

		private Sequence MANOGPIHFGH;

		public void Prepare(JFGLEMFBNDB MBBPBGHKLJM)
		{
			bool flag = MapManager.Instance.AGBOBACEIEP >= MBBPBGHKLJM.DNIBBPGALFM;
			int num = (MBBPBGHKLJM.DNIBBPGALFM - 1) * 2;
			if (!flag)
			{
				num++;
			}
			int num2 = num % 20 % 5;
			int num3 = num % 20 / 5;
			if (DLIOGCCABLI != null)
			{
				DLIOGCCABLI.Kill();
				DLIOGCCABLI = null;
			}
			CurrentMeshRenderer.material.mainTexture = MBBPBGHKLJM.JPONIAPKDDG;
			if (MBBPBGHKLJM.LAKELHJCAHM)
			{
				NEFEGJKIKJF();
				CurrentMeshRenderer.material.mainTextureScale = new Vector2(1f, 1f);
				CurrentMeshRenderer.material.mainTextureOffset = new Vector2(0f, 0f);
				JapanesseSun.SetActive(true);
				DLIOGCCABLI = JapanesseSun.transform.DOLocalRotate(new Vector3(0f, 0f, -179.99f), 20f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
			}
			else
			{
				EDKJABHEMEK();
				CurrentMeshRenderer.material.mainTextureScale = new Vector2(0.1992f, 0.2293f);
				CurrentMeshRenderer.material.mainTextureOffset = new Vector2((float)num2 * 0.1992f, (float)num3 * 0.2293f);
				JapanesseSun.SetActive(false);
			}
			if (flag || MBBPBGHKLJM.LAKELHJCAHM)
			{
				CurrentMeshRenderer.sharedMaterial.SetFloat("_Alpha", 0f);
				CurrentMeshRenderer.sharedMaterial.SetFloat("_Distortion", 0f);
			}
			else
			{
				CurrentMeshRenderer.sharedMaterial.SetFloat("_R", 0f);
				CurrentMeshRenderer.sharedMaterial.SetFloat("_G", 0.09f);
				CurrentMeshRenderer.sharedMaterial.SetFloat("_B", 0.133f);
				CurrentMeshRenderer.sharedMaterial.SetFloat("_Alpha", 0.3f);
				CurrentMeshRenderer.sharedMaterial.SetFloat("_Distortion", 0f);
			}
			BFIGMHGGHNJ(LockImage, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(ActiveFrameRight, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(ActiveFrameLeft, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(PassiveFrameRight, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(PassiveFrameLeft, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(EpisodeBgActive, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(EpisodeBgPassive, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonLeftActive, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonRightActive, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonLeftPassive, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonRightPassive, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(LevelsLeftActive, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(LevelsRightActive, flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(LevelsLeftPassive, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(LevelsRightPassive, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			OMLLJPHKIOP(Seperator, MBBPBGHKLJM.DNIBBPGALFM != 1);
			AEILFEGAKDE(TitlePassiveText, !flag && !MBBPBGHKLJM.LAKELHJCAHM);
			AEILFEGAKDE(TitleActiveText, flag || MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonLeftCL, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonRightCL, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonLeftGlow, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(RibbonRightGlow, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(GlowFrameLeft, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(GlowFrameRight, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(CLFrameLeft, MBBPBGHKLJM.LAKELHJCAHM);
			BFIGMHGGHNJ(CLFrameRight, MBBPBGHKLJM.LAKELHJCAHM);
			Color color = ((!flag && !MBBPBGHKLJM.LAKELHJCAHM) ? DIMEALNLFDI : PHOLEAKGKOG);
			ENKPPFHGKAD(TitleActiveText, ActiveTextCurver, MBBPBGHKLJM.OKMNNEHGGKO);
			ENKPPFHGKAD(TitlePassiveText, PassiveTextCurver, MBBPBGHKLJM.OKMNNEHGGKO);
			LevelText.color = color;
			EpisodeText.color = color;
			LevelText.FCJBBPHFNPJ = MBBPBGHKLJM.NAFCFOIIBAO;
			TitleActiveText.FCJBBPHFNPJ = MBBPBGHKLJM.DPMEHKMMBIP;
			TitlePassiveText.FCJBBPHFNPJ = MBBPBGHKLJM.DPMEHKMMBIP;
			EpisodeText.FCJBBPHFNPJ = MBBPBGHKLJM.PPLOMOBAEIB;
		}

		private static void ENKPPFHGKAD(TextMeshPro FCJBBPHFNPJ, TextCurver IFMBKNCPNGA, NNKPJCPJPPA GGBJDIPCEFB)
		{
			IFMBKNCPNGA.VertexCurve = new AnimationCurve(new Keyframe(0f, GGBJDIPCEFB.LJFPAJMHLKJ), new Keyframe(0.5f, GGBJDIPCEFB.ELNEKNHAKJN), new Keyframe(1f, 0f));
			IFMBKNCPNGA.VertexCurve.SmoothTangents(0, 0f);
			IFMBKNCPNGA.VertexCurve.SmoothTangents(2, 0f);
			Vector3 localPosition = FCJBBPHFNPJ.ANLKLKAINEO.localPosition;
			localPosition.y = 4.545f + (GGBJDIPCEFB.KEDHKAPOGDE - 3.45f);
			FCJBBPHFNPJ.ANLKLKAINEO.localPosition = localPosition;
		}

		private void NEFEGJKIKJF()
		{
			if (MANOGPIHFGH != null)
			{
				MANOGPIHFGH.Kill();
			}
			MANOGPIHFGH = DOTween.Sequence();
			Color color = new Color(1f, 1f, 1f, 1f);
			for (int i = 0; i < GlowAnimationSpriteRenderers.Length; i++)
			{
				GlowAnimationSpriteRenderers[i].color = color;
				MANOGPIHFGH.Insert(0f, GlowAnimationSpriteRenderers[i].DOFade(0.3f, 1f)).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
			}
		}

		private void EDKJABHEMEK()
		{
			if (MANOGPIHFGH != null)
			{
				MANOGPIHFGH.Kill();
				MANOGPIHFGH = null;
				Color color = new Color(1f, 1f, 1f, 1f);
				for (int i = 0; i < GlowAnimationSpriteRenderers.Length; i++)
				{
					GlowAnimationSpriteRenderers[i].color = color;
				}
			}
		}

		private void OMLLJPHKIOP(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}

		private void BFIGMHGGHNJ(SpriteRenderer GGOAIKFJJEI, bool ODCADGABBHJ)
		{
			if (GGOAIKFJJEI.enabled != ODCADGABBHJ)
			{
				GGOAIKFJJEI.enabled = ODCADGABBHJ;
			}
		}

		private void AEILFEGAKDE(TextMeshPro EBKNMAPNPFA, bool ODCADGABBHJ)
		{
			if (EBKNMAPNPFA.enabled != ODCADGABBHJ)
			{
				EBKNMAPNPFA.enabled = ODCADGABBHJ;
			}
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			JFGLEMFBNDB mBBPBGHKLJM = IFLICJGCCNM as JFGLEMFBNDB;
			Prepare(mBBPBGHKLJM);
		}
	}
}
