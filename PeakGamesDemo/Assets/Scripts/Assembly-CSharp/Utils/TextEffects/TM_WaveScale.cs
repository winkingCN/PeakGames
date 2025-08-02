using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Utils.TextEffects
{
	[ExecuteInEditMode]
	public class TM_WaveScale : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class IAADINAGFBG
		{
			internal Vector3[] FHBFCAEGPOH;

			internal int KAKJKCHHBAP;

			internal TM_WaveScale PDAPIGLEPGC;

			internal Vector2 AGFNGEFDHLA()
			{
				return FHBFCAEGPOH[KAKJKCHHBAP];
			}

			internal void KDACLOKGNAM(Vector2 AMFCENFNAJJ)
			{
				FHBFCAEGPOH[KAKJKCHHBAP] = AMFCENFNAJJ;
				PDAPIGLEPGC.DCDMODOFANB.UpdateVertexData();
			}

			internal Vector2 DBLIJBPNCAN()
			{
				return FHBFCAEGPOH[KAKJKCHHBAP];
			}

			internal void EFLLCMEPAEM(Vector2 AMFCENFNAJJ)
			{
				FHBFCAEGPOH[KAKJKCHHBAP + 1] = AMFCENFNAJJ;
			}

			internal Vector2 NNINHCPIBHO()
			{
				return FHBFCAEGPOH[KAKJKCHHBAP];
			}

			internal void HFBABENGMDD(Vector2 AMFCENFNAJJ)
			{
				FHBFCAEGPOH[KAKJKCHHBAP + 2] = AMFCENFNAJJ;
			}

			internal Vector2 JJBKCOCNHNL()
			{
				return FHBFCAEGPOH[KAKJKCHHBAP];
			}

			internal void MJJBIDJBGLE(Vector2 AMFCENFNAJJ)
			{
				FHBFCAEGPOH[KAKJKCHHBAP + 3] = AMFCENFNAJJ;
			}
		}

		public AnimationCurve VertexCurve2 = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.25f, 2f), new Keyframe(0.5f, 0f), new Keyframe(0.75f, 2f), new Keyframe(1f, 0f));

		public float CurveScale = 1f;

		private TMP_Text DCDMODOFANB;

		private float DOAKDOGFPPL = 0.03f;

		private float BNOGOFGHPAE = 0.3f;

		private float CMCNPKBPCFF = 6.21f;

		private void Awake()
		{
			DCDMODOFANB = base.gameObject.GetComponent<TMP_Text>();
		}

		public void SetParameters(float FMPBJJMKCIG, float DKIPEJPGACG, float DLDCPFEEMKP = 1.70158f)
		{
			BNOGOFGHPAE = FMPBJJMKCIG;
			DOAKDOGFPPL = DKIPEJPGACG;
			CMCNPKBPCFF = DLDCPFEEMKP;
		}

		public void Animate(Ease JFLCMCILIKF = Ease.OutBack)
		{
			VertexCurve2.preWrapMode = WrapMode.Once;
			VertexCurve2.postWrapMode = WrapMode.Once;
			DCDMODOFANB.KEJHLJNMEAH = true;
			DCDMODOFANB.ForceMeshUpdate();
			TMP_TextInfo textInfo = DCDMODOFANB.BIAHJAKEMLM;
			int characterCount = textInfo.characterCount;
			float x = DCDMODOFANB.DJKHEGCCHFI.min.x;
			float x2 = DCDMODOFANB.DJKHEGCCHFI.max.x;
			if (characterCount == 0)
			{
				return;
			}
			for (int i = 0; i < characterCount; i++)
			{
				if (i < textInfo.characterInfo.Length && i >= 0 && textInfo.characterInfo[i].BACHBACHNOF)
				{
					int KAKJKCHHBAP = textInfo.characterInfo[i].KAKJKCHHBAP;
					int eKBHGEBCJHL = textInfo.characterInfo[i].EKBHGEBCJHL;
					Vector3[] FHBFCAEGPOH = textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH;
					Vector3 vector = new Vector2((FHBFCAEGPOH[KAKJKCHHBAP].x + FHBFCAEGPOH[KAKJKCHHBAP + 2].x) / 2f, textInfo.characterInfo[i].CGAKKOEPCOG);
					FHBFCAEGPOH[KAKJKCHHBAP] += -vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 1] += -vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 2] += -vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 3] += -vector;
					float num = (vector.x - x) / (x2 - x);
					float num2 = num + 0.0001f;
					float y = VertexCurve2.Evaluate(num) * CurveScale;
					float y2 = VertexCurve2.Evaluate(num2) * CurveScale;
					Vector3 lhs = new Vector3(1f, 0f, 0f);
					Vector3 rhs = new Vector3(num2 * (x2 - x) + x, y2) - new Vector3(vector.x, y);
					float num3 = Mathf.Acos(Vector3.Dot(lhs, rhs.normalized)) * 57.29578f;
					float z = ((!(Vector3.Cross(lhs, rhs).z > 0f)) ? (360f - num3) : num3);
					Matrix4x4 matrix4x = Matrix4x4.TRS(new Vector3(0f, y, 0f), Quaternion.Euler(0f, 0f, z), Vector3.one);
					FHBFCAEGPOH[KAKJKCHHBAP] = matrix4x.MultiplyPoint3x4(FHBFCAEGPOH[KAKJKCHHBAP]);
					FHBFCAEGPOH[KAKJKCHHBAP + 1] = matrix4x.MultiplyPoint3x4(FHBFCAEGPOH[KAKJKCHHBAP + 1]);
					FHBFCAEGPOH[KAKJKCHHBAP + 2] = matrix4x.MultiplyPoint3x4(FHBFCAEGPOH[KAKJKCHHBAP + 2]);
					FHBFCAEGPOH[KAKJKCHHBAP + 3] = matrix4x.MultiplyPoint3x4(FHBFCAEGPOH[KAKJKCHHBAP + 3]);
					FHBFCAEGPOH[KAKJKCHHBAP] += vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 1] += vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 2] += vector;
					FHBFCAEGPOH[KAKJKCHHBAP + 3] += vector;
					Vector3 vector2 = FHBFCAEGPOH[KAKJKCHHBAP];
					Vector3 vector3 = FHBFCAEGPOH[KAKJKCHHBAP + 1];
					Vector3 vector4 = FHBFCAEGPOH[KAKJKCHHBAP + 2];
					Vector3 vector5 = FHBFCAEGPOH[KAKJKCHHBAP + 3];
					float num4 = Mathf.Max(vector2.x, vector3.x, vector4.x, vector5.x);
					float num5 = Mathf.Min(vector2.x, vector3.x, vector4.x, vector5.x);
					float num6 = Mathf.Max(vector2.y, vector3.y, vector4.y, vector5.y);
					float num7 = Mathf.Min(vector2.y, vector3.y, vector4.y, vector5.y);
					float x3 = num5 + (num4 - num5) * 0.5f;
					float y3 = num7 + (num6 - num7) * 0.5f;
					Vector3 vector6 = FHBFCAEGPOH[KAKJKCHHBAP];
					vector6.x = x3;
					vector6.y = y3;
					FHBFCAEGPOH[KAKJKCHHBAP] = vector6;
					DOTween.To(() => FHBFCAEGPOH[KAKJKCHHBAP], delegate(Vector2 AMFCENFNAJJ)
					{
						FHBFCAEGPOH[KAKJKCHHBAP] = AMFCENFNAJJ;
						DCDMODOFANB.UpdateVertexData();
					}, vector2, BNOGOFGHPAE).SetEase(JFLCMCILIKF).SetUpdate(true)
						.SetDelay((float)i * DOAKDOGFPPL)
						.easeOvershootOrAmplitude = CMCNPKBPCFF;
					Vector3 vector7 = FHBFCAEGPOH[KAKJKCHHBAP + 1];
					vector7.x = x3;
					vector7.y = y3;
					FHBFCAEGPOH[KAKJKCHHBAP + 1] = vector7;
					DOTween.To(() => FHBFCAEGPOH[KAKJKCHHBAP], delegate(Vector2 AMFCENFNAJJ)
					{
						FHBFCAEGPOH[KAKJKCHHBAP + 1] = AMFCENFNAJJ;
					}, vector3, BNOGOFGHPAE).SetEase(JFLCMCILIKF).SetUpdate(true)
						.SetDelay((float)i * DOAKDOGFPPL)
						.easeOvershootOrAmplitude = CMCNPKBPCFF;
					Vector3 vector8 = FHBFCAEGPOH[KAKJKCHHBAP + 2];
					vector8.x = x3;
					vector8.y = y3;
					FHBFCAEGPOH[KAKJKCHHBAP + 2] = vector8;
					DOTween.To(() => FHBFCAEGPOH[KAKJKCHHBAP], delegate(Vector2 AMFCENFNAJJ)
					{
						FHBFCAEGPOH[KAKJKCHHBAP + 2] = AMFCENFNAJJ;
					}, vector4, BNOGOFGHPAE).SetEase(JFLCMCILIKF).SetUpdate(true)
						.SetDelay((float)i * DOAKDOGFPPL)
						.easeOvershootOrAmplitude = CMCNPKBPCFF;
					Vector3 vector9 = FHBFCAEGPOH[KAKJKCHHBAP + 3];
					vector9.x = x3;
					vector9.y = y3;
					FHBFCAEGPOH[KAKJKCHHBAP + 3] = vector9;
					DOTween.To(() => FHBFCAEGPOH[KAKJKCHHBAP], delegate(Vector2 AMFCENFNAJJ)
					{
						FHBFCAEGPOH[KAKJKCHHBAP + 3] = AMFCENFNAJJ;
					}, vector5, BNOGOFGHPAE).SetEase(JFLCMCILIKF).SetUpdate(true)
						.SetDelay((float)i * DOAKDOGFPPL)
						.easeOvershootOrAmplitude = CMCNPKBPCFF;
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
	}
}
