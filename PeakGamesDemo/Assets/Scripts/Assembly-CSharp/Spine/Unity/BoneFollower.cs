using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/BoneFollower")]
	public class BoneFollower : MonoBehaviour
	{
		public SkeletonRenderer skeletonRenderer;

		[SerializeField]
		[LKNNBABNCFC("", "skeletonRenderer", true, false)]
		public string boneName;

		public bool followZPosition = true;

		public bool followBoneRotation = true;

		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip = true;

		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		[FormerlySerializedAs("resetOnAwake")]
		public bool initializeOnAwake = true;

		[NonSerialized]
		public bool valid;

		[NonSerialized]
		public NBKCFDOMAPI bone;

		private Transform DJFNAAPOCJD;

		private bool GFLJGLGLCCH;

		public SkeletonRenderer ALNKFMCPIIB
		{
			get
			{
				return skeletonRenderer;
			}
			set
			{
				skeletonRenderer = value;
				Initialize();
			}
		}

		public bool SetBone(string IOCMOCCFALN)
		{
			bone = skeletonRenderer.skeleton.NMLBCOPEEDC(IOCMOCCFALN);
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

		public void HandleRebuildRenderer(SkeletonRenderer NHPAGGIFGHN)
		{
			Initialize();
		}

		public void Initialize()
		{
			bone = null;
			valid = skeletonRenderer != null && skeletonRenderer.valid;
			if (valid)
			{
				DJFNAAPOCJD = skeletonRenderer.transform;
				skeletonRenderer.BOAKMFAEPME -= HandleRebuildRenderer;
				skeletonRenderer.BOAKMFAEPME += HandleRebuildRenderer;
				GFLJGLGLCCH = object.ReferenceEquals(DJFNAAPOCJD, base.transform.parent);
				if (!string.IsNullOrEmpty(boneName))
				{
					bone = skeletonRenderer.skeleton.NMLBCOPEEDC(boneName);
				}
			}
		}

		private void OnDestroy()
		{
			if (skeletonRenderer != null)
			{
				skeletonRenderer.BOAKMFAEPME -= HandleRebuildRenderer;
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
				bone = skeletonRenderer.skeleton.NMLBCOPEEDC(boneName);
				if (!SetBone(boneName))
				{
					return;
				}
			}
			Transform transform = base.transform;
			if (GFLJGLGLCCH)
			{
				transform.localPosition = new Vector3(bone.POFLEELFBPH, bone.MLMBGGJGOBP, (!followZPosition) ? transform.localPosition.z : 0f);
				if (followBoneRotation)
				{
					transform.localRotation = bone.LFBAECLADMJ();
				}
			}
			else
			{
				Vector3 position = DJFNAAPOCJD.TransformPoint(new Vector3(bone.POFLEELFBPH, bone.MLMBGGJGOBP, 0f));
				if (!followZPosition)
				{
					position.z = transform.position.z;
				}
				float num = bone.NPOPNHPPLHK;
				Transform parent = transform.parent;
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
					transform.SetPositionAndRotation(position, Quaternion.Euler(eulerAngles.x, eulerAngles.y, DJFNAAPOCJD.rotation.eulerAngles.z + num));
				}
				else
				{
					transform.position = position;
				}
			}
			Vector3 localScale = ((!followLocalScale) ? new Vector3(1f, 1f, 1f) : new Vector3(bone.IAFNPOKEFMB, bone.GFMCPIJHIGD, 1f));
			if (followSkeletonFlip)
			{
				localScale.y *= ((!(bone.GDNININLMFD.FNEPOOBKNLF ^ bone.GDNININLMFD.AIPMEJLIOFD)) ? 1f : (-1f));
			}
			transform.localScale = localScale;
		}
	}
}
