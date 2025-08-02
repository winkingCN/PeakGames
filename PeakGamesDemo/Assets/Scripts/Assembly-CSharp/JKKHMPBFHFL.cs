using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

internal class JKKHMPBFHFL : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class JDCFAEANMAO
	{
		internal Action FOGOHLLIMDJ;

		internal JKKHMPBFHFL PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			FOGOHLLIMDJ();
			PDAPIGLEPGC.BPGHLOEIJKN = false;
		}
	}

	private bool BPGHLOEIJKN;

	public override bool HPMMIAHGKBG
	{
		get
		{
			return BPGHLOEIJKN;
		}
	}

	public JKKHMPBFHFL(Action FOGOHLLIMDJ, System.Threading.ThreadPriority JCAPEOMBCIB = System.Threading.ThreadPriority.Normal)
	{
		JKKHMPBFHFL PDAPIGLEPGC = this;
		BPGHLOEIJKN = true;
		new Thread((ThreadStart)delegate
		{
			FOGOHLLIMDJ();
			PDAPIGLEPGC.BPGHLOEIJKN = false;
		}).Start(JCAPEOMBCIB);
	}
}
