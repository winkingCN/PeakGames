using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ParticlePool : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class OFOKBGEJCOJ
		{
			internal ParticlePlayer JHMKEILKIDJ;

			internal Item PJKMIAMDIID;

			internal ParticlePlayer HPHBDNBJPHB;

			internal void AGFNGEFDHLA()
			{
				if (!(JHMKEILKIDJ == null) && !(JHMKEILKIDJ.transform.parent != PJKMIAMDIID.transform))
				{
					JHMKEILKIDJ.transform.SetParent(null);
					HPHBDNBJPHB.HardStop();
				}
			}
		}

		[CompilerGenerated]
		private sealed class FAFLBJKOKFJ
		{
			internal GameObject JHMKEILKIDJ;

			internal Item PJKMIAMDIID;

			internal ParticlePlayer HPHBDNBJPHB;

			internal void AGFNGEFDHLA()
			{
				if (!(JHMKEILKIDJ == null) && !(JHMKEILKIDJ.transform.parent != PJKMIAMDIID.transform))
				{
					JHMKEILKIDJ.transform.SetParent(null);
					HPHBDNBJPHB.HardStop();
				}
			}
		}

		public static ParticlePool Instance;

		public GameObject AnvilHitParticle;

		public GameObject BombExplodeParticle;

		public GameObject ComboCreationParticle;

		public GameObject ComboHintParticle;

		public GameObject DefaultExplosion;

		public GameObject DiscoExplodeParticle;

		public GameObject DiscoRayParticle;

		public GameObject DiscoRayReachedParticle;

		public GameObject DoubleBombExplodeParticle;

		public GameObject RemainingMoveRayParticle;

		public GameObject RemainingMoveReplaceParticle;

		public GameObject RocketAndBombParticle;

		public GameObject SolidColorExplosion;

		public GameObject SpecialItemCreationParticle;

		public GameObject SpecialItemPlaceParticle;

		[HideInInspector]
		public uint RandomSeed;

		public void Awake()
		{
			Instance = this;
			RandomSeed = (uint)Random.Range(0, 2000000000);
			AnvilHitParticle.FLFDKMOOIFL(1);
			BombExplodeParticle.FLFDKMOOIFL(10);
			ComboCreationParticle.FLFDKMOOIFL(2);
			ComboHintParticle.FLFDKMOOIFL(4);
			DefaultExplosion.FLFDKMOOIFL(10);
			DiscoExplodeParticle.FLFDKMOOIFL(2);
			DiscoRayParticle.FLFDKMOOIFL(10);
			DiscoRayReachedParticle.FLFDKMOOIFL(2);
			DoubleBombExplodeParticle.FLFDKMOOIFL(2);
			RemainingMoveRayParticle.FLFDKMOOIFL(10);
			RemainingMoveReplaceParticle.FLFDKMOOIFL(10);
			RocketAndBombParticle.FLFDKMOOIFL(1);
			SolidColorExplosion.FLFDKMOOIFL(50);
			SpecialItemCreationParticle.FLFDKMOOIFL(5);
		}

		public void CreatePool(GameObject EJCNAJOHBFI, int ENMLICFLHAO)
		{
			EJCNAJOHBFI.FLFDKMOOIFL(ENMLICFLHAO);
		}

		public ParticlePlayer PlayParticle(GameObject AGIOLFBGANM, Vector3 FADJPCHMMBH, bool JGGOMPALOLM = true)
		{
			ParticlePlayer component = AGIOLFBGANM.JOBDHIPIMAG(FADJPCHMMBH).GetComponent<ParticlePlayer>();
			component.CreatedFromPool = true;
			if (JGGOMPALOLM)
			{
				component.Play();
			}
			return component;
		}

		public ParticlePlayer PlayParticle(ParticlePlayer HFGBGLIHEOL, Vector3 FADJPCHMMBH, bool JGGOMPALOLM = true)
		{
			ParticlePlayer particlePlayer = HFGBGLIHEOL.JOBDHIPIMAG(FADJPCHMMBH);
			particlePlayer.CreatedFromPool = true;
			if (JGGOMPALOLM)
			{
				particlePlayer.Play();
			}
			return particlePlayer;
		}

		public ParticlePlayer PlayParticle(ParticlePlayer HFGBGLIHEOL, Item PJKMIAMDIID, bool JGGOMPALOLM = true)
		{
			ParticlePlayer JHMKEILKIDJ = HFGBGLIHEOL.JOBDHIPIMAG();
			JHMKEILKIDJ.transform.SetParent(PJKMIAMDIID.transform);
			JHMKEILKIDJ.transform.localPosition = Vector3.zero;
			ParticlePlayer HPHBDNBJPHB = JHMKEILKIDJ.GetComponent<ParticlePlayer>();
			if (JGGOMPALOLM)
			{
				HPHBDNBJPHB.Play();
			}
			HPHBDNBJPHB.CreatedFromPool = true;
			PJKMIAMDIID.DFKAIGLKIIH += delegate
			{
				if (!(JHMKEILKIDJ == null) && !(JHMKEILKIDJ.transform.parent != PJKMIAMDIID.transform))
				{
					JHMKEILKIDJ.transform.SetParent(null);
					HPHBDNBJPHB.HardStop();
				}
			};
			return HPHBDNBJPHB;
		}

		public ParticlePlayer PlayParticle(GameObject AGIOLFBGANM, Item PJKMIAMDIID, bool JGGOMPALOLM = true)
		{
			GameObject JHMKEILKIDJ = AGIOLFBGANM.JOBDHIPIMAG();
			JHMKEILKIDJ.transform.SetParent(PJKMIAMDIID.transform);
			JHMKEILKIDJ.transform.localPosition = Vector3.zero;
			ParticlePlayer HPHBDNBJPHB = JHMKEILKIDJ.GetComponent<ParticlePlayer>();
			if (JGGOMPALOLM)
			{
				HPHBDNBJPHB.Play();
			}
			HPHBDNBJPHB.CreatedFromPool = true;
			PJKMIAMDIID.DFKAIGLKIIH += delegate
			{
				if (!(JHMKEILKIDJ == null) && !(JHMKEILKIDJ.transform.parent != PJKMIAMDIID.transform))
				{
					JHMKEILKIDJ.transform.SetParent(null);
					HPHBDNBJPHB.HardStop();
				}
			};
			return HPHBDNBJPHB;
		}

		public void OnDestroy()
		{
			ResetSelf();
		}

		public uint GetRandomSeed()
		{
			return ++RandomSeed;
		}

		public static void ResetSelf()
		{
			Instance = null;
		}
	}
}
