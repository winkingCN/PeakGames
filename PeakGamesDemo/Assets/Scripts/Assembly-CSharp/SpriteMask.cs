using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

[ExecuteInEditMode]
public class SpriteMask : SpriteMaskingComponent
{
	public enum JKMCCAHNIMA
	{
		Rectangle = 0,
		Sprite = 1,
		Texture = 2,
		CustomMesh = 3,
		None = 100
	}

	public const string SHADER_SPRITE_DEFAULT = "SpriteMask/Default";

	public const string SHADER_SPRITE_DIFFUSE = "SpriteMask/Diffuse";

	public const string SHADER_MASK_ROOT = "SpriteMask/Mask";

	private const string MDFCFGFLMGM = "_Stencil";

	private const string MJDMOBHLBHI = "_StencilComp";

	private const string BAGICKOAPAP = "_StencilReadMask";

	private const string EPDKOOMDBKF = "_ColorMask";

	private const int GGEDKGONHKD = 3;

	private const int JCGJAIMIBFF = 3000;

	[SerializeField]
	[FormerlySerializedAs("maskingRoots")]
	public List<Transform> maskedObjects = new List<Transform>();

	public bool forceDefaultMaterialOnChilds;

	public bool forceIndividualMaterialOnChilds;

	[SerializeField]
	private JKMCCAHNIMA _type;

	[SerializeField]
	private Vector2 _size = new Vector2(100f, 100f);

	[SerializeField]
	private Vector2 _pivot = new Vector2(0.5f, 0.5f);

	[SerializeField]
	private Texture2D _texture;

	[SerializeField]
	private Sprite _sprite;

	[SerializeField]
	private bool _inverted;

	[SerializeField]
	private bool _showMaskGraphics;

	private Dictionary<Material, Material> DGGIEBKAODH;

	private static bool[] OHJGPBBALDA = new bool[256];

	private int LPFJHHBPICL = -1;

	private int BOKADECPMGN = -1;

	private int MNGLBOMMEIE = -1;

	private int BKIHOFGINKO = -1;

	private static List<Renderer> DIOAOOAPJJN = new List<Renderer>();

	private static List<SpriteMask> MCPLBPJBPJB = new List<SpriteMask>();

	private static List<SpriteMaskingComponent> BOAFFKOAKAA = new List<SpriteMaskingComponent>();

	private static List<SpriteMaskingPart> OMKJOPFGLHK = new List<SpriteMaskingPart>();

	private static List<SkipMasking> BHNPHBIPPNF = new List<SkipMasking>();

	private Vector3[] FHBFCAEGPOH = new Vector3[4];

	private Vector2[] NEOLFCHBJOA = new Vector2[4]
	{
		new Vector2(0f, 1f),
		new Vector2(1f, 1f),
		new Vector2(1f, 0f),
		new Vector2(0f, 0f)
	};

	private int[] NPDGLMEOKIO = new int[6] { 0, 1, 2, 2, 3, 0 };

	private Material CIAJPHJLAED;

	[SerializeField]
	private string _defaultSpriteShaderName = "SpriteMask/Default";

	private SpriteRenderer CGGMEBGANNC;

	private ClearStencilBufferComponent LKPMODJDKOK;

	private MeshRenderer MKCLCNPKGBC;

	private bool OMOIMBECGIN;

	private Material LBGIKPHHAEE;

	private MeshFilter BOHOPOEDLMA;

	private int? PMMNPHIFCMO;

	private string AHBFOGKJDHB;

	private int KOIPNCMFJBM;

	private int LPONNGEPDON;

	public int GKPELPKCEMI
	{
		get
		{
			return KOIPNCMFJBM;
		}
	}

	public int MNOKLKFOOEN
	{
		get
		{
			return KOIPNCMFJBM & 0x1F;
		}
	}

	public int GIOFHACJEGA
	{
		get
		{
			return LPONNGEPDON;
		}
	}

	public int CKKBDHIJCEA
	{
		get
		{
			return 3000 + 100 * LPONNGEPDON;
		}
	}

	public int BBJJHIMBOMI
	{
		get
		{
			return CKKBDHIJCEA;
		}
	}

	public bool MLHNHLKAFHG
	{
		get
		{
			return LPONNGEPDON == 0;
		}
	}

