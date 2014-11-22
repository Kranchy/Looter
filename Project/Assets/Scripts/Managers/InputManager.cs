using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	Player player;
	Rigidbody2D rb;
	int jumpTime;
	Vector3 movement;
	public ItemMenu im;

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

		// Capture des mouvements

		if (Input.GetAxis ("Horizontal") < -0) {
						gameObject.transform.Translate (new Vector3 (-player.Speed, 0, 0));
						if (player.OnGround) {
								if (currentAnim == player.AnimationGauche.Count) {
										currentAnim = 0;
								} else {
										currentAnim ++;
								}
								sr.sprite = player.AnimationGauche [currentAnim];

						}
				}
		if (Input.GetAxis("Horizontal") > 0){
			gameObject.transform.Translate(new Vector3(player.Speed,0,0));
			if(player.OnGround){
				if (currentAnim == player.AnimationDroite.Count ){
					currentAnim = 0;
				}
				else{
					currentAnim ++;
				}
				sr.sprite = player.AnimationDroite [currentAnim];
			}

		}
		if (Input.GetAxis("Jump")>0){

			if (player.Booted || player.OnGround){

				jumpTime = 5;
			}
		}
		if (jumpTime > 0) {
			rb.AddForce (Vector3.up * 100);
			jumpTime -= 1;
		}

		//Capture des actions

		if (Input.GetAxis ("Weapon") > 0)
        {
			if (Input.GetAxis ("ItemMenu") > 0)
            {
				im.OpenWeaponMenu();
			}
			else
            {
			}
		}
	}
}
