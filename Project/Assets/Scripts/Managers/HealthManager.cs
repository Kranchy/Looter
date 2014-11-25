using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	float tookDmgTime;
	// Use this for initialization
	void Start () {
		tookDmgTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if ((gameObject.GetComponent ("Human") as Human).HP <= 0) {
			Destroy (gameObject);
				}

		if (gameObject.transform.position.y < -20) {

			(gameObject.GetComponent ("Human") as Human).HP = 0;

				}
		if ((gameObject.GetComponent ("Human") as Human).transform.position.x >= 300) {

			Application.LoadLevel ("StartingScreen");

				}


	}



	void OnTriggerEnter2D(Collider2D collider){

				if ((Time.time > tookDmgTime + 2) && !(collider.GetComponent ("Projectiles") as Projectile).IsAlly) {
				
						(gameObject.GetComponent ("Human") as Human).HP --;
				
				}
		}


}
