using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class BoosterUseBackgroundPanel : MonoBehaviour
{
	public SpriteRenderer TopPanel;

	public SpriteRenderer CenterPanel;

	public SpriteRenderer BottomPanel;

	public CameraSizer CameraSizer;

	public GameObject InfoPanel;

	public Transform JapaneseSunContainer;

	public SpriteRenderer BoosterImage;

	public TextMeshPro BoosterName;

	public TextMeshPro BoosterDescription;

	private bool PINNPENEGJO;

	private float BFLCMBHFFMC;

	private float DBICBDMPOHM;

	private Tweener GHOFOJDFEHL;

	private Tweener ONFKJINMDMJ;

	private const float DKBDDGLIJNE = 3.1666675f;

	private const float PNGIKACEDCE = 1.7272f;

	public void Start()
	{
		InfoPanel.SetActive(false);
		Vector3 localPosition = InfoPanel.transform.localPosition;
		localPosition.y = 4f;
		InfoPanel.transform.localPosition = localPosition;
		UpdatePanel();
	}

	public void UpdatePanel()
	{
		float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
		float num = 3.1666675f * CameraSizer.TopPanel.transform.localScale.y;
		float num2 = 1.7272f * CameraSizer.BottomPanel.transform.localScale.y;
		float y = ONCMBJKLKIL.FHAMOHDEGMK - (num + num2);
		CenterPanel.gameObject.transform.position = CameraSizer.CenterPanel.transform.position;
		CenterPanel.gameObject.transform.localScale = new Vector3(eMFKAPJMDCC, y, 0f);
		TopPanel.color = new Color(0f, 0f, 0f, 0f);
		CenterPanel.color = new Color(0f, 0f, 0f, 0f);
		BottomPanel.color = new Color(0f, 0f, 0f, 0f);
	}

	public void Show(NAAHKHPBAPA HBBIFNLDKPO)
	{
		if (PINNPENEGJO || !TutorialManager.ShowBoosterPanel)
		{
			return;
		}
		PINNPENEGJO = true;
		InfoPanel.SetActive(true);
		BoosterImage.transform.localScale = Vector3.one * 1.5f;
		BoosterImage.transform.localPosition = new Vector3(-3.18f, -0.06f, 0f);
		Quaternion quaternion = default(Quaternion);
		quaternion.eulerAngles = new Vector3(0f, 0f, 0f);
		Quaternion rotation = quaternion;
		BoosterImage.transform.rotation = rotation;
		BoosterImage.sprite = SharedImageLibrary.Instance.GetSpriteByInventoryType(HBBIFNLDKPO);
		string text = string.Empty;
		string text2 = string.Empty;
		switch (HBBIFNLDKPO)
		{
		case NAAHKHPBAPA.Anvil:
			text = NKILHODNBDE.GHBGCADFLFB("Anvil");
			text2 = NKILHODNBDE.GHBGCADFLFB("AnvilExp");
			BoosterImage.transform.localPosition = new Vector3(-3.004f, -0.04f, 0f);
			BoosterImage.transform.localScale = Vector3.one * 1.145154f;
			break;
		case NAAHKHPBAPA.BoxingGlove:
			text = NKILHODNBDE.GHBGCADFLFB("BoxingGlove");
			text2 = NKILHODNBDE.GHBGCADFLFB("BoxingGloveExp");
			break;
		case NAAHKHPBAPA.Hammer:
		{
			text = NKILHODNBDE.GHBGCADFLFB("Hammer");
			text2 = NKILHODNBDE.GHBGCADFLFB("HammerExp");
			BoosterImage.transform.localScale = Vector3.one * 1.08f;
			Quaternion rotation2 = default(Quaternion);
			rotation2.eulerAngles = new Vector3(0f, 0f, 22.48f);
			BoosterImage.transform.rotation = rotation2;
			BoosterImage.sprite = SharedImageLibrary.Instance.Hammer;
			BoosterImage.transform.localPosition = new Vector3(-3.152f, 0.096f, 0f);
			break;
		}
		case NAAHKHPBAPA.Dice:
			text = NKILHODNBDE.GHBGCADFLFB("Shuffle");
			text2 = NKILHODNBDE.GHBGCADFLFB("ShuffleExp");
			BoosterImage.transform.localScale = new Vector3(-1f, 1f, 1f);
			break;
		case NAAHKHPBAPA.PaintBrush:
			text = "Paint Brush";
			text2 = "Tap any color cubes to change their color!";
			break;
		}
		BoosterName.FCJBBPHFNPJ = text;
		BoosterDescription.FCJBBPHFNPJ = text2;
		JapaneseSunContainer.DOLocalRotate(new Vector3(0f, 0f, -90f), 4f, RotateMode.LocalAxisAdd).SetLoops(1000, LoopType.Incremental).SetEase(Ease.Linear);
		if (ONFKJINMDMJ != null)
		{
			ONFKJINMDMJ.Kill();
		}
		float endValue = -0.011f;
		if (ONCMBJKLKIL.GNGIGAPBFCN.ECLBGPBLGMD > 0f)
		{
			endValue = (0f - ONCMBJKLKIL.GNGIGAPBFCN.ECLBGPBLGMD - 0.7868268f) / 10f;
		}
		ONFKJINMDMJ = InfoPanel.transform.DOLocalMoveY(endValue, 0.4f).SetEase(Ease.OutBack).OnComplete(delegate
		{
			ONFKJINMDMJ = null;
		});
		ONFKJINMDMJ.easeOvershootOrAmplitude = 1f;
		if (TutorialManager.ShowBoosterPanel)
		{
			TopPanel.gameObject.SetActive(true);
			CenterPanel.gameObject.SetActive(true);
			BottomPanel.gameObject.SetActive(true);
			if (GHOFOJDFEHL != null)
			{
				GHOFOJDFEHL.Kill();
			}
			GHOFOJDFEHL = DOVirtual.Float(BFLCMBHFFMC, 0.8f, 0.2f, delegate(float KBKMPEOMABI)
			{
				BFLCMBHFFMC = KBKMPEOMABI;
				ACKLHMHBLLA();
			}).OnComplete(delegate
			{
				GHOFOJDFEHL = null;
			});
		}
	}

	public void Hide()
	{
		if (PINNPENEGJO)
		{
			PINNPENEGJO = false;
			if (ONFKJINMDMJ != null)
			{
				ONFKJINMDMJ.Kill();
			}
			ONFKJINMDMJ = InfoPanel.transform.DOLocalMoveY(4.3f, 0.2f).OnComplete(delegate
			{
				InfoPanel.SetActive(false);
				ONFKJINMDMJ = null;
			});
			if (GHOFOJDFEHL != null)
			{
				GHOFOJDFEHL.Kill();
			}
			GHOFOJDFEHL = DOVirtual.Float(BFLCMBHFFMC, 0f, 0.2f, delegate(float KBKMPEOMABI)
			{
				BFLCMBHFFMC = KBKMPEOMABI;
				ACKLHMHBLLA();
			}).OnComplete(delegate
			{
				TopPanel.gameObject.SetActive(false);
				CenterPanel.gameObject.SetActive(false);
				BottomPanel.gameObject.SetActive(false);
				GHOFOJDFEHL = null;
			});
		}
	}

	private void ACKLHMHBLLA()
	{
		Color color = new Color(0f, 0f, 0f, BFLCMBHFFMC);
		TopPanel.color = color;
		CenterPanel.color = color;
		BottomPanel.color = color;
	}

	[CompilerGenerated]
	private void DBHFFLLHHCJ()
	{
		ONFKJINMDMJ = null;
	}

	[CompilerGenerated]
	private void LPHGJDNCOIO(float KBKMPEOMABI)
	{
		BFLCMBHFFMC = KBKMPEOMABI;
		ACKLHMHBLLA();
	}

	[CompilerGenerated]
	private void HKOBBBCBPKM()
	{
		GHOFOJDFEHL = null;
	}

	[CompilerGenerated]
	private void AAJHJHAIDDC()
	{
		InfoPanel.SetActive(false);
		ONFKJINMDMJ = null;
	}

	[CompilerGenerated]
	private void ANACGCGCDGA(float KBKMPEOMABI)
	{
		BFLCMBHFFMC = KBKMPEOMABI;
		ACKLHMHBLLA();
	}

	[CompilerGenerated]
	private void HJBHIPOMBCB()
	{
		TopPanel.gameObject.SetActive(false);
		CenterPanel.gameObject.SetActive(false);
		BottomPanel.gameObject.SetActive(false);
		GHOFOJDFEHL = null;
	}
}
