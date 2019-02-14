using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	void OnEnable()
	{
		SceneManager.LoadScene("BloodScene");
	}
}
