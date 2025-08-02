using System;

internal class FIMJEOPEECH : IMFLJFMMNIH
{
	private readonly OHPHNNNHCOO FLHHMPBBBJG;

	internal FIMJEOPEECH(OHPHNNNHCOO FLHHMPBBBJG)
	{
		this.FLHHMPBBBJG = FLHHMPBBBJG;
	}

	public byte[] EBECCJFHNOE()
	{
		return FLHHMPBBBJG.HMJHAKCMGHC();
	}

	public int EBECCJFHNOE(byte[] IPPHCKILFOA, int IBNDGNOIEEF)
	{
		byte[] array = EBECCJFHNOE();
		Array.Copy(array, 0, IPPHCKILFOA, IBNDGNOIEEF, array.Length);
		return array.Length;
	}
}
