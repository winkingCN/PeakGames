public abstract class COEMJAGOFJJ : IGMAJHKIIPK
{
	private readonly bool JMNLHNOGILL;

	public bool CCLHEKOIIKM
	{
		get
		{
			return JMNLHNOGILL;
		}
	}

	protected COEMJAGOFJJ(bool JMNLHNOGILL)
	{
		this.JMNLHNOGILL = JMNLHNOGILL;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		COEMJAGOFJJ cOEMJAGOFJJ = NEMEKIOEOLC as COEMJAGOFJJ;
		if (cOEMJAGOFJJ == null)
		{
			return false;
		}
		return KIFDKLPDKMD(cOEMJAGOFJJ);
	}

	protected bool KIFDKLPDKMD(COEMJAGOFJJ CJHEIBNHNNE)
	{
		return JMNLHNOGILL == CJHEIBNHNNE.JMNLHNOGILL;
	}

	public override int GetHashCode()
	{
		return JMNLHNOGILL.GetHashCode();
	}
}
