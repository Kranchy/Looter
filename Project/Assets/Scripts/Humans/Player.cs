using UnityEngine;
using System.Collections.Generic;

public class Player : Human
{
    private Weapon Weapon { get; set; }
    private Util Util { get; set; }
    private Passive Passive { get; set; }

    public float SwimmingSpeed;
	float distToGround;

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

//	public void OnCollisionEnter2D(Collision2D collision)
//    {	
//		OnGround = true;
//		foreach (ContactPoint2D contact in collision.contacts) {
//						if (contact.normal.x != 0) {
//								OnGround = false;
//						}
//				}
//				
//	}
//
//	public void OnCollisionExit2D(Collision2D collision)
//    {	
//		OnGround = false;
//		foreach (ContactPoint2D contact in collision.contacts) {
//			if (contact.normal.x != 0) {
//				OnGround = true;
//			}
//		}
//	}

	void Start(){

		}

	void Update() {
		if (Physics.Raycast (transform.position + new Vector3(0,-1,0), -Vector3.up, 0.1f))
						OnGround = true;
				else
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

