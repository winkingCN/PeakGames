using System;
using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Spine/UI/BoneFollowerGraphic")]
	public class BoneFollowerGraphic : MonoBehaviour
	{
		public SkeletonGraphic skeletonGraphic;

		public bool initializeOnAwake = true;

		[LKNNBABNCFC("", "skeletonGraphic", true, false)]
		[SerializeField]
		public string boneName;

		public bool followBoneRotation = true;

		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip = true;

		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		public bool followZPosition = true;

		[NonSerialized]
		public NBKCFDOMAPI bone;

		private Transform DJFNAAPOCJD;

		private bool GFLJGLGLCCH;

		[NonSerialized]
		public bool valid;

		public SkeletonGraphic HOLLAGLOLNP
		{
			get
			{
				return skeletonGraphic;
			}
			set
			{
				skeletonGraphic = value;
				Initialize();
			}
		}

		public bool SetBone(string IOCMOCCFALN)
		{
			bone = skeletonGraphic.LICMNMABJGL.NMLBCOPEEDC(IOCMOCCFALN);
			if (bone == null)
			{
				Debug.LogError("Bone not found: " + IOCMOCCFALN, this);
				return false;
			}
			boneName = IOCMOCCFALN;
			return true;
		}

		public void Awake()
		{
			if (initializeOnAwake)
			{
				Initialize();
			}
		}

		public void Initialize()
		{
			bone = null;
			valid = skeletonGraphic != null && skeletonGraphic.NAFCDEECGEF;
			if (valid)
			{
				DJFNAAPOCJD = skeletonGraphic.transform;
				GFLJGLGLCCH = object.ReferenceEquals(DJFNAAPOCJD, base.transform.parent);
				if (!string.IsNullOrEmpty(boneName))
				{
					bone = skeletonGraphic.LICMNMABJGL.NMLBCOPEEDC(boneName);
				}
			}
		}

		public void LateUpdate()
		{
			if (!valid)
			{
				Initialize();
				return;
			}
			if (bone == null)
			{
				if (string.IsNullOrEmpty(boneName))
				{
					return;
				}
				bone = skeletonGraphic.LICMNMABJGL.NMLBCOPEEDC(boneName);
				if (!SetBone(boneName))
				{
					return;
				}
			}
			RectTransform rectTransform = base.transform as RectTransform;
			if (rectTransform == null)
			{
				return;
			}
			float referencePixelsPerUnit = skeletonGraphic.canvas.referencePixelsPerUnit;
			if (GFLJGLGLCCH)
			{
				rectTransform.localPosition = new Vector3(bone.POFLEELFBPH * referencePixelsPerUnit, bone.MLMBGGJGOBP * referencePixelsPerUnit, (!followZPosition) ? rectTransform.localPosition.z : 0f);
				if (followBoneRotation)
				{
					rectTransform.localRotation = bone.LFBAECLADMJ();
				}
			}
			else
			{
				Vector3 position = DJFNAAPOCJD.TransformPoint(new Vector3(bone.POFLEELFBPH * referencePixelsPerUnit, bone.MLMBGGJGOBP * referencePixelsPerUnit, 0f));
				if (!followZPosition)
				{
					position.z = rectTransform.position.z;
				}
				float num = bone.NPOPNHPPLHK;
				Transform parent = rectTransform.parent;
				if (parent != null)
				{
					Matrix4x4 localToWorldMatrix = parent.localToWorldMatrix;
					if (localToWorldMatrix.m00 * localToWorldMatrix.m11 - localToWorldMatrix.m01 * localToWorldMatrix.m10 < 0f)
					{
						num = 0f - num;
					}
				}
				if (followBoneRotation)
				{
					Vector3 eulerAngles = DJFNAAPOCJD.rotation.eulerAngles;
					rectTransform.SetPositionAndRotation(position, Quaternion.Euler(eulerAngles.x, eulerAngles.y, DJFNAAPOCJD.rotation.eulerAngles.z + num));
				}
				else
				{
					rectTransform.position = position;
				}
			}
			Vector3 localScale = ((!followLocalScale) ? new Vector3(1f, 1f, 1f) : new Vector3(bone.IAFNPOKEFMB, bone.GFMCPIJHIGD, 1f));
			if (followSkeletonFlip)
			{
				localScale.y *= ((!(bone.GDNININLMFD.FNEPOOBKNLF ^ bone.GDNININLMFD.AIPMEJLIOFD)) ? 1f : (-1f));
			}
			rectTransform.localScale = localScale;
		}
	}
}
