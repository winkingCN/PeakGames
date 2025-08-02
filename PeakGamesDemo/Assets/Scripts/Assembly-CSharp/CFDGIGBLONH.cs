using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using UnityEngine;
using Utils;

public abstract class CFDGIGBLONH : JDIDFKABKGN
{
	private const string GHOFLJLHOJN = "LoadingScreen";

	private readonly string LDFDEIEJCOF;

	private int MMECEKFKAPC;

	protected static GameObject FGPNJAEOONM;

	public bool AJJAPHGCFDD { get; private set; }

	public PHHKFLHAFHG BINDEBHMEJC { get; private set; }

	protected CFDGIGBLONH()
	{
		LDFDEIEJCOF = Application.persistentDataPath;
		FGPNJAEOONM = new GameObject("NativeSupportToolProxy");
		UnityEngine.Object.DontDestroyOnLoad(FGPNJAEOONM);
	}

	public void BNJIGCHGOAJ()
	{
		AJJAPHGCFDD = true;
		FHAAAFAAMDO.GABGKBAKHDP.MDEDKFBDNJA(delegate
		{
			if (MMECEKFKAPC == 0)
			{
				MMECEKFKAPC = DialogLibrary.GABGKBAKHDP.DialogBackground.sortingLayerID;
			}
			SpriteButtonListener.Instance.ScreenLockedByNative = true;
			DialogLibrary.GABGKBAKHDP.DialogBackground.sortingLayerID = SortingLayer.NameToID("LoadingScreen");
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground(false, 0f);
			OGNENMNMAIN(NKILHODNBDE.GHBGCADFLFB("Update"), NKILHODNBDE.GHBGCADFLFB("ForceUpdateMessage"), NKILHODNBDE.GHBGCADFLFB("Update"), MCJHHDACJBG.OLCJMEAHEHG);
		});
	}

	public void EHHCGDDCFML()
	{
		if (AJJAPHGCFDD)
		{
			JNOCJCGINCB();
			DialogLibrary.GABGKBAKHDP.HideDialogBackground();
			DialogLibrary.GABGKBAKHDP.DialogBackground.sortingLayerID = ((MMECEKFKAPC == 0) ? SortingLayer.NameToID("UI") : MMECEKFKAPC);
			SpriteButtonListener.Instance.ScreenLockedByNative = false;
			MMECEKFKAPC = 0;
			AJJAPHGCFDD = false;
		}
	}

	public virtual void KAMLFGLNNNE()
	{
		if (BINDEBHMEJC == null)
		{
			BINDEBHMEJC = new PHHKFLHAFHG();
		}
	}

	public virtual string KNLPPACLPOJ()
	{
		return LDFDEIEJCOF;
	}

	public abstract void OGNENMNMAIN(string FCEEGNFABAF, string OEFCOJLNCKP, string NIIMJJEBHCA, string LNCBFPEKHDJ);

	public abstract void JNOCJCGINCB();

	public abstract bool KJNBMEGHDGE();

	public abstract bool GFMLBLFOHDG();

	public abstract bool KPBDKDPAKBC();

	public abstract void NJJBJKCPJLA(string HHIHHPHCEJG);

	public abstract void EFBEHJNKFCD(string FCEEGNFABAF, string HOMONAAFMFH, string LDHECNOPBNK, string ICPIDDPDMKP, string KMJJAKAMOKO, string OELLFNCIJFH, string KGKGAEMGFIF);

	public abstract void NKPAGBPCFMI();

	public abstract void LMGDDIIJMHF(string IKNCPEPOKGJ, Action<string> CMACNIMFJHP);

	public abstract void EGGICLINDJH(string IKNCPEPOKGJ, string EDDNOJDPMCF);

	public virtual LEJICLFDBAJ BEEIBDODHCD()
	{
		return default(LEJICLFDBAJ);
	}

	[CompilerGenerated]
	private void IJGFJMCACHN()
	{
		if (MMECEKFKAPC == 0)
		{
			MMECEKFKAPC = DialogLibrary.GABGKBAKHDP.DialogBackground.sortingLayerID;
		}
		SpriteButtonListener.Instance.ScreenLockedByNative = true;
		DialogLibrary.GABGKBAKHDP.DialogBackground.sortingLayerID = SortingLayer.NameToID("LoadingScreen");
		DialogLibrary.GABGKBAKHDP.ShowDialogBackground(false, 0f);
		OGNENMNMAIN(NKILHODNBDE.GHBGCADFLFB("Update"), NKILHODNBDE.GHBGCADFLFB("ForceUpdateMessage"), NKILHODNBDE.GHBGCADFLFB("Update"), MCJHHDACJBG.OLCJMEAHEHG);
	}
}
