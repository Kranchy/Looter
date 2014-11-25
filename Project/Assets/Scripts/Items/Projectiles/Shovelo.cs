﻿using UnityEngine;
using System.Collections;

public class Shovelo : Projectile
{
	// Use this for initialization
	void Start ()
    {
		Destroy (gameObject, Delay);
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform.Translate (new Vector3 (Speed, 0f, 0f));
	}

	void OnTriggerStay2D(Collider2D collision)
    {
        Destroy (collision.gameObject, 0.2f);
    }
}
