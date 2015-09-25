using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	public AudioSource sound;
	public AudioSource siren;
	public AudioClip roar;
	public GUIText countText;
	public static int count;
	private float timer = 3f;
	private bool played = false;


	void Start(){
		count = 0;
		played = false;
		setCountText ();
	}

	void Update () {
		if (played) {
			timer -= Time.deltaTime;
			if (timer <= 0f) {
				played = false;
				audio.PlayOneShot (roar);
			}

		} else if(timer <= 0f && !siren.isPlaying)	{
			siren.Play();
		}
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown ("w") || Input.GetKeyDown ("s") || Input.GetKeyDown ("a") || Input.GetKeyDown ("d")) {
			sound.Play ();
			
		}
		if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp ("w") || Input.GetKeyUp ("s") || Input.GetKeyUp ("a") || Input.GetKeyUp ("d")) {
			sound.Pause ();
			
		}
	}

	void setCountText(){
		countText.text = "Notes: " + count.ToString();
		if (count >= 1 && !played) {
			played = true;
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Note") {
			other.gameObject.SetActive(false);
			count++;
			MoveSlender.start = true;
			setCountText();
		}
	}
	

}
