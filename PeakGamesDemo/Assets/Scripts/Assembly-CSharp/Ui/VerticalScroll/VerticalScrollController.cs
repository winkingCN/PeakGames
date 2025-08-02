using System;
using System.Collections.Generic;
using Assets.Scripts.CasualTools.Dialogs;
using NewMapScene;
using UnityEngine;

namespace Ui.VerticalScroll
{
	public class VerticalScrollController : MonoBehaviour
	{
		private static HashSet<VerticalScrollController> AENMOLHMEDN;

		public float DragTreashold = 20f;

		public float StretchFactor = 0.2f;

		public float StretchOffset = 3f;

		public BoxCollider2D ScrollArea;

		public BoxCollider2D TouchArea;

		public Transform Content;

		public SwipeManager CurrentSwipeManager;

		public Camera CurrentCamera;

		public Action OnScroll;

		private SpriteButtonListener AJGEBIJJPOD;

		private Vector2 KFFLDJPKCJN;

		private Vector3 HGNBDANJJIO;

		private bool LEHBFPIIANH;

		private bool NKPKHOGBFNE;

		private bool CBBDAPJNGJB;

		private float GDACHIJEGEE;

		private float NHMLGGLPAJI;

		private float ODPGLMBMKMI;

		private float OMPPIKLPHBP;

		private float DLPAAACPGFP;

		private float EJOHOFKPECP;

		private float HFCIENBEADN;

		private float HHOFEGKGAPC;

		private float IDAPCKFGCPI = 0.5f;

		private readonly float[] OHCAFHBIEAF = new float[5];

		protected readonly List<GameObject> NDPMKJIDBOM = new List<GameObject>();

		public static void InvalidateScrolls()
		{
			if (AENMOLHMEDN == null)
			{
				return;
			}
			foreach (VerticalScrollController item in AENMOLHMEDN)
			{
				item.Invalidate();
			}
		}

		public static void LockAllScrolls()
		{
			if (AENMOLHMEDN == null)
			{
				return;
			}
			foreach (VerticalScrollController item in AENMOLHMEDN)
			{
				item.DAMJJFCIHBA();
			}
		}

		public static void UnlockAllScrolls()
		{
			if (AENMOLHMEDN == null)
			{
				return;
			}
			foreach (VerticalScrollController item in AENMOLHMEDN)
			{
				item.JBOFOOHGDGC();
			}
		}

		public void Awake()
		{
			if (AENMOLHMEDN == null)
			{
				AENMOLHMEDN = new HashSet<VerticalScrollController>();
			}
			AENMOLHMEDN.Add(this);
		}

		public void OnDestroy()
		{
			if (AENMOLHMEDN.Contains(this))
			{
				AENMOLHMEDN.Remove(this);
			}
		}

		public void Update()
		{
			if (NKPKHOGBFNE)
			{
				return;
			}
			GetUserActionMobile();
			float value = ODPGLMBMKMI - OMPPIKLPHBP;
			value = Mathf.Clamp(value, -3f, 3f);
			Vector2 vector = HGNBDANJJIO;
			if (LEHBFPIIANH)
			{
				OMPPIKLPHBP = ODPGLMBMKMI;
				for (int num = OHCAFHBIEAF.Length - 1; num > 0; num--)
				{
					OHCAFHBIEAF[num] = OHCAFHBIEAF[num - 1];
				}
				OHCAFHBIEAF[0] = ODPGLMBMKMI;
				float f = 0f;
				float num2 = 1f;
				if (vector.y <= NHMLGGLPAJI && value < 0f)
				{
					f = vector.y - NHMLGGLPAJI;
				}
				else if (vector.y >= GDACHIJEGEE && value > 0f)
				{
					f = vector.y - GDACHIJEGEE;
				}
				f = Mathf.Abs(f);
				f = Mathf.Clamp(f, 0f, StretchOffset);
				if (f > 0f)
				{
					num2 = Mathf.Clamp01((StretchOffset - Mathf.Abs(f)) * StretchFactor);
				}
				vector.y += value * num2;
				HGNBDANJJIO = vector;
				Vector3 localPosition = Content.localPosition;
				localPosition.y += (HGNBDANJJIO.y - Content.localPosition.y) * 0.5f;
				Content.localPosition = localPosition;
			}
			else if (!CBBDAPJNGJB)
			{
				if (Mathf.Abs(HFCIENBEADN) > 0.0001f)
				{
					HFCIENBEADN *= 0.94f;
					vector.y += HFCIENBEADN;
				}
				else
				{
					HFCIENBEADN = 0f;
				}
				float value2 = 0f;
				if (vector.y <= NHMLGGLPAJI)
				{
					value2 = vector.y - NHMLGGLPAJI;
				}
				else if (vector.y >= GDACHIJEGEE)
				{
					value2 = vector.y - GDACHIJEGEE;
				}
				value2 = Mathf.Clamp(value2, 0f - StretchOffset, StretchOffset);
				float num3 = Mathf.Abs(value2);
				if (num3 > 0f)
				{
					HFCIENBEADN *= 0.7f;
				}
				vector.y -= value2 * 0.098f;
				HGNBDANJJIO = vector;
				Vector3 localPosition2 = Content.localPosition;
				localPosition2.y += (HGNBDANJJIO.y - Content.localPosition.y) * IDAPCKFGCPI;
				Content.localPosition = localPosition2;
			}
			LJPLGIKDFGM();
		}

