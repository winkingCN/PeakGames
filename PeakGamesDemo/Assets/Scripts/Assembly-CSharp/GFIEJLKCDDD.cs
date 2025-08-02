using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using DG.Tweening;
using UnityEngine;

public class GFIEJLKCDDD : OOHGOOPDAEM
{
	public static GFIEJLKCDDD GABGKBAKHDP;

	private MapTutorial LEKALPMFCAC;

	private readonly MapManager EOAFFMPJHAG;

	private int OPEPLALICHN = -1;

	private LLCJMMBBLEH IODLNANAMEA;

	private LLCJMMBBLEH HDCALDEILHJ;

	private int HCGHKOOFNOO;

	private bool ABEMBLFHCMN = true;

	private Sequence JIEEDECENPC;

	[CompilerGenerated]
	private static Action EBCOMJBLIPP;

	public GFIEJLKCDDD(MapManager GCONMABJKBG, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "SocialTutorialAnimation";
		EOAFFMPJHAG = GCONMABJKBG;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (MapTutorial.ShouldDisplaySocialTutorial())
		{
			if (GABGKBAKHDP == null)
			{
				GABGKBAKHDP = this;
			}
			EOAFFMPJHAG.CurrentSocialHelper.StartSocialHelper();
			GNKFLPGAPKK(0);
			IODLNANAMEA = new LLCJMMBBLEH(BPMACAJKBFF());
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	private IEnumerator PCACFMDDDKE()
	{
		while (JHOAHCHHBCH.CCAJIIFJPFF())
		{
			yield return MCJHHDACJBG.IONDKKIFPHN;
		}
		NDAIFGNIADD(false);
	}

	private IEnumerator BPMACAJKBFF()
	{
		yield return null;
		while (true)
		{
			if (EOAFFMPJHAG.CurrentSocialHelper != null)
			{
				EIPCLBONPLC currentSession = EOAFFMPJHAG.CurrentSocialHelper.CurrentSession;
				if (currentSession != null && currentSession.COPDAKACHFM != null)
				{
					break;
				}
			}
			yield return MCJHHDACJBG.CNDGGNLKOOC;
		}
		LEKALPMFCAC.Remove(true);
		LEKALPMFCAC = null;
		MapTutorial.CompleteSocialTutorial();
		MPLMHLCAEEN();
		if (OPEPLALICHN == 1)
		{
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesConnectedContainer, "Map", -500, 0);
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesNotConnectedContainer, "Map", -500, 0);
		}
		else if (OPEPLALICHN == 2 && EKGLBJJKNBG.GABGKBAKHDP.NMPOABLCDAC())
		{
			EOAFFMPJHAG.CurrentContainerManager.FocusSocial(false);
			EOAFFMPJHAG.ShowTopPanelBlocker(false);
			EOAFFMPJHAG.CurrentSwipeManager.enabled = true;
			GABGKBAKHDP = null;
		}
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}

	public void NDAIFGNIADD(bool HHLHIPKJHCJ = true)
	{
		ABEMBLFHCMN = HHLHIPKJHCJ;
		GNKFLPGAPKK(3);
	}

