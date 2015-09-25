using UnityEngine;
using System.Collections;

public class LightToggle : MonoBehaviour {

	private Light flashlight;
	private float random;
	public float lightOffRange;

	void Start(){
		flashlight = gameObject.GetComponent<Light>();
	}

	void LateUpdate(){

		random = Random.Range (0f, 100f);

		if (random >= lightOffRange) {
			flashlight.enabled = false;
		}
		else{
			flashlight.enabled = true;
		}
		
	}
}
