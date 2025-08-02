using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.SceneTransitions;
using Ui.VerticalScroll;
using UnityEngine;

namespace NewMapScene
{
	public class SwipeManager : MonoBehaviour
	{
		public float DragTreashold = 10f;

		public float StretchFactor = 0.2f;

		public float StretchOffset = 3f;

		public Transform Content;

		public Transform Highlight;

		public Transform BottomPanel;

		public ContainerManager CurrentContainerManager;

		private Camera MDGJEJCILMI;

		private Vector2 KFFLDJPKCJN;

		private float ODPGLMBMKMI;

		private float OMPPIKLPHBP;

		private Vector3 HGNBDANJJIO;

		private bool CBBDAPJNGJB;

		private bool LEHBFPIIANH;

		private readonly float[] MPJIMHKFBEN = new float[3];

		private bool DKNLNFMOOPO = true;

		private float MFKBAMOCAMP;

		private float HICHAHFDEAB;

		private float ICGLFHHJFKJ;

		private float LOCNHPJOGCL;

		private float HPDLLEPFGPC;

		private float HGDAAJKNJPC;

		private float JHMHKEEPEFH;

		public void Update()
		{
			if (DKNLNFMOOPO)
			{
				GetUserActionMobile();
				NOOMBEGLKCE();
			}
		}

		public void Start()
		{
			Init();
		}

		public void Init()
		{
			MDGJEJCILMI = Camera.main;
			HPDLLEPFGPC = ONCMBJKLKIL.EMFKAPJMDCC / 10.24f;
			MFKBAMOCAMP = 1.65f * HPDLLEPFGPC;
			HICHAHFDEAB = 1.82f * HPDLLEPFGPC;
			ICGLFHHJFKJ = HPDLLEPFGPC * 20.48f;
			LOCNHPJOGCL = HPDLLEPFGPC * -20.48f;
			JHMHKEEPEFH = ONCMBJKLKIL.EMFKAPJMDCC;
			float num = JHMHKEEPEFH / BottomPanel.localScale.x;
			HGDAAJKNJPC = num / 6f;
		}

		private bool PDOMIBEELBM(Vector2 NPGMHNONCGO)
		{
			float y = MDGJEJCILMI.ScreenToWorldPoint(NPGMHNONCGO).y;
			float num = ONCMBJKLKIL.FHAMOHDEGMK * 0.5f;
			float num2 = num - MFKBAMOCAMP;
			float num3 = 0f - num + HICHAHFDEAB;
			return y > num3 && y < num2;
		}

		private void NOOMBEGLKCE()
		{
			float value = ODPGLMBMKMI - OMPPIKLPHBP;
			value = Mathf.Clamp(value, -3f, 3f);
			Vector2 vector = HGNBDANJJIO;
			if (LEHBFPIIANH)
			{
				for (int num = MPJIMHKFBEN.Length - 1; num > 0; num--)
				{
					MPJIMHKFBEN[num] = MPJIMHKFBEN[num - 1];
				}
				MPJIMHKFBEN[0] = value;
				OMPPIKLPHBP = ODPGLMBMKMI;
				float f = 0f;
				float num2 = 1f;
				if (vector.x >= ICGLFHHJFKJ && value > 0f)
				{
					f = vector.x - ICGLFHHJFKJ;
				}
				else if (vector.x <= LOCNHPJOGCL && value < 0f)
				{
					f = vector.x - LOCNHPJOGCL;
				}
				f = Mathf.Abs(f);
				f = Mathf.Clamp(f, 0f, StretchOffset);
				if (f > 0f)
				{
					num2 = Mathf.Clamp01((StretchOffset - Mathf.Abs(f)) * StretchFactor);
				}
				vector.x += value * num2;
				HGNBDANJJIO = vector;
				Vector3 localPosition = Content.localPosition;
				localPosition.x += (HGNBDANJJIO.x - Content.localPosition.x) * 0.5f;
				Content.localPosition = localPosition;
				float num3 = (0f - Content.localPosition.x) / JHMHKEEPEFH;
				Vector3 localPosition2 = Highlight.localPosition;
				Highlight.localPosition = new Vector3(num3 * HGDAAJKNJPC, localPosition2.y, localPosition2.z);
			}
		}

		public void GetUserActionMobile()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.touches[0];
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

		private void KPCKCDGGBMF(Vector2 LDMDBPLADGD)
		{
			if (!PDOMIBEELBM(LDMDBPLADGD) || FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN || LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				CBBDAPJNGJB = false;
				return;
			}
			Vector3 vector = MDGJEJCILMI.ScreenToWorldPoint(LDMDBPLADGD);
			KFFLDJPKCJN = vector;
			CBBDAPJNGJB = true;
		}

		private void EFECEAIKDLA()
		{
			if (!CBBDAPJNGJB || FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				return;
			}
			if (LEHBFPIIANH)
			{
				float num = 0f;
				int num2 = MPJIMHKFBEN.Length - 1;
				for (int i = 0; i < num2; i++)
				{
					num += MPJIMHKFBEN[i];
					MPJIMHKFBEN[i] = 0f;
				}
				num = num / (float)num2 * 0.6f;
				float num3 = Mathf.Clamp(num, -2f, 2f);
				if (Mathf.Abs(num3) > 0.2f)
				{
					CurrentContainerManager.SlideToNext(num3);
				}
				else
				{
					CurrentContainerManager.SlideToNearest();
				}
				SpriteButtonListener.Instance.EnableClicks = true;
			}
			LEHBFPIIANH = false;
			CBBDAPJNGJB = false;
		}

		private void NKPMGDHHBPB(Vector2 LDMDBPLADGD)
		{
			if (!CBBDAPJNGJB || FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN || LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				return;
			}
			Vector3 vector = MDGJEJCILMI.ScreenToWorldPoint(LDMDBPLADGD);
			float num = Mathf.Abs(vector.x - KFFLDJPKCJN.x);
			if (!LEHBFPIIANH && num > DragTreashold)
			{
				LEHBFPIIANH = true;
				CurrentContainerManager.KillTweens();
				SpriteButtonListener.Instance.EnableClicks = false;
				SpriteButtonListener.Instance.InvalidateTouch();
				VerticalScrollController.InvalidateScrolls();
				ODPGLMBMKMI = vector.x;
				OMPPIKLPHBP = ODPGLMBMKMI;
				HGNBDANJJIO = Content.localPosition;
				for (int i = 0; i < MPJIMHKFBEN.Length; i++)
				{
					MPJIMHKFBEN[i] = 0f;
				}
			}
			if (LEHBFPIIANH)
			{
				ODPGLMBMKMI = vector.x;
			}
		}

		public void EnableScroll(bool IEGIOBJMGKJ)
		{
			DKNLNFMOOPO = IEGIOBJMGKJ;
		}
	}
}
