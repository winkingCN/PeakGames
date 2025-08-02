using Spine;

public class BGPAGKKLJCH
{
	internal readonly AKEHPMGGDMG BMDKDADLDPM = new AKEHPMGGDMG();

	internal readonly ExposedList<float> GDACGHJLDBI = new ExposedList<float>();

	internal readonly ExposedList<float> CFHOKCCINDM = new ExposedList<float>(128);

	internal readonly ExposedList<float> PMICOANAODO = new ExposedList<float>(128);

	internal readonly ExposedList<int> IKBFHHMOGMG = new ExposedList<int>(128);

	internal readonly ExposedList<float> HPDALGDFHGN = new ExposedList<float>(128);

	internal readonly ExposedList<float> BHGNDCGJOBN = new ExposedList<float>();

	internal ACEGNBDLKEG FDPHFBIFIDL;

	internal ExposedList<ExposedList<float>> AICCNHDDCJM;

	public ExposedList<float> GIFJDKEJKIF
	{
		get
		{
			return PMICOANAODO;
		}
	}

	public ExposedList<int> FJDNADMJPKP
	{
		get
		{
			return IKBFHHMOGMG;
		}
	}

	public ExposedList<float> PHFLBJHFMKL
	{
		get
		{
			return HPDALGDFHGN;
		}
	}

	public bool PFGJLJPKOMC
	{
		get
		{
			return FDPHFBIFIDL != null;
		}
	}

	public int CABJPGOPNCE(LBBAMMPJKDA DFKJODFHCJB, ACEGNBDLKEG AICMMKJMNKA)
	{
		if (FDPHFBIFIDL != null)
		{
			return 0;
		}
		FDPHFBIFIDL = AICMMKJMNKA;
		int mCCBDCEJDBC = AICMMKJMNKA.MCCBDCEJDBC;
		float[] items = GDACGHJLDBI.NKMKBLFBOFC(mCCBDCEJDBC).Items;
		AICMMKJMNKA.EPLAHNOCDIB(DFKJODFHCJB, 0, mCCBDCEJDBC, items, 0);
		FDHPEACIDAO(GDACGHJLDBI);
		AICCNHDDCJM = BMDKDADLDPM.CPCEKCIHFCA(GDACGHJLDBI, BMDKDADLDPM.EOBELIMKCOJ(GDACGHJLDBI));
		using (ExposedList<ExposedList<float>>.Enumerator enumerator = AICCNHDDCJM.FIFMNBJLBFK())
		{
			while (enumerator.MoveNext())
			{
				ExposedList<float> current = enumerator.Current;
				FDHPEACIDAO(current);
				current.JEACJNAKLDJ(current.Items[0]);
				current.JEACJNAKLDJ(current.Items[1]);
			}
		}
		return AICCNHDDCJM.Count;
	}

	public void LEOBDLEECHN(LBBAMMPJKDA DFKJODFHCJB)
	{
		if (FDPHFBIFIDL != null && FDPHFBIFIDL.BGKHIDKDGAC == DFKJODFHCJB.MBBPBGHKLJM)
		{
			LEOBDLEECHN();
		}
	}

	public void LEOBDLEECHN()
	{
		if (FDPHFBIFIDL != null)
		{
			FDPHFBIFIDL = null;
			AICCNHDDCJM = null;
			PMICOANAODO.BOPEPLONIFL();
			IKBFHHMOGMG.BOPEPLONIFL();
			GDACGHJLDBI.BOPEPLONIFL();
		}
	}

