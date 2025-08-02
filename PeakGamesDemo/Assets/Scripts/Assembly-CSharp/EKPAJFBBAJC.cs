using System;
using System.Collections.Generic;
using System.Text;

public class EKPAJFBBAJC : MGAOAPKCDHP
{
	public string EEFMIHDPJPG;

	public string OPKJNOHCIHC;

	public long OCHADBCJEDP;

	public long JNJOGOCNHHJ;

	public string KNMOIMNECKE;

	public DateTime BPAJJPLDGOG;

	public string HKCNCCIAMEL;

	public AKGIJAMHMNA AENEHCAFNMP;

	public NBBAAJENFFN DLDMKKEICMA;

	private static StringBuilder OFPMFAMCHJE = new StringBuilder(100);

	public ABAPNBACABK ENBPGGCIADN;

	public EKPAJFBBAJC(Dictionary<string, object> EAPGOBAJLJE)
	{
		EEFMIHDPJPG = MGAOAPKCDHP.JDANMONKNGD("id", EAPGOBAJLJE);
		OPKJNOHCIHC = MGAOAPKCDHP.JDANMONKNGD("dependant", EAPGOBAJLJE);
		OCHADBCJEDP = MGAOAPKCDHP.EICLJDHEHHP("fid", EAPGOBAJLJE, 0L);
		KNMOIMNECKE = MGAOAPKCDHP.JDANMONKNGD("from", EAPGOBAJLJE);
		ENBPGGCIADN = ABAPNBACABK.Unknown;
		long num = MGAOAPKCDHP.EICLJDHEHHP("date", EAPGOBAJLJE, 0L);
		if (num > 0)
		{
			BPAJJPLDGOG = KDIMALLNOFG.DGOIABOILEG(num);
		}
		long num2 = MGAOAPKCDHP.EICLJDHEHHP("type", EAPGOBAJLJE, -99L);
		if (num2 >= 0 && num2 <= 9)
		{
			switch (num2)
			{
			case 0L:
				ENBPGGCIADN = ABAPNBACABK.UserMessage;
				HKCNCCIAMEL = MGAOAPKCDHP.JDANMONKNGD("msg", EAPGOBAJLJE);
				return;
			case 1L:
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Left"), AENEHCAFNMP.EALJKKBHDHK);
				ENBPGGCIADN = ABAPNBACABK.LeftRoom;
				return;
			case 2L:
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Join"), AENEHCAFNMP.EALJKKBHDHK);
				ENBPGGCIADN = ABAPNBACABK.JoinRoom;
				return;
			case 3L:
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Offline"), AENEHCAFNMP.EALJKKBHDHK);
				ENBPGGCIADN = ABAPNBACABK.Disconnected;
				return;
			case 4L:
				DLDMKKEICMA = new NBBAAJENFFN((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				ENBPGGCIADN = ABAPNBACABK.HelpAsked;
				return;
			case 5L:
			{
				Dictionary<string, object> dictionary2 = (Dictionary<string, object>)EAPGOBAJLJE["msg"];
				DLDMKKEICMA = new NBBAAJENFFN((Dictionary<string, object>)dictionary2["lifeRequest"]);
				KNMOIMNECKE = (string)dictionary2["helperNick"];
				JNJOGOCNHHJ = MGAOAPKCDHP.EICLJDHEHHP("helper", dictionary2, 0L);
				ENBPGGCIADN = ABAPNBACABK.HelpedToUser;
				return;
			}
			case 6L:
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Online"), AENEHCAFNMP.EALJKKBHDHK);
				ENBPGGCIADN = ABAPNBACABK.Connected;
				return;
			case 7L:
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)EAPGOBAJLJE["msg"]);
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Join"), AENEHCAFNMP.EALJKKBHDHK);
				ENBPGGCIADN = ABAPNBACABK.AcceptedToTeam;
				return;
			case 8L:
				JNJOGOCNHHJ = Convert.ToInt64(EAPGOBAJLJE["msg"]);
				ENBPGGCIADN = ABAPNBACABK.NewManagerAssignedToTeam;
				return;
			case 9L:
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)EAPGOBAJLJE["msg"];
				AENEHCAFNMP = new AKGIJAMHMNA((Dictionary<string, object>)dictionary["user"]);
				string arg = (string)dictionary["kickerName"];
				HKCNCCIAMEL = string.Format(NKILHODNBDE.GHBGCADFLFB("Social_Kicked"), AENEHCAFNMP.EALJKKBHDHK, arg);
				ENBPGGCIADN = ABAPNBACABK.UserIsKicked;
				return;
			}
			}
		}
		ENBPGGCIADN = ABAPNBACABK.Unknown;
	}

	public string JJOEKNHBAMG()
	{
		try
		{
			OFPMFAMCHJE.Length = 0;
			DateTime utcNow = DateTime.UtcNow;
			long num = (long)(utcNow - BPAJJPLDGOG).TotalSeconds;
			if (num < 1)
			{
				return string.Empty;
			}
			long num2 = num / 86400;
			num -= num2 * 86400;
			long num3 = num / 3600;
			num -= num3 * 3600;
			long num4 = num / 60;
			long num5 = num % 60;
			if (num2 > 0)
			{
				LMNCCCLKEIG(num2, num3, NKILHODNBDE.GHBGCADFLFB("daysStr"), NKILHODNBDE.GHBGCADFLFB("hoursStr"));
			}
			else if (num3 > 0)
			{
				LMNCCCLKEIG(num3, num4, NKILHODNBDE.GHBGCADFLFB("hoursStr"), NKILHODNBDE.GHBGCADFLFB("minutesStr"));
			}
			else if (num4 > 0)
			{
				LMNCCCLKEIG(num4, num5, NKILHODNBDE.GHBGCADFLFB("minutesStr"), NKILHODNBDE.GHBGCADFLFB("secondsStr"));
			}
			else
			{
				LMNCCCLKEIG(num5, 0L, NKILHODNBDE.GHBGCADFLFB("secondsStr"), null);
			}
			return OFPMFAMCHJE.ToString();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ChatMessage, "Can not parse ago text:" + ex.Message);
			return string.Empty;
		}
	}

	private static void LMNCCCLKEIG(long GMJGGGEOLEA, long AKNDHIAHCKC, string PHINNIEOKPJ, string FFBPIIEEGKO)
	{
		OFPMFAMCHJE.Append(GMJGGGEOLEA).Append(" ").Append(PHINNIEOKPJ)
			.Append(" ");
		if (AKNDHIAHCKC > 0 && FFBPIIEEGKO != null)
		{
			OFPMFAMCHJE.Append(AKNDHIAHCKC).Append(" ").Append(FFBPIIEEGKO)
				.Append(" ");
		}
		string arg = OFPMFAMCHJE.ToString();
		OFPMFAMCHJE.Length = 0;
		OFPMFAMCHJE.AppendFormat(NKILHODNBDE.GHBGCADFLFB("AgoText"), arg);
	}
}
