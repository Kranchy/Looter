﻿using UnityEngine;
using System.Collections;

public class Arrow : Projectile
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

	void OnCollisionEnter2D(Collision2D collision)
    {
		Destroy (gameObject);
    }
}
