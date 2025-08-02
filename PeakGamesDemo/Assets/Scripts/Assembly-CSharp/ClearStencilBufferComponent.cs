using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ClearStencilBufferComponent : SkipMasking
{
	protected static volatile ClearStencilBufferComponent KNPOFJNFLJB;

	public const string SHADER_MASK_CLEAR = "SpriteMask/ClearStencil";

	[SerializeField]
	private Vector2 _size = new Vector2(100f, 100f);

	[SerializeField]
	private Vector2 _pivot = new Vector2(0.5f, 0.5f);

	private Vector3[] FHBFCAEGPOH = new Vector3[4];

	private MeshRenderer MKCLCNPKGBC;

	private MeshFilter BOHOPOEDLMA;

	private int LFFGAMJBAFJ;

	private string PEEPNLJIFNH;

	public Vector2 MOFHAKELNPN
	{
		get
		{
			return _size;
		}
		set
		{
			_size = value;
			IENNHGAIIFK();
		}
	}

	public Vector2 IIFBHCMJEKK
	{
		get
		{
			return _pivot;
		}
		set
		{
			_pivot = value;
			IENNHGAIIFK();
		}
	}

	public static ClearStencilBufferComponent GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = GDOGKAGJLPE();
			}
			return KNPOFJNFLJB;
		}
	}

	private void Awake()
	{
		base.name = "CLEAR_STENCIL_BUFFER";
		BOHOPOEDLMA = GetComponent<MeshFilter>();
		if (BOHOPOEDLMA == null)
		{
			BOHOPOEDLMA = base.gameObject.AddComponent<MeshFilter>();
		}
		if (BOHOPOEDLMA.sharedMesh == null)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.NotEditable;
			mesh.name = string.Concat("RectMesh");
			mesh.vertices = FHBFCAEGPOH;
			mesh.uv = new Vector2[4]
			{
				new Vector2(0f, 1f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f),
				new Vector2(0f, 0f)
			};
			mesh.triangles = new int[6] { 0, 1, 2, 2, 3, 0 };
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			BOHOPOEDLMA.sharedMesh = mesh;
		}
		MKCLCNPKGBC = GetComponent<MeshRenderer>();
		if (MKCLCNPKGBC == null)
		{
			MKCLCNPKGBC = base.gameObject.AddComponent<MeshRenderer>();
		}
		MKCLCNPKGBC.sortingOrder = 10000;
		if (MKCLCNPKGBC.sharedMaterial == null)
		{
			Shader shader = Shader.Find("SpriteMask/ClearStencil");
			Material material = new Material(shader);
			material.hideFlags = HideFlags.NotEditable;
			material.name = shader.name;
			MKCLCNPKGBC.sharedMaterial = material;
		}
		IENNHGAIIFK();
	}

	private void OnDrawGizmos()
	{
		if (base.enabled)
		{
			Renderer renderer = getRenderer();
			if (renderer != null)
			{
				Gizmos.color = Color.magenta;
				Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, base.transform.lossyScale);
				Bounds bounds = renderer.bounds;
				Gizmos.DrawWireCube(bounds.center, bounds.size);
			}
		}
	}

	protected virtual void OnDestroy()
	{
		KNPOFJNFLJB = null;
	}

	protected virtual void Reset()
	{
		Object[] array = Object.FindObjectsOfType(typeof(ClearStencilBufferComponent));
		if (array != null && array.Length > 1)
		{
			Debug.LogError("ClearStencilBufferComponent is already in the scene!");
		}
	}

	public MeshRenderer getRenderer()
	{
		return MKCLCNPKGBC;
	}

	private void IENNHGAIIFK()
	{
		if (BOHOPOEDLMA != null)
		{
			float num = (0f - _pivot.x) * _size.x;
			float num2 = (0f - _pivot.y) * _size.y;
			float x = num + _size.x;
			float y = num2 + _size.y;
			FHBFCAEGPOH[0] = new Vector3(num, y, 0f);
			FHBFCAEGPOH[1] = new Vector3(x, y, 0f);
			FHBFCAEGPOH[2] = new Vector3(x, num2, 0f);
			FHBFCAEGPOH[3] = new Vector3(num, num2, 0f);
			BOHOPOEDLMA.sharedMesh.vertices = FHBFCAEGPOH;
			BOHOPOEDLMA.sharedMesh.RecalculateBounds();
		}
	}

	private static ClearStencilBufferComponent GDOGKAGJLPE()
	{
		return Object.FindObjectOfType(typeof(ClearStencilBufferComponent)) as ClearStencilBufferComponent;
	}
}
