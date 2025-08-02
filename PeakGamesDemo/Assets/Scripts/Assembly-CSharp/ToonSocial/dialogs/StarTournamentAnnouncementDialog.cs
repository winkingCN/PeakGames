using DG.Tweening;
using Dialogs;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class StarTournamentAnnouncementDialog : OnCloseCallbackDialog
	{
		public Transform JapaneseSunContainer;

		private void Start()
		{
			if (JapaneseSunContainer != null)
			{
				JapaneseSunContainer.transform.DORotate(new Vector3(0f, 0f, -179.99f), 30f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
			}
		}
	}
}
