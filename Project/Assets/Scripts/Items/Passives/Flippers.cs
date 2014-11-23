﻿using UnityEngine;
using System.Collections;

public class Flippers : Passive {

	// Use this for initialization
	public override string Name
	{
		get { return "Flippers"; }
	}

	public override string Description
	{
		get { return "Swim faster!"; }
	}

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public override void OnEquip(Player player)
    {
        player.SwimmingSpeed *= 2;
        player.Speed *= 0.5f;
    }

    public override void OnUnequip(Player player)
    {
        player.SwimmingSpeed *= 0.5f;
        player.Speed *= 2;
    }
}
