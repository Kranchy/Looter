﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	Player player;
	Rigidbody2D rb;
	int jumpTime;
	Vector3 movement;

	SpriteRenderer sr;
	int currentAnim = 0;

	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent("Player") as Player;
		rb = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;
		sr = gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
		sr.sprite = player.AnimationDroite [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q")){
			gameObject.transform.Translate(new Vector3(-player.Speed,0,0));
		}
		if (Input.GetKey("d")){
			gameObject.transform.Translate(new Vector3(player.Speed,0,0));

			if (currentAnim == player.AnimationGauche.Count ){
				currentAnim = 0;
			}
			else{
				currentAnim ++;
			}
			sr.sprite = player.AnimationGauche [currentAnim];

		}
		if (Input.GetKey("d")){
			gameObject.transform.Translate(new Vector3(player.Speed,0,0));
			if (currentAnim == player.AnimationDroite.Count ){
				currentAnim = 0;
			}
			else{
				currentAnim ++;
			}
			sr.sprite = player.AnimationDroite [currentAnim];

		}
		if (Input.GetKeyDown(KeyCode.Space)){

			if (player.Booted || player.OnGround){

				jumpTime = 5;
			}
		}
		if (jumpTime > 0) {
			rb.AddForce (Vector3.up * 100);
			jumpTime -= 1;
		}


	}
}
