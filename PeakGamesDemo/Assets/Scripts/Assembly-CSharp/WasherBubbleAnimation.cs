using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using DG.Tweening;
using UnityEngine;

public class WasherBubbleAnimation : BubbleAnimation
{
	[CompilerGenerated]
	private sealed class FNFCMKALPNM
	{
		internal Cell FIICENBDLDC;

		internal WasherBubbleAnimation PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			FIICENBDLDC.ApplyReservedBubble(PDAPIGLEPGC);
			Object.Destroy(PDAPIGLEPGC.gameObject);
		}
	}

	[CompilerGenerated]
	private sealed class POPBHFFCMPM
	{
		internal Sequence JIEEDECENPC;

		internal void AGFNGEFDHLA()
		{
			JIEEDECENPC = null;
		}
	}

	protected override void DIOELAHNLKJ()
	{
	}

	public void Prepare(Cell FIICENBDLDC)
	{
		Sequence s = DOTween.Sequence();
		float duration = BFGGHJGIHLJ.FDFDDKBDPEG(0.4f, 0.6f, 12);
		base.transform.localScale = Vector3.zero;
		s.Append(base.transform.DOMove(FIICENBDLDC.GetFrozenPosition(), duration).SetEase(Ease.OutBack).OnComplete(delegate
		{
			FIICENBDLDC.ApplyReservedBubble(this);
			Object.Destroy(base.gameObject);
		}));
		s.Join(base.transform.DOScale(Vector3.one, duration));
	}

	public override void ShowBubble(Sequence JIEEDECENPC, SpriteRenderer IPOOHPFIBIB)
	{
		if (JIEEDECENPC != null)
		{
			JIEEDECENPC.Kill();
		}
		JIEEDECENPC = DOTween.Sequence();
		IPOOHPFIBIB.transform.localScale = Vector3.one;
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(new Vector3(1.2f, 0.9f, 1f), 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(new Vector3(1f, 1.2f, 1f), 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(new Vector3(1.1f, 1f, 1f), 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(Vector3.one, 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.OnComplete(delegate
		{
			JIEEDECENPC = null;
		});
	}
}
