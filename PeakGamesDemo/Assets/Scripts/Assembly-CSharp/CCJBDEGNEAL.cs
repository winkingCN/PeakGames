public static class CCJBDEGNEAL
{
	public static bool GKIBJAOFBHB(int EDDNOJDPMCF, int LDMDBPLADGD)
	{
		return (EDDNOJDPMCF & (1 << LDMDBPLADGD)) != 0;
	}

	public static void NCNOKALAALL(ref int EDDNOJDPMCF, int LDMDBPLADGD, bool CAALOLFAKKM)
	{
		if (CAALOLFAKKM)
		{
			EDDNOJDPMCF |= 1 << LDMDBPLADGD;
		}
		else
		{
			EDDNOJDPMCF &= ~(1 << LDMDBPLADGD);
		}
	}
}
