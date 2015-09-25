using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 10, 200, 40), "Play Again")){
			Application.LoadLevel("Scene1");
		}
	}
}
