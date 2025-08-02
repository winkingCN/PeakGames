using System.Runtime.InteropServices;
using caravan.protobuf.messages;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct KHMIKAEKHIG
{
	public int LGCFDCILJFO { get; private set; }

	public int FDHJCJEBGMJ { get; private set; }

	public int PCJLEBBNEKL { get; private set; }

	public string INMJKIDMBKB { get; private set; }

	public KHMIKAEKHIG(string GMMBKHKAIHC, int NNIDKMJGAJO, int LPJLCJKABDC, int AIILDOGHINA)
	{
		this = default(KHMIKAEKHIG);
		INMJKIDMBKB = GMMBKHKAIHC;
		LGCFDCILJFO = NNIDKMJGAJO;
		PCJLEBBNEKL = LPJLCJKABDC;
		FDHJCJEBGMJ = AIILDOGHINA;
	}

	public KHMIKAEKHIG(RemoteCoins FLNGDNIMPMO)
	{
		this = default(KHMIKAEKHIG);
		INMJKIDMBKB = FLNGDNIMPMO.Package;
		LGCFDCILJFO = FLNGDNIMPMO.Amount;
		PCJLEBBNEKL = FLNGDNIMPMO.LifeTime;
		FDHJCJEBGMJ = FLNGDNIMPMO.No;
	}
}
