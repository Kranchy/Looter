using UnityEngine;
using System.Collections;

public class Sword : Weapon {

	// Use this for initialization
	public override string Name
	{
		get { return "Sword"; }
	}

	public override string Description
	{
		get { return "Slash your foes!"; }
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
