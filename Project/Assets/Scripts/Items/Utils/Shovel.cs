using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shovel : Util
{
	// Use this for initialization
	public override string Name
	{
		get { return "Shovel"; }
	}

	public override string Description
	{
		get { return "Dig!"; }
	}

    void Start()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
