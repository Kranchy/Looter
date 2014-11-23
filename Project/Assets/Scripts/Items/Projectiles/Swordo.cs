﻿using UnityEngine;
using System.Collections;

public class Swordo : MonoBehaviour
{
    public float Speed { get; set; }

    public int Damage { get; set; }

    // Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(Speed, 0f, 0f));
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
