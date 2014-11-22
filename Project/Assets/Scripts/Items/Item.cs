using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour
{
    public abstract string Name { get; }

    public abstract string Description { get; }

    public abstract void OnEquip(Player player);

    public abstract void OnUnequip(Player player);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
