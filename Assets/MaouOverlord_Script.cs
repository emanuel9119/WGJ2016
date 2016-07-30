using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaouOverlord_Script : MonoBehaviour {

	public Text People;
	public Text AP;
	public Text Nuke;
	public Text Frames;

	void Start()
	{
		string NukeTxt = "/10";

		int PeopleNum = 0;
		int APNum = 0;
		int NukeNum = 0;




		Nuke.text = NukeNum.ToString() + "/10";
		AP.text = APNum.ToString() + "/20";
		People.text = PeopleNum.ToString ()+ "/10";
	}

	void Update()
	{

		int totalFrames = Time.frameCount;

		Frames.text = totalFrames.ToString ();

		
	}

}
