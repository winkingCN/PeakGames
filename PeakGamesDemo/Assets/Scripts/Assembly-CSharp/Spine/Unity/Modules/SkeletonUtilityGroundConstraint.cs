using UnityEngine;

namespace Spine.Unity.Modules
{
	[RequireComponent(typeof(SkeletonUtilityBone))]
	[ExecuteInEditMode]
	public class SkeletonUtilityGroundConstraint : SkeletonUtilityConstraint
	{
		[Tooltip("LayerMask for what objects to raycast against")]
		public LayerMask groundMask;

		[Tooltip("Use 2D")]
		public bool use2D;

		[Tooltip("Uses SphereCast for 3D mode and CircleCast for 2D mode")]
		public bool useRadius;

		[Tooltip("The Radius")]
		public float castRadius = 0.1f;

		[Tooltip("How high above the target bone to begin casting from")]
		public float castDistance = 5f;

		[Tooltip("X-Axis adjustment")]
		public float castOffset;

		[Tooltip("Y-Axis adjustment")]
		public float groundOffset;

		[Tooltip("How fast the target IK position adjusts to the ground.  Use smaller values to prevent snapping")]
		public float adjustSpeed = 5f;

		private Vector3 MLMGBDMCAIF;

		private Vector3 LFMOAGKBKDL = new Vector3(0f, -1f, 0f);

		private float PLBLNIIOONB;

		private float OKFPNMAHGJN;

		protected override void OnEnable()
		{
			base.OnEnable();
			OKFPNMAHGJN = base.transform.position.y;
		}

		public override void DoUpdate()
		{
			MLMGBDMCAIF = base.transform.position + new Vector3(castOffset, castDistance, 0f);
			PLBLNIIOONB = float.MinValue;
			if (use2D)
			{
				RaycastHit2D raycastHit2D = ((!useRadius) ? Physics2D.Raycast(MLMGBDMCAIF, LFMOAGKBKDL, castDistance + groundOffset, groundMask) : Physics2D.CircleCast(MLMGBDMCAIF, castRadius, LFMOAGKBKDL, castDistance + groundOffset, groundMask));
				if (raycastHit2D.collider != null)
				{
					PLBLNIIOONB = raycastHit2D.point.y + groundOffset;
					if (Application.isPlaying)
					{
						PLBLNIIOONB = Mathf.MoveTowards(OKFPNMAHGJN, PLBLNIIOONB, adjustSpeed * Time.deltaTime);
					}
				}
				else if (Application.isPlaying)
				{
					PLBLNIIOONB = Mathf.MoveTowards(OKFPNMAHGJN, base.transform.position.y, adjustSpeed * Time.deltaTime);
				}
			}
			else
			{
				bool flag = false;
				RaycastHit hitInfo;
				if ((!useRadius) ? Physics.Raycast(MLMGBDMCAIF, LFMOAGKBKDL, out hitInfo, castDistance + groundOffset, groundMask) : Physics.SphereCast(MLMGBDMCAIF, castRadius, LFMOAGKBKDL, out hitInfo, castDistance + groundOffset, groundMask))
				{
					PLBLNIIOONB = hitInfo.point.y + groundOffset;
					if (Application.isPlaying)
					{
						PLBLNIIOONB = Mathf.MoveTowards(OKFPNMAHGJN, PLBLNIIOONB, adjustSpeed * Time.deltaTime);
					}
				}
				else if (Application.isPlaying)
				{
					PLBLNIIOONB = Mathf.MoveTowards(OKFPNMAHGJN, base.transform.position.y, adjustSpeed * Time.deltaTime);
				}
			}
			Vector3 position = base.transform.position;
			position.y = Mathf.Clamp(position.y, Mathf.Min(OKFPNMAHGJN, PLBLNIIOONB), float.MaxValue);
			base.transform.position = position;
			GAJIKOOGPMC.bone.CBPFFIBINEH = base.transform.localPosition.x;
			GAJIKOOGPMC.bone.MOAGLBJDKKL = base.transform.localPosition.y;
			OKFPNMAHGJN = PLBLNIIOONB;
		}

		private void OnDrawGizmos()
		{
			Vector3 vector = MLMGBDMCAIF + LFMOAGKBKDL * Mathf.Min(castDistance, MLMGBDMCAIF.y - PLBLNIIOONB);
			Vector3 to = MLMGBDMCAIF + LFMOAGKBKDL * castDistance;
			Gizmos.DrawLine(MLMGBDMCAIF, vector);
			if (useRadius)
			{
				Gizmos.DrawLine(new Vector3(vector.x - castRadius, vector.y - groundOffset, vector.z), new Vector3(vector.x + castRadius, vector.y - groundOffset, vector.z));
				Gizmos.DrawLine(new Vector3(to.x - castRadius, to.y, to.z), new Vector3(to.x + castRadius, to.y, to.z));
			}
			Gizmos.color = Color.red;
			Gizmos.DrawLine(vector, to);
		}
	}
}
