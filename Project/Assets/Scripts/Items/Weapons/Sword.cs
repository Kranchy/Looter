using UnityEngine;
using System.Collections;

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
	void Update ()
    {
    }

	public override void Effect(int side)
    {
        if (side == 0)
        {
            GameObject go = Instantiate(Resources.Load("Prefabs/Projectiles/SwordProjectile"), transform.position, transform.rotation) as GameObject;
            Swordo swordo = go.GetComponent("Swordo") as Swordo;
            swordo.Speed = 1;
            swordo.Damage = this.Damage;
        }
        else
        {
            GameObject go = Instantiate(Resources.Load("Prefabs/Projectiles/SwordProjectile"), transform.position, transform.rotation) as GameObject;
            Swordo swordo = go.GetComponent("Swordo") as Swordo;
            swordo.Speed = -1;
            swordo.Damage = this.Damage;
        }
	}
}
