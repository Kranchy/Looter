using UnityEngine;
using System.Collections;

public class EndGameManager : MonoBehaviour
{
    public Player Player;

	// Use this for initialization
	void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
		if (Player.HP <= 0)
        {
			Destroy(Player.gameObject);
            Application.LoadLevel("GameOverScreen");
        }

		if (Player.gameObject.transform.position.y < -20)
        {
			Player.HP = 0;
        }

		if (Player.gameObject.transform.position.x >= 300)
        {
			Application.LoadLevel("StartingScreen");
        }
	}
}
