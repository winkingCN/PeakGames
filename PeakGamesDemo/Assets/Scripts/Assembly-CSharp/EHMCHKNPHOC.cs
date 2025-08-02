using Assets.Scripts.CasualTools.Common.DB;

public class EHMCHKNPHOC : Entity
{
	public string CDEOGMLENPN;

	public int JBGOANMLBFA;

	public EHMCHKNPHOC()
	{
	}

	public EHMCHKNPHOC(int? BDKFNEDHAOJ, string IKNCPEPOKGJ, int EDDNOJDPMCF)
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
