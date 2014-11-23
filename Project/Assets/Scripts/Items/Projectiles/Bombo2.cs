﻿using UnityEngine;
using System.Collections;

public class Bombo2 : MonoBehaviour
{
	public float speed;

    public int Damage { get; set; }

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform.Translate (new Vector3 (speed, 0f, 0f));
	}

	void OnTriggerStay2D(Collider2D collision)
    {
        Destroy (collision.gameObject, 5);
    }
}
