using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sword : Weapon
{
    // Use this for initialization
	public override string Name
	{
		get { return "Sword"; }
	}

	public override string Description
	{
		get { return "Slash your foes!"; }
	}

    void Start()
    {
        Chrono = 10.0f;
        TimeLeft = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
    }

    public override void Animate(SpriteRenderer spriteRenderer)
    {
        int count = UsageAnimRight.Count;
        int i = 0;
        while (i < count)
        {
            if (TimeLeft <= 0)
            {
                spriteRenderer.sprite = UsageAnimRight[i];
                TimeLeft = Chrono;
                i++;
            }
            Update();
        }
    }
}
