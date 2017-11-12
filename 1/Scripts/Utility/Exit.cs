using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    public Transform hand;
    public Transform[] buttons;
    public World world;
    public AudioClip moveSound;
    public AudioClip okSound;
    int id = 0;

    internal GetExit ge;

    // Use this for initialization
    void Start()
    {
        world = FindObjectOfType<World>();
        id = 0;
        ge = FindObjectOfType<GetExit>();
        UpdatePosition();
    }

    // Update is called once per frame
    void Update()
    {
        // 選單選擇
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            id--;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            id++;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        // 確定
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (id)
            {
                // continue
                case 0:
                    Game.pause = false;
                    ge.on.SetActive(false);
                    break;
                // exit
                case 1:
                    Application.Quit();
                    break;
            }
            world.sound.PlaySE(okSound);
        }
    }

    void UpdatePosition()
    {
        Vector3 pos = hand.position;
        pos.y = buttons[id].position.y;
        pos.x = buttons[id].position.x;
        hand.position = pos;
    }
}
