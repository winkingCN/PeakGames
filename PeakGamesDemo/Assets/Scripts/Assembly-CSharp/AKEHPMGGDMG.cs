using System;
using Spine;

internal class AKEHPMGGDMG
{
	private readonly ExposedList<ExposedList<float>> HGLLIOOCIDP = new ExposedList<ExposedList<float>>();

	private readonly ExposedList<ExposedList<int>> OPOOELCDCJP = new ExposedList<ExposedList<int>>();

	private readonly ExposedList<int> BJNAGPONKMK = new ExposedList<int>();

	private readonly ExposedList<bool> AFPDPIMNJLO = new ExposedList<bool>();

	private readonly ExposedList<int> NPDGLMEOKIO = new ExposedList<int>();

	private readonly global::ECEEFKLEDDE<ExposedList<float>> OGMKLHCFJFP = new global::ECEEFKLEDDE<ExposedList<float>>();

	private readonly global::ECEEFKLEDDE<ExposedList<int>> PMCNEAJBGNJ = new global::ECEEFKLEDDE<ExposedList<int>>();

	public ExposedList<int> EOBELIMKCOJ(ExposedList<float> KHIBLJMDONC)
	{
		float[] items = KHIBLJMDONC.Items;
		int num = KHIBLJMDONC.Count >> 1;
		ExposedList<int> bJNAGPONKMK = BJNAGPONKMK;
		bJNAGPONKMK.BOPEPLONIFL();
		int[] items2 = bJNAGPONKMK.NKMKBLFBOFC(num).Items;
		for (int i = 0; i < num; i++)
		{
			items2[i] = i;
		}
		ExposedList<bool> aFPDPIMNJLO = AFPDPIMNJLO;
		bool[] items3 = aFPDPIMNJLO.NKMKBLFBOFC(num).Items;
		int j = 0;
		for (int num2 = num; j < num2; j++)
		{
			items3[j] = NIILCPMBHNH(j, num, items, items2);
		}
		ExposedList<int> nPDGLMEOKIO = NPDGLMEOKIO;
		nPDGLMEOKIO.BOPEPLONIFL();
		nPDGLMEOKIO.FGLKIEFPAIA(Math.Max(0, num - 2) << 2);
		while (num > 3)
		{
			int num3 = num - 1;
			int num4 = 0;
			int num5 = 1;
			while (true)
			{
				if (!items3[num4])
				{
					int num6 = items2[num3] << 1;
					int num7 = items2[num4] << 1;
					int num8 = items2[num5] << 1;
					float num9 = items[num6];
					float num10 = items[num6 + 1];
					float num11 = items[num7];
					float num12 = items[num7 + 1];
					float num13 = items[num8];
					float num14 = items[num8 + 1];
					for (int num15 = (num5 + 1) % num; num15 != num3; num15 = (num15 + 1) % num)
					{
						if (!items3[num15])
						{
							continue;
						}
						int num16 = items2[num15] << 1;
						float nOOFJDCJLDM = items[num16];
						float gJLFGKBFJID = items[num16 + 1];
						if (!FGPIONNMPIP(num13, num14, num9, num10, nOOFJDCJLDM, gJLFGKBFJID) || !FGPIONNMPIP(num9, num10, num11, num12, nOOFJDCJLDM, gJLFGKBFJID) || !FGPIONNMPIP(num11, num12, num13, num14, nOOFJDCJLDM, gJLFGKBFJID))
						{
							continue;
						}
						goto IL_0194;
					}
					break;
				}
				goto IL_0194;
				IL_0194:
				if (num5 == 0)
				{
					while (items3[num4])
					{
						num4--;
						if (num4 <= 0)
						{
							break;
						}
					}
					break;
				}
				num3 = num4;
				num4 = num5;
				num5 = (num5 + 1) % num;
			}
			nPDGLMEOKIO.JEACJNAKLDJ(items2[(num + num4 - 1) % num]);
			nPDGLMEOKIO.JEACJNAKLDJ(items2[num4]);
			nPDGLMEOKIO.JEACJNAKLDJ(items2[(num4 + 1) % num]);
			bJNAGPONKMK.LIKBJGKHDOE(num4);
			aFPDPIMNJLO.LIKBJGKHDOE(num4);
			num--;
			int num17 = (num + num4 - 1) % num;
			int num18 = ((num4 != num) ? num4 : 0);
			items3[num17] = NIILCPMBHNH(num17, num, items, items2);
			items3[num18] = NIILCPMBHNH(num18, num, items, items2);
		}
		if (num == 3)
		{
			nPDGLMEOKIO.JEACJNAKLDJ(items2[2]);
			nPDGLMEOKIO.JEACJNAKLDJ(items2[0]);
			nPDGLMEOKIO.JEACJNAKLDJ(items2[1]);
		}
		return nPDGLMEOKIO;
	}

