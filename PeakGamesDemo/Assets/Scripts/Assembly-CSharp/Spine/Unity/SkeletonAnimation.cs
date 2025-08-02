using UnityEngine;

namespace Spine.Unity
{
	[HelpURL("http://esotericsoftware.com/spine-unity-documentation#Controlling-Animation")]
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/SkeletonAnimation")]
	public class SkeletonAnimation : SkeletonRenderer, OAGCBGJOPGD, ILGBIBDBIAG
	{
		public KJKAIEHNGAL state;

		[HPODBBIKPLB("", "", true, false)]
		[SerializeField]
		private string _animationName;

		public bool loop;

		public float timeScale = 1f;

		public KJKAIEHNGAL ANLDIDIBHAM
		{
			get
			{
				return state;
			}
		}

		public string CENGNKJGOGP
		{
			get
			{
				if (!valid)
				{
					Debug.LogWarning("You tried access AnimationName but the SkeletonAnimation was not valid. Try checking your Skeleton Data for errors.");
					return null;
				}
				JHFLAELBLPM jHFLAELBLPM = state.OAFAPDHKFLP(0);
				return (jHFLAELBLPM != null) ? jHFLAELBLPM.CEINFKDBNAH.PNGPLGHKFDI : null;
			}
			set
			{
				if (!(_animationName == value))
				{
					_animationName = value;
					if (!valid)
					{
						Debug.LogWarning("You tried to change AnimationName but the SkeletonAnimation was not valid. Try checking your Skeleton Data for errors.");
					}
					else if (string.IsNullOrEmpty(value))
					{
						state.JKEHGHMHCKJ(0);
					}
					else
					{
						state.LMHOONAMFIJ(0, value, loop);
					}
				}
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

		public static SkeletonAnimation AddToGameObject(GameObject HCEDAECPCIA, SkeletonDataAsset KAFMHICMBHN)
		{
			return SkeletonRenderer.AddSpineComponent<SkeletonAnimation>(HCEDAECPCIA, KAFMHICMBHN);
		}

		public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset KAFMHICMBHN)
		{
			return SkeletonRenderer.NewSpineGameObject<SkeletonAnimation>(KAFMHICMBHN);
		}

		public override void ClearState()
		{
			base.ClearState();
			if (state != null)
			{
				state.HGGAEKOBGDL();
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
				state = new KJKAIEHNGAL(skeletonDataAsset.AFBPPBHHKFB());
				if (!string.IsNullOrEmpty(_animationName))
				{
					state.LMHOONAMFIJ(0, _animationName, loop);
					Update(0f);
				}
			}
		}

		private void Update()
		{
			Update(Time.deltaTime);
		}

		public void Update(float CFENOBBDOHG)
		{
			if (valid)
			{
				CFENOBBDOHG *= timeScale;
				skeleton.BPAJGOINFNL(CFENOBBDOHG);
				state.BPAJGOINFNL(CFENOBBDOHG);
				state.FCHLOGCODOA(skeleton);
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
