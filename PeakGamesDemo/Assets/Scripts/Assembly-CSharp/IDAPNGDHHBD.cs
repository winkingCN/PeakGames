using System;
using System.Collections.Generic;
using UnityEngine;

public struct IDAPNGDHHBD
{
	private static readonly Color32 GCDDIBEDEPB = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	private static readonly Vector3 LEOKEIONJLP = new Vector3(0f, 0f, -1f);

	private static readonly Vector4 IIBPJONIFCD = new Vector4(-1f, 0f, 0f, 1f);

	public Mesh IJKCGGPJDIG;

	public int BKJOIFFAGKE;

	public Vector3[] FHBFCAEGPOH;

	public Vector3[] JEEPPLNJEPI;

	public Vector4[] ADGCBACGHGI;

	public Vector2[] LFAFOAOKPKA;

	public Vector2[] FJPNPHPFBFJ;

	public Color32[] PMBHKFBDDND;

	public int[] NPDGLMEOKIO;

	public IDAPNGDHHBD(Mesh IJKCGGPJDIG, int MOFHAKELNPN)
	{
		if (IJKCGGPJDIG == null)
		{
			IJKCGGPJDIG = new Mesh();
		}
		else
		{
			IJKCGGPJDIG.Clear();
		}
		this.IJKCGGPJDIG = IJKCGGPJDIG;
		MOFHAKELNPN = Mathf.Min(MOFHAKELNPN, 16383);
		int num = MOFHAKELNPN * 4;
		int num2 = MOFHAKELNPN * 6;
		BKJOIFFAGKE = 0;
		FHBFCAEGPOH = new Vector3[num];
		LFAFOAOKPKA = new Vector2[num];
		FJPNPHPFBFJ = new Vector2[num];
		PMBHKFBDDND = new Color32[num];
		JEEPPLNJEPI = new Vector3[num];
		ADGCBACGHGI = new Vector4[num];
		NPDGLMEOKIO = new int[num2];
		int num3 = 0;
		int num4 = 0;
		while (num4 / 4 < MOFHAKELNPN)
		{
			for (int i = 0; i < 4; i++)
			{
				FHBFCAEGPOH[num4 + i] = Vector3.zero;
				LFAFOAOKPKA[num4 + i] = Vector2.zero;
				FJPNPHPFBFJ[num4 + i] = Vector2.zero;
				PMBHKFBDDND[num4 + i] = GCDDIBEDEPB;
				JEEPPLNJEPI[num4 + i] = LEOKEIONJLP;
				ADGCBACGHGI[num4 + i] = IIBPJONIFCD;
			}
			NPDGLMEOKIO[num3] = num4;
			NPDGLMEOKIO[num3 + 1] = num4 + 1;
			NPDGLMEOKIO[num3 + 2] = num4 + 2;
			NPDGLMEOKIO[num3 + 3] = num4 + 2;
			NPDGLMEOKIO[num3 + 4] = num4 + 3;
			NPDGLMEOKIO[num3 + 5] = num4;
			num4 += 4;
			num3 += 6;
		}
		this.IJKCGGPJDIG.vertices = FHBFCAEGPOH;
		this.IJKCGGPJDIG.normals = JEEPPLNJEPI;
		this.IJKCGGPJDIG.tangents = ADGCBACGHGI;
		this.IJKCGGPJDIG.triangles = NPDGLMEOKIO;
		this.IJKCGGPJDIG.bounds = new Bounds(Vector3.zero, new Vector3(3840f, 2160f, 0f));
	}

