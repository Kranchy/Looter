using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
