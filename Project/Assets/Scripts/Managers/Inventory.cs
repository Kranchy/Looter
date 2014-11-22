using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public Player Player;
    public AnimationManager AnimationManager;

    public List<Weapon> Weapons;
    public List<Util> Utils;
    public List<Passive> Passives;

    public float Chrono;
    private float TimeLeft { get; set; }
    
    // Use this for initialization
	void Start ()
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/Items/Sword"));
        Sword sword = (Sword)go.GetComponent("Sword");
        Player.EquipWeapon(sword);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else
        {
            //TODO : cacher les menus
        }
    }

    public void WeaponListUp()
    {
        Weapon temp = Weapons[0];
        Weapons.RemoveAt(0);
        Weapons.Insert(Weapons.Count - 1, temp);

        TimeLeft = Chrono;
    }
    public void UtilListUp()
    {
        Util temp = Utils[0];
        Utils.RemoveAt(0);
        Utils.Insert(Utils.Count - 1, temp);

        TimeLeft = Chrono;
    }
    public void PassiveListUp()
    {
        Passive temp = Passives[0];
        Passives.RemoveAt(0);
        Passives.Insert(Passives.Count - 1, temp);

        TimeLeft = Chrono;
    }
    public void WeaponListDown()
    {
        Weapon temp = Weapons[Weapons.Count - 1];
        Weapons.RemoveAt(Weapons.Count - 1);
        Weapons.Insert(0, temp);

        TimeLeft = Chrono;
    }
    public void UtilListDown()
    {
        Util temp = Utils[Utils.Count - 1];
        Utils.RemoveAt(Utils.Count - 1);
        Utils.Insert(0, temp);

        TimeLeft = Chrono;
    }
    public void PassiveListDown()
    {
        Passive temp = Passives[Passives.Count - 1];
        Passives.RemoveAt(Passives.Count - 1);
        Passives.Insert(0, temp);

        TimeLeft = Chrono;
    }
}
