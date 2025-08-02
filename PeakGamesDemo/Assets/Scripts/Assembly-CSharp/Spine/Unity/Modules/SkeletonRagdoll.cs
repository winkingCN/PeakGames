using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	[RequireComponent(typeof(SkeletonRenderer))]
	public class SkeletonRagdoll : MonoBehaviour
	{
		public class FDHCJALIPPH : PropertyAttribute
		{
		}

		private static Transform DBAKEKLKMIE;

		[LKNNBABNCFC("", "", true, false)]
		[Header("Hierarchy")]
		public string startingBoneName = string.Empty;

		[LKNNBABNCFC("", "", true, false)]
		public List<string> stopBoneNames = new List<string>();

		[Header("Parameters")]
		public bool applyOnStart;

		[Tooltip("Warning!  You will have to re-enable and tune mix values manually if attempting to remove the ragdoll system.")]
		public bool disableIK = true;

		public bool disableOtherConstraints;

		[Tooltip("Set RootRigidbody IsKinematic to true when Apply is called.")]
		[Space(18f)]
		public bool pinStartBone;

		[Tooltip("Enable Collision between adjacent ragdoll elements (IE: Neck and Head)")]
		public bool enableJointCollision;

		public bool useGravity = true;

		[Tooltip("If no BoundingBox Attachment is attached to a bone, this becomes the default Width or Radius of a Bone's ragdoll Rigidbody")]
		public float thickness = 0.125f;

		[Tooltip("Default rotational limit value.  Min is negative this value, Max is this value.")]
		public float rotationLimit = 20f;

		public float rootMass = 20f;

		[Tooltip("If your ragdoll seems unstable or uneffected by limits, try lowering this value.")]
		[Range(0.01f, 1f)]
		public float massFalloffFactor = 0.4f;

		[Tooltip("The layer assigned to all of the rigidbody parts.")]
		public int colliderLayer;

		[Range(0f, 1f)]
		public float mix = 1f;

		private OAGCBGJOPGD EHOKBADPJNN;

		private GCJKICAPOFL GDNININLMFD;

		private Dictionary<NBKCFDOMAPI, Transform> LPMOOANNJED = new Dictionary<NBKCFDOMAPI, Transform>();

		private Transform DELEINAKCDC;

		private Vector3 LDGGEMBBCCM;

		private bool AEDFIIPIPME;

		public Rigidbody NAPDBIDONFC { get; private set; }

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

		public Rigidbody[] MNGOJOHKOHG
		{
			get
			{
				if (!AEDFIIPIPME)
				{
					return new Rigidbody[0];
				}
				Rigidbody[] array = new Rigidbody[LPMOOANNJED.Count];
				int num = 0;
				foreach (Transform value in LPMOOANNJED.Values)
				{
					array[num] = value.GetComponent<Rigidbody>();
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
				DBAKEKLKMIE.hideFlags = HideFlags.HideInHierarchy;
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
			EEGODPEKLNI = GDNININLMFD.NMLBCOPEEDC(startingBoneName);
			FBBBIEKKJPP(EEGODPEKLNI);
			NAPDBIDONFC = LPMOOANNJED[EEGODPEKLNI].GetComponent<Rigidbody>();
			NAPDBIDONFC.isKinematic = pinStartBone;
			NAPDBIDONFC.mass = rootMass;
			List<Collider> list = new List<Collider>();
			foreach (KeyValuePair<NBKCFDOMAPI, Transform> item in LPMOOANNJED)
			{
				NBKCFDOMAPI key = item.Key;
				Transform value = item.Value;
				list.Add(value.GetComponent<Collider>());
				Transform transform;
				if (key == EEGODPEKLNI)
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
				Rigidbody component = transform.GetComponent<Rigidbody>();
				if (component != null)
				{
					HingeJoint hingeJoint = value.gameObject.AddComponent<HingeJoint>();
					hingeJoint.connectedBody = component;
					Vector3 connectedAnchor = transform.InverseTransformPoint(value.position);
					connectedAnchor.x *= 1f;
					hingeJoint.connectedAnchor = connectedAnchor;
					hingeJoint.axis = Vector3.forward;
					hingeJoint.GetComponent<Rigidbody>().mass = hingeJoint.connectedBody.mass * massFalloffFactor;
					hingeJoint.limits = new JointLimits
					{
						min = 0f - rotationLimit,
						max = rotationLimit
					};
					hingeJoint.useLimits = true;
					hingeJoint.enableCollision = enableJointCollision;
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (i != j)
					{
						Physics.IgnoreCollision(list[i], list[j]);
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

		public Rigidbody GetRigidbody(string KELMMDNAGGK)
		{
			NBKCFDOMAPI nBKCFDOMAPI = GDNININLMFD.NMLBCOPEEDC(KELMMDNAGGK);
			return (nBKCFDOMAPI == null || !LPMOOANNJED.ContainsKey(nBKCFDOMAPI)) ? null : LPMOOANNJED[nBKCFDOMAPI].GetComponent<Rigidbody>();
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
			transform.localScale = new Vector3(BCIHLCMFAEK.ELLPHGGOBIC, BCIHLCMFAEK.OFFEJMPLEHD, 1f);
			List<Collider> list = BCBLLGEJCDO(BCIHLCMFAEK);
			if (list.Count == 0)
			{
				float num = BCIHLCMFAEK.LJDLCPHOBHB.EJIAJLPHOGC;
				if (num == 0f)
				{
					SphereCollider sphereCollider = gameObject.AddComponent<SphereCollider>();
					sphereCollider.radius = thickness * 0.5f;
				}
				else
				{
					BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
					boxCollider.size = new Vector3(num, thickness, thickness);
					boxCollider.center = new Vector3(num * 0.5f, 0f);
				}
			}
			Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
			rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
			using (ExposedList<NBKCFDOMAPI>.Enumerator enumerator = BCIHLCMFAEK.LNOLHNHBOFL.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					NBKCFDOMAPI current = enumerator.Current;
					FBBBIEKKJPP(current);
				}
			}
		}

		private void HLMLEMIHEIA(OAGCBGJOPGD NHPAGGIFGHN)
		{
			bool fNEPOOBKNLF = GDNININLMFD.FNEPOOBKNLF;
			bool aIPMEJLIOFD = GDNININLMFD.AIPMEJLIOFD;
			bool flag = fNEPOOBKNLF ^ aIPMEJLIOFD;
			bool flag2 = fNEPOOBKNLF || aIPMEJLIOFD;
			foreach (KeyValuePair<NBKCFDOMAPI, Transform> item in LPMOOANNJED)
			{
				NBKCFDOMAPI key = item.Key;
				Transform value = item.Value;
				bool flag3 = key == EEGODPEKLNI;
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

		private List<Collider> BCBLLGEJCDO(NBKCFDOMAPI BCIHLCMFAEK)
		{
			List<Collider> list = new List<Collider>();
			Transform transform = LPMOOANNJED[BCIHLCMFAEK];
			GameObject gameObject = transform.gameObject;
			JPAALKCPGNB jPAALKCPGNB = GDNININLMFD.NIADHAHOPKG ?? GDNININLMFD.LJDLCPHOBHB.IBBFJANAMLO;
			List<OAMNGFLKEFI> list2 = new List<OAMNGFLKEFI>();
			using (ExposedList<LBBAMMPJKDA>.Enumerator enumerator = GDNININLMFD.BKDKEAAAMBB.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					LBBAMMPJKDA current = enumerator.Current;
					if (current.LKMOJLJHLCN != BCIHLCMFAEK)
					{
						continue;
					}
					jPAALKCPGNB.ELMEPCJAHJN(GDNININLMFD.BKDKEAAAMBB.NFLFPHCMIOK(current), list2);
					foreach (OAMNGFLKEFI item in list2)
					{
						KBLNEHAAAJK kBLNEHAAAJK = item as KBLNEHAAAJK;
						if (kBLNEHAAAJK != null && item.PNGPLGHKFDI.ToLower().Contains("ragdoll"))
						{
							BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
							Bounds boundingBoxBounds = SkeletonUtility.GetBoundingBoxBounds(kBLNEHAAAJK, thickness);
							boxCollider.center = boundingBoxBounds.center;
							boxCollider.size = boundingBoxBounds.size;
							list.Add(boxCollider);
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
	}
}
