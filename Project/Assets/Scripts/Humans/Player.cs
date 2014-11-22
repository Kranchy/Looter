using UnityEngine;
using System.Collections.Generic;

public class Player : Human {

	Weapon weapon;
	Util util;
	Passive passif;

	List<Weapon> weaponInventory;
	List<Util> utilInventory;
	List<Passive> passiveInventory;

    public float SwimmingSpeed;

	public bool OnGround;
    public bool Shielded;

	public List<Sprite> AnimationDroite;
	public List<Sprite> AnimationGauche;

	public void OnCollisionEnter2D(Collision2D collider){
	
		OnGround = true;
	}

	public void OnCollisionExit2D(Collision2D collider){
		
		OnGround = false;
	}


}

