using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	int rot = -10;
	bool stopLine = true;

	void Update () 
	{
		
		float x = gameObject.transform.rotation.x; 
		Debug.Log (x);
		if (stopLine) {
			if (x < -0.2) {
				rot = 10;
				stopLine = false;
			}
		} else {
			if (x > 0.2) {
				rot = -10;
				stopLine = true;
			}
		}
		transform.Rotate (new Vector3 (rot, 0, 0) * Time.deltaTime);
	}
}