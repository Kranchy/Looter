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

	public void OnCollisionEnter2D(Collision2D collider){
	
		OnGround = true;
	}

	public void OnCollisionExit2D(Collision2D collider){
		
		OnGround = false;
	}


}

