using Assets.Scripts.CasualTools.Dialogs;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class ScrollController : MonoBehaviour
	{
		private readonly float[] OHCAFHBIEAF = new float[5];

		private Camera MDGJEJCILMI;

		private SpriteButtonListener AJGEBIJJPOD;

		private float ODPGLMBMKMI;

		private Vector2 KFFLDJPKCJN;

		private Vector3 HGNBDANJJIO;

		private bool LEHBFPIIANH;

		private float ICGLFHHJFKJ;

		private float OMPPIKLPHBP;

		private float LOCNHPJOGCL;

		private bool NKPKHOGBFNE;

		private float FGHMGLFLJMA;

		private float EOHDNBCPPLI;

		private float HFCIENBEADN;

		private bool CBBDAPJNGJB;

		public float BounceEdgeRatio = 0.1f;

		public Transform Content;

		public float DragTreashold = 20f;

		public BoxCollider2D ScrollArea;

		public float StretchFactor = 0.2f;

		public float StretchOffset = 3f;

		public void Init(float OAKLDKLPHBB, float CKJFBOLHJNM)
		{
			MDGJEJCILMI = Camera.main;
			FGHMGLFLJMA = OAKLDKLPHBB;
			EOHDNBCPPLI = CKJFBOLHJNM;
			AJGEBIJJPOD = MDGJEJCILMI.GetComponent<SpriteButtonListener>();
		}

		internal void DAMJJFCIHBA()
		{
			NKPKHOGBFNE = true;
		}

		internal void JBOFOOHGDGC()
		{
			NKPKHOGBFNE = false;
		}

		public float GetLeft()
		{
			return ICGLFHHJFKJ;
		}

		public bool IsLocked()
		{
			return NKPKHOGBFNE;
		}

		public void SetPos(float AMFCENFNAJJ)
		{
			Vector3 position = Content.position;
			position.x = Mathf.Clamp(AMFCENFNAJJ, LOCNHPJOGCL, ICGLFHHJFKJ);
			Content.position = position;
			HGNBDANJJIO = Content.position;
		}

		public void SetContentSize(float MOFHAKELNPN)
		{
			Vector3 vector = new Vector3(MOFHAKELNPN, 0f, 0f);
			Vector3 size = ScrollArea.bounds.size;
			ICGLFHHJFKJ = (0f - size.x) * 0.5f + FGHMGLFLJMA;
			LOCNHPJOGCL = 0f - (vector.x - size.x + size.x * 0.5f) + EOHDNBCPPLI;
			Vector3 position = Content.position;
			if (vector.x > size.x)
			{
				position.x = Mathf.Clamp(position.x, ICGLFHHJFKJ, LOCNHPJOGCL);
			}
			else
			{
				position.x = 0f - (vector.x * 0.25f + FGHMGLFLJMA);
				NKPKHOGBFNE = true;
			}
			position.x = Mathf.Clamp(position.x, ICGLFHHJFKJ, LOCNHPJOGCL);
			Content.position = position;
			HGNBDANJJIO = Content.position;
		}

		public void Start()
		{
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
				if (vector.x <= LOCNHPJOGCL && value < 0f)
				{
					f = vector.x - LOCNHPJOGCL;
				}
				else if (vector.x >= ICGLFHHJFKJ && value > 0f)
				{
					f = vector.x - ICGLFHHJFKJ;
				}
				f = Mathf.Abs(f);
				f = Mathf.Clamp(f, 0f, StretchOffset);
				if (f > 0f)
				{
					num2 = Mathf.Clamp01((StretchOffset - Mathf.Abs(f)) * StretchFactor);
				}
				vector.x += value * num2;
				HGNBDANJJIO = vector;
				Vector3 position = Content.position;
				position.x += (HGNBDANJJIO.x - Content.position.x) * 0.5f;
				Content.position = position;
			}
			else if (!CBBDAPJNGJB)
			{
				if (Mathf.Abs(HFCIENBEADN) > 0.0001f)
				{
					HFCIENBEADN *= 0.94f;
					vector.x += HFCIENBEADN;
				}
				else
				{
					HFCIENBEADN = 0f;
				}
				float value2 = 0f;
				if (vector.x <= LOCNHPJOGCL)
				{
					value2 = vector.x - LOCNHPJOGCL;
				}
				else if (vector.x >= ICGLFHHJFKJ)
				{
					value2 = vector.x - ICGLFHHJFKJ;
				}
				value2 = Mathf.Clamp(value2, 0f - StretchOffset, StretchOffset);
				float num3 = Mathf.Abs(value2);
				if (num3 > 0f)
				{
					HFCIENBEADN *= (1f - num3 / StretchOffset) * 0.3f;
				}
				vector.x -= value2 * 0.098f;
				HGNBDANJJIO = vector;
				Vector3 position2 = Content.position;
				position2.x += (HGNBDANJJIO.x - Content.position.x) * 0.5f;
				Content.position = position2;
			}
		}

		public void CalculateBounds()
		{
			if (!(Content == null))
			{
				Vector3 position = Content.position;
				Content.position = Vector3.zero;
				Bounds bounds = new Bounds(Content.position, Vector3.zero);
				Component[] componentsInChildren = Content.GetComponentsInChildren(typeof(Renderer));
				Component[] array = componentsInChildren;
				foreach (Component component in array)
				{
					bounds.Encapsulate(((Renderer)component).bounds);
				}
				Content.position = position;
				Vector3 size = bounds.size;
				Vector3 size2 = ScrollArea.bounds.size;
				ICGLFHHJFKJ = (0f - size2.x) * 0.5f + FGHMGLFLJMA;
				LOCNHPJOGCL = 0f - (size.x - size2.x + size2.x * 0.5f) + EOHDNBCPPLI;
				Vector3 position2 = Content.position;
				if (size.x > size2.x)
				{
					position2.x = Mathf.Clamp(position2.x, ICGLFHHJFKJ, LOCNHPJOGCL);
				}
				else
				{
					position2.x = 0f - (size.x * 0.25f + FGHMGLFLJMA);
					NKPKHOGBFNE = true;
				}
				position2.x = Mathf.Clamp(position2.x, ICGLFHHJFKJ, LOCNHPJOGCL);
				Content.position = position2;
				HGNBDANJJIO = Content.position;
			}
		}

		private Collider2D BMHJEFJMBPB(Vector3 FEGIAHNDMCE)
		{
			return Physics2D.OverlapPoint(FEGIAHNDMCE);
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
					EFECEAIKDLA();
					break;
				}
			}
		}

		private void KPCKCDGGBMF(Vector2 CHGOGDCCHOL)
		{
			Vector3 vector = MDGJEJCILMI.ScreenToWorldPoint(CHGOGDCCHOL);
			vector.z = 0f;
			HFCIENBEADN = 0f;
			if (ScrollArea.bounds.Contains(vector))
			{
				CBBDAPJNGJB = true;
				KFFLDJPKCJN = vector;
				OMPPIKLPHBP = KFFLDJPKCJN.x;
			}
		}

		private void EFECEAIKDLA()
		{
			if (!CBBDAPJNGJB)
			{
				return;
			}
			if (HGNBDANJJIO.x <= LOCNHPJOGCL || HGNBDANJJIO.x >= ICGLFHHJFKJ)
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
			if (!CBBDAPJNGJB)
			{
				return;
			}
			Vector3 vector = MDGJEJCILMI.ScreenToWorldPoint(CHGOGDCCHOL);
			float num = Mathf.Abs((vector - (Vector3)KFFLDJPKCJN).x);
			if (!LEHBFPIIANH && num > DragTreashold)
			{
				LEHBFPIIANH = true;
				ODPGLMBMKMI = MDGJEJCILMI.ScreenToWorldPoint(CHGOGDCCHOL).x;
				AJGEBIJJPOD.InvalidateTouch();
				for (int i = 0; i < OHCAFHBIEAF.Length; i++)
				{
					OHCAFHBIEAF[i] = vector.x;
				}
			}
			if (LEHBFPIIANH)
			{
				ODPGLMBMKMI = vector.x;
			}
		}
	}
}
