using UnityEngine;
using System.Collections;

public class Shield : Util
{
	// Use this for initialization
	public override string Name
	{
		get { return "Shield"; }
	}

	public override string Description
	{
		get { return "Hide from projectiles and push your enemies!"; }
	}

    void Start()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

	public override void Effect(int side){
		}
}
