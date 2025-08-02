using System;
using System.Collections.Generic;
using System.Text;
using caravan.protobuf.messages;

public class JDOKMBCDMLO : IKDMCJPBBIH
{
	public const int OBEOMOGKEOC = 1;

	public const int FMBFKHAEILL = 2;

	public const int PAGMIEPLFMG = 3;

	public const string CFIBMANOEPA = "TeamChangeList";

	private const char PILOIGIICEK = '-';

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.TEAM_CHANGE_MSG;
		}
	}

	public JDOKMBCDMLO()
	{
	}

	public JDOKMBCDMLO(int GPLIOLJFDPM, long BPKJLGJDFKG, long EMNOJOHFMEH)
	{
		if (BPKJLGJDFKG != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(GPLIOLJFDPM).Append('-').Append(BPKJLGJDFKG)
				.Append('-')
				.Append(EMNOJOHFMEH);
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TeamChangeList");
			text = ((text != null) ? (text + ':' + stringBuilder.ToString()) : stringBuilder.ToString());
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TeamChangeList", text);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		TeamChangeMessage teamChangeMessage = new TeamChangeMessage();
		teamChangeMessage.actionList.AddRange(EBFFKPDMFIG());
		IKDMCJPBBIH.MCAAJOHOFGL(teamChangeMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.TEAM_CHANGE_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(TeamChangeResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		TeamChangeResponseMessage oMJOIIOONMO = (TeamChangeResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new FEGEPOFAMFJ(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}

	public static List<TeamChangeAction> EBFFKPDMFIG()
	{
		List<TeamChangeAction> list = new List<TeamChangeAction>();
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TeamChangeList");
		if (text == null)
		{
			return list;
		}
		string[] array = text.Split(':');
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				string[] array2 = array[i].Split('-');
				list.Add(new TeamChangeAction
				{
					action = int.Parse(array2[0]),
					userId = long.Parse(array2[1]),
					teamId = long.Parse(array2[2])
				});
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
