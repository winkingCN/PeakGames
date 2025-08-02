using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using NewMapScene;
using TMPro;
using UnityEngine;
using Utils;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class CLEnterenceDialog : FullscreenDialog
	{
		public static bool DialogActive;

		public Transform ContentTransform;

		public GameObject CreateNicknameDialog;

		public GameObject NicknameButtonActive;

		public GameObject NicknameButtonDeactive;

		public GameObject BlackBackground;

		public GameObject LoadingIcon;

		public TMP_InputField NickInputField;

		public Transform JapaneseSunTranform;

		private IBKHFKAANJP EHLIIEELMGG;

		private int JODFKAPBJOE = 15;

		private Action JCOKJJGCPHI;

		private string ALANJKEIKDI;

		private Sequence BJCJLNMDBMA;

		[CompilerGenerated]
		private static Action<bool, ClStatusResponseMessage> EBCOMJBLIPP;

		public void Update()
		{
			if (!SlowCheckTime.ShouldPass() && CreateNicknameDialog.activeSelf && !NickInputField.MKAKFOEBMDF && NickInputField.enabled)
			{
				NickInputField.Select();
			}
		}

		public void OnTextChange()
		{
			EIIJIOKCNMG();
			CBHHFENKOAP();
		}

		private void CBHHFENKOAP()
		{
			string input = NickInputField.FCJBBPHFNPJ.Trim();
			input = Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
			OOJBOJKIEAE(input.Length > 2);
		}

		public void OnEnterClicked()
		{
			ABDJJDHMENI item = new ABDJJDHMENI(delegate(bool EEKJMDHEJCK, ClJoinResponseMessage DIDHNNMKJFE)
			{
				if (EEKJMDHEJCK)
				{
					switch (DIDHNNMKJFE.status)
					{
					case ClJoinStatusType.NO_NICKNAME:
						ILKIAKKFIAA();
						KOPGKGGENLL();
						break;
					case ClJoinStatusType.TOO_LATE:
						FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.MoreLevelsDialog, true);
						Close();
						break;
					case ClJoinStatusType.FAILED:
						MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
						JNHCICHFNHL();
						ICADMDPMAGD();
						break;
					default:
						IDFPAFEJPPH.GABGKBAKHDP.HBFHBJADBGL(DIDHNNMKJFE.leaderboard);
						MapManager.Instance.ShouldShowChampionsLeague();
						LGIFDHBAICM();
						StartCoroutine(HLBLCILHDKH());
						break;
					}
				}
				else
				{
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
					JNHCICHFNHL();
					ICADMDPMAGD();
				}
			});
			JBLHLNCOLHD();
			KOPGKGGENLL(true);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		private void LGIFDHBAICM()
		{
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new OMMPHPJNNBD(delegate(bool NIBBBEEAPIH, ClStatusResponseMessage OMJOIIOONMO)
				{
					IDFPAFEJPPH.GABGKBAKHDP.MGDJKABHDGJ(OMJOIIOONMO);
				})
			});
		}

		public void OnNicknameButtonClick()
		{
			if (!CKFMBPHBAJE())
			{
				return;
			}
			NickInputField.enabled = false;
			OOJBOJKIEAE(false);
			ABDJJDHMENI item = new ABDJJDHMENI(delegate(bool EEKJMDHEJCK, ClJoinResponseMessage DIDHNNMKJFE)
			{
				if (EEKJMDHEJCK)
				{
					if (DIDHNNMKJFE.status == ClJoinStatusType.SUCCESS)
					{
						IDFPAFEJPPH.GABGKBAKHDP.HBFHBJADBGL(DIDHNNMKJFE.leaderboard);
						MapManager.Instance.ShouldShowChampionsLeague();
						AFJPGLHKOID.JIPLLFBJBIL(NickInputField.FCJBBPHFNPJ, 2);
						LGIFDHBAICM();
						StartCoroutine(HLBLCILHDKH());
					}
					else if (DIDHNNMKJFE.status == ClJoinStatusType.FAILED)
					{
						MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
						OOJBOJKIEAE(true);
					}
				}
				else
				{
					OOJBOJKIEAE(true);
					NickInputField.enabled = true;
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				}
			}, NickInputField.FCJBBPHFNPJ);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		private IEnumerator HLBLCILHDKH()
		{
			float time = Time.time;
			NewMapPage newMapContent = MapManager.Instance.NewMapContent;
			while (!newMapContent.IsReady && Time.time < time + 3f)
			{
				yield return null;
			}
			Close();
		}

		private bool CKFMBPHBAJE()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				Close();
				return false;
			}
			EIIJIOKCNMG();
			string text = NickInputField.FCJBBPHFNPJ.Trim();
			if (text.Length < 2)
			{
				return false;
			}
			string gLFMIMLJAPI = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			if (!EHLIIEELMGG.HBKMKHDLEBI(text, gLFMIMLJAPI))
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_InvalidName"));
				return false;
			}
			return true;
		}

		private void EIIJIOKCNMG()
		{
			string text = NickInputField.FCJBBPHFNPJ ?? string.Empty;
			int length = text.Length;
			text = HFFNPEPPBCC.OJHJEGCAPLF(text);
			if (length != text.Length)
			{
				IPHBJCMJONN();
			}
			text = text.TrimStart();
			if (text.Length > JODFKAPBJOE)
			{
				text = text.Substring(0, JODFKAPBJOE);
			}
			NickInputField.FCJBBPHFNPJ = text;
		}

		private void IPHBJCMJONN()
		{
			string aELPGDIJOCN = NKILHODNBDE.GHBGCADFLFB("CharacterNotSupported");
			Vector3 fADJPCHMMBH = Vector3.down * 0.5f;
			MapManager.Instance.ShowErrorMessageAtPosition(aELPGDIJOCN, fADJPCHMMBH);
		}

		private void ILKIAKKFIAA()
		{
			CreateNicknameDialog.SetActive(true);
			float num = 2.15f;
			BJCJLNMDBMA.Kill();
			BJCJLNMDBMA = DOTween.Sequence();
			Tweener t = CreateNicknameDialog.transform.DOMove(new Vector3(0f, 1.5f + num, -2f), 0.3f);
			t.SetEase(Ease.Linear);
			BJCJLNMDBMA.Append(t);
			BJCJLNMDBMA.AppendCallback(base.JNHCICHFNHL);
			t = CreateNicknameDialog.transform.DOMove(new Vector3(0f, num, -2f), 0.7f);
			t.SetEase(base.EaseOutElastic);
			BJCJLNMDBMA.Append(t);
			BJCJLNMDBMA.AppendCallback(BLELAMHLLNN);
			BJCJLNMDBMA.SetEase(Ease.Linear);
			BJCJLNMDBMA.timeScale = 1.2f;
			BJCJLNMDBMA.OnComplete(delegate
			{
				BJCJLNMDBMA = null;
			});
		}

		private void OOJBOJKIEAE(bool IEGIOBJMGKJ)
		{
			NicknameButtonActive.SetActive(IEGIOBJMGKJ);
			NicknameButtonDeactive.SetActive(!IEGIOBJMGKJ);
		}

		private void KOPGKGGENLL(bool IIEOBNGHHJD = false)
		{
			BlackBackground.SetActive(true);
			LoadingIcon.SetActive(IIEOBNGHHJD);
		}

		private void ICADMDPMAGD()
		{
			BlackBackground.SetActive(false);
			LoadingIcon.SetActive(false);
		}

		public override void PlayDialogInAnimation()
		{
			base.transform.localPosition = Vector3.zero;
		}

		public override Sequence PlayDialogOutAnimation()
		{
			return DOTween.Sequence();
		}

		public override void DialogCreated()
		{
			DialogActive = true;
			base.transform.localPosition = new Vector3(0f, 1000f, 0f);
			base.NCJFEFMJKFA = Time.frameCount;
			JNHCICHFNHL();
			CreateNicknameDialog.transform.position = new Vector3(0f, ONCMBJKLKIL.ECLBGPBLGMD.y + 11f, 0f);
			CreateNicknameDialog.SetActive(false);
			OOJBOJKIEAE(false);
			EHLIIEELMGG = IBKHFKAANJP.DGGDDILJFBJ();
			ICADMDPMAGD();
			JapaneseSunTranform.DOLocalRotate(new Vector3(0f, 0f, -179.99f), 20f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
		}

		public void PrepareDialog(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void OnDialogClosed()
		{
			DialogActive = false;
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
		}

		[CompilerGenerated]
		private void HKIONHJCGDG(bool EEKJMDHEJCK, ClJoinResponseMessage DIDHNNMKJFE)
		{
			if (EEKJMDHEJCK)
			{
				switch (DIDHNNMKJFE.status)
				{
				case ClJoinStatusType.NO_NICKNAME:
					ILKIAKKFIAA();
					KOPGKGGENLL();
					break;
				case ClJoinStatusType.TOO_LATE:
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.MoreLevelsDialog, true);
					Close();
					break;
				case ClJoinStatusType.FAILED:
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
					JNHCICHFNHL();
					ICADMDPMAGD();
					break;
				default:
					IDFPAFEJPPH.GABGKBAKHDP.HBFHBJADBGL(DIDHNNMKJFE.leaderboard);
					MapManager.Instance.ShouldShowChampionsLeague();
					LGIFDHBAICM();
					StartCoroutine(HLBLCILHDKH());
					break;
				}
			}
			else
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				JNHCICHFNHL();
				ICADMDPMAGD();
			}
		}

		[CompilerGenerated]
		private static void EKKMGNHAMAK(bool NIBBBEEAPIH, ClStatusResponseMessage OMJOIIOONMO)
		{
			IDFPAFEJPPH.GABGKBAKHDP.MGDJKABHDGJ(OMJOIIOONMO);
		}

		[CompilerGenerated]
		private void INMNAIGIJCF(bool EEKJMDHEJCK, ClJoinResponseMessage DIDHNNMKJFE)
		{
			if (EEKJMDHEJCK)
			{
				if (DIDHNNMKJFE.status == ClJoinStatusType.SUCCESS)
				{
					IDFPAFEJPPH.GABGKBAKHDP.HBFHBJADBGL(DIDHNNMKJFE.leaderboard);
					MapManager.Instance.ShouldShowChampionsLeague();
					AFJPGLHKOID.JIPLLFBJBIL(NickInputField.FCJBBPHFNPJ, 2);
					LGIFDHBAICM();
					StartCoroutine(HLBLCILHDKH());
				}
				else if (DIDHNNMKJFE.status == ClJoinStatusType.FAILED)
				{
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
					OOJBOJKIEAE(true);
				}
			}
			else
			{
				OOJBOJKIEAE(true);
				NickInputField.enabled = true;
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
			}
		}

		[CompilerGenerated]
		private void FKENAJNPNLK()
		{
			BJCJLNMDBMA = null;
		}
	}
}
