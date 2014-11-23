using UnityEngine;
using System.Collections;

public class ItemMenu : MonoBehaviour
{

		bool printWeaponMenu = false;
		bool printUtilMenu = false;
		bool printPassiveMenu = false;
		bool printSasMenu = false;
		int i;
		int selectedItem = 0;
		int selectedSasItemx = 0;
		int selectedSasItemy = 0;
		float lastTime;
		public Player Player;
		public Inventory Inventory;
		public Texture2D Selected;
		public Texture2D Unselected;

		void Start ()
		{
				lastTime = Time.time;

				Player.Weapon = Inventory.Weapons [0];
				Player.Util = Inventory.Utils [0];
				Player.Passive = Inventory.Passives [0];

		}

		void OnGUI ()
		{
				// Make a background box
				if (printSasMenu) {

						GUI.Box (new Rect (100, 10, 200, 300), "Séparez-vous d'un objet");
						for (i = 0; i < (Inventory.Utils.Count); i++) {
								if (i == selectedSasItemx && selectedSasItemy == 0) {
										GUI.Button (new Rect (130, 30 + 40 * i, 40, 40), Selected);
								} else {
										GUI.Button (new Rect (130, 30 + 40 * i, 40, 40), Unselected);
								}
								GUI.Button (new Rect (130, 30 + 40 * i, 40, 40), Inventory.Utils [i].Icon);
						}
						for (i = 0; i < (Inventory.Passives.Count); i++) {
								if (i == selectedSasItemx && selectedSasItemy == 1) {
										GUI.Button (new Rect (180, 30 + 40 * i, 40, 40), Selected);
								} else {
										GUI.Button (new Rect (180, 30 + 40 * i, 40, 40), Unselected);
								}
								GUI.Button (new Rect (180, 30 + 40 * i, 40, 40), Inventory.Passives [i].Icon);
						}
						for (i = 0; i < (Inventory.Weapons.Count); i++) {
								if (i == selectedSasItemx && selectedSasItemy == 2) {
										GUI.Button (new Rect (230, 30 + 40 * i, 40, 40), Selected);
								} else {
										GUI.Button (new Rect (230, 30 + 40 * i, 40, 40), Unselected);
								}
								GUI.Button (new Rect (230, 30 + 40 * i, 40, 40), Inventory.Weapons [i].Icon);
						}


				} else {
						if (printUtilMenu) {
								for (i = 0; i < (Inventory.Utils.Count); i++) {
										if (i == selectedItem) {
												GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Selected);
										} else {
												GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Unselected);
										}
										GUI.Button (new Rect (Screen.width - 200, 10 + 40 * i, 40, 40), Inventory.Utils [i].Icon);
								}
						} else {
								GUI.Button (new Rect (Screen.width - 200, 10, 40, 40), Selected);
								GUI.Button (new Rect (Screen.width - 200, 10, 40, 40), Player.Util.Icon);
						}

						if (printPassiveMenu) {
								for (i = 0; i < (Inventory.Passives.Count); i++) {
										if (i == selectedItem) {
												GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Selected);
										} else {
												GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Unselected);
										}
										GUI.Button (new Rect (Screen.width - 150, 10 + 40 * i, 40, 40), Inventory.Passives [i].Icon);
								}
						} else {
								GUI.Button (new Rect (Screen.width - 150, 10, 40, 40), Selected);
								GUI.Button (new Rect (Screen.width - 150, 10, 40, 40), Player.Passive.Icon);
						}

						if (printWeaponMenu) {
								for (i = 0; i < (Inventory.Weapons.Count); i++) {
										if (i == selectedItem) {
												GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Selected);
										} else {
												GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Unselected);
										}
										GUI.Button (new Rect (Screen.width - 100, 10 + 40 * i, 40, 40), Inventory.Weapons [i].Icon);
								}
						} else {
								GUI.Button (new Rect (Screen.width - 100, 10, 40, 40), Selected);
								GUI.Button (new Rect (Screen.width - 100, 10, 40, 40), Player.Weapon.Icon);
						}
				}

		}

		public void OpenWeaponMenu ()
		{

				printWeaponMenu = true;
				printUtilMenu = false;
				printPassiveMenu = false;

		}

		public void OpenUtilMenu ()
		{
		
				printUtilMenu = true;
				printWeaponMenu = false;
				printPassiveMenu = false;
		
		}

		public void OpenPassiveMenu ()
		{
		
				printPassiveMenu = true;
				printWeaponMenu = false;
				printUtilMenu = false;
		
		}

		public void OpenSasMenu ()
		{
	
				printSasMenu = true;

		
		}

		public void CloseSasMenu ()
		{

		
				printSasMenu = false;
		
		
		}

		void Update ()
		{
				if (Time.time >= lastTime + 0.1) {
						if (printWeaponMenu) {
								if (Input.GetAxis ("Weapon") > 0) {
										Player.Weapon = Inventory.Weapons [selectedItem];
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
										Player.Util = Inventory.Utils [selectedItem];
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
										Player.Passive = Inventory.Passives [selectedItem];
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
						if (printSasMenu) {
								if (Input.GetAxisRaw ("ItemBot") > 0) {
										if (selectedSasItemy == 0) {
												if (selectedSasItemx == (Inventory.Weapons.Count - 1)) {
														selectedSasItemx = 0;
												} else {
														selectedSasItemx ++;
												}
										}
										if (selectedSasItemy == 1) {
												if (selectedSasItemx == (Inventory.Utils.Count - 1)) {
														selectedSasItemx = 0;
												} else {
														selectedSasItemx ++;
												}
										}
										if (selectedSasItemy == 2) {
												if (selectedSasItemx == (Inventory.Passives.Count - 1)) {
														selectedSasItemx = 0;
												} else {
														selectedSasItemx ++;
												}
										}
								}
								if (Input.GetAxisRaw ("ItemTop") > 0) {
										if (selectedSasItemy == 0) {
												if (selectedSasItemx == 0) {
														selectedSasItemx = (Inventory.Weapons.Count - 1);
												} else {
														selectedSasItemx ++;
												}
										}
										if (selectedSasItemy == 1) {
												if (selectedSasItemx == 0) {
														selectedSasItemx = (Inventory.Utils.Count - 1);
												} else {
														selectedSasItemx ++;
												}
										}
										if (selectedSasItemy == 2) {
												if (selectedSasItemx == 0) {
														selectedSasItemx = (Inventory.Passives.Count - 1);
												} else {
														selectedSasItemx ++;
												}

										}
								}
								if (Input.GetAxisRaw ("ItemLeft") > 0) {
										if (selectedSasItemy == 0) {
												selectedSasItemy = 2;
										} else {
												selectedSasItemy --;
										}
								}
								if (Input.GetAxisRaw ("ItemRight") > 0) {
										if (selectedSasItemy == 2) {
												selectedSasItemy = 0;
										} else {
												selectedSasItemy ++;
										}
								}
//								if (Input.GetAxisRaw ("Jump") > 0) {
//									if (selectedSasItemy == 0) {
//									Inventory.Weapons[selectedSasItemx] = null;
//										
//								}
//					if (selectedSasItemy == 1) {
//						Inventory.Utils[selectedSasItemx] = null;
//						
//					}
//					if (selectedSasItemy == 2) {
//						Inventory.Passives[selectedSasItemx] = null;
//						
//					}
//				}

								

						}
				}
		}
}
