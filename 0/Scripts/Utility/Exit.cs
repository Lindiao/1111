using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    public GameObject on;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Game.pause == true)
            {
                Game.pause = false;
                on.SetActive(false);
            }else {
                Game.pause = true;
                Game.player().GetComponent<Controller>().Move(0);
                on.SetActive(true);
            }
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
