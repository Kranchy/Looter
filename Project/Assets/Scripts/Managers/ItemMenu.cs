using UnityEngine;
using System.Collections;

public class ItemMenu : MonoBehaviour {

	bool printWeaponMenu = false;
	bool printUtilMenu = false;
	bool printPassiveMenu = false;
	int i;
	int selectedItem = 0;
	float lastTime;

    public Player Player;
	public Inventory Inventory;

	public Texture2D Selected;
	public Texture2D Unselected;

	void Start(){
		lastTime = Time.time;
	}

	void OnGUI () {
		// Make a background box


		if (printWeaponMenu) {
						for (i = 0; i < (Inventory.Weapons.Count); i++) {
								if (i == selectedItem) {
										GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Selected);
								} else {
										GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Unselected);
								}
				GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Inventory.Weapons[i].Icon);
						}
				} else {
								GUI.Box(new Rect(Screen.width - 200,10,40,40), Selected);
			//GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Player.Weapon.Icon);
				}

		if (printUtilMenu) {
			for (i = 0; i < (Inventory.Utils.Count); i++) {
				if (i == selectedItem) {
					GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Selected);
				} else {
					GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Unselected);
				}
				GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Inventory.Utils[i].Icon);
			}
		} else {
			GUI.Box(new Rect(Screen.width - 150,10,40,40), Selected);
			//GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Player.Util.Icon);
		}

		if (printPassiveMenu) {
			for (i = 0; i < (Inventory.Passives.Count); i++) {
				if (i == selectedItem) {
					GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Selected);
				} else {
					GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Unselected);
				}
				GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Inventory.Passives[i].Icon);
			}
		} else {
			GUI.Box(new Rect(Screen.width - 100,10,40,40), Selected);
			//GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Player.Passive.Icon);
		}

	}

	public void OpenWeaponMenu() {

		printWeaponMenu = true;
		printUtilMenu = false;
		printPassiveMenu = false;

	}

	public void OpenUtilMenu() {
		
		printUtilMenu = true;
		printWeaponMenu = false;
		printPassiveMenu = false;
		
	}

	public void OpenPassiveMenu() {
		
		printPassiveMenu = true;
		printWeaponMenu = false;
		printUtilMenu = false;
		
	}

	void Update(){
				if (Time.time >= lastTime + 0.1) {
						if (printWeaponMenu) {
								if (Input.GetAxis ("Weapon") > 0) {
										printWeaponMenu = false;
								}
								if (Input.GetAxisRaw ("ItemNext") > 0) {
					if (selectedItem == (Inventory.Weapons.Count - 1)) {
												selectedItem = 0;
										} else {
												selectedItem ++;
										}
								}
								if (Input.GetAxisRaw ("ItemPrev") > 0) {
										if (selectedItem == 0) {
						selectedItem = (Inventory.Weapons.Count - 1);
										} else {
												selectedItem --;
										}
								}
						}

			if (printUtilMenu) {
				if (Input.GetAxis ("Util") > 0) {
					printUtilMenu = false;
				}
				if (Input.GetAxisRaw ("ItemNext") > 0) {
					if (selectedItem == (Inventory.Utils.Count - 1)) {
						selectedItem = 0;
					} else {
						selectedItem ++;
					}
				}
				if (Input.GetAxisRaw ("ItemPrev") > 0) {
					if (selectedItem == 0) {
						selectedItem = (Inventory.Utils.Count - 1);
					} else {
						selectedItem --;
					}
				}
			}
			if (printPassiveMenu) {
				if (Input.GetAxis ("Passive") > 0) {
					printPassiveMenu = false;
				}
				if (Input.GetAxisRaw ("ItemNext") > 0) {
					if (selectedItem == (Inventory.Passives.Count - 1)) {
						selectedItem = 0;
					} else {
						selectedItem ++;
					}
				}
				if (Input.GetAxisRaw ("ItemPrev") > 0) {
					if (selectedItem == 0) {
						selectedItem = (Inventory.Passives.Count - 1);
					} else {
						selectedItem --;
					}
				}
			}
			lastTime = Time.time;

				}
		}
}
