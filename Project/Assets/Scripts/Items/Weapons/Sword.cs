﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sword : Weapon
{
    // Use this for initialization
	public override string Name
	{
		get { return "Sword"; }
	}

	public override string Description
	{
		get { return "Slash your foes!"; }
	}

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}