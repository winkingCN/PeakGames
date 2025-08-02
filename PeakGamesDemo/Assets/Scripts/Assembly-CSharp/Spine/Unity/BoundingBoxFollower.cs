using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	public class BoundingBoxFollower : MonoBehaviour
	{
		internal static bool PAPOHBGHENP = true;

		public SkeletonRenderer skeletonRenderer;

		[IEEPDCDKDNM("", "skeletonRenderer", true, true, false)]
		public string slotName;

		public bool isTrigger;

		public bool clearStateOnDisable = true;

		private LBBAMMPJKDA DFKJODFHCJB;

		private KBLNEHAAAJK EPFNMNCDDJM;

		private string ALKCEEFHFED;

		private PolygonCollider2D EMFCKEKKJPO;

		public readonly Dictionary<KBLNEHAAAJK, PolygonCollider2D> colliderTable = new Dictionary<KBLNEHAAAJK, PolygonCollider2D>();

		public readonly Dictionary<KBLNEHAAAJK, string> nameTable = new Dictionary<KBLNEHAAAJK, string>();

		public LBBAMMPJKDA GJKBFIPONDM
		{
			get
			{
				return DFKJODFHCJB;
			}
		}

		public KBLNEHAAAJK AGKMLOPIILP
		{
			get
			{
				return EPFNMNCDDJM;
			}
		}

		public string GDJBMKNOLFE
		{
			get
			{
				return ALKCEEFHFED;
			}
		}

		public PolygonCollider2D OHKDLBCLDCC
		{
			get
			{
				return EMFCKEKKJPO;
			}
		}

		public bool POAGAIAMHOL
		{
			get
			{
				return isTrigger;
			}
		}

		private void Start()
		{
			Initialize();
		}

		private void OnEnable()
		{
			if (skeletonRenderer != null)
			{
				skeletonRenderer.BOAKMFAEPME -= OFDOPIOODOH;
				skeletonRenderer.BOAKMFAEPME += OFDOPIOODOH;
			}
			Initialize();
		}

		private void OFDOPIOODOH(SkeletonRenderer PMEDIPOOFHE)
		{
			Initialize();
		}

		public void Initialize(bool AJMAKDEFBOL = false)
		{
			if (skeletonRenderer == null)
			{
				return;
			}
			skeletonRenderer.Initialize(false);
			if (string.IsNullOrEmpty(slotName) || (!AJMAKDEFBOL && colliderTable.Count > 0 && DFKJODFHCJB != null && skeletonRenderer.skeleton == DFKJODFHCJB.LICMNMABJGL && slotName == DFKJODFHCJB.MBBPBGHKLJM.IOCMOCCFALN))
			{
				return;
			}
			HJLJHNCIAFB();
			GCJKICAPOFL skeleton = skeletonRenderer.skeleton;
			DFKJODFHCJB = skeleton.MEKLNNENPDK(slotName);
			int pBPEMFGPGFC = skeleton.IBOGMECEHLD(slotName);
			if (DFKJODFHCJB == null)
			{
				if (PAPOHBGHENP)
				{
					Debug.LogWarning(string.Format("Slot '{0}' not found for BoundingBoxFollower on '{1}'. (Previous colliders were disposed.)", slotName, base.gameObject.name));
				}
				return;
			}
			if (base.gameObject.activeInHierarchy)
			{
				using (ExposedList<JPAALKCPGNB>.Enumerator enumerator = skeleton.LJDLCPHOBHB.BBNHBLHCFEK.FIFMNBJLBFK())
				{
					while (enumerator.MoveNext())
					{
						JPAALKCPGNB current = enumerator.Current;
						KHMHIGPNMEC(current, pBPEMFGPGFC);
					}
				}
				if (skeleton.HLCFGIFLPPE != null)
				{
					KHMHIGPNMEC(skeleton.HLCFGIFLPPE, pBPEMFGPGFC);
				}
			}
			if (PAPOHBGHENP && colliderTable.Count == 0)
			{
				if (base.gameObject.activeInHierarchy)
				{
					Debug.LogWarning("Bounding Box Follower not valid! Slot [" + slotName + "] does not contain any Bounding Box Attachments!");
				}
				else
				{
					Debug.LogWarning("Bounding Box Follower tried to rebuild as a prefab.");
				}
			}
		}

		private void KHMHIGPNMEC(JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC)
		{
			if (HLCFGIFLPPE == null)
			{
				return;
			}
			List<string> list = new List<string>();
			HLCFGIFLPPE.IDPNBGBLJGL(PBPEMFGPGFC, list);
			foreach (string item in list)
			{
				OAMNGFLKEFI oAMNGFLKEFI = HLCFGIFLPPE.JGHJDGIANDD(PBPEMFGPGFC, item);
				KBLNEHAAAJK kBLNEHAAAJK = oAMNGFLKEFI as KBLNEHAAAJK;
				if (PAPOHBGHENP && oAMNGFLKEFI != null && kBLNEHAAAJK == null)
				{
					Debug.Log("BoundingBoxFollower tried to follow a slot that contains non-boundingbox attachments: " + slotName);
				}
				if (kBLNEHAAAJK != null && !colliderTable.ContainsKey(kBLNEHAAAJK))
				{
					PolygonCollider2D polygonCollider2D = SkeletonUtility.AddBoundingBoxAsComponent(kBLNEHAAAJK, DFKJODFHCJB, base.gameObject, isTrigger);
					polygonCollider2D.enabled = false;
					polygonCollider2D.hideFlags = HideFlags.NotEditable;
					polygonCollider2D.isTrigger = POAGAIAMHOL;
					colliderTable.Add(kBLNEHAAAJK, polygonCollider2D);
					nameTable.Add(kBLNEHAAAJK, item);
				}
			}
		}

		private void OnDisable()
		{
			if (clearStateOnDisable)
			{
				ClearState();
			}
		}

		public void ClearState()
		{
			if (colliderTable != null)
			{
				foreach (PolygonCollider2D value in colliderTable.Values)
				{
					value.enabled = false;
				}
			}
			EPFNMNCDDJM = null;
			ALKCEEFHFED = null;
			EMFCKEKKJPO = null;
		}

		private void HJLJHNCIAFB()
		{
			PolygonCollider2D[] components = GetComponents<PolygonCollider2D>();
			if (components.Length == 0)
			{
				return;
			}
			if (Application.isEditor)
			{
				if (Application.isPlaying)
				{
					PolygonCollider2D[] array = components;
					foreach (PolygonCollider2D polygonCollider2D in array)
					{
						if (polygonCollider2D != null)
						{
							Object.Destroy(polygonCollider2D);
						}
					}
				}
				else
				{
					PolygonCollider2D[] array2 = components;
					foreach (PolygonCollider2D polygonCollider2D2 in array2)
					{
						if (polygonCollider2D2 != null)
						{
							Object.DestroyImmediate(polygonCollider2D2);
						}
					}
				}
			}
			else
			{
				PolygonCollider2D[] array3 = components;
				foreach (PolygonCollider2D polygonCollider2D3 in array3)
				{
					if (polygonCollider2D3 != null)
					{
						Object.Destroy(polygonCollider2D3);
					}
				}
			}
			DFKJODFHCJB = null;
			EPFNMNCDDJM = null;
			ALKCEEFHFED = null;
			EMFCKEKKJPO = null;
			colliderTable.Clear();
			nameTable.Clear();
		}

		private void LateUpdate()
		{
			if (DFKJODFHCJB != null && DFKJODFHCJB.AIKFOHCPLKG != EPFNMNCDDJM)
			{
				KGHFAANIMJC(DFKJODFHCJB.AIKFOHCPLKG);
			}
		}

		private void KGHFAANIMJC(OAMNGFLKEFI DFHHMKMLCFF)
		{
			KBLNEHAAAJK kBLNEHAAAJK = DFHHMKMLCFF as KBLNEHAAAJK;
			if (PAPOHBGHENP && DFHHMKMLCFF != null && kBLNEHAAAJK == null)
			{
				Debug.LogWarning("BoundingBoxFollower tried to match a non-boundingbox attachment. It will treat it as null.");
			}
			if (EMFCKEKKJPO != null)
			{
				EMFCKEKKJPO.enabled = false;
			}
			if (kBLNEHAAAJK == null)
			{
				EMFCKEKKJPO = null;
				EPFNMNCDDJM = null;
				ALKCEEFHFED = null;
				return;
			}
			PolygonCollider2D value;
			colliderTable.TryGetValue(kBLNEHAAAJK, out value);
			if (value != null)
			{
				EMFCKEKKJPO = value;
				EMFCKEKKJPO.enabled = true;
				EPFNMNCDDJM = kBLNEHAAAJK;
				ALKCEEFHFED = nameTable[kBLNEHAAAJK];
				return;
			}
			EMFCKEKKJPO = null;
			EPFNMNCDDJM = kBLNEHAAAJK;
			ALKCEEFHFED = null;
			if (PAPOHBGHENP)
			{
				Debug.LogFormat("Collider for BoundingBoxAttachment named '{0}' was not initialized. It is possibly from a new skin. currentAttachmentName will be null. You may need to call BoundingBoxFollower.Initialize(overwrite: true);", kBLNEHAAAJK.PNGPLGHKFDI);
			}
		}
	}
}
