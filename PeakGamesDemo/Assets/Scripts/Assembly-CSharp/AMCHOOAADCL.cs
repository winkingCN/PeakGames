internal class AMCHOOAADCL : LCDKCHNAIGN
{
	protected readonly int[] GJPIIMLNKMN;

	public virtual int NMAPLGALKKK
	{
		get
		{
			return GJPIIMLNKMN[GJPIIMLNKMN.Length - 1];
		}
	}

	internal AMCHOOAADCL(int[] GJPIIMLNKMN)
	{
		this.GJPIIMLNKMN = NOGCEBKPPJE.IKBFGGABMKP(GJPIIMLNKMN);
	}

	public virtual int[] KOHLMNNELKF()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(GJPIIMLNKMN);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (this == NEMEKIOEOLC)
		{
			return true;
		}
		AMCHOOAADCL aMCHOOAADCL = NEMEKIOEOLC as AMCHOOAADCL;
		if (aMCHOOAADCL == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(GJPIIMLNKMN, aMCHOOAADCL.GJPIIMLNKMN);
	}

	public override int GetHashCode()
	{
		return NOGCEBKPPJE.ILMFICENEMK(GJPIIMLNKMN);
	}
}
