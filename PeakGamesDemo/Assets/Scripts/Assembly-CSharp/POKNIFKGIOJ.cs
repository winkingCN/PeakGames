public class POKNIFKGIOJ : DLICBBHNDFH
{
	public const int AILBEJJIJHJ = 0;

	public const int NHPDFNKGNBK = 1;

	public const int IHJAEEKEMOM = 2;

	public const int LMPICMNAGAC = 3;

	public const int PGIPPEDDAPB = 4;

	public const int KOFCNGCJFPG = 5;

	public const int AAGFEILBPJK = 6;

	public const int JAGOOJMICFD = 8;

	public const int GEKKIJEGPHC = 9;

	public const int ALGNPIJGKOD = 10;

	private static readonly string[] HBHLNPDDFCF = new string[11]
	{
		"Unspecified", "KeyCompromise", "CACompromise", "AffiliationChanged", "Superseded", "CessationOfOperation", "CertificateHold", "Unknown", "RemoveFromCrl", "PrivilegeWithdrawn",
		"AACompromise"
	};

	public POKNIFKGIOJ(int OJCKIOENBEL)
		: base(OJCKIOENBEL)
	{
	}

	public POKNIFKGIOJ(DLICBBHNDFH OJCKIOENBEL)
		: base(OJCKIOENBEL.JBGOANMLBFA.IntValue)
	{
	}

	public override string ToString()
	{
		int intValue = base.JBGOANMLBFA.IntValue;
		string text = ((intValue >= 0 && intValue <= 10) ? HBHLNPDDFCF[intValue] : "Invalid");
		return "CrlReason: " + text;
	}
}
