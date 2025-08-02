using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using ToonSocial.ui.joined;
using UnityEngine;

public class ChatScrollTest : MonoBehaviour
{
	public ChatScrollController CurrentChatScrollController;

	public ChatEntry HelpEntry;

	private List<ChatEntry> MDIMEPHMPLD;

	public void Start()
	{
		MDIMEPHMPLD = new List<ChatEntry>();
		CurrentChatScrollController.SetVisiblePos(7f, -7f);
	}

	public void OnAddClick()
	{
		ChatEntry component = Object.Instantiate(HelpEntry).GetComponent<ChatEntry>();
		MDIMEPHMPLD.Add(component);
		CurrentChatScrollController.AddContent(component);
	}

	public void OnRemoveFirstClick()
	{
		HACHOMKGFOE(0);
	}

	public void OnRemoveLastClick()
	{
		HACHOMKGFOE(MDIMEPHMPLD.Count - 1);
	}

	public void OnRemoveMidClick()
	{
		float num = (float)MDIMEPHMPLD.Count * 0.5f;
		HACHOMKGFOE((int)num);
	}

	private void HACHOMKGFOE(int EHJNMODJEAN)
	{
		if (EHJNMODJEAN >= 0)
		{
			ChatEntry eJCNAJOHBFI = MDIMEPHMPLD[EHJNMODJEAN];
			MDIMEPHMPLD.RemoveAt(EHJNMODJEAN);
			CurrentChatScrollController.RemoveContent(eJCNAJOHBFI);
		}
	}
}
