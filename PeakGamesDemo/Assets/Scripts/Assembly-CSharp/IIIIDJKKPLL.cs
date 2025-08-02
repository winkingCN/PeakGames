using System;
using System.Collections.Generic;

public class IIIIDJKKPLL
{
	private struct PIMBALHBMLM
	{
		public readonly GNGKKPOGGGM PNGIFDAMIII;

		public readonly GNGKKPOGGGM DDJLCPAKEDD;

		public PIMBALHBMLM(GNGKKPOGGGM PNGIFDAMIII, GNGKKPOGGGM DDJLCPAKEDD)
		{
			this.PNGIFDAMIII = PNGIFDAMIII;
			this.DDJLCPAKEDD = DDJLCPAKEDD;
		}

		public override string ToString()
		{
			return PNGIFDAMIII.IOCMOCCFALN + "->" + DDJLCPAKEDD.IOCMOCCFALN;
		}
	}

	private class OFPMBCPHLNC : IEqualityComparer<PIMBALHBMLM>
	{
		internal static readonly OFPMBCPHLNC GABGKBAKHDP = new OFPMBCPHLNC();

		bool IEqualityComparer<PIMBALHBMLM>.Equals(PIMBALHBMLM AMFCENFNAJJ, PIMBALHBMLM CNLILOEEBOJ)
		{
			return object.ReferenceEquals(AMFCENFNAJJ.PNGIFDAMIII, CNLILOEEBOJ.PNGIFDAMIII) && object.ReferenceEquals(AMFCENFNAJJ.DDJLCPAKEDD, CNLILOEEBOJ.DDJLCPAKEDD);
		}

		int IEqualityComparer<PIMBALHBMLM>.GetHashCode(PIMBALHBMLM NEMEKIOEOLC)
		{
			int hashCode = NEMEKIOEOLC.PNGIFDAMIII.GetHashCode();
			return ((hashCode << 5) + hashCode) ^ NEMEKIOEOLC.DDJLCPAKEDD.GetHashCode();
		}
	}

	internal KGMHJGFNPFC DCMDAJJBNAI;

	private readonly Dictionary<PIMBALHBMLM, float> LLFPCEOPLDI = new Dictionary<PIMBALHBMLM, float>(OFPMBCPHLNC.GABGKBAKHDP);

	internal float FOMAIIHKNPM;

	public KGMHJGFNPFC NKJHFDKAPIE
	{
		get
		{
			return DCMDAJJBNAI;
		}
	}

	public float BBCHKKABLIN
	{
		get
		{
			return FOMAIIHKNPM;
		}
		set
		{
			FOMAIIHKNPM = value;
		}
	}

	public IIIIDJKKPLL(KGMHJGFNPFC DCMDAJJBNAI)
	{
		if (DCMDAJJBNAI == null)
		{
			throw new ArgumentException("skeletonData cannot be null.");
		}
		this.DCMDAJJBNAI = DCMDAJJBNAI;
	}

	public void BCGMMBBFMPJ(string NAHAKPGODNN, string GCBEKCAEAAM, float FMPBJJMKCIG)
	{
		GNGKKPOGGGM gNGKKPOGGGM = DCMDAJJBNAI.NELKDOOJCCD(NAHAKPGODNN);
		if (gNGKKPOGGGM == null)
		{
			throw new ArgumentException("Animation not found: " + NAHAKPGODNN);
		}
		GNGKKPOGGGM gNGKKPOGGGM2 = DCMDAJJBNAI.NELKDOOJCCD(GCBEKCAEAAM);
		if (gNGKKPOGGGM2 == null)
		{
			throw new ArgumentException("Animation not found: " + GCBEKCAEAAM);
		}
		BCGMMBBFMPJ(gNGKKPOGGGM, gNGKKPOGGGM2, FMPBJJMKCIG);
	}

	public void BCGMMBBFMPJ(GNGKKPOGGGM LLAEDBFNCCP, GNGKKPOGGGM BMIOECELGCA, float FMPBJJMKCIG)
	{
		if (LLAEDBFNCCP == null)
		{
			throw new ArgumentNullException("from", "from cannot be null.");
		}
		if (BMIOECELGCA == null)
		{
			throw new ArgumentNullException("to", "to cannot be null.");
		}
		PIMBALHBMLM key = new PIMBALHBMLM(LLAEDBFNCCP, BMIOECELGCA);
		LLFPCEOPLDI.Remove(key);
		LLFPCEOPLDI.Add(key, FMPBJJMKCIG);
	}

	public float PJPAKPDIAFL(GNGKKPOGGGM LLAEDBFNCCP, GNGKKPOGGGM BMIOECELGCA)
	{
		if (LLAEDBFNCCP == null)
		{
			throw new ArgumentNullException("from", "from cannot be null.");
		}
		if (BMIOECELGCA == null)
		{
			throw new ArgumentNullException("to", "to cannot be null.");
		}
		PIMBALHBMLM key = new PIMBALHBMLM(LLAEDBFNCCP, BMIOECELGCA);
		float value;
		if (LLFPCEOPLDI.TryGetValue(key, out value))
		{
			return value;
		}
		return FOMAIIHKNPM;
	}
}
