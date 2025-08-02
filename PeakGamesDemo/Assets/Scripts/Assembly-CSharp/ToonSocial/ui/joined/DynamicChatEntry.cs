using Assets.Scripts.CasualTools.Dialogs;
using DG.Tweening;
using Dialogs;
using TMPro;
using ToonSocial.dialogs;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace ToonSocial.ui.joined
{
	public class DynamicChatEntry : ChatEntry
	{
		public SpriteRenderer ChatBox;

		public TextMeshPro TimeLeftText;

		public BoxCollider2D Collider;

		public KickButton ReportButton;

		private float KOILMLBEPAA;

		public override float GetHeight()
		{
			return 1.4f + 0.45f * KOILMLBEPAA;
		}

		public override void Prepare(EKPAJFBBAJC KINKOCNMOMJ, SocialHelper JANPCBNIGFG)
		{
			base.Prepare(KINKOCNMOMJ, JANPCBNIGFG);
			if (!(Message == null))
			{
				Message.Rebuild(CanvasUpdate.Prelayout);
				Message.Rebuild(CanvasUpdate.PreRender);
				TimeLeftText.FCJBBPHFNPJ = KINKOCNMOMJ.JJOEKNHBAMG();
				KOILMLBEPAA = Mathf.Min(Message.BIAHJAKEMLM.lineCount, 17);
				float num = KOILMLBEPAA * 22.51f + 30f;
				ChatBox.size = new Vector2(7.633f, GetHeight());
				Vector3 localPosition = ChatBox.transform.localPosition;
				localPosition.y = (0f - num) / 100f - 0.2f;
				ChatBox.transform.localPosition = localPosition;
				Vector3 localPosition2 = TimeLeftText.ANLKLKAINEO.localPosition;
				localPosition2.y = -0.865f - 0.45f * KOILMLBEPAA;
				TimeLeftText.ANLKLKAINEO.localPosition = localPosition2;
				TimeLeftText.gameObject.SetActive(true);
				if (Collider != null)
				{
					float height = GetHeight();
					Collider.offset = new Vector2(0f, (0f - height) * 0.5f);
					Collider.size = new Vector2(7.1f, height);
				}
			}
		}

		public void OnReportClick()
		{
			if (!ReportButton.IsActive())
			{
				Vector3 position = ReportButton.transform.position;
				position.y = SpriteButtonListener.Instance.LastTouchUpPosition.y;
				ReportButton.Show(position.y < -3.85f);
				ReportButton.transform.position = position;
				ReportButton.transform.DOKill();
				ReportButton.transform.localScale = Vector3.zero;
				ReportButton.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
			}
		}

		public void SendReport()
		{
			ReportButton.Hide();
			ReportChatConfirmationDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.ChatReportConfirmationDialog, false).GetComponent<ReportChatConfirmationDialog>();
			component.Prepare(CurrentChatMessage);
		}
	}
}
