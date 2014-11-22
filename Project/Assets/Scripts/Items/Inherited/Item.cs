using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour
{
    public abstract string Name { get; }

    public abstract string Description { get; }

    public Sprite Icon;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
    }
}
