using UnityEngine;
using System.Collections;

public class Shovelo : MonoBehaviour {

	public float speed;
	float putTime;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 0.2f);
		putTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (speed, 0f, 0f));
	}

	void OnTriggerStay2D(Collider2D collision){

				Destroy (collision.gameObject, 0.2f);
		}


}
