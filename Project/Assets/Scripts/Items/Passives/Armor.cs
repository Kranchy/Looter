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
        throw new System.NotImplementedException();
    }

    public override void OnUnequip(Player player)
    {
        throw new System.NotImplementedException();
    }

    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
