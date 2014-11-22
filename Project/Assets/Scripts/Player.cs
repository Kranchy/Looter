using UnityEngine;
using System.Collections.Generic;

public class Player : Human {

	Weapon weapon;
	Util util;
	Passive passif;

	List<Weapon> weaponInventory;
	List<Util> utilInventory;
	List<Passive> passiveInventory;

	bool onGround;

}
