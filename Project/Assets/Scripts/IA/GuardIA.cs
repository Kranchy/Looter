using UnityEngine;
using System.Collections;

public class GuardIA : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if ((gameObject.GetComponent ("Enemy") as Enemy).OnGround) {
						transform.Translate (new Vector3 ((gameObject.GetComponent ("Enemy") as Enemy).speed, 0, 0));
				} else {
			(gameObject.GetComponent ("Enemy") as Enemy).speed = -(gameObject.GetComponent ("Enemy") as Enemy).speed;
						transform.Translate (new Vector3 (3*(gameObject.GetComponent ("Enemy") as Enemy).speed, 0, 0));
				}
	}
}
