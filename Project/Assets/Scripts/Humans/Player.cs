﻿using UnityEngine;
using System.Collections.Generic;

public class Player : Human
{
    public Weapon Weapon { get; set; }
    public Util Util { get; set; }
    public Passive Passive { get; set; }

    public enum Direction
    {
        Right = 0,
        Left = 1
    }

    public Direction Orientation { get; set; }

    public float SwimmingSpeed;

	public bool OnGround;
    public bool UsingWeapon;
    public bool UsingUtil;

    public bool Armored;
    public bool Shielded;
    public bool Booted;

	public List<Sprite> LowerAnimRight;
    public List<Sprite> LowerAnimLeft;
    public List<Sprite> UpperAnimRight;
    public List<Sprite> UpperAnimLeft;
	public List<Sprite> JumpAnimRight;
	public List<Sprite> JumpAnimLeft;

	public void OnCollisionEnter2D(Collision2D collision)
    {	
		if (collision.contacts [0].normal.x == 0) {
						OnGround = true;
				}
				
	}

	public void OnCollisionExit2D(Collision2D collision)
    {		
		if (collision.contacts [0].normal.x == 0) {
						OnGround = false;
				}
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

