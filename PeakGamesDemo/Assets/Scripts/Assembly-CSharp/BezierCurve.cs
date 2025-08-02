using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class BezierCurve : MonoBehaviour
{
	public int resolution = 30;

	public Color drawColor = Color.white;

	[SerializeField]
	private bool _close;

	private float _length;

	[SerializeField]
	private BezierPoint[] points = new BezierPoint[0];

	public bool dirty { get; private set; }

	public bool close
	{
		get
		{
			return _close;
		}
		set
		{
			if (_close != value)
			{
				_close = value;
				dirty = true;
			}
		}
	}

	public BezierPoint this[int EHJNMODJEAN]
	{
		get
		{
			return points[EHJNMODJEAN];
		}
	}

	public int pointCount
	{
		get
		{
			return points.Length;
		}
	}

	public float length
	{
		get
		{
			if (dirty)
			{
				_length = 0f;
				for (int i = 0; i < points.Length - 1; i++)
				{
					_length += ApproximateLength(points[i], points[i + 1], resolution);
				}
				if (close)
				{
					_length += ApproximateLength(points[points.Length - 1], points[0], resolution);
				}
				dirty = false;
			}
			return _length;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = drawColor;
		if (points.Length > 1)
		{
			for (int i = 0; i < points.Length - 1; i++)
			{
				DrawCurve(points[i], points[i + 1], resolution);
			}
			if (close)
			{
				DrawCurve(points[points.Length - 1], points[0], resolution);
			}
		}
	}

	private void Awake()
	{
		dirty = true;
	}

	public void AddPoint(BezierPoint KJPPPBMDJKG)
	{
		List<BezierPoint> list = new List<BezierPoint>(points);
		list.Add(KJPPPBMDJKG);
		points = list.ToArray();
		dirty = true;
	}

	public BezierPoint AddPointAt(Vector3 LDMDBPLADGD)
	{
		GameObject gameObject = new GameObject("Point " + pointCount);
		gameObject.transform.parent = base.transform;
		gameObject.transform.position = LDMDBPLADGD;
		BezierPoint bezierPoint = gameObject.AddComponent<BezierPoint>();
		bezierPoint.curve = this;
		return bezierPoint;
	}

	public void RemovePoint(BezierPoint KJPPPBMDJKG)
	{
		List<BezierPoint> list = new List<BezierPoint>(points);
		list.Remove(KJPPPBMDJKG);
		points = list.ToArray();
		dirty = false;
	}

	public BezierPoint[] GetAnchorPoints()
	{
		return (BezierPoint[])points.Clone();
	}

	public Vector3 GetPointAt(float LLIEHCKNJEM)
	{
		if (LLIEHCKNJEM <= 0f)
		{
			return points[0].position;
		}
		if (LLIEHCKNJEM >= 1f)
		{
			return points[points.Length - 1].position;
		}
		float num = 0f;
		float num2 = 0f;
		BezierPoint bezierPoint = null;
		BezierPoint lGKCEADGHNL = null;
		for (int i = 0; i < points.Length - 1; i++)
		{
			num2 = ApproximateLength(points[i], points[i + 1]) / length;
			if (num + num2 > LLIEHCKNJEM)
			{
				bezierPoint = points[i];
				lGKCEADGHNL = points[i + 1];
				break;
			}
			num += num2;
		}
		if (close && bezierPoint == null)
		{
			bezierPoint = points[points.Length - 1];
			lGKCEADGHNL = points[0];
		}
		LLIEHCKNJEM -= num;
		return GetPoint(bezierPoint, lGKCEADGHNL, LLIEHCKNJEM / num2);
	}

	public int GetPointIndex(BezierPoint KJPPPBMDJKG)
	{
		int result = -1;
		for (int i = 0; i < points.Length; i++)
		{
			if (points[i] == KJPPPBMDJKG)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	public void SetDirty()
	{
		dirty = true;
	}

	public static void DrawCurve(BezierPoint BEGCLEDLFOO, BezierPoint LGKCEADGHNL, int FBLJNPACFAI)
	{
		int num = FBLJNPACFAI + 1;
		float num2 = FBLJNPACFAI;
		Vector3 from = BEGCLEDLFOO.position;
		Vector3 zero = Vector3.zero;
		for (int i = 1; i < num; i++)
		{
			zero = GetPoint(BEGCLEDLFOO, LGKCEADGHNL, (float)i / num2);
			Gizmos.DrawLine(from, zero);
			from = zero;
		}
	}

	public static Vector3 GetPoint(BezierPoint BEGCLEDLFOO, BezierPoint LGKCEADGHNL, float LLIEHCKNJEM)
	{
		if (BEGCLEDLFOO.handle2 != Vector3.zero)
		{
			if (LGKCEADGHNL.handle1 != Vector3.zero)
			{
				return GetCubicCurvePoint(BEGCLEDLFOO.position, BEGCLEDLFOO.globalHandle2, LGKCEADGHNL.globalHandle1, LGKCEADGHNL.position, LLIEHCKNJEM);
			}
			return GetQuadraticCurvePoint(BEGCLEDLFOO.position, BEGCLEDLFOO.globalHandle2, LGKCEADGHNL.position, LLIEHCKNJEM);
		}
		if (LGKCEADGHNL.handle1 != Vector3.zero)
		{
			return GetQuadraticCurvePoint(BEGCLEDLFOO.position, LGKCEADGHNL.globalHandle1, LGKCEADGHNL.position, LLIEHCKNJEM);
		}
		return GetLinearPoint(BEGCLEDLFOO.position, LGKCEADGHNL.position, LLIEHCKNJEM);
	}

	public static Vector3 GetCubicCurvePoint(Vector3 BEGCLEDLFOO, Vector3 LGKCEADGHNL, Vector3 IDBIBADIOEE, Vector3 IACHJBJNBPG, float LLIEHCKNJEM)
	{
		LLIEHCKNJEM = Mathf.Clamp01(LLIEHCKNJEM);
		Vector3 vector = Mathf.Pow(1f - LLIEHCKNJEM, 3f) * BEGCLEDLFOO;
		Vector3 vector2 = 3f * Mathf.Pow(1f - LLIEHCKNJEM, 2f) * LLIEHCKNJEM * LGKCEADGHNL;
		Vector3 vector3 = 3f * (1f - LLIEHCKNJEM) * Mathf.Pow(LLIEHCKNJEM, 2f) * IDBIBADIOEE;
		Vector3 vector4 = Mathf.Pow(LLIEHCKNJEM, 3f) * IACHJBJNBPG;
		return vector + vector2 + vector3 + vector4;
	}

	public static Vector3 GetQuadraticCurvePoint(Vector3 BEGCLEDLFOO, Vector3 LGKCEADGHNL, Vector3 IDBIBADIOEE, float LLIEHCKNJEM)
	{
		LLIEHCKNJEM = Mathf.Clamp01(LLIEHCKNJEM);
		Vector3 vector = Mathf.Pow(1f - LLIEHCKNJEM, 2f) * BEGCLEDLFOO;
		Vector3 vector2 = 2f * (1f - LLIEHCKNJEM) * LLIEHCKNJEM * LGKCEADGHNL;
		Vector3 vector3 = Mathf.Pow(LLIEHCKNJEM, 2f) * IDBIBADIOEE;
		return vector + vector2 + vector3;
	}

	public static Vector3 GetLinearPoint(Vector3 BEGCLEDLFOO, Vector3 LGKCEADGHNL, float LLIEHCKNJEM)
	{
		return BEGCLEDLFOO + (LGKCEADGHNL - BEGCLEDLFOO) * LLIEHCKNJEM;
	}

	public static Vector3 GetPoint(float LLIEHCKNJEM, params Vector3[] JJJGMPMMJIN)
	{
		LLIEHCKNJEM = Mathf.Clamp01(LLIEHCKNJEM);
		int num = JJJGMPMMJIN.Length - 1;
		Vector3 zero = Vector3.zero;
		for (int i = 0; i < JJJGMPMMJIN.Length; i++)
		{
			Vector3 vector = JJJGMPMMJIN[JJJGMPMMJIN.Length - i - 1] * ((float)JDPCALHLJKM(i, num) * Mathf.Pow(LLIEHCKNJEM, num - i) * Mathf.Pow(1f - LLIEHCKNJEM, i));
			zero += vector;
		}
		return zero;
	}

	public static float ApproximateLength(BezierPoint BEGCLEDLFOO, BezierPoint LGKCEADGHNL, int FBLJNPACFAI = 10)
	{
		float num = FBLJNPACFAI;
		float num2 = 0f;
		Vector3 vector = BEGCLEDLFOO.position;
		for (int i = 0; i < FBLJNPACFAI + 1; i++)
		{
			Vector3 point = GetPoint(BEGCLEDLFOO, LGKCEADGHNL, (float)i / num);
			num2 += (point - vector).magnitude;
			vector = point;
		}
		return num2;
	}

	private static int JDPCALHLJKM(int PLCFEOMGCFK, int IDHLPOFDLKJ)
	{
		return NELBBDHGLJL(IDHLPOFDLKJ) / (NELBBDHGLJL(PLCFEOMGCFK) * NELBBDHGLJL(IDHLPOFDLKJ - PLCFEOMGCFK));
	}

	private static int NELBBDHGLJL(int PLCFEOMGCFK)
	{
		if (PLCFEOMGCFK == 0)
		{
			return 1;
		}
		int num = 1;
		while (PLCFEOMGCFK - 1 >= 0)
		{
			num *= PLCFEOMGCFK;
			PLCFEOMGCFK--;
		}
		return num;
	}
}
