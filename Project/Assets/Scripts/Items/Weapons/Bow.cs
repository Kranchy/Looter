﻿using UnityEngine;
using System.Collections;

public class Bow : Weapon {

	// Use this for initialization
	public override string Name
	{
		get { return "Bow"; }
	}

	public override string Description
	{
		get { return "Shoot long-range arrows!"; }
	}

    public override void OnEquip(Player player)
    {
    }

    public override void OnUnequip(Player player)
    {
    }

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