	[Obsolete("Use maskedObjects")]
	public List<Transform> KENODLHFGEJ
	{
		get
		{
			return maskedObjects;
		}
	}

	public bool EIFGAHENCBI
	{
		get
		{
			return LPONNGEPDON > 0;
		}
	}

	public override bool MKNHMLHKFKE
	{
		get
		{
			return base.enabled;
		}
	}

	public JKMCCAHNIMA NBFBPNNEKMN
	{
		get
		{
			return _type;
		}
		set
		{
			if (_type != value || !OMOIMBECGIN)
			{
				_type = value;
				LHHMNGPFAMK();
			}
		}
	}

	public Vector2 MOFHAKELNPN
	{
		get
		{
			switch (_type)
			{
			case JKMCCAHNIMA.Rectangle:
			case JKMCCAHNIMA.Texture:
				return _size;
			case JKMCCAHNIMA.Sprite:
				if (CGGMEBGANNC != null && CGGMEBGANNC.sprite != null)
				{
					return CGGMEBGANNC.sprite.bounds.size;
				}
				break;
			case JKMCCAHNIMA.CustomMesh:
				if (BOHOPOEDLMA != null && BOHOPOEDLMA.sharedMesh != null)
				{
					return BOHOPOEDLMA.sharedMesh.bounds.size;
				}
				break;
			}
			return Vector2.zero;
		}
		set
		{
			if (!OMOIMBECGIN)
			{
				LHHMNGPFAMK();
			}
			_size = value;
			if (_type == JKMCCAHNIMA.Rectangle || _type == JKMCCAHNIMA.Texture)
			{
				IENNHGAIIFK();
			}
			else
			{
				Debug.LogWarning("Size change not supported on mask type: " + _type);
			}
		}
	}

	public Vector2 IIFBHCMJEKK
	{
		get
		{
			switch (_type)
			{
			case JKMCCAHNIMA.Rectangle:
			case JKMCCAHNIMA.Texture:
				return _pivot;
			case JKMCCAHNIMA.Sprite:
				if (CGGMEBGANNC != null && CGGMEBGANNC.sprite != null)
				{
					Bounds bounds = CGGMEBGANNC.sprite.bounds;
					Vector2 vector = bounds.min;
					Vector2 vector2 = bounds.size;
					return new Vector2((0f - vector.x) / vector2.x, (0f - vector.y) / vector2.y);
				}
				break;
			case JKMCCAHNIMA.CustomMesh:
				if (BOHOPOEDLMA != null && BOHOPOEDLMA.sharedMesh != null)
				{
					return getPivot(BOHOPOEDLMA.sharedMesh.bounds);
				}
				break;
			}
			return Vector2.zero;
		}
		set
		{
			if (!OMOIMBECGIN)
			{
				LHHMNGPFAMK();
			}
			_pivot = value;
			if (_type == JKMCCAHNIMA.Rectangle || _type == JKMCCAHNIMA.Texture)
			{
				IENNHGAIIFK();
			}
			else
			{
				Debug.LogWarning("Pivot change not supported on mask type: " + _type);
			}
		}
	}

	public Sprite MJOJAOIHCIO
	{
		get
		{
			return _sprite;
		}
		set
		{
			if (!OMOIMBECGIN)
			{
				LHHMNGPFAMK();
			}
			if (_type == JKMCCAHNIMA.Sprite)
			{
				CGGMEBGANNC.sprite = (_sprite = value);
			}
			else
			{
				Debug.LogWarning("Sprite change not supported on mask type: " + _type);
			}
		}
	}

	public Texture2D CGIOFLEGCHD
	{
		get
		{
			return _texture;
		}
		set
		{
			if (!OMOIMBECGIN)
			{
				LHHMNGPFAMK();
			}
			if (_type == JKMCCAHNIMA.Texture || _type == JKMCCAHNIMA.CustomMesh)
			{
				DBBAJKJGGPK.mainTexture = (_texture = value);
			}
			else
			{
				Debug.LogWarning("Texture change not supported on mask type: " + _type);
			}
		}
	}

	public bool HNNDPNKNPCI
	{
		get
		{
			return _inverted;
		}
		set
		{
			if (_inverted != value)
			{
				_inverted = value;
				updateSprites();
			}
		}
	}

