using UnityEngine;
using System.Collections;

public abstract class Passive : Item
{
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

    public abstract void OnEquip(Player player);

    public abstract void OnUnequip(Player player);
}
