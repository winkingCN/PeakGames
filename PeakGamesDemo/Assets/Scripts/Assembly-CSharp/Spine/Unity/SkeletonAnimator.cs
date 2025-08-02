using System;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity
{
	[RequireComponent(typeof(Animator))]
	public class SkeletonAnimator : SkeletonRenderer, OAGCBGJOPGD
	{
		[Serializable]
		public class MecanimTranslator
		{
			public enum IOMAPKABLNM
			{
				AlwaysMix = 0,
				MixNext = 1,
				SpineStyle = 2
			}

			private class CFFDABIGPND : IEqualityComparer<AnimationClip>
			{
				internal static readonly IEqualityComparer<AnimationClip> GABGKBAKHDP = new CFFDABIGPND();

				public bool Equals(AnimationClip AMFCENFNAJJ, AnimationClip CNLILOEEBOJ)
				{
					return AMFCENFNAJJ.GetInstanceID() == CNLILOEEBOJ.GetInstanceID();
				}

				public int GetHashCode(AnimationClip AACCPLMFDIE)
				{
					return AACCPLMFDIE.GetInstanceID();
				}
			}

			private class FPCFKEFFLOO : IEqualityComparer<int>
			{
				internal static readonly IEqualityComparer<int> GABGKBAKHDP = new FPCFKEFFLOO();

				public bool Equals(int AMFCENFNAJJ, int CNLILOEEBOJ)
				{
					return AMFCENFNAJJ == CNLILOEEBOJ;
				}

				public int GetHashCode(int AACCPLMFDIE)
				{
					return AACCPLMFDIE;
				}
			}

			public bool autoReset = true;

			public IOMAPKABLNM[] layerMixModes = new IOMAPKABLNM[0];

			private readonly Dictionary<int, GNGKKPOGGGM> animationTable = new Dictionary<int, GNGKKPOGGGM>(FPCFKEFFLOO.GABGKBAKHDP);

			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable = new Dictionary<AnimationClip, int>(CFFDABIGPND.GABGKBAKHDP);

			private readonly List<GNGKKPOGGGM> previousAnimations = new List<GNGKKPOGGGM>();

			private readonly List<AnimatorClipInfo> clipInfoCache = new List<AnimatorClipInfo>();

			private readonly List<AnimatorClipInfo> nextClipInfoCache = new List<AnimatorClipInfo>();

			private Animator animator;

			public Animator Animator
			{
				get
				{
					return animator;
				}
			}

			public void JPLFFCHJICB(Animator HHFJHJKFPNG, SkeletonDataAsset KAFMHICMBHN)
			{
				animator = HHFJHJKFPNG;
				animationTable.Clear();
				clipNameHashCodeTable.Clear();
				KGMHJGFNPFC kGMHJGFNPFC = KAFMHICMBHN.CPILINNBJLL(true);
				using (ExposedList<GNGKKPOGGGM>.Enumerator enumerator = kGMHJGFNPFC.FBHKFANHKGM.FIFMNBJLBFK())
				{
					while (enumerator.MoveNext())
					{
						GNGKKPOGGGM current = enumerator.Current;
						animationTable.Add(current.PNGPLGHKFDI.GetHashCode(), current);
					}
				}
			}

			public void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD)
			{
				if (layerMixModes.Length < animator.layerCount)
				{
					Array.Resize(ref layerMixModes, animator.layerCount);
				}
				if (autoReset)
				{
					List<GNGKKPOGGGM> list = previousAnimations;
					int i = 0;
					for (int count = list.Count; i < count; i++)
					{
						list[i].ILEACEGENOB(GDNININLMFD);
					}
					list.Clear();
					int j = 0;
					for (int layerCount = animator.layerCount; j < layerCount; j++)
					{
						float num = ((j != 0) ? animator.GetLayerWeight(j) : 1f);
						if (num <= 0f)
						{
							continue;
						}
						bool flag = animator.GetNextAnimatorStateInfo(j).fullPathHash != 0;
						int FIDPIDMPMNG;
						int CKFLAAJELIF;
						IList<AnimatorClipInfo> GEFLJOMNJAH;
						IList<AnimatorClipInfo> DBGBCODGANN;
						LHCKDNNJBBE(j, out FIDPIDMPMNG, out CKFLAAJELIF, out GEFLJOMNJAH, out DBGBCODGANN);
						for (int k = 0; k < FIDPIDMPMNG; k++)
						{
							AnimatorClipInfo animatorClipInfo = GEFLJOMNJAH[k];
							float num2 = animatorClipInfo.weight * num;
							if (num2 != 0f)
							{
								list.Add(animationTable[JBCOADAEJAO(animatorClipInfo.clip)]);
							}
						}
						if (!flag)
						{
							continue;
						}
						for (int l = 0; l < CKFLAAJELIF; l++)
						{
							AnimatorClipInfo animatorClipInfo2 = DBGBCODGANN[l];
							float num3 = animatorClipInfo2.weight * num;
							if (num3 != 0f)
							{
								list.Add(animationTable[JBCOADAEJAO(animatorClipInfo2.clip)]);
							}
						}
					}
				}
				int m = 0;
				for (int layerCount2 = animator.layerCount; m < layerCount2; m++)
				{
					float num4 = ((m != 0) ? animator.GetLayerWeight(m) : 1f);
					AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(m);
					AnimatorStateInfo nextAnimatorStateInfo = animator.GetNextAnimatorStateInfo(m);
					bool flag2 = nextAnimatorStateInfo.fullPathHash != 0;
					int FIDPIDMPMNG2;
					int CKFLAAJELIF2;
					IList<AnimatorClipInfo> GEFLJOMNJAH2;
					IList<AnimatorClipInfo> DBGBCODGANN2;
					LHCKDNNJBBE(m, out FIDPIDMPMNG2, out CKFLAAJELIF2, out GEFLJOMNJAH2, out DBGBCODGANN2);
					IOMAPKABLNM iOMAPKABLNM = layerMixModes[m];
					if (iOMAPKABLNM == IOMAPKABLNM.AlwaysMix)
					{
						for (int n = 0; n < FIDPIDMPMNG2; n++)
						{
							AnimatorClipInfo animatorClipInfo3 = GEFLJOMNJAH2[n];
							float num5 = animatorClipInfo3.weight * num4;
							if (num5 != 0f)
							{
								animationTable[JBCOADAEJAO(animatorClipInfo3.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(currentAnimatorStateInfo.normalizedTime, animatorClipInfo3.clip.length, currentAnimatorStateInfo.loop, currentAnimatorStateInfo.speed < 0f), currentAnimatorStateInfo.loop, null, num5, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
							}
						}
						if (!flag2)
						{
							continue;
						}
						for (int num6 = 0; num6 < CKFLAAJELIF2; num6++)
						{
							AnimatorClipInfo animatorClipInfo4 = DBGBCODGANN2[num6];
							float num7 = animatorClipInfo4.weight * num4;
							if (num7 != 0f)
							{
								animationTable[JBCOADAEJAO(animatorClipInfo4.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(nextAnimatorStateInfo.normalizedTime, animatorClipInfo4.clip.length, nextAnimatorStateInfo.speed < 0f), nextAnimatorStateInfo.loop, null, num7, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
							}
						}
						continue;
					}
					int num8;
					for (num8 = 0; num8 < FIDPIDMPMNG2; num8++)
					{
						AnimatorClipInfo animatorClipInfo5 = GEFLJOMNJAH2[num8];
						float num9 = animatorClipInfo5.weight * num4;
						if (num9 != 0f)
						{
							animationTable[JBCOADAEJAO(animatorClipInfo5.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(currentAnimatorStateInfo.normalizedTime, animatorClipInfo5.clip.length, currentAnimatorStateInfo.loop, currentAnimatorStateInfo.speed < 0f), currentAnimatorStateInfo.loop, null, 1f, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
							break;
						}
					}
					for (; num8 < FIDPIDMPMNG2; num8++)
					{
						AnimatorClipInfo animatorClipInfo6 = GEFLJOMNJAH2[num8];
						float num10 = animatorClipInfo6.weight * num4;
						if (num10 != 0f)
						{
							animationTable[JBCOADAEJAO(animatorClipInfo6.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(currentAnimatorStateInfo.normalizedTime, animatorClipInfo6.clip.length, currentAnimatorStateInfo.loop, currentAnimatorStateInfo.speed < 0f), currentAnimatorStateInfo.loop, null, num10, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
						}
					}
					num8 = 0;
					if (!flag2)
					{
						continue;
					}
					if (iOMAPKABLNM == IOMAPKABLNM.SpineStyle)
					{
						for (; num8 < CKFLAAJELIF2; num8++)
						{
							AnimatorClipInfo animatorClipInfo7 = DBGBCODGANN2[num8];
							float num11 = animatorClipInfo7.weight * num4;
							if (num11 != 0f)
							{
								animationTable[JBCOADAEJAO(animatorClipInfo7.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(nextAnimatorStateInfo.normalizedTime, animatorClipInfo7.clip.length, nextAnimatorStateInfo.speed < 0f), nextAnimatorStateInfo.loop, null, 1f, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
								break;
							}
						}
					}
					for (; num8 < CKFLAAJELIF2; num8++)
					{
						AnimatorClipInfo animatorClipInfo8 = DBGBCODGANN2[num8];
						float num12 = animatorClipInfo8.weight * num4;
						if (num12 != 0f)
						{
							animationTable[JBCOADAEJAO(animatorClipInfo8.clip)].FCHLOGCODOA(GDNININLMFD, 0f, LLKPMAMIAEM(nextAnimatorStateInfo.normalizedTime, animatorClipInfo8.clip.length, nextAnimatorStateInfo.speed < 0f), nextAnimatorStateInfo.loop, null, num12, BFCFMFBHBCH.Current, ODPDBCNBOAK.In);
						}
					}
				}
			}

			private static float LLKPMAMIAEM(float EIMKCKFFEAA, float FKHJPDKOOLK, bool IKGIEEMCFDK, bool IPPPPFJPOPF)
			{
				if (IPPPPFJPOPF)
				{
					EIMKCKFFEAA = 1f - EIMKCKFFEAA + (float)(int)EIMKCKFFEAA + (float)(int)EIMKCKFFEAA;
				}
				float num = EIMKCKFFEAA * FKHJPDKOOLK;
				if (IKGIEEMCFDK)
				{
					return num;
				}
				return (!(FKHJPDKOOLK - num < 1f / 30f)) ? num : FKHJPDKOOLK;
			}

			private static float LLKPMAMIAEM(float EIMKCKFFEAA, float FKHJPDKOOLK, bool IPPPPFJPOPF)
			{
				if (IPPPPFJPOPF)
				{
					EIMKCKFFEAA = 1f - EIMKCKFFEAA + (float)(int)EIMKCKFFEAA + (float)(int)EIMKCKFFEAA;
				}
				return EIMKCKFFEAA * FKHJPDKOOLK;
			}

			private void LHCKDNNJBBE(int JNMDJGFMEOE, out int FIDPIDMPMNG, out int CKFLAAJELIF, out IList<AnimatorClipInfo> GEFLJOMNJAH, out IList<AnimatorClipInfo> DBGBCODGANN)
			{
				FIDPIDMPMNG = animator.GetCurrentAnimatorClipInfoCount(JNMDJGFMEOE);
				CKFLAAJELIF = animator.GetNextAnimatorClipInfoCount(JNMDJGFMEOE);
				if (clipInfoCache.Capacity < FIDPIDMPMNG)
				{
					clipInfoCache.Capacity = FIDPIDMPMNG;
				}
				if (nextClipInfoCache.Capacity < CKFLAAJELIF)
				{
					nextClipInfoCache.Capacity = CKFLAAJELIF;
				}
				animator.GetCurrentAnimatorClipInfo(JNMDJGFMEOE, clipInfoCache);
				animator.GetNextAnimatorClipInfo(JNMDJGFMEOE, nextClipInfoCache);
				GEFLJOMNJAH = clipInfoCache;
				DBGBCODGANN = nextClipInfoCache;
			}

			private int JBCOADAEJAO(AnimationClip AICMMKJMNKA)
			{
				int value;
				if (!clipNameHashCodeTable.TryGetValue(AICMMKJMNKA, out value))
				{
					value = AICMMKJMNKA.name.GetHashCode();
					clipNameHashCodeTable.Add(AICMMKJMNKA, value);
				}
				return value;
			}
		}

		[SerializeField]
		protected MecanimTranslator translator;

		public MecanimTranslator HCFPALDKFPF
		{
			get
			{
				return translator;
			}
		}

		protected event JNGOIOMIBKL JIODOOJGLPN;

		protected event JNGOIOMIBKL CHEHKNDBMDK;

		protected event JNGOIOMIBKL JLBDDPGJDKC;

		public event JNGOIOMIBKL HIMOJNHKFMC
		{
			add
			{
				JIODOOJGLPN += value;
			}
			remove
			{
				JIODOOJGLPN -= value;
			}
		}

		public event JNGOIOMIBKL MPLLKFLOEHE
		{
			add
			{
				CHEHKNDBMDK += value;
			}
			remove
			{
				CHEHKNDBMDK -= value;
			}
		}

		public event JNGOIOMIBKL MBJAPEPNHNB
		{
			add
			{
				JLBDDPGJDKC += value;
			}
			remove
			{
				JLBDDPGJDKC -= value;
			}
		}

		public override void Initialize(bool AJMAKDEFBOL)
		{
			if (valid && !AJMAKDEFBOL)
			{
				return;
			}
			base.Initialize(AJMAKDEFBOL);
			if (valid)
			{
				if (translator == null)
				{
					translator = new MecanimTranslator();
				}
				translator.JPLFFCHJICB(GetComponent<Animator>(), skeletonDataAsset);
			}
		}

		public void Update()
		{
			if (valid)
			{
				translator.FCHLOGCODOA(skeleton);
				if (this.JIODOOJGLPN != null)
				{
					this.JIODOOJGLPN(this);
				}
				skeleton.DGCKCELHAEG();
				if (this.CHEHKNDBMDK != null)
				{
					this.CHEHKNDBMDK(this);
					skeleton.DGCKCELHAEG();
				}
				if (this.JLBDDPGJDKC != null)
				{
					this.JLBDDPGJDKC(this);
				}
			}
		}
	}
}
