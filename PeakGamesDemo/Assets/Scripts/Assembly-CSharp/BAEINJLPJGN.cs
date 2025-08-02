public struct BAEINJLPJGN
{
	public byte OMPOBDNIDJL;

	public byte JDOEIGDOGPO;

	public byte MCNGMGMFBHJ;

	public byte EBAEAFLCFNA;

	public byte EMAGECIOLFP;

	public byte LAHGDNCKNMD;

	public byte PACAEFOCPNP;

	public byte NNPMJJGEOFO;

	public byte HKKALMHMKJK;

	public byte DLAMNCJIFEH;

	public void BOPEPLONIFL()
	{
		OMPOBDNIDJL = 0;
		JDOEIGDOGPO = 0;
		MCNGMGMFBHJ = 0;
		EBAEAFLCFNA = 0;
		EMAGECIOLFP = 0;
		LAHGDNCKNMD = 0;
		PACAEFOCPNP = 0;
		NNPMJJGEOFO = 0;
		HKKALMHMKJK = 0;
		DLAMNCJIFEH = 0;
	}

	public byte JEACJNAKLDJ(BCIEOOJOMDO LMNINFLOCIB)
	{
		switch (LMNINFLOCIB)
		{
		case BCIEOOJOMDO.Bold:
			OMPOBDNIDJL++;
			return OMPOBDNIDJL;
		case BCIEOOJOMDO.Italic:
			JDOEIGDOGPO++;
			return JDOEIGDOGPO;
		case BCIEOOJOMDO.Underline:
			MCNGMGMFBHJ++;
			return MCNGMGMFBHJ;
		case BCIEOOJOMDO.Strikethrough:
			EBAEAFLCFNA++;
			return EBAEAFLCFNA;
		case BCIEOOJOMDO.Superscript:
			LAHGDNCKNMD++;
			return LAHGDNCKNMD;
		case BCIEOOJOMDO.Subscript:
			PACAEFOCPNP++;
			return PACAEFOCPNP;
		case BCIEOOJOMDO.Highlight:
			EMAGECIOLFP++;
			return EMAGECIOLFP;
		default:
			return 0;
		}
	}

	public byte CJOHLENDJGO(BCIEOOJOMDO LMNINFLOCIB)
	{
		switch (LMNINFLOCIB)
		{
		case BCIEOOJOMDO.Bold:
			if (OMPOBDNIDJL > 1)
			{
				OMPOBDNIDJL--;
			}
			else
			{
				OMPOBDNIDJL = 0;
			}
			return OMPOBDNIDJL;
		case BCIEOOJOMDO.Italic:
			if (JDOEIGDOGPO > 1)
			{
				JDOEIGDOGPO--;
			}
			else
			{
				JDOEIGDOGPO = 0;
			}
			return JDOEIGDOGPO;
		case BCIEOOJOMDO.Underline:
			if (MCNGMGMFBHJ > 1)
			{
				MCNGMGMFBHJ--;
			}
			else
			{
				MCNGMGMFBHJ = 0;
			}
			return MCNGMGMFBHJ;
		case BCIEOOJOMDO.Strikethrough:
			if (EBAEAFLCFNA > 1)
			{
				EBAEAFLCFNA--;
			}
			else
			{
				EBAEAFLCFNA = 0;
			}
			return EBAEAFLCFNA;
		case BCIEOOJOMDO.Highlight:
			if (EMAGECIOLFP > 1)
			{
				EMAGECIOLFP--;
			}
			else
			{
				EMAGECIOLFP = 0;
			}
			return EMAGECIOLFP;
		case BCIEOOJOMDO.Superscript:
			if (LAHGDNCKNMD > 1)
			{
				LAHGDNCKNMD--;
			}
			else
			{
				LAHGDNCKNMD = 0;
			}
			return LAHGDNCKNMD;
		case BCIEOOJOMDO.Subscript:
			if (PACAEFOCPNP > 1)
			{
				PACAEFOCPNP--;
			}
			else
			{
				PACAEFOCPNP = 0;
			}
			return PACAEFOCPNP;
		default:
			return 0;
		}
	}
}
