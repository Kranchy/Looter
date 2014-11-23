using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((gameObject.GetComponent ("Human") as Human).HP == 0) {
			Destroy (gameObject);
				}

		if (gameObject.transform.position.y < -10) {

			(gameObject.GetComponent ("Human") as Human).HP = 0;
			Application.LoadLevel (Application.loadedLevel);

				}
	}
}
