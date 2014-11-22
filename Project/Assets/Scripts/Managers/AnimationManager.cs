using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour
{
    public Player Player;
    public SpriteRenderer UpperRenderer;
    public SpriteRenderer LowerRenderer;

    public Weapon Weapon { get; set; }
    public Util Util { get; set; }
    public Passive Passive { get; set; }

	// Use this for initialization
	void Start ()
    {
        LowerRenderer.sprite = Player.LowerAnimRight[0];
        UpperRenderer.sprite = Player.UpperAnimRight[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
