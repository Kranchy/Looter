using UnityEngine;
using System.Collections;

public class ThrowingKnife : Weapon
{
	// Use this for initialization
	public override string Name
	{
		get { return "Throwing knife"; }
	}

	public override string Description
	{
		get { return "Throw middle-range knives!"; }
	}

    void Start()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

	public override void Effect(int side){
		if (side == 0) {
			Instantiate (Resources.Load ("Prefabs/Projectiles/Couteau"),transform.position,transform.rotation);
		} else {
			Instantiate (Resources.Load ("Prefabs/Projectiles/couteauright"),transform.position,transform.rotation);
		}
	}
}
