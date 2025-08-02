using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TMPro
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/TMP Dropdown", 35)]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler, IEventSystemHandler
	{
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler, IEventSystemHandler
		{
			[SerializeField]
			private TMP_Text m_Text;

			[SerializeField]
			private Image m_Image;

			[SerializeField]
			private RectTransform m_RectTransform;

			[SerializeField]
			private Toggle m_Toggle;

			public TMP_Text FCJBBPHFNPJ
			{
				get
				{
					return m_Text;
				}
				set
				{
					m_Text = value;
				}
			}

			public Image BJBFPCKKOLM
			{
				get
				{
					return m_Image;
				}
				set
				{
					m_Image = value;
				}
			}

			public RectTransform GPPKOGCLKPL
			{
				get
				{
					return m_RectTransform;
				}
				set
				{
					m_RectTransform = value;
				}
			}

			public Toggle NJILCPLMEAN
			{
				get
				{
					return m_Toggle;
				}
				set
				{
					m_Toggle = value;
				}
			}

			public virtual void OnPointerEnter(PointerEventData HMIFPEJKHHH)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}

			public virtual void OnCancel(BaseEventData HMIFPEJKHHH)
			{
				TMP_Dropdown componentInParent = GetComponentInParent<TMP_Dropdown>();
				if ((bool)componentInParent)
				{
					componentInParent.Hide();
				}
			}
		}

		[Serializable]
		public class OptionData
		{
			[SerializeField]
			private string m_Text;

			[SerializeField]
			private Sprite m_Image;

			public string text
			{
				get
				{
					return m_Text;
				}
				set
				{
					m_Text = value;
				}
			}

			public Sprite image
			{
				get
				{
					return m_Image;
				}
				set
				{
					m_Image = value;
				}
			}

			public OptionData()
			{
			}

			public OptionData(string FCJBBPHFNPJ)
			{
				text = FCJBBPHFNPJ;
			}

			public OptionData(Sprite BJBFPCKKOLM)
			{
				image = BJBFPCKKOLM;
			}

			public OptionData(string FCJBBPHFNPJ, Sprite BJBFPCKKOLM)
			{
				text = FCJBBPHFNPJ;
				image = BJBFPCKKOLM;
			}
		}

		[Serializable]
		public class OptionDataList
		{
			[SerializeField]
			private List<OptionData> m_Options;

			public List<OptionData> options
			{
				get
				{
					return m_Options;
				}
				set
				{
					m_Options = value;
				}
			}

			public OptionDataList()
			{
				options = new List<OptionData>();
			}
		}

		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
		}

		[CompilerGenerated]
		private sealed class KKENJKMDBDJ
		{
			internal DropdownItem EJCNAJOHBFI;

			internal TMP_Dropdown PDAPIGLEPGC;

			internal void AGFNGEFDHLA(bool AMFCENFNAJJ)
			{
				PDAPIGLEPGC.MICJAIJHKCJ(EJCNAJOHBFI.NJILCPLMEAN);
			}
		}

		[SerializeField]
		private RectTransform m_Template;

		[SerializeField]
		private TMP_Text m_CaptionText;

		[SerializeField]
		private Image m_CaptionImage;

		[SerializeField]
		[Space]
		private TMP_Text m_ItemText;

		[SerializeField]
		private Image m_ItemImage;

		[Space]
		[SerializeField]
		private int m_Value;

		[SerializeField]
		[Space]
		private OptionDataList m_Options = new OptionDataList();

		[Space]
		[SerializeField]
		private DropdownEvent m_OnValueChanged = new DropdownEvent();

		private GameObject MOJKOIJFDBA;

		private GameObject GJBLJEEGIFI;

		private List<DropdownItem> FBHILFNMKGD = new List<DropdownItem>();

		private global::EHDCMENJODE<DOKFANOLIBM> INLBPIFMFLA;

		private bool NGJJLMMFELN;

		private static OptionData DDIMJIJMGIB = new OptionData();

		public RectTransform JCMDGEAEHGI
		{
			get
			{
				return m_Template;
			}
			set
			{
				m_Template = value;
				RefreshShownValue();
			}
		}

		public TMP_Text OHEIHGHJAHJ
		{
			get
			{
				return m_CaptionText;
			}
			set
			{
				m_CaptionText = value;
				RefreshShownValue();
			}
		}

		public Image AFIADIJLAJF
		{
			get
			{
				return m_CaptionImage;
			}
			set
			{
				m_CaptionImage = value;
				RefreshShownValue();
			}
		}

		public TMP_Text HIBHDHGFNKP
		{
			get
			{
				return m_ItemText;
			}
			set
			{
				m_ItemText = value;
				RefreshShownValue();
			}
		}

		public Image KNOKODLAFDB
		{
			get
			{
				return m_ItemImage;
			}
			set
			{
				m_ItemImage = value;
				RefreshShownValue();
			}
		}

		public List<OptionData> ONFGHNCDFKO
		{
			get
			{
				return m_Options.options;
			}
			set
			{
				m_Options.options = value;
				RefreshShownValue();
			}
		}

		public DropdownEvent DMIIPGENFFL
		{
			get
			{
				return m_OnValueChanged;
			}
			set
			{
				m_OnValueChanged = value;
			}
		}

		public int EDDNOJDPMCF
		{
			get
			{
				return m_Value;
			}
			set
			{
				if (!Application.isPlaying || (value != m_Value && ONFGHNCDFKO.Count != 0))
				{
					m_Value = Mathf.Clamp(value, 0, ONFGHNCDFKO.Count - 1);
					RefreshShownValue();
					m_OnValueChanged.Invoke(m_Value);
				}
			}
		}

		public bool NBNKLEGGGAL
		{
			get
			{
				return MOJKOIJFDBA != null;
			}
		}

		protected TMP_Dropdown()
		{
		}

		protected override void Awake()
		{
			INLBPIFMFLA = new global::EHDCMENJODE<DOKFANOLIBM>();
			INLBPIFMFLA.DIOELAHNLKJ(this);
			if ((bool)m_CaptionImage)
			{
				m_CaptionImage.enabled = m_CaptionImage.sprite != null;
			}
			if ((bool)m_Template)
			{
				m_Template.gameObject.SetActive(false);
			}
		}

		public void RefreshShownValue()
		{
			OptionData optionData = DDIMJIJMGIB;
			if (ONFGHNCDFKO.Count > 0)
			{
				optionData = ONFGHNCDFKO[Mathf.Clamp(m_Value, 0, ONFGHNCDFKO.Count - 1)];
			}
			if ((bool)m_CaptionText)
			{
				if (optionData != null && optionData.text != null)
				{
					m_CaptionText.FCJBBPHFNPJ = optionData.text;
				}
				else
				{
					m_CaptionText.FCJBBPHFNPJ = string.Empty;
				}
			}
			if ((bool)m_CaptionImage)
			{
				if (optionData != null)
				{
					m_CaptionImage.sprite = optionData.image;
				}
				else
				{
					m_CaptionImage.sprite = null;
				}
				m_CaptionImage.enabled = m_CaptionImage.sprite != null;
			}
		}

		public void AddOptions(List<OptionData> ONFGHNCDFKO)
		{
			this.ONFGHNCDFKO.AddRange(ONFGHNCDFKO);
			RefreshShownValue();
		}

		public void AddOptions(List<string> ONFGHNCDFKO)
		{
			for (int i = 0; i < ONFGHNCDFKO.Count; i++)
			{
				this.ONFGHNCDFKO.Add(new OptionData(ONFGHNCDFKO[i]));
			}
			RefreshShownValue();
		}

		public void AddOptions(List<Sprite> ONFGHNCDFKO)
		{
			for (int i = 0; i < ONFGHNCDFKO.Count; i++)
			{
				this.ONFGHNCDFKO.Add(new OptionData(ONFGHNCDFKO[i]));
			}
			RefreshShownValue();
		}

		public void ClearOptions()
		{
			ONFGHNCDFKO.Clear();
			RefreshShownValue();
		}

		private void LMGCFFBIELH()
		{
			NGJJLMMFELN = false;
			if (!m_Template)
			{
				Debug.LogError("The dropdown template is not assigned. The template needs to be assigned and must have a child GameObject with a Toggle component serving as the item.", this);
				return;
			}
			GameObject gameObject = m_Template.gameObject;
			gameObject.SetActive(true);
			Toggle componentInChildren = m_Template.GetComponentInChildren<Toggle>();
			NGJJLMMFELN = true;
			if (!componentInChildren || componentInChildren.transform == JCMDGEAEHGI)
			{
				NGJJLMMFELN = false;
				Debug.LogError("The dropdown template is not valid. The template must have a child GameObject with a Toggle component serving as the item.", JCMDGEAEHGI);
			}
			else if (!(componentInChildren.transform.parent is RectTransform))
			{
				NGJJLMMFELN = false;
				Debug.LogError("The dropdown template is not valid. The child GameObject with a Toggle component (the item) must have a RectTransform on its parent.", JCMDGEAEHGI);
			}
			else if (HIBHDHGFNKP != null && !HIBHDHGFNKP.ANLKLKAINEO.IsChildOf(componentInChildren.transform))
			{
				NGJJLMMFELN = false;
				Debug.LogError("The dropdown template is not valid. The Item Text must be on the item GameObject or children of it.", JCMDGEAEHGI);
			}
			else if (KNOKODLAFDB != null && !KNOKODLAFDB.transform.IsChildOf(componentInChildren.transform))
			{
				NGJJLMMFELN = false;
				Debug.LogError("The dropdown template is not valid. The Item Image must be on the item GameObject or children of it.", JCMDGEAEHGI);
			}
			if (!NGJJLMMFELN)
			{
				gameObject.SetActive(false);
				return;
			}
			DropdownItem dropdownItem = componentInChildren.gameObject.AddComponent<DropdownItem>();
			dropdownItem.FCJBBPHFNPJ = m_ItemText;
			dropdownItem.BJBFPCKKOLM = m_ItemImage;
			dropdownItem.NJILCPLMEAN = componentInChildren;
			dropdownItem.GPPKOGCLKPL = (RectTransform)componentInChildren.transform;
			Canvas canvas = GMNMKAKIIDE<Canvas>(gameObject);
			canvas.overrideSorting = true;
			canvas.sortingOrder = 30000;
			GMNMKAKIIDE<GraphicRaycaster>(gameObject);
			GMNMKAKIIDE<CanvasGroup>(gameObject);
			gameObject.SetActive(false);
			NGJJLMMFELN = true;
		}

		private static T GMNMKAKIIDE<T>(GameObject LGDFKAMHKFM) where T : Component
		{
			T val = LGDFKAMHKFM.GetComponent<T>();
			if (!val)
			{
				val = LGDFKAMHKFM.AddComponent<T>();
			}
			return val;
		}

		public virtual void OnPointerClick(PointerEventData HMIFPEJKHHH)
		{
			Show();
		}

		public virtual void OnSubmit(BaseEventData HMIFPEJKHHH)
		{
			Show();
		}

		public virtual void OnCancel(BaseEventData HMIFPEJKHHH)
		{
			Hide();
		}

		public void Show()
		{
			if (!IsActive() || !IsInteractable() || MOJKOIJFDBA != null)
			{
				return;
			}
			if (!NGJJLMMFELN)
			{
				LMGCFFBIELH();
				if (!NGJJLMMFELN)
				{
					return;
				}
			}
			List<Canvas> list = global::MNGOLNKCDBE<Canvas>.GHBGCADFLFB();
			base.gameObject.GetComponentsInParent(false, list);
			if (list.Count == 0)
			{
				return;
			}
			Canvas canvas = list[0];
			global::MNGOLNKCDBE<Canvas>.PNCNHFLJCIG(list);
			m_Template.gameObject.SetActive(true);
			MOJKOIJFDBA = KNIJNHOJCAI(m_Template.gameObject);
			MOJKOIJFDBA.name = "Dropdown List";
			MOJKOIJFDBA.SetActive(true);
			RectTransform rectTransform = MOJKOIJFDBA.transform as RectTransform;
			rectTransform.SetParent(m_Template.transform.parent, false);
			DropdownItem componentInChildren = MOJKOIJFDBA.GetComponentInChildren<DropdownItem>();
			GameObject gameObject = componentInChildren.GPPKOGCLKPL.parent.gameObject;
			RectTransform rectTransform2 = gameObject.transform as RectTransform;
			componentInChildren.GPPKOGCLKPL.gameObject.SetActive(true);
			Rect rect = rectTransform2.rect;
			Rect rect2 = componentInChildren.GPPKOGCLKPL.rect;
			Vector2 vector = rect2.min - rect.min + (Vector2)componentInChildren.GPPKOGCLKPL.localPosition;
			Vector2 vector2 = rect2.max - rect.max + (Vector2)componentInChildren.GPPKOGCLKPL.localPosition;
			Vector2 size = rect2.size;
			FBHILFNMKGD.Clear();
			Toggle toggle = null;
			for (int i = 0; i < ONFGHNCDFKO.Count; i++)
			{
				OptionData mBBPBGHKLJM = ONFGHNCDFKO[i];
				DropdownItem EJCNAJOHBFI = MBPCNIMPMOA(mBBPBGHKLJM, EDDNOJDPMCF == i, componentInChildren, FBHILFNMKGD);
				if (!(EJCNAJOHBFI == null))
				{
					EJCNAJOHBFI.NJILCPLMEAN.isOn = EDDNOJDPMCF == i;
					EJCNAJOHBFI.NJILCPLMEAN.onValueChanged.AddListener(delegate
					{
						MICJAIJHKCJ(EJCNAJOHBFI.NJILCPLMEAN);
					});
					if (EJCNAJOHBFI.NJILCPLMEAN.isOn)
					{
						EJCNAJOHBFI.NJILCPLMEAN.Select();
					}
					if (toggle != null)
					{
						Navigation navigation = toggle.navigation;
						Navigation navigation2 = EJCNAJOHBFI.NJILCPLMEAN.navigation;
						navigation.mode = Navigation.Mode.Explicit;
						navigation2.mode = Navigation.Mode.Explicit;
						navigation.selectOnDown = EJCNAJOHBFI.NJILCPLMEAN;
						navigation.selectOnRight = EJCNAJOHBFI.NJILCPLMEAN;
						navigation2.selectOnLeft = toggle;
						navigation2.selectOnUp = toggle;
						toggle.navigation = navigation;
						EJCNAJOHBFI.NJILCPLMEAN.navigation = navigation2;
					}
					toggle = EJCNAJOHBFI.NJILCPLMEAN;
				}
			}
			Vector2 sizeDelta = rectTransform2.sizeDelta;
			sizeDelta.y = size.y * (float)FBHILFNMKGD.Count + vector.y - vector2.y;
			rectTransform2.sizeDelta = sizeDelta;
			float num = rectTransform.rect.height - rectTransform2.rect.height;
			if (num > 0f)
			{
				rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y - num);
			}
			Vector3[] array = new Vector3[4];
			rectTransform.GetWorldCorners(array);
			RectTransform rectTransform3 = canvas.transform as RectTransform;
			Rect rect3 = rectTransform3.rect;
			for (int j = 0; j < 2; j++)
			{
				bool flag = false;
				for (int k = 0; k < 4; k++)
				{
					Vector3 vector3 = rectTransform3.InverseTransformPoint(array[k]);
					if (vector3[j] < rect3.min[j] || vector3[j] > rect3.max[j])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					RectTransformUtility.FlipLayoutOnAxis(rectTransform, j, false, false);
				}
			}
			for (int l = 0; l < FBHILFNMKGD.Count; l++)
			{
				RectTransform rectTransform4 = FBHILFNMKGD[l].GPPKOGCLKPL;
				rectTransform4.anchorMin = new Vector2(rectTransform4.anchorMin.x, 0f);
				rectTransform4.anchorMax = new Vector2(rectTransform4.anchorMax.x, 0f);
				rectTransform4.anchoredPosition = new Vector2(rectTransform4.anchoredPosition.x, vector.y + size.y * (float)(FBHILFNMKGD.Count - 1 - l) + size.y * rectTransform4.pivot.y);
				rectTransform4.sizeDelta = new Vector2(rectTransform4.sizeDelta.x, size.y);
			}
			HGLNOGAJAHP(0.15f, 0f, 1f);
			m_Template.gameObject.SetActive(false);
			componentInChildren.gameObject.SetActive(false);
			GJBLJEEGIFI = BMAGNHEJDDD(canvas);
		}

		protected virtual GameObject BMAGNHEJDDD(Canvas OKMCFHACEPD)
		{
			GameObject gameObject = new GameObject("Blocker");
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.SetParent(OKMCFHACEPD.transform, false);
			rectTransform.anchorMin = Vector3.zero;
			rectTransform.anchorMax = Vector3.one;
			rectTransform.sizeDelta = Vector2.zero;
			Canvas canvas = gameObject.AddComponent<Canvas>();
			canvas.overrideSorting = true;
			Canvas component = MOJKOIJFDBA.GetComponent<Canvas>();
			canvas.sortingLayerID = component.sortingLayerID;
			canvas.sortingOrder = component.sortingOrder - 1;
			gameObject.AddComponent<GraphicRaycaster>();
			Image image = gameObject.AddComponent<Image>();
			image.color = Color.clear;
			Button button = gameObject.AddComponent<Button>();
			button.onClick.AddListener(Hide);
			return gameObject;
		}

		protected virtual void KHMACMEDFAD(GameObject EGJIDFIGCHN)
		{
			UnityEngine.Object.Destroy(EGJIDFIGCHN);
		}

		protected virtual GameObject KNIJNHOJCAI(GameObject JCMDGEAEHGI)
		{
			return UnityEngine.Object.Instantiate(JCMDGEAEHGI);
		}

		protected virtual void MPJGKFKAKDG(GameObject DHHAFIIKFNH)
		{
			UnityEngine.Object.Destroy(DHHAFIIKFNH);
		}

		protected virtual DropdownItem FEGNMJKKDPG(DropdownItem KABGEIAAMBD)
		{
			return UnityEngine.Object.Instantiate(KABGEIAAMBD);
		}

		protected virtual void GMKFOPLOFDN(DropdownItem EJCNAJOHBFI)
		{
		}

		private DropdownItem MBPCNIMPMOA(OptionData MBBPBGHKLJM, bool FKPEGOHFGCK, DropdownItem KABGEIAAMBD, List<DropdownItem> IEECOIONEJM)
		{
			DropdownItem dropdownItem = FEGNMJKKDPG(KABGEIAAMBD);
			dropdownItem.GPPKOGCLKPL.SetParent(KABGEIAAMBD.GPPKOGCLKPL.parent, false);
			dropdownItem.gameObject.SetActive(true);
			dropdownItem.gameObject.name = "Item " + IEECOIONEJM.Count + ((MBBPBGHKLJM.text == null) ? string.Empty : (": " + MBBPBGHKLJM.text));
			if (dropdownItem.NJILCPLMEAN != null)
			{
				dropdownItem.NJILCPLMEAN.isOn = false;
			}
			if ((bool)dropdownItem.FCJBBPHFNPJ)
			{
				dropdownItem.FCJBBPHFNPJ.FCJBBPHFNPJ = MBBPBGHKLJM.text;
			}
			if ((bool)dropdownItem.BJBFPCKKOLM)
			{
				dropdownItem.BJBFPCKKOLM.sprite = MBBPBGHKLJM.image;
				dropdownItem.BJBFPCKKOLM.enabled = dropdownItem.BJBFPCKKOLM.sprite != null;
			}
			IEECOIONEJM.Add(dropdownItem);
			return dropdownItem;
		}

		private void HGLNOGAJAHP(float FMPBJJMKCIG, float KBKMPEOMABI)
		{
			CanvasGroup component = MOJKOIJFDBA.GetComponent<CanvasGroup>();
			HGLNOGAJAHP(FMPBJJMKCIG, component.alpha, KBKMPEOMABI);
		}

		private void HGLNOGAJAHP(float FMPBJJMKCIG, float EHGOOEHDNMM, float AHPGGJALELA)
		{
			if (!AHPGGJALELA.Equals(EHGOOEHDNMM))
			{
				DOKFANOLIBM dOKFANOLIBM = default(DOKFANOLIBM);
				dOKFANOLIBM.FMPBJJMKCIG = FMPBJJMKCIG;
				dOKFANOLIBM.AHHFBLFACFD = EHGOOEHDNMM;
				dOKFANOLIBM.PMLGEJPOIEM = AHPGGJALELA;
				DOKFANOLIBM gCLINOAJKIH = dOKFANOLIBM;
				gCLINOAJKIH.MHKAGNEDHPH(DPLLKBPFMBN);
				gCLINOAJKIH.AFCNLNOBLKK = true;
				INLBPIFMFLA.CMGDHHOBKPG(gCLINOAJKIH);
			}
		}

		private void DPLLKBPFMBN(float KBKMPEOMABI)
		{
			if ((bool)MOJKOIJFDBA)
			{
				CanvasGroup component = MOJKOIJFDBA.GetComponent<CanvasGroup>();
				component.alpha = KBKMPEOMABI;
			}
		}

		public void Hide()
		{
			if (MOJKOIJFDBA != null)
			{
				HGLNOGAJAHP(0.15f, 0f);
				if (IsActive())
				{
					StartCoroutine(JCEGMILBPML(0.15f));
				}
			}
			if (GJBLJEEGIFI != null)
			{
				KHMACMEDFAD(GJBLJEEGIFI);
			}
			GJBLJEEGIFI = null;
			Select();
		}

		private IEnumerator JCEGMILBPML(float DKIPEJPGACG)
		{
			yield return new WaitForSecondsRealtime(DKIPEJPGACG);
			for (int i = 0; i < FBHILFNMKGD.Count; i++)
			{
				if (FBHILFNMKGD[i] != null)
				{
					GMKFOPLOFDN(FBHILFNMKGD[i]);
				}
				FBHILFNMKGD.Clear();
			}
			if (MOJKOIJFDBA != null)
			{
				MPJGKFKAKDG(MOJKOIJFDBA);
			}
			MOJKOIJFDBA = null;
		}

		private void MICJAIJHKCJ(Toggle NJILCPLMEAN)
		{
			if (!NJILCPLMEAN.isOn)
			{
				NJILCPLMEAN.isOn = true;
			}
			int num = -1;
			Transform transform = NJILCPLMEAN.transform;
			Transform parent = transform.parent;
			for (int i = 0; i < parent.childCount; i++)
			{
				if (parent.GetChild(i) == transform)
				{
					num = i - 1;
					break;
				}
			}
			if (num >= 0)
			{
				EDDNOJDPMCF = num;
				Hide();
			}
		}
	}
}
