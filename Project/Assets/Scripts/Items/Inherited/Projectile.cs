using UnityEngine;
using System.Collections;

public abstract class Projectile : MonoBehaviour
{
    public float Speed;

    public float Delay;

	public bool IsAlly { get; set; }

    public int Damage { get; set; }

	// Use this for initialization
	void Start ()
	{
        Destroy(gameObject, Delay);
	}
	
	// Update is called once per frame
	void Update ()
	{
        transform.Translate(new Vector3(Speed, 0f, 0f));
	}
}

