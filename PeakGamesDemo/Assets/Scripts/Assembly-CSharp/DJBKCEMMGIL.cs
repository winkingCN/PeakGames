using System;
using System.Collections;

public class DJBKCEMMGIL : EventArgs
{
	private GOCEGGDFJIE DJPNBGABBOI;

	private IList AHMPKBNEEEE;

	private IList NJNFMENPPGA;

	private int NAOCCDBDNJL = -1;

	private int BOIONIHBHPG = -1;

	public GOCEGGDFJIE JGADHINFALF
	{
		get
		{
			return DJPNBGABBOI;
		}
	}

	public IList LPDHNBMPEHG
	{
		get
		{
			return AHMPKBNEEEE;
		}
	}

	public IList PILHOPMLGJK
	{
		get
		{
			return NJNFMENPPGA;
		}
	}

	public int HABMCDGEDJO
	{
		get
		{
			return NAOCCDBDNJL;
		}
	}

	public int JNGKJCONEAE
	{
		get
		{
			return BOIONIHBHPG;
		}
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Reset)
		{
			throw new ArgumentException("action");
		}
		OLHDLFJFPDO(GPLIOLJFDPM, null, -1);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, object MDPMHLNPLMK)
	{
		if (GPLIOLJFDPM != 0 && GPLIOLJFDPM != GOCEGGDFJIE.Remove && GPLIOLJFDPM != GOCEGGDFJIE.Reset)
		{
			throw new ArgumentException("action");
		}
		if (GPLIOLJFDPM == GOCEGGDFJIE.Reset)
		{
			if (MDPMHLNPLMK != null)
			{
				throw new ArgumentException("action");
			}
			OLHDLFJFPDO(GPLIOLJFDPM, null, -1);
		}
		else
		{
			JNJBFOHNMGB(GPLIOLJFDPM, new object[1] { MDPMHLNPLMK }, -1);
		}
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, object MDPMHLNPLMK, int EHJNMODJEAN)
	{
		if (GPLIOLJFDPM != 0 && GPLIOLJFDPM != GOCEGGDFJIE.Remove && GPLIOLJFDPM != GOCEGGDFJIE.Reset)
		{
			throw new ArgumentException("action");
		}
		if (GPLIOLJFDPM == GOCEGGDFJIE.Reset)
		{
			if (MDPMHLNPLMK != null)
			{
				throw new ArgumentException("action");
			}
			if (EHJNMODJEAN != -1)
			{
				throw new ArgumentException("action");
			}
			OLHDLFJFPDO(GPLIOLJFDPM, null, -1);
		}
		else
		{
			JNJBFOHNMGB(GPLIOLJFDPM, new object[1] { MDPMHLNPLMK }, EHJNMODJEAN);
		}
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList FMMJCKEKJHO)
	{
		if (GPLIOLJFDPM != 0 && GPLIOLJFDPM != GOCEGGDFJIE.Remove && GPLIOLJFDPM != GOCEGGDFJIE.Reset)
		{
			throw new ArgumentException("action");
		}
		if (GPLIOLJFDPM == GOCEGGDFJIE.Reset)
		{
			if (FMMJCKEKJHO != null)
			{
				throw new ArgumentException("action");
			}
			OLHDLFJFPDO(GPLIOLJFDPM, null, -1);
		}
		else
		{
			if (FMMJCKEKJHO == null)
			{
				throw new ArgumentNullException("changedItems");
			}
			JNJBFOHNMGB(GPLIOLJFDPM, FMMJCKEKJHO, -1);
		}
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList FMMJCKEKJHO, int JDPAKJDENMO)
	{
		if (GPLIOLJFDPM != 0 && GPLIOLJFDPM != GOCEGGDFJIE.Remove && GPLIOLJFDPM != GOCEGGDFJIE.Reset)
		{
			throw new ArgumentException("action");
		}
		if (GPLIOLJFDPM == GOCEGGDFJIE.Reset)
		{
			if (FMMJCKEKJHO != null)
			{
				throw new ArgumentException("action");
			}
			if (JDPAKJDENMO != -1)
			{
				throw new ArgumentException("action");
			}
			OLHDLFJFPDO(GPLIOLJFDPM, null, -1);
		}
		else
		{
			if (FMMJCKEKJHO == null)
			{
				throw new ArgumentNullException("changedItems");
			}
			if (JDPAKJDENMO < -1)
			{
				throw new ArgumentException("startingIndex");
			}
			JNJBFOHNMGB(GPLIOLJFDPM, FMMJCKEKJHO, JDPAKJDENMO);
		}
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, object GANOIMIHIDB, object MFLAFJACJPO)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Replace)
		{
			throw new ArgumentException("action");
		}
		IANAOPKEJMD(GPLIOLJFDPM, new object[1] { GANOIMIHIDB }, new object[1] { MFLAFJACJPO }, -1, -1);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, object GANOIMIHIDB, object MFLAFJACJPO, int EHJNMODJEAN)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Replace)
		{
			throw new ArgumentException("action");
		}
		IANAOPKEJMD(GPLIOLJFDPM, new object[1] { GANOIMIHIDB }, new object[1] { MFLAFJACJPO }, EHJNMODJEAN, EHJNMODJEAN);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE, IList BPDJPDGIGPH)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Replace)
		{
			throw new ArgumentException("action");
		}
		if (CGHHOLLIOAE == null)
		{
			throw new ArgumentNullException("newItems");
		}
		if (BPDJPDGIGPH == null)
		{
			throw new ArgumentNullException("oldItems");
		}
		IANAOPKEJMD(GPLIOLJFDPM, CGHHOLLIOAE, BPDJPDGIGPH, -1, -1);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE, IList BPDJPDGIGPH, int JDPAKJDENMO)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Replace)
		{
			throw new ArgumentException("action");
		}
		if (CGHHOLLIOAE == null)
		{
			throw new ArgumentNullException("newItems");
		}
		if (BPDJPDGIGPH == null)
		{
			throw new ArgumentNullException("oldItems");
		}
		IANAOPKEJMD(GPLIOLJFDPM, CGHHOLLIOAE, BPDJPDGIGPH, JDPAKJDENMO, JDPAKJDENMO);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, object MDPMHLNPLMK, int EHJNMODJEAN, int EEHIGAABDOB)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Move)
		{
			throw new ArgumentException("action");
		}
		if (EHJNMODJEAN < 0)
		{
			throw new ArgumentException("index");
		}
		object[] array = new object[1] { MDPMHLNPLMK };
		IANAOPKEJMD(GPLIOLJFDPM, array, array, EHJNMODJEAN, EEHIGAABDOB);
	}

	public DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList FMMJCKEKJHO, int EHJNMODJEAN, int EEHIGAABDOB)
	{
		if (GPLIOLJFDPM != GOCEGGDFJIE.Move)
		{
			throw new ArgumentException("action");
		}
		if (EHJNMODJEAN < 0)
		{
			throw new ArgumentException("index");
		}
		IANAOPKEJMD(GPLIOLJFDPM, FMMJCKEKJHO, FMMJCKEKJHO, EHJNMODJEAN, EEHIGAABDOB);
	}

	internal DJBKCEMMGIL(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE, IList BPDJPDGIGPH, int GLGHAMEAFFK, int EEHIGAABDOB)
	{
		DJPNBGABBOI = GPLIOLJFDPM;
		AHMPKBNEEEE = ((CGHHOLLIOAE != null) ? new HPHCOEDKNIC(CGHHOLLIOAE) : null);
		NJNFMENPPGA = ((BPDJPDGIGPH != null) ? new HPHCOEDKNIC(BPDJPDGIGPH) : null);
		NAOCCDBDNJL = GLGHAMEAFFK;
		BOIONIHBHPG = EEHIGAABDOB;
	}

	private void JNJBFOHNMGB(GOCEGGDFJIE GPLIOLJFDPM, IList FMMJCKEKJHO, int JDPAKJDENMO)
	{
		switch (GPLIOLJFDPM)
		{
		case GOCEGGDFJIE.Add:
			OLHDLFJFPDO(GPLIOLJFDPM, FMMJCKEKJHO, JDPAKJDENMO);
			break;
		case GOCEGGDFJIE.Remove:
			HENFKLANFIK(GPLIOLJFDPM, FMMJCKEKJHO, JDPAKJDENMO);
			break;
		}
	}

	private void OLHDLFJFPDO(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE, int NCMBKAJIJNK)
	{
		DJPNBGABBOI = GPLIOLJFDPM;
		AHMPKBNEEEE = ((CGHHOLLIOAE != null) ? new HPHCOEDKNIC(CGHHOLLIOAE) : null);
		NAOCCDBDNJL = NCMBKAJIJNK;
	}

	private void HENFKLANFIK(GOCEGGDFJIE GPLIOLJFDPM, IList BPDJPDGIGPH, int NAIALNKCGDE)
	{
		DJPNBGABBOI = GPLIOLJFDPM;
		NJNFMENPPGA = ((BPDJPDGIGPH != null) ? new HPHCOEDKNIC(BPDJPDGIGPH) : null);
		BOIONIHBHPG = NAIALNKCGDE;
	}

	private void IANAOPKEJMD(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE, IList BPDJPDGIGPH, int JDPAKJDENMO, int NAIALNKCGDE)
	{
		OLHDLFJFPDO(GPLIOLJFDPM, CGHHOLLIOAE, JDPAKJDENMO);
		HENFKLANFIK(GPLIOLJFDPM, BPDJPDGIGPH, NAIALNKCGDE);
	}
}
