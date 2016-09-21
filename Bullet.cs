using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Bullet")
			return;
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (health  != null)
		{
			Debug.LogError ("CALLING TAKE DAMAGE FROM @BULLET");
			health.TakeDamage(1);
		}

		Destroy(gameObject);
	}
}
