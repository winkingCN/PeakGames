using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class LogItem : Item
	{
		[CompilerGenerated]
		private sealed class GIEMALCKBOL
		{
			internal float ADJAEJFDMDJ;

			internal LogItem PDAPIGLEPGC;

			internal float AGFNGEFDHLA()
			{
				return ADJAEJFDMDJ;
			}

			internal void KDACLOKGNAM(float AMFCENFNAJJ)
			{
				ADJAEJFDMDJ = AMFCENFNAJJ;
			}

			internal void DBLIJBPNCAN()
			{
				PDAPIGLEPGC.LogSpriteRenderer.size = new Vector2(ADJAEJFDMDJ, 1.02f);
				if (ADJAEJFDMDJ <= 0.01f && PDAPIGLEPGC.LogSpriteRenderer.enabled)
				{
					PDAPIGLEPGC.LogSpriteRenderer.enabled = false;
					PDAPIGLEPGC.LogLeft.gameObject.SetActive(false);
					PDAPIGLEPGC.LogRight.gameObject.SetActive(false);
					PDAPIGLEPGC.LogUp.gameObject.SetActive(false);
					PDAPIGLEPGC.LogDown.gameObject.SetActive(false);
				}
			}
		}

		private const float NGKGJGNOIFI = 0.5f;

		private const float LFCCPGAELDE = 0.8f;

		private const float EEDLOAMGKJA = 0.2f;

		private const int ANMGEIDPFNF = 1;

		private const int BLHOFOKENMB = 2;

		[Header("Parameters")]
		public float AnimationDuration = 0.8f;

		public float UnlockCellDuration = 0.3f;

		private readonly Ease HPLDBGGBCAM = Ease.Linear;

		[Header("References")]
		public SpriteRenderer LogSpriteRenderer;

		public SpriteRenderer TopSpriteRenderer;

		public SpriteRenderer BodySpriteRenderer;

		public SpriteRenderer Shadow;

		public Transform LogAnimationContainer;

		public Transform PositionFixer;

		public Transform SawTransform;

		public ParticleSystem SawDustParticle;

		public ParticleSystem ExplodeParticle;

		public Animator CurrentAnimator;

		public SpriteRenderer LogLeft;

		public SpriteRenderer LogRight;

		public SpriteRenderer LogUp;

		public SpriteRenderer LogDown;

		public AudioSource CurrentAudioSource;

		public SpriteRenderer[] SpriteRenderers;

		private List<LogFakeItem> BOKIPKHFJDC;

		private IEKBFJBLGFM GOOCMNFDKGH;

		private Cell CLBLLFKGOIO;

		private int GAEPGFKDBAP;

		private int JNCLFLGKBKC;

		private int HPMPKEEJEIJ;

		private int BNODCOBOJDK;

		private bool HINNFILALIG;

		private bool HKCMJOHHABM;

		private CKKKELDIOLD KKCPOOALFAD;

		private IEKBFJBLGFM CPGLBEPLEHJ;

		private static Dictionary<string, int> OJAANJGCLKB = new Dictionary<string, int>();

		private bool FGPCFJFNOAM;

		private static bool NMEHPKPJMFN(AudioClip AICMMKJMNKA)
		{
			if (!AudioManager.NAEBPOAPIFP)
			{
				return false;
			}
			if (OJAANJGCLKB.ContainsKey(AICMMKJMNKA.name))
			{
				int num = OJAANJGCLKB[AICMMKJMNKA.name];
				if (num == Time.frameCount)
				{
					return false;
				}
				OJAANJGCLKB[AICMMKJMNKA.name] = Time.frameCount;
			}
			else
			{
				OJAANJGCLKB.Add(AICMMKJMNKA.name, Time.frameCount);
			}
			return true;
		}

		public static void ResetSounds()
		{
			OJAANJGCLKB = new Dictionary<string, int>();
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Log;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int num = SpriteRenderers.Length - 1; num >= 0; num--)
			{
				if (!(SpriteRenderers[num] == null))
				{
					SpriteRenderers[num].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + num - 50;
					SpriteRenderers[num].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return BOKIPKHFJDC.Count - JNCLFLGKBKC;
		}

		public override void PlayWrongMove()
		{
		}

		public override void PlayExplodeAudio()
		{
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			TryExplode(CCPAJBOJDMN);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			PHOPGBPFOBB();
			return false;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (CCPAJBOJDMN.ENBPGGCIADN == 3)
			{
				return Vector3.zero;
			}
			Vector3 vector = BOKIPKHFJDC[0].transform.position - IDIOLIHBJBE.transform.position;
			float x = ((!(vector.x > 0f)) ? Random.Range(vector.x, 0f) : Random.Range(0f, vector.x));
			float y = ((!(vector.y > 0f)) ? Random.Range(vector.y, 0f) : Random.Range(0f, vector.y));
			return new Vector3(x, y);
		}

		protected override void EJCFANPAMMK()
		{
			LogParticlePlayer logParticlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position) as LogParticlePlayer;
			logParticlePlayer.SetDirection(CPGLBEPLEHJ);
		}

		public void LinkNeighbours()
		{
			List<IEKBFJBLGFM> list = new List<IEKBFJBLGFM>();
			list.Add(IEKBFJBLGFM.Left);
			list.Add(IEKBFJBLGFM.Right);
			list.Add(IEKBFJBLGFM.Up);
			list.Add(IEKBFJBLGFM.Down);
			List<IEKBFJBLGFM> list2 = list;
			for (int i = 0; i < list2.Count; i++)
			{
				IEKBFJBLGFM iEKBFJBLGFM = list2[i];
				if (LPMEMDOBIHA(IDIOLIHBJBE, iEKBFJBLGFM))
				{
					GOOCMNFDKGH = iEKBFJBLGFM;
					IOKIBNEBJJK(GOOCMNFDKGH);
					break;
				}
			}
			GAEPGFKDBAP = (BOKIPKHFJDC.Count + 1) * 500;
			AudioManager.RegisterExternalAudioSource(CurrentAudioSource);
			CPGLBEPLEHJ = ((ENCFFNKONOO.X == 0) ? IEKBFJBLGFM.Right : ((ENCFFNKONOO.X == ELFBOKDHKGG.JHDMFHDHIFN.EMFKAPJMDCC - 1) ? IEKBFJBLGFM.Left : IEKBFJBLGFM.None));
			ABEABGFOMAD();
			FLBLHPINLGD();
		}

		private void ABEABGFOMAD()
		{
			HKCMJOHHABM = GOOCMNFDKGH == IEKBFJBLGFM.Down || GOOCMNFDKGH == IEKBFJBLGFM.Up;
			LogLeft.gameObject.SetActive(!HKCMJOHHABM);
			LogRight.gameObject.SetActive(!HKCMJOHHABM);
			LogUp.gameObject.SetActive(HKCMJOHHABM);
			LogDown.gameObject.SetActive(HKCMJOHHABM);
			LogSpriteRenderer.size = new Vector2((float)BOKIPKHFJDC.Count - 0.34f, 1.02f);
			LogSpriteRenderer.transform.localPosition = new Vector3((float)BOKIPKHFJDC.Count / 2f + 0.525f, (!HKCMJOHHABM) ? (-0.08f) : 0f);
			TopSpriteRenderer.enabled = GOOCMNFDKGH == IEKBFJBLGFM.Down;
			BodySpriteRenderer.enabled = GOOCMNFDKGH != IEKBFJBLGFM.Down;
			Shadow.enabled = GOOCMNFDKGH == IEKBFJBLGFM.Down;
			switch (GOOCMNFDKGH)
			{
			case IEKBFJBLGFM.Left:
				PositionFixer.transform.localScale = new Vector3(-1f, 1f, 1f);
				LogRight.transform.localPosition = new Vector3((float)BOKIPKHFJDC.Count + 0.271f, -0.08f);
				break;
			case IEKBFJBLGFM.Right:
				LogRight.transform.localPosition = new Vector3((float)BOKIPKHFJDC.Count + 0.271f, -0.08f);
				break;
			case IEKBFJBLGFM.Down:
				PositionFixer.transform.eulerAngles = Vector3.forward * 270f;
				SawDustParticle.transform.localPosition = new Vector3(0.56f, 0.012f);
				SawTransform.transform.localPosition = new Vector3(0.1f, 0.08f);
				LogDown.transform.localPosition = new Vector3((float)BOKIPKHFJDC.Count + 0.27f, 0f);
				LogUp.transform.localPosition = new Vector3(0.692f, 0f);
				LogDown.flipY = false;
				LogUp.flipY = false;
				break;
			case IEKBFJBLGFM.Up:
				PositionFixer.transform.eulerAngles = Vector3.forward * 90f;
				PositionFixer.transform.localPosition = new Vector3(0f, 0.025f);
				SawDustParticle.transform.localPosition = new Vector3(0.5f, 0.093f);
				SawTransform.transform.localPosition = new Vector3(-0.1f, 0.08f);
				LogDown.transform.localPosition = new Vector3(0.78f, 0f);
				LogUp.transform.localPosition = new Vector3((float)BOKIPKHFJDC.Count + 0.348f, 0f);
				LogDown.flipY = true;
				LogUp.flipY = true;
				break;
			case IEKBFJBLGFM.LeftUp:
			case IEKBFJBLGFM.LeftDown:
			case IEKBFJBLGFM.RightUp:
				break;
			}
		}

		private void FLBLHPINLGD()
		{
			HPMPKEEJEIJ = Animator.StringToHash("Base Layer.LogItemCutLoopAnimation");
			BNODCOBOJDK = Animator.StringToHash("Base Layer.LogItemExplodeAnimation");
		}

		private void GCJHFEOBKKL()
		{
			ELFBOKDHKGG.ACJOALJFMHN(GetItemType(), true);
			FallManager.DecreaseMechanicAnimation();
			if (CLBLLFKGOIO != null)
			{
				CLBLLFKGOIO.AcceptsFallInside();
			}
			ScoreManager.RaiseScore(GAEPGFKDBAP);
			Shadow.enabled = false;
			StartExplode();
		}

		public override void RemoveSelf()
		{
			CurrentAudioSource.Stop();
			AudioManager.DeRegisterExternalAudioSource(CurrentAudioSource);
			OnBeforeRemove();
			CurrentAnimator.gameObject.SetActive(false);
			LogAnimationContainer.gameObject.SetActive(false);
			StartCoroutine(PKLCPJELMJF());
		}

		private IEnumerator PKLCPJELMJF()
		{
			ENCFFNKONOO.LBFCDKPCDPB = null;
			yield return MCJHHDACJBG.KNLADMIBAAD;
			Object.Destroy(base.gameObject);
		}

		private void PHOPGBPFOBB()
		{
			JNCLFLGKBKC++;
			if (!HINNFILALIG)
			{
				HKHCACMHKHK();
			}
		}

		private void HKHCACMHKHK()
		{
			HINNFILALIG = true;
			Sequence sequence = DOTween.Sequence();
			if (BOKIPKHFJDC.Count == 1)
			{
				FallManager.IncreaseMechanicAnimation();
				CurrentAnimator.Play(BNODCOBOJDK, 0, 0f);
				ExplodeParticle.Play(true);
				sequence.InsertCallback(0.7f, GCJHFEOBKKL);
			}
			else
			{
				CurrentAnimator.SetInteger("AnimationState", 1);
				CurrentAnimator.Play(HPMPKEEJEIJ, 0, 0f);
				if (CurrentAudioSource.clip == null || !CurrentAudioSource.loop)
				{
					AudioClip audioClip = BBKCPPOFENL.AudioClips[0].AudioClip;
					if (NMEHPKPJMFN(audioClip))
					{
						CurrentAudioSource.Stop();
						CurrentAudioSource.clip = audioClip;
						CurrentAudioSource.loop = true;
						CurrentAudioSource.Play();
					}
					else
					{
						CurrentAudioSource.loop = false;
					}
				}
				if (JNCLFLGKBKC == 1)
				{
					sequence.InsertCallback(AnimationDuration, delegate
					{
						CurrentAnimator.SetInteger("AnimationState", 2);
					});
				}
			}
			if (GOOCMNFDKGH != IEKBFJBLGFM.Down)
			{
				sequence.InsertCallback((!HKCMJOHHABM) ? UnlockCellDuration : 0.2f, delegate
				{
					CLBLLFKGOIO.AcceptsFallInside();
					CLBLLFKGOIO = null;
				});
			}
			SawDustParticle.Play(true);
			if (!FGPCFJFNOAM)
			{
				FGPCFJFNOAM = true;
				StartCoroutine(KBELMALJGLB());
			}
			int num = BOKIPKHFJDC.Count - 1;
			if (num >= 0)
			{
				CLBLLFKGOIO = OABAMMJDIOB(num);
				if (GOOCMNFDKGH != IEKBFJBLGFM.Down)
				{
					CLBLLFKGOIO.RejectsFallInside();
				}
				float ADJAEJFDMDJ = LogSpriteRenderer.size.x;
				float endValue = (float)BOKIPKHFJDC.Count - 0.34f;
				sequence.Insert(0f, DOTween.To(() => ADJAEJFDMDJ, delegate(float AMFCENFNAJJ)
				{
					ADJAEJFDMDJ = AMFCENFNAJJ;
				}, endValue, AnimationDuration).OnUpdate(delegate
				{
					LogSpriteRenderer.size = new Vector2(ADJAEJFDMDJ, 1.02f);
					if (ADJAEJFDMDJ <= 0.01f && LogSpriteRenderer.enabled)
					{
						LogSpriteRenderer.enabled = false;
						LogLeft.gameObject.SetActive(false);
						LogRight.gameObject.SetActive(false);
						LogUp.gameObject.SetActive(false);
						LogDown.gameObject.SetActive(false);
					}
				}).SetEase(HPLDBGGBCAM));
				sequence.Insert(0f, LogSpriteRenderer.transform.DOLocalMoveX((float)BOKIPKHFJDC.Count / 2f + 0.525f, AnimationDuration).SetEase(HPLDBGGBCAM));
				switch (GOOCMNFDKGH)
				{
				case IEKBFJBLGFM.Left:
				case IEKBFJBLGFM.Right:
					sequence.Insert(0f, LogRight.transform.DOLocalMoveX((float)BOKIPKHFJDC.Count + 0.271f, AnimationDuration).SetEase(HPLDBGGBCAM));
					break;
				case IEKBFJBLGFM.Down:
					sequence.Insert(0f, LogDown.transform.DOLocalMoveX((float)BOKIPKHFJDC.Count + 0.271f, AnimationDuration).SetEase(HPLDBGGBCAM));
					break;
				default:
					sequence.Insert(0f, LogUp.transform.DOLocalMoveX((float)BOKIPKHFJDC.Count + 0.348f, AnimationDuration).SetEase(HPLDBGGBCAM));
					break;
				}
			}
			sequence.OnComplete(delegate
			{
				JNCLFLGKBKC--;
				HINNFILALIG = false;
				if (JNCLFLGKBKC > 0 && BOKIPKHFJDC.Count > 0)
				{
					HKHCACMHKHK();
				}
				else
				{
					FGPCFJFNOAM = false;
					DOTween.Sequence().InsertCallback((!HKCMJOHHABM) ? 0.4f : 0.25f, delegate
					{
						SawDustParticle.Stop();
					});
				}
			});
		}

		private Cell OABAMMJDIOB(int EHJNMODJEAN)
		{
			LogFakeItem logFakeItem = BOKIPKHFJDC[EHJNMODJEAN];
			Cell currentCell = logFakeItem.ENCFFNKONOO;
			logFakeItem.ENCFFNKONOO = null;
			Object.Destroy(logFakeItem.gameObject);
			BOKIPKHFJDC.RemoveAt(EHJNMODJEAN);
			return currentCell;
		}

		private IEnumerator KBELMALJGLB()
		{
			while (FGPCFJFNOAM)
			{
				float num = 0.5f + 0.3f * (float)(7 - BOKIPKHFJDC.Count);
				LogAnimationContainer.transform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, num) - num / 2f);
				yield return null;
			}
			LogAnimationContainer.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		}

		private void IOKIBNEBJJK(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			BOKIPKHFJDC = new List<LogFakeItem>();
			CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
			Cell cell = IDIOLIHBJBE;
			while (LPMEMDOBIHA(cell, AJLDJAHHGOJ))
			{
				cell = jHDMFHDHIFN.PHOOMEOBJCB(cell, AJLDJAHHGOJ);
				LogFakeItem logFakeItem = cell.LBFCDKPCDPB as LogFakeItem;
				logFakeItem.MasterItem = this;
				BOKIPKHFJDC.Add(logFakeItem);
			}
		}

		private bool LPMEMDOBIHA(Cell LBHDELJBONF, IEKBFJBLGFM AJLDJAHHGOJ)
		{
			Cell cell = ELFBOKDHKGG.JHDMFHDHIFN.PHOOMEOBJCB(LBHDELJBONF, AJLDJAHHGOJ);
			if (cell != null && cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB.GetItemType() == NOALGNJECAD.LogFake)
			{
				LogFakeItem logFakeItem = cell.LBFCDKPCDPB as LogFakeItem;
				IEKBFJBLGFM iEKBFJBLGFM = AJLDJAHHGOJ.JNGHEHKEBMN();
				if (logFakeItem.AKDMMEEHGHB == iEKBFJBLGFM)
				{
					return true;
				}
			}
			return false;
		}

		public void OnLoopEnd()
		{
			CurrentAudioSource.loop = false;
			AudioClip audioClip = BBKCPPOFENL.AudioClips[1].AudioClip;
			if (NMEHPKPJMFN(audioClip))
			{
				CurrentAudioSource.PlayOneShot(audioClip);
			}
		}

		public void OnExplodeStart()
		{
			CurrentAudioSource.loop = false;
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[2]);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 193;
		}

		[CompilerGenerated]
		private void BGPHIIKBIEN()
		{
			CurrentAnimator.SetInteger("AnimationState", 2);
		}

		[CompilerGenerated]
		private void OKOBDPPBDHF()
		{
			CLBLLFKGOIO.AcceptsFallInside();
			CLBLLFKGOIO = null;
		}

		[CompilerGenerated]
		private void KLGECBJEPPP()
		{
			JNCLFLGKBKC--;
			HINNFILALIG = false;
			if (JNCLFLGKBKC > 0 && BOKIPKHFJDC.Count > 0)
			{
				HKHCACMHKHK();
				return;
			}
			FGPCFJFNOAM = false;
			DOTween.Sequence().InsertCallback((!HKCMJOHHABM) ? 0.4f : 0.25f, delegate
			{
				SawDustParticle.Stop();
			});
		}

		[CompilerGenerated]
		private void JMIKJMLPLPD()
		{
			SawDustParticle.Stop();
		}
	}
}
