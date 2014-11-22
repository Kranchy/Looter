using UnityEngine;
using System.Collections.Generic;

public class Player : Human
{
    private Weapon Weapon { get; set; }
    private Util Util { get; set; }
    private Passive Passive { get; set; }

    public float SwimmingSpeed;

	public bool OnGround;
    public bool UsingWeapon;

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
		OnGround = true;
	}

	public void OnCollisionExit2D(Collision2D collider)
    {		
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

    public void UseWeapon(SpriteRenderer spriteRenderer)
    {
        UsingWeapon = true;
        Weapon.Animate(spriteRenderer);
        UsingWeapon = false;
    }

    public void UseUtil()
    {
        Util.Use();
    }
}

