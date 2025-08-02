using System;
using Spine.Unity;

public class NDLPILIFIPK : ACDPFOPPPOP
{
	public struct LKHHICHOMNI
	{
		public string HLCFGIFLPPE;

		public string DFKJODFHCJB;

		public string IOCMOCCFALN;

		public LKHHICHOMNI(string ANABKDBKLED)
		{
			string[] array = ANABKDBKLED.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 0)
			{
				HLCFGIFLPPE = string.Empty;
				DFKJODFHCJB = string.Empty;
				IOCMOCCFALN = string.Empty;
				return;
			}
			if (array.Length < 2)
			{
				throw new Exception("Cannot generate Attachment Hierarchy from string! Not enough components! [" + ANABKDBKLED + "]");
			}
			HLCFGIFLPPE = array[0];
			DFKJODFHCJB = array[1];
			IOCMOCCFALN = string.Empty;
			for (int i = 2; i < array.Length; i++)
			{
				IOCMOCCFALN += array[i];
			}
		}
	}

	public bool FDGIMGLPFGM;

	public bool JJOBIGOLKOI;

	public bool OBNGFFKPCME;

	public string HCDOHEEHJPG = string.Empty;

	public string JACCABDIEJO = string.Empty;

	public NDLPILIFIPK(bool JJOBIGOLKOI = true, bool FDGIMGLPFGM = false, bool OBNGFFKPCME = false, string JACCABDIEJO = "", string NDGJHCMKDON = "", string HCDOHEEHJPG = "", bool DHPCLHLMCPG = true, bool JICOEKBHOFE = false)
	{
		this.JJOBIGOLKOI = JJOBIGOLKOI;
		this.FDGIMGLPFGM = FDGIMGLPFGM;
		this.OBNGFFKPCME = OBNGFFKPCME;
		this.JACCABDIEJO = JACCABDIEJO;
		base.NDGJHCMKDON = NDGJHCMKDON;
		this.HCDOHEEHJPG = HCDOHEEHJPG;
		base.DHPCLHLMCPG = DHPCLHLMCPG;
		base.JICOEKBHOFE = JICOEKBHOFE;
	}

	public static LKHHICHOMNI CMIAJNNAHGD(string ANABKDBKLED)
	{
		return new LKHHICHOMNI(ANABKDBKLED);
	}

	public static OAMNGFLKEFI JGHJDGIANDD(string JPJNNNELLFP, KGMHJGFNPFC DCMDAJJBNAI)
	{
		LKHHICHOMNI lKHHICHOMNI = CMIAJNNAHGD(JPJNNNELLFP);
		return (!string.IsNullOrEmpty(lKHHICHOMNI.IOCMOCCFALN)) ? DCMDAJJBNAI.COONIJFPADF(lKHHICHOMNI.HLCFGIFLPPE).JGHJDGIANDD(DCMDAJJBNAI.IBOGMECEHLD(lKHHICHOMNI.DFKJODFHCJB), lKHHICHOMNI.IOCMOCCFALN) : null;
	}

	public static OAMNGFLKEFI JGHJDGIANDD(string JPJNNNELLFP, SkeletonDataAsset KAFMHICMBHN)
	{
		return JGHJDGIANDD(JPJNNNELLFP, KAFMHICMBHN.CPILINNBJLL(true));
	}
}