	public bool JDOHCCGFJCB
	{
		get
		{
			return _showMaskGraphics;
		}
		set
		{
			if (_showMaskGraphics != value)
			{
				_showMaskGraphics = value;
				DBBAJKJGGPK.SetFloat(MNGLBOMMEIE, _showMaskGraphics ? 15 : 0);
			}
		}
	}

	public Shader FICGNKCOMID
	{
		get
		{
			return MBAEKBHHKAO.shader;
		}
		set
		{
			if (value == null)
			{
				Debug.LogWarning("Shader is null");
				return;
			}
			if (!value.isSupported)
			{
				Debug.LogWarning("Shader '" + value.name + "' not supported!");
				return;
			}
			Material material = MBAEKBHHKAO;
			if (material.shader != value)
			{
				Shader shader = material.shader;
				material.shader = value;
				if (!PBPAPLBNPDB(material))
				{
					Debug.LogWarning("Shader '" + value.name + "' doesn't support Stencil buffer");
					material.shader = shader;
				}
				_defaultSpriteShaderName = material.shader.name;
			}
		}
	}

	private Material MBAEKBHHKAO
	{
		get
		{
			if (CIAJPHJLAED == null)
			{
				Shader shader = Shader.Find(_defaultSpriteShaderName);
				CIAJPHJLAED = new Material(shader);
				CIAJPHJLAED.name = shader.name + " OWNER_ID:" + AHBFOGKJDHB;
			}
			return CIAJPHJLAED;
		}
	}

	private Material DBBAJKJGGPK
	{
		get
		{
			if (LBGIKPHHAEE == null)
			{
				Shader shader = Shader.Find("SpriteMask/Mask");
				LBGIKPHHAEE = new Material(shader);
				LBGIKPHHAEE.hideFlags = HideFlags.HideAndDontSave;
				LBGIKPHHAEE.name = shader.name + " OWNER_ID:" + AHBFOGKJDHB;
				LBGIKPHHAEE.SetFloat(MNGLBOMMEIE, _showMaskGraphics ? 15 : 0);
			}
			return LBGIKPHHAEE;
		}
	}

	private void Awake()
	{
		AHBFOGKJDHB = GetInstanceID().ToString();
		owner = this;
		BKIHOFGINKO = Shader.PropertyToID("_Stencil");
		BOKADECPMGN = Shader.PropertyToID("_StencilComp");
		LPFJHHBPICL = Shader.PropertyToID("_StencilReadMask");
		MNGLBOMMEIE = Shader.PropertyToID("_ColorMask");
		BNLBNDKBFMG(base.transform);
		CGGMEBGANNC = GetComponent<SpriteRenderer>();
		MKCLCNPKGBC = GetComponent<MeshRenderer>();
		BOHOPOEDLMA = GetComponent<MeshFilter>();
	}

	private void OnEnable()
	{
		PMMNPHIFCMO = null;
		Renderer renderer = EAOIOCGOMLC(this);
		if (renderer != null)
		{
			renderer.enabled = true;
		}
		if (OMOIMBECGIN)
		{
			update();
		}
	}

	private void Start()
	{
		if (!OMOIMBECGIN)
		{
			LHHMNGPFAMK();
		}
		update();
	}

	private void OnDisable()
	{
		if (KOIPNCMFJBM > 0)
		{
			FIIJOCLCPOM(KOIPNCMFJBM);
			KOIPNCMFJBM = 0;
		}
		if (base.gameObject.activeInHierarchy)
		{
			Renderer renderer = EAOIOCGOMLC(this);
			if (renderer != null)
			{
				renderer.enabled = false;
			}
			SpriteMask parentMask = getParentMask(base.transform);
			if (parentMask != null)
			{
				PMMNPHIFCMO = parentMask.GKPELPKCEMI;
			}
			else
			{
				PMMNPHIFCMO = null;
			}
			updateSprites();
			updateMaskingComponents();
		}
	}

