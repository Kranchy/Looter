using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour
{
    public GameObject NewGame;
    public GameObject Quit;

    private bool NewGameSelected { get; set; }
    private bool QuitSelected { get; set; }

    // Use this for initialization
    void Start()
    {
        NewGameSelected = false;
        QuitSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            NewGameSelected = true;
            QuitSelected = false;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            NewGameSelected = false;
            QuitSelected = true;
        }

        if (NewGameSelected)
        {
            NewGame.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);

            if (Input.GetAxis("Jump") > 0)
                Application.LoadLevel("MainScene");
        }

        if (!NewGameSelected)
        {
            NewGame.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        if(QuitSelected)
        {
            Quit.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);

            if (Input.GetAxis("Jump") > 0)
                Application.Quit();
        }

        if(!QuitSelected)
        {
            Quit.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
