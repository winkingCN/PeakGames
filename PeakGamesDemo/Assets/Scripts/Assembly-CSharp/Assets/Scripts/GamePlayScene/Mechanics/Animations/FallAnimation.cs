using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class FallAnimation : MonoBehaviour
	{
		public enum FNAHJFMEOJN
		{
			NotStarted = 0,
			StartFalling = 1,
			Falling = 2,
			Completed = 3,
			Destroyed = 4
		}

		public const float MaxCrashSpeed = 30f;

		public const float Acceleration = 40f;

		private readonly Queue<Vector3> PLNELMKICNF = new Queue<Vector3>(9);

		private float IBDHOLLIANN = 6f;

		private Vector3 IJFJEPMHDCE;

		private FallListener JJACBFNBGKD;

		private bool PFKHLDEKOGH;

		public Item CurrentItem;

		private bool BGDCFNLHNPK;

		[HideInInspector]
		public FNAHJFMEOJN State;

		public void AppendFallTo(Cell CAEMELGEOAE, FallListener MOLJONEMHBK)
		{
			if (!base.enabled)
			{
				base.enabled = true;
				PLNELMKICNF.Clear();
				IBDHOLLIANN = 6f;
				PFKHLDEKOGH = false;
				BGDCFNLHNPK = false;
				State = FNAHJFMEOJN.NotStarted;
			}
			PLNELMKICNF.Enqueue(CAEMELGEOAE.GetFrozenPosition());
			if (CurrentItem != null)
			{
				CurrentItem.OnFallUpdated();
			}
			if (State == FNAHJFMEOJN.NotStarted)
			{
				if (!PFKHLDEKOGH)
				{
					PFKHLDEKOGH = true;
					FallManager.AddOneFall();
				}
				IJFJEPMHDCE = PLNELMKICNF.Peek();
				CurrentItem.DFKAIGLKIIH += NEDFJELHCCP;
				JJACBFNBGKD = MOLJONEMHBK;
			}
		}

		private void NEDFJELHCCP()
		{
			if (base.enabled)
			{
				base.enabled = false;
				if (PFKHLDEKOGH)
				{
					FallManager.RemoveOneFall();
				}
			}
		}

		public void Update()
		{
			switch (State)
			{
			case FNAHJFMEOJN.NotStarted:
				if (PLNELMKICNF.Count > 0)
				{
					State = FNAHJFMEOJN.StartFalling;
				}
				break;
			case FNAHJFMEOJN.StartFalling:
				IJFJEPMHDCE = PLNELMKICNF.Dequeue();
				State = FNAHJFMEOJN.Falling;
				if (JJACBFNBGKD != null)
				{
					JJACBFNBGKD.StartFall();
				}
				break;
			case FNAHJFMEOJN.Falling:
				NFJHKHHDODF();
				break;
			case FNAHJFMEOJN.Completed:
			{
				base.transform.position = IJFJEPMHDCE;
				CurrentItem.IsFalling = false;
				CurrentItem.FilledNewly = false;
				if (JJACBFNBGKD != null)
				{
					JJACBFNBGKD.EndFall(IBDHOLLIANN);
				}
				CurrentItem.OnFallEnded();
				Cell currentCell = CurrentItem.ENCFFNKONOO;
				if (currentCell != null)
				{
					Cell justBelowCell = currentCell.JustBelowCell;
					if (justBelowCell != null && justBelowCell.EAILOFHFNJO)
					{
						justBelowCell.LBFCDKPCDPB.ReactToUpperFall();
						if (CurrentItem.CanCastShadow())
						{
							if (justBelowCell.LBFCDKPCDPB.CanShadowDrop())
							{
								CurrentItem.GetShadowCaster().CastShadow();
							}
							else
							{
								CurrentItem.GetShadowCaster().HideShadow();
							}
						}
					}
					else if (CurrentItem.CanCastShadow())
					{
						CurrentItem.GetShadowCaster().HideShadow();
					}
				}
				IBDHOLLIANN = 0f;
				State = FNAHJFMEOJN.Destroyed;
				NEDFJELHCCP();
				break;
			}
			}
		}

		private void NFJHKHHDODF()
		{
			Vector3 position = base.transform.position;
			Vector3 iJFJEPMHDCE = IJFJEPMHDCE;
			bool flag = PLNELMKICNF.Count > 0;
			float deltaTime = Time.deltaTime;
			float num = IBDHOLLIANN * deltaTime + 40f * deltaTime * deltaTime;
			if (!BGDCFNLHNPK && IBDHOLLIANN < 30f)
			{
				IBDHOLLIANN += 40f * deltaTime;
				if (IBDHOLLIANN > 30f)
				{
					IBDHOLLIANN = 30f;
					BGDCFNLHNPK = true;
				}
			}
			position.y -= num;
			if (position.y < iJFJEPMHDCE.y)
			{
				if (!flag)
				{
					CurrentItem.IsFalling = false;
					State = FNAHJFMEOJN.Completed;
					position.x = iJFJEPMHDCE.x;
					position.y = iJFJEPMHDCE.y;
					base.gameObject.transform.position = position;
					Update();
					return;
				}
				IJFJEPMHDCE = PLNELMKICNF.Dequeue();
			}
			base.gameObject.transform.position = position;
		}

		public bool IsFalling()
		{
			return base.enabled && State != FNAHJFMEOJN.Completed && State != FNAHJFMEOJN.Destroyed;
		}

		public void Cancel()
		{
			if (base.enabled && State != FNAHJFMEOJN.Destroyed)
			{
				State = FNAHJFMEOJN.Completed;
				Update();
			}
		}
	}
}
