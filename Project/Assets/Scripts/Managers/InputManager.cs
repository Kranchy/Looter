using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public GameObject PlayerObject;
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


        if (Player.OnGround)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                PlayerObject.transform.Translate(new Vector3(-Player.Speed, 0, 0));

                if (OnNewCommand != null) OnNewCommand(Command.Walk_Left);

                if (Input.GetAxis("Jump") > 0)
                {
                    JumpTime = 5;
                    
                    if (OnNewCommand != null) OnNewCommand(Command.Jump_Left);
                }
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                PlayerObject.transform.Translate(new Vector3(Player.Speed, 0, 0));

                if (OnNewCommand != null) OnNewCommand(Command.Walk_Right);

                if (Input.GetAxis("Jump") > 0)
                {
                    JumpTime = 5;


										if (OnNewCommand != null)
												OnNewCommand (Command.Jump_Right);
								}

						}

						if (JumpTime > 0) {
								RigidBody.AddForce (Vector3.up * 75);
								JumpTime -= 1;
						}

	
				}

        if (!Player.OnGround)
        {
            if (Player.Booted && Input.GetAxis("Jump") > 0)
            {
                JumpTime = 5;
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                PlayerObject.transform.Translate(new Vector3(-Player.Speed, 0, 0));

                if (OnNewCommand != null) OnNewCommand(Command.Jump_Left);
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                PlayerObject.transform.Translate(new Vector3(Player.Speed, 0, 0));

                if (OnNewCommand != null) OnNewCommand(Command.Jump_Right);
            }
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
