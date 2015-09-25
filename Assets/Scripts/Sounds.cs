using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour {

	public Transform myTransform;
	public GameObject player;
	public Renderer slender;
	public AudioClip seenSound;
	private float distance;

	void Update(){
		Screen.lockCursor = true;
		distance = Vector3.Distance(myTransform.position, player.transform.position);
		if (slender.isVisible && distance <= 25f) {
			audio.PlayOneShot(seenSound);
		}
	}
}