	public IDAPNGDHHBD(Mesh IJKCGGPJDIG, int MOFHAKELNPN, bool JKKNBMKFKAI)
	{
		if (IJKCGGPJDIG == null)
		{
			IJKCGGPJDIG = new Mesh();
		}
		else
		{
			IJKCGGPJDIG.Clear();
		}
		this.IJKCGGPJDIG = IJKCGGPJDIG;
		int num = (JKKNBMKFKAI ? 8 : 4);
		int num2 = (JKKNBMKFKAI ? 36 : 6);
		MOFHAKELNPN = Mathf.Min(MOFHAKELNPN, 65532 / num);
		int num3 = MOFHAKELNPN * num;
		int num4 = MOFHAKELNPN * num2;
		BKJOIFFAGKE = 0;
		FHBFCAEGPOH = new Vector3[num3];
		LFAFOAOKPKA = new Vector2[num3];
		FJPNPHPFBFJ = new Vector2[num3];
		PMBHKFBDDND = new Color32[num3];
		JEEPPLNJEPI = new Vector3[num3];
		ADGCBACGHGI = new Vector4[num3];
		NPDGLMEOKIO = new int[num4];
		int num5 = 0;
		int num6 = 0;
		while (num5 / num < MOFHAKELNPN)
		{
			for (int i = 0; i < num; i++)
			{
				FHBFCAEGPOH[num5 + i] = Vector3.zero;
				LFAFOAOKPKA[num5 + i] = Vector2.zero;
				FJPNPHPFBFJ[num5 + i] = Vector2.zero;
				PMBHKFBDDND[num5 + i] = GCDDIBEDEPB;
				JEEPPLNJEPI[num5 + i] = LEOKEIONJLP;
				ADGCBACGHGI[num5 + i] = IIBPJONIFCD;
			}
			NPDGLMEOKIO[num6] = num5;
			NPDGLMEOKIO[num6 + 1] = num5 + 1;
			NPDGLMEOKIO[num6 + 2] = num5 + 2;
			NPDGLMEOKIO[num6 + 3] = num5 + 2;
			NPDGLMEOKIO[num6 + 4] = num5 + 3;
			NPDGLMEOKIO[num6 + 5] = num5;
			if (JKKNBMKFKAI)
			{
				NPDGLMEOKIO[num6 + 6] = num5 + 4;
				NPDGLMEOKIO[num6 + 7] = num5 + 5;
				NPDGLMEOKIO[num6 + 8] = num5 + 1;
				NPDGLMEOKIO[num6 + 9] = num5 + 1;
				NPDGLMEOKIO[num6 + 10] = num5;
				NPDGLMEOKIO[num6 + 11] = num5 + 4;
				NPDGLMEOKIO[num6 + 12] = num5 + 3;
				NPDGLMEOKIO[num6 + 13] = num5 + 2;
				NPDGLMEOKIO[num6 + 14] = num5 + 6;
				NPDGLMEOKIO[num6 + 15] = num5 + 6;
				NPDGLMEOKIO[num6 + 16] = num5 + 7;
				NPDGLMEOKIO[num6 + 17] = num5 + 3;
				NPDGLMEOKIO[num6 + 18] = num5 + 1;
				NPDGLMEOKIO[num6 + 19] = num5 + 5;
				NPDGLMEOKIO[num6 + 20] = num5 + 6;
				NPDGLMEOKIO[num6 + 21] = num5 + 6;
				NPDGLMEOKIO[num6 + 22] = num5 + 2;
				NPDGLMEOKIO[num6 + 23] = num5 + 1;
				NPDGLMEOKIO[num6 + 24] = num5 + 4;
				NPDGLMEOKIO[num6 + 25] = num5;
				NPDGLMEOKIO[num6 + 26] = num5 + 3;
				NPDGLMEOKIO[num6 + 27] = num5 + 3;
				NPDGLMEOKIO[num6 + 28] = num5 + 7;
				NPDGLMEOKIO[num6 + 29] = num5 + 4;
				NPDGLMEOKIO[num6 + 30] = num5 + 7;
				NPDGLMEOKIO[num6 + 31] = num5 + 6;
				NPDGLMEOKIO[num6 + 32] = num5 + 5;
				NPDGLMEOKIO[num6 + 33] = num5 + 5;
				NPDGLMEOKIO[num6 + 34] = num5 + 4;
				NPDGLMEOKIO[num6 + 35] = num5 + 7;
			}
			num5 += num;
			num6 += num2;
		}
		this.IJKCGGPJDIG.vertices = FHBFCAEGPOH;
		this.IJKCGGPJDIG.normals = JEEPPLNJEPI;
		this.IJKCGGPJDIG.tangents = ADGCBACGHGI;
		this.IJKCGGPJDIG.triangles = NPDGLMEOKIO;
		this.IJKCGGPJDIG.bounds = new Bounds(Vector3.zero, new Vector3(3840f, 2160f, 64f));
	}

