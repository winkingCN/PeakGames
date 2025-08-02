using UnityEngine;

public static class KMGEPJBDEKF
{
	public static T NKNNFLHDJHK<T>(this GameObject HCEDAECPCIA) where T : Component
	{
		T component = HCEDAECPCIA.GetComponent<T>();
		if (component != null)
		{
			return component;
		}
		return HCEDAECPCIA.AddComponent<T>();
	}
}
