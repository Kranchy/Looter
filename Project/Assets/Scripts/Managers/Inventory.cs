using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public Player Player;

    public Weapon EquippedWeapon { get; set; }
    public Util EquippedUtil { get; set; }
    public Passive EquippedPassive { get; set; }

    public List<Weapon> Weapons;
    public List<Util> Utils;
    public List<Passive> Passives;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