	public void GNKFLPGAPKK(int JNALIOOEDNJ)
	{
		if (JNALIOOEDNJ <= OPEPLALICHN)
		{
			return;
		}
		int oPEPLALICHN = OPEPLALICHN;
		OPEPLALICHN = JNALIOOEDNJ;
		if (OPEPLALICHN == 0)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GameObject gameObject = UnityEngine.Object.Instantiate(EOAFFMPJHAG.MapTutorialReference);
			LEKALPMFCAC = gameObject.GetComponent<MapTutorial>();
			LEKALPMFCAC.Init(NKILHODNBDE.GHBGCADFLFB("Tutorial_Social"), Vector3.zero, delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			});
			JIEEDECENPC = DOTween.Sequence();
			JIEEDECENPC.InsertCallback(0.49f, delegate
			{
				if (LEKALPMFCAC == null)
				{
					JIEEDECENPC.Kill();
				}
				LEKALPMFCAC.FadeInBackground();
				Vector3 position2 = EOAFFMPJHAG.LivesTabButton.position;
				position2.y += 1.7f;
				position2.x -= 0.05f;
				LEKALPMFCAC.ShowArrow(position2, -180f);
			});
			JIEEDECENPC.InsertCallback(0.5f, delegate
			{
				if (LEKALPMFCAC == null)
				{
					JIEEDECENPC.Kill();
				}
				Vector3 position = EOAFFMPJHAG.LivesTabButton.position;
				position.y += 5.63f;
				position.x = 0f;
				LEKALPMFCAC.MessagePanel.transform.position = position;
				LEKALPMFCAC.ShowDialog(false);
				GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesTabButton, "UI", 500, -8);
				Vector3 localPosition = EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition;
				Vector3 localPosition2 = EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition;
				localPosition.y = 0f;
				localPosition2.y = 0f;
				EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition = localPosition;
				EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition = localPosition2;
				HCGHKOOFNOO = 500;
			});
		}
		else if (OPEPLALICHN == 1)
		{
			LEKALPMFCAC.MessagePanel.SetActive(false);
			LEKALPMFCAC.UpArrow.SetActive(false);
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesConnectedContainer, "UI", 500, -10);
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesNotConnectedContainer, "UI", 500, -10);
			MPLMHLCAEEN();
			new LLCJMMBBLEH(JPGBDJDHICB(), true);
		}
		else if (OPEPLALICHN == 2)
		{
			IODLNANAMEA.BPPFBMCJOAH();
			IODLNANAMEA = null;
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesConnectedContainer, "Map", -500, 0);
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesNotConnectedContainer, "Map", -500, 0);
			LEKALPMFCAC.Remove(true);
			LEKALPMFCAC = null;
			if (EKGLBJJKNBG.GABGKBAKHDP.NMPOABLCDAC())
			{
				if (!JHOAHCHHBCH.CCAJIIFJPFF())
				{
					GABGKBAKHDP = null;
					if (CECMINAKHFJ != null)
					{
						CECMINAKHFJ(true);
					}
				}
				else
				{
					EOAFFMPJHAG.CurrentContainerManager.FocusSocial(true);
					EOAFFMPJHAG.ShowTopPanelBlocker(true);
					EOAFFMPJHAG.CurrentSwipeManager.enabled = false;
					HDCALDEILHJ = new LLCJMMBBLEH(PCACFMDDDKE());
				}
			}
			else
			{
				GABGKBAKHDP = null;
				MapTutorial.CompleteSocialTutorial();
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			}
		}
		else if (OPEPLALICHN == 3 && GABGKBAKHDP != null)
		{
			if (oPEPLALICHN != 2)
			{
				MAPJDGAGFHA(oPEPLALICHN);
			}
			if (IODLNANAMEA != null)
			{
				IODLNANAMEA.BPPFBMCJOAH();
			}
			if (HDCALDEILHJ != null)
			{
				HDCALDEILHJ.BPPFBMCJOAH();
			}
			if (ABEMBLFHCMN)
			{
				MapTutorial.CompleteSocialTutorial();
			}
			EOAFFMPJHAG.CurrentContainerManager.FocusSocial(false);
			EOAFFMPJHAG.ShowTopPanelBlocker(false);
			EOAFFMPJHAG.CurrentSwipeManager.enabled = true;
			GABGKBAKHDP = null;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		}
	}

	private void MAPJDGAGFHA(int BGEDKGLJIGM)
	{
		if (JIEEDECENPC != null)
		{
			JIEEDECENPC.Kill();
		}
		LEKALPMFCAC.Remove(true);
		LEKALPMFCAC = null;
		MPLMHLCAEEN();
		if (BGEDKGLJIGM == 1)
		{
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesConnectedContainer, "Map", -500, 0);
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesNotConnectedContainer, "Map", -500, 0);
		}
		else if (OPEPLALICHN == 2 && EKGLBJJKNBG.GABGKBAKHDP.NMPOABLCDAC())
		{
			EOAFFMPJHAG.CurrentContainerManager.FocusSocial(false);
			EOAFFMPJHAG.ShowTopPanelBlocker(false);
			EOAFFMPJHAG.CurrentSwipeManager.enabled = true;
			GABGKBAKHDP = null;
		}
	}

	private void MPLMHLCAEEN()
	{
		if (HCGHKOOFNOO == 500)
		{
			HCGHKOOFNOO = 0;
			GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesTabButton, "UI", -500, 0);
			Vector3 localPosition = EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition;
			Vector3 localPosition2 = EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition;
			localPosition.y = -0.018f;
			localPosition2.y = -0.018f;
			EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition = localPosition;
			EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition = localPosition2;
		}
	}

	private IEnumerator JPGBDJDHICB()
	{
		yield return new WaitForSeconds(3f);
		if (!(LEKALPMFCAC == null))
		{
			Vector3 position = ((!EOAFFMPJHAG.LivesConnectedContainer.gameObject.activeSelf) ? EOAFFMPJHAG.LivesNotConnectedButtonPos.position : EOAFFMPJHAG.LivesConnectedButtonPos.position);
			position.x -= 10f;
			position.y -= 0.1f;
			LEKALPMFCAC.ShowArrow(Vector3.zero, -90f, -0.2f);
			LEKALPMFCAC.ArrowContainer.transform.position = position;
			LEKALPMFCAC.ArrowContainer.DOMoveX(position.x + 6.3f, 0.6f);
			yield return null;
		}
	}

	[CompilerGenerated]
	private static void BHHCBGGDNHF()
	{
		SpriteButtonListener.Instance.EnableClicks = false;
	}

	[CompilerGenerated]
	private void CMLENANEKNE()
	{
		if (LEKALPMFCAC == null)
		{
			JIEEDECENPC.Kill();
		}
		LEKALPMFCAC.FadeInBackground();
		Vector3 position = EOAFFMPJHAG.LivesTabButton.position;
		position.y += 1.7f;
		position.x -= 0.05f;
		LEKALPMFCAC.ShowArrow(position, -180f);
	}

	[CompilerGenerated]
	private void JLBJAFIBOGH()
	{
		if (LEKALPMFCAC == null)
		{
			JIEEDECENPC.Kill();
		}
		Vector3 position = EOAFFMPJHAG.LivesTabButton.position;
		position.y += 5.63f;
		position.x = 0f;
		LEKALPMFCAC.MessagePanel.transform.position = position;
		LEKALPMFCAC.ShowDialog(false);
		GFFMFGMCOBP.KMHPJHNHCLG(EOAFFMPJHAG.LivesTabButton, "UI", 500, -8);
		Vector3 localPosition = EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition;
		Vector3 localPosition2 = EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition;
		localPosition.y = 0f;
		localPosition2.y = 0f;
		EOAFFMPJHAG.LivesTabButtonBackLeft.transform.localPosition = localPosition;
		EOAFFMPJHAG.LivesTabButtonBackRight.transform.localPosition = localPosition2;
		HCGHKOOFNOO = 500;
	}
}
