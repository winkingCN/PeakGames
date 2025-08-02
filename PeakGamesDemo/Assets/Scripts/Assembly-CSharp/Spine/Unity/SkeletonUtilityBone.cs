using System;
using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/SkeletonUtilityBone")]
	public class SkeletonUtilityBone : MonoBehaviour
	{
		public enum HNLALCIKDAK
		{
			Follow = 0,
			Override = 1
		}

		public string boneName;

		public Transform parentReference;

		public HNLALCIKDAK mode;

		public bool position;

		public bool rotation;

		public bool scale;

		public bool zPosition = true;

		[Range(0f, 1f)]
		public float overrideAlpha = 1f;

		[NonSerialized]
		public SkeletonUtility skeletonUtility;

		[NonSerialized]
		public NBKCFDOMAPI bone;

		[NonSerialized]
		public bool transformLerpComplete;

		[NonSerialized]
		public bool valid;

		private Transform KEADHBBFBIP;

		private Transform DJFNAAPOCJD;

		private bool JGELMIDGOEC;

		public bool CLIHFMNPDKK
		{
			get
			{
				return JGELMIDGOEC;
			}
		}

		public void Reset()
		{
			bone = null;
			KEADHBBFBIP = base.transform;
			valid = skeletonUtility != null && skeletonUtility.skeletonRenderer != null && skeletonUtility.skeletonRenderer.valid;
			if (valid)
			{
				DJFNAAPOCJD = skeletonUtility.transform;
				skeletonUtility.PEJHKOIMKLC -= POFJGNEFKNJ;
				skeletonUtility.PEJHKOIMKLC += POFJGNEFKNJ;
				DoUpdate();
			}
		}

		private void OnEnable()
		{
			skeletonUtility = base.transform.GetComponentInParent<SkeletonUtility>();
			if (!(skeletonUtility == null))
			{
				skeletonUtility.RegisterBone(this);
				skeletonUtility.PEJHKOIMKLC += POFJGNEFKNJ;
			}
		}

		private void POFJGNEFKNJ()
		{
			Reset();
		}

		private void OnDisable()
		{
			if (skeletonUtility != null)
			{
				skeletonUtility.PEJHKOIMKLC -= POFJGNEFKNJ;
				skeletonUtility.UnregisterBone(this);
			}
		}

		public void DoUpdate()
		{
			if (!valid)
			{
				Reset();
				return;
			}
			GCJKICAPOFL skeleton = skeletonUtility.skeletonRenderer.skeleton;
			if (bone == null)
			{
				if (string.IsNullOrEmpty(boneName))
				{
					return;
				}
				bone = skeleton.NMLBCOPEEDC(boneName);
				if (bone == null)
				{
					Debug.LogError("Bone not found: " + boneName, this);
					return;
				}
			}
			float num = ((!(skeleton.FNEPOOBKNLF ^ skeleton.AIPMEJLIOFD)) ? 1f : (-1f));
			if (mode == HNLALCIKDAK.Follow)
			{
				if (!bone.LPDFKGBMKOH)
				{
					bone.CKOPOJMGKOC();
				}
				if (position)
				{
					KEADHBBFBIP.localPosition = new Vector3(bone.LMEFHJAFJLG, bone.PEAEDDOIAGN, 0f);
				}
				if (rotation)
				{
					if (bone.MBBPBGHKLJM.OJOPJNBLHLO.OFACEBKFLOC())
					{
						KEADHBBFBIP.localRotation = Quaternion.Euler(0f, 0f, bone.JKLAIHKNOLK);
					}
					else
					{
						Vector3 eulerAngles = DJFNAAPOCJD.rotation.eulerAngles;
						KEADHBBFBIP.rotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, eulerAngles.z + bone.NPOPNHPPLHK * num);
					}
				}
				if (scale)
				{
					KEADHBBFBIP.localScale = new Vector3(bone.IOLDFODFHAL, bone.JBMAGEEAFKM, 1f);
					JGELMIDGOEC = BoneTransformModeIncompatible(bone);
				}
			}
			else
			{
				if (mode != HNLALCIKDAK.Override || transformLerpComplete)
				{
					return;
				}
				if (parentReference == null)
				{
					if (position)
					{
						Vector3 localPosition = KEADHBBFBIP.localPosition;
						bone.AMFCENFNAJJ = Mathf.Lerp(bone.AMFCENFNAJJ, localPosition.x, overrideAlpha);
						bone.CNLILOEEBOJ = Mathf.Lerp(bone.CNLILOEEBOJ, localPosition.y, overrideAlpha);
					}
					if (rotation)
					{
						float eDDNOJDPMCF = Mathf.LerpAngle(bone.PMNEAMANOCD, KEADHBBFBIP.localRotation.eulerAngles.z, overrideAlpha);
						bone.PMNEAMANOCD = eDDNOJDPMCF;
						bone.JKLAIHKNOLK = eDDNOJDPMCF;
					}
					if (scale)
					{
						Vector3 localScale = KEADHBBFBIP.localScale;
						bone.IAFNPOKEFMB = Mathf.Lerp(bone.IAFNPOKEFMB, localScale.x, overrideAlpha);
						bone.GFMCPIJHIGD = Mathf.Lerp(bone.GFMCPIJHIGD, localScale.y, overrideAlpha);
					}
				}
				else
				{
					if (transformLerpComplete)
					{
						return;
					}
					if (position)
					{
						Vector3 vector = parentReference.InverseTransformPoint(KEADHBBFBIP.position);
						bone.AMFCENFNAJJ = Mathf.Lerp(bone.AMFCENFNAJJ, vector.x, overrideAlpha);
						bone.CNLILOEEBOJ = Mathf.Lerp(bone.CNLILOEEBOJ, vector.y, overrideAlpha);
					}
					if (rotation)
					{
						float eDDNOJDPMCF2 = Mathf.LerpAngle(bone.PMNEAMANOCD, Quaternion.LookRotation(Vector3.forward, parentReference.InverseTransformDirection(KEADHBBFBIP.up)).eulerAngles.z, overrideAlpha);
						bone.PMNEAMANOCD = eDDNOJDPMCF2;
						bone.JKLAIHKNOLK = eDDNOJDPMCF2;
					}
					if (scale)
					{
						Vector3 localScale2 = KEADHBBFBIP.localScale;
						bone.IAFNPOKEFMB = Mathf.Lerp(bone.IAFNPOKEFMB, localScale2.x, overrideAlpha);
						bone.GFMCPIJHIGD = Mathf.Lerp(bone.GFMCPIJHIGD, localScale2.y, overrideAlpha);
					}
					JGELMIDGOEC = BoneTransformModeIncompatible(bone);
				}
				transformLerpComplete = true;
			}
		}

		public static bool BoneTransformModeIncompatible(NBKCFDOMAPI JEBEPBEGCCF)
		{
			return !JEBEPBEGCCF.MBBPBGHKLJM.OJOPJNBLHLO.KHKNHEPEKNE();
		}

		public void AddBoundingBox(string COKOMFOMBBA, string NFKHLLDFHKO, string FKAJNAAKEFH)
		{
			SkeletonUtility.AddBoundingBoxGameObject(bone.GDNININLMFD, COKOMFOMBBA, NFKHLLDFHKO, FKAJNAAKEFH, base.transform);
		}
	}
}
