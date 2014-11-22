using UnityEngine;
using System.Collections;

public class Bomb : Weapon {

	// Use this for initialization
	public override string Name
	{
		get { return "Bomb"; }
	}

	public override string Description
	{
		get { return "Burn it with fire!"; }
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
