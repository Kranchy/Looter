using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	Player player;
	Rigidbody2D rb;
	int jumpTime;
	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent("Player") as Player;
		rb = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q")){
			gameObject.transform.Translate(new Vector3(-player.speed,0,0));
		}
		if (Input.GetKey("d")){
			gameObject.transform.Translate(new Vector3(player.speed,0,0));
		}
		if (Input.GetKeyDown(KeyCode.Space)){
			if (/*player.passive.name == "boots" ||*/ player.onGround){
				jumpTime = 5;
			}
		}
		if (jumpTime > 0) {
			rb.AddForce (Vector3.up * 100);
			jumpTime -= 1;
				}

	}
}
