using DG.Tweening;
using UnityEngine;

public static class AMPCNLBLOIL
{
	public static LNEKBHIDOIG MBNNJGMFFAF(Transform ANLKLKAINEO, Vector3 LLAEDBFNCCP, Vector3 JEJLEJBPJIJ, Vector3 MPNMKDOJKOM, Vector3 BMIOECELGCA, int KIPDNBHFBAG, float KCNCHPJAALL, Ease KOMEPJAHOBA)
	{
		Vector3[] array = new Vector3[KIPDNBHFBAG];
		float[] array2 = new float[KIPDNBHFBAG];
		float num = 0f;
		Vector3 vector = MKGEDBNPGJN(LLAEDBFNCCP, JEJLEJBPJIJ, MPNMKDOJKOM, BMIOECELGCA, 0f);
		for (int i = 0; i < KIPDNBHFBAG; i++)
		{
			float lLIEHCKNJEM = (float)(i + 1) / (float)KIPDNBHFBAG;
			Vector3 vector2 = MKGEDBNPGJN(LLAEDBFNCCP, JEJLEJBPJIJ, MPNMKDOJKOM, BMIOECELGCA, lLIEHCKNJEM);
			float magnitude = (vector2 - vector).magnitude;
			array2[i] = magnitude / KCNCHPJAALL;
			array[i] = vector2;
			vector = vector2;
			num += array2[i];
		}
		Sequence sequence = DOTween.Sequence().SetEase(KOMEPJAHOBA);
		float num2 = num / (float)KIPDNBHFBAG;
		float num3 = 0f;
		for (int j = 0; j < KIPDNBHFBAG; j++)
		{
			float num4 = array2[j];
			float num5 = num2 - num4;
			num4 += num5 * 0.4f;
			sequence.Append(ANLKLKAINEO.DOMove(array[j], num4).SetEase(Ease.Linear));
			num3 += num4;
		}
		return new LNEKBHIDOIG(sequence, num3);
	}

	public static Vector3 OICPCAPKFPI(Vector3 LLAEDBFNCCP, Vector3 ELEIAMCGPIM, Vector3 BMIOECELGCA, float LLIEHCKNJEM)
	{
		Vector3 zero = Vector3.zero;
		float num = 1f - LLIEHCKNJEM;
		zero.x = LLAEDBFNCCP.x * num * num + ELEIAMCGPIM.x * 2f * num * LLIEHCKNJEM + BMIOECELGCA.x * LLIEHCKNJEM * LLIEHCKNJEM;
		zero.y = LLAEDBFNCCP.y * num * num + ELEIAMCGPIM.y * 2f * num * LLIEHCKNJEM + BMIOECELGCA.y * LLIEHCKNJEM * LLIEHCKNJEM;
		return zero;
	}

	private static Vector3 MKGEDBNPGJN(Vector3 LLAEDBFNCCP, Vector3 JEJLEJBPJIJ, Vector3 MPNMKDOJKOM, Vector3 BMIOECELGCA, float LLIEHCKNJEM)
	{
		Vector3 zero = Vector3.zero;
		float num = 1f - LLIEHCKNJEM;
		zero.x = LLAEDBFNCCP.x * Mathf.Pow(num, 3f) + 3f * LLIEHCKNJEM * Mathf.Pow(num, 2f) * JEJLEJBPJIJ.x + 3f * Mathf.Pow(LLIEHCKNJEM, 2f) * num * MPNMKDOJKOM.x + Mathf.Pow(LLIEHCKNJEM, 3f) * BMIOECELGCA.x;
		zero.y = LLAEDBFNCCP.y * Mathf.Pow(num, 3f) + 3f * LLIEHCKNJEM * Mathf.Pow(num, 2f) * JEJLEJBPJIJ.y + 3f * Mathf.Pow(LLIEHCKNJEM, 2f) * num * MPNMKDOJKOM.y + Mathf.Pow(LLIEHCKNJEM, 3f) * BMIOECELGCA.y;
		return zero;
	}
}
