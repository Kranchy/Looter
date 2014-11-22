using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shield : Util
{
	// Use this for initialization
	public override string Name
	{
		get { return "Shield"; }
	}

	public override string Description
	{
		get { return "Hide from projectiles and push your enemies!"; }
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
