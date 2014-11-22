using UnityEngine;
using System.Collections;

public class Armor : Passive {

	// Use this for initialization
    public override string Name
    {
        get { return "Armor"; }
    }

    public override string Description
    {
        get { return "Protect yourself but move slower!"; }
    }

    public override void OnEquip(Player player)
    {
        player.Armored = true;
        player.Speed *= 0.5f;
    }

    public override void OnUnequip(Player player)
    {
        player.Armored = false;
        player.Speed *= 2;
    }

    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
