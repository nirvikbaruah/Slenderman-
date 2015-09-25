using UnityEngine;
using System.Collections;

public class MoveSlender : MonoBehaviour {
	
	public GameObject player;
	public Renderer slender;
	public float speed;
	public Transform myTransform;
	private float timer = 5.0f;
	public AudioClip roar;
	private float changeDistanceTimer = 10.0f;
	public static bool start = false;
	public static float distance;
	private float stopDistance = 70f;
	private Vector3 yAxis;
	private static int score;
	private int count = 1;

	void Update()
	{
		distance = Vector3.Distance(myTransform.position, player.transform.position);
		timer -= Time.deltaTime;
		if (start) {

			Vector3 yAxis = myTransform.position;
			yAxis.y = 1.7f;
			myTransform.position = yAxis;

			score = Footsteps.count;

			if(slender.isVisible){
				myTransform.position += myTransform.forward * 0 * Time.deltaTime;
			}
			if(!slender.isVisible && distance >= stopDistance){
				myTransform.position += myTransform.forward * speed * Time.deltaTime;
			}
			if(distance >= 40f && !slender.isVisible){
				myTransform.position += myTransform.forward * speed * 4f * Time.deltaTime;
			}

			changeDistanceTimer -= Time.deltaTime;
			if(changeDistanceTimer <= 0f){
				stopDistance -= 3f;
				if(stopDistance <= 15f){
					stopDistance = 3f;
				}
				changeDistanceTimer = 10.0f;
			}

			stopDistance -= 0.00005f * score;

			if (stopDistance <= 5f && slender.isVisible && distance <= 10f){
				Time.timeScale = 0f;
				count -= 1;
				if (count <= 40){
					Application.LoadLevel("GameOver");
					Time.timeScale = 1f;
				}
			}

		}
	}
}
