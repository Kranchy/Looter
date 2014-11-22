using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bow : Weapon
{
	// Use this for initialization
	public override string Name
	{
		get { return "Bow"; }
	}

	public override string Description
	{
		get { return "Shoot long-range arrows!"; }
	}

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public override void Animate(SpriteRenderer spriteRenderer)
    {
        throw new System.NotImplementedException();
    }
}
