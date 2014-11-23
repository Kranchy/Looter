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
		if ((gameObject.GetComponent ("Human") as Human).HP == 0) {
			Destroy (gameObject);
				}

		if (gameObject.transform.position.y < -20) {

			(gameObject.GetComponent ("Human") as Human).HP = 0;
			Application.LoadLevel (Application.loadedLevel);

				}
	}

	void OnTriggerEnter2D(Collider2D collider){

				if (Time.time > tookDmgTime + 2) {

						(gameObject.GetComponent ("Human") as Human).HP --;

				}
		}

}
