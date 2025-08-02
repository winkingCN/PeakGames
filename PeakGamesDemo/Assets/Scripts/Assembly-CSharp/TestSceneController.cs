using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneController : MonoBehaviour
{
	private void Start()
	{
		SceneManager.LoadScene("InitialScene");
	}
}
