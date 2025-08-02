using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class ChatScrollController : VerticalScrollController
	{
		[CompilerGenerated]
		private sealed class HCDJMPKNGDA
		{
			internal ChatEntry GBEPIJIBPLJ;

			internal void AGFNGEFDHLA()
			{
				Object.Destroy(GBEPIJIBPLJ.gameObject);
			}
		}

		private readonly List<ChatEntry> AKHFJNECLFP = new List<ChatEntry>();

		private float JLKONGJKGKJ;

		private float GJODEKKOIAF;

		private float NOIAAOPBKMI;

		public void SetVisiblePos(float NGGFBBGNODJ, float NFJIJCMIPDJ)
		{
			GJODEKKOIAF = NGGFBBGNODJ;
			NOIAAOPBKMI = NFJIJCMIPDJ;
		}

		public List<ChatEntry> GetEntries()
		{
			return AKHFJNECLFP;
		}

		public void AddContent(ChatEntry EJCNAJOHBFI, bool HKBMOIANBPA = false)
		{
			AKHFJNECLFP.Add(EJCNAJOHBFI);
			AddGameObject(EJCNAJOHBFI.gameObject, new Vector3(0f, 0f - JLKONGJKGKJ, 0f), 1f);
			if (HKBMOIANBPA)
			{
				PDMILFFKHAL(false);
				SetContentSize(JLKONGJKGKJ);
				return;
			}
			float num = Content.transform.localPosition.y + EJCNAJOHBFI.transform.localPosition.y;
			bool eFKCIIGDDBK = num < GJODEKKOIAF && num > NOIAAOPBKMI;
			PDMILFFKHAL(eFKCIIGDDBK);
			SetContentSizeAnimated(JLKONGJKGKJ, eFKCIIGDDBK);
			EJCNAJOHBFI.transform.localScale = Vector3.zero;
			EJCNAJOHBFI.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutSine);
		}

		public void UpdateScroll()
		{
			SetContentSize(JLKONGJKGKJ);
		}

		public void LateUpdate()
		{
			if (AKHFJNECLFP.Count == 0)
			{
				return;
			}
			int count = AKHFJNECLFP.Count;
			for (int i = 0; i < count; i++)
			{
				ChatEntry chatEntry = AKHFJNECLFP[i];
				if (!(chatEntry != null))
				{
					continue;
				}
				float num = chatEntry.transform.localPosition.y + Content.transform.localPosition.y;
				if (num > -10f && num < 20f)
				{
					if (!chatEntry.gameObject.activeSelf)
					{
						chatEntry.gameObject.SetActive(true);
					}
				}
				else if (chatEntry.gameObject.activeSelf)
				{
					chatEntry.gameObject.SetActive(false);
				}
			}
		}

		public void RemoveContent(ChatEntry EJCNAJOHBFI)
		{
			if (!AKHFJNECLFP.Contains(EJCNAJOHBFI))
			{
				return;
			}
			AKHFJNECLFP.Remove(EJCNAJOHBFI);
			PENKNKCIJGH(EJCNAJOHBFI.gameObject, false);
			ChatEntry GBEPIJIBPLJ = EJCNAJOHBFI;
			float num = Content.transform.localPosition.y + EJCNAJOHBFI.transform.localPosition.y;
			bool flag = num < GJODEKKOIAF && num > NOIAAOPBKMI;
			if (flag)
			{
				EJCNAJOHBFI.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.OutSine).OnComplete(delegate
				{
					Object.Destroy(GBEPIJIBPLJ.gameObject);
				});
			}
			else
			{
				Object.Destroy(GBEPIJIBPLJ.gameObject);
			}
			PDMILFFKHAL(flag);
			SetContentSizeAnimated(JLKONGJKGKJ, flag);
		}

		public override void RemoveAllItems()
		{
			base.RemoveAllItems();
			AKHFJNECLFP.Clear();
		}

		private void PDMILFFKHAL(bool EFKCIIGDDBK = true)
		{
			int count = AKHFJNECLFP.Count;
			if (count == 0)
			{
				return;
			}
			float num = 0.5f;
			for (int i = 0; i < count; i++)
			{
				ChatEntry chatEntry = AKHFJNECLFP[i];
				if (!(chatEntry == null))
				{
					chatEntry.transform.DOKill(true);
					if ((chatEntry.transform.localPosition.y > 0f - num + 0.1f || chatEntry.transform.localPosition.y < 0f - num - 0.1f) && EFKCIIGDDBK)
					{
						chatEntry.transform.DOLocalMoveY(0f - num, 0.3f);
					}
					else
					{
						chatEntry.transform.localPosition = new Vector3(0f, 0f - num, 0f);
					}
					num += chatEntry.GetHeight() + 0.16f;
				}
			}
			JLKONGJKGKJ = num;
		}
	}
}