	public ExposedList<ExposedList<float>> CPCEKCIHFCA(ExposedList<float> KHIBLJMDONC, ExposedList<int> NPDGLMEOKIO)
	{
		float[] items = KHIBLJMDONC.Items;
		ExposedList<ExposedList<float>> hGLLIOOCIDP = HGLLIOOCIDP;
		int i = 0;
		for (int count = hGLLIOOCIDP.Count; i < count; i++)
		{
			OGMKLHCFJFP.CFPHGMEPNFK(hGLLIOOCIDP.Items[i]);
		}
		hGLLIOOCIDP.BOPEPLONIFL();
		ExposedList<ExposedList<int>> oPOOELCDCJP = OPOOELCDCJP;
		int j = 0;
		for (int count2 = oPOOELCDCJP.Count; j < count2; j++)
		{
			PMCNEAJBGNJ.CFPHGMEPNFK(oPOOELCDCJP.Items[j]);
		}
		oPOOELCDCJP.BOPEPLONIFL();
		ExposedList<int> exposedList = PMCNEAJBGNJ.KJAOIPMLKPO();
		exposedList.BOPEPLONIFL();
		ExposedList<float> exposedList2 = OGMKLHCFJFP.KJAOIPMLKPO();
		exposedList2.BOPEPLONIFL();
		int num = -1;
		int num2 = 0;
		int[] items2 = NPDGLMEOKIO.Items;
		int k = 0;
		for (int count3 = NPDGLMEOKIO.Count; k < count3; k += 3)
		{
			int num3 = items2[k] << 1;
			int num4 = items2[k + 1] << 1;
			int num5 = items2[k + 2] << 1;
			float num6 = items[num3];
			float num7 = items[num3 + 1];
			float num8 = items[num4];
			float num9 = items[num4 + 1];
			float num10 = items[num5];
			float num11 = items[num5 + 1];
			bool flag = false;
			if (num == num3)
			{
				int num12 = exposedList2.Count - 4;
				float[] items3 = exposedList2.Items;
				int num13 = LJPBONIKJGO(items3[num12], items3[num12 + 1], items3[num12 + 2], items3[num12 + 3], num10, num11);
				int num14 = LJPBONIKJGO(num10, num11, items3[0], items3[1], items3[2], items3[3]);
				if (num13 == num2 && num14 == num2)
				{
					exposedList2.JEACJNAKLDJ(num10);
					exposedList2.JEACJNAKLDJ(num11);
					exposedList.JEACJNAKLDJ(num5);
					flag = true;
				}
			}
			if (!flag)
			{
				if (exposedList2.Count > 0)
				{
					hGLLIOOCIDP.JEACJNAKLDJ(exposedList2);
					oPOOELCDCJP.JEACJNAKLDJ(exposedList);
				}
				else
				{
					OGMKLHCFJFP.CFPHGMEPNFK(exposedList2);
					PMCNEAJBGNJ.CFPHGMEPNFK(exposedList);
				}
				exposedList2 = OGMKLHCFJFP.KJAOIPMLKPO();
				exposedList2.BOPEPLONIFL();
				exposedList2.JEACJNAKLDJ(num6);
				exposedList2.JEACJNAKLDJ(num7);
				exposedList2.JEACJNAKLDJ(num8);
				exposedList2.JEACJNAKLDJ(num9);
				exposedList2.JEACJNAKLDJ(num10);
				exposedList2.JEACJNAKLDJ(num11);
				exposedList = PMCNEAJBGNJ.KJAOIPMLKPO();
				exposedList.BOPEPLONIFL();
				exposedList.JEACJNAKLDJ(num3);
				exposedList.JEACJNAKLDJ(num4);
				exposedList.JEACJNAKLDJ(num5);
				num2 = LJPBONIKJGO(num6, num7, num8, num9, num10, num11);
				num = num3;
			}
		}
		if (exposedList2.Count > 0)
		{
			hGLLIOOCIDP.JEACJNAKLDJ(exposedList2);
			oPOOELCDCJP.JEACJNAKLDJ(exposedList);
		}
		int l = 0;
		for (int count4 = hGLLIOOCIDP.Count; l < count4; l++)
		{
			exposedList = oPOOELCDCJP.Items[l];
			if (exposedList.Count == 0)
			{
				continue;
			}
			int num15 = exposedList.Items[0];
			int num16 = exposedList.Items[exposedList.Count - 1];
			exposedList2 = hGLLIOOCIDP.Items[l];
			int num17 = exposedList2.Count - 4;
			float[] items4 = exposedList2.Items;
			float lOLMOCMEJCC = items4[num17];
			float fIKGPJJPGBL = items4[num17 + 1];
			float num18 = items4[num17 + 2];
			float num19 = items4[num17 + 3];
			float num20 = items4[0];
			float num21 = items4[1];
			float nOOFJDCJLDM = items4[2];
			float gJLFGKBFJID = items4[3];
			int num22 = LJPBONIKJGO(lOLMOCMEJCC, fIKGPJJPGBL, num18, num19, num20, num21);
			for (int m = 0; m < count4; m++)
			{
				if (m == l)
				{
					continue;
				}
				ExposedList<int> exposedList3 = oPOOELCDCJP.Items[m];
				if (exposedList3.Count != 3)
				{
					continue;
				}
				int num23 = exposedList3.Items[0];
				int num24 = exposedList3.Items[1];
				int eJCNAJOHBFI = exposedList3.Items[2];
				ExposedList<float> exposedList4 = hGLLIOOCIDP.Items[m];
				float num25 = exposedList4.Items[exposedList4.Count - 2];
				float num26 = exposedList4.Items[exposedList4.Count - 1];
				if (num23 == num15 && num24 == num16)
				{
					int num27 = LJPBONIKJGO(lOLMOCMEJCC, fIKGPJJPGBL, num18, num19, num25, num26);
					int num28 = LJPBONIKJGO(num25, num26, num20, num21, nOOFJDCJLDM, gJLFGKBFJID);
					if (num27 == num22 && num28 == num22)
					{
						exposedList4.BOPEPLONIFL();
						exposedList3.BOPEPLONIFL();
						exposedList2.JEACJNAKLDJ(num25);
						exposedList2.JEACJNAKLDJ(num26);
						exposedList.JEACJNAKLDJ(eJCNAJOHBFI);
						lOLMOCMEJCC = num18;
						fIKGPJJPGBL = num19;
						num18 = num25;
						num19 = num26;
						m = 0;
					}
				}
			}
		}
		for (int num29 = hGLLIOOCIDP.Count - 1; num29 >= 0; num29--)
		{
			exposedList2 = hGLLIOOCIDP.Items[num29];
			if (exposedList2.Count == 0)
			{
				hGLLIOOCIDP.LIKBJGKHDOE(num29);
				OGMKLHCFJFP.CFPHGMEPNFK(exposedList2);
				exposedList = oPOOELCDCJP.Items[num29];
				oPOOELCDCJP.LIKBJGKHDOE(num29);
				PMCNEAJBGNJ.CFPHGMEPNFK(exposedList);
			}
		}
		return hGLLIOOCIDP;
	}

