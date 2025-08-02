using System.Collections.Generic;

internal class CIOFLCIJOHK
{
	internal static AMLCGIGPHEJ FCBGBJMGMBD(MFCJIFNNIHI EDJBGBAEAPE, string GILEGAFNHCG)
	{
		Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(GILEGAFNHCG) as Dictionary<string, object>;
		AMLCGIGPHEJ aMLCGIGPHEJ = new AMLCGIGPHEJ();
		aMLCGIGPHEJ.OJEBJDAHIIJ = EDJBGBAEAPE.EFHCBOFFHGG(dictionary["permissionStatus"]);
		aMLCGIGPHEJ.MGPHJPPBCCC = EDJBGBAEAPE.LFODGFFOCOP(dictionary["subscriptionStatus"]);
		if (dictionary.ContainsKey("emailSubscriptionStatus"))
		{
			aMLCGIGPHEJ.KKBPPNGEGNM = EDJBGBAEAPE.BPMPMJAFDMC(dictionary["emailSubscriptionStatus"]);
		}
		return aMLCGIGPHEJ;
	}

	internal static MIKPOELFDIL GMBFGDFNDHL(MFCJIFNNIHI EDJBGBAEAPE, string CMECJOGHCCJ)
	{
		Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(CMECJOGHCCJ) as Dictionary<string, object>;
		MIKPOELFDIL mIKPOELFDIL = new MIKPOELFDIL();
		mIKPOELFDIL.BMIOECELGCA = EDJBGBAEAPE.EFHCBOFFHGG(dictionary["to"]);
		mIKPOELFDIL.LLAEDBFNCCP = EDJBGBAEAPE.EFHCBOFFHGG(dictionary["from"]);
		return mIKPOELFDIL;
	}

	internal static OAEFFLGOHEC HBJBJGILCLI(MFCJIFNNIHI EDJBGBAEAPE, string CMECJOGHCCJ)
	{
		Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(CMECJOGHCCJ) as Dictionary<string, object>;
		OAEFFLGOHEC oAEFFLGOHEC = new OAEFFLGOHEC();
		oAEFFLGOHEC.BMIOECELGCA = EDJBGBAEAPE.LFODGFFOCOP(dictionary["to"]);
		oAEFFLGOHEC.LLAEDBFNCCP = EDJBGBAEAPE.LFODGFFOCOP(dictionary["from"]);
		return oAEFFLGOHEC;
	}

	internal static EJJOFNDGMNL HILMODDJFFC(MFCJIFNNIHI EDJBGBAEAPE, string CMECJOGHCCJ)
	{
		Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(CMECJOGHCCJ) as Dictionary<string, object>;
		EJJOFNDGMNL eJJOFNDGMNL = new EJJOFNDGMNL();
		eJJOFNDGMNL.BMIOECELGCA = EDJBGBAEAPE.BPMPMJAFDMC(dictionary["to"]);
		eJJOFNDGMNL.LLAEDBFNCCP = EDJBGBAEAPE.BPMPMJAFDMC(dictionary["from"]);
		return eJJOFNDGMNL;
	}
}
