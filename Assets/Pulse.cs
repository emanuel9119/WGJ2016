using UnityEngine;
using System.Collections;


public class Pulse : MonoBehaviour {

	// Use this for initialization
	public GameObject myObject;
	float i = 0f; 
	// Update is called once per frame
	void Update () {

		float hole = Mathf.Sin (Time.timeSinceLevelLoad * 6f) * 0.5f + i; //freq , amp , i
			i += 0.001f;
		myObject.transform.localScale = new Vector3 (hole, hole, hole); 
	}
}