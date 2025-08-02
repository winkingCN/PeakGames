internal sealed class LDKGGKJGCBH
{
	private const int PCFDNBPMJEC = 65521;

	private const int LCNHMJGMCGG = 5552;

	internal long IKGHHFMJBJG(long LEIJBCJFPGI, byte[] GHPCHPOHELF, int EHJNMODJEAN, int NBEDPKHALCN)
	{
		if (GHPCHPOHELF == null)
		{
			return 1L;
		}
		long num = LEIJBCJFPGI & 0xFFFF;
		long num2 = (LEIJBCJFPGI >> 16) & 0xFFFF;
		while (NBEDPKHALCN > 0)
		{
			int num3 = ((NBEDPKHALCN >= 5552) ? 5552 : NBEDPKHALCN);
			NBEDPKHALCN -= num3;
			while (num3 >= 16)
			{
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
				num2 += num;
				num3 -= 16;
			}
			if (num3 != 0)
			{
				do
				{
					num += GHPCHPOHELF[EHJNMODJEAN++] & 0xFF;
					num2 += num;
				}
				while (--num3 != 0);
			}
			num %= 65521;
			num2 %= 65521;
		}
		return (num2 << 16) | num;
	}
}
