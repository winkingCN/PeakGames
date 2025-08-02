using UnityEngine;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public abstract class SpriteButton : BaseButton
	{
		protected SpriteRenderer MGMJGELPECJ;

		private SpriteRenderer[] AFPHEFPNJKP;

		public void Awake()
		{
			MGMJGELPECJ = GetComponent<SpriteRenderer>();
			if (MGMJGELPECJ == null)
			{
				AFPHEFPNJKP = GetComponentsInChildren<SpriteRenderer>();
			}
		}

		public override void ButtonDown()
		{
			if (CanBeClicked)
			{
				LMILIEDFIFF();
				base.gameObject.transform.localScale = new Vector3(0.94f, 0.94f, 0.94f);
			}
		}

		protected virtual void LMILIEDFIFF()
		{
		}

		public override void ButtonUp(bool AJICEJDODNC)
		{
			base.gameObject.transform.localScale = Vector3.one;
			if (CanBeClicked && AJICEJDODNC)
			{
				PerformAction();
			}
		}

		public void DisableButton(bool FKNCBHEIMHP = true)
		{
			if (FKNCBHEIMHP)
			{
				if (MGMJGELPECJ != null)
				{
					MGMJGELPECJ.color = Color.grey;
				}
				else if (AFPHEFPNJKP != null)
				{
					SpriteRenderer[] aFPHEFPNJKP = AFPHEFPNJKP;
					foreach (SpriteRenderer spriteRenderer in aFPHEFPNJKP)
					{
						spriteRenderer.color = Color.grey;
					}
				}
			}
			CanBeClicked = false;
		}

		public void EnableButton()
		{
			if (MGMJGELPECJ != null)
			{
				MGMJGELPECJ.color = Color.white;
			}
			else if (AFPHEFPNJKP != null)
			{
				SpriteRenderer[] aFPHEFPNJKP = AFPHEFPNJKP;
				foreach (SpriteRenderer spriteRenderer in aFPHEFPNJKP)
				{
					spriteRenderer.color = Color.white;
				}
			}
			CanBeClicked = true;
		}
	}
}
