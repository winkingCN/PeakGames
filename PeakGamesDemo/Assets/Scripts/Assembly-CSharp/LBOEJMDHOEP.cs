using TMPro;
using UnityEngine;

public static class LBOEJMDHOEP
{
	private struct HBNJPECCHEL
	{
		public Vector3 BNKOCJLLBNL;

		public Vector3 BCFKOIDCNKJ;

		public HBNJPECCHEL(Vector3 BEGCLEDLFOO, Vector3 LGKCEADGHNL)
		{
			BNKOCJLLBNL = BEGCLEDLFOO;
			BCFKOIDCNKJ = LGKCEADGHNL;
		}
	}

	private static Vector3[] MKHBOOLIPHN = new Vector3[4];

	private const string NIEDDJLOAJL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

	private const string KGKPNCGKALE = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	public static int IJCGMADBIPC(TMP_Text MHFABDJOCMG, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		int num = GJLKMCEDBAJ(MHFABDJOCMG, LDMDBPLADGD, LFCBBKIFIJA, false);
		RectTransform rectTransform = MHFABDJOCMG.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		MGLLLPMKGDA mGLLLPMKGDA = MHFABDJOCMG.BIAHJAKEMLM.characterInfo[num];
		Vector3 vector = rectTransform.TransformPoint(mGLLLPMKGDA.GKDEKLOCKNA);
		Vector3 vector2 = rectTransform.TransformPoint(mGLLLPMKGDA.BJONICNNGLI);
		float num2 = (LDMDBPLADGD.x - vector.x) / (vector2.x - vector.x);
		if (num2 < 0.5f)
		{
			return num;
		}
		return num + 1;
	}

	public static int IJCGMADBIPC(TMP_Text MHFABDJOCMG, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA, out FKJCPPFCKFE AELKOEGPIKN)
	{
		int num = CPKKHBNPHHD(MHFABDJOCMG, LDMDBPLADGD, LFCBBKIFIJA);
		int num2 = JGIJLCLPDHF(MHFABDJOCMG, LDMDBPLADGD, num, LFCBBKIFIJA, false);
		if (MHFABDJOCMG.BIAHJAKEMLM.lineInfo[num].NGNCDLJAEFL == 1)
		{
			AELKOEGPIKN = FKJCPPFCKFE.Left;
			return num2;
		}
		RectTransform rectTransform = MHFABDJOCMG.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		MGLLLPMKGDA mGLLLPMKGDA = MHFABDJOCMG.BIAHJAKEMLM.characterInfo[num2];
		Vector3 vector = rectTransform.TransformPoint(mGLLLPMKGDA.GKDEKLOCKNA);
		Vector3 vector2 = rectTransform.TransformPoint(mGLLLPMKGDA.BJONICNNGLI);
		float num3 = (LDMDBPLADGD.x - vector.x) / (vector2.x - vector.x);
		if (num3 < 0.5f)
		{
			AELKOEGPIKN = FKJCPPFCKFE.Left;
			return num2;
		}
		AELKOEGPIKN = FKJCPPFCKFE.Right;
		return num2;
	}

