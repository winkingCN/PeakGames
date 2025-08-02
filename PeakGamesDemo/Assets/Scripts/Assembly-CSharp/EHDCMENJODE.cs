using System.Collections;
using UnityEngine;

internal class EHDCMENJODE<T> where T : struct, KPCMHKDGLFE
{
	protected MonoBehaviour DAHDLCDIKGH;

	protected IEnumerator GBMNDNBEBHM;

	private static IEnumerator BAMKBCHHLGP(T MGJNDLEMHOA)
	{
		if (MGJNDLEMHOA.KBDJIAJKPOG())
		{
			float num = 0f;
			while (num < MGJNDLEMHOA.FMPBJJMKCIG)
			{
				num += ((!MGJNDLEMHOA.AFCNLNOBLKK) ? Time.deltaTime : Time.unscaledDeltaTime);
				float dCKGCIEACAO = Mathf.Clamp01(num / MGJNDLEMHOA.FMPBJJMKCIG);
				MGJNDLEMHOA.POCKOBFHALC(dCKGCIEACAO);
				yield return null;
			}
			MGJNDLEMHOA.POCKOBFHALC(1f);
		}
	}

	public void DIOELAHNLKJ(MonoBehaviour PKOIEGFOAPO)
	{
		DAHDLCDIKGH = PKOIEGFOAPO;
	}

	public void CMGDHHOBKPG(T GCLINOAJKIH)
	{
		if (DAHDLCDIKGH == null)
		{
			Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
			return;
		}
		BDLLHNMFECH();
		if (!DAHDLCDIKGH.gameObject.activeInHierarchy)
		{
			GCLINOAJKIH.POCKOBFHALC(1f);
			return;
		}
		GBMNDNBEBHM = BAMKBCHHLGP(GCLINOAJKIH);
		DAHDLCDIKGH.StartCoroutine(GBMNDNBEBHM);
	}

	public void BDLLHNMFECH()
	{
		if (GBMNDNBEBHM != null)
		{
			DAHDLCDIKGH.StopCoroutine(GBMNDNBEBHM);
			GBMNDNBEBHM = null;
		}
	}
}
