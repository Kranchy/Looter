using UnityEngine;
using System.Collections;

public class ItemMenu : MonoBehaviour {

	bool printWeaponMenu = false;
	int i;
	int selectedItem = 0;
	float lastTime;

    public Player Player;

	public Texture2D Selected;
	public Texture2D Unselected;

	void Start(){
		lastTime = Time.time;
	}

	void OnGUI () {
		// Make a background box


		if (printWeaponMenu) {
						for (i = 0; i < 3; i++) {
								if (i == selectedItem) {
										GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Selected);
								} else {
										GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Unselected);
								}
						}
				} else {
								GUI.Box(new Rect(Screen.width - 200,10,40,40), Selected);
				}

	}

	public void OpenWeaponMenu() {

		printWeaponMenu = true;

	}

	void Update(){
				if (Time.time >= lastTime + 0.1) {
						if (printWeaponMenu) {
								if (Input.GetAxis ("Weapon") > 0) {
										printWeaponMenu = false;
								}
								if (Input.GetAxisRaw ("ItemNext") > 0) {
										if (selectedItem == 2) {
												selectedItem = 0;
										} else {
												selectedItem ++;
										}
								}
								if (Input.GetAxisRaw ("ItemPrev") > 0) {
										if (selectedItem == 0) {
												selectedItem = 2;
										} else {
												selectedItem --;
										}
								}
						}
			        lastTime = Time.time;
				}
		}
}
