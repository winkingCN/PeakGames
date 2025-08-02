using System;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity
{
	[RequireComponent(typeof(OAGCBGJOPGD))]
	[ExecuteInEditMode]
	public class SkeletonUtility : MonoBehaviour
	{
		public delegate void FBMHMJBIKGH();

		public Transform boneRoot;

		[HideInInspector]
		public SkeletonRenderer skeletonRenderer;

		[HideInInspector]
		public OAGCBGJOPGD skeletonAnimation;

		[NonSerialized]
		public List<SkeletonUtilityBone> utilityBones = new List<SkeletonUtilityBone>();

		[NonSerialized]
		public List<SkeletonUtilityConstraint> utilityConstraints = new List<SkeletonUtilityConstraint>();

		protected bool DKPLHGNHCEC;

		protected bool EANHJJGOMKG;

		protected bool ELBJMHMJHPP;

		public event FBMHMJBIKGH PEJHKOIMKLC;

		public static PolygonCollider2D AddBoundingBoxGameObject(GCJKICAPOFL GDNININLMFD, string COKOMFOMBBA, string NFKHLLDFHKO, string FKAJNAAKEFH, Transform LIMMFGDCLAB, bool BCECHMOFLNO = true)
		{
			JPAALKCPGNB jPAALKCPGNB = ((!string.IsNullOrEmpty(COKOMFOMBBA)) ? GDNININLMFD.MBBPBGHKLJM.COONIJFPADF(COKOMFOMBBA) : GDNININLMFD.MBBPBGHKLJM.NAKPPHNCJOC);
			if (jPAALKCPGNB == null)
			{
				Debug.LogError("Skin " + COKOMFOMBBA + " not found!");
				return null;
			}
			OAMNGFLKEFI oAMNGFLKEFI = jPAALKCPGNB.JGHJDGIANDD(GDNININLMFD.IBOGMECEHLD(NFKHLLDFHKO), FKAJNAAKEFH);
			if (oAMNGFLKEFI == null)
			{
				Debug.LogFormat("Attachment in slot '{0}' named '{1}' not found in skin '{2}'.", NFKHLLDFHKO, FKAJNAAKEFH, jPAALKCPGNB.IOCMOCCFALN);
				return null;
			}
			KBLNEHAAAJK kBLNEHAAAJK = oAMNGFLKEFI as KBLNEHAAAJK;
			if (kBLNEHAAAJK != null)
			{
				LBBAMMPJKDA dFKJODFHCJB = GDNININLMFD.MEKLNNENPDK(NFKHLLDFHKO);
				return AddBoundingBoxGameObject(kBLNEHAAAJK.PNGPLGHKFDI, kBLNEHAAAJK, dFKJODFHCJB, LIMMFGDCLAB, BCECHMOFLNO);
			}
			Debug.LogFormat("Attachment '{0}' was not a Bounding Box.", FKAJNAAKEFH);
			return null;
		}

		public static PolygonCollider2D AddBoundingBoxGameObject(string IOCMOCCFALN, KBLNEHAAAJK OFCDPHDDKHH, LBBAMMPJKDA DFKJODFHCJB, Transform LIMMFGDCLAB, bool BCECHMOFLNO = true)
		{
			GameObject gameObject = new GameObject("[BoundingBox]" + ((!string.IsNullOrEmpty(IOCMOCCFALN)) ? IOCMOCCFALN : OFCDPHDDKHH.PNGPLGHKFDI));
			Transform transform = gameObject.transform;
			transform.parent = LIMMFGDCLAB;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			return AddBoundingBoxAsComponent(OFCDPHDDKHH, DFKJODFHCJB, gameObject, BCECHMOFLNO);
		}

		public static PolygonCollider2D AddBoundingBoxAsComponent(KBLNEHAAAJK OFCDPHDDKHH, LBBAMMPJKDA DFKJODFHCJB, GameObject HCEDAECPCIA, bool BCECHMOFLNO = true, bool PNNADMNMEOM = true, float KONEJAJODAJ = 0f)
		{
			if (OFCDPHDDKHH == null)
			{
				return null;
			}
			if (DFKJODFHCJB.JEBEPBEGCCF != DFKJODFHCJB.LICMNMABJGL.POOHJHBAMCJ)
			{
				Rigidbody2D component = HCEDAECPCIA.GetComponent<Rigidbody2D>();
				if (component == null)
				{
					component = HCEDAECPCIA.AddComponent<Rigidbody2D>();
					component.isKinematic = PNNADMNMEOM;
					component.gravityScale = KONEJAJODAJ;
				}
			}
			PolygonCollider2D polygonCollider2D = HCEDAECPCIA.AddComponent<PolygonCollider2D>();
			polygonCollider2D.isTrigger = BCECHMOFLNO;
			SetColliderPointsLocal(polygonCollider2D, DFKJODFHCJB, OFCDPHDDKHH);
			return polygonCollider2D;
		}

		public static void SetColliderPointsLocal(PolygonCollider2D BAJOMGKMAOI, LBBAMMPJKDA DFKJODFHCJB, KBLNEHAAAJK OFCDPHDDKHH)
		{
			if (OFCDPHDDKHH != null)
			{
				if (OFCDPHDDKHH.NNKJOPGIGDB())
				{
					Debug.LogWarning("UnityEngine.PolygonCollider2D does not support weighted or animated points. Collider points will not be animated and may have incorrect orientation. If you want to use it as a collider, please remove weights and animations from the bounding box in Spine editor.");
				}
				Vector2[] points = OFCDPHDDKHH.PLNHJCIEKHM(DFKJODFHCJB, null);
				BAJOMGKMAOI.SetPath(0, points);
			}
		}

		public static Bounds GetBoundingBoxBounds(KBLNEHAAAJK BHPGAHBDMLM, float BGLFLIOOKMO = 0f)
		{
			float[] array = BHPGAHBDMLM.IAMHHPHNLHM;
			int num = array.Length;
			Bounds result = default(Bounds);
			result.center = new Vector3(array[0], array[1], 0f);
			for (int i = 2; i < num; i += 2)
			{
				result.Encapsulate(new Vector3(array[i], array[i + 1], 0f));
			}
			Vector3 size = result.size;
			size.z = BGLFLIOOKMO;
			result.size = size;
			return result;
		}

		private void Update()
		{
			GCJKICAPOFL skeleton = skeletonRenderer.skeleton;
			if (boneRoot != null && skeleton != null)
			{
				Vector3 one = Vector3.one;
				if (skeleton.FPHHECMJJBI)
				{
					one.x = -1f;
				}
				if (skeleton.NIPKPCNJCLJ)
				{
					one.y = -1f;
				}
				boneRoot.localScale = one;
			}
		}

		private void OnEnable()
		{
			if (skeletonRenderer == null)
			{
				skeletonRenderer = GetComponent<SkeletonRenderer>();
			}
			if (skeletonAnimation == null)
			{
				skeletonAnimation = GetComponent<SkeletonAnimation>();
				if (skeletonAnimation == null)
				{
					skeletonAnimation = GetComponent<SkeletonAnimator>();
				}
			}
			skeletonRenderer.BOAKMFAEPME -= PGKBDBPOIIG;
			skeletonRenderer.BOAKMFAEPME += PGKBDBPOIIG;
			if (skeletonAnimation != null)
			{
				skeletonAnimation.HIMOJNHKFMC -= HIMOJNHKFMC;
				skeletonAnimation.HIMOJNHKFMC += HIMOJNHKFMC;
			}
			CollectBones();
		}

		private void Start()
		{
			CollectBones();
		}

		private void OnDisable()
		{
			skeletonRenderer.BOAKMFAEPME -= PGKBDBPOIIG;
			if (skeletonAnimation != null)
			{
				skeletonAnimation.HIMOJNHKFMC -= HIMOJNHKFMC;
				skeletonAnimation.MPLLKFLOEHE -= MPLLKFLOEHE;
				skeletonAnimation.MBJAPEPNHNB -= MBJAPEPNHNB;
			}
		}

		private void PGKBDBPOIIG(SkeletonRenderer GPGDCCMECGF)
		{
			if (this.PEJHKOIMKLC != null)
			{
				this.PEJHKOIMKLC();
			}
			CollectBones();
		}

		public void RegisterBone(SkeletonUtilityBone JEBEPBEGCCF)
		{
			if (!utilityBones.Contains(JEBEPBEGCCF))
			{
				utilityBones.Add(JEBEPBEGCCF);
				ELBJMHMJHPP = true;
			}
		}

		public void UnregisterBone(SkeletonUtilityBone JEBEPBEGCCF)
		{
			utilityBones.Remove(JEBEPBEGCCF);
		}

		public void RegisterConstraint(SkeletonUtilityConstraint KODAFOCDPLA)
		{
			if (!utilityConstraints.Contains(KODAFOCDPLA))
			{
				utilityConstraints.Add(KODAFOCDPLA);
				ELBJMHMJHPP = true;
			}
		}

		public void UnregisterConstraint(SkeletonUtilityConstraint KODAFOCDPLA)
		{
			utilityConstraints.Remove(KODAFOCDPLA);
		}

		public void CollectBones()
		{
			GCJKICAPOFL skeleton = skeletonRenderer.skeleton;
			if (skeleton == null)
			{
				return;
			}
			if (boneRoot != null)
			{
				List<object> list = new List<object>();
				ExposedList<JICANJGGKNH> exposedList = skeleton.PCBLMDHFHII;
				int i = 0;
				for (int count = exposedList.Count; i < count; i++)
				{
					list.Add(exposedList.Items[i].CAEMELGEOAE);
				}
				ExposedList<DLKMEPPLCGM> exposedList2 = skeleton.GOCDIAICJKK;
				int j = 0;
				for (int count2 = exposedList2.Count; j < count2; j++)
				{
					list.Add(exposedList2.Items[j].CAEMELGEOAE);
				}
				List<SkeletonUtilityBone> list2 = utilityBones;
				int k = 0;
				for (int count3 = list2.Count; k < count3; k++)
				{
					SkeletonUtilityBone skeletonUtilityBone = list2[k];
					if (skeletonUtilityBone.bone != null)
					{
						DKPLHGNHCEC |= skeletonUtilityBone.mode == SkeletonUtilityBone.HNLALCIKDAK.Override;
						EANHJJGOMKG |= list.Contains(skeletonUtilityBone.bone);
					}
				}
				EANHJJGOMKG |= utilityConstraints.Count > 0;
				if (skeletonAnimation != null)
				{
					skeletonAnimation.MPLLKFLOEHE -= MPLLKFLOEHE;
					skeletonAnimation.MBJAPEPNHNB -= MBJAPEPNHNB;
					if (DKPLHGNHCEC || EANHJJGOMKG)
					{
						skeletonAnimation.MPLLKFLOEHE += MPLLKFLOEHE;
					}
					if (EANHJJGOMKG)
					{
						skeletonAnimation.MBJAPEPNHNB += MBJAPEPNHNB;
					}
				}
				ELBJMHMJHPP = false;
			}
			else
			{
				utilityBones.Clear();
				utilityConstraints.Clear();
			}
		}

		private void HIMOJNHKFMC(OAGCBGJOPGD HFIBKKLENJH)
		{
			if (ELBJMHMJHPP)
			{
				CollectBones();
			}
			List<SkeletonUtilityBone> list = utilityBones;
			if (list != null)
			{
				int i = 0;
				for (int count = list.Count; i < count; i++)
				{
					list[i].transformLerpComplete = false;
				}
				NIGNPAGLDMG();
			}
		}

		private void MPLLKFLOEHE(OAGCBGJOPGD HFIBKKLENJH)
		{
			NIGNPAGLDMG();
			int i = 0;
			for (int count = utilityConstraints.Count; i < count; i++)
			{
				utilityConstraints[i].DoUpdate();
			}
		}

		private void MBJAPEPNHNB(OAGCBGJOPGD HFIBKKLENJH)
		{
			NIGNPAGLDMG();
		}

		private void NIGNPAGLDMG()
		{
			if (boneRoot == null)
			{
				CollectBones();
			}
			List<SkeletonUtilityBone> list = utilityBones;
			if (list != null)
			{
				int i = 0;
				for (int count = list.Count; i < count; i++)
				{
					list[i].DoUpdate();
				}
			}
		}

		public Transform GetBoneRoot()
		{
			if (boneRoot != null)
			{
				return boneRoot;
			}
			boneRoot = new GameObject("SkeletonUtility-Root").transform;
			boneRoot.parent = base.transform;
			boneRoot.localPosition = Vector3.zero;
			boneRoot.localRotation = Quaternion.identity;
			boneRoot.localScale = Vector3.one;
			return boneRoot;
		}

		public GameObject SpawnRoot(SkeletonUtilityBone.HNLALCIKDAK LJCPOAOKFOE, bool FADJPCHMMBH, bool JMFJBAEAFHB, bool NLIEMLABEBE)
		{
			GetBoneRoot();
			GCJKICAPOFL skeleton = skeletonRenderer.skeleton;
			GameObject result = SpawnBone(skeleton.POOHJHBAMCJ, boneRoot, LJCPOAOKFOE, FADJPCHMMBH, JMFJBAEAFHB, NLIEMLABEBE);
			CollectBones();
			return result;
		}

		public GameObject SpawnHierarchy(SkeletonUtilityBone.HNLALCIKDAK LJCPOAOKFOE, bool FADJPCHMMBH, bool JMFJBAEAFHB, bool NLIEMLABEBE)
		{
			GetBoneRoot();
			GCJKICAPOFL skeleton = skeletonRenderer.skeleton;
			GameObject result = SpawnBoneRecursively(skeleton.POOHJHBAMCJ, boneRoot, LJCPOAOKFOE, FADJPCHMMBH, JMFJBAEAFHB, NLIEMLABEBE);
			CollectBones();
			return result;
		}

		public GameObject SpawnBoneRecursively(NBKCFDOMAPI JEBEPBEGCCF, Transform LIMMFGDCLAB, SkeletonUtilityBone.HNLALCIKDAK LJCPOAOKFOE, bool FADJPCHMMBH, bool JMFJBAEAFHB, bool NLIEMLABEBE)
		{
			GameObject gameObject = SpawnBone(JEBEPBEGCCF, LIMMFGDCLAB, LJCPOAOKFOE, FADJPCHMMBH, JMFJBAEAFHB, NLIEMLABEBE);
			ExposedList<NBKCFDOMAPI> exposedList = JEBEPBEGCCF.LNOLHNHBOFL;
			int i = 0;
			for (int count = exposedList.Count; i < count; i++)
			{
				NBKCFDOMAPI jEBEPBEGCCF = exposedList.Items[i];
				SpawnBoneRecursively(jEBEPBEGCCF, gameObject.transform, LJCPOAOKFOE, FADJPCHMMBH, JMFJBAEAFHB, NLIEMLABEBE);
			}
			return gameObject;
		}

		public GameObject SpawnBone(NBKCFDOMAPI JEBEPBEGCCF, Transform LIMMFGDCLAB, SkeletonUtilityBone.HNLALCIKDAK LJCPOAOKFOE, bool FADJPCHMMBH, bool JMFJBAEAFHB, bool NLIEMLABEBE)
		{
			GameObject gameObject = new GameObject(JEBEPBEGCCF.LJDLCPHOBHB.PNGPLGHKFDI);
			gameObject.transform.parent = LIMMFGDCLAB;
			SkeletonUtilityBone skeletonUtilityBone = gameObject.AddComponent<SkeletonUtilityBone>();
			skeletonUtilityBone.skeletonUtility = this;
			skeletonUtilityBone.position = FADJPCHMMBH;
			skeletonUtilityBone.rotation = JMFJBAEAFHB;
			skeletonUtilityBone.scale = NLIEMLABEBE;
			skeletonUtilityBone.mode = LJCPOAOKFOE;
			skeletonUtilityBone.zPosition = true;
			skeletonUtilityBone.Reset();
			skeletonUtilityBone.bone = JEBEPBEGCCF;
			skeletonUtilityBone.boneName = JEBEPBEGCCF.LJDLCPHOBHB.PNGPLGHKFDI;
			skeletonUtilityBone.valid = true;
			if (LJCPOAOKFOE == SkeletonUtilityBone.HNLALCIKDAK.Override)
			{
				if (JMFJBAEAFHB)
				{
					gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, skeletonUtilityBone.bone.JKLAIHKNOLK);
				}
				if (FADJPCHMMBH)
				{
					gameObject.transform.localPosition = new Vector3(skeletonUtilityBone.bone.CBPFFIBINEH, skeletonUtilityBone.bone.MOAGLBJDKKL, 0f);
				}
				gameObject.transform.localScale = new Vector3(skeletonUtilityBone.bone.IAFNPOKEFMB, skeletonUtilityBone.bone.GFMCPIJHIGD, 0f);
			}
			return gameObject;
		}
	}
}