	public void CMGCBJCIJNB(int MOFHAKELNPN)
	{
		MOFHAKELNPN = Mathf.Min(MOFHAKELNPN, 16383);
		int newSize = MOFHAKELNPN * 4;
		int newSize2 = MOFHAKELNPN * 6;
		int num = FHBFCAEGPOH.Length / 4;
		Array.Resize(ref FHBFCAEGPOH, newSize);
		Array.Resize(ref JEEPPLNJEPI, newSize);
		Array.Resize(ref ADGCBACGHGI, newSize);
		Array.Resize(ref LFAFOAOKPKA, newSize);
		Array.Resize(ref FJPNPHPFBFJ, newSize);
		Array.Resize(ref PMBHKFBDDND, newSize);
		Array.Resize(ref NPDGLMEOKIO, newSize2);
		if (MOFHAKELNPN <= num)
		{
			IJKCGGPJDIG.triangles = NPDGLMEOKIO;
			IJKCGGPJDIG.vertices = FHBFCAEGPOH;
			IJKCGGPJDIG.normals = JEEPPLNJEPI;
			IJKCGGPJDIG.tangents = ADGCBACGHGI;
			return;
		}
		for (int i = num; i < MOFHAKELNPN; i++)
		{
			int num2 = i * 4;
			int num3 = i * 6;
			JEEPPLNJEPI[num2] = LEOKEIONJLP;
			JEEPPLNJEPI[1 + num2] = LEOKEIONJLP;
			JEEPPLNJEPI[2 + num2] = LEOKEIONJLP;
			JEEPPLNJEPI[3 + num2] = LEOKEIONJLP;
			ADGCBACGHGI[num2] = IIBPJONIFCD;
			ADGCBACGHGI[1 + num2] = IIBPJONIFCD;
			ADGCBACGHGI[2 + num2] = IIBPJONIFCD;
			ADGCBACGHGI[3 + num2] = IIBPJONIFCD;
			NPDGLMEOKIO[num3] = num2;
			NPDGLMEOKIO[1 + num3] = 1 + num2;
			NPDGLMEOKIO[2 + num3] = 2 + num2;
			NPDGLMEOKIO[3 + num3] = 2 + num2;
			NPDGLMEOKIO[4 + num3] = 3 + num2;
			NPDGLMEOKIO[5 + num3] = num2;
		}
		IJKCGGPJDIG.vertices = FHBFCAEGPOH;
		IJKCGGPJDIG.normals = JEEPPLNJEPI;
		IJKCGGPJDIG.tangents = ADGCBACGHGI;
		IJKCGGPJDIG.triangles = NPDGLMEOKIO;
	}

