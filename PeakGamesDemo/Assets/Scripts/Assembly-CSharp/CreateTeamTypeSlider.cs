using TMPro;
using UnityEngine;

public class CreateTeamTypeSlider : MonoBehaviour
{
	public bool IsClosed;

	public TextMeshPro TypeText;

	public void Awake()
	{
		HCOGGJFNCJO();
	}

	private void HCOGGJFNCJO()
	{
		TypeText.FCJBBPHFNPJ = ((!IsClosed) ? NKILHODNBDE.GHBGCADFLFB("OpenNoun") : NKILHODNBDE.GHBGCADFLFB("Closed"));
	}

	public void Switch()
	{
		IsClosed = !IsClosed;
		HCOGGJFNCJO();
	}

	public void Force(bool BCIHLCMFAEK)
	{
		IsClosed = BCIHLCMFAEK;
		HCOGGJFNCJO();
	}
}
