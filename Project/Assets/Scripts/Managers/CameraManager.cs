using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target.transform.position.x >= gameObject.transform.position.x + 3) {
						gameObject.transform.Translate (new Vector3 (0.1f, 0, 0));
				}
		if (target.transform.position.x <= gameObject.transform.position.x - 3) {
						gameObject.transform.Translate (new Vector3 (-0.1f, 0, 0));
		}
		if (target.transform.position.y >= gameObject.transform.position.y + 1) {
			gameObject.transform.Translate (new Vector3 (0, 0.1f, 0));
		}
		if (target.transform.position.y <= gameObject.transform.position.y - 1) {
			gameObject.transform.Translate (new Vector3 (0, -0.1f, 0));
		}
	}
}
