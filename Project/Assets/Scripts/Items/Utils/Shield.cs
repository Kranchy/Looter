using UnityEngine;
using System.Collections;

public class Shield : Util {

	// Use this for initialization
	public override string Name
	{
		get { return "Shield"; }
	}

	public override string Description
	{
		get { return "Hide from projectiles and push your enemies!"; }
	}

    public override void OnEquip(Player player)
    {
        player.Shielded = true;
    }

    public override void OnUnequip(Player player)
    {
        player.Shielded = false;
    }

    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
