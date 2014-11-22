﻿using UnityEngine;
using System.Collections;

public class ItemMenu : MonoBehaviour {

	bool printWeaponMenu = false;
	bool printUtilMenu = false;
	bool printPassiveMenu = false;
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

		if (printUtilMenu) {
			for (i = 0; i < 3; i++) {
				if (i == selectedItem) {
					GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Selected);
				} else {
					GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Unselected);
				}
			}
		} else {
			GUI.Box(new Rect(Screen.width - 150,10,40,40), Selected);
		}

		if (printPassiveMenu) {
			for (i = 0; i < 3; i++) {
				if (i == selectedItem) {
					GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Selected);
				} else {
					GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Unselected);
				}
			}
		} else {
			GUI.Box(new Rect(Screen.width - 100,10,40,40), Selected);
		}

	}

	public void OpenWeaponMenu() {

		printWeaponMenu = true;

	}

	public void OpenUtilMenu() {
		
		printUtilMenu = true;
		
	}

	public void OpenPassiveMenu() {
		
		printPassiveMenu = true;
		
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

			if (printUtilMenu) {
				if (Input.GetAxis ("Util") > 0) {
					printUtilMenu = false;
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
			if (printPassiveMenu) {
				if (Input.GetAxis ("Passive") > 0) {
					printPassiveMenu = false;
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
