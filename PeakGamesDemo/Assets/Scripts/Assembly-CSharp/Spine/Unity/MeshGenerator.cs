using System;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity
{
	[Serializable]
	public class MeshGenerator
	{
		[Serializable]
		public struct Settings
		{
			public bool useClipping;

			[Range(-0.1f, 0f)]
			[Space]
			public float zSpacing;

			[Header("Vertex Data")]
			[Space]
			public bool pmaVertexColors;

			public bool tintBlack;

			public bool calculateTangents;

			public bool addNormals;

			public bool immutableTriangles;

			public static Settings Default
			{
				get
				{
					Settings result = default(Settings);
					result.pmaVertexColors = true;
					result.zSpacing = 0f;
					result.useClipping = true;
					result.tintBlack = false;
					result.calculateTangents = false;
					result.addNormals = false;
					result.immutableTriangles = false;
					return result;
				}
			}
		}

		public Settings settings = Settings.Default;

		private const float BoundsMinDefault = float.PositiveInfinity;

		private const float BoundsMaxDefault = float.NegativeInfinity;

		[NonSerialized]
		private readonly ExposedList<Vector3> vertexBuffer = new ExposedList<Vector3>(4);

		[NonSerialized]
		private readonly ExposedList<Vector2> uvBuffer = new ExposedList<Vector2>(4);

		[NonSerialized]
		private readonly ExposedList<Color32> colorBuffer = new ExposedList<Color32>(4);

		[NonSerialized]
		private readonly ExposedList<ExposedList<int>> submeshes;

		[NonSerialized]
		private Vector2 meshBoundsMin;

		[NonSerialized]
		private Vector2 meshBoundsMax;

		[NonSerialized]
		private float meshBoundsThickness;

		[NonSerialized]
		private int submeshIndex;

		[NonSerialized]
		private BGPAGKKLJCH clipper;

		[NonSerialized]
		private float[] tempVerts;

		[NonSerialized]
		private int[] regionTriangles;

		[NonSerialized]
		private Vector3[] normals;

		[NonSerialized]
		private Vector4[] tangents;

		[NonSerialized]
		private Vector2[] tempTanBuffer;

		[NonSerialized]
		private ExposedList<Vector2> uv2;

		[NonSerialized]
		private ExposedList<Vector2> uv3;

		public int VertexCount
		{
			get
			{
				return vertexBuffer.Count;
			}
		}

		public BNLAAFPAFKN Buffers
		{
			get
			{
				BNLAAFPAFKN result = default(BNLAAFPAFKN);
				result.BKJOIFFAGKE = VertexCount;
				result.ENAGNCJFJKK = vertexBuffer.Items;
				result.COHOMOFDFDJ = uvBuffer.Items;
				result.IOAAFPIDCMP = colorBuffer.Items;
				result.KBKIENONBJH = this;
				return result;
			}
		}

		public MeshGenerator()
		{
			ExposedList<ExposedList<int>> exposedList = new ExposedList<ExposedList<int>>();
			exposedList.JEACJNAKLDJ(new ExposedList<int>(6));
			submeshes = exposedList;
			clipper = new BGPAGKKLJCH();
			tempVerts = new float[8];
			regionTriangles = new int[6] { 0, 1, 2, 2, 3, 0 };
			base._002Ector();
		}

		public static void AMPBCIMDBDP(OOBEMJJCEGO LLINFKJDIJB, GCJKICAPOFL GDNININLMFD, Material GHPFOPNNJOB)
		{
			ExposedList<LBBAMMPJKDA> cOACJAFIPEI = GDNININLMFD.COACJAFIPEI;
			int count = cOACJAFIPEI.Count;
			LLINFKJDIJB.BOPEPLONIFL();
			ExposedList<OFMBOEDKGMI> dJBCCKODCLK = LLINFKJDIJB.DJBCCKODCLK;
			dJBCCKODCLK.NKMKBLFBOFC(1);
			LLINFKJDIJB.MLPNEHCDBOD.NKMKBLFBOFC(count);
			OAMNGFLKEFI[] items = LLINFKJDIJB.MLPNEHCDBOD.Items;
			int num = 0;
			OFMBOEDKGMI oFMBOEDKGMI = default(OFMBOEDKGMI);
			oFMBOEDKGMI.GDNININLMFD = GDNININLMFD;
			oFMBOEDKGMI.GONLFHIHMJF = -1;
			oFMBOEDKGMI.INMKEHEAHNO = 0;
			oFMBOEDKGMI.NCCOCLMPNIK = 0;
			oFMBOEDKGMI.GHPFOPNNJOB = GHPFOPNNJOB;
			oFMBOEDKGMI.JLIINNOLOLC = false;
			oFMBOEDKGMI.BGKHIDKDGAC = count;
			OFMBOEDKGMI oFMBOEDKGMI2 = oFMBOEDKGMI;
			bool gHPJDHGHJNO = false;
			LBBAMMPJKDA[] items2 = cOACJAFIPEI.Items;
			for (int i = 0; i < count; i++)
			{
				LBBAMMPJKDA lBBAMMPJKDA = items2[i];
				OAMNGFLKEFI oAMNGFLKEFI = (items[i] = lBBAMMPJKDA.DFHHMKMLCFF);
				MKEALIMJCFJ mKEALIMJCFJ = oAMNGFLKEFI as MKEALIMJCFJ;
				int num2;
				int num3;
				if (mKEALIMJCFJ != null)
				{
					num2 = 4;
					num3 = 6;
				}
				else
				{
					MGCLDKAFCIB mGCLDKAFCIB = oAMNGFLKEFI as MGCLDKAFCIB;
					if (mGCLDKAFCIB != null)
					{
						num2 = mGCLDKAFCIB.MCCBDCEJDBC >> 1;
						num3 = mGCLDKAFCIB.NPDGLMEOKIO.Length;
					}
					else
					{
						ACEGNBDLKEG aCEGNBDLKEG = oAMNGFLKEFI as ACEGNBDLKEG;
						if (aCEGNBDLKEG != null)
						{
							oFMBOEDKGMI2.JIBMAOPFGEO = true;
							gHPJDHGHJNO = true;
						}
						num2 = 0;
						num3 = 0;
					}
				}
				oFMBOEDKGMI2.GHOLJENMENP += num3;
				oFMBOEDKGMI2.KCDEGJNOLPL += num2;
				num += num2;
			}
			LLINFKJDIJB.GHPJDHGHJNO = gHPJDHGHJNO;
			LLINFKJDIJB.KCDEGJNOLPL = num;
			dJBCCKODCLK.Items[0] = oFMBOEDKGMI2;
		}

		public static void HBIMAGKOPGB(OOBEMJJCEGO LLINFKJDIJB, GCJKICAPOFL GDNININLMFD, Dictionary<LBBAMMPJKDA, Material> FICAMCEHGBJ, List<LBBAMMPJKDA> BPMJINJDLIN, bool LNEOAKBJFCJ, bool LMDPKPHCMOD = false)
		{
			ExposedList<LBBAMMPJKDA> cOACJAFIPEI = GDNININLMFD.COACJAFIPEI;
			int count = cOACJAFIPEI.Count;
			LLINFKJDIJB.BOPEPLONIFL();
			ExposedList<OFMBOEDKGMI> dJBCCKODCLK = LLINFKJDIJB.DJBCCKODCLK;
			LLINFKJDIJB.MLPNEHCDBOD.NKMKBLFBOFC(count);
			OAMNGFLKEFI[] items = LLINFKJDIJB.MLPNEHCDBOD.Items;
			int num = 0;
			bool gHPJDHGHJNO = false;
			OFMBOEDKGMI oFMBOEDKGMI = default(OFMBOEDKGMI);
			oFMBOEDKGMI.GDNININLMFD = GDNININLMFD;
			oFMBOEDKGMI.GONLFHIHMJF = -1;
			OFMBOEDKGMI oFMBOEDKGMI2 = oFMBOEDKGMI;
			bool flag = FICAMCEHGBJ != null && FICAMCEHGBJ.Count > 0;
			int num2 = ((BPMJINJDLIN != null) ? BPMJINJDLIN.Count : 0);
			bool flag2 = num2 > 0;
			int num3 = -1;
			int gONLFHIHMJF = -1;
			HMGLMNHOBHA hMGLMNHOBHA = null;
			int num4 = 0;
			LBBAMMPJKDA[] items2 = cOACJAFIPEI.Items;
			for (int i = 0; i < count; i++)
			{
				LBBAMMPJKDA lBBAMMPJKDA = items2[i];
				OAMNGFLKEFI oAMNGFLKEFI = (items[i] = lBBAMMPJKDA.DFHHMKMLCFF);
				int num5 = 0;
				int num6 = 0;
				object obj = null;
				bool flag3 = false;
				MKEALIMJCFJ mKEALIMJCFJ = oAMNGFLKEFI as MKEALIMJCFJ;
				if (mKEALIMJCFJ != null)
				{
					obj = mKEALIMJCFJ.HIPOEPNPBPO;
					num5 = 4;
					num6 = 6;
				}
				else
				{
					MGCLDKAFCIB mGCLDKAFCIB = oAMNGFLKEFI as MGCLDKAFCIB;
					if (mGCLDKAFCIB != null)
					{
						obj = mGCLDKAFCIB.HIPOEPNPBPO;
						num5 = mGCLDKAFCIB.MCCBDCEJDBC >> 1;
						num6 = mGCLDKAFCIB.NPDGLMEOKIO.Length;
					}
					else
					{
						ACEGNBDLKEG aCEGNBDLKEG = oAMNGFLKEFI as ACEGNBDLKEG;
						if (aCEGNBDLKEG != null)
						{
							hMGLMNHOBHA = aCEGNBDLKEG.BGKHIDKDGAC;
							num3 = i;
							oFMBOEDKGMI2.JIBMAOPFGEO = true;
							gHPJDHGHJNO = true;
						}
						flag3 = true;
					}
				}
				if (hMGLMNHOBHA != null && lBBAMMPJKDA.MBBPBGHKLJM == hMGLMNHOBHA && i != num3)
				{
					hMGLMNHOBHA = null;
					num3 = -1;
				}
				if (flag2)
				{
					oFMBOEDKGMI2.JLIINNOLOLC = false;
					for (int j = 0; j < num2; j++)
					{
						if (object.ReferenceEquals(lBBAMMPJKDA, BPMJINJDLIN[j]))
						{
							oFMBOEDKGMI2.JLIINNOLOLC = true;
							break;
						}
					}
				}
				if (flag3)
				{
					if (oFMBOEDKGMI2.JLIINNOLOLC && LNEOAKBJFCJ)
					{
						oFMBOEDKGMI2.BGKHIDKDGAC = i;
						oFMBOEDKGMI2.GONLFHIHMJF = gONLFHIHMJF;
						dJBCCKODCLK.NKMKBLFBOFC(num4 + 1);
						dJBCCKODCLK.Items[num4] = oFMBOEDKGMI2;
						num4++;
						oFMBOEDKGMI2.INMKEHEAHNO = i;
						gONLFHIHMJF = num3;
						oFMBOEDKGMI2.GHOLJENMENP = 0;
						oFMBOEDKGMI2.KCDEGJNOLPL = 0;
						oFMBOEDKGMI2.NCCOCLMPNIK = num;
						oFMBOEDKGMI2.JIBMAOPFGEO = num3 >= 0;
					}
					continue;
				}
				Material value;
				if (flag)
				{
					if (!FICAMCEHGBJ.TryGetValue(lBBAMMPJKDA, out value))
					{
						value = (Material)((FCPKAKFLFEG)obj).CPIKPMLODAK.FDCGLBIAFPB;
					}
				}
				else
				{
					value = (Material)((FCPKAKFLFEG)obj).CPIKPMLODAK.FDCGLBIAFPB;
				}
				if (oFMBOEDKGMI2.JLIINNOLOLC || (oFMBOEDKGMI2.KCDEGJNOLPL > 0 && !object.ReferenceEquals(oFMBOEDKGMI2.GHPFOPNNJOB, value)))
				{
					oFMBOEDKGMI2.BGKHIDKDGAC = i;
					oFMBOEDKGMI2.GONLFHIHMJF = gONLFHIHMJF;
					dJBCCKODCLK.NKMKBLFBOFC(num4 + 1);
					dJBCCKODCLK.Items[num4] = oFMBOEDKGMI2;
					num4++;
					oFMBOEDKGMI2.INMKEHEAHNO = i;
					gONLFHIHMJF = num3;
					oFMBOEDKGMI2.GHOLJENMENP = 0;
					oFMBOEDKGMI2.KCDEGJNOLPL = 0;
					oFMBOEDKGMI2.NCCOCLMPNIK = num;
					oFMBOEDKGMI2.JIBMAOPFGEO = num3 >= 0;
				}
				oFMBOEDKGMI2.GHPFOPNNJOB = value;
				oFMBOEDKGMI2.GHOLJENMENP += num6;
				oFMBOEDKGMI2.KCDEGJNOLPL += num5;
				oFMBOEDKGMI2.NCCOCLMPNIK = num;
				num += num5;
			}
			if (oFMBOEDKGMI2.KCDEGJNOLPL > 0)
			{
				oFMBOEDKGMI2.BGKHIDKDGAC = count;
				oFMBOEDKGMI2.GONLFHIHMJF = gONLFHIHMJF;
				oFMBOEDKGMI2.JLIINNOLOLC = false;
				dJBCCKODCLK.NKMKBLFBOFC(num4 + 1);
				dJBCCKODCLK.Items[num4] = oFMBOEDKGMI2;
			}
			LLINFKJDIJB.GHPJDHGHJNO = gHPJDHGHJNO;
			LLINFKJDIJB.KCDEGJNOLPL = num;
			LLINFKJDIJB.LMDPKPHCMOD = LMDPKPHCMOD;
		}

		public static void DMIEAEEHMGH(ExposedList<OFMBOEDKGMI> EFDAKCBNHBC, Dictionary<Material, Material> GFPOJPJNIPJ)
		{
			OFMBOEDKGMI[] items = EFDAKCBNHBC.Items;
			for (int i = 0; i < EFDAKCBNHBC.Count; i++)
			{
				Material gHPFOPNNJOB = items[i].GHPFOPNNJOB;
				Material value;
				if (GFPOJPJNIPJ.TryGetValue(gHPFOPNNJOB, out value))
				{
					items[i].GHPFOPNNJOB = value;
				}
			}
		}

		public void JLDDJANACLO()
		{
			vertexBuffer.BOPEPLONIFL(false);
			colorBuffer.BOPEPLONIFL(false);
			uvBuffer.BOPEPLONIFL(false);
			clipper.LEOBDLEECHN();
			meshBoundsMin.x = float.PositiveInfinity;
			meshBoundsMin.y = float.PositiveInfinity;
			meshBoundsMax.x = float.NegativeInfinity;
			meshBoundsMax.y = float.NegativeInfinity;
			meshBoundsThickness = 0f;
			submeshes.Count = 1;
			submeshes.Items[0].BOPEPLONIFL(false);
			submeshIndex = 0;
		}

		public void IIEGHMLKOON(OFMBOEDKGMI DOFGHNBCBCA, bool BEIMPIFBJEC = true)
		{
			Settings settings = this.settings;
			if (submeshes.Count - 1 < submeshIndex)
			{
				submeshes.NKMKBLFBOFC(submeshIndex + 1);
				if (submeshes.Items[submeshIndex] == null)
				{
					submeshes.Items[submeshIndex] = new ExposedList<int>();
				}
			}
			ExposedList<int> exposedList = submeshes.Items[submeshIndex];
			exposedList.BOPEPLONIFL(false);
			GCJKICAPOFL gDNININLMFD = DOFGHNBCBCA.GDNININLMFD;
			LBBAMMPJKDA[] items = gDNININLMFD.COACJAFIPEI.Items;
			Color32 color = default(Color32);
			float num = gDNININLMFD.MNIMEAMHNMI * 255f;
			float gPGDCCMECGF = gDNININLMFD.GPGDCCMECGF;
			float hJMBDGKAOBP = gDNININLMFD.HJMBDGKAOBP;
			float bCIHLCMFAEK = gDNININLMFD.BCIHLCMFAEK;
			Vector2 vector = meshBoundsMin;
			Vector2 vector2 = meshBoundsMax;
			float zSpacing = settings.zSpacing;
			bool pmaVertexColors = settings.pmaVertexColors;
			bool tintBlack = settings.tintBlack;
			bool flag = settings.useClipping && DOFGHNBCBCA.JIBMAOPFGEO;
			if (flag && DOFGHNBCBCA.GONLFHIHMJF >= 0)
			{
				LBBAMMPJKDA lBBAMMPJKDA = items[DOFGHNBCBCA.GONLFHIHMJF];
				clipper.CABJPGOPNCE(lBBAMMPJKDA, lBBAMMPJKDA.DFHHMKMLCFF as ACEGNBDLKEG);
			}
			for (int i = DOFGHNBCBCA.INMKEHEAHNO; i < DOFGHNBCBCA.BGKHIDKDGAC; i++)
			{
				LBBAMMPJKDA lBBAMMPJKDA2 = items[i];
				OAMNGFLKEFI dFHHMKMLCFF = lBBAMMPJKDA2.DFHHMKMLCFF;
				float z = zSpacing * (float)i;
				float[] array = tempVerts;
				Color color2 = default(Color);
				MKEALIMJCFJ mKEALIMJCFJ = dFHHMKMLCFF as MKEALIMJCFJ;
				float[] array2;
				int[] array3;
				int num2;
				int num3;
				if (mKEALIMJCFJ != null)
				{
					mKEALIMJCFJ.EPLAHNOCDIB(lBBAMMPJKDA2.JEBEPBEGCCF, array, 0);
					array2 = mKEALIMJCFJ.NDIFGLEBDLE;
					array3 = regionTriangles;
					color2.r = mKEALIMJCFJ.GPGDCCMECGF;
					color2.g = mKEALIMJCFJ.HJMBDGKAOBP;
					color2.b = mKEALIMJCFJ.BCIHLCMFAEK;
					color2.a = mKEALIMJCFJ.MNIMEAMHNMI;
					num2 = 4;
					num3 = 6;
				}
				else
				{
					MGCLDKAFCIB mGCLDKAFCIB = dFHHMKMLCFF as MGCLDKAFCIB;
					if (mGCLDKAFCIB == null)
					{
						if (flag)
						{
							ACEGNBDLKEG aCEGNBDLKEG = dFHHMKMLCFF as ACEGNBDLKEG;
							if (aCEGNBDLKEG != null)
							{
								clipper.CABJPGOPNCE(lBBAMMPJKDA2, aCEGNBDLKEG);
							}
						}
						continue;
					}
					int mCCBDCEJDBC = mGCLDKAFCIB.MCCBDCEJDBC;
					if (array.Length < mCCBDCEJDBC)
					{
						array = (tempVerts = new float[mCCBDCEJDBC]);
					}
					mGCLDKAFCIB.EPLAHNOCDIB(lBBAMMPJKDA2, 0, mCCBDCEJDBC, array, 0);
					array2 = mGCLDKAFCIB.NDIFGLEBDLE;
					array3 = mGCLDKAFCIB.NPDGLMEOKIO;
					color2.r = mGCLDKAFCIB.GPGDCCMECGF;
					color2.g = mGCLDKAFCIB.HJMBDGKAOBP;
					color2.b = mGCLDKAFCIB.BCIHLCMFAEK;
					color2.a = mGCLDKAFCIB.MNIMEAMHNMI;
					num2 = mCCBDCEJDBC >> 1;
					num3 = mGCLDKAFCIB.NPDGLMEOKIO.Length;
				}
				if (pmaVertexColors)
				{
					color.a = (byte)(num * lBBAMMPJKDA2.MNIMEAMHNMI * color2.a);
					color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * color2.r * (float)(int)color.a);
					color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * color2.g * (float)(int)color.a);
					color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * color2.b * (float)(int)color.a);
					if (lBBAMMPJKDA2.MBBPBGHKLJM.DNLHLBINHHE == AOOPCGDMICP.Additive)
					{
						color.a = 0;
					}
				}
				else
				{
					color.a = (byte)(num * lBBAMMPJKDA2.MNIMEAMHNMI * color2.a);
					color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * color2.r * 255f);
					color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * color2.g * 255f);
					color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * color2.b * 255f);
				}
				if (flag && clipper.PFGJLJPKOMC)
				{
					clipper.IKEPENEIHMB(array, num2 << 1, array3, num3, array2);
					array = clipper.PMICOANAODO.Items;
					num2 = clipper.PMICOANAODO.Count >> 1;
					array3 = clipper.IKBFHHMOGMG.Items;
					num3 = clipper.IKBFHHMOGMG.Count;
					array2 = clipper.HPDALGDFHGN.Items;
				}
				if (num2 != 0 && num3 != 0)
				{
					if (tintBlack)
					{
						GHBMNGLAMHE(lBBAMMPJKDA2.FHPFAEDHEGG, lBBAMMPJKDA2.AONHFIBNFLD, lBBAMMPJKDA2.DLGDBCBCIED, num2);
					}
					int count = vertexBuffer.Count;
					int num4 = count + num2;
					if (num4 > vertexBuffer.Items.Length)
					{
						Array.Resize(ref vertexBuffer.Items, num4);
						Array.Resize(ref uvBuffer.Items, num4);
						Array.Resize(ref colorBuffer.Items, num4);
					}
					vertexBuffer.Count = (uvBuffer.Count = (colorBuffer.Count = num4));
					Vector3[] items2 = vertexBuffer.Items;
					Vector2[] items3 = uvBuffer.Items;
					Color32[] items4 = colorBuffer.Items;
					if (count == 0)
					{
						for (int j = 0; j < num2; j++)
						{
							int num5 = count + j;
							int num6 = j << 1;
							float num7 = array[num6];
							float num8 = array[num6 + 1];
							items2[num5].x = num7;
							items2[num5].y = num8;
							items2[num5].z = z;
							items3[num5].x = array2[num6];
							items3[num5].y = array2[num6 + 1];
							items4[num5] = color;
							if (num7 < vector.x)
							{
								vector.x = num7;
							}
							if (num7 > vector2.x)
							{
								vector2.x = num7;
							}
							if (num8 < vector.y)
							{
								vector.y = num8;
							}
							if (num8 > vector2.y)
							{
								vector2.y = num8;
							}
						}
					}
					else
					{
						for (int k = 0; k < num2; k++)
						{
							int num9 = count + k;
							int num10 = k << 1;
							float num11 = array[num10];
							float num12 = array[num10 + 1];
							items2[num9].x = num11;
							items2[num9].y = num12;
							items2[num9].z = z;
							items3[num9].x = array2[num10];
							items3[num9].y = array2[num10 + 1];
							items4[num9] = color;
							if (num11 < vector.x)
							{
								vector.x = num11;
							}
							else if (num11 > vector2.x)
							{
								vector2.x = num11;
							}
							if (num12 < vector.y)
							{
								vector.y = num12;
							}
							else if (num12 > vector2.y)
							{
								vector2.y = num12;
							}
						}
					}
					if (BEIMPIFBJEC)
					{
						int count2 = exposedList.Count;
						int num13 = count2 + num3;
						if (num13 > exposedList.Items.Length)
						{
							Array.Resize(ref exposedList.Items, num13);
						}
						exposedList.Count = num13;
						int[] items5 = exposedList.Items;
						for (int l = 0; l < num3; l++)
						{
							items5[count2 + l] = array3[l] + count;
						}
					}
				}
				clipper.LEOBDLEECHN(lBBAMMPJKDA2);
			}
			clipper.LEOBDLEECHN();
			meshBoundsMin = vector;
			meshBoundsMax = vector2;
			meshBoundsThickness = (float)DOFGHNBCBCA.BGKHIDKDGAC * zSpacing;
			int[] items6 = exposedList.Items;
			int m = exposedList.Count;
			for (int num14 = items6.Length; m < num14; m++)
			{
				items6[m] = 0;
			}
			submeshIndex++;
		}

		public void AMKBHKLOLMH(OOBEMJJCEGO DOFGHNBCBCA, bool BEIMPIFBJEC)
		{
			OFMBOEDKGMI[] items = DOFGHNBCBCA.DJBCCKODCLK.Items;
			int i = 0;
			for (int count = DOFGHNBCBCA.DJBCCKODCLK.Count; i < count; i++)
			{
				IIEGHMLKOON(items[i], BEIMPIFBJEC);
			}
		}

		public void PBMPDFLANCG(OOBEMJJCEGO DOFGHNBCBCA, bool BEIMPIFBJEC)
		{
			Settings settings = this.settings;
			int kCDEGJNOLPL = DOFGHNBCBCA.KCDEGJNOLPL;
			if (kCDEGJNOLPL > vertexBuffer.Items.Length)
			{
				Array.Resize(ref vertexBuffer.Items, kCDEGJNOLPL);
				Array.Resize(ref uvBuffer.Items, kCDEGJNOLPL);
				Array.Resize(ref colorBuffer.Items, kCDEGJNOLPL);
			}
			vertexBuffer.Count = (uvBuffer.Count = (colorBuffer.Count = kCDEGJNOLPL));
			Color32 color = default(Color32);
			int num = 0;
			float[] array = tempVerts;
			Vector3 vector = meshBoundsMin;
			Vector3 vector2 = meshBoundsMax;
			Vector3[] items = vertexBuffer.Items;
			Vector2[] items2 = uvBuffer.Items;
			Color32[] items3 = colorBuffer.Items;
			int num2 = 0;
			int i = 0;
			Vector2 vector3 = default(Vector2);
			Vector2 vector4 = default(Vector2);
			for (int count = DOFGHNBCBCA.DJBCCKODCLK.Count; i < count; i++)
			{
				OFMBOEDKGMI oFMBOEDKGMI = DOFGHNBCBCA.DJBCCKODCLK.Items[i];
				GCJKICAPOFL gDNININLMFD = oFMBOEDKGMI.GDNININLMFD;
				LBBAMMPJKDA[] items4 = gDNININLMFD.COACJAFIPEI.Items;
				float num3 = gDNININLMFD.MNIMEAMHNMI * 255f;
				float gPGDCCMECGF = gDNININLMFD.GPGDCCMECGF;
				float hJMBDGKAOBP = gDNININLMFD.HJMBDGKAOBP;
				float bCIHLCMFAEK = gDNININLMFD.BCIHLCMFAEK;
				int bGKHIDKDGAC = oFMBOEDKGMI.BGKHIDKDGAC;
				int iNMKEHEAHNO = oFMBOEDKGMI.INMKEHEAHNO;
				num2 = bGKHIDKDGAC;
				if (settings.tintBlack)
				{
					int num4 = num;
					vector3.y = 1f;
					if (uv2 == null)
					{
						uv2 = new ExposedList<Vector2>();
						uv3 = new ExposedList<Vector2>();
					}
					if (kCDEGJNOLPL > uv2.Items.Length)
					{
						Array.Resize(ref uv2.Items, kCDEGJNOLPL);
						Array.Resize(ref uv3.Items, kCDEGJNOLPL);
					}
					uv2.Count = (uv3.Count = kCDEGJNOLPL);
					Vector2[] items5 = uv2.Items;
					Vector2[] items6 = uv3.Items;
					for (int j = iNMKEHEAHNO; j < bGKHIDKDGAC; j++)
					{
						LBBAMMPJKDA lBBAMMPJKDA = items4[j];
						OAMNGFLKEFI dFHHMKMLCFF = lBBAMMPJKDA.DFHHMKMLCFF;
						vector4.x = lBBAMMPJKDA.FHPFAEDHEGG;
						vector4.y = lBBAMMPJKDA.AONHFIBNFLD;
						vector3.x = lBBAMMPJKDA.DLGDBCBCIED;
						MKEALIMJCFJ mKEALIMJCFJ = dFHHMKMLCFF as MKEALIMJCFJ;
						if (mKEALIMJCFJ != null)
						{
							items5[num4] = vector4;
							items5[num4 + 1] = vector4;
							items5[num4 + 2] = vector4;
							items5[num4 + 3] = vector4;
							items6[num4] = vector3;
							items6[num4 + 1] = vector3;
							items6[num4 + 2] = vector3;
							items6[num4 + 3] = vector3;
							num4 += 4;
							continue;
						}
						MGCLDKAFCIB mGCLDKAFCIB = dFHHMKMLCFF as MGCLDKAFCIB;
						if (mGCLDKAFCIB != null)
						{
							int mCCBDCEJDBC = mGCLDKAFCIB.MCCBDCEJDBC;
							for (int k = 0; k < mCCBDCEJDBC; k += 2)
							{
								items5[num4] = vector4;
								items6[num4] = vector3;
								num4++;
							}
						}
					}
				}
				for (int l = iNMKEHEAHNO; l < bGKHIDKDGAC; l++)
				{
					LBBAMMPJKDA lBBAMMPJKDA2 = items4[l];
					OAMNGFLKEFI dFHHMKMLCFF2 = lBBAMMPJKDA2.DFHHMKMLCFF;
					float z = (float)l * settings.zSpacing;
					MKEALIMJCFJ mKEALIMJCFJ2 = dFHHMKMLCFF2 as MKEALIMJCFJ;
					if (mKEALIMJCFJ2 != null)
					{
						mKEALIMJCFJ2.EPLAHNOCDIB(lBBAMMPJKDA2.JEBEPBEGCCF, array, 0);
						float num5 = array[0];
						float num6 = array[1];
						float num7 = array[2];
						float num8 = array[3];
						float num9 = array[4];
						float num10 = array[5];
						float num11 = array[6];
						float num12 = array[7];
						items[num].x = num5;
						items[num].y = num6;
						items[num].z = z;
						items[num + 1].x = num11;
						items[num + 1].y = num12;
						items[num + 1].z = z;
						items[num + 2].x = num7;
						items[num + 2].y = num8;
						items[num + 2].z = z;
						items[num + 3].x = num9;
						items[num + 3].y = num10;
						items[num + 3].z = z;
						if (settings.pmaVertexColors)
						{
							color.a = (byte)(num3 * lBBAMMPJKDA2.MNIMEAMHNMI * mKEALIMJCFJ2.MNIMEAMHNMI);
							color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * mKEALIMJCFJ2.GPGDCCMECGF * (float)(int)color.a);
							color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * mKEALIMJCFJ2.HJMBDGKAOBP * (float)(int)color.a);
							color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * mKEALIMJCFJ2.BCIHLCMFAEK * (float)(int)color.a);
							if (lBBAMMPJKDA2.MBBPBGHKLJM.DNLHLBINHHE == AOOPCGDMICP.Additive)
							{
								color.a = 0;
							}
						}
						else
						{
							color.a = (byte)(num3 * lBBAMMPJKDA2.MNIMEAMHNMI * mKEALIMJCFJ2.MNIMEAMHNMI);
							color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * mKEALIMJCFJ2.GPGDCCMECGF * 255f);
							color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * mKEALIMJCFJ2.HJMBDGKAOBP * 255f);
							color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * mKEALIMJCFJ2.BCIHLCMFAEK * 255f);
						}
						items3[num] = color;
						items3[num + 1] = color;
						items3[num + 2] = color;
						items3[num + 3] = color;
						float[] nDIFGLEBDLE = mKEALIMJCFJ2.NDIFGLEBDLE;
						items2[num].x = nDIFGLEBDLE[0];
						items2[num].y = nDIFGLEBDLE[1];
						items2[num + 1].x = nDIFGLEBDLE[6];
						items2[num + 1].y = nDIFGLEBDLE[7];
						items2[num + 2].x = nDIFGLEBDLE[2];
						items2[num + 2].y = nDIFGLEBDLE[3];
						items2[num + 3].x = nDIFGLEBDLE[4];
						items2[num + 3].y = nDIFGLEBDLE[5];
						if (num5 < vector.x)
						{
							vector.x = num5;
						}
						if (num5 > vector2.x)
						{
							vector2.x = num5;
						}
						if (num7 < vector.x)
						{
							vector.x = num7;
						}
						else if (num7 > vector2.x)
						{
							vector2.x = num7;
						}
						if (num9 < vector.x)
						{
							vector.x = num9;
						}
						else if (num9 > vector2.x)
						{
							vector2.x = num9;
						}
						if (num11 < vector.x)
						{
							vector.x = num11;
						}
						else if (num11 > vector2.x)
						{
							vector2.x = num11;
						}
						if (num6 < vector.y)
						{
							vector.y = num6;
						}
						if (num6 > vector2.y)
						{
							vector2.y = num6;
						}
						if (num8 < vector.y)
						{
							vector.y = num8;
						}
						else if (num8 > vector2.y)
						{
							vector2.y = num8;
						}
						if (num10 < vector.y)
						{
							vector.y = num10;
						}
						else if (num10 > vector2.y)
						{
							vector2.y = num10;
						}
						if (num12 < vector.y)
						{
							vector.y = num12;
						}
						else if (num12 > vector2.y)
						{
							vector2.y = num12;
						}
						num += 4;
						continue;
					}
					MGCLDKAFCIB mGCLDKAFCIB2 = dFHHMKMLCFF2 as MGCLDKAFCIB;
					if (mGCLDKAFCIB2 == null)
					{
						continue;
					}
					int mCCBDCEJDBC2 = mGCLDKAFCIB2.MCCBDCEJDBC;
					if (array.Length < mCCBDCEJDBC2)
					{
						array = (tempVerts = new float[mCCBDCEJDBC2]);
					}
					mGCLDKAFCIB2.EPLAHNOCDIB(lBBAMMPJKDA2, array);
					if (settings.pmaVertexColors)
					{
						color.a = (byte)(num3 * lBBAMMPJKDA2.MNIMEAMHNMI * mGCLDKAFCIB2.MNIMEAMHNMI);
						color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * mGCLDKAFCIB2.GPGDCCMECGF * (float)(int)color.a);
						color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * mGCLDKAFCIB2.HJMBDGKAOBP * (float)(int)color.a);
						color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * mGCLDKAFCIB2.BCIHLCMFAEK * (float)(int)color.a);
						if (lBBAMMPJKDA2.MBBPBGHKLJM.DNLHLBINHHE == AOOPCGDMICP.Additive)
						{
							color.a = 0;
						}
					}
					else
					{
						color.a = (byte)(num3 * lBBAMMPJKDA2.MNIMEAMHNMI * mGCLDKAFCIB2.MNIMEAMHNMI);
						color.r = (byte)(gPGDCCMECGF * lBBAMMPJKDA2.GPGDCCMECGF * mGCLDKAFCIB2.GPGDCCMECGF * 255f);
						color.g = (byte)(hJMBDGKAOBP * lBBAMMPJKDA2.HJMBDGKAOBP * mGCLDKAFCIB2.HJMBDGKAOBP * 255f);
						color.b = (byte)(bCIHLCMFAEK * lBBAMMPJKDA2.BCIHLCMFAEK * mGCLDKAFCIB2.BCIHLCMFAEK * 255f);
					}
					float[] nDIFGLEBDLE2 = mGCLDKAFCIB2.NDIFGLEBDLE;
					if (num == 0)
					{
						float num13 = array[0];
						float num14 = array[1];
						if (num13 < vector.x)
						{
							vector.x = num13;
						}
						if (num13 > vector2.x)
						{
							vector2.x = num13;
						}
						if (num14 < vector.y)
						{
							vector.y = num14;
						}
						if (num14 > vector2.y)
						{
							vector2.y = num14;
						}
					}
					for (int m = 0; m < mCCBDCEJDBC2; m += 2)
					{
						float num15 = array[m];
						float num16 = array[m + 1];
						items[num].x = num15;
						items[num].y = num16;
						items[num].z = z;
						items3[num] = color;
						items2[num].x = nDIFGLEBDLE2[m];
						items2[num].y = nDIFGLEBDLE2[m + 1];
						if (num15 < vector.x)
						{
							vector.x = num15;
						}
						else if (num15 > vector2.x)
						{
							vector2.x = num15;
						}
						if (num16 < vector.y)
						{
							vector.y = num16;
						}
						else if (num16 > vector2.y)
						{
							vector2.y = num16;
						}
						num++;
					}
				}
			}
			meshBoundsMin = vector;
			meshBoundsMax = vector2;
			meshBoundsThickness = (float)num2 * settings.zSpacing;
			if (!BEIMPIFBJEC)
			{
				return;
			}
			int count2 = DOFGHNBCBCA.DJBCCKODCLK.Count;
			if (submeshes.Count < count2)
			{
				submeshes.NKMKBLFBOFC(count2);
				int n = 0;
				for (int num17 = count2; n < num17; n++)
				{
					ExposedList<int> exposedList = submeshes.Items[n];
					if (exposedList == null)
					{
						submeshes.Items[n] = new ExposedList<int>();
					}
					else
					{
						exposedList.BOPEPLONIFL(false);
					}
				}
			}
			OFMBOEDKGMI[] items7 = DOFGHNBCBCA.DJBCCKODCLK.Items;
			int num18 = 0;
			for (int num19 = 0; num19 < count2; num19++)
			{
				OFMBOEDKGMI oFMBOEDKGMI2 = items7[num19];
				ExposedList<int> exposedList2 = submeshes.Items[num19];
				int gHOLJENMENP = oFMBOEDKGMI2.GHOLJENMENP;
				if (gHOLJENMENP > exposedList2.Items.Length)
				{
					Array.Resize(ref exposedList2.Items, gHOLJENMENP);
				}
				else if (gHOLJENMENP < exposedList2.Items.Length)
				{
					int[] items8 = exposedList2.Items;
					int num20 = gHOLJENMENP;
					for (int num21 = items8.Length; num20 < num21; num20++)
					{
						items8[num20] = 0;
					}
				}
				exposedList2.Count = gHOLJENMENP;
				int[] items9 = exposedList2.Items;
				int num22 = 0;
				GCJKICAPOFL gDNININLMFD2 = oFMBOEDKGMI2.GDNININLMFD;
				LBBAMMPJKDA[] items10 = gDNININLMFD2.COACJAFIPEI.Items;
				int num23 = oFMBOEDKGMI2.INMKEHEAHNO;
				for (int bGKHIDKDGAC2 = oFMBOEDKGMI2.BGKHIDKDGAC; num23 < bGKHIDKDGAC2; num23++)
				{
					OAMNGFLKEFI dFHHMKMLCFF3 = items10[num23].DFHHMKMLCFF;
					if (dFHHMKMLCFF3 is MKEALIMJCFJ)
					{
						items9[num22] = num18;
						items9[num22 + 1] = num18 + 2;
						items9[num22 + 2] = num18 + 1;
						items9[num22 + 3] = num18 + 2;
						items9[num22 + 4] = num18 + 3;
						items9[num22 + 5] = num18 + 1;
						num22 += 6;
						num18 += 4;
						continue;
					}
					MGCLDKAFCIB mGCLDKAFCIB3 = dFHHMKMLCFF3 as MGCLDKAFCIB;
					if (mGCLDKAFCIB3 != null)
					{
						int[] nPDGLMEOKIO = mGCLDKAFCIB3.NPDGLMEOKIO;
						int num24 = 0;
						int num25 = nPDGLMEOKIO.Length;
						while (num24 < num25)
						{
							items9[num22] = num18 + nPDGLMEOKIO[num24];
							num24++;
							num22++;
						}
						num18 += mGCLDKAFCIB3.MCCBDCEJDBC >> 1;
					}
				}
			}
		}

		public void JKJBGDOOLKA(float HJLOCAEAFMJ)
		{
			Vector3[] items = vertexBuffer.Items;
			int i = 0;
			for (int count = vertexBuffer.Count; i < count; i++)
			{
				items[i] *= HJLOCAEAFMJ;
			}
			meshBoundsMin *= HJLOCAEAFMJ;
			meshBoundsMax *= HJLOCAEAFMJ;
			meshBoundsThickness *= HJLOCAEAFMJ;
		}

		private void GHBMNGLAMHE(float FHPFAEDHEGG, float AONHFIBNFLD, float DLGDBCBCIED, int BKJOIFFAGKE)
		{
			Vector2 vector = new Vector2(FHPFAEDHEGG, AONHFIBNFLD);
			Vector2 vector2 = new Vector2(DLGDBCBCIED, 1f);
			int count = vertexBuffer.Count;
			int num = count + BKJOIFFAGKE;
			if (uv2 == null)
			{
				uv2 = new ExposedList<Vector2>();
				uv3 = new ExposedList<Vector2>();
			}
			if (num > uv2.Items.Length)
			{
				Array.Resize(ref uv2.Items, num);
				Array.Resize(ref uv3.Items, num);
			}
			uv2.Count = (uv3.Count = num);
			Vector2[] items = uv2.Items;
			Vector2[] items2 = uv3.Items;
			for (int i = 0; i < BKJOIFFAGKE; i++)
			{
				items[count + i] = vector;
				items2[count + i] = vector2;
			}
		}

		public void NKMGNENMGDJ(Mesh IJKCGGPJDIG)
		{
			Vector3[] items = vertexBuffer.Items;
			Vector2[] items2 = uvBuffer.Items;
			Color32[] items3 = colorBuffer.Items;
			ExposedList<int>[] items4 = submeshes.Items;
			int count = submeshes.Count;
			int count2 = vertexBuffer.Count;
			int num = vertexBuffer.Items.Length;
			Vector3 zero = Vector3.zero;
			for (int i = count2; i < num; i++)
			{
				items[i] = zero;
			}
			IJKCGGPJDIG.vertices = items;
			IJKCGGPJDIG.uv = items2;
			IJKCGGPJDIG.colors32 = items3;
			if (float.IsInfinity(meshBoundsMin.x))
			{
				IJKCGGPJDIG.bounds = default(Bounds);
			}
			else
			{
				Vector2 vector = (meshBoundsMax - meshBoundsMin) * 0.5f;
				IJKCGGPJDIG.bounds = new Bounds
				{
					center = meshBoundsMin + vector,
					extents = new Vector3(vector.x, vector.y, meshBoundsThickness * 0.5f)
				};
			}
			int count3 = vertexBuffer.Count;
			if (settings.addNormals)
			{
				int num2 = 0;
				if (normals == null)
				{
					normals = new Vector3[count3];
				}
				else
				{
					num2 = normals.Length;
				}
				if (num2 < count3)
				{
					Array.Resize(ref normals, count3);
					Vector3[] array = normals;
					for (int j = num2; j < count3; j++)
					{
						array[j] = Vector3.back;
					}
				}
				IJKCGGPJDIG.normals = normals;
			}
			if (settings.tintBlack)
			{
				IJKCGGPJDIG.uv2 = uv2.Items;
				IJKCGGPJDIG.uv3 = uv3.Items;
			}
			if (settings.calculateTangents)
			{
				NPPOFOBEDMN(ref tangents, ref tempTanBuffer, count3);
				for (int k = 0; k < count; k++)
				{
					int[] items5 = items4[k].Items;
					int count4 = items4[k].Count;
					HIDJINKLMAB(tempTanBuffer, items5, count4, items, items2, count3);
				}
				GCNOILPAHNF(tangents, tempTanBuffer, count3);
				IJKCGGPJDIG.tangents = tangents;
			}
		}

		public void LGJAHPNKGIO(Mesh IJKCGGPJDIG)
		{
			int count = submeshes.Count;
			ExposedList<int>[] items = submeshes.Items;
			IJKCGGPJDIG.subMeshCount = count;
			for (int i = 0; i < count; i++)
			{
				IJKCGGPJDIG.SetTriangles(items[i].Items, i, false);
			}
		}

		public void DOPHHKAJJEJ(Mesh IJKCGGPJDIG)
		{
			IJKCGGPJDIG.SetTriangles(submeshes.Items[0].Items, 0, false);
		}

		public void PBHLDFFHPND()
		{
			vertexBuffer.PBHLDFFHPND();
			uvBuffer.PBHLDFFHPND();
			colorBuffer.PBHLDFFHPND();
			if (uv2 != null)
			{
				uv2.PBHLDFFHPND();
			}
			if (uv3 != null)
			{
				uv3.PBHLDFFHPND();
			}
			int count = vertexBuffer.Count;
			if (normals != null)
			{
				Array.Resize(ref normals, count);
			}
			if (tangents != null)
			{
				Array.Resize(ref tangents, count);
			}
		}

		internal static void NPPOFOBEDMN(ref Vector4[] OCEMMDNCNAF, ref Vector2[] FBFOGFHHKHM, int BKJOIFFAGKE)
		{
			if (OCEMMDNCNAF == null || OCEMMDNCNAF.Length < BKJOIFFAGKE)
			{
				OCEMMDNCNAF = new Vector4[BKJOIFFAGKE];
			}
			if (FBFOGFHHKHM == null || FBFOGFHHKHM.Length < BKJOIFFAGKE * 2)
			{
				FBFOGFHHKHM = new Vector2[BKJOIFFAGKE * 2];
			}
		}

		internal static void HIDJINKLMAB(Vector2[] FBFOGFHHKHM, int[] NPDGLMEOKIO, int DJGFEJBGLPC, Vector3[] FHBFCAEGPOH, Vector2[] NDIFGLEBDLE, int BKJOIFFAGKE)
		{
			Vector2 vector7 = default(Vector2);
			Vector2 vector8 = default(Vector2);
			for (int i = 0; i < DJGFEJBGLPC; i += 3)
			{
				int num = NPDGLMEOKIO[i];
				int num2 = NPDGLMEOKIO[i + 1];
				int num3 = NPDGLMEOKIO[i + 2];
				Vector3 vector = FHBFCAEGPOH[num];
				Vector3 vector2 = FHBFCAEGPOH[num2];
				Vector3 vector3 = FHBFCAEGPOH[num3];
				Vector2 vector4 = NDIFGLEBDLE[num];
				Vector2 vector5 = NDIFGLEBDLE[num2];
				Vector2 vector6 = NDIFGLEBDLE[num3];
				float num4 = vector2.x - vector.x;
				float num5 = vector3.x - vector.x;
				float num6 = vector2.y - vector.y;
				float num7 = vector3.y - vector.y;
				float num8 = vector5.x - vector4.x;
				float num9 = vector6.x - vector4.x;
				float num10 = vector5.y - vector4.y;
				float num11 = vector6.y - vector4.y;
				float num12 = num8 * num11 - num9 * num10;
				float num13 = ((num12 != 0f) ? (1f / num12) : 0f);
				vector7.x = (num11 * num4 - num10 * num5) * num13;
				vector7.y = (num11 * num6 - num10 * num7) * num13;
				FBFOGFHHKHM[num] = (FBFOGFHHKHM[num2] = (FBFOGFHHKHM[num3] = vector7));
				vector8.x = (num8 * num5 - num9 * num4) * num13;
				vector8.y = (num8 * num7 - num9 * num6) * num13;
				FBFOGFHHKHM[BKJOIFFAGKE + num] = (FBFOGFHHKHM[BKJOIFFAGKE + num2] = (FBFOGFHHKHM[BKJOIFFAGKE + num3] = vector8));
			}
		}

		internal static void GCNOILPAHNF(Vector4[] ADGCBACGHGI, Vector2[] FBFOGFHHKHM, int BKJOIFFAGKE)
		{
			Vector4 vector = default(Vector4);
			vector.z = 0f;
			for (int i = 0; i < BKJOIFFAGKE; i++)
			{
				Vector2 vector2 = FBFOGFHHKHM[i];
				float num = Mathf.Sqrt(vector2.x * vector2.x + vector2.y * vector2.y);
				if ((double)num > 1E-05)
				{
					float num2 = 1f / num;
					vector2.x *= num2;
					vector2.y *= num2;
				}
				Vector2 vector3 = FBFOGFHHKHM[BKJOIFFAGKE + i];
				vector.x = vector2.x;
				vector.y = vector2.y;
				vector.w = ((vector2.y * vector3.x > vector2.x * vector3.y) ? 1 : (-1));
				ADGCBACGHGI[i] = vector;
			}
		}
	}
}
