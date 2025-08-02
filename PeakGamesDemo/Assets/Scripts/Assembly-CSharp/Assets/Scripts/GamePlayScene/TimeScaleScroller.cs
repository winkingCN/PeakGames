using System.Globalization;
using Assets.Scripts.GamePlayScene.Mechanics;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class TimeScaleScroller : MonoBehaviour
	{
		private Camera MDGJEJCILMI;

		private Vector2 KFFLDJPKCJN;

		private bool LEHBFPIIANH;

		private bool CBBDAPJNGJB;

		private float FECPODOFHAN;

		private float ODPGLMBMKMI;

		private float OMPPIKLPHBP;

		private float ICGLFHHJFKJ;

		private float LOCNHPJOGCL;

		private float JHMHKEEPEFH;

		public LevelBuilder CurrentLevelBuilder;

		public Transform Content;

		public BoxCollider2D HitArea;

		public float MaxVal = 1f;

		public float MinVal = 0.01f;

		public BoxCollider2D ScrollArea;

		public TextMeshPro ValueText;

		public static bool ADMIN_CLICK_MODE;

		public GameObject AdminModeClickCheck;

		public void FastForward()
		{
			Time.timeScale = 5f;
			ValueText.FCJBBPHFNPJ = "5";
			Content.position = new Vector3(LOCNHPJOGCL, Content.position.y, Content.position.z);
		}

		public void ResetTime()
		{
			Time.timeScale = 1f;
			Vector2 vector = Content.position;
			vector.x = LOCNHPJOGCL;
			Content.position = vector;
			ValueText.FCJBBPHFNPJ = "1";
			ODPGLMBMKMI = (OMPPIKLPHBP = 0f);
		}

		private void Start()
		{
			MDGJEJCILMI = Camera.main;
			ICGLFHHJFKJ = ScrollArea.bounds.min.x;
			LOCNHPJOGCL = ScrollArea.bounds.max.x;
			JHMHKEEPEFH = Mathf.Abs(LOCNHPJOGCL - ICGLFHHJFKJ);
			Vector2 vector = Content.position;
			vector.x = LOCNHPJOGCL;
			Content.position = vector;
			ValueText.FCJBBPHFNPJ = "1";
			ADMIN_CLICK_MODE = true;
			AdminClickModeSwitch();
		}

		private void Update()
		{
			GetUserActionMobile();
			if (LEHBFPIIANH)
			{
				float num = ODPGLMBMKMI - OMPPIKLPHBP;
				Vector2 vector = Content.position;
				OMPPIKLPHBP = ODPGLMBMKMI;
				if ((!(num > 0f) || !(ODPGLMBMKMI < ICGLFHHJFKJ)) && (!(num < 0f) || !(ODPGLMBMKMI > LOCNHPJOGCL)))
				{
					vector.x += num;
					vector.x = Mathf.Clamp(vector.x, ICGLFHHJFKJ, LOCNHPJOGCL);
					Content.position = vector;
					float num2 = (vector.x - ICGLFHHJFKJ) / JHMHKEEPEFH;
					float num3 = num2 * (MaxVal - MinVal);
					num3 = MinVal + (float)(int)(num3 * 1000f) / 1000f;
					ValueText.FCJBBPHFNPJ = num3.ToString(CultureInfo.InvariantCulture);
					Time.timeScale = num3;
				}
			}
		}

		private Collider2D BMHJEFJMBPB(Vector3 FEGIAHNDMCE)
		{
			return Physics2D.OverlapPoint(FEGIAHNDMCE);
		}

		public void AdminClickModeSwitch()
		{
			ADMIN_CLICK_MODE = !ADMIN_CLICK_MODE;
			AdminModeClickCheck.SetActive(ADMIN_CLICK_MODE);
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

		private void KPCKCDGGBMF(Vector2 NPGMHNONCGO)
		{
			Vector3 point = MDGJEJCILMI.ScreenToWorldPoint(NPGMHNONCGO);
			point.z = 0f;
			if (HitArea.bounds.Contains(point))
			{
				CBBDAPJNGJB = true;
				KFFLDJPKCJN = NPGMHNONCGO;
				ODPGLMBMKMI = KFFLDJPKCJN.x;
				OMPPIKLPHBP = ODPGLMBMKMI;
			}
		}

		private void EFECEAIKDLA()
		{
			if (CBBDAPJNGJB)
			{
				LEHBFPIIANH = false;
				CBBDAPJNGJB = false;
			}
		}

		private void NKPMGDHHBPB(Vector2 CHGOGDCCHOL)
		{
			if (CBBDAPJNGJB)
			{
				float x = MDGJEJCILMI.ScreenToWorldPoint(CHGOGDCCHOL).x;
				if (!LEHBFPIIANH && Mathf.Abs((CHGOGDCCHOL - KFFLDJPKCJN).x) > 10f)
				{
					LEHBFPIIANH = true;
					ODPGLMBMKMI = x;
					OMPPIKLPHBP = ODPGLMBMKMI;
				}
				if (LEHBFPIIANH)
				{
					ODPGLMBMKMI = x;
				}
			}
		}
	}
}
