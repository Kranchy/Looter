using UnityEngine;
using System.Collections;

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
	void Update ()
    {
    }

	public override void Effect (int side){
		if (side == 0)
        {
            GameObject go = Instantiate(Resources.Load("Prefabs/Projectiles/fleche"), transform.position, transform.rotation) as GameObject;
            Arrow arrow = go.GetComponent("Arrow") as Arrow;
            arrow.Damage = this.Damage;
            arrow.IsAlly = true;
        }
        else
        {
            GameObject go = Instantiate(Resources.Load("Prefabs/Projectiles/flecheright"), transform.position, transform.rotation) as GameObject;
            Arrow arrow = go.GetComponent("Arrow") as Arrow;
            arrow.Damage = this.Damage;
            arrow.IsAlly = true;
        }
	}
}
