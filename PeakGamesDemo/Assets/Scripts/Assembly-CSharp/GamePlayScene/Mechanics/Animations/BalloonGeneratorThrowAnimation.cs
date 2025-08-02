using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Animations
{
	public class BalloonGeneratorThrowAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class BKAMDHDEFGP
		{
			internal bool MNFOIEDONKE;

			internal float COLFDPMDMDD;

			internal Vector3 GEJPKGFOCGK;

			internal Vector3 IHIIPAFDOPC;

			internal ItemResources JEDAGPJEOAM;

			internal BalloonGeneratorThrowAnimation PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.ShadowSprite.enabled = true;
			}

			internal void KDACLOKGNAM()
			{
				ParticleSystem.EmissionModule emission = PDAPIGLEPGC.TrailParticle.emission;
				emission.enabled = true;
				PDAPIGLEPGC.TrailParticle.Play();
				PDAPIGLEPGC.TailSpriteRenderer.enabled = true;
			}

			internal void DBLIJBPNCAN()
			{
				PDAPIGLEPGC.Container.transform.DOScale(1f, 0.4f);
				Vector3 position = PDAPIGLEPGC.Container.transform.position;
				PDAPIGLEPGC.Container.transform.DOMove(new Vector3(position.x + PDAPIGLEPGC.POFBDCGIBIH, position.y + 1.5f, 0f), 0.25f).SetEase(Ease.Linear);
				PDAPIGLEPGC.BalloonTransform.DOScaleX(0.9f, 0.1f).SetDelay(0f).OnComplete(delegate
				{
					PDAPIGLEPGC.BalloonTransform.DOScaleX(1.1f, 0.1f).SetDelay(0.2f);
					PDAPIGLEPGC.BalloonTransform.DOScaleY(0.9f, 0.1f).SetDelay(0.2f);
				});
				PDAPIGLEPGC.BalloonTransform.DOScaleX(1f, 0.2f).SetDelay(0.5f);
				PDAPIGLEPGC.BalloonTransform.DOScaleY(1f, 0.2f).SetDelay(0.5f);
			}

			internal void EFLLCMEPAEM()
			{
				if (!MNFOIEDONKE)
				{
					MNFOIEDONKE = true;
				}
				if (!(Time.realtimeSinceStartup < COLFDPMDMDD))
				{
					IHIIPAFDOPC = GEJPKGFOCGK;
					GEJPKGFOCGK = PDAPIGLEPGC.Container.transform.position;
					Vector3 vector = GEJPKGFOCGK - IHIIPAFDOPC;
					float num = 57.29578f * Mathf.Atan2(vector.y, vector.x);
					if (!float.IsNaN(num))
					{
						Quaternion quaternion = default(Quaternion);
						quaternion.eulerAngles = new Vector3(0f, 0f, num);
						Quaternion b = quaternion;
						PDAPIGLEPGC.Container.transform.rotation = Quaternion.Slerp(PDAPIGLEPGC.Container.transform.rotation, b, 0.8f);
						Vector3 position = PDAPIGLEPGC.BalloonTransform.position;
						position.y -= 0.6f;
						PDAPIGLEPGC.ShadowSprite.transform.position = position;
					}
				}
			}

			internal void NNINHCPIBHO()
			{
				if (JEDAGPJEOAM != null)
				{
					AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
				}
				PDAPIGLEPGC.BADHDINHKND = null;
				ParticleSystem.EmissionModule emission = PDAPIGLEPGC.TrailParticle.emission;
				emission.enabled = false;
				PDAPIGLEPGC.ShadowSprite.enabled = false;
				PDAPIGLEPGC.CurrentSpriteRenderer.enabled = false;
				PDAPIGLEPGC.TailSpriteRenderer.enabled = false;
				if (PDAPIGLEPGC.GJCEOOLAJLF != null)
				{
					PDAPIGLEPGC.GJCEOOLAJLF(PDAPIGLEPGC.HEIFFGLOPKI);
				}
				if (PDAPIGLEPGC.gameObject.activeSelf)
				{
					PDAPIGLEPGC.StartCoroutine(PDAPIGLEPGC.APEKIDMEKOI());
				}
			}

			internal void HFBABENGMDD()
			{
				PDAPIGLEPGC.BalloonTransform.DOScaleX(1.1f, 0.1f).SetDelay(0.2f);
				PDAPIGLEPGC.BalloonTransform.DOScaleY(0.9f, 0.1f).SetDelay(0.2f);
			}
		}

		public Transform BalloonParentTransform;

		public Transform BalloonTransform;

		public Transform Container;

		public SpriteRenderer CurrentSpriteRenderer;

		public ParticleSystem TrailParticle;

		public SpriteRenderer ShadowSprite;

		public SpriteRenderer TailSpriteRenderer;

		public static float CorrectionFactor = 0.4f;

		private float POFBDCGIBIH = 1.5f;

		private const float GOIFGNODPLE = 0.07f;

		private const float MLEJANLHOKD = 0.4f;

		private const float LENKCIOACGG = 0.25f;

		private const float BGBMMDJIELP = 0.15f;

		private const float JAMFNHJJDKE = 0.08f;

		private const float AFAMGAHFBLO = 1.5f;

		private const float IFFKIDEKLEM = 2f;

		private const float BPOBIOAEDAH = 1f;

		private const float MLIIICHOOHN = 0f;

		private const float AHMDLAOFGBC = 0.9f;

		private const float OIDPHLDGIKD = 0.1f;

		private const float CGICABFNFLF = 0.1f;

		private const float DJOKJEGICCB = 1.1f;

		private const float MHMCJNPCAOD = 0.9f;

		private const float IOEJILNKAGP = 0.2f;

		private const float BBIOIPFKCDA = 0.5f;

		private const float KHCODJHAFDP = 0.2f;

		private const float LKABBDOJLEH = 0.2f;

		private const float JPBENKKNIPD = 0.8f;

		private const int IJLJBCEDBCA = 50;

		private Cell HEIFFGLOPKI;

		private int GOOCMNFDKGH;

		private Sequence BADHDINHKND;

		private Action<Cell> GJCEOOLAJLF;

		public void Awake()
		{
			Container.gameObject.SetActive(false);
		}

		private void Reset()
		{
			Container.gameObject.SetActive(true);
			Container.transform.DOKill();
			Container.transform.localScale = Vector3.zero;
			Container.transform.rotation = new Quaternion
			{
				eulerAngles = new Vector3(0f, 0f, 0f)
			};
			BalloonParentTransform.DOKill();
			BalloonParentTransform.rotation = new Quaternion
			{
				eulerAngles = new Vector3(0f, 0f, 0f)
			};
			BalloonTransform.DOKill();
			BalloonTransform.localScale = Vector3.one;
			ShadowSprite.enabled = false;
			CurrentSpriteRenderer.enabled = true;
			TailSpriteRenderer.enabled = false;
		}

		public void Prepare(Cell LLAEDBFNCCP, Cell BMIOECELGCA, int AJLDJAHHGOJ, Action<Cell> LBHGIIEDMOB)
		{
			try
			{
				Reset();
				HEIFFGLOPKI = BMIOECELGCA;
				GOOCMNFDKGH = AJLDJAHHGOJ;
				GJCEOOLAJLF = LBHGIIEDMOB;
				ItemResources JEDAGPJEOAM = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.BalloonGenerator);
				Vector3 frozenPosition = LLAEDBFNCCP.GetFrozenPosition();
				Vector3 frozenPosition2 = BMIOECELGCA.GetFrozenPosition();
				frozenPosition.y += 0.08f;
				if (GOOCMNFDKGH == 0)
				{
					frozenPosition.x += 0.15f;
					POFBDCGIBIH = ((!(POFBDCGIBIH < 0f)) ? POFBDCGIBIH : (0f - POFBDCGIBIH));
				}
				else
				{
					frozenPosition.x -= 0.15f;
					POFBDCGIBIH = ((!(POFBDCGIBIH > 0f)) ? POFBDCGIBIH : (0f - POFBDCGIBIH));
				}
				Container.transform.position = frozenPosition;
				Vector3 vector = new Vector3(frozenPosition.x + POFBDCGIBIH, frozenPosition.y + 1.5f, 0f);
				float num = new Vector2(POFBDCGIBIH, 1.5f).magnitude / 0.25f;
				if (BADHDINHKND != null)
				{
					BADHDINHKND.Kill(true);
				}
				BADHDINHKND = DOTween.Sequence();
				Vector3 vector2 = (frozenPosition2 - vector) * 0.3f;
				float num2 = vector2.magnitude * 2f;
				Vector3 vector3 = new Vector3(0f - vector2.y, vector2.x);
				Vector3 eLEIAMCGPIM = new Vector3(vector.x + vector2.x * 1f, vector.y + vector2.y * 1f);
				eLEIAMCGPIM += vector3.normalized * num2 * ((!(vector2.y > 0f)) ? 1 : (-1));
				Vector3[] array = new Vector3[50];
				float[] array2 = new float[50];
				for (int i = 1; i <= 50; i++)
				{
					float lLIEHCKNJEM = (float)i / 50f;
					float lLIEHCKNJEM2 = (float)(i - 1) / 50f;
					Vector3 vector4 = AMPCNLBLOIL.OICPCAPKFPI(vector, eLEIAMCGPIM, frozenPosition2, lLIEHCKNJEM);
					Vector3 vector5 = AMPCNLBLOIL.OICPCAPKFPI(vector, eLEIAMCGPIM, frozenPosition2, lLIEHCKNJEM2);
					float magnitude = (vector4 - vector5).magnitude;
					array2[i - 1] = magnitude / num;
					array[i - 1] = vector4;
				}
				float num3 = 0f;
				for (int j = 0; j < 50; j++)
				{
					float num4 = array2[j];
					BADHDINHKND.Insert(0.32f + num3, Container.transform.DOMove(array[j], num4).SetEase(Ease.Linear));
					num3 += num4;
				}
				BADHDINHKND.InsertCallback(0.2f, delegate
				{
					ShadowSprite.enabled = true;
				});
				BADHDINHKND.InsertCallback(0.2f, delegate
				{
					ParticleSystem.EmissionModule emission2 = TrailParticle.emission;
					emission2.enabled = true;
					TrailParticle.Play();
					TailSpriteRenderer.enabled = true;
				});
				BADHDINHKND.InsertCallback(0.07f, delegate
				{
					Container.transform.DOScale(1f, 0.4f);
					Vector3 position2 = Container.transform.position;
					Container.transform.DOMove(new Vector3(position2.x + POFBDCGIBIH, position2.y + 1.5f, 0f), 0.25f).SetEase(Ease.Linear);
					BalloonTransform.DOScaleX(0.9f, 0.1f).SetDelay(0f).OnComplete(delegate
					{
						BalloonTransform.DOScaleX(1.1f, 0.1f).SetDelay(0.2f);
						BalloonTransform.DOScaleY(0.9f, 0.1f).SetDelay(0.2f);
					});
					BalloonTransform.DOScaleX(1f, 0.2f).SetDelay(0.5f);
					BalloonTransform.DOScaleY(1f, 0.2f).SetDelay(0.5f);
				});
				BalloonParentTransform.transform.localScale = Vector3.one;
				Vector3 GEJPKGFOCGK = Container.transform.position;
				bool MNFOIEDONKE = false;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float COLFDPMDMDD = realtimeSinceStartup + 0.25f + 0.07f - 0.3f;
				Vector3 IHIIPAFDOPC;
				BADHDINHKND.OnUpdate(delegate
				{
					if (!MNFOIEDONKE)
					{
						MNFOIEDONKE = true;
					}
					if (!(Time.realtimeSinceStartup < COLFDPMDMDD))
					{
						IHIIPAFDOPC = GEJPKGFOCGK;
						GEJPKGFOCGK = Container.transform.position;
						Vector3 vector6 = GEJPKGFOCGK - IHIIPAFDOPC;
						float num5 = 57.29578f * Mathf.Atan2(vector6.y, vector6.x);
						if (!float.IsNaN(num5))
						{
							Quaternion quaternion = default(Quaternion);
							quaternion.eulerAngles = new Vector3(0f, 0f, num5);
							Quaternion b = quaternion;
							Container.transform.rotation = Quaternion.Slerp(Container.transform.rotation, b, 0.8f);
							Vector3 position = BalloonTransform.position;
							position.y -= 0.6f;
							ShadowSprite.transform.position = position;
						}
					}
				});
				BADHDINHKND.OnComplete(delegate
				{
					if (JEDAGPJEOAM != null)
					{
						AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
					}
					BADHDINHKND = null;
					ParticleSystem.EmissionModule emission = TrailParticle.emission;
					emission.enabled = false;
					ShadowSprite.enabled = false;
					CurrentSpriteRenderer.enabled = false;
					TailSpriteRenderer.enabled = false;
					if (GJCEOOLAJLF != null)
					{
						GJCEOOLAJLF(HEIFFGLOPKI);
					}
					if (base.gameObject.activeSelf)
					{
						StartCoroutine(APEKIDMEKOI());
					}
				});
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.GeneratorItem, "ERROR PLAYING BALLOON THROW ANIMATION: Message:{0} Stack:{1}", ex.Message, ex.StackTrace);
				NHNBFBDHKGN.JFPLDMEBIJH("Balloon Item Throw Animation", ex.Message, ex.StackTrace);
			}
		}

		private IEnumerator APEKIDMEKOI()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			base.gameObject.MEJPNNFDEBD();
		}
	}
}
