using Assets.Scripts.CasualTools.Common.DB;

public class DEDNLGAFIDJ : Entity
{
	public string CDEOGMLENPN;

	public string JBGOANMLBFA;

	public DEDNLGAFIDJ()
	{
	}

	public DEDNLGAFIDJ(int? BDKFNEDHAOJ, string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		Id = BDKFNEDHAOJ;
		CDEOGMLENPN = IKNCPEPOKGJ;
		JBGOANMLBFA = EDDNOJDPMCF;
	}

	public override string ToString()
	{
		return string.Format("[SimpleProperty: Id={0}, Key={1}, Value={2}]", Id, CDEOGMLENPN, JBGOANMLBFA);
	}
}
