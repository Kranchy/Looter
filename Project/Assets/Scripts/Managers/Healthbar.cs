using UnityEngine;
using System.Collections.Generic;

public class Healthbar : MonoBehaviour {

	public Player player;
	public List<Texture2D> bar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI ()
	{GUI.Button (new Rect (10, 10, 200, 50), bar[player.HP]);

		}
}
