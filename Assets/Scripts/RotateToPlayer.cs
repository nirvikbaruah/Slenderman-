using UnityEngine;
using System.Collections;

public class RotateToPlayer : MonoBehaviour {

	public Transform targetPosition;// we have to add in the Inspector our target
	private int damp = 5; // we can change the slerp velocity here
	private Quaternion rotationAngle;
	
	void Update ()
	{
		if ( targetPosition ) // we get sure the target is here
		{
			rotationAngle = Quaternion.LookRotation ( targetPosition.position - transform.position); // we get the angle has to be rotated
			transform.rotation = Quaternion.Slerp ( transform.rotation, rotationAngle, Time.deltaTime * damp); // we rotate the rotationAngle 
		}
	}

}
