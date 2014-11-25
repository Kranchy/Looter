﻿﻿using UnityEngine;
using System.Collections.Generic;

public class Player : Human
{
    private float tookDmgTime;
    public float DamageDelay;

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

    void Start()
    {
        tookDmgTime = Time.time;
    }

    void Update()
    {
        //if (Physics.Raycast (transform.position + new Vector3(0,-1,0), -Vector3.up, 0.1f))
        //    OnGround = true;
        //else
        //	  OnGround = false;
    }

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if ((collision.contacts[0].normal.x == 0) && (collision.contacts[0].normal.y > 0))
		{
			OnGround = true;
            Debug.Log(collision.contacts[0].normal.x);
            Debug.Log(collision.contacts[0].normal.y);
        }
	}
	
	public void OnCollisionExit2D(Collision2D collision)
	{
        if ((collision.contacts[0].normal.x == 0) && (collision.contacts[0].normal.y > 0))
		{
			OnGround = false;
		}
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if ((Time.time > tookDmgTime + DamageDelay) && !(collider.GetComponent("Projectile") as Projectile).IsAlly)
        {
            tookDmgTime = Time.time;
            HP--;
        }
    }
}