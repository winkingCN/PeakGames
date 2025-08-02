using UnityEngine;

public class DiscoRayRotate : MonoBehaviour
{
	public float speed;

	private void Update()
	{
		base.gameObject.transform.Rotate(0f, 0f, 5f * speed * Time.deltaTime);
	}
}
