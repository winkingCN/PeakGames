using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.SceneTransitions;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Touches
{
	public abstract class AbstractTapListener : MonoBehaviour
	{
		protected CFOIPDKEFMM JHDMFHDHIFN;

		public LevelBuilder CurrentLevelBuilder;

		private const string FJGKCMHNIJK = "Cell";

		public bool WaitFirstUntap;

		public Camera TouchCamera;

		private int EPAPJFCIJCC;

		public virtual void ResetCount()
		{
			EPAPJFCIJCC = 0;
			JHDMFHDHIFN = CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
		}

		public void GetUserActionMobile()
		{
			if (Input.touchCount <= 0)
			{
				return;
			}
			Touch touch = Input.GetTouch(0);
			Vector2 position = touch.position;
			switch (touch.phase)
			{
			case TouchPhase.Began:
				KPCKCDGGBMF(position);
				break;
			case TouchPhase.Moved:
			case TouchPhase.Stationary:
				if (WaitFirstUntap)
				{
					WaitFirstUntap = false;
				}
				else
				{
					NKPMGDHHBPB(position);
				}
				break;
			case TouchPhase.Ended:
			case TouchPhase.Canceled:
				if (WaitFirstUntap)
				{
					WaitFirstUntap = false;
				}
				else
				{
					EFECEAIKDLA(position);
				}
				break;
			}
		}

		public void IncreaseBlockRequests()
		{
			EPAPJFCIJCC++;
		}

		public void DecreaseBlockRequests()
		{
			EPAPJFCIJCC--;
			if (EPAPJFCIJCC < 0)
			{
				EPAPJFCIJCC = 0;
			}
		}

		protected abstract void KPCKCDGGBMF(Vector2 KKGDJPFAHKF);

		protected abstract void NKPMGDHHBPB(Vector2 KKGDJPFAHKF);

		protected abstract void EFECEAIKDLA(Vector2 KKGDJPFAHKF);

		protected Cell PBOLDKFFGMP(Vector2 NPGMHNONCGO)
		{
			BoxCollider2D boxCollider2D = Physics2D.OverlapPoint(TouchCamera.ScreenToWorldPoint(NPGMHNONCGO)) as BoxCollider2D;
			if (boxCollider2D != null && boxCollider2D.gameObject != null && boxCollider2D.CompareTag("Cell"))
			{
				return JHDMFHDHIFN.GFIEMDDJAOB[boxCollider2D];
			}
			return null;
		}

		public void Update()
		{
			if (EPAPJFCIJCC <= 0 && !FallManager.AreThereMechanicAnimations() && !FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && !LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				GetUserActionMobile();
			}
		}
	}
}
