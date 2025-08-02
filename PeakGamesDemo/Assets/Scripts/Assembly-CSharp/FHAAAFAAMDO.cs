using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using DG.Tweening;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

public class FHAAAFAAMDO
{
	[CompilerGenerated]
	private sealed class IOOOJBCLFIJ
	{
		internal Dialog HDCNHMFEFLB;

		internal FHAAAFAAMDO PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.CALEHGDGKHN(HDCNHMFEFLB);
		}
	}

	private static FHAAAFAAMDO KNPOFJNFLJB;

	private readonly Stack<Dialog> NGPKDBCAOOH = new Stack<Dialog>();

	private Dialog HNLLPMMNELE;

	private bool GGGPNHMOBPE;

	public bool COCNAAGPOMN
	{
		get
		{
			return GGGPNHMOBPE;
		}
		set
		{
			GGGPNHMOBPE = value;
			AudioManager.CheckAndMuteExternalAudioSources(GGGPNHMOBPE);
		}
	}

	public static FHAAAFAAMDO GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new FHAAAFAAMDO();
			}
			return KNPOFJNFLJB;
		}
	}

	public bool MKLDLJHOHNA { get; set; }

	private FHAAAFAAMDO()
	{
	}

	public GameObject EOBDANKMCBK(GameObject JLJBPHFPJJF, bool OEMIFJACAGF, bool FDNEMLDPIBD = false, bool NCKMLMFFIPK = false, Action<Dialog> DKPMMIKEJDG = null, bool DALNOJFGKBK = true)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.DialogManager, "Show Dialog:" + JLJBPHFPJJF);
		VerticalScrollController.LockAllScrolls();
		VerticalScrollController.InvalidateScrolls();
		if (DALNOJFGKBK)
		{
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground(FDNEMLDPIBD);
		}
		COCNAAGPOMN = true;
		Sequence sequence = null;
		GameObject gameObject = ((!NCKMLMFFIPK) ? UnityEngine.Object.Instantiate(JLJBPHFPJJF) : JLJBPHFPJJF.JOBDHIPIMAG());
		Dialog component = gameObject.GetComponent<Dialog>();
		component.DialogCreated();
		ABPLPAEONPN(component);
		if (HNLLPMMNELE != null && OEMIFJACAGF)
		{
			NGPKDBCAOOH.Push(component);
			return gameObject;
		}
		if (HNLLPMMNELE != null)
		{
			if (HNLLPMMNELE.NCJFEFMJKFA == Time.frameCount)
			{
				HNLLPMMNELE.PlayDialogOutFast();
			}
			else
			{
				sequence = HNLLPMMNELE.PlayDialogOutAnimation();
			}
			NGPKDBCAOOH.Push(HNLLPMMNELE);
		}
		HNLLPMMNELE = component;
		if (DKPMMIKEJDG != null)
		{
			DKPMMIKEJDG(HNLLPMMNELE);
		}
		if (sequence == null)
		{
			HNLLPMMNELE.PlayDialogInAnimation();
		}
		else
		{
			sequence.OnComplete(delegate
			{
				HNLLPMMNELE.PlayDialogInAnimation();
			});
		}
		HNLLPMMNELE.SetDialogBounds();
		return gameObject;
	}

	public Dialog NGIEPDBBJBP()
	{
		return HNLLPMMNELE;
	}

	public static void ABPLPAEONPN(Dialog HICBIPFIHJH)
	{
		float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
		float fHAMOHDEGMK = ONCMBJKLKIL.FHAMOHDEGMK;
		float b = ((!ONCMBJKLKIL.PEFHCKMBHOM) ? (eMFKAPJMDCC / HICBIPFIHJH.ReferenceWidth) : (eMFKAPJMDCC / HICBIPFIHJH.IPadReferenceWidth));
		float a = fHAMOHDEGMK / HICBIPFIHJH.ReferenceHeight;
		float num = Mathf.Min(a, b);
		HICBIPFIHJH.gameObject.transform.localScale = new Vector3(num, num, num);
	}

	public void GLHIMFPOKHD()
	{
		while (NGPKDBCAOOH.Count > 0)
		{
			Dialog dialog = NGPKDBCAOOH.Pop();
			if (!(dialog == null))
			{
				UnityEngine.Object.Destroy(dialog.gameObject);
			}
		}
		if (DialogLibrary.GABGKBAKHDP != null)
		{
			DialogLibrary.GABGKBAKHDP.HideDialogBackground();
		}
		if (HNLLPMMNELE == null)
		{
			COCNAAGPOMN = false;
		}
	}

	public void FPGFIAKIIID(bool PNMBCFAEHBH = false)
	{
		while (NGPKDBCAOOH.Count > 0)
		{
			Dialog dialog = NGPKDBCAOOH.Pop();
			if (!(dialog == null))
			{
				UnityEngine.Object.Destroy(dialog.gameObject);
			}
		}
		if (HNLLPMMNELE != null && (PNMBCFAEHBH || HNLLPMMNELE.ShouldBeClosedOnSceneChange()))
		{
			if (DialogLibrary.GABGKBAKHDP != null)
			{
				DialogLibrary.GABGKBAKHDP.HideDialogBackground();
			}
			UnityEngine.Object.Destroy(HNLLPMMNELE.gameObject);
		}
		HNLLPMMNELE = null;
		OMOKOKFNBKI();
	}

	public void GANLPGBOANC(Dialog HDCNHMFEFLB)
	{
		if (HDCNHMFEFLB != null && HNLLPMMNELE == HDCNHMFEFLB)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.DialogManager, "Close arrived for:" + HDCNHMFEFLB);
			CGMONHGJMPO(HDCNHMFEFLB);
		}
		else
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.DialogManager, "Can not close dialog! Not latest dialog.");
		}
	}

	public void MJJLMBOPJMA()
	{
		if (HNLLPMMNELE != null)
		{
			GANLPGBOANC(HNLLPMMNELE);
		}
	}

	private void CGMONHGJMPO(Dialog HDCNHMFEFLB)
	{
		Sequence sequence = HDCNHMFEFLB.PlayDialogOutAnimation();
		HNLLPMMNELE = null;
		if (sequence != null)
		{
			sequence.OnComplete(delegate
			{
				CALEHGDGKHN(HDCNHMFEFLB);
			});
		}
		else
		{
			CALEHGDGKHN(HDCNHMFEFLB);
		}
	}

	private void CALEHGDGKHN(Dialog HDCNHMFEFLB)
	{
		if (NGPKDBCAOOH.Count <= 0)
		{
			COCNAAGPOMN = false;
			VerticalScrollController.UnlockAllScrolls();
		}
		DialogLibrary.GABGKBAKHDP.HideDialogBackground();
		HDCNHMFEFLB.OnDialogClosed();
		UnityEngine.Object.Destroy(HDCNHMFEFLB.gameObject);
		if (!(HNLLPMMNELE != null) && COCNAAGPOMN && NGPKDBCAOOH.Count > 0)
		{
			HNLLPMMNELE = NGPKDBCAOOH.Pop();
			HNLLPMMNELE.SetDialogBounds();
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground();
			HNLLPMMNELE.PlayDialogInAnimation();
		}
	}

	public void OMOKOKFNBKI()
	{
		HNLLPMMNELE = null;
		NGPKDBCAOOH.Clear();
		COCNAAGPOMN = false;
	}

	public void GAEFCENKJGK()
	{
		if (HNLLPMMNELE != null)
		{
			ABPLPAEONPN(HNLLPMMNELE);
		}
		foreach (Dialog item in NGPKDBCAOOH)
		{
			ABPLPAEONPN(item);
		}
	}

	public void MDEDKFBDNJA(Action GPLIOLJFDPM)
	{
		if ((bool)DialogLibrary.GABGKBAKHDP)
		{
			GPLIOLJFDPM();
		}
		else
		{
			new LLCJMMBBLEH(HOAELMCKNEL(GPLIOLJFDPM));
		}
	}

	private static IEnumerator HOAELMCKNEL(Action GPLIOLJFDPM)
	{
		while (DialogLibrary.GABGKBAKHDP == null)
		{
			yield return null;
		}
		GPLIOLJFDPM();
	}

	[CompilerGenerated]
	private void GIJFJJHANAF()
	{
		HNLLPMMNELE.PlayDialogInAnimation();
	}
}
