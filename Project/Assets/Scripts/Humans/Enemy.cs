using UnityEngine;
using System.Collections;

public class Enemy : Human
{
	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.contacts[0].normal.x == 0)
		{
			
			OnGround = true;
		}
	}

	void OnTriggerEnter2D(Collider2D shotCollider)
	{
        if (shotCollider.gameObject.tag == "Projectile")
        {
            Projectile projectile = ((Projectile)shotCollider.gameObject.GetComponent("Projectile"));
            if (projectile.IsAlly)
            {
                HP -= projectile.Damage;
                Destroy(shotCollider.gameObject);
            }
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
