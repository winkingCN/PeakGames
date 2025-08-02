using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SkeletonUtilityKinematicShadow : MonoBehaviour
	{
		private struct BPFBHNCCDLI
		{
			public Transform EAHMJBBOJKC;

			public Transform ENICBMKPJJK;
		}

		[Tooltip("If checked, the hinge chain can inherit your root transform's velocity or position/rotation changes.")]
		public bool detachedShadow;

		public Transform parent;

		public bool hideShadow = true;

		private GameObject AAKHCGJBCKJ;

		private readonly List<BPFBHNCCDLI> PEMGBLEPPNA = new List<BPFBHNCCDLI>();

		private void Start()
		{
			AAKHCGJBCKJ = Object.Instantiate(base.gameObject);
			Object.Destroy(AAKHCGJBCKJ.GetComponent<SkeletonUtilityKinematicShadow>());
			Transform transform = AAKHCGJBCKJ.transform;
			transform.position = base.transform.position;
			transform.rotation = base.transform.rotation;
			Vector3 b = base.transform.TransformPoint(Vector3.right);
			float num = Vector3.Distance(base.transform.position, b);
			transform.localScale = Vector3.one;
			if (!detachedShadow)
			{
				if (parent == null)
				{
					transform.parent = base.transform.root;
				}
				else
				{
					transform.parent = parent;
				}
			}
			if (hideShadow)
			{
				AAKHCGJBCKJ.hideFlags = HideFlags.HideInHierarchy;
			}
			Joint[] componentsInChildren = AAKHCGJBCKJ.GetComponentsInChildren<Joint>();
			Joint[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].connectedAnchor *= num;
			}
			SkeletonUtilityBone[] componentsInChildren2 = GetComponentsInChildren<SkeletonUtilityBone>();
			SkeletonUtilityBone[] componentsInChildren3 = AAKHCGJBCKJ.GetComponentsInChildren<SkeletonUtilityBone>();
			SkeletonUtilityBone[] array2 = componentsInChildren2;
			foreach (SkeletonUtilityBone skeletonUtilityBone in array2)
			{
				if (skeletonUtilityBone.gameObject == base.gameObject)
				{
					continue;
				}
				SkeletonUtilityBone[] array3 = componentsInChildren3;
				foreach (SkeletonUtilityBone skeletonUtilityBone2 in array3)
				{
					if (skeletonUtilityBone2.GetComponent<Rigidbody>() != null && skeletonUtilityBone2.boneName == skeletonUtilityBone.boneName)
					{
						PEMGBLEPPNA.Add(new BPFBHNCCDLI
						{
							EAHMJBBOJKC = skeletonUtilityBone.transform,
							ENICBMKPJJK = skeletonUtilityBone2.transform
						});
						break;
					}
				}
			}
			LPJMPDHPGFI(componentsInChildren3);
			LPJMPDHPGFI(GetComponentsInChildren<Joint>());
			LPJMPDHPGFI(GetComponentsInChildren<Rigidbody>());
			LPJMPDHPGFI(GetComponentsInChildren<Collider>());
		}

		private static void LPJMPDHPGFI(Component[] NOGEHPHKKKJ)
		{
			int i = 0;
			for (int num = NOGEHPHKKKJ.Length; i < num; i++)
			{
				Object.Destroy(NOGEHPHKKKJ[i]);
			}
		}

		private void FixedUpdate()
		{
			Rigidbody component = AAKHCGJBCKJ.GetComponent<Rigidbody>();
			component.MovePosition(base.transform.position);
			component.MoveRotation(base.transform.rotation);
			int i = 0;
			for (int count = PEMGBLEPPNA.Count; i < count; i++)
			{
				BPFBHNCCDLI bPFBHNCCDLI = PEMGBLEPPNA[i];
				bPFBHNCCDLI.EAHMJBBOJKC.localPosition = bPFBHNCCDLI.ENICBMKPJJK.localPosition;
				bPFBHNCCDLI.EAHMJBBOJKC.localRotation = bPFBHNCCDLI.ENICBMKPJJK.localRotation;
			}
		}
	}
}
