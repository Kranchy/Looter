using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
	public List<int> levels;
	// Use this for initialization
	void Start()
    {
		//int[] levels;
		int i = 0;
		while (i <= 9)
        {
			int lvl = Random.Range(0,11);
			if(!levels.Contains(lvl))
            {
				levels[i] = lvl;
				i++;
			}
		}

		for (i = 0; i < 5; i++)
        {
            Instantiate(Resources.Load("Prefabs/Levels/map" + levels[i]), new Vector3(48 + 24 * (i - 1), 0, 0), transform.rotation);
        }
		for (i = 5; i < 10; i++)
        {
			Instantiate(Resources.Load("Prefabs/Levels/map" + levels[i]), new Vector3(72 + 24 * (i - 1), 0, 0), transform.rotation);
		}
		//Instantiate(Resources.Load ("Prefabs/Characters/Player"),new Vector3(2,-11,-10),transform.rotation);
	}
	
	// Update is called once per frame
	void Update()
    {
	}
}