	[ContextMenu("Update Mask")]
	public void updateMask()
	{
		if (!OMOIMBECGIN)
		{
			return;
		}
		if (KOIPNCMFJBM > 0)
		{
			FIIJOCLCPOM(KOIPNCMFJBM);
			KOIPNCMFJBM = 0;
		}
		LPONNGEPDON = 0;
		Transform parent = base.transform.parent;
		while (parent != null)
		{
			SpriteMaskingComponent spriteMaskingComponent = KMGMCJIFPAD(parent);
			if (spriteMaskingComponent != null && spriteMaskingComponent.MKNHMLHKFKE)
			{
				LPONNGEPDON++;
			}
			parent = parent.parent;
		}
		int num = 2;
		if (LPONNGEPDON > num)
		{
			Debug.LogError("Maximum number of mask levels has been exceeded: max=" + num + " current=" + LPONNGEPDON);
			LPONNGEPDON = num;
		}
		KOIPNCMFJBM = AELHNEFOODI(LPONNGEPDON);
		if (KOIPNCMFJBM == -1)
		{
			Debug.LogError("Maximum number of mask per levels has been exceeded: " + 31);
			KOIPNCMFJBM = 0;
		}
		Material material = DBBAJKJGGPK;
		int value;
		CompareFunction value2;
		if (MLHNHLKAFHG)
		{
			value = 255;
			value2 = CompareFunction.Always;
		}
		else
		{
			value = 255 >> LPONNGEPDON - 1;
			value2 = CompareFunction.Less;
		}
		material.renderQueue = CKKBDHIJCEA;
		NHPBNLLJGDO(material, KOIPNCMFJBM, value2, value);
	}

