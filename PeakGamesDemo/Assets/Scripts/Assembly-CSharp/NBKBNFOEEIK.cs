using System;
using System.Collections;
using UnityEngine;

public static class NBKBNFOEEIK
{
	public static IEnumerator LGJBBEFGCFE(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Vector3 localPosition = ANLKLKAINEO.localPosition;
		Vector3 vector = CAEMELGEOAE - localPosition;
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			ANLKLKAINEO.localPosition = localPosition + vector * LMGHDHGABOL(num / FMPBJJMKCIG);
			yield return 0;
		}
		ANLKLKAINEO.localPosition = CAEMELGEOAE;
	}

	public static IEnumerator LGJBBEFGCFE(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.LGJBBEFGCFE(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator LGJBBEFGCFE(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.LGJBBEFGCFE(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator NOOGJCNEKLA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		Vector3 localPosition = ANLKLKAINEO.localPosition;
		ANLKLKAINEO.localPosition = CAEMELGEOAE;
		return ANLKLKAINEO.LGJBBEFGCFE(localPosition, FMPBJJMKCIG, LMGHDHGABOL);
	}

	public static IEnumerator NOOGJCNEKLA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.NOOGJCNEKLA(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator NOOGJCNEKLA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.NOOGJCNEKLA(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator JDMFKBCGNEM(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Vector3 localScale = ANLKLKAINEO.localScale;
		Vector3 vector = CAEMELGEOAE - localScale;
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			ANLKLKAINEO.localScale = localScale + vector * LMGHDHGABOL(num / FMPBJJMKCIG);
			yield return 0;
		}
		ANLKLKAINEO.localScale = CAEMELGEOAE;
	}

	public static IEnumerator JDMFKBCGNEM(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.JDMFKBCGNEM(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator JDMFKBCGNEM(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.JDMFKBCGNEM(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator BNFOLGGBHIA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		Vector3 localScale = ANLKLKAINEO.localScale;
		ANLKLKAINEO.localScale = CAEMELGEOAE;
		return ANLKLKAINEO.JDMFKBCGNEM(localScale, FMPBJJMKCIG, LMGHDHGABOL);
	}

	public static IEnumerator BNFOLGGBHIA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.BNFOLGGBHIA(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator BNFOLGGBHIA(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.BNFOLGGBHIA(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator MGPNACOFKMK(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Quaternion localRotation = ANLKLKAINEO.localRotation;
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			ANLKLKAINEO.localRotation = Quaternion.Lerp(localRotation, CAEMELGEOAE, LMGHDHGABOL(num / FMPBJJMKCIG));
			yield return 0;
		}
		ANLKLKAINEO.localRotation = CAEMELGEOAE;
	}

	public static IEnumerator MGPNACOFKMK(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.MGPNACOFKMK(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator MGPNACOFKMK(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.MGPNACOFKMK(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator CMNKDNILGLB(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		Quaternion localRotation = ANLKLKAINEO.localRotation;
		ANLKLKAINEO.localRotation = CAEMELGEOAE;
		return ANLKLKAINEO.MGPNACOFKMK(localRotation, FMPBJJMKCIG, LMGHDHGABOL);
	}

	public static IEnumerator CMNKDNILGLB(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.CMNKDNILGLB(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator CMNKDNILGLB(this Transform ANLKLKAINEO, Quaternion CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.CMNKDNILGLB(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator EJBPPMACIKI(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.EJBPPMACIKI(ELEIAMCGPIM, CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator EJBPPMACIKI(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Vector3 position = ANLKLKAINEO.position;
		Vector3 position2 = default(Vector3);
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			float num2 = LMGHDHGABOL(num / FMPBJJMKCIG);
			position2.x = position.x * (1f - num2) * (1f - num2) + ELEIAMCGPIM.x * 2f * (1f - num2) * num2 + CAEMELGEOAE.x * num2 * num2;
			position2.y = position.y * (1f - num2) * (1f - num2) + ELEIAMCGPIM.y * 2f * (1f - num2) * num2 + CAEMELGEOAE.y * num2 * num2;
			position2.z = position.z * (1f - num2) * (1f - num2) + ELEIAMCGPIM.z * 2f * (1f - num2) * num2 + CAEMELGEOAE.z * num2 * num2;
			ANLKLKAINEO.position = position2;
			yield return 0;
		}
		ANLKLKAINEO.position = CAEMELGEOAE;
	}

	public static IEnumerator JBHPOJLLMOK(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Vector3 localPosition = ANLKLKAINEO.localPosition;
		Vector3 localPosition2 = default(Vector3);
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			float num2 = LMGHDHGABOL(num / FMPBJJMKCIG);
			localPosition2.x = localPosition.x * (1f - num2) * (1f - num2) + ELEIAMCGPIM.x * 2f * (1f - num2) * num2 + CAEMELGEOAE.x * num2 * num2;
			localPosition2.y = localPosition.y * (1f - num2) * (1f - num2) + ELEIAMCGPIM.y * 2f * (1f - num2) * num2 + CAEMELGEOAE.y * num2 * num2;
			localPosition2.z = localPosition.z * (1f - num2) * (1f - num2) + ELEIAMCGPIM.z * 2f * (1f - num2) * num2 + CAEMELGEOAE.z * num2 * num2;
			ANLKLKAINEO.localPosition = localPosition2;
			yield return 0;
		}
		ANLKLKAINEO.localPosition = CAEMELGEOAE;
	}

	public static IEnumerator JBHPOJLLMOK(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 CAEMELGEOAE, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.JBHPOJLLMOK(ELEIAMCGPIM, CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator JBHPOJLLMOK(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.JBHPOJLLMOK(ELEIAMCGPIM, CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator GMNOKDHGPLM(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 EHGOOEHDNMM, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		Vector3 localPosition = ANLKLKAINEO.localPosition;
		ANLKLKAINEO.localPosition = EHGOOEHDNMM;
		return ANLKLKAINEO.JBHPOJLLMOK(ELEIAMCGPIM, localPosition, FMPBJJMKCIG, LMGHDHGABOL);
	}

	public static IEnumerator GMNOKDHGPLM(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 EHGOOEHDNMM, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.GMNOKDHGPLM(ELEIAMCGPIM, EHGOOEHDNMM, FMPBJJMKCIG, IAEACNKONMF.CALMGKBNAKF);
	}

	public static IEnumerator GMNOKDHGPLM(this Transform ANLKLKAINEO, Vector3 ELEIAMCGPIM, Vector3 EHGOOEHDNMM, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.GMNOKDHGPLM(ELEIAMCGPIM, EHGOOEHDNMM, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}

	public static IEnumerator LLFECNOBNOO(this Transform ANLKLKAINEO, Vector3 NNIDKMJGAJO, float FMPBJJMKCIG)
	{
		Vector3 localPosition = ANLKLKAINEO.localPosition;
		Vector3 zero = Vector3.zero;
		while (FMPBJJMKCIG > 0f)
		{
			FMPBJJMKCIG -= Time.deltaTime;
			zero.Set(UnityEngine.Random.Range(0f - NNIDKMJGAJO.x, NNIDKMJGAJO.x), UnityEngine.Random.Range(0f - NNIDKMJGAJO.y, NNIDKMJGAJO.y), UnityEngine.Random.Range(0f - NNIDKMJGAJO.z, NNIDKMJGAJO.z));
			ANLKLKAINEO.localPosition = localPosition + zero;
			yield return 0;
		}
		ANLKLKAINEO.localPosition = localPosition;
	}

	public static IEnumerator LLFECNOBNOO(this Transform ANLKLKAINEO, float NNIDKMJGAJO, float FMPBJJMKCIG)
	{
		return ANLKLKAINEO.LLFECNOBNOO(new Vector3(NNIDKMJGAJO, NNIDKMJGAJO, NNIDKMJGAJO), FMPBJJMKCIG);
	}

	public static IEnumerator AJKHHIKPFNL(float FMPBJJMKCIG)
	{
		while (FMPBJJMKCIG > 0f)
		{
			FMPBJJMKCIG -= Time.deltaTime;
			yield return 0;
		}
	}

	public static IEnumerator BKLDHELDMLH(HBJCHJHEMHC POEGDDBBBBH)
	{
		while (!POEGDDBBBBH())
		{
			yield return 0;
		}
	}

	public static float MELBODIIPKN(float FMPBJJMKCIG, float LLAEDBFNCCP, float BMIOECELGCA, float FOCNNHPGACO)
	{
		float num = BMIOECELGCA - LLAEDBFNCCP;
		float num2 = (Time.time + FMPBJJMKCIG * FOCNNHPGACO) * (Mathf.Abs(num) / FMPBJJMKCIG);
		if (num > 0f)
		{
			return LLAEDBFNCCP + Time.time - num * (float)Mathf.FloorToInt(Time.time / num);
		}
		return LLAEDBFNCCP - (Time.time - Mathf.Abs(num) * (float)Mathf.FloorToInt(num2 / Mathf.Abs(num)));
	}

	public static float MELBODIIPKN(float FMPBJJMKCIG, float LLAEDBFNCCP, float BMIOECELGCA)
	{
		return MELBODIIPKN(FMPBJJMKCIG, LLAEDBFNCCP, BMIOECELGCA, 0f);
	}

	public static Vector3 MELBODIIPKN(float FMPBJJMKCIG, Vector3 LLAEDBFNCCP, Vector3 BMIOECELGCA, float FOCNNHPGACO)
	{
		return Vector3.Lerp(LLAEDBFNCCP, BMIOECELGCA, MELBODIIPKN(FMPBJJMKCIG, 0f, 1f, FOCNNHPGACO));
	}

	public static Vector3 MELBODIIPKN(float FMPBJJMKCIG, Vector3 LLAEDBFNCCP, Vector3 BMIOECELGCA)
	{
		return Vector3.Lerp(LLAEDBFNCCP, BMIOECELGCA, MELBODIIPKN(FMPBJJMKCIG, 0f, 1f));
	}

	public static Quaternion MELBODIIPKN(float FMPBJJMKCIG, Quaternion LLAEDBFNCCP, Quaternion BMIOECELGCA, float FOCNNHPGACO)
	{
		return Quaternion.Lerp(LLAEDBFNCCP, BMIOECELGCA, MELBODIIPKN(FMPBJJMKCIG, 0f, 1f, FOCNNHPGACO));
	}

	public static Quaternion MELBODIIPKN(float FMPBJJMKCIG, Quaternion LLAEDBFNCCP, Quaternion BMIOECELGCA)
	{
		return Quaternion.Lerp(LLAEDBFNCCP, BMIOECELGCA, MELBODIIPKN(FMPBJJMKCIG, 0f, 1f));
	}

	public static float CIHOBCCBIGC(float FMPBJJMKCIG, float LLAEDBFNCCP, float BMIOECELGCA, float FOCNNHPGACO)
	{
		float num = (BMIOECELGCA - LLAEDBFNCCP) / 2f;
		return LLAEDBFNCCP + num + Mathf.Sin((Time.time + FMPBJJMKCIG * FOCNNHPGACO) / FMPBJJMKCIG * ((float)Math.PI * 2f)) * num;
	}

	public static float CIHOBCCBIGC(float FMPBJJMKCIG, float LLAEDBFNCCP, float BMIOECELGCA)
	{
		return CIHOBCCBIGC(FMPBJJMKCIG, LLAEDBFNCCP, BMIOECELGCA, 0f);
	}

	public static Vector3 CIHOBCCBIGC(float FMPBJJMKCIG, Vector3 LLAEDBFNCCP, Vector3 BMIOECELGCA, float FOCNNHPGACO)
	{
		return Vector3.Lerp(LLAEDBFNCCP, BMIOECELGCA, CIHOBCCBIGC(FMPBJJMKCIG, 0f, 1f, FOCNNHPGACO));
	}

	public static Vector3 CIHOBCCBIGC(float FMPBJJMKCIG, Vector3 LLAEDBFNCCP, Vector3 BMIOECELGCA)
	{
		return Vector3.Lerp(LLAEDBFNCCP, BMIOECELGCA, CIHOBCCBIGC(FMPBJJMKCIG, 0f, 1f));
	}

	public static Quaternion CIHOBCCBIGC(float FMPBJJMKCIG, Quaternion LLAEDBFNCCP, Quaternion BMIOECELGCA, float FOCNNHPGACO)
	{
		return Quaternion.Lerp(LLAEDBFNCCP, BMIOECELGCA, CIHOBCCBIGC(FMPBJJMKCIG, 0f, 1f, FOCNNHPGACO));
	}

	public static Quaternion CIHOBCCBIGC(float FMPBJJMKCIG, Quaternion LLAEDBFNCCP, Quaternion BMIOECELGCA)
	{
		return Quaternion.Lerp(LLAEDBFNCCP, BMIOECELGCA, CIHOBCCBIGC(FMPBJJMKCIG, 0f, 1f));
	}

	public static IEnumerator NEKLLODKJPO(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, AJLDDMLECNL LMGHDHGABOL)
	{
		float num = 0f;
		Vector3 position = ANLKLKAINEO.position;
		Vector3 vector = CAEMELGEOAE - position;
		while (num < FMPBJJMKCIG)
		{
			num = Mathf.MoveTowards(num, FMPBJJMKCIG, Time.deltaTime);
			if (ANLKLKAINEO == null)
			{
				break;
			}
			ANLKLKAINEO.position = position + vector * LMGHDHGABOL(num / FMPBJJMKCIG);
			yield return 0;
		}
		if (ANLKLKAINEO != null)
		{
			ANLKLKAINEO.position = CAEMELGEOAE;
		}
	}

	public static IEnumerator NEKLLODKJPO(this Transform ANLKLKAINEO, Vector3 CAEMELGEOAE, float FMPBJJMKCIG, BJCJEPIOBMA LMGHDHGABOL)
	{
		return ANLKLKAINEO.NEKLLODKJPO(CAEMELGEOAE, FMPBJJMKCIG, IAEACNKONMF.DKKKCFJGKCN(LMGHDHGABOL));
	}
}
