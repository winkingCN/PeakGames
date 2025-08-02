using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	[RequireComponent(typeof(SkeletonRenderer))]
	public class SkeletonRagdoll2D : MonoBehaviour
	{
		private static Transform DBAKEKLKMIE;

		[Header("Hierarchy")]
		[LKNNBABNCFC("", "", true, false)]
		public string startingBoneName = string.Empty;

		[LKNNBABNCFC("", "", true, false)]
		public List<string> stopBoneNames = new List<string>();

		[Header("Parameters")]
		public bool applyOnStart;

		[Tooltip("Warning!  You will have to re-enable and tune mix values manually if attempting to remove the ragdoll system.")]
		public bool disableIK = true;

		public bool disableOtherConstraints;

		[Space]
		[Tooltip("Set RootRigidbody IsKinematic to true when Apply is called.")]
		public bool pinStartBone;

		public float gravityScale = 1f;

		[Tooltip("If no BoundingBox Attachment is attached to a bone, this becomes the default Width or Radius of a Bone's ragdoll Rigidbody")]
		public float thickness = 0.125f;

		[Tooltip("Default rotational limit value.  Min is negative this value, Max is this value.")]
		public float rotationLimit = 20f;

		public float rootMass = 20f;

		[Range(0.01f, 1f)]
		[Tooltip("If your ragdoll seems unstable or uneffected by limits, try lowering this value.")]
		public float massFalloffFactor = 0.4f;

		[SkeletonRagdoll.FDHCJALIPPH]
		[Tooltip("The layer assigned to all of the rigidbody parts.")]
		public int colliderLayer;

		[Range(0f, 1f)]
		public float mix = 1f;

		private OAGCBGJOPGD EHOKBADPJNN;

		private GCJKICAPOFL GDNININLMFD;

		private Dictionary<NBKCFDOMAPI, Transform> LPMOOANNJED = new Dictionary<NBKCFDOMAPI, Transform>();

		private Transform DELEINAKCDC;

		private Vector2 LDGGEMBBCCM;

		private bool AEDFIIPIPME;

		public Rigidbody2D NAPDBIDONFC { get; private set; }

		public NBKCFDOMAPI EEGODPEKLNI { get; private set; }

		public Vector3 GLPCIGCJMME
		{
			get
			{
				return LDGGEMBBCCM;
			}
		}

		public bool NDODOKFECKE
		{
			get
			{
				return AEDFIIPIPME;
			}
		}

		public Rigidbody2D[] MNGOJOHKOHG
		{
			get
			{
				if (!AEDFIIPIPME)
				{
					return new Rigidbody2D[0];
				}
				Rigidbody2D[] array = new Rigidbody2D[LPMOOANNJED.Count];
				int num = 0;
				foreach (Transform value in LPMOOANNJED.Values)
				{
					array[num] = value.GetComponent<Rigidbody2D>();
					num++;
				}
				return array;
			}
		}

		public Vector3 KAHFLIACEJN
		{
			get
			{
				return NAPDBIDONFC.position - LDGGEMBBCCM;
			}
		}

		private IEnumerator Start()
		{
			if (DBAKEKLKMIE == null)
			{
				DBAKEKLKMIE = new GameObject("Parent Space Helper").transform;
			}
			EHOKBADPJNN = GetComponent<SkeletonRenderer>() as OAGCBGJOPGD;
			if (EHOKBADPJNN == null)
			{
				Debug.LogError("Attached Spine component does not implement ISkeletonAnimation. This script is not compatible.");
			}
			GDNININLMFD = EHOKBADPJNN.LICMNMABJGL;
			if (applyOnStart)
			{
				yield return null;
				Apply();
			}
		}

		public void Apply()
		{
			AEDFIIPIPME = true;
			mix = 1f;
			NBKCFDOMAPI nBKCFDOMAPI2 = (EEGODPEKLNI = GDNININLMFD.NMLBCOPEEDC(startingBoneName));
			NBKCFDOMAPI nBKCFDOMAPI3 = nBKCFDOMAPI2;
			FBBBIEKKJPP(nBKCFDOMAPI3);
			NAPDBIDONFC = LPMOOANNJED[nBKCFDOMAPI3].GetComponent<Rigidbody2D>();
			NAPDBIDONFC.isKinematic = pinStartBone;
			NAPDBIDONFC.mass = rootMass;
			List<Collider2D> list = new List<Collider2D>();
			foreach (KeyValuePair<NBKCFDOMAPI, Transform> item in LPMOOANNJED)
			{
				NBKCFDOMAPI key = item.Key;
				Transform value = item.Value;
				list.Add(value.GetComponent<Collider2D>());
				Transform transform;
				if (key == nBKCFDOMAPI3)
				{
					DELEINAKCDC = new GameObject("RagdollRoot").transform;
					DELEINAKCDC.SetParent(base.transform, false);
					if (key == GDNININLMFD.POOHJHBAMCJ)
					{
						DELEINAKCDC.localPosition = new Vector3(key.BINDPNKNACL, key.CJGJJAOIMDA, 0f);
						DELEINAKCDC.localRotation = Quaternion.Euler(0f, 0f, OBOOLHBEEHH(key));
					}
					else
					{
						DELEINAKCDC.localPosition = new Vector3(key.KNIICKBBGJB.BINDPNKNACL, key.KNIICKBBGJB.CJGJJAOIMDA, 0f);
						DELEINAKCDC.localRotation = Quaternion.Euler(0f, 0f, OBOOLHBEEHH(key.KNIICKBBGJB));
					}
					transform = DELEINAKCDC;
					LDGGEMBBCCM = value.position - base.transform.position;
				}
				else
				{
					transform = LPMOOANNJED[key.KNIICKBBGJB];
				}
				Rigidbody2D component = transform.GetComponent<Rigidbody2D>();
				if (component != null)
				{
					HingeJoint2D hingeJoint2D = value.gameObject.AddComponent<HingeJoint2D>();
					hingeJoint2D.connectedBody = component;
					Vector3 vector = transform.InverseTransformPoint(value.position);
					hingeJoint2D.connectedAnchor = vector;
					hingeJoint2D.GetComponent<Rigidbody2D>().mass = hingeJoint2D.connectedBody.mass * massFalloffFactor;
					hingeJoint2D.limits = new JointAngleLimits2D
					{
						min = 0f - rotationLimit,
						max = rotationLimit
					};
					hingeJoint2D.useLimits = true;
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (i != j)
					{
						Physics2D.IgnoreCollision(list[i], list[j]);
					}
				}
			}
			SkeletonUtilityBone[] componentsInChildren = GetComponentsInChildren<SkeletonUtilityBone>();
			if (componentsInChildren.Length > 0)
			{
				List<string> list2 = new List<string>();
				SkeletonUtilityBone[] array = componentsInChildren;
				foreach (SkeletonUtilityBone skeletonUtilityBone in array)
				{
					if (skeletonUtilityBone.mode == SkeletonUtilityBone.HNLALCIKDAK.Override)
					{
						list2.Add(skeletonUtilityBone.gameObject.name);
						Object.Destroy(skeletonUtilityBone.gameObject);
					}
				}
				if (list2.Count > 0)
				{
					string text = "Destroyed Utility Bones: ";
					for (int l = 0; l < list2.Count; l++)
					{
						text += list2[l];
						if (l != list2.Count - 1)
						{
							text += ",";
						}
					}
					Debug.LogWarning(text);
				}
			}
			if (disableIK)
			{
				ExposedList<JICANJGGKNH> exposedList = GDNININLMFD.PCBLMDHFHII;
				int m = 0;
				for (int count = exposedList.Count; m < count; m++)
				{
					exposedList.Items[m].MIIHPKNIPAB = 0f;
				}
			}
			if (disableOtherConstraints)
			{
				ExposedList<DLKMEPPLCGM> fOANDHFONAA = GDNININLMFD.FOANDHFONAA;
				int n = 0;
				for (int count2 = fOANDHFONAA.Count; n < count2; n++)
				{
					fOANDHFONAA.Items[n].OIBAIJIPGOM = 0f;
					fOANDHFONAA.Items[n].DLEIMBNDMOF = 0f;
					fOANDHFONAA.Items[n].OKJBKNEPKPN = 0f;
					fOANDHFONAA.Items[n].DHNKOEMONHP = 0f;
				}
				ExposedList<KNKKDGIBGLM> nDOOCKKIMHO = GDNININLMFD.NDOOCKKIMHO;
				int num = 0;
				for (int count3 = nDOOCKKIMHO.Count; num < count3; num++)
				{
					nDOOCKKIMHO.Items[num].OIBAIJIPGOM = 0f;
					nDOOCKKIMHO.Items[num].DHNKOEMONHP = 0f;
				}
			}
			EHOKBADPJNN.MPLLKFLOEHE += HLMLEMIHEIA;
		}

		public Coroutine SmoothMix(float CAEMELGEOAE, float FMPBJJMKCIG)
		{
			return StartCoroutine(MGEALLDBKGM(CAEMELGEOAE, FMPBJJMKCIG));
		}

		private IEnumerator MGEALLDBKGM(float CAEMELGEOAE, float FMPBJJMKCIG)
		{
			float time = Time.time;
			float from = mix;
			while (mix > 0f)
			{
				GDNININLMFD.CLFEIDBIMFJ();
				mix = Mathf.SmoothStep(from, CAEMELGEOAE, (Time.time - time) / FMPBJJMKCIG);
				yield return null;
			}
		}

		public void SetSkeletonPosition(Vector3 ANAPEELIOJJ)
		{
			if (!AEDFIIPIPME)
			{
				Debug.LogWarning("Can't call SetSkeletonPosition while Ragdoll is not active!");
				return;
			}
			Vector3 vector = ANAPEELIOJJ - base.transform.position;
			base.transform.position = ANAPEELIOJJ;
			foreach (Transform value in LPMOOANNJED.Values)
			{
				value.position -= vector;
			}
			HLMLEMIHEIA(null);
			GDNININLMFD.DGCKCELHAEG();
		}

		public void Remove()
		{
			AEDFIIPIPME = false;
			foreach (Transform value in LPMOOANNJED.Values)
			{
				Object.Destroy(value.gameObject);
			}
			Object.Destroy(DELEINAKCDC.gameObject);
			LPMOOANNJED.Clear();
			EHOKBADPJNN.MPLLKFLOEHE -= HLMLEMIHEIA;
		}

		public Rigidbody2D GetRigidbody(string KELMMDNAGGK)
		{
			NBKCFDOMAPI nBKCFDOMAPI = GDNININLMFD.NMLBCOPEEDC(KELMMDNAGGK);
			return (nBKCFDOMAPI == null || !LPMOOANNJED.ContainsKey(nBKCFDOMAPI)) ? null : LPMOOANNJED[nBKCFDOMAPI].GetComponent<Rigidbody2D>();
		}

		private void FBBBIEKKJPP(NBKCFDOMAPI BCIHLCMFAEK)
		{
			string iOCMOCCFALN = BCIHLCMFAEK.MBBPBGHKLJM.IOCMOCCFALN;
			if (stopBoneNames.Contains(iOCMOCCFALN))
			{
				return;
			}
			GameObject gameObject = new GameObject(iOCMOCCFALN);
			gameObject.layer = colliderLayer;
			Transform transform = gameObject.transform;
			LPMOOANNJED.Add(BCIHLCMFAEK, transform);
			transform.parent = base.transform;
			transform.localPosition = new Vector3(BCIHLCMFAEK.BINDPNKNACL, BCIHLCMFAEK.CJGJJAOIMDA, 0f);
			transform.localRotation = Quaternion.Euler(0f, 0f, BCIHLCMFAEK.NPOPNHPPLHK - BCIHLCMFAEK.BALNAGONJDA);
			transform.localScale = new Vector3(BCIHLCMFAEK.ELLPHGGOBIC, BCIHLCMFAEK.OFFEJMPLEHD, 0f);
			List<Collider2D> list = BCBLLGEJCDO(BCIHLCMFAEK, gameObject, GDNININLMFD, gravityScale);
			if (list.Count == 0)
			{
				float eOFAGACBNFP = BCIHLCMFAEK.MBBPBGHKLJM.EOFAGACBNFP;
				if (eOFAGACBNFP == 0f)
				{
					CircleCollider2D circleCollider2D = gameObject.AddComponent<CircleCollider2D>();
					circleCollider2D.radius = thickness * 0.5f;
				}
				else
				{
					BoxCollider2D boxCollider2D = gameObject.AddComponent<BoxCollider2D>();
					boxCollider2D.size = new Vector2(eOFAGACBNFP, thickness);
					boxCollider2D.offset = new Vector2(eOFAGACBNFP * 0.5f, 0f);
				}
			}
			Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
			if (rigidbody2D == null)
			{
				rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
			}
			rigidbody2D.gravityScale = gravityScale;
			using (ExposedList<NBKCFDOMAPI>.Enumerator enumerator = BCIHLCMFAEK.LNOLHNHBOFL.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					NBKCFDOMAPI current = enumerator.Current;
					FBBBIEKKJPP(current);
				}
			}
		}

		private void HLMLEMIHEIA(OAGCBGJOPGD KNCAFKICION)
		{
			bool fNEPOOBKNLF = GDNININLMFD.FNEPOOBKNLF;
			bool aIPMEJLIOFD = GDNININLMFD.AIPMEJLIOFD;
			bool flag = fNEPOOBKNLF ^ aIPMEJLIOFD;
			bool flag2 = fNEPOOBKNLF || aIPMEJLIOFD;
			NBKCFDOMAPI startingBone = EEGODPEKLNI;
			foreach (KeyValuePair<NBKCFDOMAPI, Transform> item in LPMOOANNJED)
			{
				NBKCFDOMAPI key = item.Key;
				Transform value = item.Value;
				bool flag3 = key == startingBone;
				Transform transform = ((!flag3) ? LPMOOANNJED[key.KNIICKBBGJB] : DELEINAKCDC);
				Vector3 position = transform.position;
				Quaternion rotation = transform.rotation;
				DBAKEKLKMIE.position = position;
				DBAKEKLKMIE.rotation = rotation;
				DBAKEKLKMIE.localScale = transform.localScale;
				Vector3 position2 = value.position;
				Vector3 vector = DBAKEKLKMIE.InverseTransformDirection(value.right);
				Vector3 vector2 = DBAKEKLKMIE.InverseTransformPoint(position2);
				float num = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
				if (flag2)
				{
					if (flag3)
					{
						if (fNEPOOBKNLF)
						{
							vector2.x *= -1f;
						}
						if (aIPMEJLIOFD)
						{
							vector2.y *= -1f;
						}
						num *= ((!flag) ? 1f : (-1f));
						if (fNEPOOBKNLF)
						{
							num += 180f;
						}
					}
					else if (flag)
					{
						num *= -1f;
						vector2.y *= -1f;
					}
				}
				key.AMFCENFNAJJ = Mathf.Lerp(key.AMFCENFNAJJ, vector2.x, mix);
				key.CNLILOEEBOJ = Mathf.Lerp(key.CNLILOEEBOJ, vector2.y, mix);
				key.ODLHFMOPCHL = Mathf.Lerp(key.ODLHFMOPCHL, num, mix);
			}
		}

		private static List<Collider2D> BCBLLGEJCDO(NBKCFDOMAPI BCIHLCMFAEK, GameObject LGDFKAMHKFM, GCJKICAPOFL GDNININLMFD, float KONEJAJODAJ)
		{
			List<Collider2D> list = new List<Collider2D>();
			JPAALKCPGNB jPAALKCPGNB = GDNININLMFD.NIADHAHOPKG ?? GDNININLMFD.LJDLCPHOBHB.IBBFJANAMLO;
			List<OAMNGFLKEFI> list2 = new List<OAMNGFLKEFI>();
			using (ExposedList<LBBAMMPJKDA>.Enumerator enumerator = GDNININLMFD.BKDKEAAAMBB.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					LBBAMMPJKDA current = enumerator.Current;
					if (current.JEBEPBEGCCF != BCIHLCMFAEK)
					{
						continue;
					}
					jPAALKCPGNB.ELMEPCJAHJN(GDNININLMFD.BKDKEAAAMBB.NFLFPHCMIOK(current), list2);
					foreach (OAMNGFLKEFI item2 in list2)
					{
						KBLNEHAAAJK kBLNEHAAAJK = item2 as KBLNEHAAAJK;
						if (kBLNEHAAAJK != null && item2.PNGPLGHKFDI.ToLower().Contains("ragdoll"))
						{
							PolygonCollider2D item = SkeletonUtility.AddBoundingBoxAsComponent(kBLNEHAAAJK, current, LGDFKAMHKFM, false, false, KONEJAJODAJ);
							list.Add(item);
						}
					}
				}
				return list;
			}
		}

		private static float OBOOLHBEEHH(NBKCFDOMAPI BCIHLCMFAEK)
		{
			NBKCFDOMAPI nBKCFDOMAPI = BCIHLCMFAEK.KNIICKBBGJB;
			float num = BCIHLCMFAEK.JKLAIHKNOLK;
			while (nBKCFDOMAPI != null)
			{
				num += nBKCFDOMAPI.JKLAIHKNOLK;
				nBKCFDOMAPI = nBKCFDOMAPI.LIMMFGDCLAB;
			}
			return num;
		}

		private static Vector3 HKHEAFDONEE(bool FNEPOOBKNLF, bool AIPMEJLIOFD)
		{
			return new Vector3((!FNEPOOBKNLF) ? 1f : (-1f), (!AIPMEJLIOFD) ? 1f : (-1f), 1f);
		}
	}
}