	public static int CPKKHBNPHHD(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		float num = float.PositiveInfinity;
		int result = -1;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.lineCount; i++)
		{
			CFLMKMOJIJI cFLMKMOJIJI = FCJBBPHFNPJ.BIAHJAKEMLM.lineInfo[i];
			float y = rectTransform.TransformPoint(new Vector3(0f, cFLMKMOJIJI.MNKFKKODLLM, 0f)).y;
			float y2 = rectTransform.TransformPoint(new Vector3(0f, cFLMKMOJIJI.CALDBEMMLEA, 0f)).y;
			if (y > LDMDBPLADGD.y && y2 < LDMDBPLADGD.y)
			{
				return i;
			}
			float a = Mathf.Abs(y - LDMDBPLADGD.y);
			float b = Mathf.Abs(y2 - LDMDBPLADGD.y);
			float num2 = Mathf.Min(a, b);
			if (num2 < num)
			{
				num = num2;
				result = i;
			}
		}
		return result;
	}

	public static int JGIJLCLPDHF(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, int BBIEJBIHPLE, Camera LFCBBKIFIJA, bool EIOIMIPBDFF)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		int iAJJNNOAMLG = FCJBBPHFNPJ.BIAHJAKEMLM.lineInfo[BBIEJBIHPLE].IAJJNNOAMLG;
		int fNOFPOMADEM = FCJBBPHFNPJ.BIAHJAKEMLM.lineInfo[BBIEJBIHPLE].FNOFPOMADEM;
		float num = float.PositiveInfinity;
		int result = fNOFPOMADEM;
		for (int i = iAJJNNOAMLG; i < fNOFPOMADEM; i++)
		{
			MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[i];
			if (!EIOIMIPBDFF || mGLLLPMKGDA.BACHBACHNOF)
			{
				Vector3 vector = rectTransform.TransformPoint(mGLLLPMKGDA.GKDEKLOCKNA);
				Vector3 vector2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.BJONICNNGLI.y, 0f));
				Vector3 vector3 = rectTransform.TransformPoint(mGLLLPMKGDA.BJONICNNGLI);
				Vector3 vector4 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.GKDEKLOCKNA.y, 0f));
				if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, vector3, vector4))
				{
					result = i;
					break;
				}
				float num2 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
				float num3 = JMBEBNFOPJK(vector2, vector3, LDMDBPLADGD);
				float num4 = JMBEBNFOPJK(vector3, vector4, LDMDBPLADGD);
				float num5 = JMBEBNFOPJK(vector4, vector, LDMDBPLADGD);
				float num6 = ((!(num2 < num3)) ? num3 : num2);
				num6 = ((!(num6 < num4)) ? num4 : num6);
				num6 = ((!(num6 < num5)) ? num5 : num6);
				if (num > num6)
				{
					num = num6;
					result = i;
				}
			}
		}
		return result;
	}

	public static bool DGAGKPPHJFE(RectTransform GPPKOGCLKPL, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		LOCDFEMLMCB(GPPKOGCLKPL, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		GPPKOGCLKPL.GetWorldCorners(MKHBOOLIPHN);
		if (IGJFKICHOJP(LDMDBPLADGD, MKHBOOLIPHN[0], MKHBOOLIPHN[1], MKHBOOLIPHN[2], MKHBOOLIPHN[3]))
		{
			return true;
		}
		return false;
	}

	public static int DMKHELKGIAI(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA, bool EIOIMIPBDFF)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.characterCount; i++)
		{
			MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[i];
			if (!EIOIMIPBDFF || mGLLLPMKGDA.BACHBACHNOF)
			{
				Vector3 mNIMEAMHNMI = rectTransform.TransformPoint(mGLLLPMKGDA.GKDEKLOCKNA);
				Vector3 bCIHLCMFAEK = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.BJONICNNGLI.y, 0f));
				Vector3 fMFABAKPMLB = rectTransform.TransformPoint(mGLLLPMKGDA.BJONICNNGLI);
				Vector3 eLNCCDELMMH = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.GKDEKLOCKNA.y, 0f));
				if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, fMFABAKPMLB, eLNCCDELMMH))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static int GJLKMCEDBAJ(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA, bool EIOIMIPBDFF)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		float num = float.PositiveInfinity;
		int result = 0;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.characterCount; i++)
		{
			MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[i];
			if (!EIOIMIPBDFF || mGLLLPMKGDA.BACHBACHNOF)
			{
				Vector3 vector = rectTransform.TransformPoint(mGLLLPMKGDA.GKDEKLOCKNA);
				Vector3 vector2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.BJONICNNGLI.y, 0f));
				Vector3 vector3 = rectTransform.TransformPoint(mGLLLPMKGDA.BJONICNNGLI);
				Vector3 vector4 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.GKDEKLOCKNA.y, 0f));
				if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, vector3, vector4))
				{
					return i;
				}
				float num2 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
				float num3 = JMBEBNFOPJK(vector2, vector3, LDMDBPLADGD);
				float num4 = JMBEBNFOPJK(vector3, vector4, LDMDBPLADGD);
				float num5 = JMBEBNFOPJK(vector4, vector, LDMDBPLADGD);
				float num6 = ((!(num2 < num3)) ? num3 : num2);
				num6 = ((!(num6 < num4)) ? num4 : num6);
				num6 = ((!(num6 < num5)) ? num5 : num6);
				if (num > num6)
				{
					num = num6;
					result = i;
				}
			}
		}
		return result;
	}

	public static int PLBPMPBDMPH(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.wordCount; i++)
		{
			GLDAENBEFBI gLDAENBEFBI = FCJBBPHFNPJ.BIAHJAKEMLM.wordInfo[i];
			bool flag = false;
			Vector3 mNIMEAMHNMI = Vector3.zero;
			Vector3 bCIHLCMFAEK = Vector3.zero;
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			float num = float.NegativeInfinity;
			float num2 = float.PositiveInfinity;
			for (int j = 0; j < gLDAENBEFBI.NGNCDLJAEFL; j++)
			{
				int num3 = gLDAENBEFBI.IAJJNNOAMLG + j;
				MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num3];
				int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
				bool bACHBACHNOF = mGLLLPMKGDA.BACHBACHNOF;
				num = Mathf.Max(num, mGLLLPMKGDA.MNKFKKODLLM);
				num2 = Mathf.Min(num2, mGLLLPMKGDA.CALDBEMMLEA);
				if (!flag && bACHBACHNOF)
				{
					flag = true;
					mNIMEAMHNMI = new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.CALDBEMMLEA, 0f);
					bCIHLCMFAEK = new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.MNKFKKODLLM, 0f);
					if (gLDAENBEFBI.NGNCDLJAEFL == 1)
					{
						flag = false;
						zero = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f);
						zero2 = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f);
						mNIMEAMHNMI = rectTransform.TransformPoint(new Vector3(mNIMEAMHNMI.x, num2, 0f));
						bCIHLCMFAEK = rectTransform.TransformPoint(new Vector3(bCIHLCMFAEK.x, num, 0f));
						zero2 = rectTransform.TransformPoint(new Vector3(zero2.x, num, 0f));
						zero = rectTransform.TransformPoint(new Vector3(zero.x, num2, 0f));
						if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
						{
							return i;
						}
					}
				}
				if (flag && j == gLDAENBEFBI.NGNCDLJAEFL - 1)
				{
					flag = false;
					zero = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f);
					zero2 = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f);
					mNIMEAMHNMI = rectTransform.TransformPoint(new Vector3(mNIMEAMHNMI.x, num2, 0f));
					bCIHLCMFAEK = rectTransform.TransformPoint(new Vector3(bCIHLCMFAEK.x, num, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(zero2.x, num, 0f));
					zero = rectTransform.TransformPoint(new Vector3(zero.x, num2, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
					{
						return i;
					}
				}
				else if (flag && hGCMIDFMKHD != FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num3 + 1].HGCMIDFMKHD)
				{
					flag = false;
					zero = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f);
					zero2 = new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f);
					mNIMEAMHNMI = rectTransform.TransformPoint(new Vector3(mNIMEAMHNMI.x, num2, 0f));
					bCIHLCMFAEK = rectTransform.TransformPoint(new Vector3(bCIHLCMFAEK.x, num, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(zero2.x, num, 0f));
					zero = rectTransform.TransformPoint(new Vector3(zero.x, num2, 0f));
					num = float.NegativeInfinity;
					num2 = float.PositiveInfinity;
					if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
					{
						return i;
					}
				}
			}
		}
		return -1;
	}

	public static int APHPNAAEAOF(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		float num = float.PositiveInfinity;
		int result = 0;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.wordCount; i++)
		{
			GLDAENBEFBI gLDAENBEFBI = FCJBBPHFNPJ.BIAHJAKEMLM.wordInfo[i];
			bool flag = false;
			Vector3 vector = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			for (int j = 0; j < gLDAENBEFBI.NGNCDLJAEFL; j++)
			{
				int num2 = gLDAENBEFBI.IAJJNNOAMLG + j;
				MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num2];
				int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
				bool bACHBACHNOF = mGLLLPMKGDA.BACHBACHNOF;
				if (!flag && bACHBACHNOF)
				{
					flag = true;
					vector = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					vector2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (gLDAENBEFBI.NGNCDLJAEFL == 1)
					{
						flag = false;
						zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
						zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
						if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
						{
							return i;
						}
						float num3 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
						float num4 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
						float num5 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
						float num6 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
						float num7 = ((!(num3 < num4)) ? num4 : num3);
						num7 = ((!(num7 < num5)) ? num5 : num7);
						num7 = ((!(num7 < num6)) ? num6 : num7);
						if (num > num7)
						{
							num = num7;
							result = i;
						}
					}
				}
				if (flag && j == gLDAENBEFBI.NGNCDLJAEFL - 1)
				{
					flag = false;
					zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
					{
						return i;
					}
					float num8 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
					float num9 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
					float num10 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
					float num11 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
					float num12 = ((!(num8 < num9)) ? num9 : num8);
					num12 = ((!(num12 < num10)) ? num10 : num12);
					num12 = ((!(num12 < num11)) ? num11 : num12);
					if (num > num12)
					{
						num = num12;
						result = i;
					}
				}
				else if (flag && hGCMIDFMKHD != FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num2 + 1].HGCMIDFMKHD)
				{
					flag = false;
					zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
					{
						return i;
					}
					float num13 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
					float num14 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
					float num15 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
					float num16 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
					float num17 = ((!(num13 < num14)) ? num14 : num13);
					num17 = ((!(num17 < num15)) ? num15 : num17);
					num17 = ((!(num17 < num16)) ? num16 : num17);
					if (num > num17)
					{
						num = num17;
						result = i;
					}
				}
			}
		}
		return result;
	}

	public static int AFAGHDOBPFD(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		int result = -1;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.lineCount; i++)
		{
			CFLMKMOJIJI cFLMKMOJIJI = FCJBBPHFNPJ.BIAHJAKEMLM.lineInfo[i];
			float y = rectTransform.TransformPoint(new Vector3(0f, cFLMKMOJIJI.MNKFKKODLLM, 0f)).y;
			float y2 = rectTransform.TransformPoint(new Vector3(0f, cFLMKMOJIJI.CALDBEMMLEA, 0f)).y;
			if (y > LDMDBPLADGD.y && y2 < LDMDBPLADGD.y)
			{
				return i;
			}
		}
		return result;
	}

	public static int DLABFAPNBGL(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		Transform transform = FCJBBPHFNPJ.ANLKLKAINEO;
		LOCDFEMLMCB(transform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.linkCount; i++)
		{
			IDPGGIAHIGC iDPGGIAHIGC = FCJBBPHFNPJ.BIAHJAKEMLM.linkInfo[i];
			bool flag = false;
			Vector3 mNIMEAMHNMI = Vector3.zero;
			Vector3 bCIHLCMFAEK = Vector3.zero;
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			for (int j = 0; j < iDPGGIAHIGC.IAJHNMEHLCA; j++)
			{
				int num = iDPGGIAHIGC.HKBLAGGHCNK + j;
				MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num];
				int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
				if (FCJBBPHFNPJ.FJBKGKBEEGI == OLMBEAODAPL.Page && mGLLLPMKGDA.LJABKMPPOML + 1 != FCJBBPHFNPJ.IEPGKBOEPKP)
				{
					continue;
				}
				if (!flag)
				{
					flag = true;
					mNIMEAMHNMI = transform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					bCIHLCMFAEK = transform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (iDPGGIAHIGC.IAJHNMEHLCA == 1)
					{
						flag = false;
						zero = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
						zero2 = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
						if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
						{
							return i;
						}
					}
				}
				if (flag && j == iDPGGIAHIGC.IAJHNMEHLCA - 1)
				{
					flag = false;
					zero = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
					{
						return i;
					}
				}
				else if (flag && hGCMIDFMKHD != FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num + 1].HGCMIDFMKHD)
				{
					flag = false;
					zero = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = transform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, mNIMEAMHNMI, bCIHLCMFAEK, zero2, zero))
					{
						return i;
					}
				}
			}
		}
		return -1;
	}

	public static int PJNPNMHODMC(TMP_Text FCJBBPHFNPJ, Vector3 LDMDBPLADGD, Camera LFCBBKIFIJA)
	{
		RectTransform rectTransform = FCJBBPHFNPJ.GPPKOGCLKPL;
		LOCDFEMLMCB(rectTransform, LDMDBPLADGD, LFCBBKIFIJA, out LDMDBPLADGD);
		float num = float.PositiveInfinity;
		int result = 0;
		for (int i = 0; i < FCJBBPHFNPJ.BIAHJAKEMLM.linkCount; i++)
		{
			IDPGGIAHIGC iDPGGIAHIGC = FCJBBPHFNPJ.BIAHJAKEMLM.linkInfo[i];
			bool flag = false;
			Vector3 vector = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			for (int j = 0; j < iDPGGIAHIGC.IAJHNMEHLCA; j++)
			{
				int num2 = iDPGGIAHIGC.HKBLAGGHCNK + j;
				MGLLLPMKGDA mGLLLPMKGDA = FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num2];
				int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
				if (FCJBBPHFNPJ.FJBKGKBEEGI == OLMBEAODAPL.Page && mGLLLPMKGDA.LJABKMPPOML + 1 != FCJBBPHFNPJ.IEPGKBOEPKP)
				{
					continue;
				}
				if (!flag)
				{
					flag = true;
					vector = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					vector2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.GKDEKLOCKNA.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (iDPGGIAHIGC.IAJHNMEHLCA == 1)
					{
						flag = false;
						zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
						zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
						if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
						{
							return i;
						}
						float num3 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
						float num4 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
						float num5 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
						float num6 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
						float num7 = ((!(num3 < num4)) ? num4 : num3);
						num7 = ((!(num7 < num5)) ? num5 : num7);
						num7 = ((!(num7 < num6)) ? num6 : num7);
						if (num > num7)
						{
							num = num7;
							result = i;
						}
					}
				}
				if (flag && j == iDPGGIAHIGC.IAJHNMEHLCA - 1)
				{
					flag = false;
					zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
					{
						return i;
					}
					float num8 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
					float num9 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
					float num10 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
					float num11 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
					float num12 = ((!(num8 < num9)) ? num9 : num8);
					num12 = ((!(num12 < num10)) ? num10 : num12);
					num12 = ((!(num12 < num11)) ? num11 : num12);
					if (num > num12)
					{
						num = num12;
						result = i;
					}
				}
				else if (flag && hGCMIDFMKHD != FCJBBPHFNPJ.BIAHJAKEMLM.characterInfo[num2 + 1].HGCMIDFMKHD)
				{
					flag = false;
					zero = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.CALDBEMMLEA, 0f));
					zero2 = rectTransform.TransformPoint(new Vector3(mGLLLPMKGDA.BJONICNNGLI.x, mGLLLPMKGDA.MNKFKKODLLM, 0f));
					if (IGJFKICHOJP(LDMDBPLADGD, vector, vector2, zero2, zero))
					{
						return i;
					}
					float num13 = JMBEBNFOPJK(vector, vector2, LDMDBPLADGD);
					float num14 = JMBEBNFOPJK(vector2, zero2, LDMDBPLADGD);
					float num15 = JMBEBNFOPJK(zero2, zero, LDMDBPLADGD);
					float num16 = JMBEBNFOPJK(zero, vector, LDMDBPLADGD);
					float num17 = ((!(num13 < num14)) ? num14 : num13);
					num17 = ((!(num17 < num15)) ? num15 : num17);
					num17 = ((!(num17 < num16)) ? num16 : num17);
					if (num > num17)
					{
						num = num17;
						result = i;
					}
				}
			}
		}
		return result;
	}

	private static bool IGJFKICHOJP(Vector3 CEKMAJAHNAG, Vector3 MNIMEAMHNMI, Vector3 BCIHLCMFAEK, Vector3 FMFABAKPMLB, Vector3 ELNCCDELMMH)
	{
		Vector3 vector = BCIHLCMFAEK - MNIMEAMHNMI;
		Vector3 rhs = CEKMAJAHNAG - MNIMEAMHNMI;
		Vector3 vector2 = FMFABAKPMLB - BCIHLCMFAEK;
		Vector3 rhs2 = CEKMAJAHNAG - BCIHLCMFAEK;
		float num = Vector3.Dot(vector, rhs);
		float num2 = Vector3.Dot(vector2, rhs2);
		return 0f <= num && num <= Vector3.Dot(vector, vector) && 0f <= num2 && num2 <= Vector3.Dot(vector2, vector2);
	}

	public static bool LOCDFEMLMCB(Transform ANLKLKAINEO, Vector2 CGGEHPNHNHA, Camera GAPLNBLGDPC, out Vector3 FHIPBCJDOMJ)
	{
		FHIPBCJDOMJ = Vector2.zero;
		Ray ray = RectTransformUtility.ScreenPointToRay(GAPLNBLGDPC, CGGEHPNHNHA);
		float enter;
		if (!new Plane(ANLKLKAINEO.rotation * Vector3.back, ANLKLKAINEO.position).Raycast(ray, out enter))
		{
			return false;
		}
		FHIPBCJDOMJ = ray.GetPoint(enter);
		return true;
	}

	private static bool BFGDFBPLHBA(HBNJPECCHEL BBIEJBIHPLE, Vector3 KJPPPBMDJKG, Vector3 CAIMCKBHGKP, out Vector3 HKDMNGGGDOC)
	{
		HKDMNGGGDOC = Vector3.zero;
		Vector3 vector = BBIEJBIHPLE.BCFKOIDCNKJ - BBIEJBIHPLE.BNKOCJLLBNL;
		Vector3 rhs = BBIEJBIHPLE.BNKOCJLLBNL - KJPPPBMDJKG;
		float num = Vector3.Dot(CAIMCKBHGKP, vector);
		float num2 = 0f - Vector3.Dot(CAIMCKBHGKP, rhs);
		if (Mathf.Abs(num) < Mathf.Epsilon)
		{
			if (num2 == 0f)
			{
				return true;
			}
			return false;
		}
		float num3 = num2 / num;
		if (num3 < 0f || num3 > 1f)
		{
			return false;
		}
		HKDMNGGGDOC = BBIEJBIHPLE.BNKOCJLLBNL + num3 * vector;
		return true;
	}

	public static float JMBEBNFOPJK(Vector3 MNIMEAMHNMI, Vector3 BCIHLCMFAEK, Vector3 KJPPPBMDJKG)
	{
		Vector3 vector = BCIHLCMFAEK - MNIMEAMHNMI;
		Vector3 vector2 = MNIMEAMHNMI - KJPPPBMDJKG;
		float num = Vector3.Dot(vector, vector2);
		if (num > 0f)
		{
			return Vector3.Dot(vector2, vector2);
		}
		Vector3 vector3 = KJPPPBMDJKG - BCIHLCMFAEK;
		if (Vector3.Dot(vector, vector3) > 0f)
		{
			return Vector3.Dot(vector3, vector3);
		}
		Vector3 vector4 = vector2 - vector * (num / Vector3.Dot(vector, vector));
		return Vector3.Dot(vector4, vector4);
	}

	public static char PHGGNMEFCEC(char FMFABAKPMLB)
	{
		if (FMFABAKPMLB > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1)
		{
			return FMFABAKPMLB;
		}
		return "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"[FMFABAKPMLB];
	}

	public static char JNAMKIOPJCE(char FMFABAKPMLB)
	{
		if (FMFABAKPMLB > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".Length - 1)
		{
			return FMFABAKPMLB;
		}
		return "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"[FMFABAKPMLB];
	}

	public static int OLDMALBCAKF(string IBBBMACIBGK)
	{
		int num = 0;
		for (int i = 0; i < IBBBMACIBGK.Length; i++)
		{
			num = ((num << 5) + num) ^ IBBBMACIBGK[i];
		}
		return num;
	}

	public static uint OCOKICANLFL(string IBBBMACIBGK)
	{
		uint num = 5381u;
		for (int i = 0; i < IBBBMACIBGK.Length; i++)
		{
			num = ((num << 5) + num) ^ PHGGNMEFCEC(IBBBMACIBGK[i]);
		}
		return num;
	}

	public static int ELOPCHGFKGE(char PEGNALIKDPB)
	{
		switch (PEGNALIKDPB)
		{
		case '0':
			return 0;
		case '1':
			return 1;
		case '2':
			return 2;
		case '3':
			return 3;
		case '4':
			return 4;
		case '5':
			return 5;
		case '6':
			return 6;
		case '7':
			return 7;
		case '8':
			return 8;
		case '9':
			return 9;
		case 'A':
			return 10;
		case 'B':
			return 11;
		case 'C':
			return 12;
		case 'D':
			return 13;
		case 'E':
			return 14;
		case 'F':
			return 15;
		case 'a':
			return 10;
		case 'b':
			return 11;
		case 'c':
			return 12;
		case 'd':
			return 13;
		case 'e':
			return 14;
		case 'f':
			return 15;
		default:
			return 15;
		}
	}

	public static int NOFLKKGLCDL(string IBBBMACIBGK)
	{
		int num = 0;
		for (int i = 0; i < IBBBMACIBGK.Length; i++)
		{
			num += ELOPCHGFKGE(IBBBMACIBGK[i]) * (int)Mathf.Pow(16f, IBBBMACIBGK.Length - 1 - i);
		}
		return num;
	}
}
