using UnityEngine;
using System.Collections;

public class Enemy : Human
{
    void Start()
    {
    }

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.y < -20)
        {
            HP = 0;
        }
    }

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