	public void CMGCBJCIJNB(int MOFHAKELNPN, bool JKKNBMKFKAI)
	{
		int num = (JKKNBMKFKAI ? 8 : 4);
		int num2 = (JKKNBMKFKAI ? 36 : 6);
		MOFHAKELNPN = Mathf.Min(MOFHAKELNPN, 65532 / num);
		int newSize = MOFHAKELNPN * num;
		int newSize2 = MOFHAKELNPN * num2;
		int num3 = FHBFCAEGPOH.Length / num;
		Array.Resize(ref FHBFCAEGPOH, newSize);
		Array.Resize(ref JEEPPLNJEPI, newSize);
		Array.Resize(ref ADGCBACGHGI, newSize);
		Array.Resize(ref LFAFOAOKPKA, newSize);
		Array.Resize(ref FJPNPHPFBFJ, newSize);
		Array.Resize(ref PMBHKFBDDND, newSize);
		Array.Resize(ref NPDGLMEOKIO, newSize2);
		if (MOFHAKELNPN <= num3)
		{
			IJKCGGPJDIG.triangles = NPDGLMEOKIO;
			IJKCGGPJDIG.vertices = FHBFCAEGPOH;
			IJKCGGPJDIG.normals = JEEPPLNJEPI;
			IJKCGGPJDIG.tangents = ADGCBACGHGI;
			return;
		}
		for (int i = num3; i < MOFHAKELNPN; i++)
		{
			int num4 = i * num;
			int num5 = i * num2;
			JEEPPLNJEPI[num4] = LEOKEIONJLP;
			JEEPPLNJEPI[1 + num4] = LEOKEIONJLP;
			JEEPPLNJEPI[2 + num4] = LEOKEIONJLP;
			JEEPPLNJEPI[3 + num4] = LEOKEIONJLP;
			ADGCBACGHGI[num4] = IIBPJONIFCD;
			ADGCBACGHGI[1 + num4] = IIBPJONIFCD;
			ADGCBACGHGI[2 + num4] = IIBPJONIFCD;
			ADGCBACGHGI[3 + num4] = IIBPJONIFCD;
			if (JKKNBMKFKAI)
			{
				JEEPPLNJEPI[4 + num4] = LEOKEIONJLP;
				JEEPPLNJEPI[5 + num4] = LEOKEIONJLP;
				JEEPPLNJEPI[6 + num4] = LEOKEIONJLP;
				JEEPPLNJEPI[7 + num4] = LEOKEIONJLP;
				ADGCBACGHGI[4 + num4] = IIBPJONIFCD;
				ADGCBACGHGI[5 + num4] = IIBPJONIFCD;
				ADGCBACGHGI[6 + num4] = IIBPJONIFCD;
				ADGCBACGHGI[7 + num4] = IIBPJONIFCD;
			}
			NPDGLMEOKIO[num5] = num4;
			NPDGLMEOKIO[1 + num5] = 1 + num4;
			NPDGLMEOKIO[2 + num5] = 2 + num4;
			NPDGLMEOKIO[3 + num5] = 2 + num4;
			NPDGLMEOKIO[4 + num5] = 3 + num4;
			NPDGLMEOKIO[5 + num5] = num4;
			if (JKKNBMKFKAI)
			{
				NPDGLMEOKIO[num5 + 6] = num4 + 4;
				NPDGLMEOKIO[num5 + 7] = num4 + 5;
				NPDGLMEOKIO[num5 + 8] = num4 + 1;
				NPDGLMEOKIO[num5 + 9] = num4 + 1;
				NPDGLMEOKIO[num5 + 10] = num4;
				NPDGLMEOKIO[num5 + 11] = num4 + 4;
				NPDGLMEOKIO[num5 + 12] = num4 + 3;
				NPDGLMEOKIO[num5 + 13] = num4 + 2;
				NPDGLMEOKIO[num5 + 14] = num4 + 6;
				NPDGLMEOKIO[num5 + 15] = num4 + 6;
				NPDGLMEOKIO[num5 + 16] = num4 + 7;
				NPDGLMEOKIO[num5 + 17] = num4 + 3;
				NPDGLMEOKIO[num5 + 18] = num4 + 1;
				NPDGLMEOKIO[num5 + 19] = num4 + 5;
				NPDGLMEOKIO[num5 + 20] = num4 + 6;
				NPDGLMEOKIO[num5 + 21] = num4 + 6;
				NPDGLMEOKIO[num5 + 22] = num4 + 2;
				NPDGLMEOKIO[num5 + 23] = num4 + 1;
				NPDGLMEOKIO[num5 + 24] = num4 + 4;
				NPDGLMEOKIO[num5 + 25] = num4;
				NPDGLMEOKIO[num5 + 26] = num4 + 3;
				NPDGLMEOKIO[num5 + 27] = num4 + 3;
				NPDGLMEOKIO[num5 + 28] = num4 + 7;
				NPDGLMEOKIO[num5 + 29] = num4 + 4;
				NPDGLMEOKIO[num5 + 30] = num4 + 7;
				NPDGLMEOKIO[num5 + 31] = num4 + 6;
				NPDGLMEOKIO[num5 + 32] = num4 + 5;
				NPDGLMEOKIO[num5 + 33] = num4 + 5;
				NPDGLMEOKIO[num5 + 34] = num4 + 4;
				NPDGLMEOKIO[num5 + 35] = num4 + 7;
			}
		}
		IJKCGGPJDIG.vertices = FHBFCAEGPOH;
		IJKCGGPJDIG.normals = JEEPPLNJEPI;
		IJKCGGPJDIG.tangents = ADGCBACGHGI;
		IJKCGGPJDIG.triangles = NPDGLMEOKIO;
	}

