using UnityEngine;
using System.Collections;

public class Shovel : Util {

	// Use this for initialization
	public override string Name
	{
		get { return "Shovel"; }
	}

	public override string Description
	{
		get { return "Dig!"; }
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