	public void IKEPENEIHMB(float[] FHBFCAEGPOH, int IEOIFMMIKPE, int[] NPDGLMEOKIO, int CKFECIEOEBD, float[] NDIFGLEBDLE)
	{
		ExposedList<float> cFHOKCCINDM = CFHOKCCINDM;
		ExposedList<float> pMICOANAODO = PMICOANAODO;
		ExposedList<int> iKBFHHMOGMG = IKBFHHMOGMG;
		ExposedList<float>[] items = AICCNHDDCJM.Items;
		int count = AICCNHDDCJM.Count;
		int num = 0;
		pMICOANAODO.BOPEPLONIFL();
		HPDALGDFHGN.BOPEPLONIFL();
		iKBFHHMOGMG.BOPEPLONIFL();
		for (int i = 0; i < CKFECIEOEBD; i += 3)
		{
			int num2 = NPDGLMEOKIO[i] << 1;
			float num3 = FHBFCAEGPOH[num2];
			float num4 = FHBFCAEGPOH[num2 + 1];
			float num5 = NDIFGLEBDLE[num2];
			float num6 = NDIFGLEBDLE[num2 + 1];
			num2 = NPDGLMEOKIO[i + 1] << 1;
			float num7 = FHBFCAEGPOH[num2];
			float num8 = FHBFCAEGPOH[num2 + 1];
			float num9 = NDIFGLEBDLE[num2];
			float num10 = NDIFGLEBDLE[num2 + 1];
			num2 = NPDGLMEOKIO[i + 2] << 1;
			float num11 = FHBFCAEGPOH[num2];
			float num12 = FHBFCAEGPOH[num2 + 1];
			float num13 = NDIFGLEBDLE[num2];
			float num14 = NDIFGLEBDLE[num2 + 1];
			for (int j = 0; j < count; j++)
			{
				int num15 = pMICOANAODO.Count;
				if (NNHKHAGCFEH(num3, num4, num7, num8, num11, num12, items[j], cFHOKCCINDM))
				{
					int count2 = cFHOKCCINDM.Count;
					if (count2 != 0)
					{
						float num16 = num8 - num12;
						float num17 = num11 - num7;
						float num18 = num3 - num11;
						float num19 = num12 - num4;
						float num20 = 1f / (num16 * num18 + num17 * (num4 - num12));
						int num21 = count2 >> 1;
						float[] items2 = cFHOKCCINDM.Items;
						float[] items3 = pMICOANAODO.NKMKBLFBOFC(num15 + num21 * 2).Items;
						float[] items4 = HPDALGDFHGN.NKMKBLFBOFC(num15 + num21 * 2).Items;
						for (int k = 0; k < count2; k += 2)
						{
							float num22 = items2[k];
							float num23 = items2[k + 1];
							items3[num15] = num22;
							items3[num15 + 1] = num23;
							float num24 = num22 - num11;
							float num25 = num23 - num12;
							float num26 = (num16 * num24 + num17 * num25) * num20;
							float num27 = (num19 * num24 + num18 * num25) * num20;
							float num28 = 1f - num26 - num27;
							items4[num15] = num5 * num26 + num9 * num27 + num13 * num28;
							items4[num15 + 1] = num6 * num26 + num10 * num27 + num14 * num28;
							num15 += 2;
						}
						num15 = iKBFHHMOGMG.Count;
						int[] items5 = iKBFHHMOGMG.NKMKBLFBOFC(num15 + 3 * (num21 - 2)).Items;
						num21--;
						for (int l = 1; l < num21; l++)
						{
							items5[num15] = num;
							items5[num15 + 1] = num + l;
							items5[num15 + 2] = num + l + 1;
							num15 += 3;
						}
						num += num21 + 1;
					}
					continue;
				}
				float[] items6 = pMICOANAODO.NKMKBLFBOFC(num15 + 6).Items;
				float[] items7 = HPDALGDFHGN.NKMKBLFBOFC(num15 + 6).Items;
				items6[num15] = num3;
				items6[num15 + 1] = num4;
				items6[num15 + 2] = num7;
				items6[num15 + 3] = num8;
				items6[num15 + 4] = num11;
				items6[num15 + 5] = num12;
				items7[num15] = num5;
				items7[num15 + 1] = num6;
				items7[num15 + 2] = num9;
				items7[num15 + 3] = num10;
				items7[num15 + 4] = num13;
				items7[num15 + 5] = num14;
				num15 = iKBFHHMOGMG.Count;
				int[] items8 = iKBFHHMOGMG.NKMKBLFBOFC(num15 + 3).Items;
				items8[num15] = num;
				items8[num15 + 1] = num + 1;
				items8[num15 + 2] = num + 2;
				num += 3;
				break;
			}
		}
	}