	public void BOPEPLONIFL()
	{
		if (FHBFCAEGPOH != null)
		{
			Array.Clear(FHBFCAEGPOH, 0, FHBFCAEGPOH.Length);
			BKJOIFFAGKE = 0;
			if (IJKCGGPJDIG != null)
			{
				IJKCGGPJDIG.vertices = FHBFCAEGPOH;
			}
		}
	}

	public void BOPEPLONIFL(bool GOBFBHCMGHG)
	{
		if (FHBFCAEGPOH != null)
		{
			Array.Clear(FHBFCAEGPOH, 0, FHBFCAEGPOH.Length);
			BKJOIFFAGKE = 0;
			if (GOBFBHCMGHG && IJKCGGPJDIG != null)
			{
				IJKCGGPJDIG.vertices = FHBFCAEGPOH;
			}
		}
	}

	public void NGOKLPFCFAO()
	{
		int num = FHBFCAEGPOH.Length - BKJOIFFAGKE;
		if (num > 0)
		{
			Array.Clear(FHBFCAEGPOH, BKJOIFFAGKE, num);
		}
	}

	public void NGOKLPFCFAO(int KKMNKJJENIL)
	{
		int num = FHBFCAEGPOH.Length - KKMNKJJENIL;
		if (num > 0)
		{
			Array.Clear(FHBFCAEGPOH, KKMNKJJENIL, num);
		}
	}

	public void NGOKLPFCFAO(int KKMNKJJENIL, bool AHJKJHGIJIA)
	{
		int num = FHBFCAEGPOH.Length - KKMNKJJENIL;
		if (num > 0)
		{
			Array.Clear(FHBFCAEGPOH, KKMNKJJENIL, num);
		}
		if (AHJKJHGIJIA && IJKCGGPJDIG != null)
		{
			IJKCGGPJDIG.vertices = FHBFCAEGPOH;
		}
	}

	public void HJDKIIGKKNG(LLKOCAEGPDG CMAJLIAELDP)
	{
		if (CMAJLIAELDP == LLKOCAEGPDG.Normal || CMAJLIAELDP != LLKOCAEGPDG.Reverse)
		{
			return;
		}
		int num = BKJOIFFAGKE / 4;
		for (int i = 0; i < num; i++)
		{
			int num2 = i * 4;
			int num3 = (num - i - 1) * 4;
			if (num2 < num3)
			{
				AHKEBAMDNJF(num2, num3);
			}
		}
	}

	public void HJDKIIGKKNG(IList<int> GDDGFAKOCIL)
	{
		int count = GDDGFAKOCIL.Count;
		if (count * 4 > FHBFCAEGPOH.Length)
		{
			return;
		}
		for (int i = 0; i < count; i++)
		{
			int num;
			for (num = GDDGFAKOCIL[i]; num < i; num = GDDGFAKOCIL[num])
			{
			}
			if (num != i)
			{
				AHKEBAMDNJF(num * 4, i * 4);
			}
		}
	}

