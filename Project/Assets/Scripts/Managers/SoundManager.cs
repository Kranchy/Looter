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

	// Use this for initialization
	void Start ()
    {
        PlayingWalkSound = false;
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
        }

        if (command == InputManager.Command.Use_Weapon_Left)
        {
        }

        if (command == InputManager.Command.Use_Util_Right)
        {
        }

        if (command == InputManager.Command.Use_Util_Left)
        {
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
}
