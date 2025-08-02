using System;
using System.Collections.Generic;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[ExecuteInEditMode]
	public class SpriteDeformerTargetPoints : SpriteDeformerWithMaterialPropertyBlock, ISerializationCallbackReceiver
	{
		[Serializable]
		public class PointMover
		{
			public Transform transform;

			public SpritePoint point;

			public int pointIndex;

			public Vector3 lastPosition;

			public PointMover(Transform ANLKLKAINEO, SpritePoint KJPPPBMDJKG)
			{
				transform = ANLKLKAINEO;
				lastPosition = ANLKLKAINEO.position;
				point = KJPPPBMDJKG;
			}
		}

		public bool dirty;

		public List<PointMover> pointMovers = new List<PointMover>();

		[SerializeField]
		private Transform _tranformPointGroup;

		private Transform GHMDKBBFKBJ
		{
			get
			{
				if (_tranformPointGroup == null)
				{
					_tranformPointGroup = new GameObject().transform;
					_tranformPointGroup.gameObject.name = "Animation points group";
					_tranformPointGroup.parent = base.transform;
					_tranformPointGroup.localPosition = Vector3.zero;
					_tranformPointGroup.localRotation = Quaternion.identity;
					_tranformPointGroup.localScale = new Vector3(1f, 1f, 1f);
				}
				return _tranformPointGroup;
			}
		}

		protected override void Awake()
		{
			base.Awake();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
		}

		protected override void Update()
		{
			if (!Application.isPlaying)
			{
				fixErrors();
			}
			dirty = false;
			foreach (PointMover pointMover in pointMovers)
			{
				if (!(pointMover.transform == null) && pointMover.transform.position != pointMover.lastPosition)
				{
					dirty = true;
					pointMover.lastPosition = pointMover.transform.position;
					pointMover.point.offset = getOffsetPointPositionByGlobalPosition(pointMover.point, pointMover.lastPosition);
				}
			}
			if (dirty)
			{
				dirty_offset = true;
			}
			base.Update();
		}

		public PointMover getAnimationPoint(SpritePoint HPHBDNBJPHB)
		{
			foreach (PointMover pointMover in pointMovers)
			{
				if (pointMover.point == HPHBDNBJPHB)
				{
					return pointMover;
				}
			}
			return null;
		}

		public void fixErrors()
		{
			List<PointMover> list = new List<PointMover>();
			foreach (PointMover pointMover in pointMovers)
			{
				if (pointMover.transform == null)
				{
					list.Add(pointMover);
				}
			}
			foreach (PointMover item in list)
			{
				pointMovers.Remove(item);
			}
		}

		public void addMoverPoint(SpritePoint KJPPPBMDJKG, Transform CAEMELGEOAE)
		{
			PointMover item = new PointMover(CAEMELGEOAE, KJPPPBMDJKG);
			pointMovers.Add(item);
		}

		public override void RemovePoint(SpritePoint HPHBDNBJPHB)
		{
			PointMover animationPoint = getAnimationPoint(HPHBDNBJPHB);
			if (animationPoint != null)
			{
				pointMovers.Remove(animationPoint);
			}
			base.RemovePoint(HPHBDNBJPHB);
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			base.OnAfterDeserialize();
			foreach (PointMover pointMover in pointMovers)
			{
				pointMover.point = base.JJJGMPMMJIN[pointMover.pointIndex];
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			OnBeforeSerialize();
			foreach (PointMover pointMover in pointMovers)
			{
				pointMover.pointIndex = base.JJJGMPMMJIN.IndexOf(pointMover.point);
			}
		}
	}
}
