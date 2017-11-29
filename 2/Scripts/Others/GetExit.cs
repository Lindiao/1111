using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetExit : MonoBehaviour {
    public GameObject on;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Game.pause == false)
            {
                Game.pause = true;
                Game.player().GetComponent<Controller>().Move(0);
                on.SetActive(true);
            }
        }
    }
}
