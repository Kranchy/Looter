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

	// Use this for initialization
	void Start ()
    {
        LowerAnimCount = Player.LowerAnimRight.Count;
        UpperAnimCount = Player.UpperAnimRight.Count;

        LowerAnimIndex = 0;
        UpperAnimIndex = 0;

        LowerRenderer.sprite = Player.LowerAnimRight[0];
        UpperRenderer.sprite = Player.UpperAnimRight[0];

        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/Items/Sword"));
        Sword sword = go.GetComponent("Sword") as Sword;
        Player.Weapon = sword;
	}
	
	// Update is called once per frame
	void Update ()
    {

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

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            UpdateUpperAnim();

            AnimWalkRight();
        }

        if (command == InputManager.Command.Walk_Left)
        {
            LowerAnimCount = Player.LowerAnimLeft.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            UpdateUpperAnim();

            AnimWalkLeft();
        }

        if (command == InputManager.Command.Jump_Right)
        {
            LowerAnimCount = Player.JumpAnimRight.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            UpdateUpperAnim();

            AnimJumpRight();
        }

        if (command == InputManager.Command.Jump_Left)
        {
            LowerAnimCount = Player.JumpAnimLeft.Count;

            if (Player.UsingWeapon) UpperAnimCount = Player.Weapon.UsageAnimRight.Count;
            else if (Player.UsingUtil) UpperAnimCount = Player.Util.UsageAnimRight.Count;
            else UpperAnimCount = LowerAnimCount;

            UpdateLowerAnim();
            UpdateUpperAnim();

            AnimJumpLeft();
        }

        if (command == InputManager.Command.Use_Weapon_Right)
        {
            UpperAnimCount = Player.Weapon.UsageAnimRight.Count;

            UpperAnimIndex = 0;
            AnimWeaponRight();
        }

        if (command == InputManager.Command.Use_Weapon_Left)
        {
            UpperAnimCount = Player.Weapon.UsageAnimLeft.Count;

            UpperAnimIndex = 0;
            AnimWeaponLeft();
        }

        if (command == InputManager.Command.Use_Util_Right)
        {
            UpperAnimCount = Player.Util.UsageAnimRight.Count;

            UpperAnimIndex = 0;
            AnimUtilRight();
        }

        if (command == InputManager.Command.Use_Util_Left)
        {
            UpperAnimCount = Player.Util.UsageAnimLeft.Count;

            UpperAnimIndex = 0;
            AnimUtilLeft();
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

        if (Player.UsingWeapon) AnimWeaponRight();
        else if (Player.UsingUtil) AnimUtilRight();
        else UpperRenderer.sprite = Player.UpperAnimRight[UpperAnimIndex];
    }

    private void AnimWalkLeft()
    {
        LowerRenderer.sprite = Player.LowerAnimLeft[LowerAnimIndex];

        if (Player.UsingWeapon) AnimWeaponLeft();
        else if (Player.UsingUtil) AnimUtilLeft();
        else UpperRenderer.sprite = Player.UpperAnimLeft[UpperAnimIndex];
    }

    private void AnimJumpRight()
    {
        LowerRenderer.sprite = Player.JumpAnimRight[LowerAnimIndex];

        if (Player.UsingWeapon) AnimWeaponRight();
        else if (Player.UsingUtil) AnimUtilRight();
        else UpperRenderer.sprite = null;
    }

    private void AnimJumpLeft()
    {
        LowerRenderer.sprite = Player.JumpAnimLeft[LowerAnimIndex];

        if (Player.UsingWeapon) AnimWeaponLeft();
        else if (Player.UsingUtil) AnimUtilLeft();
        else UpperRenderer.sprite = null;
    }

    private void AnimWeaponRight()
    {
        UpperRenderer.sprite = Player.Weapon.UsageAnimRight[UpperAnimIndex];
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingWeapon = false;
    }

    private void AnimWeaponLeft()
    {
        UpperRenderer.sprite = Player.Weapon.UsageAnimLeft[UpperAnimIndex];
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingWeapon = false;
    }

    private void AnimUtilRight()
    {
        UpperRenderer.sprite = Player.Util.UsageAnimRight[UpperAnimIndex];
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingUtil = false;
    }

    private void AnimUtilLeft()
    {
        UpperRenderer.sprite = Player.Util.UsageAnimLeft[UpperAnimIndex];
        if (UpperAnimIndex == UpperAnimCount - 1)
            Player.UsingUtil = false;
    }
}
