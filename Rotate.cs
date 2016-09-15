using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	int rot = -10;
	bool stopLine = true;
	float mx;
	float mz;
	float my;
	
	float randomNumber(){
		return Random.Range(-0.2,0.2);
	}
	
	void Start(){
		start();
	}
	
	void start(){
		mx = randomNumber();
		my = randomNumber();
		mz = randomNumber();
	}
	
	void Update () 
	{
		
		float x = gameObject.transform.rotation.x;
		float y = gameObject.transform.rotation.y; 
		float z = gameObject.transform.rotation.z; 
		Debug.Log (x);
		int a,b,c = 0;
		if(y*y < my*my){a = mx*Random.Range(10,25)+1; }
		else {my = randomNumber();}
		if(z * z < mz * mz){b = mx*Random.Range(10,25)+1;}
		else{mz = randomNumber();}
		if (x *x < mx*mx) {c =mx*Random.Range(10,25)+1;}
		else{mx = randomNumber();}
	
		transform.Rotate (new Vector3 (a,b,c) * Time.deltaTime);
	
	}
}
