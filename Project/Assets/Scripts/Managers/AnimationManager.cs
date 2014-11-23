using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour
{
    public InputManager InputManager;

    public Player Player;
    public SpriteRenderer UpperRenderer;
    public SpriteRenderer LowerRenderer;

    public int LowerAnimCount { get; set; }
    public int UpperAnimCount { get; set; }
    public int LowerAnimIndex { get; set; }
    public int UpperAnimIndex { get; set; }
	public AudioClip Soundwalk;

	float useTime;

	// Use this for initialization
	void Start ()
    {
        LowerAnimCount = Player.LowerAnimRight.Count;
        UpperAnimCount = Player.UpperAnimRight.Count;

        LowerAnimIndex = 0;
        UpperAnimIndex = 0;

        LowerRenderer.sprite = Player.LowerAnimRight[0];
        UpperRenderer.sprite = Player.UpperAnimRight[0];

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Player.UsingWeapon)
        {
            if (Player.Orientation == Player.Direction.Left)
                AnimWeaponLeft();
            if (Player.Orientation == Player.Direction.Right)
                AnimWeaponRight();
        }
        
        if (Player.UsingUtil)
        {
            if (Player.Orientation == Player.Direction.Left)
                AnimUtilLeft();
            if (Player.Orientation == Player.Direction.Right)
                AnimUtilRight();
        }
    }

    void OnEnable()
    {
        InputManager.OnNewCommand += NewCommandHandler;
    }

    void OnDisable()
    {
        InputManager.OnNewCommand -= NewCommandHandler;
    }

    protected void NewCommandHandler(InputManager.Command command)
    {
        if (command == InputManager.Command.Walk_Right)
        {
            LowerAnimCount = Player.LowerAnimRight.Count;
			
			audio.PlayOneShot(Soundwalk);
			
            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            if (!Player.UsingWeapon && !Player.UsingUtil) UpdateUpperAnim();

            AnimWalkRight();
        }

        if (command == InputManager.Command.Walk_Left)
        {
            LowerAnimCount = Player.LowerAnimLeft.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            if (!Player.UsingWeapon && !Player.UsingUtil) UpdateUpperAnim();

            AnimWalkLeft();
        }

        if (command == InputManager.Command.Jump_Right)
        {
            LowerAnimCount = Player.JumpAnimRight.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            if (!Player.UsingWeapon && !Player.UsingUtil) UpdateUpperAnim();

            AnimJumpRight();
        }

        if (command == InputManager.Command.Jump_Left)
        {
            LowerAnimCount = Player.JumpAnimLeft.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            if (!Player.UsingWeapon && !Player.UsingUtil) UpdateUpperAnim();

            AnimJumpLeft();
        }

        if (command == InputManager.Command.Use_Weapon_Right)
        {
            if (!Player.UsingWeapon && !Player.UsingUtil)
            {
                UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
                UpperAnimIndex = 0;

                Player.UsingWeapon = true;
            }
			if(Time.time > useTime + Player.Weapon.Cd){
				Player.Weapon.Effect (0);
				useTime = Time.time;
			}
        }

        if (command == InputManager.Command.Use_Weapon_Left)
        {
            if (!Player.UsingWeapon && !Player.UsingUtil)
            {
                UpperAnimCount = Player.Weapon.UsageAnimLeft.Count;
                UpperAnimIndex = 0;

                Player.UsingWeapon = true;
            }
			if(Time.time > useTime + Player.Weapon.Cd){
				Player.Weapon.Effect (1);
				useTime = Time.time;
			}
        }

        if (command == InputManager.Command.Use_Util_Right)
        {
            if (!Player.UsingWeapon && !Player.UsingUtil)
            {
                UpperAnimCount = Player.Util.UsageAnimRight.Count;
                UpperAnimIndex = 0;

                Player.UsingUtil = true;
            }
			if(Time.time > useTime + Player.Util.Cd){
				Player.Util.Effect (0);
				useTime = Time.time;
			}
        }

        if (command == InputManager.Command.Use_Util_Left)
        {
            if (!Player.UsingWeapon && !Player.UsingUtil)
            {
                UpperAnimCount = Player.Util.UsageAnimLeft.Count;
                UpperAnimIndex = 0;

                Player.UsingUtil = true;
            }
			if(Time.time > useTime + Player.Util.Cd){
				Player.Util.Effect (0);
				useTime = Time.time;
			}
        }
    }

    private void UpdateLowerAnim()
    {
        LowerAnimIndex = (LowerAnimIndex + 1) % LowerAnimCount;
    }

    private void UpdateUpperAnim()
    {
        UpperAnimIndex = (UpperAnimIndex + 1) % UpperAnimCount;
    }

    private void AnimWalkRight()
    {
        LowerRenderer.sprite = Player.LowerAnimRight[LowerAnimIndex];

        if (!Player.UsingWeapon && !Player.UsingUtil)
            UpperRenderer.sprite = Player.UpperAnimRight[UpperAnimIndex];
    }

    private void AnimWalkLeft()
    {
        LowerRenderer.sprite = Player.LowerAnimLeft[LowerAnimIndex];

        if (!Player.UsingWeapon && !Player.UsingUtil) 
            UpperRenderer.sprite = Player.UpperAnimLeft[UpperAnimIndex];
    }

    private void AnimJumpRight()
    {
        LowerRenderer.sprite = Player.JumpAnimRight[LowerAnimIndex];

        if (!Player.UsingWeapon && !Player.UsingUtil) 
            UpperRenderer.sprite = null;
    }

    private void AnimJumpLeft()
    {
        LowerRenderer.sprite = Player.JumpAnimLeft[LowerAnimIndex];

        if (!Player.UsingWeapon && !Player.UsingUtil) 
            UpperRenderer.sprite = null;
    }

    private void AnimWeaponRight()
    {
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingWeapon = false;

        UpperRenderer.sprite = Player.Weapon.UsageAnimRight[UpperAnimIndex];
        UpdateUpperAnim();
    }

    private void AnimWeaponLeft()
    {
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingWeapon = false;

        UpperRenderer.sprite = Player.Weapon.UsageAnimLeft[UpperAnimIndex];
        UpdateUpperAnim();
    }

    private void AnimUtilRight()
    {
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingUtil = false;

        UpperRenderer.sprite = Player.Util.UsageAnimRight[UpperAnimIndex];
        UpdateUpperAnim();
    }

    private void AnimUtilLeft()
    {
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingUtil = false;

        UpperRenderer.sprite = Player.Util.UsageAnimLeft[UpperAnimIndex];
        UpdateUpperAnim();
    }
}
