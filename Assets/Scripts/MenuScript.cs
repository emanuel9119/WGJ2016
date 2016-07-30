using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	public void LoadScene (string name)
	{
		SceneManager.LoadScene (name);
	}
	public void QuitGame ()
	{
		Application.Quit ();
	}
}