		public int GetScrollTopIndex(float IACFIOBNMPP, float IBNDGNOIEEF = 0f)
		{
			return (int)((Content.transform.localPosition.y - NHMLGGLPAJI - IBNDGNOIEEF) / IACFIOBNMPP);
		}

		public float GetScrollPosition(float IBNDGNOIEEF = 0f)
		{
			return Content.transform.localPosition.y - NHMLGGLPAJI - IBNDGNOIEEF;
		}

		public void SetScrollAreaHeight(float JKNPBEOPMPK)
		{
			ScrollArea.size = new Vector2(ScrollArea.size.x, JKNPBEOPMPK);
			SetContentSize(JKNPBEOPMPK);
		}

		public void SetOffsets(float IMOCCLGLCMH, float MMBMCOPEABC)
		{
			DLPAAACPGFP = IMOCCLGLCMH;
			EJOHOFKPECP = MMBMCOPEABC;
		}

		public void SetOffsetsAndUpdate(float IMOCCLGLCMH, float MMBMCOPEABC)
		{
			SetOffsets(IMOCCLGLCMH, MMBMCOPEABC);
			SetContentSize(HHOFEGKGAPC);
		}

		public void Init()
		{
			if (CurrentCamera == null)
			{
				CurrentCamera = Camera.main;
			}
			AJGEBIJJPOD = CurrentCamera.GetComponent<SpriteButtonListener>();
		}

		public void Init(Camera LFCBBKIFIJA)
		{
			if (CurrentCamera == null && LFCBBKIFIJA != null)
			{
				CurrentCamera = LFCBBKIFIJA;
			}
			AJGEBIJJPOD = CurrentCamera.GetComponent<SpriteButtonListener>();
		}

		internal void DAMJJFCIHBA()
		{
			NKPKHOGBFNE = true;
		}

		internal void JBOFOOHGDGC()
		{
			NKPKHOGBFNE = false;
		}

		public bool IsLocked()
		{
			return NKPKHOGBFNE;
		}

		public void Invalidate()
		{
			LEHBFPIIANH = false;
			CBBDAPJNGJB = false;
		}

		public void ScrollToTop()
		{
			Vector3 localPosition = Content.localPosition;
			localPosition.y = NHMLGGLPAJI;
			Content.localPosition = localPosition;
			HGNBDANJJIO = Content.localPosition;
			HFCIENBEADN = 0f;
		}

		public void ScrollToBottom()
		{
			Vector3 localPosition = Content.localPosition;
			localPosition.y = GDACHIJEGEE;
			Content.localPosition = localPosition;
			HGNBDANJJIO = Content.localPosition;
			HFCIENBEADN = 0f;
		}

		public void SetPos(float CNLILOEEBOJ)
		{
			Vector3 localPosition = Content.localPosition;
			localPosition.y = Mathf.Clamp(CNLILOEEBOJ, NHMLGGLPAJI, GDACHIJEGEE);
			Content.position = localPosition;
			HGNBDANJJIO = Content.localPosition;
		}

		public void SetLocalPos(float CNLILOEEBOJ)
		{
			CNLILOEEBOJ = Mathf.Clamp(CNLILOEEBOJ, NHMLGGLPAJI, GDACHIJEGEE);
			Content.localPosition = new Vector3(0f, CNLILOEEBOJ, 0f);
			HGNBDANJJIO = Content.localPosition;
		}

