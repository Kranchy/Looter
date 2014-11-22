﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public Player Player;
    public Rigidbody2D RigidBody;
    public SpriteRenderer LowerRenderer;
    public SpriteRenderer UpperRenderer;
    public ItemMenu ItemMenu;

	int JumpTime;
	Vector3 Movement;
	int CurrentAnim = 0;

    public enum Command
    {
        Walk_Right = 0,
        Walk_Left = 1,
        Jump_Right = 2,
        Jump_Left = 3,
        Use_Weapon_Right = 4,
        Use_Weapon_Left = 5,
        Use_Util_Right = 6,
        Use_Util_Left = 7
    }

    public delegate void NewCommandHandler(Command command);

    public static event NewCommandHandler OnNewCommand;

	// Use this for initialization
	void Start ()
	{
    }
	
	// Update is called once per frame
	void Update ()
	{
		// Capture des mouvements

		if (Input.GetAxis ("Horizontal") < 0)
        {
			gameObject.transform.Translate (new Vector3 (-Player.Speed, 0, 0));
			if (Player.OnGround)
            {
				if (CurrentAnim == Player.LowerAnimLeft.Count - 1)
                {
					CurrentAnim = 0;
			    }
                else
                {
		    		CurrentAnim ++;
	    		}
                LowerRenderer.sprite = Player.LowerAnimLeft[CurrentAnim];
                UpperRenderer.sprite = Player.UpperAnimLeft[CurrentAnim];

			}
		    else
            {
				if (CurrentAnim == Player.AnimationSautGauche.Count - 1)
                {
				    CurrentAnim = 0;
				}
                else
                {
					CurrentAnim ++;
                }
				LowerRenderer.sprite = Player.AnimationSautGauche[CurrentAnim];
				UpperRenderer.sprite = null;
			}
        }
		if (Input.GetAxis ("Horizontal") > 0)
        {
            gameObject.transform.Translate (new Vector3 (Player.Speed, 0, 0));
            if (Player.OnGround)
            {
                if (CurrentAnim == Player.LowerAnimRight.Count - 1)
                {
                    CurrentAnim = 0;
                } 
                else
                {
                    CurrentAnim ++;
                }
                LowerRenderer.sprite = Player.LowerAnimRight[CurrentAnim];
                UpperRenderer.sprite = Player.UpperAnimRight[CurrentAnim];
            }
			else
            {
				if (CurrentAnim == Player.AnimationSautDroite.Count - 1) {
					CurrentAnim = 0;
				} else {
					CurrentAnim ++;
				}

				LowerRenderer.sprite = Player.AnimationSautDroite [CurrentAnim];
				UpperRenderer.sprite = null;

			}
        }
        if (Input.GetAxis ("Jump") > 0)
        {
            if (Player.Booted || Player.OnGround)
            {
                JumpTime = 5;
            }
        }
        if (JumpTime > 0)
        {
            RigidBody.AddForce (Vector3.up * 75);
            JumpTime -= 1;
        }
        
        //Capture des actions
        
        if (Input.GetAxis ("Weapon") > 0)
        {
            if (Input.GetAxis ("ItemMenu") > 0)
            {
                ItemMenu.OpenWeaponMenu();
            }
            else
            {
                Player.UseWeapon(UpperRenderer);
            }
        }
        
        if (Input.GetAxis ("Util") > 0)
        {
            if (Input.GetAxis ("ItemMenu") > 0)
            {
                ItemMenu.OpenUtilMenu();
            }
            else
            {
            }
        }
        
        if (Input.GetAxis ("Passive") > 0)
        {
            if (Input.GetAxis ("ItemMenu") > 0)
            {
                ItemMenu.OpenPassiveMenu ();
            }
            else
            {
            }
        }
    }
}
