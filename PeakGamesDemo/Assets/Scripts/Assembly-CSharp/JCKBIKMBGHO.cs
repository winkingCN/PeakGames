using UnityEngine;

public struct JCKBIKMBGHO
{
	public Vector2 PCNBBODKIOL;

	public Vector2 BEGCLEDLFOO;

	private JCKBIKMBGHO(Vector2 PCNBBODKIOL, Vector2 BEGCLEDLFOO)
	{
		this.PCNBBODKIOL = PCNBBODKIOL;
		this.BEGCLEDLFOO = BEGCLEDLFOO;
	}

	public static float EAMJDDFALKB(Vector2 HPDNNAPPLBI, Vector2 ECBGNJEHCPJ, Vector2 KJPPPBMDJKG)
	{
		return Vector2.Distance(EEMCPNDFKJF(HPDNNAPPLBI, ECBGNJEHCPJ, KJPPPBMDJKG), KJPPPBMDJKG);
	}

	public static Vector2 EGBLNNKKNLL(Vector2 HPDNNAPPLBI, Vector2 ECBGNJEHCPJ, Vector2 KJPPPBMDJKG)
	{
		Vector2 vector = ECBGNJEHCPJ - HPDNNAPPLBI;
		float num = vector.x * vector.x + vector.y * vector.y;
		float num2 = ((KJPPPBMDJKG.x - HPDNNAPPLBI.x) * vector.x + (KJPPPBMDJKG.y - HPDNNAPPLBI.y) * vector.y) / num;
		return HPDNNAPPLBI + num2 * vector;
	}

	public static Vector2 EEMCPNDFKJF(Vector2 MJHNHFDPACC, Vector2 PMCOPOPNIPG, Vector2 KJPPPBMDJKG)
	{
		Vector2 vector = PMCOPOPNIPG - MJHNHFDPACC;
		float num = vector.x * vector.x + vector.y * vector.y;
		float num2 = Mathf.Clamp01(((KJPPPBMDJKG.x - MJHNHFDPACC.x) * vector.x + (KJPPPBMDJKG.y - MJHNHFDPACC.y) * vector.y) / num);
		return MJHNHFDPACC + num2 * vector;
	}

	public static Vector2 EEMCPNDFKJF(JCKBIKMBGHO BBIEJBIHPLE, Vector2 KJPPPBMDJKG)
	{
		return EEMCPNDFKJF(BBIEJBIHPLE.PCNBBODKIOL, BBIEJBIHPLE.BEGCLEDLFOO, KJPPPBMDJKG);
	}

	public Vector2 DMPGPOLMPDD(Vector2 KJPPPBMDJKG)
	{
		return EEMCPNDFKJF(this, KJPPPBMDJKG);
	}

	public static bool DIBLDHPCCCB(JCKBIKMBGHO CNLPFONEBLP, JCKBIKMBGHO PBDBJPAFMPF)
	{
		return DIBLDHPCCCB(CNLPFONEBLP.PCNBBODKIOL, CNLPFONEBLP.BEGCLEDLFOO, PBDBJPAFMPF.PCNBBODKIOL, PBDBJPAFMPF.BEGCLEDLFOO);
	}

	public static bool DIBLDHPCCCB(Vector2 PNGIFDAMIII, Vector2 DDJLCPAKEDD, Vector2 NEHOIIIODHC, Vector2 DLGDBCBCIED)
	{
		float num = (DLGDBCBCIED.x - NEHOIIIODHC.x) * (PNGIFDAMIII.y - NEHOIIIODHC.y) - (DLGDBCBCIED.y - NEHOIIIODHC.y) * (PNGIFDAMIII.x - NEHOIIIODHC.x);
		float num2 = (DLGDBCBCIED.x - NEHOIIIODHC.x) * (DDJLCPAKEDD.y - NEHOIIIODHC.y) - (DLGDBCBCIED.y - NEHOIIIODHC.y) * (DDJLCPAKEDD.x - NEHOIIIODHC.x);
		float num3 = (DDJLCPAKEDD.x - PNGIFDAMIII.x) * (NEHOIIIODHC.y - PNGIFDAMIII.y) - (DDJLCPAKEDD.y - PNGIFDAMIII.y) * (NEHOIIIODHC.x - PNGIFDAMIII.x);
		float num4 = (DDJLCPAKEDD.x - PNGIFDAMIII.x) * (DLGDBCBCIED.y - PNGIFDAMIII.y) - (DDJLCPAKEDD.y - PNGIFDAMIII.y) * (DLGDBCBCIED.x - PNGIFDAMIII.x);
		return num * num2 < 0f && num3 * num4 < 0f;
	}

	public static bool FLNOJOGHHMC(Vector2 PNGIFDAMIII, Vector2 DDJLCPAKEDD, Vector2 NEHOIIIODHC, Vector2 DLGDBCBCIED, out Vector2 KJPPPBMDJKG)
	{
		KJPPPBMDJKG = Vector2.zero;
		float x = PNGIFDAMIII.x;
		float y = PNGIFDAMIII.y;
		float x2 = DDJLCPAKEDD.x;
		float y2 = DDJLCPAKEDD.y;
		float x3 = NEHOIIIODHC.x;
		float y3 = NEHOIIIODHC.y;
		float x4 = DLGDBCBCIED.x;
		float y4 = DLGDBCBCIED.y;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		if ((double)Mathf.Abs((x - x2) * (y3 - y4) - (y - y2) * (x3 - x4)) < 0.0001)
		{
			return false;
		}
		num = ((y3 - y) * (x3 - x4) - (x3 - x) * (y3 - y4)) / ((x - x2) * (y3 - y4) - (y - y2) * (x3 - x4));
		if (num >= 0f && num <= 1f)
		{
			num2 = x + num * (x2 - x);
			num3 = y + num * (y2 - y);
			if ((x3 - num2) * (x4 - num2) <= 0f && (y3 - num3) * (y4 - num3) <= 0f)
			{
				KJPPPBMDJKG = new Vector2(num2, num3);
				return true;
			}
			return false;
		}
		return false;
	}
}
