using TMPro;
using UnityEngine;

namespace Assets.Scripts.Utils.TextCurver
{
	[ExecuteInEditMode]
	public class TextCurver : MonoBehaviour
	{
		private TMP_Text DCDMODOFANB;

		public AnimationCurve VertexCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.25f, 2f), new Keyframe(0.5f, 0f), new Keyframe(0.75f, 2f), new Keyframe(1f, 0f));

		public float CurveScale = 1f;

		public void Awake()
		{
			DCDMODOFANB = base.gameObject.GetComponent<TMP_Text>();
		}

		public void Start()
		{
			NMBJMALKIDK();
		}

		public void LateUpdate()
		{
			NMBJMALKIDK();
		}

		private void NMBJMALKIDK()
		{
			VertexCurve.preWrapMode = WrapMode.Once;
			VertexCurve.postWrapMode = WrapMode.Once;
			DCDMODOFANB.KEJHLJNMEAH = true;
			float curveScale = CurveScale;
			AnimationCurve animationCurve = ECEKEIKANEK(VertexCurve);
			if (!DCDMODOFANB.KEJHLJNMEAH && curveScale == CurveScale && animationCurve.keys[1].value == VertexCurve.keys[1].value)
			{
				return;
			}
			DCDMODOFANB.ForceMeshUpdate();
			TMP_TextInfo textInfo = DCDMODOFANB.BIAHJAKEMLM;
			int characterCount = textInfo.characterCount;
			if (characterCount == 0)
			{
				return;
			}
			float x = DCDMODOFANB.DJKHEGCCHFI.min.x;
			float x2 = DCDMODOFANB.DJKHEGCCHFI.max.x;
			for (int i = 0; i < characterCount; i++)
			{
				if (i < textInfo.characterInfo.Length && i >= 0 && textInfo.characterInfo[i].BACHBACHNOF)
				{
					int kAKJKCHHBAP = textInfo.characterInfo[i].KAKJKCHHBAP;
					int eKBHGEBCJHL = textInfo.characterInfo[i].EKBHGEBCJHL;
					Vector3[] fHBFCAEGPOH = textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH;
					Vector3 vector = new Vector2((fHBFCAEGPOH[kAKJKCHHBAP].x + fHBFCAEGPOH[kAKJKCHHBAP + 2].x) / 2f, textInfo.characterInfo[i].CGAKKOEPCOG);
					fHBFCAEGPOH[kAKJKCHHBAP] += -vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 1] += -vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 2] += -vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 3] += -vector;
					float num = (vector.x - x) / (x2 - x);
					float num2 = num + 0.0001f;
					float y = VertexCurve.Evaluate(num) * CurveScale;
					float y2 = VertexCurve.Evaluate(num2) * CurveScale;
					Vector3 lhs = new Vector3(1f, 0f, 0f);
					Vector3 rhs = new Vector3(num2 * (x2 - x) + x, y2) - new Vector3(vector.x, y);
					float num3 = Mathf.Acos(Vector3.Dot(lhs, rhs.normalized)) * 57.29578f;
					float z = ((!(Vector3.Cross(lhs, rhs).z > 0f)) ? (360f - num3) : num3);
					Matrix4x4 matrix4x = Matrix4x4.TRS(new Vector3(0f, y, 0f), Quaternion.Euler(0f, 0f, z), Vector3.one);
					fHBFCAEGPOH[kAKJKCHHBAP] = matrix4x.MultiplyPoint3x4(fHBFCAEGPOH[kAKJKCHHBAP]);
					fHBFCAEGPOH[kAKJKCHHBAP + 1] = matrix4x.MultiplyPoint3x4(fHBFCAEGPOH[kAKJKCHHBAP + 1]);
					fHBFCAEGPOH[kAKJKCHHBAP + 2] = matrix4x.MultiplyPoint3x4(fHBFCAEGPOH[kAKJKCHHBAP + 2]);
					fHBFCAEGPOH[kAKJKCHHBAP + 3] = matrix4x.MultiplyPoint3x4(fHBFCAEGPOH[kAKJKCHHBAP + 3]);
					fHBFCAEGPOH[kAKJKCHHBAP] += vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 1] += vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 2] += vector;
					fHBFCAEGPOH[kAKJKCHHBAP + 3] += vector;
				}
			}
			DCDMODOFANB.UpdateVertexData();
		}

		private AnimationCurve ECEKEIKANEK(AnimationCurve NINILENHPHE)
		{
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve.keys = NINILENHPHE.keys;
			return animationCurve;
		}

		public void UpdateView()
		{
			NMBJMALKIDK();
		}
	}
}
