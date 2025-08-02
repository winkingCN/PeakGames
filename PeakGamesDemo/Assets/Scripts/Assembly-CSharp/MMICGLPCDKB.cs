public static class MMICGLPCDKB
{
	public static FCPPDOMBLHL HMMIDIGLBLM(this ALIFCLNJKPH BDKFNEDHAOJ)
	{
		switch (BDKFNEDHAOJ)
		{
		case ALIFCLNJKPH.Group1:
			return FCPPDOMBLHL.Group1;
		case ALIFCLNJKPH.Group2:
			return FCPPDOMBLHL.Group2;
		case ALIFCLNJKPH.Group3:
			return FCPPDOMBLHL.Group3;
		case ALIFCLNJKPH.Group4:
			return FCPPDOMBLHL.Group4;
		case ALIFCLNJKPH.Group5:
			return FCPPDOMBLHL.Group5;
		case ALIFCLNJKPH.Group6:
			return FCPPDOMBLHL.Group6;
		case ALIFCLNJKPH.Group7:
			return FCPPDOMBLHL.Group7;
		case ALIFCLNJKPH.Group8:
			return FCPPDOMBLHL.Group8;
		case ALIFCLNJKPH.Group9:
			return FCPPDOMBLHL.Group9;
		case ALIFCLNJKPH.Group10:
			return FCPPDOMBLHL.Group10;
		default:
			return FCPPDOMBLHL.None;
		}
	}

	public static FCPPDOMBLHL HMMIDIGLBLM(this string JLGIPAKFGEK)
	{
		int num = int.Parse(JLGIPAKFGEK.Substring("group".Length));
		FCPPDOMBLHL result = FCPPDOMBLHL.None;
		switch (num)
		{
		case 1:
			result = FCPPDOMBLHL.Group1;
			break;
		case 2:
			result = FCPPDOMBLHL.Group2;
			break;
		case 3:
			result = FCPPDOMBLHL.Group3;
			break;
		case 4:
			result = FCPPDOMBLHL.Group4;
			break;
		case 5:
			result = FCPPDOMBLHL.Group5;
			break;
		case 6:
			result = FCPPDOMBLHL.Group6;
			break;
		case 7:
			result = FCPPDOMBLHL.Group7;
			break;
		case 8:
			result = FCPPDOMBLHL.Group8;
			break;
		case 9:
			result = FCPPDOMBLHL.Group9;
			break;
		case 10:
			result = FCPPDOMBLHL.Group10;
			break;
		case 11:
			result = FCPPDOMBLHL.Group11;
			break;
		}
		return result;
	}
}
