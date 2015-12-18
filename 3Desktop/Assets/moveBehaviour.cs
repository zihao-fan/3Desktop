using UnityEngine;
using System.Collections;

public class moveBehaviour : MonoBehaviour {
	
	public float smooth = 2.0f;
	public float tiltAngle = 60.0f;
	public bool leapIsEnabled = false;

	void Update () 
	{
		if(leapIsEnabled)
		{
			float rotate = LDCLeapControl.getHandInput("Rotation");
			float tiltAroundY = rotate * tiltAngle;
			Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		}

	}
}
