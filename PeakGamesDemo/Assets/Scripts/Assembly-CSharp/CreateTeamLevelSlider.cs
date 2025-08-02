using Assets.Scripts.MapScene;
using TMPro;
using ToonSocial;
using UnityEngine;

public class CreateTeamLevelSlider : MonoBehaviour
{
	public int Level;

	public TextMeshPro LevelText;

	public SocialHelper CurrentSocialHelper;

	private LLCJMMBBLEH BCPDMNFHBHE;

	public void Awake()
	{
		LevelText.FCJBBPHFNPJ = Level.ToString();
	}

	public void IncreaseLevelUp()
	{
		JEACJNAKLDJ();
	}

	public void DecreaseLevelUp()
	{
		PDFCGEODKHI();
	}

	private void JEACJNAKLDJ()
	{
		Level += 50;
		if (Level > MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1)
		{
			Level = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			Level -= Level % 50;
			string aELPGDIJOCN = string.Format(NKILHODNBDE.GHBGCADFLFB("Error_LevelLimit"), Level + 50);
			MapManager.Instance.ShowErrorMessage(aELPGDIJOCN);
			if (Level < 0)
			{
				Level = 0;
			}
		}
		LevelText.FCJBBPHFNPJ = Level.ToString();
	}

	private void PDFCGEODKHI()
	{
		Level -= 50;
		if (Level < 0)
		{
			Level = 0;
		}
		LevelText.FCJBBPHFNPJ = Level.ToString();
	}

	public void Force(int PLCFEOMGCFK)
	{
		Level = PLCFEOMGCFK;
		LevelText.FCJBBPHFNPJ = Level.ToString();
	}
}
