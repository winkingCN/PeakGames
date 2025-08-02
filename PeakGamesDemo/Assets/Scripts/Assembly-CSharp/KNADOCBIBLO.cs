using System;

public class KNADOCBIBLO : JEMNCGMEABF
{
	private readonly int DFKIEEIDJNM;

	public int IPMOKLGGJIB
	{
		get
		{
			return DFKIEEIDJNM;
		}
	}

	public KNADOCBIBLO(byte[] IKNCPEPOKGJ, int DFKIEEIDJNM)
		: base(IKNCPEPOKGJ)
	{
		if (IKNCPEPOKGJ.Length > 255)
		{
			throw new ArgumentException("RC5 key length can be no greater than 255");
		}
		this.DFKIEEIDJNM = DFKIEEIDJNM;
	}
}
