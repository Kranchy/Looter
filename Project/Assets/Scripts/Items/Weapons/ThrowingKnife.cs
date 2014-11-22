using UnityEngine;
using System.Collections;

public class ThrowingKnife : Weapon {

	// Use this for initialization
	public override string Name
	{
		get { return "Throwing knife"; }
	}

	public override string Description
	{
		get { return "Throw middle-range knives!"; }
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
