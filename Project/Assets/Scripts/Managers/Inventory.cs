using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public Player Player;

    public List<Weapon> Weapons;
    public List<Util> Utils;
    public List<Passive> Passives;

    public void WeaponListUp()
    {
        Weapon temp = Weapons[0];
        Weapons.RemoveAt(0);
        Weapons.Insert(Weapons.Count - 1, temp);
    }
    public void UtilListUp()
    {
        Util temp = Utils[0];
        Utils.RemoveAt(0);
        Utils.Insert(Utils.Count - 1, temp);
    }
    public void PassiveListUp()
    {
        Passive temp = Passives[0];
        Passives.RemoveAt(0);
        Passives.Insert(Passives.Count - 1, temp);
    }
    public void WeaponListDown()
    {
        Weapon temp = Weapons[Weapons.Count - 1];
        Weapons.RemoveAt(Weapons.Count - 1);
        Weapons.Insert(0, temp);
    }
    public void UtilListDown()
    {
        Util temp = Utils[Utils.Count - 1];
        Utils.RemoveAt(Utils.Count - 1);
        Utils.Insert(0, temp);
    }
    public void PassiveListDown()
    {
        Passive temp = Passives[Passives.Count - 1];
        Passives.RemoveAt(Passives.Count - 1);
        Passives.Insert(0, temp);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
