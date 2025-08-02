using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(SkeletonUtilityBone))]
	public abstract class SkeletonUtilityConstraint : MonoBehaviour
	{
		protected SkeletonUtilityBone GAJIKOOGPMC;

		protected SkeletonUtility BHOKNJLFEOG;

		protected virtual void OnEnable()
		{
			GAJIKOOGPMC = GetComponent<SkeletonUtilityBone>();
			BHOKNJLFEOG = base.transform.GetComponentInParent<SkeletonUtility>();
			BHOKNJLFEOG.RegisterConstraint(this);
		}

		protected virtual void OnDisable()
		{
			BHOKNJLFEOG.UnregisterConstraint(this);
		}

		public abstract void DoUpdate();
	}
}
