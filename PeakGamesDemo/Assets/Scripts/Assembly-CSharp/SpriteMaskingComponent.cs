using UnityEngine;
using UnityEngine.Rendering;

public class SpriteMaskingComponent : MonoBehaviour
{
	public SpriteMask owner;

	public virtual bool MKNHMLHKFKE
	{
		get
		{
			return !(owner == null) && owner.enabled;
		}
	}

	protected virtual void FHABHCNBLEB(Transform LLIEHCKNJEM, CompareFunction IJLKCOHLILI, int AFOCAAAOHGP)
	{
		if (owner != null)
		{
			owner.FHABHCNBLEB(LLIEHCKNJEM, IJLKCOHLILI, AFOCAAAOHGP);
		}
	}
}
