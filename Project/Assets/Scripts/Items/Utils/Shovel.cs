using UnityEngine;
using System.Collections;

public class Shovel : Util
{
	// Use this for initialization
	public override string Name
	{
		get { return "Shovel"; }
	}

	public override string Description
	{
		get { return "Dig!"; }
	}

    void Start()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
    }

	public override void Effect(int side){
		Instantiate (Resources.Load ("Prefabs/Projectiles/Shovel"),transform.position + new Vector3(0,-0.5f,0),transform.rotation);
		}
}
