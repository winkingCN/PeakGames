using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security.Certificates;

public class PIFGBCCBEPG
{
	public static EDOEBJJFOBM MEGDDHGGCFJ(PJGIGKJFGFI GIKMLCMBLHH)
	{
		return EDOEBJJFOBM.HPDCKMOPEMM(GIKMLCMBLHH.KLHNEKMCKKI());
	}

	public static ICollection BNEAMPGPENK(MPMAOKNGPCF DDNIHGOJJGC)
	{
		PJGIGKJFGFI eNHAMIMNEEI = DDNIHGOJJGC.NMBKKGMJOBA(HLAHBGANIKK.GFBIMMBBHDG);
		return CCMGABHADJH(eNHAMIMNEEI);
	}

	public static ICollection GLKGAHALPAD(MPMAOKNGPCF DDNIHGOJJGC)
	{
		PJGIGKJFGFI eNHAMIMNEEI = DDNIHGOJJGC.NMBKKGMJOBA(HLAHBGANIKK.FCALAKCJJDP);
		return CCMGABHADJH(eNHAMIMNEEI);
	}

	private static ICollection CCMGABHADJH(PJGIGKJFGFI ENHAMIMNEEI)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		if (ENHAMIMNEEI != null)
		{
			try
			{
				ALLINHNNNJN aLLINHNNNJN = ALLINHNNNJN.BJLJCGFMFOO(MEGDDHGGCFJ(ENHAMIMNEEI));
				foreach (GGHMCHAHOCN item in aLLINHNNNJN)
				{
					IList list2 = LHFGHNFJIKM.PPPFFFBMGML();
					list2.Add(item.JPBIKBDCEKC);
					switch (item.JPBIKBDCEKC)
					{
					case 0:
					case 3:
					case 5:
						list2.Add(item.PNGPLGHKFDI.IIHKEACDNID());
						break;
					case 4:
						list2.Add(HMMHEPKCKCP.BJLJCGFMFOO(item.PNGPLGHKFDI).ToString());
						break;
					case 1:
					case 2:
					case 6:
						list2.Add(((NKKPPKHBBFB)item.PNGPLGHKFDI).JDANMONKNGD());
						break;
					case 8:
						list2.Add(KLKJHFKJLEM.BJLJCGFMFOO(item.PNGPLGHKFDI).EEFMIHDPJPG);
						break;
					case 7:
						list2.Add(PJGIGKJFGFI.BJLJCGFMFOO(item.PNGPLGHKFDI).KLHNEKMCKKI());
						break;
					default:
						throw new IOException("Bad tag number: " + item.JPBIKBDCEKC);
					}
					list.Add(list2);
				}
			}
			catch (Exception ex)
			{
				throw new CertificateParsingException(ex.Message);
			}
		}
		return list;
	}
}
