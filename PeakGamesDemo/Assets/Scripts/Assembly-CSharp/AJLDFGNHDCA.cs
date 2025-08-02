using Org.BouncyCastle.Crypto;

internal class AJLDFGNHDCA
{
	internal static void OONDALLFPOP(bool CFGGBONGJNP, string NOIOHIPHFHA)
	{
		if (CFGGBONGJNP)
		{
			throw new DataLengthException(NOIOHIPHFHA);
		}
	}

	internal static void OONDALLFPOP(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN, string NOIOHIPHFHA)
	{
		if (JBAJPGIAPFF + NBEDPKHALCN > GHPCHPOHELF.Length)
		{
			throw new DataLengthException(NOIOHIPHFHA);
		}
	}

	internal static void KLPNFGNKNKB(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN, string NOIOHIPHFHA)
	{
		if (JBAJPGIAPFF + NBEDPKHALCN > GHPCHPOHELF.Length)
		{
			throw new OutputLengthException(NOIOHIPHFHA);
		}
	}
}