	public void updateMaskingComponents()
	{
		if (maskedObjects == null || maskedObjects.Count == 0)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < maskedObjects.Count; i++)
		{
			if (maskedObjects[i] == null)
			{
				flag = true;
				continue;
			}
			SpriteMaskingComponent spriteMaskingComponent = KMGMCJIFPAD(maskedObjects[i]);
			if (spriteMaskingComponent != this)
			{
				if (spriteMaskingComponent == null)
				{
					spriteMaskingComponent = maskedObjects[i].gameObject.AddComponent<SpriteMaskingComponent>();
					spriteMaskingComponent.owner = this;
				}
				else if (spriteMaskingComponent.owner == null)
				{
					spriteMaskingComponent.owner = this;
				}
				else if (spriteMaskingComponent.owner != this)
				{
					continue;
				}
				updateSprites(maskedObjects[i]);
			}
			else
			{
				maskedObjects[i] = null;
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		for (int j = 0; j < maskedObjects.Count; j++)
		{
			if (maskedObjects[j] == null)
			{
				maskedObjects.RemoveAt(j);
				j = 0;
			}
		}
	}

	[ContextMenu("Update Sprites")]
	public void updateSprites()
	{
		updateSprites(base.transform);
	}

	public void updateSprites(Transform EAAAFJALKCD)
	{
		if (OMOIMBECGIN)
		{
			int aFOCAAAOHGP;
			CompareFunction iJLKCOHLILI;
			if (PMMNPHIFCMO.HasValue)
			{
				aFOCAAAOHGP = PMMNPHIFCMO.Value;
				iJLKCOHLILI = ((!base.enabled || !_inverted) ? CompareFunction.Equal : CompareFunction.Less);
			}
			else
			{
				aFOCAAAOHGP = KOIPNCMFJBM;
				iJLKCOHLILI = ((!base.enabled) ? CompareFunction.Always : ((!_inverted) ? CompareFunction.Equal : ((!MLHNHLKAFHG) ? CompareFunction.Less : CompareFunction.NotEqual)));
			}
			FHABHCNBLEB(EAAAFJALKCD, iJLKCOHLILI, aFOCAAAOHGP);
		}
	}

	public void update()
	{
		updateMask();
		updateSprites();
		updateMaskingComponents();
	}

	public static SpriteMask updateFor(Transform LLIEHCKNJEM)
	{
		SpriteMask parentMask = getParentMask(LLIEHCKNJEM);
		if (parentMask != null)
		{
			parentMask.updateSprites(LLIEHCKNJEM);
		}
		return parentMask;
	}

	public static SpriteMask getParentMask(Transform LLIEHCKNJEM)
	{
		LLIEHCKNJEM = LLIEHCKNJEM.parent;
		while (LLIEHCKNJEM != null)
		{
			SpriteMaskingComponent spriteMaskingComponent = KMGMCJIFPAD(LLIEHCKNJEM);
			if (spriteMaskingComponent != null && spriteMaskingComponent.MKNHMLHKFKE)
			{
				return spriteMaskingComponent.owner;
			}
			LLIEHCKNJEM = LLIEHCKNJEM.parent;
		}
		return null;
	}

	private void LHHMNGPFAMK()
	{
		switch (_type)
		{
		case JKMCCAHNIMA.Rectangle:
			_texture = null;
			_sprite = null;
			DBBAJKJGGPK.mainTexture = null;
			NOLFCEBBJAD();
			JFBOLFIIALO();
			IENNHGAIIFK();
			break;
		case JKMCCAHNIMA.Sprite:
			_texture = null;
			DBBAJKJGGPK.mainTexture = null;
			MAINDEEEDBP();
			INMOHDJGMII();
			CGGMEBGANNC.sprite = _sprite;
			break;
		case JKMCCAHNIMA.Texture:
			_sprite = null;
			NOLFCEBBJAD();
			JFBOLFIIALO();
			IENNHGAIIFK();
			DBBAJKJGGPK.mainTexture = _texture;
			break;
		case JKMCCAHNIMA.CustomMesh:
			_sprite = null;
			NOLFCEBBJAD();
			AMIIPNJHDGC();
			JFBOLFIIALO();
			DBBAJKJGGPK.mainTexture = _texture;
			break;
		case JKMCCAHNIMA.None:
			_texture = null;
			_sprite = null;
			DBBAJKJGGPK.mainTexture = null;
			NOLFCEBBJAD();
			MAINDEEEDBP();
			break;
		}
		OMOIMBECGIN = true;
	}

	protected override void FHABHCNBLEB(Transform LLIEHCKNJEM, CompareFunction IJLKCOHLILI, int AFOCAAAOHGP)
	{
		if (DNKMDDGOCBO(LLIEHCKNJEM))
		{
			return;
		}
		if (IPFOLDLFLJC(LLIEHCKNJEM))
		{
			Renderer renderer = EAOIOCGOMLC(LLIEHCKNJEM);
			if (renderer != null)
			{
				renderer.sharedMaterial = DBBAJKJGGPK;
			}
			return;
		}
		SpriteMaskingComponent spriteMaskingComponent = KMGMCJIFPAD(LLIEHCKNJEM);
		bool flag = true;
		if (spriteMaskingComponent != null)
		{
			if (spriteMaskingComponent == this)
			{
				flag = false;
			}
			else if (spriteMaskingComponent.owner == this)
			{
				flag = true;
			}
			else if (spriteMaskingComponent is SpriteMask)
			{
				flag = false;
				if (spriteMaskingComponent.MKNHMLHKFKE)
				{
					((SpriteMask)spriteMaskingComponent).update();
					return;
				}
			}
			else if (spriteMaskingComponent.MKNHMLHKFKE)
			{
				return;
			}
		}
		if (flag)
		{
			Renderer renderer2 = EAOIOCGOMLC(LLIEHCKNJEM);
			if (renderer2 != null)
			{
				Material[] sharedMaterials = renderer2.sharedMaterials;
				if (sharedMaterials.Length > 1)
				{
					for (int i = 0; i < sharedMaterials.Length; i++)
					{
						if (sharedMaterials[i] != null && PBPAPLBNPDB(sharedMaterials[i]))
						{
							if (forceIndividualMaterialOnChilds && sharedMaterials[i].GetInstanceID() > 0)
							{
								sharedMaterials[i] = MMNHILAHLKM(sharedMaterials[i]);
							}
							sharedMaterials[i].renderQueue = BBJJHIMBOMI;
							NHPBNLLJGDO(sharedMaterials[i], AFOCAAAOHGP, IJLKCOHLILI, null);
						}
					}
				}
				else
				{
					Material material2;
					if (sharedMaterials.Length == 0)
					{
						material2 = (renderer2.sharedMaterial = MBAEKBHHKAO);
					}
					else
					{
						material2 = sharedMaterials[0];
						if (material2 == null || !PBPAPLBNPDB(material2) || forceDefaultMaterialOnChilds)
						{
							material2 = (renderer2.sharedMaterial = MBAEKBHHKAO);
						}
						else if (forceIndividualMaterialOnChilds && material2.GetInstanceID() > 0)
						{
							material2 = (renderer2.sharedMaterial = MMNHILAHLKM(material2));
						}
					}
					material2.renderQueue = BBJJHIMBOMI;
					NHPBNLLJGDO(material2, AFOCAAAOHGP, IJLKCOHLILI, null);
				}
			}
		}
		int childCount = LLIEHCKNJEM.childCount;
		if (childCount > 0)
		{
			for (int j = 0; j < childCount; j++)
			{
				FHABHCNBLEB(LLIEHCKNJEM.GetChild(j), IJLKCOHLILI, AFOCAAAOHGP);
			}
		}
	}

	private Material MMNHILAHLKM(Material EBDCOMKHPBG)
	{
		if (DGGIEBKAODH == null)
		{
			DGGIEBKAODH = new Dictionary<Material, Material>();
		}
		if (DGGIEBKAODH.ContainsKey(EBDCOMKHPBG))
		{
			return DGGIEBKAODH[EBDCOMKHPBG];
		}
		Material material = new Material(EBDCOMKHPBG);
		material.name += " (Clone)";
		KJEEGMIKCHM(EBDCOMKHPBG);
		DGGIEBKAODH[EBDCOMKHPBG] = material;
		return material;
	}

	private void BNLBNDKBFMG(Transform LLIEHCKNJEM)
	{
		int childCount = LLIEHCKNJEM.childCount;
		if (childCount == 0)
		{
			return;
		}
		for (int i = 0; i < childCount; i++)
		{
			Transform child = LLIEHCKNJEM.GetChild(i);
			SpriteMaskingComponent spriteMaskingComponent = KMGMCJIFPAD(child);
			if (spriteMaskingComponent != null)
			{
				continue;
			}
			Renderer renderer = EAOIOCGOMLC(child);
			if (renderer != null)
			{
				Material sharedMaterial = renderer.sharedMaterial;
				if (sharedMaterial != null)
				{
					string text = GMNIHFKNKGF(sharedMaterial.name);
					if (text != null && !text.Equals(AHBFOGKJDHB))
					{
						renderer.sharedMaterial = null;
					}
				}
			}
			BNLBNDKBFMG(child);
		}
	}

	private void KJEEGMIKCHM(Material CEKMAJAHNAG)
	{
		NHPBNLLJGDO(CEKMAJAHNAG, 0, CompareFunction.Always, null);
	}

	private void NHPBNLLJGDO(Material CEKMAJAHNAG, int? AFOCAAAOHGP, CompareFunction? IJLKCOHLILI, int? NCFLKEMGBLM)
	{
		if (AFOCAAAOHGP.HasValue)
		{
			CEKMAJAHNAG.SetInt(BKIHOFGINKO, AFOCAAAOHGP.Value);
		}
		if (IJLKCOHLILI.HasValue)
		{
			CEKMAJAHNAG.SetInt(BOKADECPMGN, (int)IJLKCOHLILI.Value);
		}
		if (NCFLKEMGBLM.HasValue)
		{
			CEKMAJAHNAG.SetInt(LPFJHHBPICL, NCFLKEMGBLM.Value);
		}
	}

	private int AELHNEFOODI(int GIOFHACJEGA)
	{
		int num = 128 >> GIOFHACJEGA;
		int num2 = 31;
		for (int i = 0; i < num2; i++)
		{
			int num3 = num + i;
			if (!OHJGPBBALDA[num3])
			{
				OHJGPBBALDA[num3] = true;
				return num3;
			}
		}
		return -1;
	}

	private void FIIJOCLCPOM(int BDKFNEDHAOJ)
	{
		OHJGPBBALDA[BDKFNEDHAOJ] = false;
	}

	private bool PBPAPLBNPDB(Material CEKMAJAHNAG)
	{
		return CEKMAJAHNAG.HasProperty(BKIHOFGINKO) && CEKMAJAHNAG.HasProperty(BOKADECPMGN);
	}

	private string GMNIHFKNKGF(string GFPBBLPMOOL)
	{
		int num = GFPBBLPMOOL.IndexOf("OWNER_ID");
		if (num != -1)
		{
			return GFPBBLPMOOL.Substring(num + 9);
		}
		return null;
	}

	private void NOLFCEBBJAD()
	{
		if (CGGMEBGANNC != null)
		{
			UnityEngine.Object.Destroy(CGGMEBGANNC);
			CGGMEBGANNC = null;
		}
	}

	private void MAINDEEEDBP()
	{
		if (BOHOPOEDLMA != null)
		{
			UnityEngine.Object.Destroy(BOHOPOEDLMA);
			BOHOPOEDLMA = null;
		}
		if (MKCLCNPKGBC != null)
		{
			UnityEngine.Object.Destroy(MKCLCNPKGBC);
			MKCLCNPKGBC = null;
		}
	}

	private void AMIIPNJHDGC()
	{
		if (BOHOPOEDLMA != null && BOHOPOEDLMA.sharedMesh != null && BOHOPOEDLMA.sharedMesh.GetInstanceID() < 0)
		{
			UnityEngine.Object.Destroy(BOHOPOEDLMA.sharedMesh);
			BOHOPOEDLMA.sharedMesh = null;
			BOHOPOEDLMA.mesh = null;
		}
	}

	private void INMOHDJGMII()
	{
		if (CGGMEBGANNC == null)
		{
			CGGMEBGANNC = GetComponent<SpriteRenderer>();
			if (CGGMEBGANNC == null)
			{
				CGGMEBGANNC = base.gameObject.AddComponent<SpriteRenderer>();
			}
		}
		CGGMEBGANNC.sharedMaterial = DBBAJKJGGPK;
	}

	private void JFBOLFIIALO()
	{
		if (BOHOPOEDLMA == null)
		{
			BOHOPOEDLMA = GetComponent<MeshFilter>();
			if (BOHOPOEDLMA == null)
			{
				BOHOPOEDLMA = base.gameObject.AddComponent<MeshFilter>();
			}
		}
		if (BOHOPOEDLMA.sharedMesh == null)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.HideAndDontSave;
			mesh.name = "RectMesh OWNER_ID:" + AHBFOGKJDHB;
			mesh.MarkDynamic();
			BOHOPOEDLMA.sharedMesh = mesh;
			mesh.vertices = FHBFCAEGPOH;
			mesh.uv = NEOLFCHBJOA;
			mesh.triangles = NPDGLMEOKIO;
			mesh.RecalculateNormals();
		}
		if (MKCLCNPKGBC == null)
		{
			MKCLCNPKGBC = GetComponent<MeshRenderer>();
			if (MKCLCNPKGBC == null)
			{
				MKCLCNPKGBC = base.gameObject.AddComponent<MeshRenderer>();
			}
		}
		MKCLCNPKGBC.sharedMaterial = DBBAJKJGGPK;
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

	public Renderer getRenderer()
	{
		return EAOIOCGOMLC(this);
	}

	private static Renderer EAOIOCGOMLC(Component FMFABAKPMLB)
	{
		FMFABAKPMLB.GetComponents(DIOAOOAPJJN);
		Renderer result = ((DIOAOOAPJJN.Count <= 0) ? null : DIOAOOAPJJN[0]);
		DIOAOOAPJJN.Clear();
		return result;
	}

	private static bool IPFOLDLFLJC(Component LLIEHCKNJEM)
	{
		LLIEHCKNJEM.GetComponents(OMKJOPFGLHK);
		bool result = OMKJOPFGLHK.Count > 0;
		OMKJOPFGLHK.Clear();
		return result;
	}

	private static bool DNKMDDGOCBO(Component LLIEHCKNJEM)
	{
		LLIEHCKNJEM.GetComponents(BHNPHBIPPNF);
		bool result = BHNPHBIPPNF.Count > 0;
		BHNPHBIPPNF.Clear();
		return result;
	}

	private static SpriteMaskingComponent KMGMCJIFPAD(Component LLIEHCKNJEM)
	{
		LLIEHCKNJEM.GetComponents(BOAFFKOAKAA);
		SpriteMaskingComponent result = ((BOAFFKOAKAA.Count != 1) ? null : BOAFFKOAKAA[0]);
		BOAFFKOAKAA.Clear();
		return result;
	}

	private static SpriteMask CEDJNIPOPNC(Component LLIEHCKNJEM)
	{
		LLIEHCKNJEM.GetComponents(MCPLBPJBPJB);
		SpriteMask result = ((MCPLBPJBPJB.Count != 1) ? null : MCPLBPJBPJB[0]);
		MCPLBPJBPJB.Clear();
		return result;
	}

	public Vector2 getPivot(Bounds DJKHEGCCHFI)
	{
		Vector2 result = default(Vector2);
		result.x = (0f - DJKHEGCCHFI.center.x) / DJKHEGCCHFI.extents.x / 2f + 0.5f;
		result.y = (0f - DJKHEGCCHFI.center.y) / DJKHEGCCHFI.extents.y / 2f + 0.5f;
		return result;
	}
}
