using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using DG.Tweening;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class BlasterCollectAnimation : MonoBehaviour
{
	public SpriteRenderer CurrentSpriteRenderer;

	public SpriteRenderer ShadowSpriteRenderer;

	public Transform Container;

	private Sequence BADHDINHKND;

	private CollectorItem EDHJCPDBBIB;

	private Vector3 NLHJNNLLFDI;

	private Vector3 ILKAECCIAPG;

	private bool EMFCNFMLOIF;

	private bool DBGBDFCPKCP;

	private float NBDALDOHDDF;

	private float KPAAOGKOFFJ;

	private float PHEBPECJPMA;

	private float DOAKDOGFPPL;

	private int JGFFOBIOJDM;

	private int KKCPOOALFAD;

	private int JKPMGCHDMMC;

	public Cell HLOBGGHBOIM { get; private set; }

	public Vector3 NPBPGCMMLNE { get; private set; }

	public void StartAnimation(NOALGNJECAD HBBIFNLDKPO, Vector3 NBOLDLDHNGE, Vector3 NBLHKHMMCKB, CollectorItem CAMFPAAGCIC, Cell MFENMHPPAHD, bool LIBMFHBHMFK, CKKKELDIOLD EINEPILKPIH)
	{
		if (BADHDINHKND != null)
		{
			BADHDINHKND.Kill();
		}
		BADHDINHKND = DOTween.Sequence();
		NLHJNNLLFDI = NBOLDLDHNGE;
		NPBPGCMMLNE = NBLHKHMMCKB;
		EDHJCPDBBIB = CAMFPAAGCIC;
		HLOBGGHBOIM = MFENMHPPAHD;
		EMFCNFMLOIF = LIBMFHBHMFK;
		ShadowSpriteRenderer.enabled = false;
		ShadowSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
		CAMFPAAGCIC.StartCollectingItem();
		CurrentSpriteRenderer.enabled = true;
		CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.GetGoalSpriteByItemType(HBBIFNLDKPO);
		CurrentSpriteRenderer.sortingOrder = EINEPILKPIH.BHIJCAOHDCM;
		CurrentSpriteRenderer.sortingLayerID = EINEPILKPIH.MMFFDANAEEI;
		Container.transform.position = NBOLDLDHNGE;
		Container.transform.localScale = Vector3.one;
		BlasterCollectManager.Instance.Register(this, EDHJCPDBBIB.CollectorId);
	}

	public void InsertDelays(MCLFAHIMDIF FMFABAKPMLB, Cell FKGDPGLNJHA, int AIILDOGHINA, int FGFEGHLBFNP)
	{
		DBGBDFCPKCP = FMFABAKPMLB.NPGABPICIAD;
		int num = FMFABAKPMLB.FGMDLNBGFJB(HLOBGGHBOIM.X);
		KPAAOGKOFFJ = FKGDPGLNJHA.Y - num;
		NBDALDOHDDF = FKGDPGLNJHA.X - FMFABAKPMLB.DGMLPAAGIJF;
		JGFFOBIOJDM = AIILDOGHINA;
		JKPMGCHDMMC = FGFEGHLBFNP;
		if (!DBGBDFCPKCP)
		{
			NBDALDOHDDF = (float)(FMFABAKPMLB.BFBEDEPAOLB - FMFABAKPMLB.DGMLPAAGIJF) - NBDALDOHDDF;
		}
		KPAAOGKOFFJ = FKGDPGLNJHA.Y - FMFABAKPMLB.GIFMPDOHNCL;
		if (EMFCNFMLOIF)
		{
			CurrentSpriteRenderer.sortingOrder = 2000 + JGFFOBIOJDM;
			ShadowSpriteRenderer.sortingOrder = 2000;
		}
		else
		{
			KKCPOOALFAD = CurrentSpriteRenderer.sortingOrder + 1600;
		}
		PlayAnimation();
	}

	public void PlayAnimation()
	{
		if (EMFCNFMLOIF)
		{
			BADHDINHKND = EFLJMGBJEFF();
		}
		else
		{
			BADHDINHKND = HENGFPAHHGN();
		}
		BADHDINHKND.OnComplete(delegate
		{
			CurrentSpriteRenderer.enabled = false;
			Reset();
			EDHJCPDBBIB.OnItemCollectCompleted();
		});
	}

	private Sequence HENGFPAHHGN()
	{
		Vector3 position = Container.transform.position;
		Sequence sequence = DOTween.Sequence();
		sequence.SetEase(Ease.Linear);
		int num = 13;
		float num2 = 2.2f + KPAAOGKOFFJ * 1f;
		Vector3 vector = position;
		vector.y -= num2;
		float num3 = num2 / (float)num;
		Vector3 vector2 = NPBPGCMMLNE - vector;
		Vector3 vector3 = vector2 * 0.2f;
		Vector3 iLKAECCIAPG = vector + vector3;
		iLKAECCIAPG.y -= vector2.magnitude * 0.5f;
		ILKAECCIAPG = iLKAECCIAPG;
		float num4 = NBDALDOHDDF * 0.04f;
		sequence.Insert(num4, Container.transform.DOMoveY(vector.y, num3).SetEase(Ease.Linear));
		sequence.InsertCallback(0.05f, delegate
		{
			CurrentSpriteRenderer.sortingOrder = KKCPOOALFAD;
			ShadowSpriteRenderer.sortingOrder = KKCPOOALFAD - (int)KPAAOGKOFFJ * 100 - 1;
		});
		sequence.InsertCallback(num4, delegate
		{
			ShadowSpriteRenderer.enabled = true;
			ShadowSpriteRenderer.DOColor(new Color(0f, 0f, 0f, 11f / 51f), 0.1f);
		});
		if (vector2.magnitude < 3f)
		{
			num -= 2;
		}
		int num5 = 20;
		Vector3[] array = new Vector3[num5];
		float[] array2 = new float[num5];
		for (int i = 1; i <= num5; i++)
		{
			float lLIEHCKNJEM = (float)i / (float)num5;
			float lLIEHCKNJEM2 = (float)(i - 1) / (float)num5;
			Vector3 vector4 = OICPCAPKFPI(vector, ILKAECCIAPG, NPBPGCMMLNE, lLIEHCKNJEM);
			Vector3 b = OICPCAPKFPI(vector, ILKAECCIAPG, NPBPGCMMLNE, lLIEHCKNJEM2);
			float num6 = Vector3.Distance(vector4, b);
			array2[i - 1] = num6 / (float)num;
			array[i - 1] = vector4;
		}
		float num7 = 0f;
		for (int j = 0; j < num5; j++)
		{
			sequence.Insert(num3 + num4 + num7, Container.transform.DOMove(array[j], array2[j]).SetEase(Ease.Linear));
			num7 += array2[j];
		}
		sequence.Insert(num4 + num3, Container.transform.DOScale(0.8f, num7).SetEase(Ease.InQuad));
		return sequence;
	}

	private Sequence EFLJMGBJEFF()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.SetEase(Ease.Linear);
		Vector3 vector = NPBPGCMMLNE - NLHJNNLLFDI;
		Vector3 vector2 = vector * 0.2f;
		Vector3 eLEIAMCGPIM = NLHJNNLLFDI + vector2;
		eLEIAMCGPIM.y -= vector.magnitude;
		int num = JKPMGCHDMMC - JGFFOBIOJDM - 1;
		float num2 = (float)num * 0.1f;
		sequence.InsertCallback(num2, delegate
		{
			ShadowSpriteRenderer.enabled = true;
			ShadowSpriteRenderer.DOColor(new Color(0f, 0f, 0f, 11f / 51f), 0.1f);
		});
		int num3 = 13;
		int num4 = 20;
		Vector3[] array = new Vector3[num4];
		float[] array2 = new float[num4];
		for (int i = 1; i <= num4; i++)
		{
			float lLIEHCKNJEM = (float)i / (float)num4;
			float lLIEHCKNJEM2 = (float)(i - 1) / (float)num4;
			Vector3 vector3 = OICPCAPKFPI(NLHJNNLLFDI, eLEIAMCGPIM, NPBPGCMMLNE, lLIEHCKNJEM);
			Vector3 b = OICPCAPKFPI(NLHJNNLLFDI, eLEIAMCGPIM, NPBPGCMMLNE, lLIEHCKNJEM2);
			float num5 = Vector3.Distance(vector3, b);
			array2[i - 1] = num5 / (float)num3;
			array[i - 1] = vector3;
		}
		float num6 = 0f;
		for (int j = 0; j < num4; j++)
		{
			sequence.Insert(num2 + num6, Container.transform.DOMove(array[j], array2[j]).SetEase(Ease.Linear));
			num6 += array2[j];
		}
		sequence.Insert(num2, Container.transform.DOScale(0.8f, num6).SetEase(Ease.InQuad));
		return sequence;
	}

	private void Reset()
	{
		CurrentSpriteRenderer.sortingOrder = 2000;
		if (BADHDINHKND != null)
		{
			BADHDINHKND.Kill();
		}
		base.gameObject.MEJPNNFDEBD();
	}

	private Vector3 OICPCAPKFPI(Vector3 LLAEDBFNCCP, Vector3 ELEIAMCGPIM, Vector3 BMIOECELGCA, float LLIEHCKNJEM)
	{
		Vector3 zero = Vector3.zero;
		float num = 1f - LLIEHCKNJEM;
		zero.x = LLAEDBFNCCP.x * num * num + ELEIAMCGPIM.x * 2f * num * LLIEHCKNJEM + BMIOECELGCA.x * LLIEHCKNJEM * LLIEHCKNJEM;
		zero.y = LLAEDBFNCCP.y * num * num + ELEIAMCGPIM.y * 2f * num * LLIEHCKNJEM + BMIOECELGCA.y * LLIEHCKNJEM * LLIEHCKNJEM;
		return zero;
	}

	[CompilerGenerated]
	private void KMBOCKAKCCC()
	{
		CurrentSpriteRenderer.enabled = false;
		Reset();
		EDHJCPDBBIB.OnItemCollectCompleted();
	}

	[CompilerGenerated]
	private void BJPLPMONHDD()
	{
		CurrentSpriteRenderer.sortingOrder = KKCPOOALFAD;
		ShadowSpriteRenderer.sortingOrder = KKCPOOALFAD - (int)KPAAOGKOFFJ * 100 - 1;
	}

	[CompilerGenerated]
	private void FIKNPHKIGDM()
	{
		ShadowSpriteRenderer.enabled = true;
		ShadowSpriteRenderer.DOColor(new Color(0f, 0f, 0f, 11f / 51f), 0.1f);
	}

	[CompilerGenerated]
	private void FMHPCCAPADD()
	{
		ShadowSpriteRenderer.enabled = true;
		ShadowSpriteRenderer.DOColor(new Color(0f, 0f, 0f, 11f / 51f), 0.1f);
	}
}
