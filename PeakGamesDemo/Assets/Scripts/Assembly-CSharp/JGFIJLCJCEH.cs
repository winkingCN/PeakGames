using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class JGFIJLCJCEH
{
	[CompilerGenerated]
	private sealed class AEANDDLHDDL
	{
		internal CanvasGroup CAEMELGEOAE;

		internal float AGFNGEFDHLA()
		{
			return CAEMELGEOAE.alpha;
		}

		internal void KDACLOKGNAM(float AMFCENFNAJJ)
		{
			CAEMELGEOAE.alpha = AMFCENFNAJJ;
		}
	}

	[CompilerGenerated]
	private sealed class GCLAPHEDKJH
	{
		internal Image CAEMELGEOAE;

		internal Color AGFNGEFDHLA()
		{
			return CAEMELGEOAE.color;
		}

		internal void KDACLOKGNAM(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}
	}

	[CompilerGenerated]
	private sealed class DNBMMNCIDOB
	{
		internal Image CAEMELGEOAE;

		internal Color AGFNGEFDHLA()
		{
			return CAEMELGEOAE.color;
		}

		internal void KDACLOKGNAM(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}
	}

	[CompilerGenerated]
	private sealed class NNFKCBODDJF
	{
		internal TextMeshPro CAEMELGEOAE;

		internal Color AGFNGEFDHLA()
		{
			return CAEMELGEOAE.color;
		}

		internal void KDACLOKGNAM(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}
	}

	public static Tweener GGJNLNJGKCO(this CanvasGroup CAEMELGEOAE, float IPCJMEJMGHB, float FMPBJJMKCIG)
	{
		return DOTween.To(() => CAEMELGEOAE.alpha, delegate(float AMFCENFNAJJ)
		{
			CAEMELGEOAE.alpha = AMFCENFNAJJ;
		}, IPCJMEJMGHB, FMPBJJMKCIG).SetTarget(CAEMELGEOAE);
	}

	public static Tweener BNAKJMAPECI(this Image CAEMELGEOAE, Color IPCJMEJMGHB, float FMPBJJMKCIG)
	{
		return DOTween.To(() => CAEMELGEOAE.color, delegate(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}, IPCJMEJMGHB, FMPBJJMKCIG).SetTarget(CAEMELGEOAE);
	}

	public static Tweener GGJNLNJGKCO(this Image CAEMELGEOAE, float IPCJMEJMGHB, float FMPBJJMKCIG)
	{
		return DOTween.ToAlpha(() => CAEMELGEOAE.color, delegate(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}, IPCJMEJMGHB, FMPBJJMKCIG).SetTarget(CAEMELGEOAE);
	}

	public static Tweener OCHJNKODKNO(this TextMeshPro CAEMELGEOAE, float IPCJMEJMGHB, float FMPBJJMKCIG)
	{
		return DOTween.ToAlpha(() => CAEMELGEOAE.color, delegate(Color AMFCENFNAJJ)
		{
			CAEMELGEOAE.color = AMFCENFNAJJ;
		}, IPCJMEJMGHB, FMPBJJMKCIG).SetTarget(CAEMELGEOAE);
	}
}
