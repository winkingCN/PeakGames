using System;

public class JEMNCGMEABF : IGMAJHKIIPK
{
	private readonly byte[] IKNCPEPOKGJ;

	public JEMNCGMEABF(byte[] IKNCPEPOKGJ)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new ArgumentNullException("key");
		}
		this.IKNCPEPOKGJ = (byte[])IKNCPEPOKGJ.Clone();
	}

	public JEMNCGMEABF(byte[] IKNCPEPOKGJ, int EDKGBLMGFOO, int JJBNFEJMIPJ)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new ArgumentNullException("key");
		}
		if (EDKGBLMGFOO < 0 || EDKGBLMGFOO > IKNCPEPOKGJ.Length)
		{
			throw new ArgumentOutOfRangeException("keyOff");
		}
		if (JJBNFEJMIPJ < 0 || EDKGBLMGFOO + JJBNFEJMIPJ > IKNCPEPOKGJ.Length)
		{
			throw new ArgumentOutOfRangeException("keyLen");
		}
		this.IKNCPEPOKGJ = new byte[JJBNFEJMIPJ];
		Array.Copy(IKNCPEPOKGJ, EDKGBLMGFOO, this.IKNCPEPOKGJ, 0, JJBNFEJMIPJ);
	}

	public byte[] MEGBFHFMBFI()
	{
		return (byte[])IKNCPEPOKGJ.Clone();
	}
}
