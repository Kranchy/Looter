using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Weapon : Item
{
    public int Damage;
	public float Cooldown;

    public List<Sprite> UsageAnimRight;
    public List<Sprite> UsageAnimLeft;

    public AudioClip UsageSound;

	// Use this for initialization
	void Start()
    {
	}

	// Update is called once per frame
	void Update()
    {
	}

	public abstract void Effect(int side);
}
