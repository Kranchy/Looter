﻿using UnityEngine;
using System.Collections;

public class Bomb : Weapon
{
	// Use this for initialization
	public override string Name
	{
		get { return "Bomb"; }
	}

	public override string Description
	{
		get { return "Burn it with fire!"; }
	}

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

	public override void Effect(int side){
		Instantiate (Resources.Load ("Prefabs/Projectiles/Bombe"),transform.position + new Vector3(0,-0.5f,0),transform.rotation);
		}
}
