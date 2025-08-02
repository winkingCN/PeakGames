using System;
using Org.BouncyCastle.Crypto;

public class JMJGBCGFHMM : IEKIBBAKJDP
{
	private OJGBFLKAPOB MFMIFDMEPPO;

	private CHCELGDKEJG BOFHHECPKNF;

	private bool CDOHJGCEGAJ;

	private FBIJJFGLKMK JHAINHBMFDI;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return MFMIFDMEPPO.GBHNDFALCDC().KFKMEPMEBND + "/RFC3211Wrap";
		}
	}

	public JMJGBCGFHMM(JMPFLJGHAIM MFMIFDMEPPO)
	{
		this.MFMIFDMEPPO = new OJGBFLKAPOB(MFMIFDMEPPO);
	}

	public virtual void DIOELAHNLKJ(bool CDOHJGCEGAJ, IGMAJHKIIPK BOFHHECPKNF)
	{
		this.CDOHJGCEGAJ = CDOHJGCEGAJ;
		if (BOFHHECPKNF is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)BOFHHECPKNF;
			JHAINHBMFDI = mDAKJDOFCEP.IPFKDIJBGIM;
			this.BOFHHECPKNF = (CHCELGDKEJG)mDAKJDOFCEP.KPJHHAAOFOH;
			return;
		}
		if (CDOHJGCEGAJ)
		{
			JHAINHBMFDI = new FBIJJFGLKMK();
		}
		this.BOFHHECPKNF = (CHCELGDKEJG)BOFHHECPKNF;
	}

	public virtual byte[] LFAFFAHKPCD(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (!CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("not set for wrapping");
		}
		MFMIFDMEPPO.DIOELAHNLKJ(true, BOFHHECPKNF);
		int num = MFMIFDMEPPO.BDIGGHEPIIP();
		byte[] array = ((DBGBBFPPDCE + 4 >= num * 2) ? new byte[((DBGBBFPPDCE + 4) % num != 0) ? (((DBGBBFPPDCE + 4) / num + 1) * num) : (DBGBBFPPDCE + 4)] : new byte[num * 2]);
		array[0] = (byte)DBGBBFPPDCE;
		array[1] = (byte)(~AIFKJBMJOMK[ELICNEDIBGB]);
		array[2] = (byte)(~AIFKJBMJOMK[ELICNEDIBGB + 1]);
		array[3] = (byte)(~AIFKJBMJOMK[ELICNEDIBGB + 2]);
		Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, array, 4, DBGBBFPPDCE);
		JHAINHBMFDI.GOADFPHGDJG(array, DBGBBFPPDCE + 4, array.Length - DBGBBFPPDCE - 4);
		for (int i = 0; i < array.Length; i += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array, i, array, i);
		}
		for (int j = 0; j < array.Length; j += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array, j, array, j);
		}
		return array;
	}

	public virtual byte[] FKFAOFJMEEF(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("not set for unwrapping");
		}
		int num = MFMIFDMEPPO.BDIGGHEPIIP();
		if (DBGBBFPPDCE < 2 * num)
		{
			throw new InvalidCipherTextException("input too short");
		}
		byte[] array = new byte[DBGBBFPPDCE];
		byte[] array2 = new byte[num];
		Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, array, 0, DBGBBFPPDCE);
		Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, array2, 0, array2.Length);
		MFMIFDMEPPO.DIOELAHNLKJ(false, new CHCELGDKEJG(BOFHHECPKNF.KPJHHAAOFOH, array2));
		for (int i = num; i < array.Length; i += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array, i, array, i);
		}
		Array.Copy(array, array.Length - array2.Length, array2, 0, array2.Length);
		MFMIFDMEPPO.DIOELAHNLKJ(false, new CHCELGDKEJG(BOFHHECPKNF.KPJHHAAOFOH, array2));
		MFMIFDMEPPO.DPACJDFHLKB(array, 0, array, 0);
		MFMIFDMEPPO.DIOELAHNLKJ(false, BOFHHECPKNF);
		for (int j = 0; j < array.Length; j += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array, j, array, j);
		}
		if ((array[0] & 0xFF) > array.Length - 4)
		{
			throw new InvalidCipherTextException("wrapped key corrupted");
		}
		byte[] array3 = new byte[array[0] & 0xFF];
		Array.Copy(array, 4, array3, 0, array[0]);
		int num2 = 0;
		for (int k = 0; k != 3; k++)
		{
			byte b = (byte)(~array[1 + k]);
			num2 |= b ^ array3[k];
		}
		if (num2 != 0)
		{
			throw new InvalidCipherTextException("wrapped key fails checksum");
		}
		return array3;
	}
}
