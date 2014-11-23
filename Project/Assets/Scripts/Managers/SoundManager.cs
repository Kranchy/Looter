using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public InputManager InputManager;
    public Player Player;

    public AudioClip WalkSound;
    public AudioClip JumpSound;

    public bool PlayingWalkSound { get; set; }
    public bool PlayingJumpSound { get; set; }
    public bool PlayingWeaponSound { get; set; }
    public bool PlayingUtilSound { get; set; }

	// Use this for initialization
	void Start ()
    {
        PlayingWalkSound = false;
        PlayingJumpSound = false;
        PlayingWeaponSound = false;
        PlayingUtilSound = false;
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
            if (!PlayingWalkSound)
            {
                audio.PlayOneShot(WalkSound);
                PlayingWalkSound = true;
                StartCoroutine(EndWalkSound());
            }
        }

        if (command == InputManager.Command.Walk_Left)
        {
            if (!PlayingWalkSound)
            {
                audio.PlayOneShot(WalkSound);
                PlayingWalkSound = true;
                StartCoroutine(EndWalkSound());
            }
        }

        if (command == InputManager.Command.Jump_Right)
        {
            if (!PlayingJumpSound && Player.OnGround)
            {
                PlayingJumpSound = true;
                audio.PlayOneShot(JumpSound);
                StartCoroutine(EndJumpSound());
            }
        }

        if (command == InputManager.Command.Jump_Left)
        {
            if (!PlayingJumpSound && Player.OnGround)
            {
                PlayingJumpSound = true;
                audio.PlayOneShot(JumpSound);
                StartCoroutine(EndJumpSound());
            }
        }

        if (command == InputManager.Command.Use_Weapon_Right)
        {
            if (!PlayingWeaponSound && Player.UsingWeapon)
            {
                audio.PlayOneShot(Player.Weapon.UsageSound);
                PlayingWeaponSound = true;
                StartCoroutine(EndWeaponSound());
            }
        }

        if (command == InputManager.Command.Use_Weapon_Left)
        {
            if (!PlayingWeaponSound && Player.UsingWeapon)
            {
                audio.PlayOneShot(Player.Weapon.UsageSound);
                PlayingWeaponSound = true;
                StartCoroutine(EndWeaponSound());
            }
        }

        if (command == InputManager.Command.Use_Util_Right)
        {
            if (!PlayingUtilSound && Player.UsingUtil)
            {
                audio.PlayOneShot(Player.Util.UsageSound);
                PlayingUtilSound = true;
                StartCoroutine(EndUtilSound());
            }
        }

        if (command == InputManager.Command.Use_Util_Left)
        {
            if (!PlayingUtilSound && Player.UsingUtil)
            {
                audio.PlayOneShot(Player.Util.UsageSound);
                PlayingUtilSound = true;
                StartCoroutine(EndUtilSound());
            }
        }
    }

    private IEnumerator EndWalkSound()
    {
        yield return new WaitForSeconds(WalkSound.length);
        PlayingWalkSound = false;
    }
    private IEnumerator EndJumpSound()
    {
        yield return new WaitForSeconds(JumpSound.length);
        PlayingJumpSound = false;
    }

    private IEnumerator EndWeaponSound()
    {
        yield return new WaitForSeconds(Player.Weapon.UsageSound.length);
        PlayingWeaponSound = false;
    }

    private IEnumerator EndUtilSound()
    {
        yield return new WaitForSeconds(Player.Util.UsageSound.length);
        PlayingUtilSound = false;
    }
}
