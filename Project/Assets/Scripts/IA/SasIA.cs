using UnityEngine;
using System.Collections;

public class SasIA : MonoBehaviour {

	public Player player;
	public ItemMenu itemMenu;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if ((player.transform.position.x >= transform.position.x - 1) && (player.transform.position.x <= transform.position.x + 1)) {
						if ((player.transform.position.y >= transform.position.y - 3) && (player.transform.position.y <= transform.position.y + 3)) {
								itemMenu.OpenSasMenu ();
						}
			else {
				itemMenu.CloseSasMenu ();
			}


				} 
	}
}