		public void SetContentSize(float JKNPBEOPMPK, bool BIIINCHBBBF = false)
		{
			HFCIENBEADN = 0f;
			HHOFEGKGAPC = ((!(JKNPBEOPMPK < ScrollArea.size.y)) ? JKNPBEOPMPK : ScrollArea.size.y);
			Vector3 vector = new Vector3(0f, HHOFEGKGAPC, 0f);
			Vector2 size = ScrollArea.size;
			NHMLGGLPAJI = size.y * 0.5f + EJOHOFKPECP;
			GDACHIJEGEE = vector.y - size.y * 0.5f + DLPAAACPGFP;
			Vector3 localPosition = Content.localPosition;
			if (vector.y > size.y)
			{
				localPosition.y = Mathf.Clamp(localPosition.y, GDACHIJEGEE, NHMLGGLPAJI);
				if (BIIINCHBBBF)
				{
					NKPKHOGBFNE = false;
				}
			}
			else
			{
				localPosition.y = 0f - (vector.y * 0.25f + DLPAAACPGFP);
				if (BIIINCHBBBF)
				{
					NKPKHOGBFNE = true;
				}
			}
			localPosition.y = NHMLGGLPAJI;
			Content.localPosition = localPosition;
			HGNBDANJJIO = Content.localPosition;
		}

		public void SetContentSizeAnimated(float JKNPBEOPMPK, bool EFKCIIGDDBK = true)
		{
			HFCIENBEADN = 0f;
			HHOFEGKGAPC = ((!(JKNPBEOPMPK < ScrollArea.size.y)) ? JKNPBEOPMPK : ScrollArea.size.y);
			Vector3 vector = new Vector3(0f, HHOFEGKGAPC, 0f);
			Vector2 size = ScrollArea.size;
			NHMLGGLPAJI = size.y * 0.5f + EJOHOFKPECP;
			GDACHIJEGEE = vector.y - size.y * 0.5f + DLPAAACPGFP;
			Vector3 localPosition = Content.localPosition;
			if (EFKCIIGDDBK)
			{
				float num = Mathf.Abs(localPosition.y - GDACHIJEGEE);
				float num2 = Mathf.Abs(localPosition.y - NHMLGGLPAJI);
				IDAPCKFGCPI = 0.1f;
				if (num2 < 1f)
				{
					localPosition.y = NHMLGGLPAJI;
				}
				else if (num > 0f)
				{
					localPosition.y = GDACHIJEGEE;
				}
				else
				{
					localPosition.y = Mathf.Clamp(localPosition.y, NHMLGGLPAJI, GDACHIJEGEE);
					Content.localPosition = localPosition;
				}
			}
			else
			{
				IDAPCKFGCPI = 0f;
				localPosition.y = Mathf.Clamp(localPosition.y, NHMLGGLPAJI, GDACHIJEGEE);
				Content.localPosition = localPosition;
			}
			HGNBDANJJIO = localPosition;
		}

		public void CalculateBounds()
		{
			if (!(Content == null))
			{
				Vector3 localPosition = Content.localPosition;
				Content.localPosition = Vector3.zero;
				Bounds bounds = new Bounds(Content.localPosition, Vector3.zero);
				Component[] componentsInChildren = Content.GetComponentsInChildren(typeof(Renderer));
				Component[] array = componentsInChildren;
				foreach (Component component in array)
				{
					bounds.Encapsulate(((Renderer)component).bounds);
				}
				Content.localPosition = localPosition;
				Vector3 size = bounds.size;
				Vector3 size2 = ScrollArea.bounds.size;
				NHMLGGLPAJI = (0f - size2.y) * 0.5f + EJOHOFKPECP;
				GDACHIJEGEE = size.y - size2.y + size2.y * 0.5f + DLPAAACPGFP;
				Vector3 localPosition2 = Content.localPosition;
				if (size.y > size2.y)
				{
					localPosition2.y = Mathf.Clamp(localPosition2.y, GDACHIJEGEE, NHMLGGLPAJI);
				}
				else
				{
					localPosition2.y = 0f - (size.y * 0.25f + DLPAAACPGFP);
				}
				localPosition2.y = Mathf.Clamp(localPosition2.y, GDACHIJEGEE, NHMLGGLPAJI);
				Content.localPosition = localPosition2;
				HGNBDANJJIO = Content.localPosition;
			}
		}

