using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using NewMapScene;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class DailyBonusDialog : FullscreenDialog
	{
		public GameObject DailyBonusItem;

		public GameObject ClaimButton;

		public Transform Scaler2;

		public Transform DailyBonusTitle;

		public Transform InfoTextContainer;

		public Transform CardsContainer;

		public TextMeshPro InfoText;

		public Transform BackgroundImage;

		public SpriteRenderer GradientSpriteRenderer;

		public SpriteRenderer BlackLayerSpriteRenderer;

		public AnimationCurve TextMoveCurve;

		public AnimationCurve CardMoveCurve;

		private Material FNDEBEFCKAD;

		private Coroutine LBHCFCBBEOF;

		private int OPICJDMPMDI;

		private List<DailyBonusItem> JIJAJCNPHEP;

		private KeyValuePair<NAAHKHPBAPA, int> PFEKHONFOGL;

		private Action AMFCLGFBDJI;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		public void Start()
		{
			float x = base.transform.lossyScale.x;
			Vector3 localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
			BackgroundImage.transform.localScale = localScale;
			GradientSpriteRenderer.transform.localScale = localScale;
			BlackLayerSpriteRenderer.transform.localScale = localScale;
		}

		public override void DialogCreated()
		{
			base.NCJFEFMJKFA = Time.frameCount;
			ClaimButton.SetActive(false);
			ClaimButton.transform.localScale = Vector3.zero;
			DailyBonusTitle.localPosition = ONCMBJKLKIL.ECLBGPBLGMD + Vector3.up * 1.5f;
			InfoTextContainer.localPosition = ONCMBJKLKIL.HINDAIPFFJL + Vector3.down * 1.5f;
			if (ONCMBJKLKIL.PEFHCKMBHOM)
			{
				Scaler2.localScale = Vector3.one * 0.75f;
				DailyBonusTitle.localPosition = ONCMBJKLKIL.ECLBGPBLGMD + Vector3.up * 2f;
				InfoTextContainer.localPosition = ONCMBJKLKIL.HINDAIPFFJL + Vector3.down * 2f;
			}
			else if (ONCMBJKLKIL.GGPFFOOIGHG)
			{
				Scaler2.localScale = Vector3.one * 0.85f;
				DailyBonusTitle.localPosition = ONCMBJKLKIL.ECLBGPBLGMD + Vector3.up * 2f;
				InfoTextContainer.localPosition = ONCMBJKLKIL.HINDAIPFFJL + Vector3.down * 2f;
			}
			else if (ONCMBJKLKIL.HLDNKOLGDGE)
			{
				Scaler2.localScale = Vector3.one * 0.95f;
			}
			FNDEBEFCKAD = GradientSpriteRenderer.material;
			FNDEBEFCKAD.SetColor("_colorA", new Color(10f / 51f, 48f / 85f, 0.7647059f, 0f));
			FNDEBEFCKAD.SetColor("_colorB", new Color(0f, 0f, 0f, 0.08627451f));
			FNDEBEFCKAD.SetFloat("_slide", 0.4f);
			FNDEBEFCKAD.SetFloat("_alpha", 1f);
			FNDEBEFCKAD.SetFloat("_x", 0.5f);
			FNDEBEFCKAD.SetFloat("_y", 0.5f);
			FNDEBEFCKAD.SetFloat("_scaleX", 12.44f);
			FNDEBEFCKAD.SetFloat("_scaleY", 24.34f);
			FNDEBEFCKAD.SetFloat("_ratio", 0.79f);
			HNGMNHMJCOC(0);
		}

		public override void PlayDialogInAnimation()
		{
			Sequence s = DOTween.Sequence();
			s.Insert(0.2f, DailyBonusTitle.DOLocalMove(new Vector3(0f, 6.461f), 0.4f).SetEase(TextMoveCurve));
			MBGMCKHOCIA(0.5f);
		}

		public override Sequence PlayDialogOutAnimation()
		{
			return DOTween.Sequence();
		}

		public void OnItemClicked(int HBMKHCHGHHF)
		{
			int num = HBMKHCHGHHF;
			KeyValuePair<NAAHKHPBAPA, int> keyValuePair = DJFEHCGIDGC.GABGKBAKHDP.CPFHJBNNLHB(HBMKHCHGHHF);
			if (keyValuePair.Key == NAAHKHPBAPA.Life && CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ() >= 5)
			{
				num = ((HBMKHCHGHHF >= 4) ? (HBMKHCHGHHF - 1) : (HBMKHCHGHHF + 1));
				KeyValuePair<NAAHKHPBAPA, int> keyValuePair2 = DJFEHCGIDGC.GABGKBAKHDP.CPFHJBNNLHB(num);
				JIJAJCNPHEP[HBMKHCHGHHF].SetContent(keyValuePair2.Key, keyValuePair2.Value, num, this);
				JIJAJCNPHEP[num].SetContent(keyValuePair.Key, keyValuePair.Value, HBMKHCHGHHF, this);
			}
			JIJAJCNPHEP[OPICJDMPMDI].PlayRareIdleAnimation(false);
			StopCoroutine(LBHCFCBBEOF);
			JPEBEDLKFEP(num);
			PKMALAAFMOH(HBMKHCHGHHF);
			HNGMNHMJCOC(1);
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.1f, delegate
			{
				ClaimButton.SetActive(true);
				ClaimButton.transform.DOScale(Vector3.one, 0.35f);
			});
		}

		public void SetOnDialogClosedCallback(Action BHFCKIMLCMM)
		{
			AMFCLGFBDJI = BHFCKIMLCMM;
		}

		public void ClaimDailyBonus()
		{
			DJFEHCGIDGC.GABGKBAKHDP.PJEOJFGDDAD(PFEKHONFOGL.Key, PFEKHONFOGL.Value);
			AFJPGLHKOID.FJAGKJJLIGH(PFEKHONFOGL.Key, PFEKHONFOGL.Value);
			Close();
		}

		private void HNGMNHMJCOC(int EGEPICBFDAE)
		{
			switch (EGEPICBFDAE)
			{
			case 0:
				InfoText.SetText(NKILHODNBDE.GHBGCADFLFB("DailyBonusPick"));
				break;
			case 1:
			{
				Sequence s = DOTween.Sequence();
				s.Append(InfoText.DOFade(0f, 0.5f));
				s.AppendCallback(delegate
				{
					InfoText.SetText(NKILHODNBDE.GHBGCADFLFB("DailyBonusTomorrow"));
				});
				s.Append(InfoText.DOFade(1f, 0.5f));
				break;
			}
			}
		}

		public override void OnDialogClosed()
		{
			if (PFEKHONFOGL.Key != 0)
			{
				if (base.FANPAGHELKE)
				{
					SpriteButtonListener.Instance.EnableClicks = false;
				}
				if (PFEKHONFOGL.Key == NAAHKHPBAPA.Coins)
				{
					IJIMKNBDAKJ(PFEKHONFOGL.Value);
				}
				else if (PFEKHONFOGL.Key == NAAHKHPBAPA.Life)
				{
					BGLOMCDFIJN(PFEKHONFOGL.Value);
					if (MapManager.Instance != null)
					{
						MapManager.Instance.CurrentSocialHelper.CurrentInbox.UpdateScrollContent();
					}
				}
				else if (PFEKHONFOGL.Key.LGOKFILDDDD() || PFEKHONFOGL.Key.MCMDJCBFENO())
				{
					PNCAMIMNGII();
				}
			}
			else
			{
				base.OnDialogClosed();
			}
			if (AMFCLGFBDJI != null)
			{
				AMFCLGFBDJI();
			}
		}

		private void NIBANLIALFA()
		{
			if (base.FANPAGHELKE)
			{
				MapManager.Instance.CurrentNewMapAnimationController.StartAnimationFlowOnFocusIn();
			}
		}

		private void JPEBEDLKFEP(int EDDNOJDPMCF)
		{
			PFEKHONFOGL = DJFEHCGIDGC.GABGKBAKHDP.HNENNHMGDAN(EDDNOJDPMCF);
			DJFEHCGIDGC.GABGKBAKHDP.IMIJOKIKJPG();
		}

		private void MBGMCKHOCIA(float GMKDJDOLPMB)
		{
			Sequence s = DOTween.Sequence();
			Dictionary<NAAHKHPBAPA, int> dictionary = DJFEHCGIDGC.GABGKBAKHDP.BEHOJDPIJEK();
			Vector3 endValue = new Vector3(-3.02f, 3.678f, -12f);
			Vector2 vector = new Vector2(3.02f, 3.381f);
			JIJAJCNPHEP = new List<DailyBonusItem>();
			Vector3 position = ONCMBJKLKIL.HINDAIPFFJL + Vector3.down * 1.5f;
			int num = 0;
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in dictionary)
			{
				if (endValue.x > vector.x)
				{
					endValue.x = vector.x * -1f;
					endValue.y -= vector.y;
				}
				GameObject gameObject = UnityEngine.Object.Instantiate(DailyBonusItem);
				gameObject.transform.SetParent(CardsContainer);
				gameObject.transform.localScale = Vector3.one;
				gameObject.transform.position = position;
				DailyBonusItem component = gameObject.GetComponent<DailyBonusItem>();
				component.SetContent(item.Key, item.Value, num, this);
				JIJAJCNPHEP.Add(component);
				float atPosition = GMKDJDOLPMB + (float)num * 0.08f;
				s.Insert(atPosition, gameObject.transform.DOLocalMove(endValue, 0.6f).SetEase(CardMoveCurve));
				endValue.x += vector.x;
				num++;
			}
			for (int i = 0; i < 7; i++)
			{
				float atPosition2 = GMKDJDOLPMB + (float)i * 0.141f;
				s.InsertCallback(atPosition2, delegate
				{
					AudioManager.Play(KOOGPFAPGGD.DailyBonusCardFly, GCEAKOOGDJK.Multiple);
				});
			}
			KDIHHJOKDIA(false);
			s.Insert(1.4f, InfoTextContainer.DOLocalMove(new Vector3(0f, -5.976f), 0.4f).SetEase(TextMoveCurve));
			s.InsertCallback(1.4f, delegate
			{
				KDIHHJOKDIA(true);
				LBHCFCBBEOF = StartCoroutine(MPNLFBBMJEE());
			});
		}

		private void PKMALAAFMOH(int EDDNOJDPMCF)
		{
			KDIHHJOKDIA(false);
			BlackLayerSpriteRenderer.DOFade(0.6f, 0.5f);
			for (int i = 0; i < JIJAJCNPHEP.Count; i++)
			{
				if (i != EDDNOJDPMCF)
				{
					JIJAJCNPHEP[i].PlayTurnAnimation(1f + (float)i * 0.05f, 0.2f, false);
				}
			}
		}

		private void KDIHHJOKDIA(bool EDDNOJDPMCF)
		{
			foreach (DailyBonusItem item in JIJAJCNPHEP)
			{
				item.EnableItem(EDDNOJDPMCF);
			}
		}

		private IEnumerator MPNLFBBMJEE()
		{
			WaitForSeconds[] array = new WaitForSeconds[3]
			{
				new WaitForSeconds(1.8f),
				new WaitForSeconds(2.4f),
				new WaitForSeconds(3f)
			};
			while (true)
			{
				OPICJDMPMDI = UnityEngine.Random.Range(0, JIJAJCNPHEP.Count);
				JIJAJCNPHEP[OPICJDMPMDI].PlayRareIdleAnimation(true);
				yield return array[UnityEngine.Random.Range(0, array.Length)];
			}
		}

		private void IJIMKNBDAKJ(int AGKAAMJKIMN)
		{
			if (AGKAAMJKIMN <= 0)
			{
				return;
			}
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				base.OnDialogClosed();
				return;
			}
			Vector3 kKAHENNAJJD = Vector3.down * 2.45f;
			if (base.DNADNGGDHKE)
			{
				instance.StartCoinCollectAnimation(AGKAAMJKIMN, NIBANLIALFA, 10, kKAHENNAJJD);
				return;
			}
			base.OnDialogClosed();
			instance.StartCoinCollectAnimation(AGKAAMJKIMN, 10, kKAHENNAJJD);
		}

		private void BGLOMCDFIJN(int CEIFIBDKNCB)
		{
			if (CEIFIBDKNCB <= 0)
			{
				return;
			}
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				base.OnDialogClosed();
				return;
			}
			Vector3 kKAHENNAJJD = Vector3.down * 2.45f;
			if (base.DNADNGGDHKE)
			{
				instance.StartLifeCollectAnimation(CEIFIBDKNCB, NIBANLIALFA, 5, kKAHENNAJJD, true);
				return;
			}
			base.OnDialogClosed();
			instance.StartLifeCollectAnimation(CEIFIBDKNCB, 5, kKAHENNAJJD, true);
		}

		private void PNCAMIMNGII()
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				base.OnDialogClosed();
				return;
			}
			if (base.DNADNGGDHKE)
			{
				instance.StartRewardCollectAnimation(PFEKHONFOGL.Key, PFEKHONFOGL.Value, NIBANLIALFA);
				return;
			}
			base.OnDialogClosed();
			instance.StartRewardCollectAnimation(PFEKHONFOGL.Key, PFEKHONFOGL.Value, null);
		}

		[CompilerGenerated]
		private void JFOAOIOGDJM()
		{
			ClaimButton.SetActive(true);
			ClaimButton.transform.DOScale(Vector3.one, 0.35f);
		}

		[CompilerGenerated]
		private void HOJADKHDJLI()
		{
			InfoText.SetText(NKILHODNBDE.GHBGCADFLFB("DailyBonusTomorrow"));
		}

		[CompilerGenerated]
		private static void DNJOILMHENE()
		{
			AudioManager.Play(KOOGPFAPGGD.DailyBonusCardFly, GCEAKOOGDJK.Multiple);
		}

		[CompilerGenerated]
		private void BELEGLEHFLP()
		{
			KDIHHJOKDIA(true);
			LBHCFCBBEOF = StartCoroutine(MPNLFBBMJEE());
		}
	}
}
