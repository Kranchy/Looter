using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Util : Item
{
    public List<Sprite> UsageAnimation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public abstract void Use();
}
