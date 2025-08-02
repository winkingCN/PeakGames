using System.Linq;
using System.Text;

public class EKGLBJJKNBG : DLDDFKDFKEF
{
	public const string HGJAJELLIAE = "KeyAB_WaitingABList";

	public const string GNOPMGFNLON = "KeyAB_SocialTutorial";

	public const string EDAINHNLLHO = "KeyAB_Bundle";

	public const string MHAICFMMPGD = "KeyAB_Calendar";

	public const string JNIBECOBFBO = "KeyAB_FunLevel";

	private const string CLDJLMJGPMO = "Joined_AB_Test_List";

	private static EKGLBJJKNBG KNPOFJNFLJB;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	public static EKGLBJJKNBG GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new EKGLBJJKNBG();
			}
			return KNPOFJNFLJB;
		}
	}

	private EKGLBJJKNBG()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
	}

	public void OMOKOKFNBKI()
	{
	}

	public string PGMJGDOBNGL(string JBIPAKANILF)
	{
		return NJCPCACOCGB.LIANKDMAHFM(JBIPAKANILF);
	}

	public void EPMDBDDKDEM(string JBIPAKANILF)
	{
		NJCPCACOCGB.MFKBEDNLCJA(JBIPAKANILF);
	}

	public void FIMIAMGJADB(string JBIPAKANILF, string EDDNOJDPMCF)
	{
		NJCPCACOCGB.JGMDDMNGDJO(JBIPAKANILF, EDDNOJDPMCF);
	}

	public void FMAFNNNJEGI(string DEDAPOCMOJG)
	{
		if (!HAALBLAGNKB(DEDAPOCMOJG))
		{
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("Joined_AB_Test_List");
			if (text == null)
			{
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("Joined_AB_Test_List", DEDAPOCMOJG);
				return;
			}
			text = new StringBuilder(3).Append(text).Append(':').Append(DEDAPOCMOJG)
				.ToString();
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("Joined_AB_Test_List", text);
		}
	}

	public bool HAALBLAGNKB(string DEDAPOCMOJG)
	{
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("Joined_AB_Test_List");
		if (text == null)
		{
			return false;
		}
		string[] source = text.Split(':');
		return source.Contains(DEDAPOCMOJG);
	}

	public void CKHHPNAOAEF()
	{
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_CoinReward");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_FreeEgo");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_FreeEgo_Interval");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_MoveCount");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_NoticeMark");
		NJCPCACOCGB.MFKBEDNLCJA("KeyLast5Moves");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_CrownRush");
		NJCPCACOCGB.MFKBEDNLCJA("KeyAB_LevelMove");
	}

	public bool NMPOABLCDAC()
	{
		string text = NJCPCACOCGB.LIANKDMAHFM("KeyAB_SocialTutorial");
		if (text == null)
		{
			return false;
		}
		int result;
		int.TryParse(text, out result);
		return result == 1;
	}
}
