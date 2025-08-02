using System;
using Org.BouncyCastle.Math;

public abstract class JDPBBBGMMMP : JGAFKLGGBGF
{
	protected internal JDPBBBGMMMP(BHPIABAGAPB NINILENHPHE, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, bool HPGABKNMEAG)
		: base(NINILENHPHE, AMFCENFNAJJ, CNLILOEEBOJ, HPGABKNMEAG)
	{
	}

	protected internal JDPBBBGMMMP(BHPIABAGAPB NINILENHPHE, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG)
		: base(NINILENHPHE, AMFCENFNAJJ, CNLILOEEBOJ, IJGNIJAMCML, HPGABKNMEAG)
	{
	}

	public override byte[] PPCPBIEGJKM(bool BDKLBMAKEIN)
	{
		if (base.IFCDKFANPBO)
		{
			return new byte[1];
		}
		JGAFKLGGBGF jGAFKLGGBGF = MIHJHLFLHNA();
		byte[] array = jGAFKLGGBGF.OBCJFNBLIPG.PPCPBIEGJKM();
		if (BDKLBMAKEIN)
		{
			byte[] array2 = new byte[array.Length + 1];
			array2[0] = (byte)((!jGAFKLGGBGF.NLPBPDPOOAK) ? 2u : 3u);
			Array.Copy(array, 0, array2, 1, array.Length);
			return array2;
		}
		byte[] array3 = jGAFKLGGBGF.LGFGMGPDEIB.PPCPBIEGJKM();
		byte[] array4 = new byte[array.Length + array3.Length + 1];
		array4[0] = 4;
		Array.Copy(array, 0, array4, 1, array.Length);
		Array.Copy(array3, 0, array4, array.Length + 1, array3.Length);
		return array4;
	}

	public override JGAFKLGGBGF IBJBIGNPNEM(BigInteger BENKLGPHLGI)
	{
		return ECFGFKNLLGH.FMFCODCKFAE().IBJBIGNPNEM(this, BENKLGPHLGI);
	}
}
