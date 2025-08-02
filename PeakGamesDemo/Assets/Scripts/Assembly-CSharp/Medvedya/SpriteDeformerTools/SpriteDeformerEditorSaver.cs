using System;
using System.Collections.Generic;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[Serializable]
	public class SpriteDeformerEditorSaver
	{
		public enum PIJKCBEFOAB
		{
			Encapsulate = 0,
			CROPE = 1,
			USER = 2,
			NEED_SELECT = 3
		}

		[SerializeField]
		public PIJKCBEFOAB boundsEditorMode = PIJKCBEFOAB.NEED_SELECT;

		public Vector2 pivot;

		public float oriant;

		public AFNLCLMPDLM mainToolBar;

		public List<SpritePoint> selectedPoints = new List<SpritePoint>();

		[SerializeField]
		public int[] serelizableSelectedPoints;

		public bool inversGizmos;

		public bool generateColliderInEditor;

		public Color paintColor = Color.white;

		public bool autoFreezeScale;

		public bool savePivot;

		public int selectShape;
	}
}
