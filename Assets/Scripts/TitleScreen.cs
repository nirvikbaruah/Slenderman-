using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 200, 40), "Start Game")){
			Application.LoadLevel("Scene1");
		}
	}
}
