using UnityEngine;

public struct FGDPCFDHAIJ
{
	public Vector3 LDMDBPLADGD;

	public Vector3 CAIMCKBHGKP;

	public Vector3 OCKOIFECMPI;

	public Vector3 BEPNMGAAIDF;

	public FGDPCFDHAIJ(Vector3 LDMDBPLADGD, Quaternion ODLHFMOPCHL)
	{
		this.LDMDBPLADGD = LDMDBPLADGD;
		CAIMCKBHGKP = ODLHFMOPCHL * Vector3.forward;
		OCKOIFECMPI = ODLHFMOPCHL * Vector3.up;
		BEPNMGAAIDF = ODLHFMOPCHL * Vector3.right;
	}

	public Vector3 DOEPLMJBPHP(Ray LGOJEFOJAPN)
	{
		float num = (0f - Vector3.Dot(LGOJEFOJAPN.origin - LDMDBPLADGD, CAIMCKBHGKP)) / Vector3.Dot(LGOJEFOJAPN.direction, CAIMCKBHGKP);
		return LGOJEFOJAPN.origin + LGOJEFOJAPN.direction * num;
	}

	public Vector3 OMNOCMINAKA(Vector3 GELBNILDNJP)
	{
		Vector3 lhs = GELBNILDNJP - LDMDBPLADGD;
		return new Vector3(Vector3.Dot(lhs, BEPNMGAAIDF), Vector3.Dot(lhs, OCKOIFECMPI), Vector3.Dot(lhs, CAIMCKBHGKP));
	}
}
