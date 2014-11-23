﻿using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
	public float speed;

    public bool IsAlly { get; set; }

    public int Damage { get; set; }

	// Use this for initialization
	void Start ()
    {
		Destroy (gameObject, 4);
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform.Translate (new Vector3 (speed, 0f, 0f));
	}

	void OnCollisionEnter2D(Collision2D collision)
    {
		Destroy (gameObject);
    }


}
