using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaouOverlord_Script : MonoBehaviour {

	public Text Score;
	public Text Frames;
	int CurScore = 0;

	void Start()
	{
		
	
	}

	void Update()
	{
		Score.text = CurScore.ToString();
		int totalFrames = Time.frameCount;
		Frames.text = totalFrames.ToString ();

		if ( Input.GetMouseButtonDown(0))
		{
			RaycastHit hit = new RaycastHit (); 
			Ray ray= Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast(transform.position, transform.forward, 10))
			{  
				Destroy(GameObject.Find("loot"));
			}
		}
	}
}