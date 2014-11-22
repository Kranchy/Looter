using UnityEngine;
using System.Collections.Generic;

public class Player : Human
{
    private Weapon Weapon { get; set; }
    private Util Util { get; set; }
    private Passive Passive { get; set; }

    public float SwimmingSpeed;

	public bool OnGround;

    public bool Armored;
    public bool Shielded;
    public bool Booted;

	public List<Sprite> LowerAnimRight;
    public List<Sprite> LowerAnimLeft;
    public List<Sprite> UpperAnimRight;
    public List<Sprite> UpperAnimLeft;
	public List<Sprite> AnimationSautDroite;
	public List<Sprite> AnimationSautGauche;

	public void OnCollisionEnter2D(Collision2D collider)
    {	
		if(collider.transform.position.y < gameObject.transform.position.y)
		OnGround = true;
	}

	public void OnCollisionExit2D(Collision2D collider)
    {		
		if(collider.transform.position.y < gameObject.transform.position.y)
		OnGround = false;
	}

    public void EquipWeapon(Weapon weapon)
    {
        Weapon = weapon;
    }

    public void EquipUtil(Util util)
    {
        Util = util;
    }

    public void EquipPassive(Passive passive)
    {
        Passive = passive;
    }

    public void UseWeapon()
    {
        Weapon.Use();
    }

    public void UseUtil()
    {
        Util.Use();
    }
}

