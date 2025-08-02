using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class SodaItem : Item
	{
		public SodaFakeItem BottomRight;

		public SodaFakeItem TopLeft;

		public SodaFakeItem TopRight;

		public Animator CurrentAnimator;

		public SpriteRenderer BackSpriteRenderer;

		public Transform ExplodePosition;

		public SodaBottle[] SodaBottles;

		private Dictionary<LEDBLDKJBAI, SodaBottle> PKOLNILPHBO;

		private CKKKELDIOLD KKCPOOALFAD;

		private int[] DAJLHJICGJN;

		private int ENIKFOJCMIG;

		private bool DJIFKHIOMNO;

		private LEDBLDKJBAI IFOPILLJHCL = LEDBLDKJBAI.None;

		private float OBBFCPIOIBH;

		private int GAEPGFKDBAP = 1000;

		private readonly Dictionary<LEDBLDKJBAI, Vector2> FMPGDKOGHNN = new Dictionary<LEDBLDKJBAI, Vector2>
		{
			{
				LEDBLDKJBAI.Blue,
				new Vector2(0.293f, -0.147f)
			},
			{
				LEDBLDKJBAI.Green,
				new Vector2(0.014f, -0.239f)
			},
			{
				LEDBLDKJBAI.Red,
				new Vector2(-0.583f, -0.057f)
			},
			{
				LEDBLDKJBAI.Yellow,
				new Vector2(-0.293f, -0.161f)
			},
			{
				LEDBLDKJBAI.Purple,
				new Vector2(0.595f, -0.052f)
			}
		};

		private readonly Dictionary<LEDBLDKJBAI, Vector2> KJHPKDKACCI = new Dictionary<LEDBLDKJBAI, Vector2>
		{
			{
				LEDBLDKJBAI.Blue,
				new Vector2(0.573f, -0.102f)
			},
			{
				LEDBLDKJBAI.Green,
				new Vector2(0.232f, -0.236f)
			},
			{
				LEDBLDKJBAI.Red,
				new Vector2(-0.546f, -0.099f)
			},
			{
				LEDBLDKJBAI.Yellow,
				new Vector2(-0.213f, -0.226f)
			}
		};

		public override Cell ENCFFNKONOO
		{
			get
			{
				return base.ENCFFNKONOO;
			}
			set
			{
				base.ENCFFNKONOO = value;
				if (ENCFFNKONOO != null)
				{
					TopLeft.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X, ENCFFNKONOO.Y + 1);
					TopRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y + 1);
					BottomRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y);
				}
				else
				{
					TopLeft.ENCFFNKONOO = null;
					TopRight.ENCFFNKONOO = null;
					BottomRight.ENCFFNKONOO = null;
				}
			}
		}

		public void Start()
		{
			JKPEPNEOJML();
		}

		protected void JKPEPNEOJML()
		{
			DAJLHJICGJN = new int[1] { Animator.StringToHash("Base Layer.SodaItemShakeAnimation1") };
		}

		public void Init(int PKBJIKCAOLB)
		{
			PKOLNILPHBO = new Dictionary<LEDBLDKJBAI, SodaBottle>
			{
				{
					LEDBLDKJBAI.Blue,
					SodaBottles[0]
				},
				{
					LEDBLDKJBAI.Green,
					SodaBottles[1]
				},
				{
					LEDBLDKJBAI.Red,
					SodaBottles[2]
				},
				{
					LEDBLDKJBAI.Yellow,
					SodaBottles[3]
				},
				{
					LEDBLDKJBAI.Purple,
					SodaBottles[4]
				}
			};
			ENIKFOJCMIG = PKBJIKCAOLB;
			Dictionary<LEDBLDKJBAI, Vector2> dictionary = FMPGDKOGHNN;
			if (ENIKFOJCMIG == 4)
			{
				SodaBottles[4].Remove();
				Array.Resize(ref SodaBottles, 4);
				PKOLNILPHBO.Remove(LEDBLDKJBAI.Purple);
				dictionary = KJHPKDKACCI;
			}
			foreach (KeyValuePair<LEDBLDKJBAI, Vector2> item in dictionary)
			{
				PKOLNILPHBO[item.Key].transform.localPosition = item.Value;
			}
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			if (!PKOLNILPHBO.ContainsKey(KOINNGEBMJI))
			{
				return false;
			}
			IFOPILLJHCL = KOINNGEBMJI;
			return true;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return ExplodeBy(this, CCPAJBOJDMN);
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DJIFKHIOMNO)
			{
				return;
			}
			DJIFKHIOMNO = true;
			Dictionary<LEDBLDKJBAI, SodaBottle> dictionary = new Dictionary<LEDBLDKJBAI, SodaBottle>();
			foreach (KeyValuePair<LEDBLDKJBAI, SodaBottle> item in PKOLNILPHBO)
			{
				dictionary.Add(item.Key, item.Value);
			}
			foreach (KeyValuePair<LEDBLDKJBAI, SodaBottle> item2 in dictionary)
			{
				ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Soda, false);
				KKHHCDOPGND(item2.Key, true);
				ScoreManager.RaiseScore(GAEPGFKDBAP);
			}
			PKOLNILPHBO = null;
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		public bool ExplodeBy(Item EJCNAJOHBFI, APBDPLNCDIJ CCPAJBOJDMN, bool PNJGCDKOLOF = false)
		{
			if (DJIFKHIOMNO)
			{
				return false;
			}
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (!CCPAJBOJDMN.AFAAILGMEBN)
			{
				IFOPILLJHCL = PKOLNILPHBO.ElementAt(BFGGHJGIHLJ.FDFDDKBDPEG(0, PKOLNILPHBO.Count, 12)).Key;
			}
			KKHHCDOPGND(IFOPILLJHCL);
			ScoreManager.RaiseScore(GAEPGFKDBAP);
			if (PKOLNILPHBO.Count != 0)
			{
				ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Soda, false);
				return false;
			}
			DJIFKHIOMNO = true;
			return true;
		}

		private void KKHHCDOPGND(LEDBLDKJBAI GOJPOGFIGBD, bool AEGOANBPCGB = false)
		{
			if (DJIFKHIOMNO && !AEGOANBPCGB)
			{
				return;
			}
			foreach (KeyValuePair<LEDBLDKJBAI, SodaBottle> item in PKOLNILPHBO)
			{
				if (!(item.Value == null) && item.Key != GOJPOGFIGBD)
				{
					item.Value.PlayShakeAnimation(item.Key);
				}
			}
			Vector3 position = base.transform.position;
			if (PKOLNILPHBO.ContainsKey(GOJPOGFIGBD))
			{
				position = PKOLNILPHBO[GOJPOGFIGBD].transform.position;
				PKOLNILPHBO[GOJPOGFIGBD].Remove();
				PKOLNILPHBO.Remove(GOJPOGFIGBD);
			}
			int stateNameHash = DAJLHJICGJN[UnityEngine.Random.Range(0, DAJLHJICGJN.Length)];
			CurrentAnimator.Play(stateNameHash, 0, 0f);
			ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			if (resources != null)
			{
				AudioManager.PlayAudioProps(resources.AudioClips[0]);
			}
			if (ParticlePool.Instance != null && resources != null)
			{
				SodaBottleParticlePlayer component = ParticlePool.Instance.PlayParticle(resources.Particles[0], position).GetComponent<SodaBottleParticlePlayer>();
				component.SetColor(GOJPOGFIGBD);
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Soda;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			BackSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			BackSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
			SodaBottles[0].ChangeSorting(KKCPOOALFAD, 20);
			SodaBottles[1].ChangeSorting(KKCPOOALFAD, 30);
			SodaBottles[2].ChangeSorting(KKCPOOALFAD, 10);
			SodaBottles[3].ChangeSorting(KKCPOOALFAD, 20);
			if (ENIKFOJCMIG == 5)
			{
				SodaBottles[4].ChangeSorting(KKCPOOALFAD, 10);
			}
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override bool CanFall()
		{
			return false;
		}

		public override int GetScore()
		{
			return 0;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], ExplodePosition.position);
			}
		}

		public override void RemoveSelf()
		{
			base.RemoveSelf();
			BottomRight.RemoveSelf();
			TopLeft.RemoveSelf();
			TopRight.RemoveSelf();
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return true;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return PKOLNILPHBO.Count;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			if (ENIKFOJCMIG == 4)
			{
				PNINCDLIDLL.EEFMIHDPJPG = 136;
			}
			else
			{
				PNINCDLIDLL.EEFMIHDPJPG = 138;
			}
			byte b = 0;
			foreach (KeyValuePair<LEDBLDKJBAI, SodaBottle> item in PKOLNILPHBO)
			{
				b |= (byte)(1 << (int)item.Key);
			}
			PNINCDLIDLL.DKJDLMNKFGM(b);
		}

		protected Dictionary<LEDBLDKJBAI, SodaBottle> KBOIIEODFLE()
		{
			return PKOLNILPHBO;
		}
	}
}
