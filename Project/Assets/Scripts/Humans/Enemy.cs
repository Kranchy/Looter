using UnityEngine;
using System.Collections;

public class Enemy : Human {
	
	public bool OnGround;
	public float speed;

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.contacts[0].normal.x == 0)
		{
			
			OnGround = true;
		}
	}
	
	public void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.contacts[0].normal.x == 0)
		{
			OnGround = false;
		}
	}

}