	private static bool NIILCPMBHNH(int EHJNMODJEAN, int BKJOIFFAGKE, float[] FHBFCAEGPOH, int[] HKDOGPLGKNH)
	{
		int num = HKDOGPLGKNH[(BKJOIFFAGKE + EHJNMODJEAN - 1) % BKJOIFFAGKE] << 1;
		int num2 = HKDOGPLGKNH[EHJNMODJEAN] << 1;
		int num3 = HKDOGPLGKNH[(EHJNMODJEAN + 1) % BKJOIFFAGKE] << 1;
		return !FGPIONNMPIP(FHBFCAEGPOH[num], FHBFCAEGPOH[num + 1], FHBFCAEGPOH[num2], FHBFCAEGPOH[num2 + 1], FHBFCAEGPOH[num3], FHBFCAEGPOH[num3 + 1]);
	}

	private static bool FGPIONNMPIP(float LOLMOCMEJCC, float FIKGPJJPGBL, float GEJMGFFFMOK, float EOFNBHKMJAG, float NOOFJDCJLDM, float GJLFGKBFJID)
	{
		return LOLMOCMEJCC * (GJLFGKBFJID - EOFNBHKMJAG) + GEJMGFFFMOK * (FIKGPJJPGBL - GJLFGKBFJID) + NOOFJDCJLDM * (EOFNBHKMJAG - FIKGPJJPGBL) >= 0f;
	}

	private static int LJPBONIKJGO(float LOLMOCMEJCC, float FIKGPJJPGBL, float GEJMGFFFMOK, float EOFNBHKMJAG, float NOOFJDCJLDM, float GJLFGKBFJID)
	{
		float num = GEJMGFFFMOK - LOLMOCMEJCC;
		float num2 = EOFNBHKMJAG - FIKGPJJPGBL;
		return (NOOFJDCJLDM * num2 - GJLFGKBFJID * num + num * FIKGPJJPGBL - LOLMOCMEJCC * num2 >= 0f) ? 1 : (-1);
	}
}
