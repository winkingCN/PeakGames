using UnityEngine;

namespace I2.Loc
{
	public class RegisterGlobalParameters : MonoBehaviour, JMFAIACBIGP
	{
		public virtual void OnEnable()
		{
			if (!PNAJOCHGJFO.OAANICEABPL.Contains(this))
			{
				PNAJOCHGJFO.OAANICEABPL.Add(this);
				PNAJOCHGJFO.EBEBNPMKGEO(true);
			}
		}

		public virtual void OnDisable()
		{
			PNAJOCHGJFO.OAANICEABPL.Remove(this);
		}

		public virtual string GetParameterValue(string GFIIAOBDDPB)
		{
			return null;
		}
	}
}
