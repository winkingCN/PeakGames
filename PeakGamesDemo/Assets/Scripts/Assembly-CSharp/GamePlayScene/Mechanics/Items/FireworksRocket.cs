using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class FireworksRocket : MonoBehaviour
	{
		public static float AnimationSpeed = 10f;

		public static float RocketWaitBeforeLaunch = 0.12f;

		public static float RocketFinalScale = 1.15f;

		public SpriteRenderer CurrentSpriteRenderer;

		public SpriteRenderer Shadow;

		public Animator CurrentAnimator;

		public ParticleSystem TrailParticles;

		public Transform Container;

		public Transform RocketTransform;

		public Transform RocketShadowTransform;

		private Item IHBFNFBKNHO;

		private Cell GIKPDAJONLB;

		private Transform NAJIDDBAJKP;

		private Sequence BADHDINHKND;

		private bool OMLNDFNJOHP;

		private Vector3 BFBADJCPCNM;

		private Vector3 LPCIBPDKICH;

		private Vector3 IFCLDKNCGEG;

		private Vector3 ANHIBLPOPBK;

		private Vector3 JMJKKNNJPFC;

		private Vector3 DPOFHAMGNDI;

		private Vector3 AJFHOBKDCHP;

		private float MGINLLGBBHI;

		private float MBDOABMIOJL;

		private float MJGAKPEGKJH;

		private int KKCMNNOCKJP;

		public void Prepare(Vector3 LDMDBPLADGD, int CMAJLIAELDP)
		{
			FallManager.IncreaseStatAnimation();
			base.transform.position = LDMDBPLADGD;
			Shadow.enabled = false;
			LDJLCGKJBKI(CMAJLIAELDP);
		}

		private void LDJLCGKJBKI(int CMAJLIAELDP)
		{
			Vector3 localScale = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 position = base.transform.position;
			float num = 1f;
			switch (CMAJLIAELDP)
			{
			case 0:
				position.y -= 0.1f;
				break;
			case 1:
				localScale = Vector3.one * 0.814f;
				identity.eulerAngles = Vector3.forward * 13.273f;
				position.x -= 0.206f;
				position.y -= 0.126f;
				num = 0.784f;
				break;
			case 2:
				localScale = Vector3.one * 0.814f;
				identity.eulerAngles = Vector3.back * 13.273f;
				position.x += 0.206f;
				position.y -= 0.126f;
				num = 0.784f;
				break;
			}
			RocketTransform.rotation = Quaternion.identity;
			RocketShadowTransform.rotation = Quaternion.identity;
			base.transform.position = position;
			base.transform.localRotation = identity;
			base.transform.localScale = localScale;
			CurrentSpriteRenderer.sortingOrder = 1605 - CMAJLIAELDP;
			CurrentSpriteRenderer.color = new Color(num, num, num);
		}

		public void Launch()
		{
			StartCoroutine(NBEBNFEPEEC());
		}

		private IEnumerator NBEBNFEPEEC()
		{
			CurrentAnimator.Play(Animator.StringToHash("FireworksRocketLaunchAnimation"), -1, 0f);
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Fireworks).AudioClips[1]);
			yield return new WaitForSeconds(RocketWaitBeforeLaunch);
			Shadow.enabled = true;
			Shadow.color = new Color(0f, 0f, 0f, 0f);
			Shadow.DOColor(new Color(0f, 0f, 0f, 0.3529412f), 0.1f).SetDelay(0.12f);
			TrailParticles.Play();
			FireworksController.GABGKBAKHDP.RegisterRocket(this);
			base.transform.DOScale(Vector3.one * RocketFinalScale, 0.1f);
			CurrentSpriteRenderer.DOColor(Color.white, 0.1f);
		}

		public void SetTargetCell(Cell FIICENBDLDC)
		{
			IHBFNFBKNHO = null;
			GIKPDAJONLB = FIICENBDLDC;
			NAJIDDBAJKP = FIICENBDLDC.transform;
			ANHIBLPOPBK = Vector3.zero;
			OMLNDFNJOHP = true;
			ABLFPILNDCP();
		}

		public void SetTargetItem(Item CKCOPGFCKCN)
		{
			IHBFNFBKNHO = CKCOPGFCKCN;
			GIKPDAJONLB = IHBFNFBKNHO.ENCFFNKONOO;
			NAJIDDBAJKP = IHBFNFBKNHO.transform;
			ANHIBLPOPBK = IHBFNFBKNHO.GetCenterPositionOffset(MLENMAIAOHJ.BDAKKAIBMIM(16));
			ABLFPILNDCP();
		}

		public void Recycle()
		{
			FallManager.DecreaseStatAnimation();
			MGINLLGBBHI = 0f;
			MJGAKPEGKJH = 0f;
			IHBFNFBKNHO = null;
			GIKPDAJONLB = null;
			NAJIDDBAJKP = null;
			OMLNDFNJOHP = false;
			ANHIBLPOPBK = Vector3.zero;
			base.transform.position = Vector3.zero;
			base.transform.rotation = Quaternion.identity;
			Container.localPosition = Vector3.zero;
			CurrentSpriteRenderer.enabled = true;
			Shadow.enabled = true;
			base.gameObject.MEJPNNFDEBD();
		}

		private IEnumerator KAFHOOMBLLO()
		{
			CurrentSpriteRenderer.enabled = false;
			Shadow.enabled = false;
			TrailParticles.Stop();
			yield return MCJHHDACJBG.IONDKKIFPHN;
			Recycle();
		}

		public bool UpdateRocket()
		{
			if (IHBFNFBKNHO == null)
			{
				if (!OMLNDFNJOHP)
				{
					if (GIKPDAJONLB == null)
					{
						Recycle();
						return true;
					}
					NAJIDDBAJKP = GIKPDAJONLB.transform;
					ANHIBLPOPBK = Vector3.zero;
					OMLNDFNJOHP = true;
				}
			}
			else if (IHBFNFBKNHO.ENCFFNKONOO != null)
			{
				GIKPDAJONLB = IHBFNFBKNHO.ENCFFNKONOO;
			}
			if (MGINLLGBBHI < 1f)
			{
				MJGAKPEGKJH += Time.deltaTime;
				MGINLLGBBHI = MJGAKPEGKJH / MBDOABMIOJL;
			}
			Vector3 vector = NAJIDDBAJKP.position + ANHIBLPOPBK - LPCIBPDKICH;
			Container.localPosition = vector * MGINLLGBBHI;
			Vector3 vector2 = IFCLDKNCGEG - base.transform.position;
			if ((double)vector2.magnitude > 0.0001)
			{
				float num = 57.29578f * Mathf.Atan2(vector2.y, vector2.x) + 90f;
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = Vector3.forward * num;
				RocketTransform.rotation = identity;
				RocketShadowTransform.rotation = identity;
			}
			IFCLDKNCGEG = base.transform.position;
			float num2 = 1f - Mathf.Abs(MGINLLGBBHI - 0.5f) * 2f;
			RocketShadowTransform.localPosition = new Vector3(0f, (0f - num2) * 0.5f, 0f);
			if (MGINLLGBBHI >= 1f)
			{
				if (IHBFNFBKNHO != null)
				{
					IHBFNFBKNHO.SetExplodeDirection(IEKBFJBLGFM.None);
					IHBFNFBKNHO.HitByFireworks();
					if (GIKPDAJONLB == null && IHBFNFBKNHO.ParentCell != null)
					{
						GIKPDAJONLB = IHBFNFBKNHO.ParentCell;
					}
				}
				if (GIKPDAJONLB != null)
				{
					Vector3 frozenPosition = GIKPDAJONLB.GetFrozenPosition();
					APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(16);
					if (GIKPDAJONLB.EAILOFHFNJO)
					{
						frozenPosition += GIKPDAJONLB.LBFCDKPCDPB.GetCenterPositionOffset(cCPAJBOJDMN);
					}
					GIKPDAJONLB.CurrentGrid.EJBPCMDJFEM(GIKPDAJONLB, cCPAJBOJDMN);
					if (ParticlePool.Instance != null)
					{
						ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Fireworks).Particles[2], frozenPosition);
					}
					AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Fireworks).AudioClips[2]);
				}
				StartCoroutine(KAFHOOMBLLO());
				return true;
			}
			return false;
		}

		private void ABLFPILNDCP()
		{
			MGINLLGBBHI = 0f;
			BFBADJCPCNM = base.transform.position;
			LPCIBPDKICH = NAJIDDBAJKP.position + ANHIBLPOPBK;
			JMJKKNNJPFC = LPCIBPDKICH - BFBADJCPCNM;
			IFCLDKNCGEG = BFBADJCPCNM;
			int num = ((!(LPCIBPDKICH.x > BFBADJCPCNM.x)) ? 1 : (-1));
			int num2 = 2 * num;
			int num3 = 2 * num;
			float num4 = 5f;
			if (Mathf.Abs(JMJKKNNJPFC.x) < 2f)
			{
				num2 = 3 * num;
				num3 = 3 * num;
				num4 = 5f;
			}
			DPOFHAMGNDI = new Vector3(BFBADJCPCNM.x + (float)num2, (!(LPCIBPDKICH.y > BFBADJCPCNM.y)) ? (BFBADJCPCNM.y + num4) : (LPCIBPDKICH.y + num4), 0f);
			AJFHOBKDCHP = new Vector3(LPCIBPDKICH.x - (float)num3, DPOFHAMGNDI.y);
			MKDNOGFMJIJ();
		}

		private void MKDNOGFMJIJ()
		{
			LNEKBHIDOIG lNEKBHIDOIG = AMPCNLBLOIL.MBNNJGMFFAF(base.transform, BFBADJCPCNM, DPOFHAMGNDI, AJFHOBKDCHP, LPCIBPDKICH, 60, AnimationSpeed, Ease.Linear);
			BADHDINHKND = lNEKBHIDOIG.IOBPBFOPFCH;
			MBDOABMIOJL = lNEKBHIDOIG.AEBACBBGHKI;
			BADHDINHKND.OnComplete(delegate
			{
				MGINLLGBBHI = 1f;
			});
		}

		[CompilerGenerated]
		private void NKMDMHNMMFJ()
		{
			MGINLLGBBHI = 1f;
		}
	}
}
