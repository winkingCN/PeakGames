using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class OJCEPCLIDFO
{
	public struct BOFHILCAGPJ
	{
		public Sprite HNEKCHCDEJG;

		public Sprite MDBFIFLKPKP;

		public Sprite FEJFOKCKKAL;

		public Sprite GKINOMHIHDE;

		public Sprite DNKHKKHGGLB;

		public Sprite CEJLMBNIAKE;

		public Sprite DHJODBJPGBJ;
	}

	private const float MGHBOKKOCIA = 160f;

	private const float FFONCEGGAPN = 30f;

	private const float MAOCHIKCBEN = 20f;

	private static Vector2 ECIDFFDFBHG = new Vector2(160f, 30f);

	private static Vector2 CDODFLKJNFC = new Vector2(160f, 20f);

	private static Color IDCIKCKFMDN = new Color(1f, 1f, 1f, 1f);

	private static Color DBCNGPJPLAN = new Color(10f / 51f, 10f / 51f, 10f / 51f, 1f);

	private static GameObject GHAPFHJCPDE(string IOCMOCCFALN, Vector2 MOFHAKELNPN)
	{
		GameObject gameObject = new GameObject(IOCMOCCFALN);
		RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
		rectTransform.sizeDelta = MOFHAKELNPN;
		return gameObject;
	}

	private static GameObject EEFPDGJKJGD(string IOCMOCCFALN, GameObject LIMMFGDCLAB)
	{
		GameObject gameObject = new GameObject(IOCMOCCFALN);
		gameObject.AddComponent<RectTransform>();
		GPOPFLMFELN(gameObject, LIMMFGDCLAB);
		return gameObject;
	}

	private static void EJMIPMNDJJM(TMP_Text GLEAKAFKBKM)
	{
		GLEAKAFKBKM.color = DBCNGPJPLAN;
		GLEAKAFKBKM.DGLOHLPKABM = 14f;
	}

	private static void JLBJLKMHDCM(Selectable DPNNIJAKMHI)
	{
		ColorBlock colors = DPNNIJAKMHI.colors;
		colors.highlightedColor = new Color(0.882f, 0.882f, 0.882f);
		colors.pressedColor = new Color(0.698f, 0.698f, 0.698f);
		colors.disabledColor = new Color(0.521f, 0.521f, 0.521f);
	}

	private static void GPOPFLMFELN(GameObject MNCHGLKLBOD, GameObject LIMMFGDCLAB)
	{
		if (!(LIMMFGDCLAB == null))
		{
			MNCHGLKLBOD.transform.SetParent(LIMMFGDCLAB.transform, false);
			BDBNDCPGGKE(MNCHGLKLBOD, LIMMFGDCLAB.layer);
		}
	}

	private static void BDBNDCPGGKE(GameObject LGDFKAMHKFM, int JNMDJGFMEOE)
	{
		LGDFKAMHKFM.layer = JNMDJGFMEOE;
		Transform transform = LGDFKAMHKFM.transform;
		for (int i = 0; i < transform.childCount; i++)
		{
			BDBNDCPGGKE(transform.GetChild(i).gameObject, JNMDJGFMEOE);
		}
	}

	public static GameObject CGBOFIEFPPI(BOFHILCAGPJ JEDAGPJEOAM)
	{
		GameObject gameObject = GHAPFHJCPDE("Scrollbar", CDODFLKJNFC);
		GameObject gameObject2 = EEFPDGJKJGD("Sliding Area", gameObject);
		GameObject gameObject3 = EEFPDGJKJGD("Handle", gameObject2);
		Image image = gameObject.AddComponent<Image>();
		image.sprite = JEDAGPJEOAM.MDBFIFLKPKP;
		image.type = Image.Type.Sliced;
		image.color = IDCIKCKFMDN;
		Image image2 = gameObject3.AddComponent<Image>();
		image2.sprite = JEDAGPJEOAM.HNEKCHCDEJG;
		image2.type = Image.Type.Sliced;
		image2.color = IDCIKCKFMDN;
		RectTransform component = gameObject2.GetComponent<RectTransform>();
		component.sizeDelta = new Vector2(-20f, -20f);
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		RectTransform component2 = gameObject3.GetComponent<RectTransform>();
		component2.sizeDelta = new Vector2(20f, 20f);
		Scrollbar scrollbar = gameObject.AddComponent<Scrollbar>();
		scrollbar.handleRect = component2;
		scrollbar.targetGraphic = image2;
		JLBJLKMHDCM(scrollbar);
		return gameObject;
	}

	public static GameObject MBKBJAKFLAL(BOFHILCAGPJ JEDAGPJEOAM)
	{
		GameObject gameObject = GHAPFHJCPDE("TextMeshPro - InputField", ECIDFFDFBHG);
		GameObject gameObject2 = EEFPDGJKJGD("Text Area", gameObject);
		GameObject gameObject3 = EEFPDGJKJGD("Placeholder", gameObject2);
		GameObject gameObject4 = EEFPDGJKJGD("Text", gameObject2);
		Image image = gameObject.AddComponent<Image>();
		image.sprite = JEDAGPJEOAM.FEJFOKCKKAL;
		image.type = Image.Type.Sliced;
		image.color = IDCIKCKFMDN;
		TMP_InputField tMP_InputField = gameObject.AddComponent<TMP_InputField>();
		JLBJLKMHDCM(tMP_InputField);
		gameObject2.AddComponent<RectMask2D>();
		RectTransform component = gameObject2.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.sizeDelta = Vector2.zero;
		component.offsetMin = new Vector2(10f, 6f);
		component.offsetMax = new Vector2(-10f, -7f);
		TextMeshProUGUI textMeshProUGUI = gameObject4.AddComponent<TextMeshProUGUI>();
		textMeshProUGUI.FCJBBPHFNPJ = string.Empty;
		textMeshProUGUI.MHAGENKBNAN = false;
		textMeshProUGUI.AJLGMMOGEOC = true;
		textMeshProUGUI.DGCLMBNNONA = true;
		EJMIPMNDJJM(textMeshProUGUI);
		TextMeshProUGUI textMeshProUGUI2 = gameObject3.AddComponent<TextMeshProUGUI>();
		textMeshProUGUI2.FCJBBPHFNPJ = "Enter text...";
		textMeshProUGUI2.DGLOHLPKABM = 14f;
		textMeshProUGUI2.CMFEBDBACDI = BCIEOOJOMDO.Italic;
		textMeshProUGUI2.MHAGENKBNAN = false;
		textMeshProUGUI2.AJLGMMOGEOC = true;
		Color color = textMeshProUGUI.color;
		color.a *= 0.5f;
		textMeshProUGUI2.color = color;
		RectTransform component2 = gameObject4.GetComponent<RectTransform>();
		component2.anchorMin = Vector2.zero;
		component2.anchorMax = Vector2.one;
		component2.sizeDelta = Vector2.zero;
		component2.offsetMin = new Vector2(0f, 0f);
		component2.offsetMax = new Vector2(0f, 0f);
		RectTransform component3 = gameObject3.GetComponent<RectTransform>();
		component3.anchorMin = Vector2.zero;
		component3.anchorMax = Vector2.one;
		component3.sizeDelta = Vector2.zero;
		component3.offsetMin = new Vector2(0f, 0f);
		component3.offsetMax = new Vector2(0f, 0f);
		tMP_InputField.KLOMNOALHCH = component;
		tMP_InputField.MHFABDJOCMG = textMeshProUGUI;
		tMP_InputField.IALPAELMGPL = textMeshProUGUI2;
		tMP_InputField.PIJNMJOHBIE = textMeshProUGUI.ELKNHALJKNI;
		return gameObject;
	}

	public static GameObject CPDIAHOOEEO(BOFHILCAGPJ JEDAGPJEOAM)
	{
		GameObject gameObject = GHAPFHJCPDE("Dropdown", ECIDFFDFBHG);
		GameObject gameObject2 = EEFPDGJKJGD("Label", gameObject);
		GameObject gameObject3 = EEFPDGJKJGD("Arrow", gameObject);
		GameObject gameObject4 = EEFPDGJKJGD("Template", gameObject);
		GameObject gameObject5 = EEFPDGJKJGD("Viewport", gameObject4);
		GameObject gameObject6 = EEFPDGJKJGD("Content", gameObject5);
		GameObject gameObject7 = EEFPDGJKJGD("Item", gameObject6);
		GameObject gameObject8 = EEFPDGJKJGD("Item Background", gameObject7);
		GameObject gameObject9 = EEFPDGJKJGD("Item Checkmark", gameObject7);
		GameObject gameObject10 = EEFPDGJKJGD("Item Label", gameObject7);
		GameObject gameObject11 = CGBOFIEFPPI(JEDAGPJEOAM);
		gameObject11.name = "Scrollbar";
		GPOPFLMFELN(gameObject11, gameObject4);
		Scrollbar component = gameObject11.GetComponent<Scrollbar>();
		component.SetDirection(Scrollbar.Direction.BottomToTop, true);
		RectTransform component2 = gameObject11.GetComponent<RectTransform>();
		component2.anchorMin = Vector2.right;
		component2.anchorMax = Vector2.one;
		component2.pivot = Vector2.one;
		component2.sizeDelta = new Vector2(component2.sizeDelta.x, 0f);
		TextMeshProUGUI textMeshProUGUI = gameObject10.AddComponent<TextMeshProUGUI>();
		EJMIPMNDJJM(textMeshProUGUI);
		textMeshProUGUI.JOPPDFNGJBM = KNOECCJHIDP.Left;
		Image image = gameObject8.AddComponent<Image>();
		image.color = new Color32(245, 245, 245, byte.MaxValue);
		Image image2 = gameObject9.AddComponent<Image>();
		image2.sprite = JEDAGPJEOAM.DNKHKKHGGLB;
		Toggle toggle = gameObject7.AddComponent<Toggle>();
		toggle.targetGraphic = image;
		toggle.graphic = image2;
		toggle.isOn = true;
		Image image3 = gameObject4.AddComponent<Image>();
		image3.sprite = JEDAGPJEOAM.HNEKCHCDEJG;
		image3.type = Image.Type.Sliced;
		ScrollRect scrollRect = gameObject4.AddComponent<ScrollRect>();
		scrollRect.content = (RectTransform)gameObject6.transform;
		scrollRect.viewport = (RectTransform)gameObject5.transform;
		scrollRect.horizontal = false;
		scrollRect.movementType = ScrollRect.MovementType.Clamped;
		scrollRect.verticalScrollbar = component;
		scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
		scrollRect.verticalScrollbarSpacing = -3f;
		Mask mask = gameObject5.AddComponent<Mask>();
		mask.showMaskGraphic = false;
		Image image4 = gameObject5.AddComponent<Image>();
		image4.sprite = JEDAGPJEOAM.DHJODBJPGBJ;
		image4.type = Image.Type.Sliced;
		TextMeshProUGUI textMeshProUGUI2 = gameObject2.AddComponent<TextMeshProUGUI>();
		EJMIPMNDJJM(textMeshProUGUI2);
		textMeshProUGUI2.JOPPDFNGJBM = KNOECCJHIDP.Left;
		Image image5 = gameObject3.AddComponent<Image>();
		image5.sprite = JEDAGPJEOAM.CEJLMBNIAKE;
		Image image6 = gameObject.AddComponent<Image>();
		image6.sprite = JEDAGPJEOAM.HNEKCHCDEJG;
		image6.color = IDCIKCKFMDN;
		image6.type = Image.Type.Sliced;
		TMP_Dropdown tMP_Dropdown = gameObject.AddComponent<TMP_Dropdown>();
		tMP_Dropdown.targetGraphic = image6;
		JLBJLKMHDCM(tMP_Dropdown);
		tMP_Dropdown.JCMDGEAEHGI = gameObject4.GetComponent<RectTransform>();
		tMP_Dropdown.OHEIHGHJAHJ = textMeshProUGUI2;
		tMP_Dropdown.HIBHDHGFNKP = textMeshProUGUI;
		textMeshProUGUI.FCJBBPHFNPJ = "Option A";
		tMP_Dropdown.ONFGHNCDFKO.Add(new TMP_Dropdown.OptionData
		{
			text = "Option A"
		});
		tMP_Dropdown.ONFGHNCDFKO.Add(new TMP_Dropdown.OptionData
		{
			text = "Option B"
		});
		tMP_Dropdown.ONFGHNCDFKO.Add(new TMP_Dropdown.OptionData
		{
			text = "Option C"
		});
		tMP_Dropdown.RefreshShownValue();
		RectTransform component3 = gameObject2.GetComponent<RectTransform>();
		component3.anchorMin = Vector2.zero;
		component3.anchorMax = Vector2.one;
		component3.offsetMin = new Vector2(10f, 6f);
		component3.offsetMax = new Vector2(-25f, -7f);
		RectTransform component4 = gameObject3.GetComponent<RectTransform>();
		component4.anchorMin = new Vector2(1f, 0.5f);
		component4.anchorMax = new Vector2(1f, 0.5f);
		component4.sizeDelta = new Vector2(20f, 20f);
		component4.anchoredPosition = new Vector2(-15f, 0f);
		RectTransform component5 = gameObject4.GetComponent<RectTransform>();
		component5.anchorMin = new Vector2(0f, 0f);
		component5.anchorMax = new Vector2(1f, 0f);
		component5.pivot = new Vector2(0.5f, 1f);
		component5.anchoredPosition = new Vector2(0f, 2f);
		component5.sizeDelta = new Vector2(0f, 150f);
		RectTransform component6 = gameObject5.GetComponent<RectTransform>();
		component6.anchorMin = new Vector2(0f, 0f);
		component6.anchorMax = new Vector2(1f, 1f);
		component6.sizeDelta = new Vector2(-18f, 0f);
		component6.pivot = new Vector2(0f, 1f);
		RectTransform component7 = gameObject6.GetComponent<RectTransform>();
		component7.anchorMin = new Vector2(0f, 1f);
		component7.anchorMax = new Vector2(1f, 1f);
		component7.pivot = new Vector2(0.5f, 1f);
		component7.anchoredPosition = new Vector2(0f, 0f);
		component7.sizeDelta = new Vector2(0f, 28f);
		RectTransform component8 = gameObject7.GetComponent<RectTransform>();
		component8.anchorMin = new Vector2(0f, 0.5f);
		component8.anchorMax = new Vector2(1f, 0.5f);
		component8.sizeDelta = new Vector2(0f, 20f);
		RectTransform component9 = gameObject8.GetComponent<RectTransform>();
		component9.anchorMin = Vector2.zero;
		component9.anchorMax = Vector2.one;
		component9.sizeDelta = Vector2.zero;
		RectTransform component10 = gameObject9.GetComponent<RectTransform>();
		component10.anchorMin = new Vector2(0f, 0.5f);
		component10.anchorMax = new Vector2(0f, 0.5f);
		component10.sizeDelta = new Vector2(20f, 20f);
		component10.anchoredPosition = new Vector2(10f, 0f);
		RectTransform component11 = gameObject10.GetComponent<RectTransform>();
		component11.anchorMin = Vector2.zero;
		component11.anchorMax = Vector2.one;
		component11.offsetMin = new Vector2(20f, 1f);
		component11.offsetMax = new Vector2(-10f, -2f);
		gameObject4.SetActive(false);
		return gameObject;
	}
}
