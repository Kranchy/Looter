using UnityEngine;
using System.Collections.Generic;

public class Player : Human {

	Weapon weapon;
	Util util;
	Passive passif;

	List<Weapon> weaponInventory;
	List<Util> utilInventory;
	List<Passive> passiveInventory;

	public bool onGround;

	public void OnCollisionEnter2D(Collision2D collider){
	
		onGround = true;
	}

	public void OnCollisionExit2D(Collision2D collider){
		
		onGround = false;
	}


}

