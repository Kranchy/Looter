using UnityEngine;
using System.Collections;

public class Boots : Passive {

	// Use this for initialization
    public override string Name
    {
        get { return "Boots"; }
    }

    public override string Description
    {
        get { return "Do a double jump!"; }
    }

    public override void OnEquip(Player player)
    {
        throw new System.NotImplementedException();
    }

    public override void OnUnequip(Player player)
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
