using I2.Loc;
using UnityEngine;

public class DMJIGBNGAOI : global::BCFJOAHKHMI<AudioSource>
{
	static DMJIGBNGAOI()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new DMJIGBNGAOI());
	}

	public override string CILJKDELPFP()
	{
		return "AudioSource";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.AudioClip;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override bool BPGIAEEGAHG()
	{
		return false;
	}

	public override bool EPEEEAJJCEM()
	{
		return false;
	}

	public override bool ILELPLPENPA()
	{
		return false;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		AudioSource audioSource = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = ((!audioSource.clip) ? string.Empty : audioSource.clip.name);
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		AudioSource audioSource = LDGBMPEMHEI(HNKFIOBAHOB);
		bool flag = (audioSource.isPlaying || audioSource.loop) && Application.isPlaying;
		AudioClip clip = audioSource.clip;
		AudioClip audioClip = HNKFIOBAHOB.FindTranslatedObject<AudioClip>(JJMAEFKBEIL);
		if (clip != audioClip)
		{
			audioSource.clip = audioClip;
		}
		if (flag && (bool)audioSource.clip)
		{
			audioSource.Play();
		}
	}
}
