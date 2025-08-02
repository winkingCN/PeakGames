using UnityEngine;

public class AlphaMaterialModifier : MonoBehaviour
{
	private Renderer EGGNPJNPBEC;

	[Range(0f, 1f)]
	public float AlphaValue = 1f;

	private Color LGDJKKILIOG;

	public void Awake()
	{
		EGGNPJNPBEC = GetComponent<Renderer>();
		LGDJKKILIOG = EGGNPJNPBEC.material.color;
		LGDJKKILIOG.a = 1f;
		EGGNPJNPBEC.material.color = LGDJKKILIOG;
	}

	public void Update()
	{
		LGDJKKILIOG.a = AlphaValue;
		EGGNPJNPBEC.material.color = LGDJKKILIOG;
	}
}