		public void GetUserActionMobile()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);
				Vector2 position = touch.position;
				switch (touch.phase)
				{
				case TouchPhase.Began:
					KPCKCDGGBMF(position);
					break;
				case TouchPhase.Moved:
					NKPMGDHHBPB(position);
					break;
				case TouchPhase.Ended:
				case TouchPhase.Canceled:
					EFECEAIKDLA();
					break;
				case TouchPhase.Stationary:
					break;
				}
			}
		}

		private void KPCKCDGGBMF(Vector2 CHGOGDCCHOL)
		{
			if (!(CurrentCamera == null))
			{
				IDAPCKFGCPI = 0.5f;
				Vector3 vector = CurrentCamera.ScreenToWorldPoint(CHGOGDCCHOL);
				Vector3 vector2 = Content.parent.transform.InverseTransformPoint(vector);
				vector.z = ScrollArea.bounds.center.z;
				HFCIENBEADN = 0f;
				bool flag = false;
				if (TouchArea != null)
				{
					vector.z = TouchArea.bounds.center.z;
					flag = TouchArea.bounds.Contains(vector);
				}
				else
				{
					flag = ScrollArea.bounds.Contains(vector);
				}
				if (flag)
				{
					CBBDAPJNGJB = true;
					KFFLDJPKCJN = vector2;
					OMPPIKLPHBP = KFFLDJPKCJN.y;
				}
			}
		}

		private void EFECEAIKDLA()
		{
			if (CurrentCamera == null || !CBBDAPJNGJB)
			{
				return;
			}
			if (CurrentSwipeManager != null)
			{
				CurrentSwipeManager.EnableScroll(true);
			}
			if (HGNBDANJJIO.y <= NHMLGGLPAJI || HGNBDANJJIO.y >= GDACHIJEGEE)
			{
				LEHBFPIIANH = false;
				CBBDAPJNGJB = false;
				HFCIENBEADN = 0f;
				return;
			}
			if (LEHBFPIIANH)
			{
				float num = 0f;
				int num2 = OHCAFHBIEAF.Length - 1;
				for (int i = 0; i < num2; i++)
				{
					num += OHCAFHBIEAF[i] - OHCAFHBIEAF[i + 1];
				}
				num = num / (float)num2 * 0.98f;
				HFCIENBEADN = Mathf.Clamp(num, -3f, 3f);
			}
			LEHBFPIIANH = false;
			CBBDAPJNGJB = false;
		}

		private void NKPMGDHHBPB(Vector2 CHGOGDCCHOL)
		{
			if (CurrentCamera == null || !CBBDAPJNGJB)
			{
				return;
			}
			Vector3 position = CurrentCamera.ScreenToWorldPoint(CHGOGDCCHOL);
			Vector3 vector = Content.parent.transform.InverseTransformPoint(position);
			float num = Mathf.Abs(vector.y - KFFLDJPKCJN.y);
			if (!LEHBFPIIANH && num > DragTreashold)
			{
				if (CurrentSwipeManager != null)
				{
					CurrentSwipeManager.EnableScroll(false);
				}
				LEHBFPIIANH = true;
				ODPGLMBMKMI = vector.y;
				if (AJGEBIJJPOD != null)
				{
					AJGEBIJJPOD.InvalidateTouch();
				}
				for (int i = 0; i < OHCAFHBIEAF.Length; i++)
				{
					OHCAFHBIEAF[i] = vector.y;
				}
			}
			if (LEHBFPIIANH)
			{
				ODPGLMBMKMI = vector.y;
			}
		}

		public List<GameObject> GetContent()
		{
			return NDPMKJIDBOM;
		}

		public virtual void RemoveAllItems()
		{
			if (NDPMKJIDBOM == null)
			{
				return;
			}
			foreach (GameObject item in NDPMKJIDBOM)
			{
				if (item != null)
				{
					UnityEngine.Object.Destroy(item);
				}
			}
			NDPMKJIDBOM.Clear();
		}

		public GameObject AddPrefab(Vector3 DLKBJLNCHBE, GameObject DOHDHJHFBMG, float ECICCLCFNJA = 1f)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(DOHDHJHFBMG);
			AddGameObject(gameObject, DLKBJLNCHBE, ECICCLCFNJA);
			return gameObject;
		}

		public void AddGameObject(GameObject EJCNAJOHBFI, Vector3 DLKBJLNCHBE, float ECICCLCFNJA)
		{
			EJCNAJOHBFI.transform.SetParent(Content);
			EJCNAJOHBFI.transform.localScale = Vector3.one * ECICCLCFNJA;
			EJCNAJOHBFI.transform.localPosition = DLKBJLNCHBE;
			NDPMKJIDBOM.Add(EJCNAJOHBFI);
		}

		public int Count()
		{
			return NDPMKJIDBOM.Count;
		}

		protected void PENKNKCIJGH(GameObject IDBBMJGCHPH, bool AGBHHOGANPJ = true)
		{
			NDPMKJIDBOM.Remove(IDBBMJGCHPH);
			if (AGBHHOGANPJ)
			{
				IDBBMJGCHPH.transform.SetParent(null);
				UnityEngine.Object.Destroy(IDBBMJGCHPH);
			}
		}

		protected virtual void LJPLGIKDFGM()
		{
			if (OnScroll != null)
			{
				OnScroll();
			}
		}
	}
}
