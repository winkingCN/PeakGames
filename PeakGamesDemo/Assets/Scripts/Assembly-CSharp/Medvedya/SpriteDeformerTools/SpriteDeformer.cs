using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	public abstract class SpriteDeformer : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		public class PolygonBorderPath
		{
			public int[] points;
		}

		[CompilerGenerated]
		private sealed class PILLEBIJGLF
		{
			internal Vector2 PKIBIMAALJE;

			internal int AGFNGEFDHLA(SpritePoint BEGCLEDLFOO, SpritePoint LGKCEADGHNL)
			{
				return Vector2.Distance(PKIBIMAALJE, BEGCLEDLFOO.spritePosition).CompareTo(Vector2.Distance(PKIBIMAALJE, LGKCEADGHNL.spritePosition));
			}
		}

		public List<PolygonBorderPath> borderPaths = new List<PolygonBorderPath>();

		private MeshRenderer FMAEKHIDEIK;

		[SerializeField]
		private Sprite _sprite;

		private Sprite ODBNBGGPAJH;

		private Rect MLOOGALHMIH;

		private Bounds JCEDIIBBPNF;

		[SerializeField]
		private List<SpritePoint> _points = new List<SpritePoint>();

		[SerializeField]
		private Bounds _bounds = new Bounds(Vector3.zero, new Vector3(1f, 1f, 1f));

		private List<Edge> JENCPMADNIJ = new List<Edge>();

		[SerializeField]
		private Mesh mesh;

		protected Vector2 PEHFJBBAMHI;

		protected Vector2 KIEEDCONKIB;

		private Vector2 CHDCMAFBABK;

		private Vector2 JJLAJPLKGHD;

		[NonSerialized]
		public bool dirty_sprite;

		[NonSerialized]
		public bool dirty_offset;

		[NonSerialized]
		public bool dirty_tris;

		[NonSerialized]
		public bool dirty_collider;

		[NonSerialized]
		public bool dirty_uv;

		[NonSerialized]
		public bool dirty_color;

		[NonSerialized]
		public bool dirty_normals;

		[SerializeField]
		private bool _triangulateWithOffsetPosition;

		[SerializeField]
		protected Vector2[] mesh_uvs;

		[SerializeField]
		protected Vector3[] mesh_vertecs;

		[SerializeField]
		protected int[] mesh_triangles;

		[SerializeField]
		protected Vector3[] mesh_normals;

		[SerializeField]
		protected Color[] mesh_colors;

		[SerializeField]
		private Vector2 _scale = new Vector2(1f, 1f);

		private Vector2 GLLLEMKIMHH;

		protected GCJPGGACJPC BMDKDADLDPM;

		[SerializeField]
		private List<EdgeSerialization> edgeSerializations;

		[SerializeField]
		private int lastID;

		[SerializeField]
		private float minimumTimeToUpdate;

		private float GBMHPPIEKDM;

		private PolygonCollider2D IEGNIIAKMAE;

		private Vector2[][] KHAPHJOMANO;

		[SerializeField]
		private bool _generateColliderInRunTime;

		public MeshRenderer FJOOPODJMFC
		{
			get
			{
				if (FMAEKHIDEIK == null)
				{
					FMAEKHIDEIK = GetComponent<MeshRenderer>();
				}
				return FMAEKHIDEIK;
			}
		}

		public virtual Sprite MJOJAOIHCIO
		{
			get
			{
				return _sprite;
			}
			set
			{
				if (!(_sprite == value))
				{
					PJMPCKADKLI(_sprite, value);
					_sprite = value;
					ODBNBGGPAJH = value;
					dirty_sprite = true;
					if (!Application.isPlaying)
					{
						Update();
					}
				}
			}
		}

		public List<SpritePoint> JJJGMPMMJIN
		{
			get
			{
				return _points;
			}
		}

		public Bounds DJKHEGCCHFI
		{
			get
			{
				return _bounds;
			}
			set
			{
				_bounds = value;
				if (mesh != null)
				{
					mesh.bounds = value;
				}
			}
		}

		public List<Edge> BCPKCBPJBGN
		{
			get
			{
				return JENCPMADNIJ;
			}
		}

		public bool FLNFGBKEKMA
		{
			get
			{
				return _triangulateWithOffsetPosition;
			}
			set
			{
				if (value != _triangulateWithOffsetPosition)
				{
					_triangulateWithOffsetPosition = value;
					dirty_tris = true;
					if (!Application.isPlaying)
					{
						UpdateMeshImmediate();
					}
				}
			}
		}

		public Vector2 HJLOCAEAFMJ
		{
			get
			{
				return _scale;
			}
			set
			{
				if (!(value == _scale))
				{
					_scale = value;
					dirty_offset = true;
					GLLLEMKIMHH = value;
				}
			}
		}

		public float ADEKDCIDHBP
		{
			get
			{
				if (minimumTimeToUpdate == 0f)
				{
					return 0f;
				}
				return 1f / minimumTimeToUpdate;
			}
			set
			{
				if (value == 0f)
				{
					minimumTimeToUpdate = 0f;
				}
				else
				{
					minimumTimeToUpdate = 1f / value;
				}
			}
		}

		protected PolygonCollider2D JJFLFNCKEJM
		{
			get
			{
				if (IEGNIIAKMAE == null)
				{
					IEGNIIAKMAE = base.gameObject.GetComponent<PolygonCollider2D>();
				}
				if (IEGNIIAKMAE == null)
				{
					IEGNIIAKMAE = base.gameObject.AddComponent<PolygonCollider2D>();
				}
				return IEGNIIAKMAE;
			}
		}

		public bool PAFBBGFJBFH
		{
			get
			{
				return _generateColliderInRunTime;
			}
			set
			{
				if (value != _generateColliderInRunTime)
				{
					_generateColliderInRunTime = value;
					if (value)
					{
						dirty_collider = true;
					}
				}
			}
		}

		public void FreezeScale()
		{
			Vector3 localScale = base.transform.localScale;
			if (localScale != new Vector3(1f, 1f, 1f))
			{
				HJLOCAEAFMJ = Vector2.Scale(localScale, HJLOCAEAFMJ);
				base.transform.localScale = new Vector3(1f, 1f, 1f);
			}
		}

		public void CreateNewMesh(bool LIALGJFKHDE = false)
		{
			mesh = new Mesh();
			MeshFilter component = GetComponent<MeshFilter>();
			if (component.sharedMesh != null && LIALGJFKHDE)
			{
				UnityEngine.Object.DestroyImmediate(component.sharedMesh);
			}
			if (!Application.isPlaying)
			{
				component.sharedMesh = mesh;
			}
			else
			{
				component.mesh = mesh;
			}
		}

		public void ClearPoints()
		{
			while (JJJGMPMMJIN.Count > 0)
			{
				RemovePoint(JJJGMPMMJIN[0]);
			}
		}

		public void ClearEdges()
		{
			while (JENCPMADNIJ.Count > 0)
			{
				JENCPMADNIJ.Clear();
			}
			dirty_tris = true;
		}

		public void SetRectanglePoints()
		{
			ClearEdges();
			ClearPoints();
			SpritePoint spritePoint = new SpritePoint(0f, 1f);
			SpritePoint spritePoint2 = new SpritePoint(0f, 0f);
			SpritePoint spritePoint3 = new SpritePoint(1f, 1f);
			SpritePoint spritePoint4 = new SpritePoint(1f, 0f);
			AddPoint(spritePoint);
			AddPoint(spritePoint2);
			AddPoint(spritePoint3);
			AddPoint(spritePoint4);
			AddEdge(new Edge(spritePoint, spritePoint3));
			AddEdge(new Edge(spritePoint3, spritePoint4));
			AddEdge(new Edge(spritePoint4, spritePoint2));
			AddEdge(new Edge(spritePoint2, spritePoint));
		}

		public void RecalculateSpriteInfo()
		{
			if (MJOJAOIHCIO == null)
			{
				return;
			}
			if (MJOJAOIHCIO.packed && MJOJAOIHCIO.packingMode == SpritePackingMode.Tight)
			{
				Debug.LogException(new Exception("Sprite packer -> TightPackerPolicy is not supported. Please use DefaultPackerPolicy"));
				return;
			}
			if (Application.isPlaying)
			{
				PEHFJBBAMHI = new Vector2(MJOJAOIHCIO.textureRect.x / (float)MJOJAOIHCIO.texture.width, MJOJAOIHCIO.textureRect.y / (float)MJOJAOIHCIO.texture.height);
				PEHFJBBAMHI -= new Vector2(MJOJAOIHCIO.textureRectOffset.x / (float)MJOJAOIHCIO.texture.width, MJOJAOIHCIO.textureRectOffset.y / (float)MJOJAOIHCIO.texture.height);
				KIEEDCONKIB = new Vector2(MJOJAOIHCIO.rect.width / (float)MJOJAOIHCIO.texture.width, MJOJAOIHCIO.rect.height / (float)MJOJAOIHCIO.texture.height);
			}
			else
			{
				PEHFJBBAMHI = new Vector2(MJOJAOIHCIO.rect.x / (float)MJOJAOIHCIO.texture.width, MJOJAOIHCIO.rect.y / (float)MJOJAOIHCIO.texture.height);
				KIEEDCONKIB = new Vector2(MJOJAOIHCIO.rect.width / (float)MJOJAOIHCIO.texture.width, MJOJAOIHCIO.rect.height / (float)MJOJAOIHCIO.texture.height);
			}
			CHDCMAFBABK = MJOJAOIHCIO.rect.size / MJOJAOIHCIO.pixelsPerUnit;
			JJLAJPLKGHD = -MJOJAOIHCIO.pivot / MJOJAOIHCIO.pixelsPerUnit;
		}

		protected void FAOBFAOFJKH()
		{
			if (BMDKDADLDPM == null)
			{
				BMDKDADLDPM = new GCJPGGACJPC(this);
			}
			BMDKDADLDPM.EINPIGOIKNM = FLNFGBKEKMA;
			BMDKDADLDPM.DCDHMENEMPD();
			borderPaths.Clear();
			foreach (GCJPGGACJPC.IFJNBEGNKME item in BMDKDADLDPM.EIEPBFGLFLJ)
			{
				PolygonBorderPath polygonBorderPath = new PolygonBorderPath();
				borderPaths.Add(polygonBorderPath);
				List<int> list = new List<int>();
				foreach (GCJPGGACJPC.KFKHBELKJHG item2 in item.DLGOFMAJNIC)
				{
					list.Add(item2.EHJNMODJEAN);
				}
				polygonBorderPath.points = list.ToArray();
			}
		}

		private static void CNGNBKCLILD<T>(ref T[] KDOGMDCDCEN, int EFILDOIJABE)
		{
			if (KDOGMDCDCEN == null)
			{
				KDOGMDCDCEN = new T[EFILDOIJABE];
			}
			else if (KDOGMDCDCEN.Length != EFILDOIJABE)
			{
				Array.Resize(ref KDOGMDCDCEN, EFILDOIJABE);
			}
		}

		protected virtual void PINIBJIOJCJ(bool PGCKHGIALDB, bool HDKHEEKBECI, bool FCCDCJHPBDG, bool BKJBHOEKGFF, bool GFIEOMENFFA)
		{
			if (FCCDCJHPBDG || BKJBHOEKGFF || HDKHEEKBECI || GFIEOMENFFA)
			{
				if (GFIEOMENFFA)
				{
					CNGNBKCLILD(ref mesh_normals, _points.Count);
				}
				if (BKJBHOEKGFF)
				{
					CNGNBKCLILD(ref mesh_colors, _points.Count);
				}
				if (FCCDCJHPBDG)
				{
					CNGNBKCLILD(ref mesh_vertecs, _points.Count);
				}
				if (HDKHEEKBECI)
				{
					CNGNBKCLILD(ref mesh_uvs, _points.Count);
				}
				for (int i = 0; i < _points.Count; i++)
				{
					SpritePoint spritePoint = _points[i];
					if (FCCDCJHPBDG)
					{
						Vector3 vector = SpritePositionToLocal(getSpritePositionOfSpritePoint(spritePoint));
						vector.z = spritePoint.offsets[0].z;
						mesh_vertecs[i] = vector;
					}
					if (GFIEOMENFFA)
					{
						mesh_normals[i] = Vector3.forward;
					}
					if (BKJBHOEKGFF)
					{
						mesh_colors[i] = spritePoint.color;
					}
					if (HDKHEEKBECI)
					{
						mesh_uvs[i] = Vector2.Scale(KIEEDCONKIB, spritePoint.spritePosition) + PEHFJBBAMHI;
					}
				}
			}
			if (PGCKHGIALDB)
			{
				FAOBFAOFJKH();
				mesh_triangles = BMDKDADLDPM.MCCHCDINFDN;
			}
		}

		protected void KHFOJKHKMIG(bool PGCKHGIALDB, bool HDKHEEKBECI, bool FCCDCJHPBDG, bool BKJBHOEKGFF, bool GFIEOMENFFA)
		{
			if (!(mesh == null))
			{
				if (PGCKHGIALDB)
				{
					mesh.Clear();
				}
				if (PGCKHGIALDB || FCCDCJHPBDG)
				{
					mesh.MarkDynamic();
					mesh.vertices = mesh_vertecs;
				}
				if (PGCKHGIALDB || GFIEOMENFFA)
				{
					mesh.normals = mesh_normals;
				}
				if (PGCKHGIALDB || HDKHEEKBECI)
				{
					mesh.uv = mesh_uvs;
				}
				if (PGCKHGIALDB)
				{
					mesh.triangles = mesh_triangles;
				}
				if (PGCKHGIALDB || BKJBHOEKGFF)
				{
					mesh.colors = mesh_colors;
				}
			}
		}

		public SpritePoint DivedeEdge(IGKJBLFOHGB MKIDBBBHBIC, bool NJMABEFFHDM = false)
		{
			SpritePoint spritePoint = new SpritePoint(MKIDBBBHBIC.LDMDBPLADGD);
			Edge eKFOKNPODBK = new Edge(MKIDBBBHBIC.KIPPNCKFODM.point1, spritePoint);
			Edge eKFOKNPODBK2 = new Edge(spritePoint, MKIDBBBHBIC.KIPPNCKFODM.point2);
			AddPoint(spritePoint);
			AddEdge(eKFOKNPODBK);
			AddEdge(eKFOKNPODBK2);
			if (NJMABEFFHDM)
			{
				float num = Vector2.Distance(MKIDBBBHBIC.KIPPNCKFODM.point1.spritePosition, MKIDBBBHBIC.LDMDBPLADGD);
				float num2 = Vector2.Distance(MKIDBBBHBIC.KIPPNCKFODM.point2.spritePosition, MKIDBBBHBIC.LDMDBPLADGD);
				float num3 = num + num2;
				float t = num / num3;
				Vector2 vector = Vector2.Lerp(MKIDBBBHBIC.KIPPNCKFODM.point1.spritePosition + MKIDBBBHBIC.KIPPNCKFODM.point1.offset2d, MKIDBBBHBIC.KIPPNCKFODM.point2.spritePosition + MKIDBBBHBIC.KIPPNCKFODM.point2.offset2d, t);
				spritePoint.offset2d = vector - spritePoint.spritePosition;
			}
			RemoveEdge(MKIDBBBHBIC.KIPPNCKFODM);
			return spritePoint;
		}

		public void AddEdge(Edge EKFOKNPODBK)
		{
			JENCPMADNIJ.Add(EKFOKNPODBK);
			dirty_tris = true;
		}

		public IGKJBLFOHGB GetClosestEdge(Vector2 FLABDDEGAFC, Edge[] PBIOCPDBIEK = null)
		{
			IGKJBLFOHGB iGKJBLFOHGB = new IGKJBLFOHGB();
			float num = float.MaxValue;
			List<Edge> list = null;
			if (PBIOCPDBIEK != null)
			{
				list = new List<Edge>(PBIOCPDBIEK);
			}
			foreach (Edge edge in BCPKCBPJBGN)
			{
				if (PBIOCPDBIEK == null || !list.Contains(edge))
				{
					Vector2 vector = edge.GOEBMAFKEEG(FLABDDEGAFC);
					float num2 = Vector2.Distance(FLABDDEGAFC, vector);
					if (num2 < num)
					{
						num = num2;
						iGKJBLFOHGB.KIPPNCKFODM = edge;
						iGKJBLFOHGB.LDMDBPLADGD = vector;
					}
				}
			}
			return iGKJBLFOHGB;
		}

		public List<Edge> GetEdgesWithPoint(SpritePoint HPHBDNBJPHB)
		{
			List<Edge> list = new List<Edge>();
			foreach (Edge edge in BCPKCBPJBGN)
			{
				if (edge.GKMPJGIJPPO(HPHBDNBJPHB))
				{
					list.Add(edge);
				}
			}
			return list;
		}

		public Edge GetEdgeWithTwoPoints(SpritePoint HPHBDNBJPHB, SpritePoint LGKCEADGHNL)
		{
			foreach (Edge edge in BCPKCBPJBGN)
			{
				if (edge.GKMPJGIJPPO(HPHBDNBJPHB) && edge.GKMPJGIJPPO(LGKCEADGHNL))
				{
					return edge;
				}
			}
			return null;
		}

		public List<Edge> GetEdgesWithEdge(Edge KIPPNCKFODM)
		{
			List<Edge> list = new List<Edge>();
			foreach (Edge edge in BCPKCBPJBGN)
			{
				if (edge.GKMPJGIJPPO(KIPPNCKFODM.point1) || edge.GKMPJGIJPPO(KIPPNCKFODM.point2))
				{
					list.Add(edge);
				}
			}
			return list;
		}

		public List<SpritePoint> GetСonnectedPoint(SpritePoint KJPPPBMDJKG, string DGDNDOKHIGC = "")
		{
			List<SpritePoint> list = new List<SpritePoint>();
			List<Edge> edgesWithPoint = GetEdgesWithPoint(KJPPPBMDJKG);
			foreach (Edge item in edgesWithPoint)
			{
				if (item.GKMPJGIJPPO(KJPPPBMDJKG))
				{
					SpritePoint spritePoint = ((item.point1 != KJPPPBMDJKG) ? item.point1 : item.point2);
					if (DGDNDOKHIGC == string.Empty || DGDNDOKHIGC == spritePoint.name)
					{
						list.Add(spritePoint);
					}
				}
			}
			return list;
		}

		public bool ContainsEdge(SpritePoint BEGCLEDLFOO, SpritePoint LGKCEADGHNL)
		{
			foreach (Edge edge in BCPKCBPJBGN)
			{
				if ((edge.point1 == BEGCLEDLFOO && edge.point2 == LGKCEADGHNL) || (edge.point1 == LGKCEADGHNL && edge.point2 == BEGCLEDLFOO))
				{
					return true;
				}
			}
			return false;
		}

		public void OnBeforeSerialize()
		{
			edgeSerializations = new List<EdgeSerialization>();
			for (int i = 0; i < BCPKCBPJBGN.Count; i++)
			{
				edgeSerializations.Add(new EdgeSerialization(JJJGMPMMJIN.IndexOf(BCPKCBPJBGN[i].point1), JJJGMPMMJIN.IndexOf(BCPKCBPJBGN[i].point2)));
			}
		}

		public virtual void OnAfterDeserialize()
		{
			JENCPMADNIJ = new List<Edge>();
			for (int i = 0; i < edgeSerializations.Count; i++)
			{
				EdgeSerialization edgeSerialization = edgeSerializations[i];
				JENCPMADNIJ.Add(new Edge(JJJGMPMMJIN[edgeSerialization.point1Index], JJJGMPMMJIN[edgeSerialization.point2index]));
			}
		}

		public void SetAllDirty(bool ILPLNHIOBME = true)
		{
			dirty_tris = ILPLNHIOBME;
			dirty_color = ILPLNHIOBME;
			dirty_normals = ILPLNHIOBME;
			dirty_offset = ILPLNHIOBME;
			dirty_uv = ILPLNHIOBME;
			dirty_sprite = ILPLNHIOBME;
		}

		public virtual void AddPoint(SpritePoint KJPPPBMDJKG, bool NJMABEFFHDM = false)
		{
			if (KJPPPBMDJKG.id != 0)
			{
				Debug.LogError("SpritePoint is not unique", this);
				return;
			}
			lastID++;
			KJPPPBMDJKG.id = lastID;
			_points.Add(KJPPPBMDJKG);
			SetAllDirty();
			if (!NJMABEFFHDM)
			{
				return;
			}
			SpritePoint[] triangleAroundPoint = GetTriangleAroundPoint(KJPPPBMDJKG);
			if (triangleAroundPoint == null)
			{
				return;
			}
			Vector2 spritePosition = triangleAroundPoint[0].spritePosition;
			Vector2 spritePosition2 = triangleAroundPoint[1].spritePosition;
			Vector2 spritePosition3 = triangleAroundPoint[2].spritePosition;
			Vector2 vector = triangleAroundPoint[0].spritePosition + (Vector2)triangleAroundPoint[0].offset;
			Vector2 vector2 = triangleAroundPoint[1].spritePosition + (Vector2)triangleAroundPoint[1].offset;
			Vector2 vector3 = triangleAroundPoint[2].spritePosition + (Vector2)triangleAroundPoint[2].offset;
			float num = KAJFMDNGDCP.EDCBCGKJCLN(spritePosition, spritePosition2, spritePosition3);
			if (num == 0f)
			{
				return;
			}
			float num2 = KAJFMDNGDCP.EDCBCGKJCLN(spritePosition2, spritePosition3, KJPPPBMDJKG.spritePosition) / num;
			if (num2 < 0f)
			{
				return;
			}
			float num3 = KAJFMDNGDCP.EDCBCGKJCLN(spritePosition3, spritePosition, KJPPPBMDJKG.spritePosition) / num;
			if (!(num3 < 0f))
			{
				float num4 = KAJFMDNGDCP.EDCBCGKJCLN(spritePosition, spritePosition2, KJPPPBMDJKG.spritePosition) / num;
				if (!(num4 < 0f))
				{
					Vector2 vector4 = num2 * vector + num3 * vector2 + num4 * vector3;
					KJPPPBMDJKG.offset = vector4 - KJPPPBMDJKG.spritePosition;
				}
			}
		}

		public SpritePoint[] GetTriangleAroundPoint(SpritePoint KJPPPBMDJKG)
		{
			for (int i = 0; i < mesh_triangles.Length; i += 3)
			{
				int index = mesh_triangles[i];
				int index2 = mesh_triangles[i + 1];
				int index3 = mesh_triangles[i + 2];
				if (KAJFMDNGDCP.PGKFNNNLKPP(JJJGMPMMJIN[index].spritePosition, JJJGMPMMJIN[index2].spritePosition, JJJGMPMMJIN[index3].spritePosition, KJPPPBMDJKG.spritePosition))
				{
					return new SpritePoint[3]
					{
						JJJGMPMMJIN[index],
						JJJGMPMMJIN[index2],
						JJJGMPMMJIN[index3]
					};
				}
			}
			return null;
		}

		public Vector2 SpritePositionToLocal(Vector2 LFGOFBOIPCJ)
		{
			Vector2 a = Vector2.Scale(LFGOFBOIPCJ, CHDCMAFBABK) + JJLAJPLKGHD;
			return Vector2.Scale(a, _scale);
		}

		public Vector3 SpritePositionToGlobal(Vector2 LFGOFBOIPCJ)
		{
			return base.transform.TransformPoint(SpritePositionToLocal(LFGOFBOIPCJ));
		}

		public Vector2 LocalPositionToSpritePosition(Vector2 DLKBJLNCHBE)
		{
			return new Vector2(DLKBJLNCHBE.x / CHDCMAFBABK.x / _scale.x, DLKBJLNCHBE.y / CHDCMAFBABK.y / _scale.y) - new Vector2(JJLAJPLKGHD.x / CHDCMAFBABK.x, JJLAJPLKGHD.y / CHDCMAFBABK.y);
		}

		public Vector2 GlobalPositionToSpritePosition(Vector3 GELBNILDNJP)
		{
			return LocalPositionToSpritePosition(base.transform.InverseTransformPoint(GELBNILDNJP));
		}

		protected virtual void Update()
		{
			GBMHPPIEKDM += Time.unscaledDeltaTime;
			if (FJOOPODJMFC != null && FJOOPODJMFC.isVisible && (GBMHPPIEKDM >= minimumTimeToUpdate || !Application.isPlaying))
			{
				GBMHPPIEKDM = 0f;
				UpdateMeshImmediate();
			}
			if (!Application.isPlaying && MJOJAOIHCIO != null && (MLOOGALHMIH != MJOJAOIHCIO.rect || JCEDIIBBPNF != MJOJAOIHCIO.bounds))
			{
				MLOOGALHMIH = MJOJAOIHCIO.rect;
				JCEDIIBBPNF = MJOJAOIHCIO.bounds;
				dirty_sprite = true;
				UpdateMeshImmediate();
			}
		}

		protected virtual void PJMPCKADKLI(Sprite IHPCGJBFPFP, Sprite GNHNPAMIEBN)
		{
		}

		public virtual void RemovePoint(SpritePoint HPHBDNBJPHB)
		{
			SetAllDirty();
			List<Edge> list = new List<Edge>();
			list.AddRange(GetEdgesWithPoint(HPHBDNBJPHB));
			foreach (Edge item in list)
			{
				RemoveEdge(item);
			}
			_points.Remove(HPHBDNBJPHB);
		}

		public void RemovePoints(SpritePoint[] JJJGMPMMJIN)
		{
			foreach (SpritePoint hPHBDNBJPHB in JJJGMPMMJIN)
			{
				RemovePoint(hPHBDNBJPHB);
			}
		}

		public void RemoveEdge(Edge EKFOKNPODBK)
		{
			JENCPMADNIJ.Remove(EKFOKNPODBK);
			dirty_tris = true;
			dirty_offset = true;
		}

		public Edge CreateEdge(SpritePoint BEGCLEDLFOO, SpritePoint LGKCEADGHNL)
		{
			Edge edge = new Edge(BEGCLEDLFOO, LGKCEADGHNL);
			JENCPMADNIJ.Add(edge);
			dirty_tris = true;
			return edge;
		}

		private IGKJBLFOHGB[] OJCGMPHCOCF(Vector2 PKIBIMAALJE, Vector2 OFFFLJCPAJE)
		{
			List<IGKJBLFOHGB> list = new List<IGKJBLFOHGB>();
			foreach (Edge edge in BCPKCBPJBGN)
			{
				Vector2 KJPPPBMDJKG = Vector2.zero;
				if (JCKBIKMBGHO.FLNOJOGHHMC(PKIBIMAALJE, OFFFLJCPAJE, edge.point1.spritePosition, edge.point2.spritePosition, out KJPPPBMDJKG))
				{
					list.Add(new IGKJBLFOHGB(KJPPPBMDJKG, edge));
				}
			}
			return list.ToArray();
		}

		private void EOOGHHPNPOB(Vector2[] JJJGMPMMJIN)
		{
			for (int i = 0; i < JJJGMPMMJIN.Length - 1; i++)
			{
				Vector2 PKIBIMAALJE = JJJGMPMMJIN[i];
				Vector2 oFFFLJCPAJE = JJJGMPMMJIN[i + 1];
				IGKJBLFOHGB[] array = OJCGMPHCOCF(PKIBIMAALJE, oFFFLJCPAJE);
				List<SpritePoint> list = new List<SpritePoint>();
				IGKJBLFOHGB[] array2 = array;
				foreach (IGKJBLFOHGB mKIDBBBHBIC in array2)
				{
					list.Add(DivedeEdge(mKIDBBBHBIC));
				}
				list.Sort((SpritePoint BEGCLEDLFOO, SpritePoint LGKCEADGHNL) => Vector2.Distance(PKIBIMAALJE, BEGCLEDLFOO.spritePosition).CompareTo(Vector2.Distance(PKIBIMAALJE, LGKCEADGHNL.spritePosition)));
				for (int k = 0; k < list.Count - 1; k++)
				{
					CreateEdge(list[k], list[k + 1]);
				}
			}
		}

		private void EOOGHHPNPOB(Vector2 PKIBIMAALJE, Vector2 OFFFLJCPAJE)
		{
			EOOGHHPNPOB(new Vector2[2] { PKIBIMAALJE, OFFFLJCPAJE });
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Awake()
		{
			int sortingLayerID = 0;
			int sortingOrder = 0;
			bool flag = false;
			SpriteRenderer component = base.gameObject.GetComponent<SpriteRenderer>();
			Sprite sprite = null;
			if (component != null)
			{
				sprite = component.sprite;
				sortingLayerID = component.sortingLayerID;
				sortingOrder = component.sortingOrder;
				flag = true;
				UnityEngine.Object.DestroyImmediate(component);
			}
			if (base.gameObject.GetComponent<MeshRenderer>() == null)
			{
				FMAEKHIDEIK = base.gameObject.AddComponent<MeshRenderer>();
			}
			if (base.gameObject.GetComponent<MeshFilter>() == null)
			{
				base.gameObject.AddComponent<MeshFilter>();
			}
			if (flag)
			{
				FJOOPODJMFC.sortingLayerID = sortingLayerID;
				FJOOPODJMFC.sortingOrder = sortingOrder;
			}
			if (sprite != null)
			{
				MJOJAOIHCIO = sprite;
				SetRectanglePoints();
			}
			if (!Application.isPlaying)
			{
				if (MJOJAOIHCIO != null)
				{
					MLOOGALHMIH = MJOJAOIHCIO.rect;
					JCEDIIBBPNF = MJOJAOIHCIO.bounds;
				}
				SpriteDeformer[] components = base.gameObject.GetComponents<SpriteDeformer>();
				if (components.Length > 1)
				{
					SpriteDeformer[] array = components;
					foreach (SpriteDeformer spriteDeformer in array)
					{
						if (!(spriteDeformer != this))
						{
							continue;
						}
						MJOJAOIHCIO = spriteDeformer.MJOJAOIHCIO;
						foreach (SpritePoint point in spriteDeformer.JJJGMPMMJIN)
						{
							AddPoint(point);
						}
						foreach (Edge edge in spriteDeformer.BCPKCBPJBGN)
						{
							AddEdge(edge);
						}
						UnityEngine.Object.DestroyImmediate(spriteDeformer);
						dirty_tris = true;
						dirty_offset = true;
						break;
					}
				}
			}
			if (_points.Count > 0 && _points[0].id == 0)
			{
				CDLFHGDGIPN();
			}
			dirty_sprite = true;
			ODBNBGGPAJH = _sprite;
			GLLLEMKIMHH = _scale;
			UpdateMeshImmediate();
			CreateNewMesh();
			mesh.bounds = DJKHEGCCHFI;
			KHFOJKHKMIG(true, true, true, true, true);
			if (Application.isPlaying && !GetComponent<Renderer>().isVisible)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDestroy()
		{
			UnityEngine.Object.DestroyImmediate(mesh);
		}

		public Vector2 getOffsetPointPositionByGlobalPosition(SpritePoint KJPPPBMDJKG, Vector3 GELBNILDNJP)
		{
			Vector2 vector = GlobalPositionToSpritePosition(GELBNILDNJP);
			return vector - KJPPPBMDJKG.spritePosition;
		}

		public void UpdateMeshImmediate()
		{
			if (GLLLEMKIMHH != _scale)
			{
				dirty_offset = true;
				GLLLEMKIMHH = HJLOCAEAFMJ;
			}
			if (ODBNBGGPAJH != _sprite)
			{
				dirty_sprite = true;
				PJMPCKADKLI(ODBNBGGPAJH, _sprite);
				ODBNBGGPAJH = _sprite;
			}
			if (dirty_tris || dirty_offset || dirty_sprite || dirty_offset)
			{
			}
			if (dirty_sprite)
			{
				RecalculateSpriteInfo();
				dirty_offset = true;
				dirty_uv = true;
			}
			if (dirty_tris || dirty_uv || dirty_offset || dirty_color || dirty_normals)
			{
				PINIBJIOJCJ(dirty_tris, dirty_uv, dirty_offset, dirty_color, dirty_normals);
				KHFOJKHKMIG(dirty_tris, dirty_uv, dirty_offset, dirty_color, dirty_normals);
				if (dirty_offset || dirty_uv || dirty_tris)
				{
					dirty_collider = true;
				}
			}
			SetAllDirty(false);
		}

		public virtual Vector2 getSpritePositionOfSpritePoint(SpritePoint KJPPPBMDJKG)
		{
			return KJPPPBMDJKG.spritePosition + (Vector2)KJPPPBMDJKG.offsets[0];
		}

		protected void FixedUpdate()
		{
			if (_generateColliderInRunTime && dirty_collider)
			{
				GenerateCollider();
			}
			dirty_collider = false;
		}

		public void GenerateCollider()
		{
			CNGNBKCLILD(ref KHAPHJOMANO, borderPaths.Count);
			JJFLFNCKEJM.pathCount = borderPaths.Count;
			for (int i = 0; i < borderPaths.Count; i++)
			{
				PolygonBorderPath polygonBorderPath = borderPaths[i];
				CNGNBKCLILD(ref KHAPHJOMANO[i], polygonBorderPath.points.Length);
				for (int j = 0; j < polygonBorderPath.points.Length; j++)
				{
					SpritePoint spritePoint = _points[polygonBorderPath.points[j]];
					KHAPHJOMANO[i][j] = SpritePositionToLocal(getSpritePositionOfSpritePoint(spritePoint) + spritePoint.colliderOffset);
				}
				JJFLFNCKEJM.SetPath(i, KHAPHJOMANO[i]);
			}
		}

		protected void OnBecameVisible()
		{
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
		}

		private void OnBecameInvisible()
		{
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
		}

		private void CDLFHGDGIPN()
		{
			foreach (SpritePoint point in _points)
			{
				lastID++;
				point.id = lastID;
			}
		}
	}
}