	public void AHKEBAMDNJF(int ENICBMKPJJK, int PPFHFMDDDLM)
	{
		Vector3 vector = FHBFCAEGPOH[PPFHFMDDDLM];
		FHBFCAEGPOH[PPFHFMDDDLM] = FHBFCAEGPOH[ENICBMKPJJK];
		FHBFCAEGPOH[ENICBMKPJJK] = vector;
		vector = FHBFCAEGPOH[PPFHFMDDDLM + 1];
		FHBFCAEGPOH[PPFHFMDDDLM + 1] = FHBFCAEGPOH[ENICBMKPJJK + 1];
		FHBFCAEGPOH[ENICBMKPJJK + 1] = vector;
		vector = FHBFCAEGPOH[PPFHFMDDDLM + 2];
		FHBFCAEGPOH[PPFHFMDDDLM + 2] = FHBFCAEGPOH[ENICBMKPJJK + 2];
		FHBFCAEGPOH[ENICBMKPJJK + 2] = vector;
		vector = FHBFCAEGPOH[PPFHFMDDDLM + 3];
		FHBFCAEGPOH[PPFHFMDDDLM + 3] = FHBFCAEGPOH[ENICBMKPJJK + 3];
		FHBFCAEGPOH[ENICBMKPJJK + 3] = vector;
		Vector2 vector2 = LFAFOAOKPKA[PPFHFMDDDLM];
		LFAFOAOKPKA[PPFHFMDDDLM] = LFAFOAOKPKA[ENICBMKPJJK];
		LFAFOAOKPKA[ENICBMKPJJK] = vector2;
		vector2 = LFAFOAOKPKA[PPFHFMDDDLM + 1];
		LFAFOAOKPKA[PPFHFMDDDLM + 1] = LFAFOAOKPKA[ENICBMKPJJK + 1];
		LFAFOAOKPKA[ENICBMKPJJK + 1] = vector2;
		vector2 = LFAFOAOKPKA[PPFHFMDDDLM + 2];
		LFAFOAOKPKA[PPFHFMDDDLM + 2] = LFAFOAOKPKA[ENICBMKPJJK + 2];
		LFAFOAOKPKA[ENICBMKPJJK + 2] = vector2;
		vector2 = LFAFOAOKPKA[PPFHFMDDDLM + 3];
		LFAFOAOKPKA[PPFHFMDDDLM + 3] = LFAFOAOKPKA[ENICBMKPJJK + 3];
		LFAFOAOKPKA[ENICBMKPJJK + 3] = vector2;
		vector2 = FJPNPHPFBFJ[PPFHFMDDDLM];
		FJPNPHPFBFJ[PPFHFMDDDLM] = FJPNPHPFBFJ[ENICBMKPJJK];
		FJPNPHPFBFJ[ENICBMKPJJK] = vector2;
		vector2 = FJPNPHPFBFJ[PPFHFMDDDLM + 1];
		FJPNPHPFBFJ[PPFHFMDDDLM + 1] = FJPNPHPFBFJ[ENICBMKPJJK + 1];
		FJPNPHPFBFJ[ENICBMKPJJK + 1] = vector2;
		vector2 = FJPNPHPFBFJ[PPFHFMDDDLM + 2];
		FJPNPHPFBFJ[PPFHFMDDDLM + 2] = FJPNPHPFBFJ[ENICBMKPJJK + 2];
		FJPNPHPFBFJ[ENICBMKPJJK + 2] = vector2;
		vector2 = FJPNPHPFBFJ[PPFHFMDDDLM + 3];
		FJPNPHPFBFJ[PPFHFMDDDLM + 3] = FJPNPHPFBFJ[ENICBMKPJJK + 3];
		FJPNPHPFBFJ[ENICBMKPJJK + 3] = vector2;
		Color32 color = PMBHKFBDDND[PPFHFMDDDLM];
		PMBHKFBDDND[PPFHFMDDDLM] = PMBHKFBDDND[ENICBMKPJJK];
		PMBHKFBDDND[ENICBMKPJJK] = color;
		color = PMBHKFBDDND[PPFHFMDDDLM + 1];
		PMBHKFBDDND[PPFHFMDDDLM + 1] = PMBHKFBDDND[ENICBMKPJJK + 1];
		PMBHKFBDDND[ENICBMKPJJK + 1] = color;
		color = PMBHKFBDDND[PPFHFMDDDLM + 2];
		PMBHKFBDDND[PPFHFMDDDLM + 2] = PMBHKFBDDND[ENICBMKPJJK + 2];
		PMBHKFBDDND[ENICBMKPJJK + 2] = color;
		color = PMBHKFBDDND[PPFHFMDDDLM + 3];
		PMBHKFBDDND[PPFHFMDDDLM + 3] = PMBHKFBDDND[ENICBMKPJJK + 3];
		PMBHKFBDDND[ENICBMKPJJK + 3] = color;
	}
}
