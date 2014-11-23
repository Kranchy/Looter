using UnityEngine;
using System.Collections;

public class GuardIA : MonoBehaviour {

	bool goesRight;
	int steps;
	float autoTurn;
	// Use this for initialization
	void Start () {
		goesRight = false;
		steps = 0;
		autoTurn = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if ((gameObject.GetComponent ("Enemy") as Enemy).OnGround && Time.time < (autoTurn + 4)) {
						transform.Translate (new Vector3 ((gameObject.GetComponent ("Enemy") as Enemy).speed, 0, 0));
				if (goesRight){
				//(gameObject.GetComponent ("SpriteRenderer") as SpriteRenderer).sprite = Resources.Load ("Sprite/AnimationGGroite/Garde" + steps) as Sprite;
				Debug.Log (("Sprite/AnimationGGroite/Garde" + steps));
				if (steps == 4) steps = 0;
				else steps ++;
				if (!goesRight){
					//(gameObject.GetComponent ("SpriteRenderer") as SpriteRenderer).sprite = Resources.Load ("Sprite/AnimationGGauche/Garde" + steps)as Sprite;
					if (steps == 4) steps = 0;
					else steps ++;
				}
			}
		
		
		} else {
			(gameObject.GetComponent ("Enemy") as Enemy).speed = -(gameObject.GetComponent ("Enemy") as Enemy).speed;
						transform.Translate (new Vector3 (3*(gameObject.GetComponent ("Enemy") as Enemy).speed, 0, 0));
			goesRight = !goesRight;
			autoTurn = Time.time;
				}
	}
}
