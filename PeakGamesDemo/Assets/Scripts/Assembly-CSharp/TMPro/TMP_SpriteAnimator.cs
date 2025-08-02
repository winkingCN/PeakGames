using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		private Dictionary<int, bool> PDGGFJCLGHG = new Dictionary<int, bool>(16);

		private TMP_Text DCDMODOFANB;

		private void Awake()
		{
			DCDMODOFANB = GetComponent<TMP_Text>();
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void StopAllAnimations()
		{
			StopAllCoroutines();
			PDGGFJCLGHG.Clear();
		}

		public void DoSpriteAnimation(int IPBOJLJACMC, TMP_SpriteAsset GKDEMJDOOLB, int EHGOOEHDNMM, int AHPGGJALELA, int IBCHGFEKEAH)
		{
			bool value = false;
			if (!PDGGFJCLGHG.TryGetValue(IPBOJLJACMC, out value))
			{
				StartCoroutine(GPDPOIHCABK(IPBOJLJACMC, GKDEMJDOOLB, EHGOOEHDNMM, AHPGGJALELA, IBCHGFEKEAH));
				PDGGFJCLGHG.Add(IPBOJLJACMC, true);
			}
		}

		private IEnumerator GPDPOIHCABK(int IPBOJLJACMC, TMP_SpriteAsset GKDEMJDOOLB, int EHGOOEHDNMM, int AHPGGJALELA, int IBCHGFEKEAH)
		{
			if (DCDMODOFANB == null)
			{
				yield break;
			}
			yield return null;
			int num = EHGOOEHDNMM;
			if (AHPGGJALELA > GKDEMJDOOLB.spriteInfoList.Count)
			{
				AHPGGJALELA = GKDEMJDOOLB.spriteInfoList.Count - 1;
			}
			MGLLLPMKGDA mGLLLPMKGDA = DCDMODOFANB.BIAHJAKEMLM.characterInfo[IPBOJLJACMC];
			int eKBHGEBCJHL = mGLLLPMKGDA.EKBHGEBCJHL;
			int kAKJKCHHBAP = mGLLLPMKGDA.KAKJKCHHBAP;
			IDAPNGDHHBD iDAPNGDHHBD = DCDMODOFANB.BIAHJAKEMLM.meshInfo[eKBHGEBCJHL];
			float num2 = 0f;
			float num3 = 1f / (float)Mathf.Abs(IBCHGFEKEAH);
			while (true)
			{
				if (num2 > num3)
				{
					num2 = 0f;
					TMP_Sprite tMP_Sprite = GKDEMJDOOLB.spriteInfoList[num];
					Vector3[] fHBFCAEGPOH = iDAPNGDHHBD.FHBFCAEGPOH;
					Vector2 vector = new Vector2(mGLLLPMKGDA.EBDCOMKHPBG, mGLLLPMKGDA.CGAKKOEPCOG);
					float num4 = mGLLLPMKGDA.PIJNMJOHBIE.fontInfo.Ascender / tMP_Sprite.height * tMP_Sprite.scale * mGLLLPMKGDA.HJLOCAEAFMJ;
					Vector3 vector2 = new Vector3(vector.x + tMP_Sprite.xOffset * num4, vector.y + (tMP_Sprite.yOffset - tMP_Sprite.height) * num4);
					Vector3 vector3 = new Vector3(vector2.x, vector.y + tMP_Sprite.yOffset * num4);
					Vector3 vector4 = new Vector3(vector.x + (tMP_Sprite.xOffset + tMP_Sprite.width) * num4, vector3.y);
					Vector3 vector5 = new Vector3(vector4.x, vector2.y);
					fHBFCAEGPOH[kAKJKCHHBAP] = vector2;
					fHBFCAEGPOH[kAKJKCHHBAP + 1] = vector3;
					fHBFCAEGPOH[kAKJKCHHBAP + 2] = vector4;
					fHBFCAEGPOH[kAKJKCHHBAP + 3] = vector5;
					Vector2[] lFAFOAOKPKA = iDAPNGDHHBD.LFAFOAOKPKA;
					Vector2 vector6 = new Vector2(tMP_Sprite.x / (float)GKDEMJDOOLB.spriteSheet.width, tMP_Sprite.y / (float)GKDEMJDOOLB.spriteSheet.height);
					Vector2 vector7 = new Vector2(vector6.x, (tMP_Sprite.y + tMP_Sprite.height) / (float)GKDEMJDOOLB.spriteSheet.height);
					Vector2 vector8 = new Vector2((tMP_Sprite.x + tMP_Sprite.width) / (float)GKDEMJDOOLB.spriteSheet.width, vector7.y);
					Vector2 vector9 = new Vector2(vector8.x, vector6.y);
					lFAFOAOKPKA[kAKJKCHHBAP] = vector6;
					lFAFOAOKPKA[kAKJKCHHBAP + 1] = vector7;
					lFAFOAOKPKA[kAKJKCHHBAP + 2] = vector8;
					lFAFOAOKPKA[kAKJKCHHBAP + 3] = vector9;
					iDAPNGDHHBD.IJKCGGPJDIG.vertices = fHBFCAEGPOH;
					iDAPNGDHHBD.IJKCGGPJDIG.uv = lFAFOAOKPKA;
					DCDMODOFANB.UpdateGeometry(iDAPNGDHHBD.IJKCGGPJDIG, eKBHGEBCJHL);
					num = ((IBCHGFEKEAH > 0) ? ((num >= AHPGGJALELA) ? EHGOOEHDNMM : (num + 1)) : ((num <= EHGOOEHDNMM) ? AHPGGJALELA : (num - 1)));
				}
				num2 += Time.deltaTime;
				yield return null;
			}
		}
	}
}
