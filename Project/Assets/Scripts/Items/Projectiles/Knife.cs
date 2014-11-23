﻿using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour
{
	public float speed;

    public int Damage { get; set; }

	// Use this for initialization
	void Start ()
    {
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform.Translate(new Vector3 (speed, 0f, 0f));
	}

	void OnCollisionEnter2D(Collision2D collision)
    {
		Destroy (gameObject);
    }


}