	internal bool NNHKHAGCFEH(float CMJGCHCINDK, float KLMIJJJNIIL, float DPGEOPKDNPM, float GPINCOHCNEI, float JLBGELNHGPO, float DIHMJCLMOAB, ExposedList<float> AMMIDHJCNNE, ExposedList<float> BILGCJNPJGJ)
	{
		ExposedList<float> exposedList = BILGCJNPJGJ;
		bool result = false;
		ExposedList<float> exposedList2 = null;
		if (AMMIDHJCNNE.Count % 4 >= 2)
		{
			exposedList2 = BILGCJNPJGJ;
			BILGCJNPJGJ = BHGNDCGJOBN;
		}
		else
		{
			exposedList2 = BHGNDCGJOBN;
		}
		exposedList2.BOPEPLONIFL();
		exposedList2.JEACJNAKLDJ(CMJGCHCINDK);
		exposedList2.JEACJNAKLDJ(KLMIJJJNIIL);
		exposedList2.JEACJNAKLDJ(DPGEOPKDNPM);
		exposedList2.JEACJNAKLDJ(GPINCOHCNEI);
		exposedList2.JEACJNAKLDJ(JLBGELNHGPO);
		exposedList2.JEACJNAKLDJ(DIHMJCLMOAB);
		exposedList2.JEACJNAKLDJ(CMJGCHCINDK);
		exposedList2.JEACJNAKLDJ(KLMIJJJNIIL);
		BILGCJNPJGJ.BOPEPLONIFL();
		float[] items = AMMIDHJCNNE.Items;
		int num = AMMIDHJCNNE.Count - 4;
		int num2 = 0;
		while (true)
		{
			float num3 = items[num2];
			float num4 = items[num2 + 1];
			float num5 = items[num2 + 2];
			float num6 = items[num2 + 3];
			float num7 = num3 - num5;
			float num8 = num4 - num6;
			float[] items2 = exposedList2.Items;
			int num9 = exposedList2.Count - 2;
			int count = BILGCJNPJGJ.Count;
			for (int i = 0; i < num9; i += 2)
			{
				float num10 = items2[i];
				float num11 = items2[i + 1];
				float num12 = items2[i + 2];
				float num13 = items2[i + 3];
				bool flag = num7 * (num13 - num6) - num8 * (num12 - num5) > 0f;
				if (num7 * (num11 - num6) - num8 * (num10 - num5) > 0f)
				{
					if (flag)
					{
						BILGCJNPJGJ.JEACJNAKLDJ(num12);
						BILGCJNPJGJ.JEACJNAKLDJ(num13);
						continue;
					}
					float num14 = num13 - num11;
					float num15 = num12 - num10;
					float num16 = (num15 * (num4 - num11) - num14 * (num3 - num10)) / (num14 * (num5 - num3) - num15 * (num6 - num4));
					BILGCJNPJGJ.JEACJNAKLDJ(num3 + (num5 - num3) * num16);
					BILGCJNPJGJ.JEACJNAKLDJ(num4 + (num6 - num4) * num16);
				}
				else if (flag)
				{
					float num17 = num13 - num11;
					float num18 = num12 - num10;
					float num19 = (num18 * (num4 - num11) - num17 * (num3 - num10)) / (num17 * (num5 - num3) - num18 * (num6 - num4));
					BILGCJNPJGJ.JEACJNAKLDJ(num3 + (num5 - num3) * num19);
					BILGCJNPJGJ.JEACJNAKLDJ(num4 + (num6 - num4) * num19);
					BILGCJNPJGJ.JEACJNAKLDJ(num12);
					BILGCJNPJGJ.JEACJNAKLDJ(num13);
				}
				result = true;
			}
			if (count == BILGCJNPJGJ.Count)
			{
				exposedList.BOPEPLONIFL();
				return true;
			}
			BILGCJNPJGJ.JEACJNAKLDJ(BILGCJNPJGJ.Items[0]);
			BILGCJNPJGJ.JEACJNAKLDJ(BILGCJNPJGJ.Items[1]);
			if (num2 == num)
			{
				break;
			}
			ExposedList<float> exposedList3 = BILGCJNPJGJ;
			BILGCJNPJGJ = exposedList2;
			BILGCJNPJGJ.BOPEPLONIFL();
			exposedList2 = exposedList3;
			num2 += 2;
		}
		if (exposedList != BILGCJNPJGJ)
		{
			exposedList.BOPEPLONIFL();
			int j = 0;
			for (int num20 = BILGCJNPJGJ.Count - 2; j < num20; j++)
			{
				exposedList.JEACJNAKLDJ(BILGCJNPJGJ.Items[j]);
			}
		}
		else
		{
			exposedList.NKMKBLFBOFC(exposedList.Count - 2);
		}
		return result;
	}

	private static void FDHPEACIDAO(ExposedList<float> BGCDJHJPCLE)
	{
		float[] items = BGCDJHJPCLE.Items;
		int count = BGCDJHJPCLE.Count;
		float num = items[count - 2] * items[1] - items[0] * items[count - 1];
		int i = 0;
		for (int num2 = count - 3; i < num2; i += 2)
		{
			float num3 = items[i];
			float num4 = items[i + 1];
			float num5 = items[i + 2];
			float num6 = items[i + 3];
			num += num3 * num6 - num5 * num4;
		}
		if (!(num < 0f))
		{
			int j = 0;
			int num7 = count - 2;
			for (int num8 = count >> 1; j < num8; j += 2)
			{
				float num9 = items[j];
				float num10 = items[j + 1];
				int num11 = num7 - j;
				items[j] = items[num11];
				items[j + 1] = items[num11 + 1];
				items[num11] = num9;
				items[num11 + 1] = num10;
			}
		}
	}
}
